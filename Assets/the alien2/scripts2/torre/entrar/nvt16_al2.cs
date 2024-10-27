using UnityEngine;
using UnityEngine.SceneManagement;

public class nvt16_al2 : MonoBehaviour
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
			manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
			manager.datosserial.niveltc = 16;
			manager.guardar();
			SceneManager.LoadScene("nivel16t_al2");
		}
	}
}
