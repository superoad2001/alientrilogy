using UnityEngine;
using UnityEngine.SceneManagement;

public class mundo_acceso_al2 : MonoBehaviour
{

	private void Start()
	{

	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.respawntipo = 5;
			manager.datosserial.univel = 0;
			manager.guardar();
			SceneManager.LoadScene("mundo_abierto_al2");
			
		}
	}
}
