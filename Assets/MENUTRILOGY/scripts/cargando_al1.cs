using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cargando_al1 : MonoBehaviour
{

    public Image barraProgreso;
    public managerBASE manager;
    public string escenaACargar;

    
    void Start()
    {
        escenaACargar = manager.datosconfig.carga;


        // Iniciar la barra en 0
        barraProgreso.fillAmount = 0;
        // Iniciar la carga
        StartCoroutine(CargarEscenaAsync());

    }
    
    IEnumerator CargarEscenaAsync()
    {
        // Iniciar la carga asíncrona de la escena
        AsyncOperation operacionCarga = SceneManager.LoadSceneAsync(manager.datosconfig.carga);
        
        // No permitir que la escena se active hasta que lo indiquemos
        operacionCarga.allowSceneActivation = false;
        
        // Mientras la carga no haya llegado al 90%
        while (operacionCarga.progress < 0.9f)
        {
            // Aquí puedes actualizar una barra de progreso
            barraProgreso.fillAmount = Mathf.Clamp01(operacionCarga.progress / 0.9f);
            // Actualizar UI con el progreso
            yield return null;
        }

        // Activar la escena cuando esté lista
        operacionCarga.allowSceneActivation = true;
        // La carga llegó al 90%, completar la barra hasta el 100%
        barraProgreso.fillAmount = 1f;
        
        // Esperar un momento para que el usuario vea la barra completa
        yield return new WaitForSeconds(0.4f);
        
    }
}
