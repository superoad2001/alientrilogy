using UnityEngine;
using UnityEngine.SceneManagement;

public class torre_acceso_al2 : MonoBehaviour
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
        jugador_al2 jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		if (col.gameObject.tag == "Player" && jugador.blanco == 29)
		{
			jugador.blanco = 26;
            jugador.objeto = 0;
		}
	}
    private void OnTriggerExit(Collider col)
	{
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador_al2 jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		if (col.gameObject.tag == "Player")
		{
			jugador.blanco = 30;
            jugador.objeto = 0;
		}
	}
}
