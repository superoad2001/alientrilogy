using UnityEngine;

public class trozo2nv4_al2 : MonoBehaviour
{
	public AudioSource audio1;
	private void Start()
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo2nv4 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo2nv4 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo2nv4 == 0)
		{
			manager.datosserial.trozo2nv4 = 1;
			manager.datosserial.trozosnv4++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
