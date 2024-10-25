using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta_jefe2_al2 : MonoBehaviour
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
			SceneManager.LoadScene("jefe2_al2");
		}
	}
}
