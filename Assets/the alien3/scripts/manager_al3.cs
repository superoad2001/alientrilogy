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
	public AudioMixer audiomixer;
	public int MisionesCumplidas;
	public void move()
	{
		moevson.Play();
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
        result = Path.Combine(result, $"alien3data.data");
		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"AlienDatadev");
        result = Path.Combine(result, $"alien3data.data");
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
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));

		if(datosserial.monedas >= 5000 && datostrof.alien3ahorra5000monedas == 0)
		{
			datostrof.alien3ahorra5000monedas = 1;
			guardartro();
			push.push(91);
		}
		if(datosserial.vidamaxima ==  100 && datostrof.alien3consiguetodadlasmejorasvida == 0)
		{
			datostrof.alien3consiguetodadlasmejorasvida = 1;
			guardartro();
			push.push(95);
		}
		if(datostrof.alien3gastatodalamuniciondetodaslasarmas == 0 && datosserial.marma1 == 0 && datosserial.marma5 == 0 &&  datosserial.marma6 == 0 && datosserial.marma7 == 0 && datosserial.marma8 == 0 && datosserial.marma9 == 0 && datosserial.marma10 == 0 && datosserial.marma11 == 0 && datosserial.marma13 == 0 && datosserial.marma14 == 0 && datosserial.marma15 == 0)
		{
			datostrof.alien3gastatodalamuniciondetodaslasarmas = 1;
			guardartro();
			push.push(99);
		}
		if(datosserial.armastotal >= 1 && datostrof.alien3primeraarma == 0)
		{
			datostrof.alien3primeraarma = 1;
			guardartro();
			push.push(92);
		}
		if(datosserial.armastotal == 15 && datostrof.alien3consiguetodaslasarmas == 0)
		{
			datostrof.alien3consiguetodaslasarmas = 1;
			guardartro();
			push.push(98);
		}
		if(datosserial.armadurastotal >= 1 && datostrof.alien3primeraarmadura == 0)
		{
			datostrof.alien3primeraarmadura = 1;
			guardartro();
			push.push(93);
		}
		if(datosserial.armadurastotal == 10 && datostrof.alien3consiguetodaslasarmaduras == 0)
		{
			datostrof.alien3consiguetodaslasarmaduras = 1;
			guardartro();
			push.push(97);
		}
		if(datosserial.enemigos >= 100 && datostrof.alien3vence100enemigos == 0)
		{
			datostrof.alien3vence100enemigos = 1;
			guardartro();
			push.push(102);
		}
		if(datosserial.enemigos >= 200 && datostrof.alien3vence200enemigos == 0)
		{
			datostrof.alien3vence200enemigos = 1;
			guardartro();
			push.push(103);
		}
		if(trofeoact == 1 && datostrof.completaalien3m == 0)
		{
			datostrof.completaalien3m = 1;
			guardartro();
			push.push(87);
		}
		if(trofeoact == 2 && datostrof.completaalien3v == 0)
		{
			datostrof.completaalien3v = 1;
			guardartro();
			push.push(88);
		}
		if(trofeoact == 3 && datostrof.alien3acabaeltutorial == 0)
		{
			datostrof.alien3acabaeltutorial = 1;
			guardartro();
			push.push(89);
		}

		if(trofeoact == 4 && datostrof.alien3jefe1 == 0 && datosserial.espacio2act == 1)
		{
			datostrof.alien3jefe1 = 1;
			guardartro();
			push.push(52);
		}
		if(trofeoact == 4 && datostrof.alien3jefe2 == 0 && datosserial.espacio3act == 1)
		{
			datostrof.alien3jefe2 = 1;
			guardartro();
			push.push(53);
		}
		if(trofeoact == 4 && datostrof.alien3jefe3 == 0 && datosserial.espacio4act == 1)
		{
			datostrof.alien3jefe3 = 1;
			guardartro();
			push.push(54);
		}
		if(trofeoact == 4 && datostrof.alien3jefe4 == 0 && datosserial.espacio5act == 1)
		{
			datostrof.alien3jefe4 = 1;
			guardartro();
			push.push(55);
		}
		if(trofeoact == 5 && datostrof.alien3jefe5 == 0 )
		{
			datostrof.alien3jefe5 = 1;
			guardartro();
			push.push(56);
		}
		if(trofeoact == 6 && datostrof.alien3jefe6 == 0 )
		{
			datostrof.alien3jefe6 = 1;
			guardartro();
			push.push(57);
		}
		if(trofeoact == 4 && datostrof.alien3jefe1nave == 0 && datosserial.espacio2act == 2)
		{
			datostrof.alien3jefe1nave = 1;
			guardartro();
			push.push(58);
		}
		if(trofeoact == 4 && datostrof.alien3jefe5nave == 0 && datosserial.espacio5act == 2)
		{
			datostrof.alien3jefe5nave = 1;
			guardartro();
			push.push(59);
		}
		if(datostrof.alien3planeta1nave == 0 && datosserial.menu == 1)
		{
			datostrof.alien3planeta1nave = 1;
			guardartro();
			push.push(60);
		}
		if(datostrof.alien3planeta2nave == 0 && datosserial.menu == 2)
		{
			datostrof.alien3planeta2nave = 1;
			guardartro();
			push.push(61);
		}
		if(datostrof.alien3planeta3nave == 0 && datosserial.menu == 3)
		{
			datostrof.alien3planeta3nave = 1;
			guardartro();
			push.push(62);
		}
		if(datostrof.alien3planeta4nave == 0 && datosserial.menu == 4)
		{
			datostrof.alien3planeta4nave = 1;
			guardartro();
			push.push(63);
		}
		if(datostrof.alien3planeta5nave == 0 && datosserial.menu == 5)
		{
			datostrof.alien3planeta5nave = 1;
			guardartro();
			push.push(64);
		}
		if(datostrof.alien3planeta6nave == 0 && datosserial.menu == 6)
		{
			datostrof.alien3planeta6nave = 1;
			guardartro();
			push.push(65);
		}
		if(datostrof.alien3planeta7nave == 0 && datosserial.menu == 7)
		{
			datostrof.alien3planeta7nave = 1;
			guardartro();
			push.push(66);
		}
		if(datostrof.alien3planeta8nave == 0 && datosserial.menu == 8)
		{
			datostrof.alien3planeta8nave = 1;
			guardartro();
			push.push(67);
		}
		if(datostrof.alien3planeta9nave == 0 && datosserial.menu == 9)
		{
			datostrof.alien3planeta9nave = 1;
			guardartro();
			push.push(68);
		}
		if(datostrof.alien3planeta10nave == 0 && datosserial.menu == 10)
		{
			datostrof.alien3planeta10nave = 1;
			guardartro();
			push.push(69);
		}
		if(datostrof.alien3planeta11nave == 0 && datosserial.menu == 11)
		{
			datostrof.alien3planeta11nave = 1;
			guardartro();
			push.push(70);
		}
		if(datostrof.alien3planeta12nave == 0 && datosserial.menu == 12)
		{
			datostrof.alien3planeta12nave = 1;
			guardartro();
			push.push(71);
		}
		if(datostrof.alien3planeta13nave == 0 && datosserial.menu == 13)
		{
			datostrof.alien3planeta13nave = 1;
			guardartro();
			push.push(72);
		}
		if(datostrof.alien3planeta14nave == 0 && datosserial.menu == 14)
		{
			datostrof.alien3planeta14nave = 1;
			guardartro();
			push.push(73);
		}
		if(datostrof.alien3planeta15nave == 0 && datosserial.menu == 15)
		{
			datostrof.alien3planeta15nave = 1;
			guardartro();
			push.push(74);
		}
		if(datostrof.alien3planeta16nave == 0 && datosserial.menu == 16)
		{
			datostrof.alien3planeta16nave = 1;
			guardartro();
			push.push(75);
		}
		if(datostrof.alien3planeta17nave == 0 && datosserial.menu == 18)
		{
			datostrof.alien3planeta17nave = 1;
			guardartro();
			push.push(76);
		}
		if(datostrof.alien3consigue10gemas == 0 && datosserial.gemas >= 10)
		{
			datostrof.alien3consigue10gemas = 1;
			guardartro();
			push.push(80);
		}
		if(datostrof.alien3consigue20gemas == 0 && datosserial.gemas >= 20)
		{
			datostrof.alien3consigue20gemas = 1;
			guardartro();
			push.push(81);
		}
		if(datostrof.alien3consigue40gemas == 0 && datosserial.gemas >= 40)
		{
			datostrof.alien3consigue40gemas = 1;
			guardartro();
			push.push(82);
		}
		if(datostrof.alien3consigue70gemas == 0 && datosserial.gemas >= 70)
		{
			datostrof.alien3consigue70gemas = 1;
			guardartro();
			push.push(83);
		}
		if(datostrof.alien3consigue100gemas == 0 && datosserial.gemas >= 100)
		{
			datostrof.alien3consigue100gemas = 1;
			guardartro();
			push.push(84);
		}
		if(datostrof.alien3consiguetodaslaspaginas == 0 && datosserial.diariostotal >= 15)
		{
			datostrof.alien3consiguetodaslaspaginas = 1;
			guardartro();
			push.push(85);
		}
		if(trofeoact == 4 && datostrof.alien3aceptalaherencia == 0 && datosserial.herencia == 1)
		{
			datostrof.alien3aceptalaherencia = 1;
			guardartro();
			push.push(90);
		}
		if(trofeoact == 7 && datostrof.alien3aceptalaherencia == 0 && datosserial.herencia == 1)
		{
			datostrof.alien3aceptalaherencia = 1;
			guardartro();
			push.push(90);
		}
		if(datosserial.vidamaxima > 5 && datostrof.alien3primeramejoradevida == 0)
		{
			datostrof.alien3primeramejoradevida = 1;
			guardartro();
			push.push(94);
			
		}
		if(datosserial.alien3muere == 1 && datostrof.alien3muere == 0)
		{
			datostrof.alien3muere = 1;
			guardartro();
			push.push(101);
			
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
				jefetitulo.text = "la deidad";
			}
			if(jefen == 5)
			{
				jefetitulo.text = "el encorbado";
			}
			if(jefen == 6)
			{
				jefetitulo.text = "reminiscencia de la deidad";
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
			if(jefen == 12)
			{
				jefetitulo.text = "engendro";
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
				bloque2.text = "para salir al menu principal";
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
			if(cmenu == 8)
			{
				bloque1.text = "presenta";
				bloque2.text = "saltar";
			}



			if(misionact == true)
			{
				 if(menu == 0 && nivel == 0)
				 {
					mision.text = "mision: rompe la pared roja con tu arma mele";
				 }
				 if(menu == 0 && datosserial.tarma[0] == 1 && nivel == 0)
				 {
					mision.text = "mision: sube la rampa y dispara a la pared roja para que caiga el puente y sigue hasta llegar a la nave";
				 }


				//zona1

				 if(datosserial.gemas < 5)
				 {
					mision.text = "mision: consigue 5 gemas para desbloquear el portal en el cometa 2274";
				 }
				 if(datosserial.gemas >= 5)
				 {
					mision.text = "mision: ve al portal del cometa 2274 para buscar pistas sobre tu padre";
				 }
				 if(datosserial.espacio2act == 1)
				 {
					mision.text = "mision: ve al espacio y inicia el transito a la galaxia 24039";
				 }



				//zona2
				 if(datosserial.espacio2act == 2 && datosserial.gemas < 12)
				 {
					mision.text = "mision: consigue 12 gemas para desbloquear el portal en orotopia";
				 }
				 if(datosserial.espacio2act == 2 && datosserial.gemas >= 12)
				 {
					mision.text = "mision: ve al portal en orotopia para seguir el rastro del encorbado";
				 }
				 if(datosserial.espacio3act == 1 && datosserial.gemas >= 12)
				 {
					mision.text = "mision: ve al espacio y inicia el transito a la galaxia 30099";
				 }
				 //zona3
				 if(datosserial.espacio3act == 2 && datosserial.gemas < 21)
				 {
					mision.text = "mision: consigue 21 gemas para desbloquear el portal en asteroide 7248";
				 }
				 if(datosserial.espacio3act == 2 && datosserial.gemas >= 21)
				 {
					mision.text = "mision: ve al portal en asteroide 7248 el encorbado te esta esperando";
				 }
				 if(datosserial.espacio4act == 1 && datosserial.gemas >= 21)
				 {
					mision.text = "mision: ve al espacio y inicia el transito a la galaxia 45638";
				 }
				//zona4
				 if(datosserial.espacio4act == 2 && datosserial.gemas < 39)
				 {
					mision.text = "mision: consigue 39 gemas para desbloquear el portal en planeta x";
				 }
				 if(datosserial.espacio4act == 2 && datosserial.gemas >= 39)
				 {
					mision.text = "mision: ve al portal en planeta x y destruie a la deidad para detener al encorbado";
				 }
				 if(datosserial.espacio5act == 1 && datosserial.gemas >= 39)
				 {
					mision.text = "mision: ve al espacio y inicia el transito a la galaxia X??59";
				 }
				 //zona5
				 if(datosserial.espacio5act == 2 && datosserial.gemas < 70)
				 {
					mision.text = "mision: consigue 70 gemas para desbloquear el portal en viejo hogar";
				 }
				 if(datosserial.espacio5act == 2 && datosserial.gemas >= 70)
				 {
					mision.text = "mision: ve al portal en viejo hogar y destruye al encorbado";
				 }
				 if(datosserial.espacio0act == 0 && datosserial.gemas >= 70 && datosserial.tfinal1 == true)
				 {
					mision.text = "mision: ve al espacio y inicia el transito al final del universo";
				 }
					
				 //zona6
				 if(datosserial.espacio0act == 1 && datosserial.gemas < 100 && datosserial.tfinal1 == true)
				 {
					mision.text = "mision: consigue 100 gemas para desbloquear el portal en mundo final";
				 }
				 if(datosserial.espacio0act == 1 && datosserial.gemas >= 100 && datosserial.tfinal1 == true)
				 {
					mision.text = "mision: ve al portal en mundo final y destruie al remanente de la deidad";
				 }
				 if(datosserial.espacio0act == 1 && datosserial.gemas >= 100 && datosserial.tfinal1 == true && datosserial.tfinal2 == true)
				 {
					mision.text = "mision: si te a quedado alguna cosa puedes buscarla";
				 }
					
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
				jefetitulo.text = "the entity";
			}
			if(jefen == 5)
			{
				jefetitulo.text = "the stooped";
			}
			if(jefen == 6)
			{
				jefetitulo.text = "remiscence of the entity";
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
				jefetitulo.text = "the suprem stooped";
			}
			if(jefen == 12)
			{
				jefetitulo.text = "dark mirror";
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
			if(cmenu == 8)
			{
				bloque1.text = "present";
				bloque2.text = "skip";
			}
			if(misionact == true)
			{
				 if(menu == 0 && nivel == 0)
				 {
					mision.text = "Mission: Break the red wall with your melee weapon";
				 }
				 if(menu == 0 && datosserial.tarma[0] == 1 && nivel == 0)
				 {
					mision.text = "Mission: Go up the ramp and shoot the red wall to make the bridge fall and continue until you reach the ship";
				 }


				//zona1

				 if(datosserial.gemas < 5)
				 {
					mision.text = "Mission: Get 5 gems to unlock the portal on cometa 2274";
				 }
				 if(datosserial.gemas >= 5)
				 {
					mision.text = "Mission: Go to the portal of cometa 2274 to search for clues about your father";
				 }
				 if(datosserial.espacio2act == 1)
				 {
					mision.text = "Mission: Go to space and begin transit to galaxy 24039";
				 }



				//zona2
				 if(datosserial.espacio2act == 2 && datosserial.gemas < 12)
				 {
					mision.text = "Mission: Get 12 gems to unlock the portal in Orotopia";
				 }
				 if(datosserial.espacio2act == 2 && datosserial.gemas >= 12)
				 {
					mision.text = "Mission: Go to the portal in Orotopia to follow the trail of the hunchback";
				 }
				 if(datosserial.espacio3act == 1 && datosserial.gemas >= 12)
				 {
					mision.text = "Mission: Go to space and begin transit to galaxy 30099";
				 }
				 //zona3
				 if(datosserial.espacio3act == 2 && datosserial.gemas < 21)
				 {
					mision.text = "Mission: Get 21 gems to unlock the portal on asteroide 7248";
				 }
				 if(datosserial.espacio3act == 2 && datosserial.gemas >= 21)
				 {
					mision.text = "Mission: Go to the portal in asteroide 7248, the hunchback is waiting for you";
				 }
				 if(datosserial.espacio4act == 1 && datosserial.gemas >= 21)
				 {
					mision.text = "Mission: Go to space and begin transit to galaxy 45638";
				 }
				//zona4
				 if(datosserial.espacio4act == 2 && datosserial.gemas < 39)
				 {
					mision.text = "Mission: Get 39 gems to unlock the portal on planeta X";
				 }
				 if(datosserial.espacio4act == 2 && datosserial.gemas >= 39)
				 {
					mision.text = "Mission: Go to the portal on planeta X and destroy the deity to stop the hunchback";
				 }
				 if(datosserial.espacio5act == 1 && datosserial.gemas >= 39)
				 {
					mision.text = "Mission: Go to space and begin transit to galaxy X??59";
				 }
				 //zona5
				 if(datosserial.espacio5act == 2 && datosserial.gemas < 70)
				 {
					mision.text = "Mission: Get 70 gems to unlock the portal in viejo hogar";
				 }
				 if(datosserial.espacio5act == 2 && datosserial.gemas >= 70)
				 {
					mision.text = "Mission: Go to the portal in the viejo hogar and destroy the hunchback";
				 }
				 if(datosserial.espacio0act == 0 && datosserial.gemas >= 70 && datosserial.tfinal1 == true)
				 {
					mision.text = "Mission: Go to space and begin the transit to the end of the universe";
				 }
					
				 //zona6
				 if(datosserial.espacio0act == 1 && datosserial.gemas < 100 && datosserial.tfinal1 == true)
				 {
					mision.text = "Mission: Get 100 gems to unlock the portal in the final world";
				 }
				 if(datosserial.espacio0act == 1 && datosserial.gemas >= 100 && datosserial.tfinal1 == true)
				 {
					mision.text = "Mission: Go to the portal in the final world and destroy the remnant of the deity";
				 }
				 if(datosserial.espacio0act == 1 && datosserial.gemas >= 100 && datosserial.tfinal1 == true && datosserial.tfinal2 == true)
				 {
					mision.text = "Mission: If you have something left, you can look for it.";
				 }
					
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
				jefetitulo.text = "el encorbat";
			}
			if(jefen == 4)
			{
				jefetitulo.text = "la deitat";
			}
			if(jefen == 5)
			{
				jefetitulo.text = "el encorbat";
			}
			if(jefen == 6)
			{
				jefetitulo.text = "reflexe de la deitat";
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
			if(jefen == 12)
			{
				jefetitulo.text = "engendre";
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
				bloque1.text = "salta";
			}
			if(cmenu == 7)
			{
				bloque1.text = "el teu pare te a deixat "+manageral2.datosserial.monedas+" monedas";
				bloque2.text = "recollir diners de en pare";
				bloque3.text = "deixar diners de en pare";
			}
			if(cmenu == 8)
			{
				bloque1.text = "presenta";
				bloque2.text = "salta";
			}
			if(misionact == true)
			{
				 if(menu == 0 && nivel == 0)
				 {
					mision.text = "misio: trenca la pared vermella amb el teu arma mele";
				 }
				 if(menu == 0 && datosserial.tarma[0] == 1 && nivel == 0)
				 {
					mision.text = "misio: puja la rampa y dispara a la pared vermella para que caigui el pont i ves endevant fins a la nave";
				 }


				//zona1

				 if(datosserial.gemas < 5)
				 {
					mision.text = "misio: agafa 5 gemas per desbloquejar el portal en el cometa 2274";
				 }
				 if(datosserial.gemas >= 5)
				 {
					mision.text = "misio: ves cap al portal del cometa 2274 per buscar pistes sobre el teu pare";
				 }
				 if(datosserial.espacio2act == 1)
				 {
					mision.text = "misio: ve al espai y inicia el transit a la galaxia 24039";
				 }



				//zona2
				 if(datosserial.espacio2act == 2 && datosserial.gemas < 12)
				 {
					mision.text = "misio: agafa 12 gemas per desbloquejar el portal en orotopia";
				 }
				 if(datosserial.espacio2act == 2 && datosserial.gemas >= 12)
				 {
					mision.text = "misio: ves cap al portal de orotopia para seguir el rastre del encorbat";
				 }
				 if(datosserial.espacio3act == 1 && datosserial.gemas >= 12)
				 {
					mision.text = "misio: ve al espacio y inicia el transito a la galaxia 30099";
				 }
				 //zona3
				 if(datosserial.espacio3act == 2 && datosserial.gemas < 21)
				 {
					mision.text = "misio: agafa 21 gemas per desbloquejar el portal en asteroide 7248";
				 }
				 if(datosserial.espacio3act == 2 && datosserial.gemas >= 21)
				 {
					mision.text = "misio: ves cap al portal del asteroide 7248 el encorbat esta esperan";
				 }
				 if(datosserial.espacio4act == 1 && datosserial.gemas >= 21)
				 {
					mision.text = "misio: ve al espacio y inicia el transito a la galaxia 45638";
				 }
				//zona4
				 if(datosserial.espacio4act == 2 && datosserial.gemas < 39)
				 {
					mision.text = "misio: agafa 39 gemas per desbloquejar el portal en planeta x";
				 }
				 if(datosserial.espacio4act == 2 && datosserial.gemas >= 39)
				 {
					mision.text = "misio: ves cap al portal del planeta x y mata a la deitat per detenir al encorbat";
				 }
				 if(datosserial.espacio5act == 1 && datosserial.gemas >= 39)
				 {
					mision.text = "misio: ve al espacio y inicia el transito a la galaxia X??59";
				 }
				 //zona5
				 if(datosserial.espacio5act == 2 && datosserial.gemas < 70)
				 {
					mision.text = "misio: agafa 70 gemas per desbloquejar el portal en viejo hogar";
				 }
				 if(datosserial.espacio5act == 2 && datosserial.gemas >= 70)
				 {
					mision.text = "misio: ves cap al portal del viejo hogar y mata al encorbat";
				 }
				 if(datosserial.espacio0act == 0 && datosserial.gemas >= 70 && datosserial.tfinal1 == true)
				 {
					mision.text = "misio: ve al espacio y inicia el transito al final del universo";
				 }
					
				 //zona6
				 if(datosserial.espacio0act == 1 && datosserial.gemas < 100 && datosserial.tfinal1 == true)
				 {
					mision.text = "misio: agafa 100 gemas per desbloquejar el portal en mundo final";
				 }
				 if(datosserial.espacio0act == 1 && datosserial.gemas >= 100 && datosserial.tfinal1 == true)
				 {
					mision.text = "misio: ves cap al portal del mundo final y mata al remanent de la deitat";
				 }
				 if(datosserial.espacio0act == 1 && datosserial.gemas >= 100 && datosserial.tfinal1 == true && datosserial.tfinal2 == true)
				 {
					mision.text = "misio: si te a quedat alguna cosa pots buscarla";
				 }
					
			}
		}
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
