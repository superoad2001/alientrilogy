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
	public bool tutorial;
	public bool desarmadef;
	public manager_nivel_al1 managerN;
	public bool cin;
	public int MisionesCumplidas;
	public bool nivelact;
	public bool puertasgiract;
	public bool puertasposact;
	public bool muertetutorial;
	public int trofeoact;
	public bool combatenave;
	public bool controlene = true;
	public float tempshow;
	public bool actguardarub;
	public string nivelu;
	public bool cargando;
	public jugador_al1 jugador;
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
	public GameObject misionUI;

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

	[SerializeField]
	public misiones_al1 dmisiones;

	public bool tutorialintro;
	public int misionS;

	public bool hierronivel;
	public int IDhierronivel;
	

	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C
	public void misioncomplete(int i)
	{
		if(datosserial.misiondescS == dmisiones.misionesdesc[i])
		{
			datosserial.misionS = "";
			datosserial.misiondescS = "";

		}
		datosserial.misiones[i] = 2;
	}
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



		datosserial.signivelexp = 3;

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
		
		IDhierronivel = -100;

		if(datosserial.economia[0] >= 2)
		{
			datosserial.misiones[8] = 2;
		}
		if(datosserial.economia[0] >= 3)
		{
			datosserial.misiones[11] = 2;
		}
		if(desarmadef == true)
		{
			datosserial.armadef = false;
			datosserial.armasel = 0;
			guardar();
		}
		

		
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			hidemenu_al1 hide = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
			hide.anim.SetBool("show2",true);
		}

		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));


		if(nivelact == false && cin == false)
		{

			datosserial.nivelu = SceneManager.GetActiveScene().name;
			manager.guardar();
		}
		if (puertasposact == true && datosserial.puertaposact == true)
		{
			//jugador.transform.position = datosserial.puertapos;
		}
		if (puertasgiract == true && datosserial.puertagiract == true)
		{
			jugador.transform.eulerAngles = new Vector3(jugador.transform.eulerAngles.x,datosserial.puertagir,jugador.transform.eulerAngles.z);
		}
		if((manager_nivel_al1)FindFirstObjectByType(typeof(manager_nivel_al1)) != null)
		{
			managerN = (manager_nivel_al1)FindFirstObjectByType(typeof(manager_nivel_al1));
			if(nivelact && (manager_ordas_al1)FindFirstObjectByType(typeof(manager_ordas_al1)) == null )
			{
				managerN.ubi = datosserial.actual_checkpoint;
				managerN.carga();

			}
		}


		for(int p = 0; p < datosserial.misiones.Length; p++)
		{
			if(datosserial.misiones[p] == 2)
			{MisionesCumplidas++;}
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
	public bool actG;

	// Token: 0x04000032 RID: 

	// Token: 0x04000038 RID: 56
	
	// Token: 0x06000026 RID: 38 RVA: 0x000037BC File Offset: 0x000019BC
	private void Update()
	{

		if(actG)
		{
			guardar();
			actG = false;
		}
		/*if(trofeoact == 1 && datostrof.completaalien1m == 0)
		{
			datostrof.completaalien1m = 1;
			push.push(15);
			guardartro();
		}
		if(trofeoact == 2 && datostrof.completaalien1v == 0)
		{
			datostrof.completaalien1v = 1;
			push.push(16);
			guardartro();
		}
		if(trofeoact == 3 && datostrof.alien1saladelrey == 0)
		{
			datostrof.alien1saladelrey = 1;
			push.push(19);
			guardartro();
		}
		if(trofeoact == 4 && datostrof.alien1salasecreta == 0)
		{
			datostrof.alien1salasecreta = 1;
			push.push(20);
			guardartro();
		}
		if(trofeoact == 5 && datostrof.alien1primeracinematica == 0)
		{
			datostrof.alien1primeracinematica = 1;
			push.push(1);
			guardartro();
		}
		if(trofeoact == 6 && datosserial.tengomejora == 1 && datostrof.alien1mejora5 == 0)
		{
			datostrof.alien1mejora5 = 1;
			push.push(6);
			guardartro();
		}
		if(trofeoact == 5 && datosserial.economia[0] >= 1 && datostrof.alien1consigue1gema == 0)
		{
			datostrof.alien1consigue1gema = 1;
			push.push(7);
			guardartro();
		}
		if(trofeoact == 5 && datosserial.economia[0] >= 15 && datostrof.alien1consigue15gemas == 0)
		{
			datostrof.alien1consigue15gemas = 1;
			push.push(9);
			guardartro();
		}
		if(trofeoact == 5 && datosserial.economia[4] >= 10 && datostrof.alien1consigue10monedas == 0)
		{
			datostrof.alien1consigue10monedas = 1;
			push.push(8);
			guardartro();
		}
		if(trofeoact == 5 && datosserial.economia[4] >= 50 && datosserial.fragmento >= 3 && datostrof.alien1consigue50monedas == 0)
		{
			datostrof.alien1consigue50monedas = 1;
			push.push(10);
			guardartro();
		}
		if(trofeoact == 7 && datosserial.economia[4] >= 50 && datosserial.fragmento < 3 && datostrof.alien1consigue50monedas == 0)
		{
			datostrof.alien1consigue50monedas = 1;
			push.push(10);
			guardartro();
		}
		if(trofeoact == 5 && datosserial.fragmento >= 3 && datostrof.alien1consiguelagrangema == 0)
		{
			datostrof.alien1consiguelagrangema = 1;
			push.push(11);
			guardartro();
		}
		if(trofeoact == 8 && datostrof.alien1usaelcochedelmundo == 0)
		{
			datostrof.alien1usaelcochedelmundo = 1;
			push.push(12);
			guardartro();
		}
		if(trofeoact == 6 && datostrof.alien1usalanaveenelespacio == 0)
		{
			datostrof.alien1usalanaveenelespacio = 1;
			push.push(13);
			guardartro();
		}
		if(trofeoact == 7 && otroasteroide == true && datostrof.alien1visitaotroasteroide == 0)
		{
			datostrof.alien1visitaotroasteroide = 1;
			push.push(14);
			guardartro();
		}
		if(trofeoact == 5 && datosserial.alien1muere == true && datostrof.alien1muere == 0)
		{
			datostrof.alien1muere = 1;
			push.push(17);
			guardartro();
		}*/
		
		if(tempshow > 1f && juego == 6 && datosserial.tengomejora == 1)
		{
			hidemenu_al1 hide = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
        	hide.anim.SetBool("show2",false);
		}
		tempshow += 1f * Time.deltaTime;
		



	}


}
