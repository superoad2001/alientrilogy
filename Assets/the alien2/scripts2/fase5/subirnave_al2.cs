using UnityEngine;
using UnityEngine.SceneManagement;

public class subirnave_al2 : MonoBehaviour
{

	private void Start()
	{

	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player" && manager.datosserial.tengonave == 1)
		{
			SceneManager.LoadScene("espacio_c_al2");
		}
	}
}
