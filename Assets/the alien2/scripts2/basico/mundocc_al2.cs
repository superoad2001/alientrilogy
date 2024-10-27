using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class mundocc_al2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.tengocoche == 1)
		{
			jugador.blanco = 23;
            jugador.objeto = 0;
		}
	}
    private void OnTriggerExit(Collider col)
	{
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.tengocoche == 1)
		{
			jugador.blanco = 0;
            jugador.objeto = 0;
		}
	}
}
