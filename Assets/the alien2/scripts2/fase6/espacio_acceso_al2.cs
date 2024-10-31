using UnityEngine;
using UnityEngine.SceneManagement;

public class espacio_acceso_al2 : MonoBehaviour
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
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("espacio_al2");
		}
	}
}
