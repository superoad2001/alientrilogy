using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nivel1_c2_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public AudioSource audio1;

	private void Start()
	{
		
	}

	private void Update()
	{

	}

	private void OnTriggerEnter(Collider col)
	{
		
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		manager.datosserial.nivel1c = 3;
		if (col.gameObject.tag == "Player" && manager.datosserial.nivel1ch2 == 0)
		{
			manager.datosserial.nivel1ch2 = 1;
			manager.datosserial.checkpoints++;
			manager.guardar();
			audio1.Play();

		}
	}
}
