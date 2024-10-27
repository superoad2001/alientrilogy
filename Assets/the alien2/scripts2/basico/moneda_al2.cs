using UnityEngine;

public class moneda_al2 : MonoBehaviour
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
			manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
			manager.datosserial.monedas++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
