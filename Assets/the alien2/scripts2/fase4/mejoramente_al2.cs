using UnityEngine;
using UnityEngine.SceneManagement;

public class mejoramente_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public AudioSource audio1;

	private void Start()
	{

	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
			manager.datosserial.tengomental = 1;
			manager.guardar();
			audio1.Play();
			SceneManager.LoadScene("mundo_abierto_al2");
		}
	}
}
