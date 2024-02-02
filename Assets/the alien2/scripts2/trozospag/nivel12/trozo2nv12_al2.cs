using UnityEngine;

public class trozo2nv12_al2 : MonoBehaviour
{
	public AudioSource audio1;
	private void Start()
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (manager.datosserial.trozo2nv12 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (manager.datosserial.trozo2nv12 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo2nv12 == 0)
		{
			manager.datosserial.trozo2nv12 = 1;
			manager.datosserial.trozosnv12++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
