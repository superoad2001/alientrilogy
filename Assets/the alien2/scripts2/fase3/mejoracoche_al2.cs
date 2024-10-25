using UnityEngine;
using UnityEngine.SceneManagement;

public class mejoracoche_al2 : MonoBehaviour
{
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
			manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
			manager.datosserial.tengocoche = 1;
			manager.guardar();
			audio1.Play();
			SceneManager.LoadScene("mundo_abierto_al2");
		}
	}
}
