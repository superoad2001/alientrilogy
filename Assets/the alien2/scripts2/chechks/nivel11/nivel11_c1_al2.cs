using UnityEngine;

public class nivel11_c1_al2 : MonoBehaviour
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
		if (col.gameObject.tag == "Player" && manager.datosserial.nivel11ch1 == 0)
		{
			manager.datosserial.nivel11ch1 = 1;
			manager.datosserial.checkpoints++;
			manager.guardar();
			audio1.Play();

		}
	}
}
