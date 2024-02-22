using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt1_al2 : MonoBehaviour
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
			manager.datosserial.niveltc = 1;
			manager.guardar();
			SceneManager.LoadScene("nivel1t_al2");
		}
	}
}
