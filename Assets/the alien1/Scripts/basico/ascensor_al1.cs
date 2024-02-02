using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEngine.UI;

public class ascensor_al1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jugador_al1 jugador = UnityEngine.Object.FindObjectOfType<jugador_al1>();
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
