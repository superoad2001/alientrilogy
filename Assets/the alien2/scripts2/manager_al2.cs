using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class manager_al2 : MonoBehaviour
{

	public bool torretiempo;
	public bool torretiemponivel;
	public int inicio;
	public int trofeoact;
	public int tuto = 0;
	public int estado = 0;
	public int menu = 0;
	public int paginas;
	public Text boton1;
	public Text boton2;
	public Text boton3;
	public Text boton4;
	public Text boton5;
	public Text boton6;
	public Text boton7;
	public Text boton8;
	public Image vidaui;
	public AudioSource audio0;

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

	public GameObject llaveo1;
	public GameObject llaveo2;
	public GameObject llaveo3;
	public GameObject llaveo4;
	public GameObject llaveo5;
	public GameObject llaveo6;
	public GameObject llaveo7;
	public GameObject llaveo8;
	public GameObject llaveo9;
	public GameObject llaveo10;
	public GameObject llaveo11;
	public GameObject llaveo12;
	public GameObject llaveo13;
	public GameObject llaveo14;
	public GameObject llaveo15;
	public GameObject llaveo16;
	public GameObject llaveo17;
	public GameObject llaveo18;
	public GameObject llaveo19;
	public GameObject llaveo20;

	public int nivel;

	public GameObject paginac1;
	public GameObject paginac2;
	public GameObject paginac3;
	public GameObject paginac4;
	public GameObject paginac5;
	public GameObject paginac6;
	public GameObject paginac7;
	public GameObject paginac8;
	public GameObject paginac9;
	public GameObject paginac10;
	public GameObject paginac11;
	public GameObject paginac12;
	public GameObject paginac13;
	public GameObject paginac14;
	public GameObject paginac15;
	public GameObject paginac16;
	public GameObject paginac17;
	public GameObject paginac18;
	public GameObject paginac19;
	public GameObject paginac20;
	public bool pause = false;
	public bool mundos;

	public bool unavez;

	public GameObject jefe1;

	public Camera normal;

	public float tiement;

	public int juego;

	public int respawntipo;

	public bool tutorial;

	public int personaje;

	public int espacio;

	public Text mision;

	public Text mision2;

	public Text cuentavidas;

	public Text cuentallaves;

	public Text cuentamonedas;

	public Text cuentafrag;

	[SerializeField]
	public datos2 datosserial;
	[SerializeField]
	public datosconfig datosconfig;
	[SerializeField]
	public datosextra datostrof;
	public string repath;
	public string repathconfig;
	public string repathtro;


	public void GetFilePath()
    {
        string result;
 
		result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alien2data.data");
		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alien2data.data");
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
		}


		jugador1_al2 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al2>();
		







		if(trofeoact == 5)
		{datosserial.tienda1c = 1;}
		if(trofeoact == 6)
		{datosserial.tienda2c = 1;}
		if(trofeoact == 7)
		{datosserial.tienda3c = 1;}
		if(trofeoact == 8)
		{datosserial.tienda4c = 1;}
		if(trofeoact == 9)
		{datosserial.tienda5c = 1;}
		if(trofeoact == 10)
		{datosserial.tienda6c = 1;}
		if(trofeoact == 11)
		{datosserial.tienda7c = 1;}
		guardar();
		

		if(datosserial.trozosnv1 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv2 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv3 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv4 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv5 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv6 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv7 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv8 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv9 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv10 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv11 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv12 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv13 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv14 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv15 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv16 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv17 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv18 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv19 == 3)
		{
			paginas++;
		}
		if(datosserial.trozosnv20 == 3)
		{
			paginas++;
		}
		


		jugador1_al2 jugador1 = UnityEngine.Object.FindObjectOfType<jugador1_al2>();

		if(torretiempo == true)
		{
			if(datosserial.niveltc == 1)
			{
				jugadorpos.transform.localPosition = new Vector3(34.5299988f,28.0733643f,-120f);
				boxcampos.transform.localPosition = new Vector3(34.5299988f,28.0733643f,-120f);
			}
			if(datosserial.niveltc == 2)
			{
				jugadorpos.transform.localPosition = new Vector3(77.1399994f,28.0733643f,-120f);
				boxcampos.transform.localPosition = new Vector3(77.1399994f,28.0733643f,-120f);
			}
			if(datosserial.niveltc == 3)
			{
				jugadorpos.transform.localPosition = new Vector3(121.230003f,28.0733643f,-120f);
				boxcampos.transform.localPosition = new Vector3(121.230003f,28.0733643f,-120f);
			}
			if(datosserial.niveltc == 4)
			{
				jugadorpos.transform.localPosition = new Vector3(160.860001f,28.0733643f,-120f);
				boxcampos.transform.localPosition = new Vector3(160.860001f,28.0733643f,-120f);
			}
			if(datosserial.niveltc == 5)
			{
				jugadorpos.transform.localPosition = new Vector3(33f,52.2000008f,-64.0699997f);
				boxcampos.transform.localPosition = new Vector3(33f,52.2000008f,-64.0699997f);
			}
			if(datosserial.niveltc == 6)
			{
				jugadorpos.transform.localPosition = new Vector3(73.5999985f,52.2000008f,-64.0699997f);
				boxcampos.transform.localPosition = new Vector3(73.5999985f,52.2000008f,-64.0699997f);
			}
			if(datosserial.niveltc == 7)
			{
				jugadorpos.transform.localPosition = new Vector3(119.5f,52.2000008f,-64.0699997f);
				boxcampos.transform.localPosition = new Vector3(119.5f,52.2000008f,-64.0699997f);
			}
			if(datosserial.niveltc == 8)
			{
				jugadorpos.transform.localPosition = new Vector3(158.360001f,52.2000008f,-64.0699997f);
				boxcampos.transform.localPosition = new Vector3(158.360001f,52.2000008f,-64.0699997f);
			}
			if(datosserial.niveltc == 9)
			{
				jugadorpos.transform.localPosition = new Vector3(33f,79.4700012f,-13f);
				boxcampos.transform.localPosition = new Vector3(33f,79.4700012f,-13f);
			}
			if(datosserial.niveltc == 10)
			{
				jugadorpos.transform.localPosition = new Vector3(72.6999969f,79.4700012f,-13f);
				boxcampos.transform.localPosition = new Vector3(72.6999969f,79.4700012f,-13f);
			}
			if(datosserial.niveltc == 11)
			{
				jugadorpos.transform.localPosition = new Vector3(119.300003f,79.4700012f,-13f);
				boxcampos.transform.localPosition = new Vector3(119.300003f,79.4700012f,-13f);
			}
			if(datosserial.niveltc == 12)
			{
				jugadorpos.transform.localPosition = new Vector3(159.100006f,79.4700012f,-13f);
				boxcampos.transform.localPosition = new Vector3(159.100006f,79.4700012f,-13f);
			}
			if(datosserial.niveltc == 13)
			{
				jugadorpos.transform.localPosition = new Vector3(31.3999996f,110.800003f,48.7000008f);
				boxcampos.transform.localPosition = new Vector3(31.3999996f,110.800003f,48.7000008f);
			}
			if(datosserial.niveltc == 14)
			{
				jugadorpos.transform.localPosition = new Vector3(73.6999969f,110.800003f,48.7000008f);
				boxcampos.transform.localPosition = new Vector3(73.6999969f,110.800003f,48.7000008f);
			}
			if(datosserial.niveltc == 15)
			{
				jugadorpos.transform.localPosition = new Vector3(118.699997f,110.800003f,48.7000008f);
				boxcampos.transform.localPosition = new Vector3(118.699997f,110.800003f,48.7000008f);
			}
			if(datosserial.niveltc == 16)
			{
				jugadorpos.transform.localPosition = new Vector3(157.800003f,110.800003f,48.7000008f);
				boxcampos.transform.localPosition = new Vector3(157.800003f,110.800003f,48.7000008f);
			}
			if(datosserial.niveltc == 17)
			{
				jugadorpos.transform.localPosition = new Vector3(31.3999996f,136.5f,106.800003f);
				boxcampos.transform.localPosition = new Vector3(31.3999996f,136.5f,106.800003f);
			}
			if(datosserial.niveltc == 18)
			{
				jugadorpos.transform.localPosition = new Vector3(73.4000015f,136.5f,106.800003f);
				boxcampos.transform.localPosition = new Vector3(73.4000015f,136.5f,106.800003f);
			}
			if(datosserial.niveltc == 19)
			{
				jugadorpos.transform.localPosition = new Vector3(119.599998f,136.5f,106.800003f);
				boxcampos.transform.localPosition = new Vector3(119.599998f,136.5f,106.800003f);
			}
			if(datosserial.niveltc == 20)
			{
				jugadorpos.transform.localPosition = new Vector3(156.199997f,136.5f,106.800003f);
				boxcampos.transform.localPosition = new Vector3(156.199997f,136.5f,106.800003f);
			}
		}

		//fase 1
		if(nivel  == 1 && datosserial.nivel1c == 1)
		{
			jugadorpos.transform.position = new Vector3(-0.449999988f,501.609985f,450.049988f);
			boxcampos.transform.position = new Vector3(-0.449999988f,501.609985f,450.049988f);
		}
		if(nivel == 1 && datosserial.nivel1c == 2)
		{
			jugadorpos.transform.position = new Vector3(0.289999992f,500.970001f,324.980011f);
			boxcampos.transform.position = new Vector3(0.289999992f,500.970001f,324.980011f);
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

		}
		if (nivel == 0)
		{
			if(datosserial.llaveN1 == 1)
			{
				llaveo1.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN2 == 1)
			{
				llaveo2.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN3 == 1)
			{
				llaveo3.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN4 == 1)
			{
				llaveo4.transform.position = new Vector3(-355.899994f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN5 == 1)
			{
				llaveo5.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN6 == 1)
			{
				llaveo6.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN7 == 1)
			{
				llaveo7.transform.position = new Vector3(-355.929993f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN8 == 1)
			{
				llaveo8.transform.position = new Vector3(-353.640015f,500.700012f,457.48999f);
			}
			if(datosserial.llaveN9 == 1)
			{
				llaveo9.transform.position = new Vector3(-355.869995f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN10 == 1)
			{
				llaveo10.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN11 == 1)
			{
				llaveo11.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN12 == 1)
			{
				llaveo12.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN13 == 1)
			{
				llaveo13.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN14 == 1)
			{
				llaveo14.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN15 == 1)
			{
				llaveo15.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN16 == 1)
			{
				llaveo16.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN17 == 1)
			{
				llaveo17.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN18 == 1)
			{
				llaveo18.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN19 == 1)
			{
				llaveo19.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}
			if(datosserial.llaveN20 == 1)
			{
				llaveo20.transform.position = new Vector3(-356.200012f,500.700012f,459.399994f);
			}



			if(datosserial.llaveN1 == 0)
			{
				llaveo1.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN2 == 0)
			{
				llaveo2.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN3 == 0)
			{
				llaveo3.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN4 == 0)
			{
				llaveo4.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN5 == 0)
			{
				llaveo5.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN6 == 0)
			{
				llaveo6.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN7 == 0)
			{
				llaveo7.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN8 == 0)
			{
				llaveo8.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN9 == 0)
			{
				llaveo9.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN10 == 0)
			{
				llaveo10.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN11 == 0)
			{
				llaveo11.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN12 == 0)
			{
				llaveo12.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN13 == 0)
			{
				llaveo13.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN14 == 0)
			{
				llaveo14.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN15 == 0)
			{
				llaveo15.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN16 == 0)
			{
				llaveo16.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN17 == 0)
			{
				llaveo17.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN18 == 0)
			{
				llaveo18.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN19 == 0)
			{
				llaveo19.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.llaveN20 == 0)
			{
				llaveo20.transform.position = new Vector3(0,0,0);
			}





			if(datosserial.trozosnv1 == 3)
			{
				paginac1.transform.position = new Vector3(-357.630005f,506.230011f,457.049988f);
			}
			if(datosserial.trozosnv2 == 3)
			{
				paginac2.transform.position = new Vector3(-354.829987f,515.099976f,311f);
			}
			if(datosserial.trozosnv3 == 3)
			{
				paginac3.transform.position = new Vector3(-480.600006f,515.099976f,367f);
			}
			if(datosserial.trozosnv4 == 3)
			{
				paginac4.transform.position = new Vector3(-635.099976f,512.400024f,489f);
			}
			if(datosserial.trozosnv5 == 3)
			{
				paginac5.transform.position = new Vector3(-829.799988f,515.099976f,490.200012f);
			}

			if(datosserial.trozosnv6 == 3)
			{
				paginac6.transform.position = new Vector3(-954.900024f,515.099976f,577f);
			}
			if(datosserial.trozosnv7 == 3)
			{
				paginac7.transform.position = new Vector3(-996.200012f,515.099976f,689f);
			}
			if(datosserial.trozosnv8 == 3)
			{
				paginac8.transform.position = new Vector3(-738.099976f,515.099976f,553.719971f);
			}
			if(datosserial.trozosnv9 == 3)
			{
				paginac9.transform.position = new Vector3(-732.700012f,529.669983f,285.890015f);
			}
			if(datosserial.trozosnv10 == 3)
			{
				paginac10.transform.position = new Vector3(-635.710022f,530.460022f,303.75f);
			}
			if(datosserial.trozosnv11 == 3)
			{
				paginac11.transform.position = new Vector3(-599.140015f,591.099976f,431.5f);
			}
			if(datosserial.trozosnv12 == 3)
			{
				paginac12.transform.position = new Vector3(-296.829987f,586.359985f,591.369995f);
			}
			if(datosserial.trozosnv13 == 3)
			{
				paginac13.transform.position = new Vector3(87.9000015f,563.900024f,525.700012f);
			}
			if(datosserial.trozosnv14 == 3)
			{
				paginac14.transform.position = new Vector3(106.099998f,562.150024f,715.700012f);
			}
			if(datosserial.trozosnv15 == 3)
			{
				paginac15.transform.position = new Vector3(-128.190002f,565.190002f,700.409973f);
			}

			if(datosserial.trozosnv16 == 3)
			{
				paginac16.transform.position = new Vector3(-45.5600014f,527.849976f,813.320007f);
			}
			if(datosserial.trozosnv17 == 3)
			{
				paginac17.transform.position = new Vector3(-666.52002f,515.099976f,964.830017f);
			}
			if(datosserial.trozosnv18 == 3)
			{
				paginac18.transform.position = new Vector3(-478.899994f,515.099976f,964.859985f);
			}
			if(datosserial.trozosnv19 == 3)
			{
				paginac19.transform.position = new Vector3(-494.399994f,515.099976f,861.940002f);
			}
			if(datosserial.trozosnv20 == 3)
			{
				paginac20.transform.position = new Vector3(-666.780029f,515.099976f,861.390015f);
			}


			if(datosserial.trozosnv1 != 3)
			{
				paginac1.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv2 != 3)
			{
				paginac2.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv3 != 3)
			{
				paginac3.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv4 != 3)
			{
				paginac4.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv5 != 3)
			{
				paginac5.transform.position = new Vector3(0,0,0);
			}

			if(datosserial.trozosnv6 != 3)
			{
				paginac6.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv7 != 3)
			{
				paginac7.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv8 != 3)
			{
				paginac8.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv9 != 3)
			{
				paginac9.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv10 != 3)
			{
				paginac10.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv11 != 3)
			{
				paginac11.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv12 != 3)
			{
				paginac12.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv13 != 3)
			{
				paginac13.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv14 != 3)
			{
				paginac14.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv15 != 3)
			{
				paginac15.transform.position = new Vector3(0,0,0);
			}

			if(datosserial.trozosnv16 != 3)
			{
				paginac16.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv17 != 3)
			{
				paginac17.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv18 != 3)
			{
				paginac18.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv19 != 3)
			{
				paginac19.transform.position = new Vector3(0,0,0);
			}
			if(datosserial.trozosnv20 != 3)
			{
				paginac20.transform.position = new Vector3(0,0,0);
			}


		}
		
	}

	private void Update()
	{
		jugador1_al2 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al2>();
		jugador2_al2 jugador2 = UnityEngine.Object.FindObjectOfType<jugador2_al2>();
		pushup push = UnityEngine.Object.FindObjectOfType<pushup>();

		if(datostrof.alien2compraentodaslastiendas1vez == 0 && datosserial.tienda1c == 1 && datosserial.tienda2c == 1 && datosserial.tienda3c == 1 && datosserial.tienda4c == 1 && datosserial.tienda5c == 1 && datosserial.tienda6c == 1 && datosserial.tienda7c == 1)
		{
			datostrof.alien2compraentodaslastiendas1vez = 1;
			guardartro();
			push.push(46);
		}
		guardartro();
		if(datosserial.monedas >= 1000 && datostrof.alien2ahorra1000monedas == 0)
		{
			datostrof.alien2ahorra1000monedas = 1;
			guardartro();
			push.push(45);
		}
		if(datosserial.vidamaxima ==  6 && datostrof.alien2obtentodaslasmejorasvida == 0)
		{
			datostrof.alien2obtentodaslasmejorasvida = 1;
			guardartro();
			push.push(49);
		}

		if(trofeoact == 1 && datostrof.completaalien2m == 0)
		{
			datostrof.completaalien2m = 1;
			push.push(43);
		}
		if(trofeoact == 2 && datostrof.completaalien2v == 0)
		{
			datostrof.completaalien2v = 1;
			push.push(44);
		}
		if(trofeoact == 3 && datostrof.alien2sacaelfinalalternativo == 0)
		{
			datostrof.alien2sacaelfinalalternativo = 1;
			push.push(50);
		}
		if(trofeoact == 4 && datostrof.alien2saladelrey == 0)
		{
			datostrof.alien2saladelrey = 1;
			push.push(51);
		}

		if(trofeoact == 12 && datostrof.alien2primeracinematica == 0)
		{
			datostrof.alien2primeracinematica = 1;
			push.push(22);
		}
		if(datosserial.checkpoints >= 1 && datostrof.alien2desbloqueaelcheckpoint1delnivel1 == 0)
		{
			datostrof.alien2desbloqueaelcheckpoint1delnivel1 = 1;
			push.push(23);
		}
		if(trofeoact == 12 && datosserial.llaves >= 4 && datostrof.alien2consigue4llaves == 0)
		{
			datostrof.alien2consigue4llaves = 1;
			push.push(24);
		}
		if(paginas >= 1  && datostrof.alien2unapaginadeldiario == 0)
		{
			datostrof.alien2unapaginadeldiario = 1;
			push.push(25);
		}
		if(paginas >= 20  && datostrof.alien2consiguetodaslaspaginas == 0)
		{
			datostrof.alien2consiguetodaslaspaginas = 1;
			push.push(27);
		}
		if(datosserial.checkpoints >= 40 && datostrof.alien2desbloqueatodosloscheckpoits == 0)
		{
			datostrof.alien2desbloqueatodosloscheckpoits = 1;
			push.push(29);
		}
		if(trofeoact == 12 && datosserial.mejora1c == 1 && datostrof.alien2mejora1 == 0)
		{
			datostrof.alien2mejora1 = 1;
			push.push(32);
		}
		if(trofeoact == 12 && datosserial.mejora2c == 1 && datostrof.alien2mejora2 == 0)
		{
			datostrof.alien2mejora2 = 1;
			push.push(33);
		}
		if(trofeoact == 12 && datosserial.mejora3c == 1 && datostrof.alien2mejora3 == 0)
		{
			datostrof.alien2mejora3 = 1;
			push.push(34);
		}
		if(trofeoact == 12 && datosserial.mejora4c == 1 && datostrof.alien2mejora4 == 0)
		{
			datostrof.alien2mejora4 = 1;
			push.push(35);
		}
		if( trofeoact == 12 && datosserial.mejora5c == 1 && datostrof.alien2mejora5 == 0)
		{
			datostrof.alien2mejora5 = 1;
			push.push(36);
		}
		if( trofeoact == 13 && datostrof.alien2usaelcochedelmundo == 0)
		{
			datostrof.alien2usaelcochedelmundo = 1;
			push.push(39);
		}
		if( trofeoact == 14 && datostrof.alien2usalanaveenelespacio == 0)
		{
			datostrof.alien2usalanaveenelespacio = 1;
			push.push(41);
		}
		if( trofeoact == 15 && datostrof.alien2usalanavegumi == 0)
		{
			datostrof.alien2usalanavegumi = 1;
			push.push(42);
		}
		if( trofeoact == 12 && datostrof.alien2muere == 0  && datosserial.alien2muere == 1)
		{
			datostrof.alien2muere = 1;
			push.push(48);
		}
		guardartro();

		if(datosconfig.idioma == "es")
		{
			if(menu == -2)
			{
				boton1.text = "en que dispositivo estas jugando?";
				boton2.text = "si estas jugando en un pc tableta o android selecciona dispositivo tactil si estas en los anteriores dispositivos con un mando o en pc o consola selecciona pc o consola";
				boton3.text = "una vez slecionado para cambiarlo entra a opciones";
				boton4.text = "controles";
				boton5.text = "pc o consola";
				boton6.text = "dispositivo tactil";
			}
			if(menu == -1)
			{
				boton1.text = "controles";
				boton2.text = "teclado y raton o mando";
				boton3.text = "controles tactiles";
				boton4.text = "idioma";
				boton5.text = "espanol";
				boton6.text = "catala";
				boton7.text = "english";
			}
			if(menu == 1)
			{
				boton1.text = "presenta";
			}
			if(menu == 2)
			{
				boton1.text = "borrar partida";
				boton2.text = "opciones";
				boton3.text = "comenzar";
			}
			if(menu == 3)
			{
				boton1.text = "saltar";
			}
			if(menu == 4)
			{
				boton1.text = "estas seguro?";
				boton2.text = "atras";
				boton3.text = "borrar partida";
			}
			if(menu == 5)
			{
				boton1.text = "FIN";
				boton2.text = "para salir al menu principal";
			}
			if(menu == 6)
			{
				boton1.text = "FIN?";
				boton2.text = "para continuar";
			}
			if(menu == 7)
			{
				boton1.text = "FIN?";
				boton2.text = "para salir al menu principal";
			}
			if(estado == 1)
			{
				boton1.text = "TIEMPOS";
				boton2.text = "para salir";
			}
			if(estado == 2)
			{
				boton1.text = "SALA DEL REY";
				boton2.text = "para salir";
			}




			if(tuto == 1)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "para seleccionar nivel cambia con (q) y (e) o (lb) y (rb) y pulsa (click izquierdo) o (x) para comenzar";
				boton3.text = "cuando tengas cuatro llaves usalas con la roca azul para desbloquear la puerta del jefe";
			}
			if(tuto == -1)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "pulsa wasd o joystick para esquivar pulsa (click izquierdo) o (x) para disparar esquiva los disparos del pirata matalo y sobrevive";
			}
			if(tuto == 2)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "acabas de conseguir el salto doble presiona (espacio) o (a )para saltar y manten para saltar mas alto tambien puedes dar un salto soltar y volver a apretar para maximizar su longitud";
				boton3.text = "has desbloqueado la tienda de la caseta morada puedes gastar monedas para comprar objetos";
			}
			if(tuto == 3)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "acabas de conseguir la habilidad disparar ahora puedes recojer balas y usarlas usa (q) y (e) o (lb) y (rb) para seleccionar habilidad presiona (click izquierdo) para usar una habilidad con la pistola puedes romper muros y acceder a nuevas zonas";
			}
			if(tuto == 4)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "ahora tienes acceso al coche encuentralo por el mapa podras usarlo usalo para llegar al otro lado del puente";
			}
			if(tuto == 5)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "ahora tienes acceso al coche encuentralo por el mapa podras usarlo usalo para llegar al otro lado del puente";
			}
			if(tuto == 6)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "has conseguido la habilidad control mental ahora puede controlar a algun pirata desde la plat azul de control mental usando su habilidad en el selector seguro que algun pirata puede abrirte camino a la guarida del comandante";
			}
			if(tuto == 7)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "carrera de coches";
				boton3.text = "al darle al (espacio) o (a) comenzara la carrera pulsa (espacio) o (a) para acelerar (a) y (d) o usa el joystick para girar el coche pulsa (click izquierdo) o (b) para la marcha atras que gane el mejor";
			}
			if(tuto == 8)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "el rey pirata a escapado ve por el usa tu nave esta enfrente de la guarida pero ten en cuenta que es muy poderoso tal vez alguien pueda ayudarte";
				
			}
			if(tuto == 9)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "tu familia a sido secuestrada aqui podras oir sus diarios consiguelos en los niveles si los consigues todos tal vez alguien pueda ayudarte a vencer al rey pirata";
			}
			if(tuto == 10)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "ahora puedes hacer varias cosas puedes ir a enfrentarte al jefe ten cuenta que es muy poderoso puede que necesites ayuda tambien hay una tienda con nuevos objetos  y una isla en la que podras escuchar los diarios que recojas en los niveles que hayas hecho por ultimo esta la gran torre del tiempo donde podras romper tus records pero recuerda no hay checkpoits solo un temporizaDOR PUEDES COMPRAR OBJETOS PARA APURAR EL TIEMPO";
			}
			if(tuto == 11)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "el comandante pirata a huido";
			}
			if(tuto == 12)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "vas a comenzar el combate final este enemigo es muy poderoso necesitaras ayuda al igual no es buena idea enfrentarte a el solo";
			}
			if(tuto == 13)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "aqui puedes comprar objetos especiales necesarios para completar los secretos de los niveles tambien sirven para sacar mejores tiempos en la torre del tiempo objetos: disparo: sirve para romper paredes pocion:  sirve para recuperar vitalidad pocion de salto: sirve para hacer un hypersalto sin su plat pocion de velocidad: sirve para ir rapido sin su plat pocion mortal: te hace invulnerable a la lava durante 15 segundos";
			}
			if(tuto == 14)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "esto es la torre del tiempo aqui podras repetir los niveles en contrareloj puedes usar todas tus habilidades escoje la mejor ruta saca los mejores records que puedas suerte";
			}

			if(tuto == -1)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "muevete con wasd o joystick pulsa (espacio) o (a) para saltar";
				boton3.text = "pulsa (espacio) o (a) en en los saltadores verdes para saltar mas alto cuando toques un acelerador amarillo podras saltar con mas longitud";
			}
			if(tuto == -2)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "pulsa (a) y (d) o joystick para moverte pulsa (espacio) o (a) para saltar pulsa (click derecho) para cambiar la perspectiva";
				boton3.text = "pulsa (espacio) o (a) en en los saltadores verdes para saltar mas alto cuando toques un acelerador amarillo podras saltar con mas longitud";
			}
			if(tuto == -3)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "muevete con wasd o joystick pulsa (espacio) o (a) para saltar usa el salto doble para llegar mas alto y mas lejos";
			}
			if(tuto == -4)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "pulsa (a) y (d) o joystick para moverte pulsa (espacio) o (a) para saltar pulsa (click derecho) para cambiar la perspectiva";
				boton3.text = "usa el salto doble para llegar mas alto y mas lejos";
			}
			if(tuto == -5)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "muevete con wasd o joystick pulsa (espacio) o (a) para saltar usa (q) y (e) o (lb) y (rb) para seleccionar habilidad presiona (click izquierdo) para usar una habilidad";
				boton3.text = "usa la habilidad disparo para romper objetos molestos del entorno algunos son rompibles otros no prueba haber si hay suerte";
			}
			if(tuto == -6)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "pulsa (a) y (d) o joystick para moverte pulsa (espacio) o (a) para saltar pulsa (click derecho) para cambiar la perspectiva";
			}
			if(tuto == -7)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "muevete con wasd o joystick pulsa (espacio) o (a) para saltar";
			}
			if(tuto == -8)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "pulsa (espacio) o (a) para acelerar (a) y (d) o usa el joystick para girar el coche pulsa (click izquierdo) o (b) para la marcha atras";
			}
			if(tuto == -9)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "pulsa (a) y (d) o joystick para moverte pulsa (espacio) o (a) para saltar pulsa (click derecho) para cambiar la perspectiva usa el control mental para abrirte camino";
			}
			if(tuto == -10)
			{
				boton1.text = "Apreta (espacio) o (a) para continuar";
				boton2.text = "muevete con wasd o joystick pulsa (espacio) o (a) para saltar usa el control mental para abrirte camino";
			}





			if(pause == false)
			{
			if(nivel  <= -1 && nivel >= -20)
			{
				cuentavidas.text = ""+jugador.vida;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel >= 1 && nivel <= 20 && personaje == 1 || nivel >= 1 && nivel <= 20 && personaje == 0 )
			{
				cuentavidas.text = ""+jugador.vida;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
			}
			if(nivel == 1 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv1+"/3";
			}
			if(nivel == 2 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv2+"/3";
			}
			if(nivel == 3 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv3+"/3";
			}
			if(nivel == 4 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv4+"/3";
			}

			if(nivel == 5 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv5+"/3";
			}
			if(nivel == 6 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv6+"/3";
			}
			if(nivel == 7 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv7+"/3";
			}
			if(nivel == 8 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv8+"/3";
			}

			if(nivel == 9 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv9+"/3";
			}
			if(nivel == 10 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv10+"/3";
			}
			if(nivel == 11 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv11+"/3";
			}
			if(nivel == 12 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv12+"/3";
			}

			if(nivel == 13 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv13+"/3";
			}
			if(nivel == 14 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv14+"/3";
			}
			if(nivel == 15 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv15+"/3";
			}
			if(nivel == 16 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv16+"/3";
			}

			if(nivel == 17 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv17+"/3";
			}
			if(nivel == 18 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv18+"/3";
			}
			if(nivel == 19 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv19+"/3";
			}
			if(nivel == 20 )
			{
				cuentafrag.text = "TROZOS DE PAGINA: "+datosserial.trozosnv20+"/3";
			}
			if(nivel >= 1 && nivel <= 20 && personaje == 2)
			{
				cuentavidas.text = ""+jugador2.vida;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
			}
			if(nivel == 0 && personaje == 1 && datosserial.tengonave == 0)
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentallaves.text = "LLAVES: "+datosserial.llaves+"/4";
			}
			if(nivel == 0 && personaje == 2 && datosserial.tengonave == 0)
			{
				cuentavidas.text = ""+jugador2.vida;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentallaves.text = "LLAVES: "+datosserial.llaves+"/4";
			}
			if(nivel == 0 && personaje == 1 && datosserial.tengonave == 1)
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentallaves.text = "PAGINAS: "+paginas+"/20";
			}
			if(nivel == 0 && personaje == 2 && datosserial.tengonave == 1)
			{
				cuentavidas.text = ""+jugador2.vida;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentallaves.text = "PAGINAS: "+paginas+"/20";
			}
			if(nivel == 500)
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				cuentallaves.text = "PAGINAS: "+paginas+"/20";
			}
			if(nivel == 21 || nivel == 22 || nivel == 23 || nivel == 25 || nivel == 26 )
			{
				cuentavidas.text = ""+jugador.vida;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(personaje == 1 )
			{
				p1c.SetActive(true);
				p2c.SetActive(false);
			}
			if(personaje == 2)
			{
				p1c.SetActive(false);
				p2c.SetActive(true);
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 0 && datosserial.block1 == 0)
			{
				mision.text = "mision: consigue las llaves de los 4 niveles disponibles";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 0 && datosserial.block1 == 0)
			{
				mision.text = "mision: abre la puerta azul del jefe y enfrentalo";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 0 && datosserial.block1 == 1)
			{
				mision.text = "mision: vence al jefe";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 0)
			{
				mision.text = "mision: consigue las llaves de los 4 niveles disponibles";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 0)
			{
				mision.text = "mision: abre la puerta azul del jefe y enfrentalo";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 1)
			{
				mision.text = "mision: vence al jefe";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 0)
			{
				mision.text = "mision: consigue las llaves de los 4 niveles disponibles";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 0)
			{
				mision.text = "mision: abre la puerta azul del jefe y enfrentalo";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1)
			{
				mision.text = "mision: vence al jefe";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1  && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 0)
			{
				mision.text = "mision: consigue las llaves de los 4 niveles disponibles";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 0)
			{
				mision.text = "mision: abre la puerta azul del jefe y enfrentalo";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1)
			{
				mision.text = "mision: vence al jefe";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1  && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 0)
			{
				mision.text = "mision: consigue las llaves de los 4 niveles disponibles";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 0 )
			{
				mision.text = "mision: abre la puerta azul del jefe y enfrentalo";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 )
			{
				mision.text = "mision: vence al jefe";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 )
			{
				mision.text = "mision: sube a la nave y ve a por el rey pirata";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && datosserial.finalmalo == 1 && paginas < 20)
			{
				mision.text = "mision: busca las 20 paginas en los niveles y ve a la isla familiar";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && paginas == 20 && datosserial.finalbueno == 0)
			{
				mision.text = "mision: ve a la isla familiar hay alguien esperandote";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && datosserial.finalbueno == 1)
			{
				mision.text = "mision: ve a por el rey pirata";
			}
			}
		}
		if(datosconfig.idioma == "en")
		{
			if(menu == -2)
			{
				boton1.text = "what device are you playing on??";
				boton2.text = "if you are playing on a tablet or android pc select touch device if you are on the above devices with a controller or on pc or console select pc or console";
				boton3.text = "once selected to change it, go to settings";
				boton4.text = "controls";
				boton5.text = "pc or console";
				boton6.text = "touch device";
			}
			if(menu == -1)
			{
				boton1.text = "controls";
				boton2.text = "keyboard and mouse or controller";
				boton3.text = "touch controls";
				boton4.text = "language";
				boton5.text = "espanol";
				boton6.text = "catala";
				boton7.text = "english";
			}
			if(menu == 1)
			{
				boton1.text = "presents";
			}
			if(menu == 2)
			{
				boton1.text = "borrar partida";
				boton2.text = "settings";
				boton3.text = "begin adventure";
			}
			if(menu == 3)
			{
				boton1.text = "skip";
			}
			if(menu == 4)
			{
				boton1.text = "you're sure?";
				boton2.text = "back";
				boton3.text = "delete files";
			}
			if(menu == 5)
			{
				boton1.text = "END";
				boton2.text = "to exit to the main menu";
			}
			if(menu == 6)
			{
				boton1.text = "END?";
				boton2.text = "to continue";
			}
			if(menu == 7)
			{
				boton1.text = "END?";
				boton2.text = "to exit to the main menu";
			}
			if(estado == 1)
			{
				boton1.text = "TIME";
				boton2.text = "to exit";
			}
			if(estado == 2)
			{
				boton1.text = "KING'S ROOM";
				boton2.text = "to exit";
			}




			if(tuto == 1)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "to select level change with (q) and (e) or (lb) and (rb) and press (left click) or (x) to start";
				boton3.text = "when you have four keys use them with the blue rock to unlock the boss door";
			}
			if(tuto == -1)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "press wasd or joystick to dodge press (left click) or (x) to shoot dodge the pirate's shots kill him and survive";
			}
			if(tuto == 2)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "you just got the double jump press (space) or (a ) to jump and hold to jump higher you can also jump release and press again to maximize its length";
				boton3.text = "you have unlocked the shop in the purple booth you can spend coins to buy items";
			}
			if(tuto == 3)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "you just got the shoot skill now you can pick up bullets and use them use (q) and (e) or (lb) and (rb) to select skill press (left click) to use a skill with the gun you can break walls and access new ones zones";
			}
			if(tuto == 4)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "now you have access to the car find it on the map you can use it use it to get to the other side of the bridge";
			}
			if(tuto == 5)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "now you have access to the car find it on the map you can use it use it to get to the other side of the bridge";
			}
			if(tuto == 6)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "you got the mind control ability now you can control any pirate from the blue hypnotize platform using your ability on the selector sure some pirate can make your way to the pirate king's lair";
			}
			if(tuto == 7)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "car race";
				boton3.text = "when you hit (space) or (a) the race will start press (space) or (a) to accelerate (a) and (d) or use the joystick to turn the car press (left click) or (b) to go back may the best man win";
			}
			if(tuto == 8)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "the pirate king has escaped go for him use your ship it is in front of the lair but keep in mind that it is very powerful maybe someone can help you";
				
			}
			if(tuto == 9)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "your family has been kidnapped here you can hear their diaries get them in the levels if you get them all maybe someone can help you defeat the pirate king";
			}
			if(tuto == 10)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "now you can do several things you can go to face the boss keep in mind that he is very powerful you may need help there is also a store with new objects and an island where you can listen to the newspapers that you collect in the levels that you have done last is the big tower of time where you can break your records but remember there are no checkpoints just a timer YOU CAN BUY ITEMS TO SPEED UP TIME";
			}
			if(tuto == 11)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "the pirate king has fled";
			}
			if(tuto == 12)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "you are going to start the final fight this enemy is very powerful you will need help as well it is not a good idea to face him alone";
			}
			if(tuto == 13)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "Here you can buy special objects necessary to complete the secrets of the levels, they also serve to get better times in the tower of time Objects: shot: it is used to break walls potion: it is used to recover vitality jumping potion: it is used to hyperjump without its platform speed potion: used to go fast without his platform deadly potion: makes you invulnerable to lava for 15 seconds";
			}
			if(tuto == 14)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "this is the tower of time here you can repeat the levels against the clock you can use all your skills choose the best route get the best records you can luck";
			}

			if(tuto == -1)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "move with wasd or joystick press (space) or (a) to jump";
				boton3.text = "press (space) or (a) on the green jumpers to jump higher when you touch a yellow accelerator you can jump longer";
			}
			if(tuto == -2)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "press (a) and (d) or joystick to move press (space) or (a) to jump press (right click) to change perspective";
				boton3.text = "press (space) or (a) on the green jumpers to jump higher when you touch a yellow accelerator you can jump longer";
			}
			if(tuto == -3)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "move with wasd or joystick press (space) or (a) to jump use the double jump to get higher and further";
			}
			if(tuto == -4)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "press (a) and (d) or joystick to move press (space) or (a) to jump press (right click) to change perspective";
				boton3.text = "use the double jump to get higher and further";
			}
			if(tuto == -5)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "move with wasd or joystick press (space) or (a) to jump use (q) and (e) or (lb) and (rb) to select skill press (left click) to use a skill";
				boton3.text = "use the shot ability to break annoying objects in the environment some are breakable others do not try if you are lucky";
			}
			if(tuto == -6)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "press (a) and (d) or joystick to move press (space) or (a) to jump press (right click) to change perspective";
			}
			if(tuto == -7)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "move with wasd or joystick press (space) or (a) to jump";
			}
			if(tuto == -8)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "press (space) or (a) to accelerate (a) and (d) or use the joystick to turn the car press (left click) or (b) to reverse";
			}
			if(tuto == -9)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "press (a) and (d) or joystick to move press (space) or (a) to jump press (right click) to change perspective use hypnotize to make your way";
			}
			if(tuto == -10)
			{
				boton1.text = "Press (space) or (a) to continue";
				boton2.text = "move with wasd or joystick press (space) or (a) to jump use hypnotize to open your way";
			}





			if(pause == false)
			{
			if(nivel  <= -1 && nivel >= -20)
			{
				cuentavidas.text = ""+jugador.vida;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel >= 1 && nivel <= 20 && personaje == 1 || nivel >= 1 && nivel <= 20 && personaje == 0 )
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 1 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv1+"/3";
			}
			if(nivel == 2 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv2+"/3";
			}
			if(nivel == 3 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv3+"/3";
			}
			if(nivel == 4 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv4+"/3";
			}

			if(nivel == 5 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv5+"/3";
			}
			if(nivel == 6 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv6+"/3";
			}
			if(nivel == 7 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv7+"/3";
			}
			if(nivel == 8 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv8+"/3";
			}

			if(nivel == 9 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv9+"/3";
			}
			if(nivel == 10 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv10+"/3";
			}
			if(nivel == 11 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv11+"/3";
			}
			if(nivel == 12 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv12+"/3";
			}

			if(nivel == 13 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv13+"/3";
			}
			if(nivel == 14 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv14+"/3";
			}
			if(nivel == 15 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv15+"/3";
			}
			if(nivel == 16 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv16+"/3";
			}

			if(nivel == 17 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv17+"/3";
			}
			if(nivel == 18 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv18+"/3";
			}
			if(nivel == 19 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv19+"/3";
			}
			if(nivel == 20 )
			{
				cuentafrag.text = "pieces of pages: "+datosserial.trozosnv20+"/3";
			}
			if(nivel >= 1 && nivel <= 20 && personaje == 2)
			{
				cuentavidas.text = ""+jugador2.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 0 && personaje == 1 && datosserial.tengonave == 0)
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				cuentallaves.text = "keys: "+datosserial.llaves+"/4";
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 0 && personaje == 2 && datosserial.tengonave == 0)
			{
				cuentavidas.text = ""+jugador2.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				cuentallaves.text = "keys: "+datosserial.llaves+"/4";
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 0 && personaje == 1 && datosserial.tengonave == 1)
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				cuentallaves.text = "pages: "+paginas+"/20";
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 0 && personaje == 2 && datosserial.tengonave == 1)
			{
				cuentavidas.text = ""+jugador2.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				cuentallaves.text = "pages: "+paginas+"/20";
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 500)
			{
				cuentavidas.text = ""+jugador.vida;
				cuentamonedas.text = "coins: "+datosserial.monedas;
				cuentallaves.text = "pages: "+paginas+"/20";
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(nivel == 21 || nivel == 22 || nivel == 23 || nivel == 25 || nivel == 26 )
			{
				cuentavidas.text = ""+jugador.vida;
				vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
			}
			if(personaje == 1 )
			{
				p1c.SetActive(true);
				p2c.SetActive(false);
			}
			if(personaje == 2)
			{
				p1c.SetActive(false);
				p2c.SetActive(true);
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 0 && datosserial.block1 == 0)
			{
				mision.text = "mission: get the keys to the 4 available levels";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 0 && datosserial.block1 == 0)
			{
				mision.text = "mission: open the blue door of the boss and face him";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 0 && datosserial.block1 == 1)
			{
				mision.text = "mission: beat the boss";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 0)
			{
				mision.text = "mission: get the keys to the 4 available levels";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 0)
			{
				mision.text = "mission: open the blue door of the boss and face him";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 1)
			{
				mision.text = "mission: beat the boss";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 0)
			{
				mision.text = "mission: get the keys to the 4 available levels";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 0)
			{
				mision.text = "mission: open the blue door of the boss and face him";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1)
			{
				mision.text = "mission: beat the boss";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1  && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 0)
			{
				mision.text = "mission: get the keys to the 4 available levels";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 0)
			{
				mision.text = "mission: open the blue door of the boss and face him";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1)
			{
				mision.text = "mission: beat the boss";
			}
			if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1  && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 0)
			{
				mision.text = "mission: get the keys to the 4 available levels";
			}
			if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 0 )
			{
				mision.text = "mission: open the blue door of the boss and face him";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 )
			{
				mision.text = "mission: beat the boss";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 )
			{
				mision.text = "mission: get on the ship and go for the pirate king";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && datosserial.finalmalo == 1 && paginas < 20)
			{
				mision.text = "mission: find the 20 pages in the levels and go to the family island";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && paginas == 20 && datosserial.finalbueno == 0)
			{
				mision.text = "mission: go to the family island there is someone waiting for you";
			}
			if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && datosserial.finalbueno == 1)
			{
				mision.text = "mission: go for the pirate king";
			}
			}
		}
		if(datosconfig.idioma == "cat")
		{
			if(menu == -2)
			{
				boton1.text = "en quin dispositiu estas jugant?";
				boton2.text = "si estas jugant a un pc tabla o android selecciona dispositiu tactil si estas en els anteriors dispositius amb un mando o en un pc o consola selecciona pc o consola";
				boton3.text = "una vegada selecionat per cambiaro entra a opcions";
				boton4.text = "controls";
				boton5.text = "pc o consola";
				boton6.text = "dispositiu tactil";
			}
			if(menu == -1)
			{
				boton1.text = "controls";
				boton2.text = "teclat y ratoli o mando";
				boton3.text = "controls tactils";
				boton4.text = "idioma";
				boton5.text = "espanol";
				boton6.text = "catala";
				boton7.text = "english";
			}
			if(menu == 1)
			{
				boton1.text = "presenta";
			}
			if(menu == 2)
			{
				boton1.text = "esborra data";
				boton2.text = "opcions";
				boton3.text = "inicia aventura";
			}
			if(menu == 3)
			{
				boton1.text = "salta";
			}
			if(menu == 4)
			{
				boton1.text = "estas segur?";
				boton2.text = "andarrere";
				boton3.text = "esborra data";
			}
			if(menu == 5)
			{
				boton1.text = "FI";
				boton2.text = "per sortir al menu principal";
			}
			if(menu == 6)
			{
				boton1.text = "FIN?";
				boton2.text = "per continuar";
			}
			if(menu == 7)
			{
				boton1.text = "FI?";
				boton2.text = "per sortir al menu principal";
			}
			if(estado == 1)
			{
				boton1.text = "Temps";
				boton2.text = "per sortir";
			}
			if(estado == 2)
			{
				boton1.text = "SALA DEL REY";
				boton2.text = "per sortir";
			}




			if(tuto == 1)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "per seleccionar nivell canvia amb (q) i (e) o (lb) i (rb) i prem (clic esquerre) o (x) per comencar";
				boton3.text = "quan tinguis quatre claus usa-les amb la roca blava per desbloquejar la porta del pirata";
			}
			if(tuto == -1)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "prem wasd o joystick per esquivar prem (clic esquerre) o (x) per disparar esquiva els trets del pirata matal i sobreviu";
			}
			if(tuto == 2)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "acabes d'aconseguir el salt doble pressiona (espai) o (a )per saltar i mantingues per saltar mes alt tambe pots fer un salt deixar anar i tornar a premer el boto per maximitzar la seva longitud";
				boton3.text = "has desbloqueado la tienda de la caseta morada puedes gastar monedas para comprar objetos";
			}
			if(tuto == 3)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "acabes d'aconseguir l'habilitat disparar ara pots recollir bales i fer-les servir usa (q) i (e) o (lb) i (rb) per seleccionar habilitat pressiona (clic esquerre) per utilitzar una habilitat amb la pistola pots trencar murs i accedir a noves zones";
			}
			if(tuto == 4)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "ara tens acces al cotxe troba'l pel mapa podras utilitzar-lo usa'l per arribar a l'altre costat del pont";
			}
			if(tuto == 5)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "ara tens acces al cotxe troba'l pel mapa podras utilitzar-lo usa'l per arribar a l'altre costat del pont";
			}
			if(tuto == 6)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "has aconseguit l'habilitat control mental ara pot controlar algun pirata des de la plat blava de hipnotitcar usant la seva habilitat al selector segur que algun pirata pot obrir-te camí al cau del comandant";
			}
			if(tuto == 7)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "cursa de cotxes";
				boton3.text = "en donar-li al (espai) o (a) comences la cursa prem (espai) o (a) per accelerar (a) i (d) o fes servir el joystick per girar el cotxe prem (clic esquerre) o (b) per a la marxa enrere que guanyi el millor";
			}
			if(tuto == 8)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "el rei pirata a escapat, ves-te'n per ell, utilitza la teva nau que esta davant del cau pero tingues en compte que es molt poderos potser algu pugui ajudar-te";
				
			}
			if(tuto == 9)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "la teva familia ha estat segrestada aqui podras escoltar els seus diaris aconsegueix-los en els nivells si els aconsegueixes tots potser algu pugui ajudar-te a vencer el rei pirata";
			}
			if(tuto == 10)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "ara pots fer diverses coses pots anar a enfrontar-te al rei pirata tingues en compte que es molt poderos pot ser que necessitis ajuda tambe hi ha una botiga amb nous objectes i una illa on podras escoltar els diaris que recullis en els nivells que hagis fet per ultim aquesta la gran torre del temps on podras trencar els teus records pero recorda no hi ha checkpoits nomes un temporitzador POTS COMPRAR OBJECTES PER APURAR EL TEMPS";
			}
			if(tuto == 11)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "el rei pirata a escapat";
			}
			if(tuto == 12)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "comencaras el combat final aquest enemic es molt poderos necessitessis ajuda igual no es bona idea enfrontar-te al sol";
			}
			if(tuto == 13)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "aqui pots comprar objectes especials necessaris per completar els secrets dels nivells tambe serveixen per treure millors temps a la torre del temps objectes: bala: serveix per trencar parets pocio: serveix per recuperar vitalitat pocio de velocitat: serveix per anar rapid sense la seva plat pocio mortal: et fa invulnerable a la lava durant 15 segons";
			}
			if(tuto == 14)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "aixo es la torre del temps aqui podras repetir els nivells en contrarellotge pots fer servir totes les teves habilitats escull la millor ruta treu els millors records que puguis sort";
			}

			if(tuto == -1)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "mou-te amb wasd o joystick prem (espai) o (a) per saltar";
				boton3.text = "prem (espai) o (a) als saltadors verds per saltar mes alt quan toquis un accelerador groc podras saltar amb mes longitud";
			}
			if(tuto == -2)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "prem (a) i (d) o joystick per moure't prem (espai) o (a) per saltar prem (clic dret) per canviar la perspectiva";
				boton3.text = "prem (espai) o (a) als saltadors verds per saltar mes alt quan toquis un accelerador groc podras saltar amb mes longitud";
			}
			if(tuto == -3)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "mou-te amb wasd o joystick prem (espai) o (a) per saltar utilitza el salt doble per arribar mes alt i mes lluny";
			}
			if(tuto == -4)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "prem (a) i (d) o joystick per moure't prem (espai) o (a) per saltar prem (clic dret) per canviar la perspectiva";
				boton3.text = "utilitza el salt doble per arribar mes alt i mes lluny";
			}
			if(tuto == -5)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "mou-te amb wasd o joystick prem (espai) o (a) per saltar usa (q) i (e) o (lb) i (rb) per seleccionar habilitat prem (clic esquerre) per utilitzar una habilitat";
				boton3.text = "utilitza l'habilitat bala per trencar objectes molestos de l'entorn alguns son trencables altres no prova haver-hi si hi ha sort";
			}
			if(tuto == -6)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "prem (a) i (d) o joystick per moure't prem (espai) o (a) per saltar prem (clic dret) per canviar la perspectiva";
			}
			if(tuto == -7)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "mou-te amb wasd o joystick prem (espai) o (a) per saltar";
			}
			if(tuto == -8)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "prem (espai) o (a) per accelerar (a) i (d) o fes servir el joystick per girar el cotxe prem (clic esquerre) o (b) per a la marxa enrere";
			}
			if(tuto == -9)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "prem (a) i (d) o joystick per moure't prem (espai) o (a) per saltar prem (clic dret) per canviar la perspectiva utilitza el hipnoticar per obrir-te cami";
			}
			if(tuto == -10)
			{
				boton1.text = "pren (espai) o (a) per continuar";
				boton2.text = "mou-te amb wasd o joystick prem (espai) o (a) per saltar utilitza el hipnotitcar per obrir-te cami";
			}





			if(pause == false)
			{
				if(nivel  <= -1 && nivel >= -20)
				{
					cuentavidas.text = ""+jugador.vida;
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(nivel >= 1 && nivel <= 20 && personaje == 1 || nivel >= 1 && nivel <= 20 && personaje == 0 )
				{
					cuentavidas.text = ""+jugador.vida;
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
				}
				if(nivel == 1 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv1+"/3";
				}
				if(nivel == 2 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv2+"/3";
				}
				if(nivel == 3 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv3+"/3";
				}
				if(nivel == 4 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv4+"/3";
				}

				if(nivel == 5 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv5+"/3";
				}
				if(nivel == 6 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv6+"/3";
				}
				if(nivel == 7 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv7+"/3";
				}
				if(nivel == 8 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv8+"/3";
				}

				if(nivel == 9 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv9+"/3";
				}
				if(nivel == 10 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv10+"/3";
				}
				if(nivel == 11 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv11+"/3";
				}
				if(nivel == 12 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv12+"/3";
				}

				if(nivel == 13 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv13+"/3";
				}
				if(nivel == 14 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv14+"/3";
				}
				if(nivel == 15 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv15+"/3";
				}
				if(nivel == 16 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv16+"/3";
				}

				if(nivel == 17 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv17+"/3";
				}
				if(nivel == 18 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv18+"/3";
				}
				if(nivel == 19 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv19+"/3";
				}
				if(nivel == 20 )
				{
					cuentafrag.text = "TROSSOS DE PAGINA: "+datosserial.trozosnv20+"/3";
				}
				if(nivel >= 1 && nivel <= 20 && personaje == 2)
				{
					cuentavidas.text = ""+jugador2.vida;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(nivel == 0 && personaje == 1 && datosserial.tengonave == 0)
				{
					cuentavidas.text = ""+jugador.vida;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
					cuentallaves.text = "LLAVES: "+datosserial.llaves+"/4";
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(nivel == 0 && personaje == 2 && datosserial.tengonave == 0)
				{
					cuentavidas.text = ""+jugador2.vida;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
					cuentallaves.text = "LLAVES: "+datosserial.llaves+"/4";
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(nivel == 0 && personaje == 1 && datosserial.tengonave == 1)
				{
					cuentavidas.text = ""+jugador.vida;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
					cuentallaves.text = "PAGINAS: "+paginas+"/20";
				}
				if(nivel == 0 && personaje == 2 && datosserial.tengonave == 1)
				{
					cuentavidas.text = ""+jugador2.vida;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
					cuentallaves.text = "PAGINAS: "+paginas+"/20";
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(nivel == 500)
				{
					cuentavidas.text = ""+jugador.vida;
					cuentamonedas.text = "MONEDAS: "+datosserial.monedas;
					cuentallaves.text = "PAGINAS: "+paginas+"/20";
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(nivel == 21 || nivel == 22 || nivel == 23 || nivel == 25 || nivel == 26 )
				{
					cuentavidas.text = ""+jugador.vida;
					vidaui.fillAmount = jugador.vida/datosserial.vidamaxima;
				}
				if(personaje == 1 )
				{
					p1c.SetActive(true);
					p2c.SetActive(false);
				}
				if(personaje == 2)
				{
					p1c.SetActive(false);
					p2c.SetActive(true);
				}
				if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 0 && datosserial.block1 == 0)
				{
					mision.text = "misio: aconsegueix les claus dels 4 datosserial.nivells disponibles";
				}
				if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 0 && datosserial.block1 == 0)
				{
					mision.text = "misio: obre la porta blava del pirata i enfronta'l";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 0 && datosserial.block1 == 1)
				{
					mision.text = "misio: venc al pirata";
				}
				if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 0)
				{
					mision.text = "misio: aconsegueix les claus dels 4 datosserial.nivells disponibles";
				}
				if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 0)
				{
					mision.text = "misio: obre la porta blava del pirata i enfronta'l";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 0 && datosserial.block1 == 1 && datosserial.block2 == 1)
				{
					mision.text = "misio: venc al pirata";
				}
				if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 0)
				{
					mision.text = "misio: aconsegueix les claus dels 4 datosserial.nivells disponibles";
				}
				if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 0)
				{
					mision.text = "misio: obre la porta blava del pirata i enfronta'l";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1)
				{
					mision.text = "misio: venc al pirata";
				}
				if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1  && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 0)
				{
					mision.text = "misio: aconsegueix les claus dels 4 datosserial.nivells disponibles";
				}
				if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 0)
				{
					mision.text = "misio: obre la porta blava del pirata i enfronta'l";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1)
				{
					mision.text = "misio: venc al pirata";
				}
				if(nivel == 0 && datosserial.llaves < 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1  && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 0)
				{
					mision.text = "misio: aconsegueix les claus dels 4 datosserial.nivells disponibles";
				}
				if(nivel == 0 && datosserial.llaves == 4 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 0 )
				{
					mision.text = "misio: obre la porta blava del pirata i enfronta'l";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 0 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 )
				{
					mision.text = "misio: venc al pirata";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 )
				{
					mision.text = "misio: puja a la nau i ves a buscar el rei pirata";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && datosserial.finalmalo == 1 && paginas < 20)
				{
					mision.text = "misio: busca les 20 pagines als datosserial.nivells i ves a l'illa familiar";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && paginas == 20 && datosserial.finalbueno == 0)
				{
					mision.text = "misio: ves a l'illa familiar hi ha algu esperant-te";
				}
				if(nivel == 0 && datosserial.llaves == 0 && datosserial.tengosaltod == 1 && datosserial.tengodisparo == 1 && datosserial.tengocoche == 1 && datosserial.tengomental == 1 && datosserial.tengonave == 1 && datosserial.block1 == 1 && datosserial.block2 == 1 && datosserial.block3 == 1 && datosserial.block4 == 1 && datosserial.block5 == 1 && datosserial.finalbueno == 1)
				{
					mision.text = "mision: ves a buscar el rei pirata";
				}
			}
		}
		


	}
}
