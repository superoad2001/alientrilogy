using UnityEngine;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public class CleanDontSaveFlagsBeforeBuild : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
        string[] guids = AssetDatabase.FindAssets("t:Object");
        int count = 0;

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Object asset = AssetDatabase.LoadMainAssetAtPath(path);
            if (asset == null) continue;

            // Detecta solo si tiene flags de DontSave
            // Detecta solo si tiene flags de DontSave
            if ((asset.hideFlags & HideFlags.DontSaveInEditor) != 0 ||
                (asset.hideFlags & HideFlags.DontSaveInBuild) != 0 ||
                (asset.hideFlags & HideFlags.DontSave) != 0) // cubre runtime en Unity viejo
            {
                Debug.LogWarning($"[Build] Corrigiendo {asset.name} en {path} (flags: {asset.hideFlags})");

                // Elimina solo los DontSave, conserva los demás (ej. HideInInspector)
                asset.hideFlags &= ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontSave);

                EditorUtility.SetDirty(asset);
                count++;
            }
        }

        if (count > 0)
        {
            AssetDatabase.SaveAssets();
            Debug.Log($"✅ Se corrigieron {count} assets con DontSave antes de la build.");
        }
        else
        {
            Debug.Log("👌 No se encontraron assets con DontSave problemáticos.");
        }
    }
}