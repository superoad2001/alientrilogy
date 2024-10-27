using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;

public class iniciocarrera_al2 : MonoBehaviour
{
    public GameObject interfaz;
    public GameObject imagen;
    public jugador1_al2 jugador;
    public jefe4_al2 enemigo;
    public Text cont;
    public float temp;
    public int intentos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        temp = 0;
        cont.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        if (temp >= 1 && intentos < 3)
        {
            temp = 0;
            intentos++;
        }
        if (temp >= 0.1f && intentos == 3)
        {
            temp = 0;
            intentos++;
        }
        if(intentos == 1)
        {
            cont.text = "2";
        }
        if(intentos == 2)
        {
            cont.text = "1";
        }
        if(intentos == 3)
        {

            cont.text = "start";
            jugador.controlact = true;
            enemigo.enabled = true;
            imagen.SetActive(false);
        }
        if(intentos == 4)
        {

            cont.text = "";
            interfaz.SetActive(false);
        }
        temp += 1 * Time.deltaTime;
        
    }
}
