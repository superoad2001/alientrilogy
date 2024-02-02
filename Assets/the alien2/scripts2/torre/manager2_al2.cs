using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
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
            nv1.text = "nivel 1 la llegada : " + datosserial.recordnv1;
            nv2.text = "nivel 2 el laberinto : " + datosserial.recordnv2;
            nv3.text = "nivel 3 las 2 torres : " + datosserial.recordnv3;
            nv4.text = "nivel 4 viaje a los cielos : " + datosserial.recordnv4;
            nv5.text = "nivel 5 mar de lava : " + datosserial.recordnv5;
            nv6.text = "nivel 6 corredero de lava : " + datosserial.recordnv6;
            nv7.text = "nivel 7 la atraccion de la tierra : " + datosserial.recordnv7;
            nv8.text = "nivel 8 torre de lava : " + datosserial.recordnv8;
            nv9.text = "nivel 9 sotano bajo lava : " + datosserial.recordnv9;
            nv10.text = "nivel 10 laberinto de espejos : " + datosserial.recordnv10;
            nv11.text = "nivel 11 peresecuccion peligrosa : " + datosserial.recordnv11;
            nv12.text = "nivel 12 en la cuerda floja : " + datosserial.recordnv12;
            nv13.text = "nivel 13 aqui estoy rapunzel : " + datosserial.recordnv13;
            nv14.text = "nivel 14 ascensor al infierno : " + datosserial.recordnv14;
            nv15.text = "nivel 15 colandose en la joyeria : " + datosserial.recordnv15;
            nv16.text = "nivel 16 coche acrobatico : " + datosserial.recordnv16;
            nv17.text = "nivel 17 trabajo en equipo : " + datosserial.recordnv17;
            nv18.text = "nivel 18 trabajo sincronizado : " + datosserial.recordnv18;
            nv19.text = "nivel 19 abreme camino : " + datosserial.recordnv19;
            nv20.text = "nivel 20 camino acrobatico : " + datosserial.recordnv20;
            nv1.text = nv1.text.Substring(0, 25);
            nv2.text = nv2.text.Substring(0, 27);
            nv3.text = nv3.text.Substring(0, 27);
            nv4.text = nv4.text.Substring(0, 34);
            nv5.text = nv5.text.Substring(0, 26);
            nv6.text = nv6.text.Substring(0, 33);
            nv7.text = nv7.text.Substring(0, 40);
            nv8.text = nv8.text.Substring(0, 28);
            nv9.text = nv9.text.Substring(0, 31);
            nv10.text = nv10.text.Substring(0, 36);
            nv11.text = nv11.text.Substring(0, 39);
            nv12.text = nv12.text.Substring(0, 34);
            nv13.text = nv13.text.Substring(0, 35);
            nv14.text = nv14.text.Substring(0, 36);
            nv15.text = nv15.text.Substring(0, 39);
            nv16.text = nv16.text.Substring(0, 32);
            nv17.text = nv17.text.Substring(0, 33);
            nv18.text = nv18.text.Substring(0, 36);
            nv19.text = nv19.text.Substring(0, 29);
            nv20.text = nv20.text.Substring(0, 33);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        crono.text = crono.text.Substring(0, 11);
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if(manager.juego != -1)
        {
        contador += 1 * Time.deltaTime;
        if(manager.datosconfig.idioma == "es")
		{
		this.crono.text = "crono : " + contador;
        crono.text = crono.text.Substring(0, 12);
		}
		if(manager.datosconfig.idioma == "en")
		{
		this.crono.text = "chrono : " + contador;
        crono.text = crono.text.Substring(0, 13);
		}
		if(manager.datosconfig.idioma == "cat")
		{
		this.crono.text = "crono : " + contador;
        crono.text = crono.text.Substring(0, 12);
		}
        }
    }
}
