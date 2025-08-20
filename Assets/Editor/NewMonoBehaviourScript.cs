using UnityEngine;
using UnityEditor;

public class ClearAllHideFlags : EditorWindow
{
    [MenuItem("Tools/Limpiar HideFlags en todo el proyecto")]
    public static void ClearAll()
    {
        // Busca todos los assets del proyecto
        string[] guids = AssetDatabase.FindAssets("t:Object");

        int count = 0;
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Object asset = AssetDatabase.LoadMainAssetAtPath(path);

            if (asset == null) continue;

            if (asset.hideFlags != HideFlags.None)
            {
                Debug.LogWarning($"Corrigiendo: {asset.name} en {path} (flags: {asset.hideFlags})");
                asset.hideFlags = HideFlags.None;
                EditorUtility.SetDirty(asset);
                count++;
            }
        }

        AssetDatabase.SaveAssets();
        Debug.Log($"✅ Limpieza completada. {count} assets corregidos.");
    }
}