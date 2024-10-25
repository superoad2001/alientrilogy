using UnityEngine;
using UnityEngine.SceneManagement;

public class tiendas_acceso_al2 : MonoBehaviour
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
			SceneManager.LoadScene("tiendas_al2");
		}
	}
}
