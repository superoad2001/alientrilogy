using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine.Audio;
using MeetAndTalk.Localization;

public class managerBASE : MonoBehaviour
{

    public int cmenu;

    public Text boton1;
	public Text boton2;
	public Text boton3;
	public Text boton4;
	public Text boton5;
	public Text boton6;
	public Text boton7;
    public Text boton8;
    public Text boton9;
    public AudioMixer audiomixer;



	[SerializeField]
	public datosconfig datosconfig;
    [SerializeField]
	public datosextra datostrof;
	public string repath;
    public string repathtro;
    public AudioSource moveson;

	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C

	public void move()
	{
		moveson.Play();
	}

	public void GetFilePath()
    {
        string result;
 
        result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alienconfigdata.data");
        #if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alienconfigdata.data");
		#endif
 
        repath = result;
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

	public void guardar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosconfig1 = JsonUtility.ToJson(datosconfig);
            File.WriteAllText(path,datosconfig1);
            Debug.Log(datosconfig1);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosconfig1 = JsonUtility.ToJson(datosconfig);
            File.WriteAllText(path,datosconfig1);
            Debug.Log(datosconfig1);
        }
        
    }
    public void guardartro()
    {
        GetFilePathtro();
        string path = repathtro;
        if(File.Exists(path))
        {
            string datosconfig2 = JsonUtility.ToJson(datostrof);
            File.WriteAllText(path,datosconfig2);
            Debug.Log(datosconfig2);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosconfig2 = JsonUtility.ToJson(datostrof);
            File.WriteAllText(path,datosconfig2);
            Debug.Log(datosconfig2);
        }
        
    }

	public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosconfig1 = File.ReadAllText(path);
            datosconfig = JsonUtility.FromJson<datosconfig>(datosconfig1);
            Debug.Log(datosconfig1);
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
            Debug.Log(datosconfig2);
        }
        
    }

	public void borrar_data()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosconfig1 = JsonUtility.ToJson("");
            File.WriteAllText(path,datosconfig1);
        }
        cargar();
        
    }

	private void Awake() 
	{
		cargar();
        cargartro();
	}
	private void Start()
	{

		cargar();
        cargartro();

        LocalizationManager.Instance.selectedLang = SystemLanguage.English;

        audiomixer.SetFloat ("MusicVolume",datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",datosconfig.ui);


        if(datosconfig.idioma == "es")
	    {
            if(cmenu == 1)
            {
                boton1.text = "Controles";
                boton2.text = "pc o consola";
                boton3.text = "dispositivo tactil";
                boton4.text = "en que dispositivo estas jugando?";
                boton5.text = "si estas jugando en un pc tableta o android selecciona dispositivo tactil si estas en los anteriores dispositivos con un mando o en pc o consola selecciona pc o consola";
                boton6.text = "una vez selecionado para cambiarlo entra a opciones";
            }
            if(cmenu == 2)
            {
                boton1.text = "ENTRAR";
                boton2.text = "SALIR";
            }
            if(cmenu == 3)
            {
                boton1.text = "Elige una distancia de dibujado subirla consume recursos del dispositivo";
                boton2.text = "Distancia de dibujado";
                boton3.text = "Una vez selecionado para cambiarlo entra a opciones";
            }
            if(cmenu == 4)
            {
                boton1.text = "Mejora grafica";
                boton2.text = "Post procesado desactivado";
                boton3.text = "Post procesado activado";
                boton4.text = "Si juegas en un dispositivo con recursos moderados podras usar la mejora grafica";
                boton5.text = "El post procesado puede crashear el juego en ciertos dispositivos si esto sucede resetea la configuracion con el boton de recuperacion al inicio del juego";
                boton6.text = "Una vez selecionado para cambiarlo entra a opciones";
            }
            if(cmenu == 5)
            {
                boton1.text = "CONTROLES";
                boton2.text = "IDIOMA";
                boton3.text = "DISTANCIA DE DIBUJADO";
                boton4.text = "POST PROCESADO";
                boton5.text = "SONIDO";
                boton6.text = "MUSICA";
                boton7.text = "VOCES";
                boton8.text = "SFX";
                boton9.text = "LOGROS";
            }
            if(cmenu == 6)
            {
                boton1.text = "atras";
            }
        }
        if(datosconfig.idioma == "en")
	    {
            if(cmenu == 1)
            {
                boton1.text = "controls";
                boton2.text = "pc or console";
                boton3.text = "touch device";
                boton4.text = "what device are you playing on?";
                boton5.text = "if you are playing on a tablet or android pc select touch device if you are on the above devices with a controller or on pc or console select pc or console";
                boton6.text = "once selected to change it go to settings";
            }
            if(cmenu == 2)
            {
                boton1.text = "play";
                boton2.text = "exit";
            }
            if(cmenu == 3)
            {
                boton1.text = "choose a drawing distance upload it consumes device resources";
                boton2.text = "draw distance";
                boton3.text = "once selected to change it go to settings";
            }
            if(cmenu == 4)
            {
                boton1.text = "mejora grafica";
                boton2.text = "post processing disabled";
                boton3.text = "post processing enabled";
                boton4.text = "If you play on a device with moderate resources you can use the graphic improvement";
                boton5.text = "The post processing may crash the game on certain devices. If this happens, reset the settings with the recovery button at the start of the game.";
                boton6.text = "once selected to change it go to settings";
            }
            if(cmenu == 5)
            {
                boton1.text = "controls";
                boton2.text = "language";
                boton3.text = "drawing distance";
                boton4.text = "post processed";
                boton5.text = "sound";
                boton6.text = "music";
                boton7.text = "voices";
                boton8.text = "sfx";
                boton9.text = "trophies";
            }
            if(cmenu == 6)
            {
                boton1.text = "back";
            }
        }
        if(datosconfig.idioma == "cat")
	    {
            if(cmenu == 1)
            {
                boton1.text = "controls";
                boton2.text = "pc o consola";
                boton3.text = "dispositiu tactil";
                boton4.text = "en quin dispositiu estas jugan?";
                boton5.text = "si estas jugan a un pc tableta o android selecciona dispositiu tactil si estas als anteriors dispositius amb un control o a un pc o consola selecciona pc o consola";
                boton6.text = "una vegada selecionat per cambiaro entra a opcions";
            }
            if(cmenu == 2)
            {
                boton1.text = "entra";
                boton2.text = "sortir";
            }
            if(cmenu == 3)
            {
                boton1.text = "escull una distancia de dibuxat pujarla consumeix recursos del dispositiu";
                boton2.text = "distancia de dibuxat";
                boton3.text = "una vegada selecionat per cambiaro entra a opcions";
            }
            if(cmenu == 4)
            {
                boton1.text = "millora grafica";
                boton2.text = "post procesat desactivat";
                boton3.text = "post procesat activat";
                boton4.text = "si juegas en un dispositiu amb recursos moderats podras usar la millora grafica";
                boton5.text = "el post procesat pot crashejar el joc en certs dispositius si aixo pasa resetea la configuracio amb el boton de recuperacion al inici del joc";
                boton6.text = "una vegada selecionat per cambiaro entra a opcions";
            }
            if(cmenu == 5)
            {
                boton1.text = "controls";
                boton2.text = "idioma";
                boton3.text = "distancia de dibuxat";
                boton4.text = "post procesat";
                boton5.text = "so";
                boton6.text = "musica";
                boton7.text = "veus";
                boton8.text = "sfx";
                boton9.text = "trofeus";
            }
            if(cmenu == 6)
            {
                boton1.text = "anrere";
            }
        }
		

	}
    public void Update()
    {
        if(datosconfig.idioma == "es")
	    {
            if(cmenu == 5)
            {
                boton1.text = "Controles";
                boton2.text = "Idioma";
                boton3.text = "Distancia de Dibujado";
                boton4.text = "Post Procesado";
                boton5.text = "Sonido";
                boton6.text = "Musica";
                boton7.text = "Voces";
                boton8.text = "SFX";
                boton9.text = "Logros";
            }
        }
        if(datosconfig.idioma == "en")
	    {
            if(cmenu == 5)
            {
                boton1.text = "controls";
                boton2.text = "language";
                boton3.text = "drawing distance";
                boton4.text = "post processed";
                boton5.text = "sound";
                boton6.text = "music";
                boton7.text = "voices";
                boton8.text = "sfx";
                boton9.text = "trophies";
            }
        }
        if(datosconfig.idioma == "cat")
	    {
            if(cmenu == 5)
            {
                boton1.text = "controls";
                boton2.text = "idioma";
                boton3.text = "distancia de dibuxat";
                boton4.text = "post procesat";
                boton5.text = "so";
                boton6.text = "musica";
                boton7.text = "veus";
                boton8.text = "sfx";
                boton9.text = "trofeus";
            }
        }
    }
}
