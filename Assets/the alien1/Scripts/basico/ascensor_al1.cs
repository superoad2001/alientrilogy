using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class ascensor_al1 : MonoBehaviour
{
	public manager_al1 manager;
    public jugador_al1 jugador;
    public GameObject arr;
    public GameObject abj;
    public string TP;
    // Start is called before the first frame update
    void Start()
    {
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
    }

    // Update is called once per frame
    void Update()
    {
        
        if(jugador.subir == true)
        {
            base.transform.Translate(Vector3.up * 4f * Time.deltaTime);
        }
        if(jugador.bajar == true)
        {
            base.transform.Translate(Vector3.up * -4f * Time.deltaTime);
        }

        if(manager.piso == 1)
        {
            if(manager.datosserial.jefeV[0] == false)
            {
                arr.SetActive(false);
            }
            else
            {
                arr.SetActive(true);
            }

            if(manager.datosserial.tengollave0 == false)
            {
                abj.SetActive(false);
            }
            else
            {
                abj.SetActive(true);
            }
        }
    }
}
