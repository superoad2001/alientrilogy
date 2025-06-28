using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class manager_nivel_al1 : MonoBehaviour
{
	public manager_al1 manager;
    public int ubi;
	public GameObject posch1;
	public GameObject posch2;

	public jugador_al1 jugador;



	private void Start()
	{
		
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if (manager.nivelact == true)
		{
			if (manager.datosserial.actual_checkpoint == 1)
			{
				jugador.transform.position = posch1.transform.position + new Vector3(0, 4, 0);
				if(manager.juego == 4)
				{
					jugador.transform.eulerAngles = posch1.transform.eulerAngles;
				}
				if(manager.juego == 3)
				{
					//jugador.camara.transform.eulerAngles = jugador.transform.eulerAngles + new Vector3(0, 90, 0);
					if(posch1.transform.eulerAngles.y == 90f)
					{
						jugador.dimensiion = true;
					}
					else
					{
						jugador.dimensiion = false;
					}
				}
			}
			if (manager.datosserial.actual_checkpoint == 2)
			{
				jugador.transform.position = posch2.transform.position + new Vector3(0, 4, 0);
				if(manager.juego == 4)
				{
					jugador.transform.eulerAngles = posch2.transform.eulerAngles;
				}
				if(manager.juego == 3)
				{
					if(posch2.transform.eulerAngles.y == 90f)
					{
						jugador.dimensiion = true;
					}
					else
					{
						jugador.dimensiion = false;
					}
				}
			}
		}
	}


    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void Update()
    {
        
    }


}
