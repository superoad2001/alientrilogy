using UnityEngine;

public class trozo1nv7_al2 : MonoBehaviour
{
	public manager_al2 manager;

	public AudioSource audio1;
	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo1nv7 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo1nv7 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo1nv7 == 0)
		{
			manager.datosserial.trozo1nv7 = 1;
			manager.datosserial.trozosnv7++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
