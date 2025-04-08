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
	public managerBASE manager;
	public GameObject eventbase;
	public GameObject idiomam;
	public GameObject resolucionm;
	public GameObject controlesm;
	public GameObject sonidom;
	public GameObject postm;
	public GameObject distanciam;
	public Text conftxtidi;
	public Text conftxtresolucion;
	public Text conftxtcontroles;
	public Text conftxtpost;
	public Text conftxtdistancia;

	public void idiomab()
	{
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;
		eventbase.SetActive(false);
		resolucionm.SetActive(false);
		controlesm.SetActive(false);
		sonidom.SetActive(false);
		postm.SetActive(false);
		distanciam.SetActive(false);
		idiomam.SetActive(true);
	}
	public void resolucionb()
	{
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;
		eventbase.SetActive(false);
		idiomam.SetActive(false);
		controlesm.SetActive(false);
		sonidom.SetActive(false);
		postm.SetActive(false);
		distanciam.SetActive(false);
		resolucionm.SetActive(true);
	}
	public void controlesb()
	{
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;
		eventbase.SetActive(false);
		resolucionm.SetActive(false);
		idiomam.SetActive(false);
		sonidom.SetActive(false);
		postm.SetActive(false);
		distanciam.SetActive(false);
		controlesm.SetActive(true);
	}
	public void sonidob()
	{
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;
		eventbase.SetActive(false);
		resolucionm.SetActive(false);
		controlesm.SetActive(false);
		idiomam.SetActive(false);
		postm.SetActive(false);
		distanciam.SetActive(false);
		sonidom.SetActive(true);
	}
	public void postb()
	{
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;
		eventbase.SetActive(false);
		resolucionm.SetActive(false);
		controlesm.SetActive(false);
		sonidom.SetActive(false);
		idiomam.SetActive(false);
		distanciam.SetActive(false);
		postm.SetActive(true);
	}
	public void distanciab()
	{
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;
		eventbase.SetActive(false);
		resolucionm.SetActive(false);
		controlesm.SetActive(false);
		sonidom.SetActive(false);
		postm.SetActive(false);
		idiomam.SetActive(false);
		distanciam.SetActive(true);
	}
	public void Start()
	{
		
		manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
		manager.guardar();
		if(menu)
		{
		audiomixer.SetFloat ("MusicVolume",manager.datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",manager.datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",manager.datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",manager.datosconfig.ui);
		}

		plat = manager.datosconfig.plat;
		idioma = manager.datosconfig.idioma;
		postpro = manager.datosconfig.postpro;
		distancia = manager.datosconfig.distancia;

		
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if(manager.datosconfig.idioma == "es")
		{
			conftxtidi.text = "Idioma: Español";
		}
		if(manager.datosconfig.plat== 2)
		{
			conftxtcontroles.text = "Modo: Touch";
		}
		if(manager.datosconfig.plat == 1)
		{
			conftxtcontroles.text = "Modo: Fisico";
		}
		if(manager.datosconfig.postpro == 1)
		{
			conftxtpost.text = "postprocesado: desactivado";
		}
		if(manager.datosconfig.postpro == 2)
		{
			conftxtpost.text = "postprocesado: activado";
		}
		conftxtdistancia.text = "distancia: "+manager.datosconfig.distancia;
		conftxtresolucion.text = "resolucion: ";

		
		
	
	

	}
	public void aplicaridioma()
    {
		idioma = manager.datosconfig.idioma;
		manager.guardar();
		idiomam.SetActive(false);
		eventbase.SetActive(true);
	}
	public void idi_es()
    {
		manager.datosconfig.idioma = "es";
	}
	public void aplicaresolucion()
    {
		manager.guardar();
		resolucionm.SetActive(false);
		eventbase.SetActive(true);
	}
	public void aplicarcontroles()
    {
		plat = manager.datosconfig.plat;
		manager.guardar();
		controlesm.SetActive(false);
		eventbase.SetActive(true);
	}
	public void con_fisico()
    {
		manager.datosconfig.plat = 1;
	}
	public void con_Touch()
    {
		manager.datosconfig.plat = 2;
	}
	public void aplicarpost()
    {
		postpro = manager.datosconfig.postpro;
		manager.guardar();
		postm.SetActive(false);
		eventbase.SetActive(true);
	}
	public void post_si()
    {
		manager.datosconfig.postpro = 2;
	}
	public void post_no()
    {
		manager.datosconfig.postpro = 1;
	}
	public void aplicardistancia()
    {
		distancia = manager.datosconfig.distancia;
		manager.guardar();
		distanciam.SetActive(false);
		eventbase.SetActive(true);
	}
	public void dist_200()
    {
		manager.datosconfig.distancia = 200;
	}
	public void dist_500()
    {
		manager.datosconfig.distancia = 500;
	}
	public void dist_1000()
    {
		manager.datosconfig.distancia = 1000;
	}
	public void dist_2000()
    {
		manager.datosconfig.distancia = 2000;
	}
	public void dist_3000()
    {
		manager.datosconfig.distancia = 3000;
	}
	public void aplicarmusica()
    {
		manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
		controlmusicabase controlslider = (controlmusicabase)FindFirstObjectByType(typeof(controlmusicabase));


		audiomixer.GetFloat ("MusicVolume",out manager.datosconfig.musica);
		manager.datosconfig.musicaslider = controlslider.slidermusica.value;

		audiomixer.GetFloat ("EnvironmentVolume",out manager.datosconfig.voz);
		manager.datosconfig.vozslider = controlslider.slidervoz.value;

		audiomixer.GetFloat ("SFXVolume",out manager.datosconfig.sfx);
		manager.datosconfig.sfxslider = controlslider.slidersfx.value;

		audiomixer.GetFloat ("UIVolume",out manager.datosconfig.ui);
		manager.datosconfig.uislider = controlslider.sliderui.value;

		manager.guardar();
		sonidom.SetActive(false);
		eventbase.SetActive(true);
		
    }
	public void salir()
    {
		manager.datosconfig.plat = plat;
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.postpro = postpro;
		manager.datosconfig.distancia = distancia;

		manager.datosconfig.primera = true;
		
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
