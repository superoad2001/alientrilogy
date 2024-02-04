using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class manager_al3: MonoBehaviour
{
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

	public int armastotal;
	public int armadurastotal;
	public int diariostotal;

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

	public string repathtro;
	

	public void GetFilePath()
    {
        string result;
 
		result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alien3data.data");
 
        repath = result;
    }
	public void GetFilePathconfig()
    {
        string result;
 
		result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alienconfigdata.data");
 
        repathconfig = result;
    }
	public void GetFilePathtro()
    {
        string result;
 
		result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alientorfeodata.data");
 
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

		if(datosserial.tarma[0] == 1)
		{armastotal++;}
        if(datosserial.tarma[1] == 1)
		{armastotal++;}
        if(datosserial.tarma[2] == 1)
		{armastotal++;}
        if(datosserial.tarma[3] == 1)
		{armastotal++;}
        if(datosserial.tarma[4] == 1)
		{armastotal++;}
        if(datosserial.tarma[5] == 1)
		{armastotal++;}
        if(datosserial.tarma[6] == 1)
		{armastotal++;}
        if(datosserial.tarma[7] == 1)
		{armastotal++;}
        if(datosserial.tarma[8] == 1)
		{armastotal++;}
        if(datosserial.tarma[9] == 1)
		{armastotal++;}
        if(datosserial.tarma[10] == 1)
		{armastotal++;}
        if(datosserial.tarma[11] == 1)
		{armastotal++;}
        if(datosserial.tarma[12] == 1)
		{armastotal++;}
        if(datosserial.tarma[13] == 1)
		{armastotal++;}
        if(datosserial.tarma[14] == 1)
		{armastotal++;}

        if(datosserial.tarmad[0] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[1] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[2] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[3] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[4] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[5] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[6] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[7] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[8] == 1)
		{armadurastotal++;}
        if(datosserial.tarmad[9] == 1)
		{armadurastotal++;}


		if(trofeoact == 1)
		{datostrof.completaalien3m = 1;}
		if(trofeoact == 2)
		{datostrof.completaalien3v = 1;}
		if(trofeoact == 3)
		{datostrof.alien3acabaeltutorial = 1;}
		guardartro();

		
		jugador1_al3 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al3>();
		


		if(niveltouch == true && datosconfig.plat == 2)
		{
			touch.SetActive(true);
		}


		jugador1_al3 jugador1 = UnityEngine.Object.FindObjectOfType<jugador1_al3>();

		//fase 1
		if(datosserial.tdiario1 == 1)
		{diariostotal++;}
		if(datosserial.tdiario2 == 1)
		{diariostotal++;}
		if(datosserial.tdiario3 == 1)
		{diariostotal++;}
		if(datosserial.tdiario4 == 1)
		{diariostotal++;}
		if(datosserial.tdiario5 == 1)
		{diariostotal++;}
		if(datosserial.tdiario6 == 1)
		{diariostotal++;}
		if(datosserial.tdiario7 == 1)
		{diariostotal++;}
		if(datosserial.tdiario8 == 1)
		{diariostotal++;}
		if(datosserial.tdiario9 == 1)
		{diariostotal++;}
		if(datosserial.tdiario10 == 1)
		{diariostotal++;}
		if(datosserial.tdiario11 == 1)
		{diariostotal++;}
		if(datosserial.tdiario12 == 1)
		{diariostotal++;}
		if(datosserial.tdiario13 == 1)
		{diariostotal++;}
		if(datosserial.tdiario14 == 1)
		{diariostotal++;}
		if(datosserial.tdiario15 == 1)
		{diariostotal++;}
		
	}

	private void Update()
	{
		manager_al2 manageral2 = UnityEngine.Object.FindObjectOfType<manager_al2>();

		if(datosserial.monedas >= 5000 && datostrof.alien3ahorra5000monedas != 1)
		{
			datostrof.alien3ahorra5000monedas = 1;
			guardartro();
		}
		if(datosserial.vidamaxima ==  100 && datostrof.alien3consiguetodadlasmejorasvida != 1)
		{
			datostrof.alien3consiguetodadlasmejorasvida = 1;
			guardartro();
		}
		if(datosserial.marma1 == 0 && datosserial.marma5 == 0 &&  datosserial.marma6 == 0 && datosserial.marma7 == 0 && datosserial.marma8 == 0 && datosserial.marma9 == 0 && datosserial.marma10 == 0 && datosserial.marma11 == 0 && datosserial.marma13 == 0 && datosserial.marma14 == 0 && datosserial.marma15 == 0 && datostrof.alien3gastatodalamuniciondetodaslasarmas != 1)
		{
			datostrof.alien3gastatodalamuniciondetodaslasarmas = 1;
			guardartro();
		}
		if(armastotal == 15 && datostrof.alien3consiguetodaslasarmas != 1)
		{
			datostrof.alien3consiguetodaslasarmas = 1;
			guardartro();
		}
		if(armadurastotal == 15 && datostrof.alien3consiguetodaslasarmaduras!= 1)
		{
			datostrof.alien3consiguetodaslasarmaduras = 1;
			guardartro();
		}
		if(datosserial.enemigos >= 100 && datostrof.alien3vence100enemigos != 1)
		{
			datostrof.alien3vence100enemigos = 1;
			guardartro();
		}
		if(datosserial.enemigos >= 200 && datostrof.alien3vence200enemigos != 1)
		{
			datostrof.alien3vence200enemigos = 1;
			guardartro();
		}

		if(datosconfig.idioma == "es")
		{
			if(jefen == 1)
			{
				jefetitulo.text = "falsos papa y mama";
			}
			if(jefen == 2)
			{
				jefetitulo.text = "el ente de oro";
			}
			if(jefen == 3)
			{
				jefetitulo.text = "el encorbado";
			}
			if(jefen == 4)
			{
				jefetitulo.text = "la oscuridad";
			}
			if(jefen == 5)
			{
				jefetitulo.text = "el encorbado";
			}
			if(jefen == 6)
			{
				jefetitulo.text = "la oscuridad";
			}
			if(jefen == 7)
			{
				jefetitulo.text = "presecutor";
			}
			if(jefen == 8)
			{
				jefetitulo.text = "desvivetizador";
			}
			if(jefen == 9)
			{
				jefetitulo.text = "nave de huida";
			}
			if(jefen == 10)
			{
				jefetitulo.text = "el encorbado superior";
			}
			if(jefen == 11)
			{
				jefetitulo.text = "el encorbado supremo";
			}
			if(cmenu == 1)
			{
				bloque1.text = "controles";
				bloque2.text = "teclado y raton o mando";
				bloque3.text = "tactiles";
				bloque4.text = "idioma";
			}
			if(cmenu == 2)
			{
				bloque1.text = "estas seguro?";
				bloque2.text = "atras";
				bloque3.text = "borrar partida";
			}
			if(cmenu == 3)
			{
				bloque1.text = "cargando";
			}
			if(cmenu == 4)
			{
				bloque1.text = "en que dispositivo estas jugando?";
				bloque2.text = "controles";
				bloque3.text = "pc o consola";
				bloque4.text = "dispositivo tactil";
				bloque5.text = "si estas jugando en un pc tableta o android selecciona dispositivo tactil si estas en los anteriores dispositivos con un mando o en pc o consola selecciona pc o consola";
				bloque6.text = "una vez selecionado para cambiarlo entra a opciones";
			}
			if(cmenu == 5)
			{
				bloque1.text = "fin";
				bloque2.text = "Apreta (manager.datosserial.espacio) o (a) para salir al menu principal";
			}
			if(cmenu == 6)
			{
				bloque1.text = "saltar";
			}
			if(cmenu == 7)
			{
				bloque1.text = "tu padre te a dejado "+manageral2.datosserial.monedas+" monedas";
				bloque2.text = "recojer dinero de papa";
				bloque3.text = "dejar dinero de papa";
			}
		}
		if(datosconfig.idioma == "en")
		{
			if(jefen == 1)
			{
				jefetitulo.text = "fake dad and mom";
			}
			if(jefen == 2)
			{
				jefetitulo.text = "the golden entity";
			}
			if(jefen == 3)
			{
				jefetitulo.text = "the stooped";
			}
			if(jefen == 4)
			{
				jefetitulo.text = "la oscuridad";
			}
			if(jefen == 5)
			{
				jefetitulo.text = "the darkness";
			}
			if(jefen == 6)
			{
				jefetitulo.text = "the darkness";
			}
			if(jefen == 7)
			{
				jefetitulo.text = "prosecutor";
			}
			if(jefen == 8)
			{
				jefetitulo.text = "unlivetizador";
			}
			if(jefen == 9)
			{
				jefetitulo.text = "escape ship";
			}
			if(jefen == 10)
			{
				jefetitulo.text = "the superior stooped";
			}
			if(jefen == 11)
			{
				jefetitulo.text = "the supremo stooped";
			}
			if(cmenu == 1)
			{
				bloque1.text = "controls";
				bloque2.text = "keyboard and mouse or controller";
				bloque3.text = "touch device";
				bloque4.text = "lenguage";
			}
			if(cmenu == 2)
			{
				bloque1.text = "you're sure?";
				bloque2.text = "back";
				bloque3.text = "delete data";
			}
			if(cmenu == 3)
			{
				bloque1.text = "loading";
			}
			if(cmenu == 4)
			{
				bloque1.text = "What device are you playing on?";
				bloque2.text = "controls";
				bloque3.text = "pc or console";
				bloque4.text = "touch device";
				bloque5.text = "If you are playing on a PC, tablet or Android, select touch device, if you are on the previous devices with a controller or on a PC or console, select PC or console";
				bloque6.text = "once selected to change it, go to options";
			}
			if(cmenu == 5)
			{
				bloque1.text = "the end";
				bloque2.text = "Press (space) or (a) to exit to the main menu";
			}
			if(cmenu == 6)
			{
				bloque1.text = "skip";
			}
			if(cmenu == 7)
			{
				bloque1.text = "your father has left you "+manageral2.datosserial.monedas+ " coins";
				bloque2.text = "take daddy's money";
				bloque3.text = "don't take daddy's money";
			}
		}
		if(datosconfig.idioma == "cat")
		{
			if(jefen == 1)
			{
				jefetitulo.text = "falsos pare i mare";
			}
			if(jefen == 2)
			{
				jefetitulo.text = "l entitat d or";
			}
			if(jefen == 3)
			{
				jefetitulo.text = "l encorbat";
			}
			if(jefen == 4)
			{
				jefetitulo.text = "la oscuritat";
			}
			if(jefen == 5)
			{
				jefetitulo.text = "el encorbat";
			}
			if(jefen == 6)
			{
				jefetitulo.text = "la oscuritat";
			}
			if(jefen == 7)
			{
				jefetitulo.text = "presecutor";
			}
			if(jefen == 8)
			{
				jefetitulo.text = "desvivetizador";
			}
			if(jefen == 9)
			{
				jefetitulo.text = "nau de huida";
			}
			if(jefen == 10)
			{
				jefetitulo.text = "el encorbat superior";
			}
			if(jefen == 11)
			{
				jefetitulo.text = "el encorbat suprem";
			}
			if(cmenu == 1)
			{
				bloque1.text = "controls";
				bloque2.text = "teclat y ratoli o mando";
				bloque3.text = "controls tactils";
				bloque4.text = "idioma";
			}
			if(cmenu == 2)
			{
				bloque1.text = "estas segur?";
				bloque2.text = "anrere";
				bloque3.text = "esborra data";
			}
			if(cmenu == 3)
			{
				bloque1.text = "cargan";
			}
			if(cmenu == 4)
			{
				bloque1.text = "en que dispositiu estas jugan?";
				bloque2.text = "controls";
				bloque3.text = "pc o consola";
				bloque4.text = "dispositiu tactil";
				bloque5.text = "si estas jugan a un pc tableta o android selecciona dispositiu tactil si estas en els anteriors dispositius amb un mando o pc o consola selecciona pc o consola";
				bloque6.text = "una vegada selecionat per cambiaro entra a opcions";
			}
			if(cmenu == 5)
			{
				bloque1.text = "fi";
				bloque2.text = "prem (espai) o (a) per sortir al menu principal";
			}
			if(cmenu == 6)
			{
				bloque1.text = "saltar";
			}
			if(cmenu == 7)
			{
				bloque1.text = "el teu pare te a deixat "+manageral2.datosserial.monedas+" monedas";
				bloque2.text = "recollir diners de en pare";
				bloque3.text = "deixar diners de en pare";
			}
		}
		jugador1_al3 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al3>();
		if(datosserial.marma11 < 3 && tempm11 > 25)
		{
			datosserial.marma11++;
			tempm11 = 0f;
		}
		else if(tempm11 < 30)
		{tempm11 += 1 * Time.deltaTime;}

		
	}
}
