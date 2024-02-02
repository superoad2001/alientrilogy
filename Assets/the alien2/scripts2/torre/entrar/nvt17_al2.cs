using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt17_al2 : MonoBehaviour
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
			SceneManager.LoadScene("nivel17t_al2");
		}
	}
}
