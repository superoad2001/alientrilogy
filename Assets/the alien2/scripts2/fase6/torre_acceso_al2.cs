using UnityEngine;
using UnityEngine.SceneManagement;

public class torre_acceso_al2 : MonoBehaviour
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
			SceneManager.LoadScene("torre_al2");
		}
	}
}
