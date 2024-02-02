using UnityEngine;
using UnityEngine.SceneManagement;

public class rey_al2 : MonoBehaviour
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
			SceneManager.LoadScene("sala_del_rey_al2");
		}
	}
}
