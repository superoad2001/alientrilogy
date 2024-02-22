using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt13_al2 : MonoBehaviour
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
			manager.datosserial.niveltc = 13;
			manager.guardar();
			SceneManager.LoadScene("nivel13t_al2");
		}
	}
}
