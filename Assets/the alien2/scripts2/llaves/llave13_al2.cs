using UnityEngine;
using UnityEngine.SceneManagement;

public class llave13_al2 : MonoBehaviour
{
	public manager_al2 manager;
	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.llaveN13 == 0)
		{
			manager.datosserial.llaveN13 = 1;
			manager.datosserial.llaves++;
			manager.guardar();
			SceneManager.LoadScene("mundo_abierto_al2");

		}
		if (col.gameObject.tag == "Player" && manager.datosserial.llaveN13 == 1)
		{
			SceneManager.LoadScene("mundo_abierto_al2");

		}
	}
}
