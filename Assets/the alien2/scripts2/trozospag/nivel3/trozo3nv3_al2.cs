using UnityEngine;

public class trozo3nv3_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public AudioSource audio1;
	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo3nv3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.trozo3nv3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo3nv3 == 0)
		{
			manager.datosserial.trozo3nv3 = 1;
			manager.datosserial.trozosnv3++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
