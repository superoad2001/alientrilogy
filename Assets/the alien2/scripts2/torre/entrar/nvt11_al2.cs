using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt11_al2 : MonoBehaviour
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
			manager.datosserial.niveltc = 11;
			manager.guardar();
			SceneManager.LoadScene("nivel11t_al2");
		}
	}
}
