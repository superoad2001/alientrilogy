using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt18_al2 : MonoBehaviour
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
			manager.datosserial.niveltc = 18;
			manager.guardar();
			SceneManager.LoadScene("nivel18t_al2");
		}
	}
}
