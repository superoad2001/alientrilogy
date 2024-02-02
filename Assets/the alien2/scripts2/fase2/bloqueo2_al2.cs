using UnityEngine;

public class bloqueo2_al2 : MonoBehaviour
{
	public AudioSource audio1;

	public AudioSource audio2;

	public AudioSource audioesp;
	public AudioSource audioen;
	public AudioSource audiocat;

	private void Start()
	{
		
	}

	private void Update()
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if(manager.datosserial.block2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player")
		{
			if(manager.datosserial.llaves == 4 && manager.datosserial.block2 == 0)
			{
				manager.datosserial.llaves = 0;
				manager.datosserial.block2 = 1;
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
			if(manager.datosserial.llaves < 4 && manager.datosserial.block2 == 0)
			{
				audio2.Play();
			}
		}
	}
}
