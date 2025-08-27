using UnityEngine;
using UnityEditor;
using System.IO;

public class CleanCache : Editor
{
    [MenuItem("Tools/Limpiar Caché de Compilación")]
    public static void CleanCompileCache()
    {
        string libraryPath = Path.Combine(Directory.GetCurrentDirectory(), "Library");

        if (EditorUtility.DisplayDialog(
            "Limpiar caché",
            "Esto borrará la carpeta 'Library' y obligará a Unity a recompilar todo.\n\n" +
            "La próxima apertura del proyecto puede tardar bastante.\n\n¿Quieres continuar?",
            "Sí, borrar",
            "Cancelar"))
        {
            try
            {
                if (Directory.Exists(libraryPath))
                {
                    Directory.Delete(libraryPath, true);
                    File.Delete(libraryPath + ".meta");
                }

                EditorUtility.DisplayDialog("Éxito", "Caché borrada. Reinicia Unity.", "OK");
            }
            catch (System.Exception ex)
            {
                EditorUtility.DisplayDialog("Error", "No se pudo borrar la caché:\n" + ex.Message, "OK");
            }
        }
    }
}