using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt14_al2 : MonoBehaviour
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
			manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
			manager.datosserial.niveltc = 14;
			manager.guardar();
			SceneManager.LoadScene("nivel14t_al2");
		}
	}
}
