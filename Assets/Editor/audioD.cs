using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public static class DialogueAudioCopier
{
    [MenuItem("Herramientas/Copiar audios de idioma 0")]
    public static void CopyAudios()
    {
        string assetsPath = Application.dataPath;
        string[] files = Directory.GetFiles(assetsPath, "*.*", SearchOption.AllDirectories);

        int modifiedCount = 0;

        foreach (string file in files)
        {
            if (!(file.EndsWith(".asset") || file.EndsWith(".prefab")))
                continue;

            string[] lines = File.ReadAllLines(file);
            string[] newLines = ProcessFile(lines, out bool changed);

            if (changed)
            {
                File.WriteAllLines(file, newLines);
                modifiedCount++;
                Debug.Log($"🎵 Audios copiados en: {file}");
            }
        }

        AssetDatabase.Refresh();
        Debug.Log($"✅ Proceso terminado. Archivos modificados: {modifiedCount}");
    }

    private static string[] ProcessFile(string[] lines, out bool changed)
    {
        changed = false;
        List<string> newLines = new List<string>(lines);

        List<string> baseAudioBlock = null;
        int baseIndent = 0;

        for (int i = 0; i < newLines.Count; i++)
        {
            string line = newLines[i];

            // Detectamos el bloque del idioma 0
            if (line.TrimStart().StartsWith("- languageEnum: 0"))
            {
                baseAudioBlock = new List<string>();
                baseIndent = line.Length - line.TrimStart().Length;
                int j = i + 1;

                while (j < newLines.Count && !newLines[j].TrimStart().StartsWith("- languageEnum:"))
                {
                    if (newLines[j].TrimStart().StartsWith("LanguageGenericType:") || newLines[j].TrimStart().StartsWith("audio:"))
                        baseAudioBlock.Add(newLines[j].Substring(baseIndent));
                    j++;
                }
            }

            // Rellenamos en otros idiomas
            if (line.TrimStart().StartsWith("- languageEnum:") && !line.TrimStart().StartsWith("- languageEnum: 0") && baseAudioBlock != null)
            {
                int j = i + 1;

                while (j < newLines.Count && !newLines[j].TrimStart().StartsWith("- languageEnum:"))
                {
                    string trimmed = newLines[j].TrimStart();
                    if (trimmed.StartsWith("LanguageGenericType:") || trimmed.StartsWith("audio:"))
                    {
                        if (trimmed == "LanguageGenericType:" || trimmed == "LanguageGenericType: {}" || trimmed == "LanguageGenericType: null" ||
                            trimmed == "audio:" || trimmed == "audio: {}" || trimmed == "audio: null" || trimmed.Contains("{fileID: 0}"))
                        {
                            int indent = newLines[j].Length - newLines[j].TrimStart().Length;
                            string prefix = new string(' ', indent);

                            for (int b = 0; b < baseAudioBlock.Count; b++)
                                newLines[j + b] = prefix + baseAudioBlock[b].TrimStart();

                            changed = true;
                        }
                    }
                    j++;
                }
            }
        }

        return newLines.ToArray();
    }
}