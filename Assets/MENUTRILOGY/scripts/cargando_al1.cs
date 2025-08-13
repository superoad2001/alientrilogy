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
            // Actualizar la barra de progreso
            barraProgreso.fillAmount = operacionCarga.progress;
            
            // Esperar al siguiente frame
            yield return null;
        }
        
        // La carga llegó al 90%, completar la barra hasta el 100%
        barraProgreso.fillAmount = 1f;
        
        // Esperar un momento para que el usuario vea la barra completa
        yield return new WaitForSeconds(0.4f);
        
        // Activar la escena
        operacionCarga.allowSceneActivation = true;
    }
}
