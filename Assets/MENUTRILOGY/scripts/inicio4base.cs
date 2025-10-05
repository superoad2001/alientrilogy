using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Rendering;

// Token: 0x02000008 RID: 8
public class inicio4base : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	private Controles controles;
	public Text exp1;
    public Text exp2;
	public Text exp3;
	public int plat;
	public string idioma;
	public GameObject Gobj;
	public Text[] botones;
	public RenderPipelineAsset calidad1;
	public RenderPipelineAsset calidad2;
	private string disstring;

	public int distancia;
	public int postpro;

	public Text platt;
	public Text idiomat;
	public Text postt;
	public Text distanciat;
	public Resolution[] resoluciones;
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
	public int gameL;
	public int gameA;
	public Toggle toggle;
	public Dropdown resoL;
	public Resolution[] Allres;
	public List<Resolution> resolucion = new List<Resolution>();
	public List<string> opcionesR = new List<string>();
	public List<string> opcionesRdef = new List<string>();
	public List<int> resRdef = new List<int>();
	public float tempG;
	public int C;

	public int ind;
	public bool full;
	public int largo;
	public int altura;
	public SystemLanguage sysidi;
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }

	public void rescheck()
	{
		
		opcionesRdef.Add("720P");
		opcionesRdef.Add("1080P");
		opcionesRdef.Add("2K");
		opcionesRdef.Add("4K");

		resRdef.Add(720);
		resRdef.Add(1080);
		resRdef.Add(1440);
		resRdef.Add(2160);


		Allres = Screen.resolutions;
		resoL.ClearOptions();
		string opcion;

		
		for(int i = 0; i < opcionesRdef.Count; i++)
		{
			opcion = opcionesRdef[i];
			Resolution resop = new Resolution();
			resop.height = 0;
			resop.width = 0;
			foreach(Resolution resv in Allres)
			{
				if(resv.height  == resRdef[i] && resv.width >= resop.width)
				{
					resop = resv;
				}
				

			}
			if(!opcionesR.Contains(opcion) && resop.height != 0)
			{
				opcionesR.Add(opcion);
				resolucion.Add(resop);
				if(resop.height == Screen.currentResolution.height && resop.width == Screen.currentResolution.width)
				{
					ind = C;
					resoL.value = ind;
				}
				C++;
				
				
			}
			
			
			

		}
		resoL.AddOptions(opcionesR);


		
	}
	public void cambiarresoluciones()
	{
		if(Screen.width >= resolucion[resoL.value].width && Screen.height >= resolucion[resoL.value].height)
		{
			ind = resoL.value;
			altura = resolucion[ind].height;
			largo = resolucion[ind].width;
			Screen.SetResolution(resolucion[ind].width,resolucion[ind].height,full);
		}
	}
	public void idiomab()
	{
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
		manager.cargar();
		manager.guardar();

		if(manager.datosconfig.idioma == "es")
        {
			exp1.text = "Guardar";
			exp2.text = "Ir al menu";
			botones[0].text = "Guardar";
			botones[1].text = "Ir al menu";
			botones[2].text = "Guardado";
        }
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
		//largo = manager.datosconfig.largo;
    	//altura = manager.datosconfig.altura;
   		ind = manager.datosconfig.ind;
    	//full = manager.datosconfig.full;

			if(manager.datosconfig.primera == false)
			{
			manager.datosconfig.plat = 1;

			#if UNITY_ANDROID
			manager.datosconfig.plat = 2;
			#endif

			manager.datosconfig.idioma = "es";
			manager.datosconfig.postpro = 1;
			manager.datosconfig.distancia = 3000;
			sysidi = SystemLanguage.English;
			manager.datosconfig.lastgame = 0;
			}
			

		/*if(manager.datosconfig.primerares == true)
		{
			if(full)
			{
				toggle.isOn = true;
			}
			else
			{
				toggle.isOn = false;
			}
			if(Screen.width >= largo && Screen.height >= altura)
			{
				Screen.SetResolution(largo,altura,full);
			}
		}*/
		rescheck();
		resoL.value = ind;

		
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (tempG < 15)
		{tempG += 1 * Time.deltaTime;}
		
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
			conftxtpost.text = "calidad: baja";
		}
		if(manager.datosconfig.postpro == 2)
		{
			conftxtpost.text = "calidad: alta";
		}
		conftxtdistancia.text = disstring;

		if(controles.menu.saltar.ReadValue<float>()  > 0 && temp > 0.5f)
		{
			aplicartodo();


		}
		if(controles.menu.atras.ReadValue<float>() > 0 && temp > 0.5f )
		{
			salir();

		}

		if(tempG > 2)
		{
			exp3.text = "";
			Gobj.SetActive(false);
		}


		
		
	
	

	}
	public void aplicaridioma()
    {
		manager.datosconfig.idioma = idioma;
		manager.datosconfig.sysidi = sysidi;
		manager.guardar();
		idiomam.SetActive(false);
		eventbase.SetActive(true);
		icono();
	}
	public void idi_es()
    {
		idioma = "es";
		sysidi = SystemLanguage.English;
	}
	public void aplicaresolucion()
    {
		manager.datosconfig.altura = altura;
		manager.datosconfig.largo = largo;
		manager.datosconfig.full = full;
		manager.datosconfig.ind = ind;
		manager.datosconfig.primerares = true;
		manager.guardar();
		resolucionm.SetActive(false);
		eventbase.SetActive(true);
		icono();
	}
	public void fullScreen_change()
    {
		full = toggle.isOn;
		Screen.fullScreen = full;
	}
	public void aplicarcontroles()
    {
		manager.datosconfig.plat = plat;
		manager.guardar();
		controlesm.SetActive(false);
		eventbase.SetActive(true);
		icono();
	}
	public void con_fisico()
    {
		plat = 1;
	}
	public void con_Touch()
    {
		plat = 2;
	}
	public void aplicarpost()
    {
		manager.datosconfig.calidad = QualitySettings.renderPipeline;
		manager.datosconfig.postpro = postpro;
		manager.guardar();
		postm.SetActive(false);
		eventbase.SetActive(true);
		icono();
	}
	public void post_si()
    {
		QualitySettings.renderPipeline = calidad2;
		postpro = 2;
	}
	public void post_no()
    {
		QualitySettings.renderPipeline = calidad1;
		postpro = 1;
	}
	public void aplicardistancia()
    {
		manager.datosconfig.distancia = distancia;
		manager.guardar();
		distanciam.SetActive(false);
		eventbase.SetActive(true);
		icono();
	}
	public void dist_200()
    {
		distancia = 200;
		disstring = "distancia: "+distancia;
	}
	public void dist_500()
    {
		distancia = 500;
		disstring = "distancia: "+distancia;
	}
	public void dist_1000()
    {
		distancia = 1000;
		disstring = "distancia: "+distancia;
	}
	public void dist_2000()
    {
		distancia = 2000;
		disstring = "distancia: "+distancia;
	}
	public void dist_3000()
    {
		distancia = 3000;
		disstring = "distancia: "+distancia;
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
		icono();
		
    }
	public void salir()
    {
		
		
		
		if(manager.datosconfig.primerares == false)
		{
			manager.datosconfig.full = Screen.fullScreen;
			manager.datosconfig.altura = Screen.height;
			manager.datosconfig.largo = Screen.width;
			manager.datosconfig.ind = ind;
			//Screen.SetResolution(manager.datosconfig.largo,manager.datosconfig.altura,manager.datosconfig.full);
		}

		manager.datosconfig.primera = true;
		manager.datosconfig.primerares = true;
		manager.guardar();
		
		if(manager.datosconfig.lastgame == 0)
		{
			manager.datosconfig.carga = "menutrilogy";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if(manager.datosconfig.lastgame == 1)
		{
			manager.datosconfig.carga = "menu_de_carga_al1";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if(manager.datosconfig.lastgame == 2)
		{
			manager.datosconfig.carga = "menu_de_carga_al2";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if(manager.datosconfig.lastgame == 3)
		{
			manager.datosconfig.carga = "carga_al3";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
	}
	public void aplicartodo()
	{
		
		aplicaridioma();
		aplicarpost();
		aplicardistancia();
		aplicarmusica();
		icono();


	}
	void icono()
	{
		if(manager.datosconfig.idioma == "es")
        {
        exp3.text = "Guardado";
		Gobj.SetActive(true);
		tempG = 0;
        }
	}


}
