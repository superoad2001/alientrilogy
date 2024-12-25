using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;

public class iniciocarrera_al1 : MonoBehaviour
{
	public manager_al1 manager;
    public GameObject interfaz;
    public GameObject imagen;
    public jugador_al1 jugador;
    public bola1_al1 enemigo;
    public Text cont;
    public float temp = -2;
    public int intentos;
    public AudioSource pip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        temp = -6;
        cont.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        if (temp == 0 && intentos < 3 && intentos > 0)
        {
            pip.Play();
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
            imagen.SetActive(false);
            cont.text = "start";
            jugador.controlact = true;
            enemigo.enabled = true;
        }
        if(intentos == 4)
        {

            cont.text = "";
            interfaz.SetActive(false);
        }
        temp += 1 * Time.deltaTime;
        if (temp >= 1 && intentos < 3)
        {
            temp = 0;
            intentos++;
            pip.Play();
        }
        
    }
}
