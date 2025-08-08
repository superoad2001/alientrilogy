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
    public manager_al1 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        frases = 9;
        loreN = new string[frases];
        loredesc = new string[frases];


        if(manager.datosconfig.idioma == "es")
        {
        loreN[0] = "oscuridad oculta";
        loreN[1] = "salir de aqui";
        loreN[2] = "robots con complejo de toro";
        loreN[3] = "un tesoro llamativo";
        loreN[4] = "un loco con recursos";
        loreN[5] = "fugitivo";
        loreN[6] = "paquete";
        loreN[7] = "la familia es lo primero";
        loreN[8] = "sucesos extraños";



        loredesc[0] = "dicen que en el centro exacto del universo se ubica una energia ancestral pero solo son mitos";
        loredesc[1] = "llevo meses atrapado aqui,mi unica compañia son los que se quedan vartados como yo tengo una flota de naves sin energia ni yo ni nadie de los aqui presentes tenemos valor para conseguir gemas pues este lugar esta lleno y son una gran fuente de energia.";
        loredesc[2] = "desde que llegaste han comenzado a aparecer robots asesionos casualmente se sienten atraidos a objetos rojos como tu uno vi uno caer varado al perseguir una neblina roja";
        loredesc[3] = "las gemas rezuman energia en si brillan mucho si no la ves tambein hacen un sonido carateristico";
        loredesc[4] = "esto es un lugar sagrado pertencio a una civilizacion extinta habia un cientifico que queria demostrar que todavia viven,destruyo a todo su planeta hace meses y desaparecio si lo ves huye es un radical genocida";
        loredesc[5] = "como un cientifico puede querer el avanze evolutivo pero querer deststruir a toda su especie por coniderarlos inferiores siendo uno de ellos en fin menos mal que nadie apoyaria a un psicopata en esta galaxia";
        loredesc[6] = "tu planeta era un planeta antes de quedarme aqui varado debia ir ahi a tu luna a entregar un paquete de armas para un rey pirata no pregunte pero pidio un cargamento enorme no se para que querria tantas";
        loredesc[7] = "me dijeron que tienes un hijo y familia cuidalos, ten cuidado llevamos meses oyendo que una gran flota de secuestradores ronda tu galaxia saqueando y secuestrando gente para convertirla en esclava";
        loredesc[8] = "dicen que habeces rezuma una energia roja y se ven portales mas raros de la cuenta gente afirma haberse visto a si misma como un espejo extraño no?";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
