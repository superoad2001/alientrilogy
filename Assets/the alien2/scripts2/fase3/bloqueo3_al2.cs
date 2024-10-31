using UnityEngine;

public class bloqueo3_al2 : MonoBehaviour
{
	public AudioSource audio1;

	public AudioSource audio2;

	public AudioSource audioesp;
	public AudioSource audioen;
	public AudioSource audiocat;

	public manager_al2 manager;

	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
	}

	private void Update()
	{
		if(manager.datosserial.block3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player")
		{
			if(manager.datosserial.llaves == 4 && manager.datosserial.block3 == 0)
			{
				manager.datosserial.llaves = 0;
				manager.datosserial.block3 = 1;
				manager.guardar();
				audio1.Play();
				if(manager.datosconfig.idioma == "es")
				{audioesp.Play();}
				if(manager.datosconfig.idioma == "cat")
				{audiocat.Play();}
				if(manager.datosconfig.idioma == "en")
				{audioen.Play();}
				UnityEngine.Object.Destroy(base.gameObject);
			}
			if(manager.datosserial.llaves < 4 && manager.datosserial.block3 == 0)
			{
				audio2.Play();
			}
		}
	}
}
