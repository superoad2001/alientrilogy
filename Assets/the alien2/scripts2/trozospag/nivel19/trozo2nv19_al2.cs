using UnityEngine;

public class trozo2nv19_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public AudioSource audio1;
	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo2nv19 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo2nv19 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo2nv19 == 0)
		{
			manager.datosserial.trozo2nv19 = 1;
			manager.datosserial.trozosnv19++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
