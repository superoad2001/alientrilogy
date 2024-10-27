using UnityEngine;
using UnityEngine.SceneManagement;

public class jefe_acceso1_al2 : MonoBehaviour
{

	private void Start()
	{

	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("jefecin_al2");
		}
	}
	private void OnTriggerEnter(Collider col)
	{
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
		if (col.gameObject.tag == "Player")
		{
			jugador.blanco = 29;
            jugador.objeto = 0;
		}
	}
    private void OnTriggerExit(Collider col)
	{
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
		if (col.gameObject.tag == "Player" )
		{
			jugador.blanco = 30;
            jugador.objeto = 0;
		}
	}
}
