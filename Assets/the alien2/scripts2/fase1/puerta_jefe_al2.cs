using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta_jefe_al2 : MonoBehaviour
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
			SceneManager.LoadScene("jefe1_al2");
		}
	}
}
