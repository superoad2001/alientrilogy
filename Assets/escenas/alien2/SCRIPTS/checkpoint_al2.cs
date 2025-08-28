using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class checkpoint_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public int ubi;
	public AudioSource son;


	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		this.gameObject.GetComponent<MeshRenderer>().enabled = false;
	}

    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			son.Play();
			manager.datosserial.actual_checkpoint = ubi;
			manager.guardar();

		}
	}

}
