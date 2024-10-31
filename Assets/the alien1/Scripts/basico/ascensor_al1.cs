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
    // Start is called before the first frame update
    void Start()
    {
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
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
    }
}
