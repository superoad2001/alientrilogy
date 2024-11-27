using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class datosconfig
{
    public string idioma;
    public int plat;
    public int distancia;
    public int postpro;
    public int resoluciones;
    public int lastgame = 1;

    public float master = -7;
    public float masterslider = 0.5f;

    public float musica = 14;
    public float musicaslider = 0.5f;
    public float sfx = 10;
    public float sfxslider = 3f;

    public float voz = 14;
    public float vozslider = 5f;

    public float ui = 12;
    public float uislider = 4f;

}
