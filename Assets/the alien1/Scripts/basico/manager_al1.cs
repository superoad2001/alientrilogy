using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;
using UnityEngine.Audio;
using MeetAndTalk.Localization;
// Token: 0x0200000B RID: 11
public class manager_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool muertetutorial;
	public int trofeoact;
	public bool controlene = true;
	public float tempshow;
	public bool actguardarub;
	public string nivelu;

	public GameObject portalg;
	public int nivel = 0;
	public int piso_carga;
	public bool otroasteroide = false;
	public AudioSource audio;
	public bool dentrotienda;
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;
	public AudioSource audio4;
	public AudioSource audio5;
	public AudioSource audio6;
	public AudioSource audio7;
	public AudioSource audioen;
	public AudioSource audio1en;
	public AudioSource audio2en;
	public AudioSource audio3en;
	public AudioSource audio4en;
	public AudioSource audio5en;
	public AudioSource audio6en;
	public AudioSource audio7en;
	public AudioSource audiocat;
	public AudioSource audio1cat;
	public AudioSource audio2cat;
	public AudioSource audio3cat;
	public AudioSource audio4cat;
	public AudioSource audio5cat;
	public AudioSource audio6cat;
	public AudioSource audio7cat;
	public Text boton1;
	public Text boton2;
	public Text boton3;
	public Text boton4;
	public Text boton5;
	public Text boton6;
	public Text boton7;

	public Text tmonedar;
	public Text tllave;
	public int menu = 0;
	public int estados = 0;
	public int tuto = 0;

	public bool pauseact = false;

	public string repath;
	public string repathconfig;

	[SerializeField]
	public datos1 datosserial;
	[SerializeField]
	public datosconfig datosconfig;
	[SerializeField]
	public datosextra datostrof;
	[SerializeField]
	public datosconfigslot datosslot;
	public string repathtro;
	public string repathslot;

	public AudioSource moveson;
	public string mision;
	public string mision2;
	public bool dialogueact;

	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C

	public void move()
	{
		moveson.Play();
	}
	public void GetFilePathslot()
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"datosslot.data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"datosslot.data");
		#endif
 
        repathslot = result;
    }
	public void guardarslot()
    {
        GetFilePathslot();
        string path = repathslot;
        if(File.Exists(path))
        {
            string datosconfigslot1 = JsonUtility.ToJson(datosslot);
            File.WriteAllText(path,datosconfigslot1);
            //Debug.Log(datosconfig2);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosconfigslot1 = JsonUtility.ToJson(datosslot);
            File.WriteAllText(path,datosconfigslot1);
            //Debug.Log(datosconfig2);
        }
        
    }
	public void cargarslot()
    {
        GetFilePathslot();
        string path = repathslot;
        if(File.Exists(path))
        {
            string datosconfigslot1 = File.ReadAllText(path);
            datosslot = JsonUtility.FromJson<datosconfigslot>(datosconfigslot1);
            //Debug.Log(datosinventario);
        }
        
    }





	public void GetFilePath()
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alien1data"+datosslot.datos1slot+".data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alien1data"+datosslot.datos1slot+".data");
		#endif
 
        repath = result;
    }
	public void GetFilePathconfig()
    {
        string result;
 
    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alienconfigdata.data");	

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alienconfigdata.data");
		#endif
 
        repathconfig = result;
    }
	
	public void GetFilePathtro()
    {
        string result;

            result = Path.Combine(Application.persistentDataPath,"AlienData");
            result = Path.Combine(result, $"alientorfeodata.data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alientrofdata.data");
		#endif

 
        repathtro = result;
    }
	public void guardartro()
    {
        GetFilePathtro();
        string path = repathtro;
        if(File.Exists(path))
        {
            string datosconfig2 = JsonUtility.ToJson(datostrof);
            File.WriteAllText(path,datosconfig2);
            //Debug.Log(datosconfig2);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosconfig2 = JsonUtility.ToJson(datostrof);
            File.WriteAllText(path,datosconfig2);
            //Debug.Log(datosconfig2);
        }
        
    }

	public void guardar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = JsonUtility.ToJson(datosserial);
            File.WriteAllText(path,datosinventario);
            //Debug.Log(datosinventario);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosinventario = JsonUtility.ToJson(datosserial);
            File.WriteAllText(path,datosinventario);
            //Debug.Log(datosinventario);
        }
        
    }
	public void guardarconfig()
    {
        GetFilePathconfig();
        string path = repathconfig;
        if(File.Exists(path))
        {
            string datosconfig1 = JsonUtility.ToJson(datosconfig);
            File.WriteAllText(path,datosconfig1);
            //Debug.Log(datosconfig1);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosconfig1 = JsonUtility.ToJson(datosconfig);
            File.WriteAllText(path,datosconfig1);
            //Debug.Log(datosconfig1);
        }
        
    }
	public void cargartro()
    {
        GetFilePathtro();
        string path = repathtro;
        if(File.Exists(path))
        {
            string datosconfig2 = File.ReadAllText(path);
            datostrof = JsonUtility.FromJson<datosextra>(datosconfig2);
            //Debug.Log(datosconfig2);
        }
        
    }
	public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = File.ReadAllText(path);
            datosserial = JsonUtility.FromJson<datos1>(datosinventario);
            //Debug.Log(datosinventario);
        }
        
    }
	public void cargarconfig()
    {
        GetFilePathconfig();
        string path = repathconfig;
        if(File.Exists(path))
        {
            string datosconfig1 = File.ReadAllText(path);
            datosconfig = JsonUtility.FromJson<datosconfig>(datosconfig1);
            //Debug.Log(datosconfig1);
        }
        
    }

	public void borrar_data()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = JsonUtility.ToJson("");
            File.WriteAllText(path,datosinventario);
        }
        cargar();
        
    }





	public AudioMixer audiomixer;
	public void Awake() {
	{

		cargar();
		cargarconfig();
		cargartro();
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			hidemenu_al1 hide = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
			hide.anim.SetBool("show2",true);
		}
	}
	}
	public void Start()
	{
		cargarslot();
		cargar();
		cargarconfig();
		cargartro();

		audiomixer.SetFloat ("MusicVolume",datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",datosconfig.ui);

		LocalizationManager.Instance.selectedLang = datosconfig.sysidi;
		Debug.Log(LocalizationManager.Instance);

		Debug.Log(LocalizationManager.Instance.SelectedLang());
		

		if(actguardarub == true)
		{
			datosserial.nivelu = nivelu;
		}

		
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			hidemenu_al1 hide = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
			hide.anim.SetBool("show2",true);
		}

		if(datosserial.mejora1 == 0 && datosserial.economia[0] >= 3 && datosserial.economia[4] >= 10)
		{
			datosserial.mejora1 = 1;
			guardar();
			SceneManager.LoadScene("mejora1_al1");
		}
		if(datosserial.mejora2 == 0 && datosserial.economia[0] >= 6 && datosserial.economia[4] >= 20)
		{
			datosserial.mejora2 = 1;
			guardar();
			SceneManager.LoadScene("mejora2_al1");
		}
		if(datosserial.mejora3 == 0 && datosserial.economia[0] >= 9 && datosserial.economia[4] >= 30)
		{
			datosserial.mejora3 = 1;
			guardar();
			SceneManager.LoadScene("mejora3_al1");
		}
		if(datosserial.mejora4 == 0 && datosserial.economia[0] >= 12 && datosserial.economia[4] >= 40)
		{
			datosserial.mejora4 = 1;
			guardar();
			SceneManager.LoadScene("mejora4_al1");
		}
		if(datosserial.mejora5 == 0 && datosserial.fragmento >= 3 && datosserial.economia[4] >= 50)
		{
			datosserial.mejora5 = 1;
			guardar();
			SceneManager.LoadScene("mejora5_al1");
		}

		jugador_al1 jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		

		if(datosconfig.idioma == "es")
		{
			if (this.piso == 1 && this.datosserial.economia[0] == 0 && dentrotienda == false)
			{
				audio.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 1 && this.datosserial.economia[0] <= 3 && datosserial.tengovel == 0 && dentrotienda == false)
			{
				audio1.Play();
			}
			
			if (this.piso == 1 && this.datosserial.economia[0] >= 3 && this.datosserial.economia[0] <= 6 && dentrotienda == false && datosserial.tengovel == 1 && datosserial.tengocoche == 0)
			{
				audio2.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 6 && this.datosserial.economia[0] <= 9 && datosserial.tengocoche == 1 && dentrotienda == false && datosserial.tengosalto == 0)
			{
				audio3.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 9 && this.datosserial.economia[0] <= 12 && datosserial.tengosalto == 1 && dentrotienda == false && datosserial.tengonave == 0)
			{
				audio4.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 12 && datosserial.tengonave == 1 && dentrotienda == false && datosserial.fragmento < 3 && datosserial.tengomejora == 0 && datosserial.llave[7] == 0)
			{
				audio5.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] == 15 && datosserial.tengomejora == 0 && dentrotienda == false && datosserial.fragmento == 3 && datosserial.llave[7] == 0 && datosserial.economia[4] == 50)
			{
				audio6.Play();
			}
		}
		if(datosconfig.idioma == "en")
		{
			if (this.piso == 1 && this.datosserial.economia[0] == 0 && dentrotienda == false)
			{
				audioen.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 1 && this.datosserial.economia[0] <= 3 && datosserial.tengovel == 0 && dentrotienda == false)
			{
				audio1en.Play();
			}
			
			if (this.piso == 1 && this.datosserial.economia[0] >= 3 && this.datosserial.economia[0] <= 6 && dentrotienda == false && datosserial.tengovel == 1 && datosserial.tengocoche == 0)
			{
				audio2en.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 6 && this.datosserial.economia[0] <= 9 && datosserial.tengocoche == 1 && dentrotienda == false && datosserial.tengosalto == 0)
			{
				audio3en.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 9 && this.datosserial.economia[0] <= 12 && datosserial.tengosalto == 1 && dentrotienda == false && datosserial.tengonave == 0)
			{
				audio4en.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 12 && datosserial.tengonave == 1 && dentrotienda == false && datosserial.fragmento < 3 && datosserial.tengomejora == 0 && datosserial.llave[7] == 0)
			{
				audio5en.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] == 15 && datosserial.tengomejora == 0 && dentrotienda == false && datosserial.fragmento == 3 && datosserial.llave[7] == 0 && datosserial.economia[4] == 50)
			{
				audio6en.Play();
			}
		}
		if(datosconfig.idioma == "cat")
		{
			if (this.piso == 1 && this.datosserial.economia[0] == 0 && dentrotienda == false)
			{
				audiocat.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 1 && this.datosserial.economia[0] <= 3 && datosserial.tengovel == 0 && dentrotienda == false)
			{
				audio1cat.Play();
			}
			
			if (this.piso == 1 && this.datosserial.economia[0] >= 3 && this.datosserial.economia[0] <= 6 && dentrotienda == false && datosserial.tengovel == 1 && datosserial.tengocoche == 0)
			{
				audio2cat.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 6 && this.datosserial.economia[0] <= 9 && datosserial.tengocoche == 1 && dentrotienda == false && datosserial.tengosalto == 0)
			{
				audio3cat.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 9 && this.datosserial.economia[0] <= 12 && datosserial.tengosalto == 1 && dentrotienda == false && datosserial.tengonave == 0)
			{
				audio4cat.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] >= 12 && datosserial.tengonave == 1 && dentrotienda == false && datosserial.fragmento < 3 && datosserial.tengomejora == 0 && datosserial.llave[7] == 0)
			{
				audio5cat.Play();
			}
			if (this.piso == 1 && this.datosserial.economia[0] == 15 && datosserial.tengomejora == 0 && dentrotienda == false && datosserial.fragmento == 3 && datosserial.llave[7] == 0 && datosserial.economia[4] == 50)
			{
				audio6cat.Play();
			}
		}

	}
	public bool mundos = false;
		// Token: 0x04000021 RID: 33

	// Token: 0x04000022 RID: 34
	public GameObject jugador1;

	// Token: 0x04000023 RID: 35
	public GameObject jefe1;

	// Token: 0x04000024 RID: 36
	public Camera normal;

	// Token: 0x04000025 RID: 37
	public float tiement;

	// Token: 0x04000026 RID: 38
	public int juego;

	// Token: 0x04000027 RID: 39
	public bool tutorial;
	public int mundo;

	// Token: 0x04000028 RID: 40
	public int espacio = 0;


	public Text mision1t;

	public Text mision2t;

	// Token: 0x04000029 RID: 41
	public Text cuentagemas;

	// Token: 0x0400002A RID: 42
	public Text cuentamonedas;

	// Token: 0x0400002B RID: 43
	public Text cuentafrag;

	// Token: 0x0400002C RID: 44

	// Token: 0x0400002D RID: 45

	// Token: 0x0400002E RID: 4

	// Token: 0x04000031 RID: 49
	public int piso = 0;

	// Token: 0x04000032 RID: 

	// Token: 0x04000038 RID: 56
	
	// Token: 0x06000026 RID: 38 RVA: 0x000037BC File Offset: 0x000019BC
	private void Update()
	{
		jugador_al1 jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
		if(trofeoact == 1 && datostrof.completaalien1m == 0)
		{
			datostrof.completaalien1m = 1;
			push.push(15);
		}
		if(trofeoact == 2 && datostrof.completaalien1v == 0)
		{
			datostrof.completaalien1v = 1;
			push.push(16);
		}
		if(trofeoact == 3 && datostrof.alien1saladelrey == 0)
		{
			datostrof.alien1saladelrey = 1;
			push.push(19);
		}
		if(trofeoact == 4 && datostrof.alien1salasecreta == 0)
		{
			datostrof.alien1salasecreta = 1;
			push.push(20);
		}
		if(trofeoact == 5 && datostrof.alien1primeracinematica == 0)
		{
			datostrof.alien1primeracinematica = 1;
			push.push(1);
		}
		if(trofeoact == 6 && datosserial.tengomejora == 1 && datostrof.alien1mejora5 == 0)
		{
			datostrof.alien1mejora5 = 1;
			push.push(6);
		}
		if(trofeoact == 5 && datosserial.economia[0] >= 1 && datostrof.alien1consigue1gema == 0)
		{
			datostrof.alien1consigue1gema = 1;
			push.push(7);
		}
		if(trofeoact == 5 && datosserial.economia[0] >= 15 && datostrof.alien1consigue15gemas == 0)
		{
			datostrof.alien1consigue15gemas = 1;
			push.push(9);
		}
		if(trofeoact == 5 && datosserial.economia[4] >= 10 && datostrof.alien1consigue10monedas == 0)
		{
			datostrof.alien1consigue10monedas = 1;
			push.push(8);
		}
		if(trofeoact == 5 && datosserial.economia[4] >= 50 && datosserial.fragmento >= 3 && datostrof.alien1consigue50monedas == 0)
		{
			datostrof.alien1consigue50monedas = 1;
			push.push(10);
		}
		if(trofeoact == 7 && datosserial.economia[4] >= 50 && datosserial.fragmento < 3 && datostrof.alien1consigue50monedas == 0)
		{
			datostrof.alien1consigue50monedas = 1;
			push.push(10);
		}
		if(trofeoact == 5 && datosserial.fragmento >= 3 && datostrof.alien1consiguelagrangema == 0)
		{
			datostrof.alien1consiguelagrangema = 1;
			push.push(11);
		}
		if(trofeoact == 8 && datostrof.alien1usaelcochedelmundo == 0)
		{
			datostrof.alien1usaelcochedelmundo = 1;
			push.push(12);
		}
		if(trofeoact == 6 && datostrof.alien1usalanaveenelespacio == 0)
		{
			datostrof.alien1usalanaveenelespacio = 1;
			push.push(13);
		}
		if(trofeoact == 7 && otroasteroide == true && datostrof.alien1visitaotroasteroide == 0)
		{
			datostrof.alien1visitaotroasteroide = 1;
			push.push(14);
		}
		if(trofeoact == 5 && datosserial.alien1muere == true && datostrof.alien1muere == 0)
		{
			datostrof.alien1muere = 1;
			push.push(17);
		}
		guardartro();
		if(tempshow > 1f && juego == 6 && datosserial.tengomejora == 1)
		{
			hidemenu_al1 hide = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
        	hide.anim.SetBool("show2",false);
		}
		tempshow += 1f * Time.deltaTime;
		

	if(datosconfig.idioma == "es")
	{
	
		if(estados == 1)
		{
			boton1.text = "Para subir a la nave pulsa";
		}
		if(estados == 2)
		{
			boton1.text = "Para subir al ascensor pulsa";
		}
		if(estados == 3)
		{
			boton1.text = "Para bajar de planta pulsa";
			boton2.text = "CRONO";
		}
		if(estados == 4)
		{
			boton1.text = "SALA DEL REY";
		}
		if(estados == 5)
		{
			boton1.text = "SALA SECRETA";
		}
		if(menu == 1)
		{
			boton1.text = "gestion de partidas";
			boton2.text = "Opciones";
			boton3.text = "Comenzar";
			boton4.text = "Salir";
		}
		if(menu == -1)
		{
			boton1.text = "Presenta";
			boton2.text = "Saltar";
		}
		if(menu == -2)
		{
			boton1.text = "Saltar";
		}
		if(menu == 2)
		{
			
		}
		if(menu == 3)
		{
			boton1.text = "Controles";
			boton2.text = "Teclado y raton o mando";
			boton3.text = "Tactil (solo Android)";
			boton4.text = "Idioma";
		}
		if(menu == 4)
		{
			boton1.text = "FIN";
			boton2.text = "Volver al menu";

		}
		if(menu == 5)
		{
			boton1.text = "Controles";
			boton2.text = "Pc o Consola";
			boton3.text = "Dispositivo tactil";
			boton4.text = "En que dispositivo estas jugando?";
			boton5.text = "Si estas jugando en un pc tableta o android selecciona dispositivo tactil si estas en los anteriores dispositivos con un mando o en pc o consola selecciona pc o consola";
			boton6.text = "Una vez selecionado para cambiarlo entra a opciones";
		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == true && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
			

		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 2 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 3 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 4 && dentrotienda == false && pauseact == false|| mundo != 0)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";

			if (datosserial.economia[0] == 0)
			{
				this.mision = "MISION: Cruza una puerta y consigue una gema completando un nivel";
			}
			if (datosserial.economia[0] == 1 && datosserial.economia[4] < 10)
			{
				this.mision = "MISION: Haz los 2 niveles que quedan y baja abajo y consigue 10 monedas";
			}
			if (datosserial.economia[0] == 2 && datosserial.economia[4] < 10)
			{
				this.mision = "MISION: Haz el nivel que te queda y baja abajo y consigue 10 monedas";
			}
			if (datosserial.economia[0] == 3 && datosserial.economia[4] < 10)
			{
				this.mision = "MISION: Baja abajo y consigue 10 monedas";
			}
			if (datosserial.economia[0] == 1 && datosserial.economia[4] == 10)
			{
				this.mision = "MISION: Haz los 2 niveles que quedan";
			}
			if (datosserial.economia[0] == 2 && datosserial.economia[4] == 10)
			{
				this.mision = "MISION: Haz el nivel que te queda";
			}
			if (datosserial.economia[0] == 3 && datosserial.economia[4] == 10 && datosserial.tengovel == 0)
			{
				this.mision = "MISION: Ve a la tienda del primer  piso y recoge el acelerador";
			}
			if (datosserial.economia[0] <= 6 && datosserial.economia[4] <= 20 && datosserial.tengovel == 1)
			{
				this.mision = "MISION: Sube al segundo piso y consigue 6 gemas  baja al espacio y llega a las 20 monedas usando el acelerador";
			}
			if (datosserial.economia[0] == 6 && datosserial.economia[4] == 20 && datosserial.tengocoche == 0)
			{
				this.mision = "MISION: Ve a la tienda y recoge tu nuevo coche";
			}
			if (datosserial.economia[0] <= 9 && datosserial.economia[4] <= 30 && datosserial.tengocoche == 1)
			{
				this.mision = "MISION: Sube al tercer piso y consigue 9 gemas                                                     baja al espacio y llega a las 30 monedas usando el coche para usarlo tocalo";
			}
			if (datosserial.economia[0] == 9 && datosserial.economia[4] == 30 && datosserial.tengosalto == 0)
			{
				this.mision = "MISION: Ve a la tienda y recoge el saltador";
			}
			if (datosserial.economia[0] <= 12 && datosserial.economia[4] <= 40 && datosserial.tengosalto == 1)
			{
				this.mision = "MISION: Sube al cuarto piso y consigue 12 gemas                                                     baja al espacio y llega a las 40 monedas usando el saltador";
			}
			if (datosserial.economia[0] == 12 && datosserial.economia[4] == 40 && datosserial.tengonave == 0)
			{
				this.mision = "MISION: Ve a la tienda y recoge la nave espacial";
			}
			if (datosserial.economia[0] == 12 && datosserial.economia[4] == 40 && datosserial.tengonave == 1)
			{
				this.mision = "MISION fase 1: Usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 13 gemas";
			}
			if (datosserial.economia[0] == 13 && datosserial.tengonave == 1 && datosserial.llave[4] == 0)
			{
				this.mision = "MISION fase 1: Ve a la tienda y recoge la llave secreta de las minas del piso 2 ";
			}
			if (datosserial.economia[0] == 13 &&  datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0)
			{
				this.mision = "MISION fase 1: Usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 14 gemas";
			}
			if (datosserial.economia[0] == 14 && datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 0)
			{
				this.mision = "MISION fase 1: Ve a la tienda y recoge la llave secreta de las minas del piso 3 ";
			}
			if (datosserial.economia[0] == 14 &&  datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0)
			{
				this.mision = "MISION fase 1: Usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 15 gemas";
			}
			if (datosserial.economia[0] == 15 && datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0)
			{
				this.mision = "MISION fase 1: vV a la tienda y recoge la llave secreta de las minas del piso 4 ";
			}
			if (datosserial.economia[0] == 14 && datosserial.tengonave == 1 && datosserial.llave[4] == 0 && datosserial.llave[5] == 0)
			{
				this.mision = "MISION fase 1: Ve a la tienda y recoge la llave secreta de las minas del piso 2 y 3 ";
			}
			if (datosserial.economia[0] == 15 && datosserial.tengonave == 1 && datosserial.llave[4] == 0 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0)
			{
				this.mision = "MISION fase 1: Ve a la tienda y recoge la llave secreta de las minas del piso 2,3 y 4 ";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISION fase 2: Ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISION fase 2: Ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISION fase 2: Ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1)
			{
				this.mision2 = "MISION fase 2: Ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0)
			{
				this.mision2 = "MISION fase 2: Ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 0 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISION fase 2: Ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISION fase 2: Ve al piso 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISION fase 2: Ve al cuarto piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISION fase 2: Ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISION fase 2: Ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISION fase 2: Ve al piso 2 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISION fase 2: Ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.fragmento == 3 && datosserial.economia[4] < 50 && datosserial.llave[7] == 0)
			{
				this.mision = "MISION fase 3: Consigue 50 monedas por el espacio";
			}
			if (datosserial.fragmento == 3 && datosserial.economia[4] == 50 && datosserial.llave[7] == 0)
			{
				this.mision = "MISION fase 3: Ve a la tienda y recoje la llave del quinto piso";
			}

			if (datosserial.fragmento == 3 && datosserial.llave[7] == 1 && datosserial.tengomejora == 0)
			{
				this.mision = "MISION fase 3: Recoje el hiperpropulsor en el quinto piso";
			}
			if (datosserial.fragmento == 3 && datosserial.tengomejora == 1)
			{
				this.mision = "MISION fase final: Ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera tus records";
			}
			

			
		}
		if (piso == 5 && datosserial.tengomejora == 1)
		{
			this.mision = "MISION fase final: Ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera los records negtivos";
		}
		if (this.juego == 4 && this.piso == 10  && pauseact == false|| this.juego == 1 && this.piso == 10  && pauseact == false|| this.juego == 4 && this.piso == 1 && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
			
		}
		if (this.juego == 4 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 1 && this.piso == 10 && this.mundos == true && pauseact == false || this.juego == 4 && this.piso == 1 && this.mundos == true && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
		}
		if (juego == 6 && datosserial.tengomejora == 1)
		{

			this.mision = "MISION fase final: Vuela arriba a la plataforma de aterrizaje y sal de esta galaxia";
		}
		}
	if(datosconfig.idioma == "en")
	{
		if(estados == 1)
		{
			boton1.text = "To go up to ship";
		}
		if(estados == 2)
		{
			boton1.text = "To get on the elevator";
		}
		if(estados == 3)
		{
			boton1.text = "To go down the floor";
			boton2.text = "CRONO";
		}
		if(estados == 4)
		{
			boton1.text = "KING'S ROOM";
		}
		if(estados == 5)
		{
			boton1.text = "SECRET ROOM";
		}
		if(menu == 1)
		{
			boton1.text = "Delete data";
			boton2.text = "Settings";
			boton3.text = "Start adventure";
			boton4.text = "exit";
		}
		if(menu == -1)
		{
			boton1.text = "Presents";
			boton2.text = "Skip";
		}
		if(menu == -2)
		{
			boton1.text = "Skip";
		}
		if(menu == 2)
		{
			boton1.text = "You're sure?";
			boton2.text = "Delete data";
			boton3.text = "Go back";
		}
		if(menu == 3)
		{
			boton1.text = "Controls";
			boton2.text = "Keyboard and mouse or controller";
			boton3.text = "Touch controls";
			boton4.text = "Language";
		}
		if(menu == 4)
		{
			boton1.text = "THE END";
			boton2.text = "Back to menu";

		}
		if(menu == 5)
		{
			boton1.text = "Controls";
			boton2.text = "Pc or console";
			boton3.text = "Touch device";
			boton4.text = "What device are you playing on?";
			boton5.text = "If you are playing on a tablet or android pc select touch device if you are on the above devices with a controller or on pc or console select pc or console";
			boton6.text = "Once selected to change it go to settings";
		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == true && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";

		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 2 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 3 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 4 && dentrotienda == false && pauseact == false || mundo != 0)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";

			if (datosserial.economia[0] == 0)
			{
				this.mision = "MISSION: Go through a door and get a gem by completing a level";
			}
			if (datosserial.economia[0] == 1 && datosserial.economia[4] < 10)
			{
				this.mision = "MISSION: Do the remaining 2 levels and go downstairs and get 10 coins";
			}
			if (datosserial.economia[0] == 2 && datosserial.economia[4] < 10)
			{
				this.mision = "MISSION: Do the level you have left and go down below and get 10 coins";
			}
			if (datosserial.economia[0] == 3 && datosserial.economia[4] < 10)
			{
				this.mision = "MISSION: Go downstairs and get 10 coins";
			}
			if (datosserial.economia[0] == 1 && datosserial.economia[4] == 10)
			{
				this.mision = "MISSION: Do the remaining 2 levels";
			}
			if (datosserial.economia[0] == 2 && datosserial.economia[4] == 10)
			{
				this.mision = "MISSION: Do the level you have left";
			}
			if (datosserial.economia[0] == 3 && datosserial.economia[4] == 10 && datosserial.tengovel == 0)
			{
				this.mision = "MISSION: Go to the shop on the first floor and pick up the accelerator";
			}
			if (datosserial.economia[0] <= 6 && datosserial.economia[4] <= 20 && datosserial.tengovel == 1)
			{
				this.mision = "MISSION: Go up to the second floor and get 6 gems go down to space and reach 20 coins using the accelerator";
			}
			if (datosserial.economia[0] == 6 && datosserial.economia[4] == 20 && datosserial.tengocoche == 0)
			{
				this.mision = "MISSION: Go to the store and pick up your new car";
			}
			if (datosserial.economia[0] <= 9 && datosserial.economia[4] <= 30 && datosserial.tengocoche == 1)
			{
				this.mision = "MISSION: Go up to the third floor and get 9 gems go down to space and reach 30 coins using the car to use it touch it";
			}
			if (datosserial.economia[0] == 9 && datosserial.economia[4] == 30 && datosserial.tengosalto == 0)
			{
				this.mision = "MISSION: Go to the store and pick up the jumper";
			}
			if (datosserial.economia[0] <= 12 && datosserial.economia[4] <= 40 && datosserial.tengosalto == 1)
			{
				this.mision = "MISSION: Go up to the fourth floor and get 12 gems go down to space and reach 40 coins using the jumper";
			}
			if (datosserial.economia[0] == 12 && datosserial.economia[4] == 40 && datosserial.tengonave == 0)
			{
				this.mision = "MISSION: Go to the store and pick up the spaceship";
			}
			if (datosserial.economia[0] == 12 && datosserial.economia[4] == 40 && datosserial.tengonave == 1)
			{
				this.mision = "MISSION phase 1: Use the spaceship on your property by touching it in the free zone and travel to asteroids and reach all 13 gems";
			}
			if (datosserial.economia[0] == 13 && datosserial.tengonave == 1 && datosserial.llave[4] == 0)
			{
				this.mision = "MISSION phase 1: Go to the store and collect the secret key to the mines on floor 2";
			}
			if (datosserial.economia[0] == 13 &&  datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0)
			{
				this.mision = "MISSION phase 1: Use the spaceship on your property by touching it in the free zone and travel to asteroids and reach 14 gems";
			}
			if (datosserial.economia[0] == 14 && datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 0)
			{
				this.mision = "MISSION phase 1: Go to the store and collect the secret key to the mines on floor 3";
			}
			if (datosserial.economia[0] == 14 &&  datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0)
			{
				this.mision = "MISSION phase 1: Use the spaceship on your property by touching it in the free zone and travel to asteroids and reach 15 gems";
			}
			if (datosserial.economia[0] == 15 && datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0)
			{
				this.mision = "MISSION phase 1: Go to the store and collect the secret key to the mines on floor 4";
			}
			if (datosserial.economia[0] == 14 && datosserial.tengonave == 1 && datosserial.llave[4] == 0 && datosserial.llave[5] == 0)
			{
				this.mision = "MISSION phase 1: Go to the store and collect the secret key to the mines on floor 2 and 3";
			}
			if (datosserial.economia[0] == 15 && datosserial.tengonave == 1 && datosserial.llave[4] == 0 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0)
			{
				this.mision = "MISSION phase 1: Go to the store and collect the secret key to the mines on floors 2, 3 and 4";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISSION phase 2: Go to the second floor and get a large gem fragment in the secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISSION phase 2: Go to floor 2 and 3 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISSION phase 2: Go to floor 2, 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1)
			{
				this.mision2 = "MISSION phase 2: Go to the second floor and get a large gem fragment in the secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0)
			{
				this.mision2 = "MISSION phase 2: Go to the third floor and get a large gem fragment in the secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 0 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISSION phase 2: Go to floor 2, 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISSION phase 2: Go to floor 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISSION phase 2: Go to the fourth floor and get a large gem fragment in the secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISSION phase 2: Go to floor 2 and 3 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISSION phase 2: Go to the second floor and get a large gem fragment in the secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISSION phase 2: Go to floor 2 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISSION phase 2: Go to the third floor and get a large gem fragment in the secret level";
			}
			if (datosserial.fragmento == 3 && datosserial.economia[4] < 50 && datosserial.llave[7] == 0)
			{
				this.mision = "MISSION phase 3: Get 50 Coins in the space";
			}
			if (datosserial.fragmento == 3 && datosserial.economia[4] == 50 && datosserial.llave[7] == 0)
			{
				this.mision = "MISSION phase 3: Go to the store and collect the key to the fifth floor";
			}

			if (datosserial.fragmento == 3 && datosserial.llave[7] == 1 && datosserial.tengomejora == 0)
			{
				this.mision = "MISSION phase 3: Pick up the hyperdrive on the fifth floor";
			}
			if (datosserial.fragmento == 3 && datosserial.tengomejora == 1)
			{
				this.mision = "MISSION final phase: Go to space with the ship and get out of this galaxy you have unlocked the tower of time go up to the fifth floor and beat your records";
			}
			

			
		}
		if (piso == 5 && datosserial.tengomejora == 1)
		{
			this.mision = "MISSION final phase: Go to space with the ship and get out of this galaxy you have unlocked the tower of time go up to the fifth floor and beat your recordss";
		}
		if (this.juego == 4 && this.piso == 10  && pauseact == false|| this.juego == 1 && this.piso == 10 && pauseact == false || this.juego == 4 && this.piso == 1 && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
		}
		if (this.juego == 4 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 1 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 4 && this.piso == 1 && this.mundos == true && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
		}
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			this.mision = "MISSION final phase: Fly up to the landing platform and get out of this galaxy";
		}
		}
	if(datosconfig.idioma == "cat")
	{
	
		if(estados == 1)
		{
			boton1.text = "Per putjar a la nau";
		}
		if(estados == 2)
		{
			boton1.text = "PEr putjar al ascensor";
		}
		if(estados == 3)
		{
			boton1.text = "Per baixar de planta";
			boton2.text = "CRONO";
		}
		if(estados == 4)
		{
			boton1.text = "SALA D EL REY";
		}
		if(estados == 5)
		{
			boton1.text = "SALA SECRETA";
		}
		if(menu == 1)
		{
			boton1.text = "Esborra data";
			boton2.text = "Opcions";
			boton3.text = "Comencar joc";
			boton4.text = "Sortir";
		}
		if(menu == -1)
		{
			boton1.text = "Presenta";
			boton2.text = "Salta";
		}
		if(menu == -2)
		{
			boton1.text = "Salta";
		}
		if(menu == 2)
		{
			boton1.text = "Estas segur?";
			boton2.text = "Esborra data";
			boton3.text = "Tornar andarrere";
		}
		if(menu == 3)
		{
			boton1.text = "Controls";
			boton2.text = "Teclat y ratoli o control";
			boton3.text = "Tactil (sol android)";
			boton4.text = "Idioma";
		}
		if(menu == 4)
		{
			boton1.text = "FI";
			boton2.text = "Tornar al menu";

		}
		if(menu == 5)
		{
			boton1.text = "Controls";
			boton2.text = "Pc o consola";
			boton3.text = "Dispositiu tactil";
			boton4.text = "En quin dispositiu estas jugan?";
			boton5.text = "Si estas jugan a un pc tableta o android selecciona dispositiu tactil si estas als anteriors dispositius amb un control o a un pc o consola selecciona pc o consola";
			boton6.text = "Una vegada selecionat per cambiaro entra a opcions";
		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == true && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";

		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == false  && pauseact == false || this.juego == 0 && this.piso == 2 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 3 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 4 && dentrotienda == false && pauseact == false || mundo != 0)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";

			if (datosserial.economia[0] == 0)
			{
				this.mision = "MISIO: Creua una porta i consegueix una gema completan un nivell";
			}
			if (datosserial.economia[0] == 1 && datosserial.economia[4] < 10)
			{
				this.mision = "MISIO: Fes els 2 niveles que queden i baixa abaix i agafa 10 monedes";
			}
			if (datosserial.economia[0] == 2 && datosserial.economia[4] < 10)
			{
				this.mision = "MISIO: Fes el nivell que et queda i baixa abaix i agafa 10 monedes";
			}
			if (datosserial.economia[0] == 3 && datosserial.economia[4] < 10)
			{
				this.mision = "MISIO: Baixa abaix i agafa 10 monedes";
			}
			if (datosserial.economia[0] == 1 && datosserial.economia[4] == 10)
			{
				this.mision = "MISIO: Fes els 2 niveles que queden";
			}
			if (datosserial.economia[0] == 2 && datosserial.economia[4] == 10)
			{
				this.mision = "MISIO: Fes el nivell que et queda";
			}
			if (datosserial.economia[0] == 3 && datosserial.economia[4] == 10 && datosserial.tengovel == 0)
			{
				this.mision = "MISIO: Ves a la tenda del primer  pis i agafa el acelerador";
			}
			if (datosserial.economia[0] <= 6 && datosserial.economia[4] <= 20 && datosserial.tengovel == 1)
			{
				this.mision = "MISIO: Puja al segon pis i agafa 6 gemmes  baixa al espai y arriba a les 20 monedes fent servir el acelerador";
			}
			if (datosserial.economia[0] == 6 && datosserial.economia[4] == 20 && datosserial.tengocoche == 0)
			{
				this.mision = "MISIO: Ves a la tenda i agafa el teu nuo cotxe";
			}
			if (datosserial.economia[0] <= 9 && datosserial.economia[4] <= 30 && datosserial.tengocoche == 1)
			{
				this.mision = "MISIO: Puja al tercer pis i agafa 9 gemmes                                                     baixa al espai y arriba a les 30 monedes fent servir el cotxe per ferlo servir tocal";
			}
			if (datosserial.economia[0] == 9 && datosserial.economia[4] == 30 && datosserial.tengosalto == 0)
			{
				this.mision = "MISIO: Ves a la tenda y agafa el saltador";
			}
			if (datosserial.economia[0] <= 12 && datosserial.economia[4] <= 40 && datosserial.tengosalto == 1)
			{
				this.mision = "MISIO: Puja al quart pis i agafa 12 gemmes                                                    baixa al espai i arriba a les 40 monedes fent servir el saltador";
			}
			if (datosserial.economia[0] == 12 && datosserial.economia[4] == 40 && datosserial.tengonave == 0)
			{
				this.mision = "MISIO: Ves a la tenda y agafa la nau espacial";
			}
			if (datosserial.economia[0] == 12 && datosserial.economia[4] == 40 && datosserial.tengonave == 1)
			{
				this.mision = "MISIO fase 1: Fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 13 gemmes";
			}
			if (datosserial.economia[0] == 13 && datosserial.tengonave == 1 && datosserial.llave[4] == 0)
			{
				this.mision = "MISIO fase 1: Ves a la tenda y recull la clau secreta de les mines del pis 2 ";
			}
			if (datosserial.economia[0] == 13 &&  datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0)
			{
				this.mision = "MISIO fase 1: Fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 14 gemmes";
			}
			if (datosserial.economia[0] == 14 && datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 0)
			{
				this.mision = "MISIO fase 1: Ves a la tenda i recull la clau secreta de les mines del pis 3";
			}
			if (datosserial.economia[0] == 14 &&  datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0)
			{
				this.mision = "MISIO fase 1: Fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 15 gemmes";
			}
			if (datosserial.economia[0] == 15 && datosserial.tengonave == 1 && datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0)
			{
				this.mision = "MISIO fase 1: Ves a la tenda i recull la clau secreta de les mines del pis 4 ";
			}
			if (datosserial.economia[0] == 14 && datosserial.tengonave == 1 && datosserial.llave[4] == 0 && datosserial.llave[5] == 0)
			{
				this.mision = "MISIO fase 1:Ves a la tenda i recull la clau secreta de les mines del pis 2 i 4 ";
			}
			if (datosserial.economia[0] == 15 && datosserial.tengonave == 1 && datosserial.llave[4] == 0 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0)
			{
				this.mision = "MISIO fase 1: Ves a la tenda i recull la clau secreta de les mines del pis 2,3 i 4";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 0 && datosserial.llave[6] == 0 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al segon pis i agafa un fragment de gran gemmme en el nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al pis 2 i 3 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al pis 2, 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1)
			{
				this.mision2 = "MISIO fase 2: Ves al segon pis y agafa el fragment de gran gemme en el nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al tercer pis y agafa el fragment de gran gemme en el nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 0 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al pis 2, 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al pis 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al quart pis i agafa un fragment de gran gemmme en el nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISIO fase 2: Ves al pis 2 i 3 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISIO fase 2: Ves al seguon pis i agafa un fragment de gran gemme en el nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2 = "MISIO fase 2: Ves al pis 2 y 4 i agafa un fragment de gran gemme en el seu respectiu nivell secret";
			}
			if (datosserial.llave[4] == 1 && datosserial.llave[5] == 1 && datosserial.llave[6] == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2 = "MISIO fase 2: Ves al tercer pis y agafa un fragment de gran gemme en el nivell secret";
			}
			if (datosserial.fragmento == 3 && datosserial.economia[4] < 50 && datosserial.llave[7] == 0)
			{
				this.mision = "MISIO fase 3: Agafa 50 monedes en el espai amb la nau";
			}
			if (datosserial.fragmento == 3 && datosserial.economia[4] == 50 && datosserial.llave[7] == 0)
			{
				this.mision = "MISIO fase 3: Ves a la tenda i agafa la calu del cinque pis";
			}

			if (datosserial.fragmento == 3 && datosserial.llave[7] == 1 && datosserial.tengomejora == 0)
			{
				this.mision = "MISIO fase 3: Recull el hiperpropulsor en el cinque pis";
			}
			if (datosserial.fragmento == 3 && datosserial.tengomejora == 1)
			{
				this.mision = "MISIO fase final: Ves al espaci amb la nau i vesten d aquesta galaxia                 has desbloquejat la torre del temps puja a d alt del cinque pis y supera els records negatius";
			}
			

			
		}
		if (piso == 5 && datosserial.tengomejora == 1)
		{
			this.mision = "MISIO fase final: Ves al espai amb la nau y vesten de aquesta galaxia                 has desbloquejat la torre del temps puja a d alt del cinque pis y supera els records negatius";
		}
		if (this.juego == 4 && this.piso == 10  && pauseact == false|| this.juego == 1 && this.piso == 10  && pauseact == false|| this.juego == 4 && this.piso == 1 && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
		}
		if (this.juego == 4 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 1 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 4 && this.piso == 1 && this.mundos == true  && pauseact == false)
		{
			this.cuentamonedas.text = this.datosserial.economia[4]+"";
			this.cuentagemas.text = this.datosserial.economia[0]+"/15";
			tmonedar.text = + datosserial.economia[3]+"";
			tllave.text = datosserial.economia[1]+"/4";
			this.cuentafrag.text = datosserial.fragmento+"/3";
		}
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			this.mision = "MISION fase final: Vola a d'alt d la plataforma de aterricaje y surt d aquesta galaxia";
		}
		}
		if(mision == "" && mision == "")
		{
			mision = "Mision:";
		}



	}


}
