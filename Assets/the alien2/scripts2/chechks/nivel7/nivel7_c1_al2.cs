using UnityEngine;

public class nivel7_c1_al2 : MonoBehaviour
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
		
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		manager.datosserial.nivel7c = 2;
		if (col.gameObject.tag == "Player" && manager.datosserial.nivel7ch1 == 0)
		{
			manager.datosserial.nivel7ch1 = 1;
			manager.datosserial.checkpoints++;
			manager.guardar();
			audio1.Play();

		}
	}
}
