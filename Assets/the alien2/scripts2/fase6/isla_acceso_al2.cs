using UnityEngine;
using UnityEngine.SceneManagement;

public class isla_acceso_al2 : MonoBehaviour
{
	public manager_al2 manager;

	private void Start()
	{

	}

	private void Update()
	{
	}

	private void OnTriggerStay(Collider col)
	{
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
		if (col.gameObject.tag == "Player" && jugador.blanco == 29 )
		{
			jugador.blanco = 27;
            jugador.objeto = 0;
		}
	}
    private void OnTriggerExit(Collider col)
	{
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
		if (col.gameObject.tag == "Player")
		{
			jugador.blanco = 30;
            jugador.objeto = 0;
		}
	}
}
