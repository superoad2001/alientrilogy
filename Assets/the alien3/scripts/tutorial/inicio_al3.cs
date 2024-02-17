using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio_al3: MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botond = false;
	public GameObject guia;
	public GameObject guia2;
	public GameObject obj;
	public GameObject canvas;
	public GameObject player;
	public GameObject cam;
	public GameObject tactil;
	public AudioSource audio1;
	public AudioSource audio1es;
	public AudioSource audio1en;
	public AudioSource audio1cat;
	public AudioSource menum;
	public AudioSource juegom;
	public int mundo = 0;
	public int espacio;
	public int com = 0;
	public float temp2;
	public bool actg = false;
	public bool guiaboton;
	public bool guiaboton2;

	public Text tbp;
	public Text topc;
	public Text tcom;
	public Text tg1;
	public Text tg2;
	public Text tsalir;

	public void Start()
	{
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		manager.cargar();
		if (manager.datosconfig.idioma == "es")
		{
			audio1 = audio1es;
		}
		if (manager.datosconfig.idioma == "en")
		{
			audio1 = audio1en;
		}
		if (manager.datosconfig.idioma == "cat")
		{
			audio1 = audio1cat;
		}
		manager.datosserial.menu = mundo;
		if(espacio != 0)
		{manager.datosserial.espacio = espacio;}
		manager.guardar();
		if(manager.datosserial.com == 1)
		{
			player.GetComponent<jugador1_al3>().enabled = true;
			if(manager.juego == 1)
			{
			cam.GetComponent<movcam_al3>().enabled = true;
			}
			menum.Stop();
			juegom.Play();
			obj.SetActive(true);
			canvas.SetActive(false);
			if(mundo == 0)
			{
				audio1.Play();
			}
			if(manager.datosconfig.plat == 2)
			{
				
				tactil.SetActive(true);
			}
		}

	}
	public void Awake()
		{
			manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
			manager.cargar();
			manager.datosserial.menu = mundo;
			if(espacio != 0)
			{manager.datosserial.espacio = espacio;}
			manager.guardar();
		}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	public void Update()
	{
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();

		if(manager.datosconfig.idioma == "es")
		{
			tbp.text = "borrar partida";
			topc.text = "opciones";
			tcom.text = "comenzar";
			tg1.text = "guia de controles pc";
			tg2.text = "guia de controles mando";
			tsalir.text = "salir";
		}
		if(manager.datosconfig.idioma == "en")
		{
			tbp.text = "delete data";
			topc.text = "settings";
			tcom.text = "begin adventure";
			tg1.text = "guide of controls pc";
			tg2.text = "guide of controls mando";
			tsalir.text = "exit";
		}
		if(manager.datosconfig.idioma == "cat")
		{
			tbp.text = "esborra dadas";
			topc.text = "opcions";
			tcom.text = "comencar aventura";
			tg1.text = "guia de controls pc";
			tg2.text = "guia de controls mando";
			tsalir.text = "sortir";
		}
		
		if(actg == false)
		{
		manager.datosserial.menu = mundo;
		manager.guardar();
		actg = true;
		}
		temp2 += 1 * Time.deltaTime;

		if(!menum.isPlaying && temp2 > 60)
		{
			SceneManager.LoadScene("intro_al3");
		}
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}

		if (this.botonm == true && temp >= 1)
		{
			manager.datosserial.com = 1;
			manager.guardar();
			com = 1;
			player.GetComponent<jugador1_al3>().enabled = true;
			if(manager.juego == 1)
			{
			cam.GetComponent<movcam_al3>().enabled = true;
			}
			menum.Stop();
			juegom.Play();
			obj.SetActive(true);
			canvas.SetActive(false);
			if(mundo == 0)
			{
				audio1.Play();
			}
			if(manager.datosconfig.plat == 2)
			{
				
				tactil.SetActive(true);
			}
		}
		if (this.botonn == true && temp >= 1)
		{
			SceneManager.LoadScene("borrar_partida_al3");
		}
		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.lastgame = 4;
            manager.guardarconfig();
			SceneManager.LoadScene("opcionesbase");
		}
		if (this.botond == true && temp >= 1)
		{
			SceneManager.LoadScene("menutrilogy");
		}
	

	}
	public void comenzar()
    {
        botonm = true;
    }
	public void borrar()
    {
        botonn = true;
    }
	public void opciones()
    {
        botonc = true;
    }
	public void salir()
    {
        botond = true;
    }
	public void guia_()
	{
		if(guiaboton == false && temp >= 1 )
		{
			guia.SetActive(true);
			guiaboton = true;
			guia2.SetActive(false);
			guiaboton2 = false;
		}
		else if(guiaboton == true && temp >= 1)
		{
			guia.SetActive(false);
			guiaboton = false;
			
		}
	}
	public void guia2_()
	{
		if(guiaboton2 == false && temp >= 1)
		{
			guia2.SetActive(true);
			guiaboton2 = true;
			guia.SetActive(false);
			guiaboton = false;
		}
		else if(guiaboton2 == true && temp >= 1)
		{
			guia2.SetActive(false);
			guiaboton2 = false;
		}
	}


}
