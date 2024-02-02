using UnityEngine;

public class trozo1nv14_al2 : MonoBehaviour
{

	public AudioSource audio1;
	private void Start()
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (manager.datosserial.trozo1nv14 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (manager.datosserial.trozo1nv14 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player" && manager.datosserial.trozo1nv14 == 0)
		{
			manager.datosserial.trozo1nv14 = 1;
			manager.datosserial.trozosnv14++;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
