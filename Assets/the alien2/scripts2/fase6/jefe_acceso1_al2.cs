using UnityEngine;
using UnityEngine.SceneManagement;

public class jefe_acceso1_al2 : MonoBehaviour
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
			SceneManager.LoadScene("jefecin");
		}
	}
}
