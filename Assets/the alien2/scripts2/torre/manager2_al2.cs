using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager2_al2 : MonoBehaviour
{
    
    public float contador = 0;
    public Text crono;
    public Text nv1;
    public Text nv2;
    public Text nv3;
    public Text nv4;
    public Text nv5;
    public Text nv6;
    public Text nv7;
    public Text nv8;
    public Text nv9;
    public Text nv10;
    public Text nv11;
    public Text nv12;
    public Text nv13;
    public Text nv14;
    public Text nv15;
    public Text nv16;
    public Text nv17;
    public Text nv18;
    public Text nv19;
    public Text nv20;

    public datos2 datosserial;

    public manager_al2 manager;
    // Start is called before the first frame update
    void Start()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if (manager.nivel == -21)
        {
            nv1.text = "nivel 1 la llegada : " + datosserial.recordnv1.ToString("F2");
            nv2.text = "nivel 2 el laberinto : " + datosserial.recordnv2.ToString("F2");
            nv3.text = "nivel 3 las 2 torres : " + datosserial.recordnv3.ToString("F2");
            nv4.text = "nivel 4 viaje a los cielos : " + datosserial.recordnv4.ToString("F2");
            nv5.text = "nivel 5 mar de lava : " + datosserial.recordnv5.ToString("F2");
            nv6.text = "nivel 6 corredero de lava : " + datosserial.recordnv6.ToString("F2");
            nv7.text = "nivel 7 la atraccion de la tierra : " + datosserial.recordnv7.ToString("F2");
            nv8.text = "nivel 8 torre de lava : " + datosserial.recordnv8.ToString("F2");
            nv9.text = "nivel 9 sotano bajo lava : " + datosserial.recordnv9.ToString("F2");
            nv10.text = "nivel 10 laberinto de espejos : " + datosserial.recordnv10.ToString("F2");
            nv11.text = "nivel 11 peresecuccion peligrosa : " + datosserial.recordnv11.ToString("F2");
            nv12.text = "nivel 12 en la cuerda floja : " + datosserial.recordnv12.ToString("F2");
            nv13.text = "nivel 13 aqui estoy rapunzel : " + datosserial.recordnv13.ToString("F2");
            nv14.text = "nivel 14 ascensor al infierno : " + datosserial.recordnv14.ToString("F2");
            nv15.text = "nivel 15 colandose en la joyeria : " + datosserial.recordnv15.ToString("F2");
            nv16.text = "nivel 16 coche acrobatico : " + datosserial.recordnv16.ToString("F2");
            nv17.text = "nivel 17 trabajo en equipo : " + datosserial.recordnv17.ToString("F2");
            nv18.text = "nivel 18 trabajo sincronizado : " + datosserial.recordnv18.ToString("F2");
            nv19.text = "nivel 19 abreme camino : " + datosserial.recordnv19.ToString("F2");
            nv20.text = "nivel 20 camino acrobatico : " + datosserial.recordnv20.ToString("F2");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if(manager.juego != -1)
        {
        contador += 1 * Time.deltaTime;
        if(manager.datosconfig.idioma == "es")
		{
		this.crono.text = "crono : " + contador.ToString("F2");
		}
		if(manager.datosconfig.idioma == "en")
		{
		this.crono.text = "chrono : " + contador.ToString("F2");
		}
		if(manager.datosconfig.idioma == "cat")
		{
		this.crono.text = "crono : " + contador.ToString("F2");
		}
        }
    }
}
