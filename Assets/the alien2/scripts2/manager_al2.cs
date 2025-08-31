using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.Audio;
using MeetAndTalk.Localization;

public class manager_al2 : MonoBehaviour
{
	public int MisionesCumplidas;
	public AudioSource moveson;

	public bool nomundo = true;
	public bool espaciom;
	public int mundo;
	public int inicio;
	public int tuto = 0;
	public int estado = 0;
	public int menu = 0;
	public bool pauseact;
	public bool nivelact;
	public int paginas;
	public bool controlene;
	public int misionS;

	public AudioSource audio0;

	public AudioSource audio1;

	public AudioSource audio2;

	public AudioSource audio3;

	public GameObject jugadorpos;

	public GameObject boxcampos;

	public GameObject p1c;

	public GameObject p2c;

	public int nivel;

	public bool pause = false;

	public bool mundos;

	public bool unavez;

	public Camera normal;

	public int juego;

	public int respawntipo;

	public bool tutorial;

	public int personaje;

	public int espacio;

	[SerializeField]
	public datos2 datosserial;
	[SerializeField]
	public datosconfig datosconfig;
	[SerializeField]
	public datosconfigslot datosslot;
	[SerializeField]
	public datosextra datostrof;
	public string repath;
	public string repathconfig;
	public string repathtro;
	public string repathslot;

	public datos2[] datosserialallslots = new datos2[6];
	public string[] repathallslots = new string[6];

	public jugador_al2 jugador1;
	public jugador2_al2 jugador2;
	public AudioMixer audiomixer;


		public void GetFilePathallslots(int slot)
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        repathallslots[slot] = Path.Combine(result, $"alien2data"+(slot-1).ToString()+".data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
       	repathallslots[slot] = Path.Combine(result, $"alien2data"+(slot-1).ToString()+".data");
		#endif
 
        if(File.Exists(repathallslots[slot]))
        {
            string datosall = File.ReadAllText(repathallslots[slot]);
            datosserialallslots[slot] = JsonUtility.FromJson<datos2>(datosall);
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
		moveson.Play();
	}
		public void GetFilePathslot()
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"datosslot2.data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"datosslot2.data");
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
        result = Path.Combine(result, $"alien2data"+datosslot.datos2slot+".data");
		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alien2data"+datosslot.datos2slot+".data");
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

	public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = File.ReadAllText(path);
            datosserial = JsonUtility.FromJson<datos2>(datosinventario);
            Debug.Log(datosinventario);
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

		cargar();
		cargarconfig();
		cargartro();

		LocalizationManager.Instance.selectedLang = datosconfig.sysidi;

		audiomixer.SetFloat ("MusicVolume",datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",datosconfig.ui);

		jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		jugador2 = (jugador2_al2)FindFirstObjectByType(typeof(jugador2_al2));

		if(datosserial.mejora1c == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 0)
		{
			datosserial.mejora1c = 1;
			guardar();
			SceneManager.LoadScene("mejora1c_al2");
		}
		if(datosserial.mejora2c == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1)
		{
			datosserial.mejora2c = 1;
			guardar();
			SceneManager.LoadScene("mejora2c_al2");
		}
		if(datosserial.mejora3c == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1)
		{
			datosserial.mejora3c = 1;
			guardar();
			SceneManager.LoadScene("mejora3c_al2");
		}
		if(datosserial.mejora4c == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1)
		{
			datosserial.mejora4c = 1;
			guardar();
			SceneManager.LoadScene("mejora4c_al2");
		}
		if(datosserial.mejora5c == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1)
		{
			datosserial.mejora5c = 1;
			guardar();
			SceneManager.LoadScene("mejora5c_al2");
		}
		if(datosserial.tiendasc == 0 && datosserial.tengosaltod == 1 && datosserial.block1 == 1)
		{
			datosserial.tiendasc = 1;
			guardar();
			SceneManager.LoadScene("tiendasc_al2");


		



		//fase 1
		/*if(nivel  == 1 && datosserial.nivel1c == 1)
		{
			jugadorpos.transform.position = new Vector3(-0.449999988f,501.609985f,450.049988f);
			boxcampos.transform.position = new Vector3(-0.449999988f,501.609985f,450.049988f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,180,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,180,0);
		}
		if(nivel == 1 && datosserial.nivel1c == 2)
		{
			jugadorpos.transform.position = new Vector3(0.289999992f,500.970001f,324.980011f);
			boxcampos.transform.position = new Vector3(0.289999992f,500.970001f,324.980011f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,180,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,180,0);
		}
		if(nivel == 1 && datosserial.nivel1c == 3)
		{
			jugadorpos.transform.position = new Vector3(-88.4899979f,474.390015f,106.269997f);
			boxcampos.transform.position = new Vector3(-88.4899979f,474.390015f,106.269997f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,270,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,270,0);
		}



		if(nivel == 2 && datosserial.nivel2c == 1)
		{
			jugadorpos.transform.position = new Vector3(0f,501.609985f,458.5f);
		}
		if(nivel == 2 && datosserial.nivel2c == 2)
		{
			jugadorpos.transform.position = new Vector3(44.6149979f,456.575012f,331.830017f);
		}
		if(nivel == 2 && datosserial.nivel2c == 3)
		{
			jugadorpos.transform.position = new Vector3(129.925003f,455.899994f,543.210022f);
		}


		if(nivel == 3 && datosserial.nivel3c == 1)
		{
			jugadorpos.transform.position = new Vector3(-0.449999988f,502.899994f,450.049988f);
			boxcampos.transform.position = new Vector3(-0.449999988f,502.899994f,450.049988f);
		}
		if(nivel == 3 && datosserial.nivel3c == 2)
		{
			jugadorpos.transform.position = new Vector3(0.289999992f,633.650024f,448.929993f);
			boxcampos.transform.position = new Vector3(0.289999992f,633.650024f,448.929993f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,0,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,0,0);
		}
		if(nivel == 3 && datosserial.nivel3c == 3)
		{
			jugadorpos.transform.position = new Vector3(-38.8300018f,496.619995f,580.890015f);
			boxcampos.transform.position = new Vector3(-38.8300018f,496.619995f,580.890015f);
		}

		if(nivel == 4 && datosserial.nivel4c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1194.34998f,90.9300003f,-142.029999f);
		}
		if(nivel == 4 && datosserial.nivel4c == 2)
		{
			jugadorpos.transform.position = new Vector3(-1172.75f,90.1399994f,-354.519012f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
		}
		if(nivel == 4 && datosserial.nivel4c == 3)
		{
			jugadorpos.transform.position = new Vector3(-1206.95996f,93.7699966f,-160.380005f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
		}



		//fase2
		if(nivel == 5 && datosserial.nivel5c == 1)
		{
			jugadorpos.transform.position = new Vector3(0.300000012f,502.299988f,462.299988f);
		}
		if(nivel == 5 && datosserial.nivel5c == 2)
		{
			jugadorpos.transform.position = new Vector3(-71.8600006f,508.279999f,336.369995f);
		}
		if(nivel == 5 && datosserial.nivel5c == 3)
		{
			jugadorpos.transform.position = new Vector3(-83.2599945f,532.919983f,128.600006f);
		}

		if(nivel == 6 && datosserial.nivel6c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1177.81006f,91.1999969f,-140.550003f);
		}
		if(nivel == 6 && datosserial.nivel6c == 2)
		{
			jugadorpos.transform.position = new Vector3(-1177.76001f,157.389999f,-338.309998f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
		}
		if(nivel == 6 && datosserial.nivel6c == 3)
		{
			jugadorpos.transform.position = new Vector3(-1178.18005f,175.740005f,-337f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
		}


		if(nivel == 7 && datosserial.nivel7c == 1)
		{
			jugadorpos.transform.position = new Vector3(0.200000003f,510.399994f,561f);
		}
		if(nivel == 7 && datosserial.nivel7c == 2)
		{
			jugadorpos.transform.position = new Vector3(1.17000198f,502.190002f,353.980011f);
		}
		if(nivel == 7 && datosserial.nivel7c == 3)
		{
			jugadorpos.transform.position = new Vector3(0.48500061f,502.089996f,166.5f);
		}
		if(nivel == 8 && datosserial.nivel8c == 1)
		{
			jugadorpos.transform.position = new Vector3(1.29999995f,504.100006f,455.399994f);
			boxcampos.transform.position = new Vector3(1.29999995f,504.100006f,455.399994f);
		}
		if(nivel == 8 && datosserial.nivel8c == 2)
		{
			jugadorpos.transform.position = new Vector3(-71.1999969f,601.789978f,262.5f);
			boxcampos.transform.position = new Vector3(-71.1999969f,601.789978f,262.5f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,0,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,0,0);
		}
		if(nivel == 8 && datosserial.nivel8c == 3)
		{
			jugadorpos.transform.position = new Vector3(-69.8339996f,685.469971f,357.811981f);
			boxcampos.transform.position = new Vector3(-69.8339996f,685.469971f,357.811981f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,90,0);
		}





		//FASE3
		if(nivel == 9 && datosserial.nivel9c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1172.09998f,92.8000031f,-140.100006f);
		
		}
		if(nivel == 9 && datosserial.nivel9c == 2)
		{
			jugadorpos.transform.position = new Vector3(-1426.76001f,108.849998f,-140.350006f);
			
		}
		if(nivel == 9 && datosserial.nivel9c == 3)
		{
			jugadorpos.transform.position = new Vector3(-1704.96045f,49.7099991f,-229.839996f);
			
		}
		if(nivel == 10 && datosserial.nivel10c == 1)
		{
			jugadorpos.transform.position = new Vector3(2.79999995f,503f,457.899994f);
			boxcampos.transform.position = new Vector3(2.79999995f,503f,457.899994f);
		}
		if(nivel == 10 && datosserial.nivel10c == 2)
		{
			jugadorpos.transform.position = new Vector3(52.5499992f,461.910004f,557.049988f);
			boxcampos.transform.position = new Vector3(52.5499992f,461.910004f,557.049988f);
		}
		if(nivel == 10 && datosserial.nivel10c == 3)
		{
			jugadorpos.transform.position = new Vector3(-62.6356392f,461.399994f,577.400024f);
			boxcampos.transform.position = new Vector3(-62.6356392f,461.399994f,577.400024f);
		}
		if(nivel == 11 && datosserial.nivel11c == 1)
		{
			jugadorpos.transform.position = new Vector3(65.5999985f,412.5f,878.799988f);
		
		}
		if(nivel == 11 && datosserial.nivel11c == 2)
		{
			jugadorpos.transform.position = new Vector3(30.6500168f,466.200012f,415.938721f);
			
		}
		if(nivel == 11 && datosserial.nivel11c == 3)
		{
			jugadorpos.transform.position = new Vector3(-32.9499931f,520.22998f,-36.1533813f);
			
		}
		if(nivel == 12 && datosserial.nivel12c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1174.40002f,93.6999969f,-140.009995f);
		
		}
		if(nivel == 12 && datosserial.nivel12c == 2)
		{
			jugadorpos.transform.position = new Vector3(-1201.526f,51.4500008f,-227.786591f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
			
		}
		if(nivel == 12 && datosserial.nivel12c == 3)
		{
			jugadorpos.transform.position = new Vector3(-1252.30225f,128.5f,-223.247009f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
			
		}





		//fase4
		if(nivel == 13 && datosserial.nivel13c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1160.88f,91.25f,-139.820007f);
		}
		if(nivel == 13 && datosserial.nivel13c == 2)
		{
			jugadorpos.transform.position = new Vector3(-1149.53003f,187.130005f,-159.009995f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
		}
		if(nivel == 13 && datosserial.nivel13c == 3)
		{
			jugadorpos.transform.position = new Vector3(-1152.73999f,238.869995f,-139.820007f);
		}




		if(nivel == 14 && datosserial.nivel14c == 1)
		{
			jugadorpos.transform.position = new Vector3(0.400000006f,514f,438f);
		}
		if(nivel == 14 && datosserial.nivel14c == 2)
		{
			jugadorpos.transform.position = new Vector3(-0.274999619f,226.740005f,362.600006f);
		}
		if(nivel == 14 && datosserial.nivel14c == 3)
		{
			jugadorpos.transform.position = new Vector3(-111.474998f,19.9300003f,164.600006f);
		}


		
		if(nivel == 15 && datosserial.nivel15c == 1)
		{
			jugadorpos.transform.position = new Vector3(81.0999985f,480.299988f,520.700012f);
			boxcampos.transform.position = new Vector3(81.0999985f,480.299988f,520.700012f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,-90,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,-90,0);
		}
		if(nivel == 15 && datosserial.nivel15c == 2)
		{
			jugadorpos.transform.position = new Vector3(-13.7335539f,510.399994f,370.753601f);
			boxcampos.transform.position = new Vector3(-13.7335539f,510.399994f,370.753601f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,-270,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,-270,0);
		}
		if(nivel == 15 && datosserial.nivel15c == 3)
		{
			jugadorpos.transform.position = new Vector3(-69.8339996f,578.969971f,501.839996f);
			boxcampos.transform.position = new Vector3(-69.8339996f,578.969971f,501.839996f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,-180,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,-180,0);
		}
		if(nivel == 16 && datosserial.nivel16c == 1)
		{
			jugadorpos.transform.position = new Vector3(0.400000006f,507.899994f,-27.5f);
			boxcampos.transform.position = new Vector3(0.400000006f,507.899994f,-27.5f);
			
		}
		if(nivel == 16 && datosserial.nivel16c == 2)
		{
			jugadorpos.transform.position = new Vector3(-345.299988f,548.400024f,687.799988f);
			boxcampos.transform.position = new  Vector3(-345.299988f,548.400024f,687.799988f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,-180,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,-180,0);
		}
		if(nivel == 16 && datosserial.nivel16c == 3)
		{
			jugadorpos.transform.position = new Vector3(-344.600006f,196.300003f,-210.699997f);
			boxcampos.transform.position = new Vector3(-344.600006f,196.300003f,-210.699997f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,90,0);
		}


		//fase5
		if(nivel == 17 && datosserial.nivel17c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1175f,91.9000015f,-140.5f);
		}
		if(nivel == 17 && datosserial.nivel17c == 2)
		{
			jugadorpos.transform.position = new Vector3(-1121.19995f,91.7600021f,-187.119995f);
		}
		if(nivel == 17 && datosserial.nivel17c == 3)
		{
			jugadorpos.transform.position = new Vector3(-1104.29993f,91.6500015f,-354.160004f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			jugador1.dimensiion = true;
		}



		if(nivel == 18 && datosserial.nivel18c == 1)
		{
			jugadorpos.transform.position = new Vector3(1f,504.399994f,554.799988f);
		}
		if(nivel == 18 && datosserial.nivel18c == 2)
		{
			jugadorpos.transform.position = new Vector3(36.9000015f,514.280029f,855.300049f);
		}
		if(nivel == 18 && datosserial.nivel18c == 3)
		{
			jugadorpos.transform.position = new Vector3(295.930023f,514.059998f,620.299988f);
		}


		if(nivel == 19 && datosserial.nivel19c == 1)
		{
			jugadorpos.transform.position = new Vector3(-1.10000002f,501.899994f,455.799988f);
			boxcampos.transform.position = new Vector3(-1.10000002f,501.899994f,455.799988f);
		}
		if(nivel == 19 && datosserial.nivel19c == 2)
		{
			jugadorpos.transform.position = new Vector3(98.8950043f,530.580017f,295.950012f);
			boxcampos.transform.position = new Vector3(98.8950043f,530.580017f,295.950012f);
		}
		if(nivel == 19 && datosserial.nivel19c == 3)
		{
			jugadorpos.transform.position = new Vector3(-66.9499969f,539.27002f,249.190002f);
			boxcampos.transform.position = new Vector3(-66.9499969f,539.27002f,249.190002f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,0,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,0,0);
		}


		if(nivel == 20 && datosserial.nivel20c == 1)
		{
			jugadorpos.transform.position = new Vector3(0.300000012f,503.200012f,-24.6000004f);
			boxcampos.transform.position = new Vector3(0.300000012f,503.200012f,-24.6000004f);

		}
		if(nivel == 20 && datosserial.nivel20c == 2)
		{
			jugadorpos.transform.position = new Vector3(-345.299988f,548.099976f,687.799988f);
			boxcampos.transform.position = new Vector3(-345.299988f,548.099976f,687.799988f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,-180,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,-180,0);

		}
		if(nivel == 20 && datosserial.nivel20c == 3)
		{
			jugadorpos.transform.position = new Vector3(-344.600006f,194.699997f,-210.699997f);
			boxcampos.transform.position = new Vector3(-344.600006f,194.699997f,-210.699997f);
			jugadorpos.transform.eulerAngles = new Vector3 (0,90,0);
			boxcampos.transform.eulerAngles = new Vector3 (0,90,0);

		}*/
	


		}
		
	}

	private void Update()
	{

		if(actG)
		{
            datosserial.armasjug[0] = true;
            datosserial.armasjug[1] = true;
            datosserial.armasjug[2] = true;
            datosserial.armasjug[3] = true;

			datosserial.armasjug[4] = true;
            datosserial.armasjug[5] = true;
            datosserial.armasjug[6] = true;
            datosserial.armasjug[7] = true;

			datosserial.armasjug[8] = true;
            datosserial.armasjug[9] = true;
            datosserial.armasjug[10] = true;
            datosserial.armasjug[11] = true;
			

			datosserial.artilugiosjug[0] = true;
			datosserial.artilugiosjug[1] = true;
			datosserial.artilugiosjug[2] = true;
			datosserial.artilugiosjug[3] = true;

			datosserial.artilugiosjug[4] = true;
			datosserial.artilugiosjug[5] = true;
			datosserial.artilugiosjug[6] = true;
			datosserial.artilugiosjug[7] = true;

			datosserial.pocionesmax = 9;
			guardar();
			actG = false;
		}
		
	}
	public bool actG;
		
		


	
}
