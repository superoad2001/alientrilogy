using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt6_al2 : MonoBehaviour
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
			manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
			manager.datosserial.niveltc = 6;
			manager.guardar();
			SceneManager.LoadScene("nivel6t_al2");
		}
	}
}
