using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class teleportautom_al1 : MonoBehaviour
{
	public manager_al1 manager;
    public string ubi;


	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                SceneManager.LoadScene("carga");
		}
	}

}
