using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEngine.UI;

public class manager2_al1 : MonoBehaviour
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

    public bool rey;

    public datos1 datosserial;
    // Start is called before the first frame update
    void Start()
    {
        manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        if (manager.piso == -5)
        {
            nv1.text = "nivel 1 parque de saltos : " + manager.datosserial.recordnv1.ToString("F2") ;
            nv2.text = "nivel 2 zona de planeadores : " + manager.datosserial.recordnv2.ToString("F2");
            nv3.text = "nivel 3 aceras de principiante : " + manager.datosserial.recordnv3.ToString("F2");
            nv4.text = "nivel 4 islas de salto de altura : " + manager.datosserial.recordnv4.ToString("F2");
            nv5.text = "nivel 5 aceras de salto : " + manager.datosserial.recordnv5.ToString("F2");
            nv6.text = "nivel 6 mirador en la altura : " + manager.datosserial.recordnv6.ToString("F2");
            nv7.text = "nivel 7 tercer piso sin ascensor : " + manager.datosserial.recordnv7.ToString("F2");
            nv8.text = "nivel 8 carretera para principiantes : " + manager.datosserial.recordnv8.ToString("F2");
            nv9.text = "nivel 9 carretera con obstaculos : " + manager.datosserial.recordnv9;
            nv10.text = "nivel 10 subida infernal no esta tan mal : " + manager.datosserial.recordnv10.ToString("F2");
            nv11.text = "nivel 11 carrera del siglo : " + manager.datosserial.recordnv11.ToString("F2");
            nv12.text = "nivel 12 alien invaders : " + manager.datosserial.recordnv12.ToString("F2");
            nv13.text = "nivel 13 subida infernal a secas : " + manager.datosserial.recordnv13.ToString("F2");
            nv14.text = "nivel 14 carrera de la muerte : " + manager.datosserial.recordnv14.ToString("F2");
            nv15.text = "nivel 15  pilla pilla nivel dios : " + manager.datosserial.recordnv15.ToString("F2");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        if(rey == false)
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
