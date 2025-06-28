using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class checkpoint_al1 : MonoBehaviour
{
	public manager_al1 manager;
    public int ubi;
	public AudioSource son;


	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
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
