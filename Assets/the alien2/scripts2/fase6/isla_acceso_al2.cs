using UnityEngine;
using UnityEngine.SceneManagement;

public class isla_acceso_al2 : MonoBehaviour
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
			SceneManager.LoadScene("diarios_c_al2");
		}
	}
}
