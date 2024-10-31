using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt1_al2 : MonoBehaviour
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
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.niveltc = 1;
			manager.guardar();
			SceneManager.LoadScene("nivel1t_al2");
		}
	}
}
