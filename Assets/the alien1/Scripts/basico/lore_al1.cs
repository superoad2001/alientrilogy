using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class lore_al1 : MonoBehaviour
{
    public string[] loreN;
    public string[] loredesc;
    public int frases;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frases = 2;
        loreN = new string[frases];
        loredesc = new string[frases];

        loreN[0] = "oscuridad oculta";
        loreN[1] = "salir de aqui";



        loredesc[0] = "dicen que en el centro exacto del universo se ubica una energia ancestral per solo son miros";
        loredesc[1] = "llevo años atrapado aqui,mi unica compañia son los que se quedan vartados como yo tengo una flota de naves sin energia ni yo ni nadie de los aqui presentes tenemos valor para conseguir gemas pues este lugar esta lleno y son una gran fuente de energia.";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
