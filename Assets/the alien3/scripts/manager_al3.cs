using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.Audio;
using MeetAndTalk.Localization;

public class manager_al3: MonoBehaviour
{
	public manager_al3 manager;
	public int trofeoact;
	public int jefen = 0;
	public int cmenu = 0;
	public int menu = 1;
	public float tempm11;
	public Text jefetitulo;

	public Text bloque1;
	public Text bloque2;
	public Text bloque3;
	public Text bloque4;
	public Text bloque5;
	public Text bloque6;
	public Text bloque7;
	public Text mision;
	public bool misionact;

	public AudioSource audio;

	public AudioSource audio1;

	public AudioSource audio2;

	public AudioSource audio3;

	public AudioSource audio4;

	public AudioSource audio5;

	public AudioSource audio6;

	public AudioSource audio7;

	public GameObject jugadorpos;

	public GameObject boxcampos;

	public GameObject p1c;

	public GameObject p2c;

	public bool mundos;

	public GameObject jefe1;

	public Camera normal;

	public float tiement;

	public int juego;

	public bool tutorial;

	public int espacio;

	public Text cuentavidas;



	public int nivel;






	public GameObject touch;
	public bool niveltouch = false;

	public bool jefe1_act1 = false;
    public bool jefe1_act2 = false;

	public string repath;
	public string repathconfig;

	[SerializeField]
	public datos3 datosserial;



	[SerializeField]
	public datosconfig datosconfig;
	[SerializeField]
	public datosextra datostrof;
	[SerializeField]
	public datosconfigslot datosslot;

	public string repathslot;

	public string repathtro;
	public AudioSource moevson;

    public datos3[] datosserialallslots = new datos3[6];
	public string[] repathallslots = new string[6];

	public AudioMixer audiomixer;
	public int MisionesCumplidas;

    	public void GetFilePathallslots(int slot)
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        repathallslots[slot] = Path.Combine(result, $"alien3data"+(slot+1).ToString()+".data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
       	repathallslots[slot] = Path.Combine(result, $"alien3data"+(slot+1).ToString()+".data");
		#endif
 
        if(File.Exists(repathallslots[slot]))
        {
            string datosall = File.ReadAllText(repathallslots[slot]);
            datosserialallslots[slot] = JsonUtility.FromJson<datos3>(datosall);
        }
    }

	public void cargarallslots()
    {
        GetFilePathallslots(0);
		GetFilePathallslots(1);
		GetFilePathallslots(2);
		GetFilePathallslots(3);
		GetFilePathallslots(4);
		GetFilePathallslots(5);       
    }


	public void move()
	{
		moevson.Play();
	}

	public void GetFilePathslot()
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"datosslot3.data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"datosslot3.data");
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
        result = Path.Combine(result, $"alien3data"+datosslot.datos3slot+".data");
		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alien3data"+datosslot.datos3slot+".data");
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

	public void guardar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = JsonUtility.ToJson(datosserial);
            File.WriteAllText(path,datosinventario);
            Debug.Log(datosinventario);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosinventario = JsonUtility.ToJson(datosserial);
            File.WriteAllText(path,datosinventario);
            Debug.Log(datosinventario);
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
	public void cargarconfig()
    {
        GetFilePathconfig();
        string path = repathconfig;
        if(File.Exists(path))
        {
            string datosconfig1 = File.ReadAllText(path);
            datosconfig = JsonUtility.FromJson<datosconfig>(datosconfig1);
            Debug.Log(datosconfig1);
        }
        
    }
	public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = File.ReadAllText(path);
            datosserial = JsonUtility.FromJson<datos3>(datosinventario);
            Debug.Log(datosinventario);
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
	private void Awake() 
	{
		cargar();
		cargarconfig();
		cargartro();
	}
	private void Start()
	{
		cargarconfig();
		cargar();
		cargartro();

		LocalizationManager.Instance.selectedLang = datosconfig.sysidi;
		
		guardartro();

		audiomixer.SetFloat ("MusicVolume",datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",datosconfig.ui);

		
		jugador1_al3 jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
		


		if(niveltouch == true && datosconfig.plat == 2)
		{
			touch.SetActive(true);
		}


		jugador1_al3 jugador1 = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));

		//fase 1
		
	}

	public void Update()
	{
		manager_al2 manageral2 = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		//pushup push = (pushup)FindFirstObjectByType(typeof(pushup));



					
			
		
		jugador1_al3 jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
		if(datosserial.marma11 < 3 && tempm11 > 25)
		{
			datosserial.marma11++;
			tempm11 = 0f;
		}
		else if(tempm11 < 30)
		{tempm11 += 1 * Time.deltaTime;}

		
	}
}
