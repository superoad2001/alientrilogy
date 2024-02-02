using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt12: MonoBehaviour
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
			SceneManager.LoadScene("nivel12t_al2");
		}
	}
}
