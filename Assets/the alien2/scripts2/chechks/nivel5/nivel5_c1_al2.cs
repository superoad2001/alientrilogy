using UnityEngine;

public class nivel5_c1_al2 : MonoBehaviour
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
		if (col.gameObject.tag == "Player" && manager.datosserial.nivel5ch1 == 0)
		{
			manager.datosserial.nivel5ch1 = 1;
			manager.guardar();
			audio1.Play();

		}
	}
}
