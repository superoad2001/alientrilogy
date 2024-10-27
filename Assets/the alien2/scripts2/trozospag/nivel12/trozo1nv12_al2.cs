using UnityEngine;

public class trozo1nv12_al2 : MonoBehaviour
{

	public AudioSource audio1;
	private void Start()
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo1nv12 == 1)
		{
			UnityEngine.Object.Destroy(this.gameObject);
		}
	}

	private void Update()
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo1nv12 == 1)
		{
			UnityEngine.Object.Destroy(this.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo1nv12 == 0)
		{
			manager.datosserial.trozo1nv12 = 1;
			manager.datosserial.trozosnv12++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
