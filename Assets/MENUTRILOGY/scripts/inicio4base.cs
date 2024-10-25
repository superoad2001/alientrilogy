using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;

// Token: 0x02000008 RID: 8
public class inicio4base : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public int plat;
	public string idioma;

	public int distancia;
	public int postpro;

	public Text platt;
	public Text idiomat;
	public Text postt;
	public Text distanciat;
	public Resolution[] resoluciones;
	public List<string> opcionesr = new List<string>();
	public int opcres = 0;
	public Text resolt;
	public AudioMixer audiomixer;
	public bool menu;
	public void Start()
	{
		managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
		if(menu)
		{
		audiomixer.SetFloat ("MusicVolume",manager.datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",manager.datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",manager.datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",manager.datosconfig.ui);
		}


		revresol_();
		plat = manager.datosconfig.plat;
		idioma = manager.datosconfig.idioma;
		postpro = manager.datosconfig.postpro;
		if(manager.datosconfig.distancia == 200)
		{distancia = 1;}
		if(manager.datosconfig.distancia == 500)
		{distancia = 2;}
		if(manager.datosconfig.distancia == 1000)
		{distancia = 3;}
		if(manager.datosconfig.distancia == 2000)
		{distancia = 4;}
		if(manager.datosconfig.distancia == 3000)
		{distancia = 5;}
	}
	public void revresol_()
	{
		resoluciones = Screen.resolutions;
		
		int resolactual = 0;
		for (int i = 0; i < resoluciones.Length; i++)
		{
			string opcion = resoluciones[i].width + " x " + resoluciones[i].height;
			opcionesr.Add(opcion);
			if(Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width &&	resoluciones[i].height == Screen.currentResolution.height)
			{
				resolactual = i;
			}	
		}
		opcres = resolactual;

	}
	public void Resizq()
	{
		if(opcres > 0)
		{
		opcres--;
		managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
		Resolution resolucion = resoluciones[opcres];
		Screen.SetResolution(resolucion.width,resolucion.height,Screen.fullScreen);
		manager.datosconfig.resolh = Screen.currentResolution.width;
		manager.datosconfig.resolv = Screen.currentResolution.height;
		}
	}
	public void Resder()
	{
		if(opcres < opcionesr.Count - 1)
		{
		opcres++;
		managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
		Resolution resolucion = resoluciones[opcres];
		Screen.SetResolution(resolucion.width,resolucion.height,Screen.fullScreen);
		manager.datosconfig.resolh = Screen.currentResolution.width;
		manager.datosconfig.resolv = Screen.currentResolution.height;
		}
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
		if(plat == 1)
		{
			if(manager.datosconfig.idioma == "es")
			{platt.text = "pc o consola";}
			if(manager.datosconfig.idioma == "en")
			{platt.text = "pc or console";}
			if(manager.datosconfig.idioma == "cat")
			{platt.text = "pc o consola";}
		}
		if(plat == 2)
		{
			if(manager.datosconfig.idioma == "es")
			{platt.text = "dispositvo tactil";}
			if(manager.datosconfig.idioma == "en")
			{platt.text = "touch device";}
			if(manager.datosconfig.idioma == "cat")
			{platt.text = "dispositiu tactil";}
		}
		if(idioma == "es")
		{
			idiomat.text = "español";
		}
		if(idioma == "en")
		{
			idiomat.text = "english";
		}
		if(idioma == "cat")
		{
			idiomat.text = "catala";
		}


		if(distancia == 1)
		{
			distanciat.text = "200";
		}
		if(distancia == 2)
		{
			distanciat.text = "500";
		}
		if(distancia == 3)
		{
			distanciat.text = "1000";
		}
		if(distancia == 4)
		{
			distanciat.text = "2000";
		}
		if(distancia == 5)
		{
			distanciat.text = "3000";
		}

		if(postpro == 1)
		{
			if(manager.datosconfig.idioma == "es")
			{postt.text = "desactivado";}
			if(manager.datosconfig.idioma == "en")
			{postt.text = "disabled";}
			if(manager.datosconfig.idioma == "cat")
			{postt.text = "desactivat";}
		}
		if(postpro== 2)
		{
			if(manager.datosconfig.idioma == "es")
			{postt.text = "activado";}
			if(manager.datosconfig.idioma == "en")
			{postt.text = "enabled";}
			if(manager.datosconfig.idioma == "cat")
			{postt.text = "activat";}
		}
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		if(distancia == 1)
		{
			manager.datosconfig.distancia = 200;
		}
		if(distancia == 2)
		{
			manager.datosconfig.distancia = 500;
		}
		if(distancia == 3)
		{
			manager.datosconfig.distancia = 1000;
		}
		if(distancia == 4)
		{
			manager.datosconfig.distancia = 2000;
		}
		if(distancia == 5)
		{
			manager.datosconfig.distancia = 3000;
		}

		resolt.text = opcionesr[opcres];
	

	}
	public void contder()
    {
        if(plat < 2)
		{plat+= 1;}
    }
	public void contizq()
    {
        if(plat > 1)
		{plat-= 1;}
    }

	public void idider()
    {
        if(idioma == "es")
		{idioma = "en";}
		else if(idioma == "en")
		{idioma = "cat";}
    }
	public void idiizq()
    {
        if(idioma == "cat")
		{idioma = "en";}
		else if(idioma == "en")
		{idioma = "es";}
    }
	public void disder()
    {
        if(distancia < 5)
		{distancia+= 1;}
    }
	public void disizq()
    {
        if(distancia > 1)
		{distancia-= 1;}
    }
	public void postder()
    {
        if(postpro == 2)
		{postpro = 1;}
		else if(postpro == 1)
		{postpro = 2;}
    }
	public void aplicar()
    {
		managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
		controlmusicabase controlslider = UnityEngine.Object.FindObjectOfType<controlmusicabase>();


		audiomixer.GetFloat ("MusicVolume",out manager.datosconfig.musica);
		manager.datosconfig.musicaslider = controlslider.slidermusica.value;

		audiomixer.GetFloat ("EnvironmentVolume",out manager.datosconfig.voz);
		manager.datosconfig.vozslider = controlslider.slidervoz.value;

		audiomixer.GetFloat ("SFXVolume",out manager.datosconfig.sfx);
		manager.datosconfig.sfxslider = controlslider.slidersfx.value;

		audiomixer.GetFloat ("UIVolume",out manager.datosconfig.ui);
		manager.datosconfig.uislider = controlslider.sliderui.value;

		manager.datosconfig.aplicarres = true;
		manager.guardar();
		if(manager.datosconfig.lastgame == 1)
		{SceneManager.LoadScene("menutrilogy");}
		if(manager.datosconfig.lastgame == 2)
		{SceneManager.LoadScene("menu_de_carga_al1");}
		if(manager.datosconfig.lastgame == 3)
		{SceneManager.LoadScene("menu_de_carga_al2");}
		if(manager.datosconfig.lastgame == 4)
		{SceneManager.LoadScene("carga_al3");}
    }


}
