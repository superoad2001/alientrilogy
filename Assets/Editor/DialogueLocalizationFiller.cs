using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class DialogueYamlFiller : Editor
{
    [MenuItem("Herramientas/Backup + Rellenar idiomas YAML")]
    public static void BackupAndFill()
    {
        string assetsPath = Application.dataPath;
        string[] files = Directory.GetFiles(assetsPath, "*.*", SearchOption.AllDirectories);

        int modifiedCount = 0;

        foreach (string file in files)
        {
            if (!(file.EndsWith(".asset") || file.EndsWith(".prefab")))
                continue;

            string[] lines = File.ReadAllLines(file);

            bool changed;
            string[] newLines = FillLanguages(lines, out changed);

            if (changed)
            {
                File.WriteAllLines(file, newLines);
                modifiedCount++;
                Debug.Log($"✅ Modificado: {file}");
            }
        }

        AssetDatabase.Refresh();
        Debug.Log($"🔄 Proceso terminado. Archivos modificados: {modifiedCount}");
    }

    private static string[] FillLanguages(string[] lines, out bool changed)
    {
        changed = false;
        List<string> newLines = new List<string>(lines);
        List<string> baseBlock = null;

        for (int i = 0; i < newLines.Count; i++)
        {
            string line = newLines[i];

            if (line.TrimStart().StartsWith("- languageEnum: 0"))
            {
                baseBlock = new List<string>();
                int j = i + 1;
                while (j < newLines.Count && !newLines[j].TrimStart().StartsWith("- languageEnum:"))
                {
                    baseBlock.Add(newLines[j]);
                    j++;
                }
            }

            if (line.TrimStart().StartsWith("- languageEnum:") && !line.TrimStart().StartsWith("- languageEnum: 0") && baseBlock != null)
            {
                int j = i + 1;
                bool needsCopy = false;

                if (j < newLines.Count && newLines[j].Trim().StartsWith("LanguageGenericType:"))
                {
                    string val = newLines[j].Trim();
                    if (val == "LanguageGenericType:" || val == "LanguageGenericType: {}" || val == "LanguageGenericType: null")
                        needsCopy = true;
                }

                if (needsCopy)
                {
                    int indent = newLines[i].Length - newLines[i].TrimStart().Length;
                    string prefix = new string(' ', indent + 2);

                    // Borrar línea vacía
                    if (j < newLines.Count)
                        newLines.RemoveAt(j);

                    // Insertar bloque base con sangría
                    for (int b = 0; b < baseBlock.Count; b++)
                        newLines.Insert(j + b, prefix + baseBlock[b].TrimStart());

                    changed = true;
                }
            }
        }

        return newLines.ToArray();
    }
}