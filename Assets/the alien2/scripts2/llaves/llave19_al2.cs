using UnityEngine;
using UnityEngine.SceneManagement;

public class llave19_al2 : MonoBehaviour
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
		if (col.gameObject.tag == "Player" && manager.datosserial.llaveN19 == 0)
		{
			manager.datosserial.llaveN19 = 1;
			manager.datosserial.llaves++;
			manager.guardar();
			SceneManager.LoadScene("mundo_abierto_al2");

		}
		if (col.gameObject.tag == "Player" && manager.datosserial.llaveN19 == 1)
		{
			SceneManager.LoadScene("mundo_abierto_al2");

		}
	}
}
