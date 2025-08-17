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
	public GameObject model;

	public jugador_al1 jugador;



	public void carga()
	{
		
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if (manager.nivelact == true)
		{
			if (ubi == 1)
			{
				jugador.transform.position = posch1.transform.position + new Vector3(0, 4, 0);
				if( jugador.modo == "3D" )
				{
					jugador.transform.eulerAngles = posch1.transform.eulerAngles;
				}
				if(jugador.modo == "2D")
				{
					
					if(posch1.transform.eulerAngles.y == 0f)
					{
						jugador.transform.eulerAngles = new Vector3(0,90,0);
						jugador.dimensiion = true;
						jugador.jugpos = jugador.transform.position.x;
						jugador.girodir = 270;
						model.transform.localEulerAngles = new Vector3(0,270,0);
					}
					else if(posch1.transform.eulerAngles.y == 180)
					{
						jugador.transform.eulerAngles = new Vector3(0,90,0);
						jugador.dimensiion = true;
						jugador.jugpos = jugador.transform.position.x;
						jugador.girodir = 90;
						model.transform.localEulerAngles = new Vector3(0,90,0);
					}
					else if(posch1.transform.eulerAngles.y == 90)
					{
						jugador.transform.eulerAngles = new Vector3(0,0,0);
						jugador.dimensiion = false;
						jugador.jugpos = jugador.transform.position.z;
						jugador.girodir = 90;
						model.transform.localEulerAngles = new Vector3(0,90,0);
					}
					else if(posch1.transform.eulerAngles.y == 270)
					{
						jugador.transform.eulerAngles = new Vector3(0,0,0);
						jugador.dimensiion = false;
						jugador.jugpos = jugador.transform.position.z;
						jugador.girodir = 270;
						model.transform.localEulerAngles = new Vector3(0,270,0);
					}
					
					

				}
			}
			if (manager.datosserial.actual_checkpoint == 2)
			{
				jugador.transform.position = posch2.transform.position + new Vector3(0, 4, 0);
				if(jugador.modo == "3D" )
				{
					jugador.transform.eulerAngles = posch2.transform.eulerAngles;
				}


				if(jugador.modo == "2D")
				{
					if(posch2.transform.eulerAngles.y == 0f)
					{
						jugador.transform.eulerAngles = new Vector3(0,90,0);
						jugador.dimensiion = true;
						jugador.jugpos = jugador.transform.position.x;
						jugador.girodir = 270;
						model.transform.localEulerAngles = new Vector3(0,270,0);
					}
					else if(posch2.transform.eulerAngles.y == 180)
					{
						jugador.transform.eulerAngles = new Vector3(0,90,0);
						jugador.dimensiion = true;
						jugador.jugpos = jugador.transform.position.x;
						jugador.girodir = 90;
						model.transform.localEulerAngles = new Vector3(0,90,0);
					}
					else if(posch2.transform.eulerAngles.y == 90)
					{
						jugador.transform.eulerAngles = new Vector3(0,0,0);
						jugador.dimensiion = false;
						jugador.jugpos = jugador.transform.position.z;
						jugador.girodir = 90;
						model.transform.localEulerAngles = new Vector3(0,90,0);
					}
					else if(posch2.transform.eulerAngles.y == 270)
					{
						jugador.transform.eulerAngles = new Vector3(0,0,0);
						jugador.dimensiion = false;
						jugador.jugpos = jugador.transform.position.z;
						jugador.girodir = 270;
						model.transform.localEulerAngles = new Vector3(0,270,0);
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
