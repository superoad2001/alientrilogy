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
					
					if(posch1.transform.eulerAngles.y == 90f)
					{
						jugador.transform.eulerAngles = posch1.transform.eulerAngles;
						jugador.dimensiion = true;
						jugador.jugpos = jugador.transform.position.x;
					}
					else
					{
						jugador.transform.eulerAngles = posch1.transform.eulerAngles;
						jugador.dimensiion = false;
						jugador.jugpos = jugador.transform.position.z;
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
					if(posch1.transform.eulerAngles.y == 90f)
					{
						jugador.transform.eulerAngles = posch2.transform.eulerAngles;
						jugador.dimensiion = true;
						jugador.jugpos = jugador.transform.position.x;
					}
					else
					{
						jugador.transform.eulerAngles = posch2.transform.eulerAngles;
						jugador.dimensiion = false;
						jugador.jugpos = jugador.transform.position.z;
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
