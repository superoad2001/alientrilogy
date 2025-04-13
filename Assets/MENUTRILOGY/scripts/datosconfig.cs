using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class datosconfig
{
    public bool primera;
    public string idioma = "es";
    public int plat = 1;
    public int distancia = 1000;
    public int postpro = 1;
    public int resoluciones;
    public int lastgame = 0;

    public float master = -28;

    public float musica = 14;
    public float musicaslider = 0.5f;
    
    public float sfx = 10;
    public float sfxslider = 3f;

    public float voz = 14;
    public float vozslider = 5f;

    public float ui = 12;
    public float uislider = 4f;
    public int largo;
    public int altura;
    public int ind;
    public bool full;

}
