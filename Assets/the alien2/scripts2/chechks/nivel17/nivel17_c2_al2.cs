using UnityEngine;

public class nivel17_c2_al2 : MonoBehaviour
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
		
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player" && manager.datosserial.nivel17ch2 == 0)
		{
			manager.datosserial.nivel17ch2 = 1;
			manager.guardar();
			audio1.Play();

		}
	}
}
