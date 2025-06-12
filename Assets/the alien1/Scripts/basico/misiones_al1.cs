using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class misiones_al1
{
    public string[] misiones = new string[200];
    public string[] misionesdesc = new string[200];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        misiones[0] = "salida";
        misiones[1] = "holomuerte";
        misiones[2] = "entrenamiento";
        misiones[3] = "novato recadero";
        misiones[4] = "agilizado";
        misiones[5] = "pocimero";
        misiones[6] = "el control";



        misionesdesc[0] = "busca una salida del asteroide";
        misionesdesc[1] = "vence al jefe";
        misionesdesc[2] = "supera los retos de tu salvador en el portal";
        misionesdesc[3] = "consigue la camara de fotos del extraño";
        misionesdesc[4] = "consigue el dash en la tienda";
        misionesdesc[5] = "conigue una pocion en la tienda";
        misionesdesc[6] = "consigue todas las notas";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
