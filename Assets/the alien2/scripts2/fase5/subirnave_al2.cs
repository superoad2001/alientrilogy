using UnityEngine;
using UnityEngine.SceneManagement;

public class subirnave_al2 : MonoBehaviour
{
	public manager_al2 manager;

	private void Start()
	{

	}

	private void Update()
	{
	}
	private void OnTriggerEnter(Collider col)
	{
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador_al2 jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.tengonave == 1)
		{
			jugador.blanco = 24;
            jugador.objeto = 0;
		}
	}
    private void OnTriggerExit(Collider col)
	{
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador_al2 jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.tengonave == 1)
		{
			jugador.blanco = 0;
            jugador.objeto = 0;
		}
	}
}
