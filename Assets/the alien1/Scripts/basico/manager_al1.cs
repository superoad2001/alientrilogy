using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;

// Token: 0x0200000B RID: 11
public class manager_al1 : MonoBehaviour
{

	public int trofeoact;
	public int nivel = 0;
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
	public string repathtro;
	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C





	public void GetFilePath()
    {
        string result;
 
    	result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alien1data.data");
 
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
	public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = File.ReadAllText(path);
            datosserial = JsonUtility.FromJson<datos1>(datosinventario);
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






	public void Awake() {
	{

		cargar();
		cargarconfig();
		cargartro();
	}
	}
	public void Start()
	{
		cargar();
		cargarconfig();
		cargartro();


		if(datosserial.mejora1 == 0 && datosserial.gemas >= 3 && datosserial.monedas >= 10)
		{
			datosserial.mejora1 = 1;
			guardar();
			SceneManager.LoadScene("mejora1_al1");
		}
		if(datosserial.mejora2 == 0 && datosserial.gemas >= 6 && datosserial.monedas >= 20)
		{
			datosserial.mejora2 = 1;
			guardar();
			SceneManager.LoadScene("mejora2_al1");
		}
		if(datosserial.mejora3 == 0 && datosserial.gemas >= 9 && datosserial.monedas >= 30)
		{
			datosserial.mejora3 = 1;
			guardar();
			SceneManager.LoadScene("mejora3_al1");
		}
		if(datosserial.mejora4 == 0 && datosserial.gemas >= 12 && datosserial.monedas >= 40)
		{
			datosserial.mejora4 = 1;
			guardar();
			SceneManager.LoadScene("mejora4_al1");
		}
		if(datosserial.mejora5 == 0 && datosserial.fragmento >= 3 && datosserial.monedas >= 50)
		{
			datosserial.mejora5 = 1;
			guardar();
			SceneManager.LoadScene("mejora5_al1");
		}

		jugador_al1 jugador = UnityEngine.Object.FindObjectOfType<jugador_al1>();
		

		if(datosconfig.idioma == "es")
		{
			if (this.piso == 1 && this.datosserial.gemas == 0 && dentrotienda == false)
			{
				audio.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 1 && this.datosserial.gemas <= 3 && datosserial.tengovel == 0 && dentrotienda == false)
			{
				audio1.Play();
			}
			
			if (this.piso == 1 && this.datosserial.gemas >= 3 && this.datosserial.gemas <= 6 && dentrotienda == false && datosserial.tengovel == 1 && datosserial.tengocoche == 0)
			{
				audio2.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 6 && this.datosserial.gemas <= 9 && datosserial.tengocoche == 1 && dentrotienda == false && datosserial.tengosalto == 0)
			{
				audio3.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 9 && this.datosserial.gemas <= 12 && datosserial.tengosalto == 1 && dentrotienda == false && datosserial.tengonave == 0)
			{
				audio4.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 12 && datosserial.tengonave == 1 && dentrotienda == false && datosserial.fragmento < 3 && datosserial.tengomejora == 0 && datosserial.tengollave4 == 0)
			{
				audio5.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas == 15 && datosserial.tengomejora == 0 && dentrotienda == false && datosserial.fragmento == 3 && datosserial.tengollave4 == 0 && datosserial.monedas == 50)
			{
				audio6.Play();
			}
		}
		if(datosconfig.idioma == "en")
		{
			if (this.piso == 1 && this.datosserial.gemas == 0 && dentrotienda == false)
			{
				audioen.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 1 && this.datosserial.gemas <= 3 && datosserial.tengovel == 0 && dentrotienda == false)
			{
				audio1en.Play();
			}
			
			if (this.piso == 1 && this.datosserial.gemas >= 3 && this.datosserial.gemas <= 6 && dentrotienda == false && datosserial.tengovel == 1 && datosserial.tengocoche == 0)
			{
				audio2en.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 6 && this.datosserial.gemas <= 9 && datosserial.tengocoche == 1 && dentrotienda == false && datosserial.tengosalto == 0)
			{
				audio3en.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 9 && this.datosserial.gemas <= 12 && datosserial.tengosalto == 1 && dentrotienda == false && datosserial.tengonave == 0)
			{
				audio4en.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 12 && datosserial.tengonave == 1 && dentrotienda == false && datosserial.fragmento < 3 && datosserial.tengomejora == 0 && datosserial.tengollave4 == 0)
			{
				audio5en.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas == 15 && datosserial.tengomejora == 0 && dentrotienda == false && datosserial.fragmento == 3 && datosserial.tengollave4 == 0 && datosserial.monedas == 50)
			{
				audio6en.Play();
			}
		}
		if(datosconfig.idioma == "cat")
		{
			if (this.piso == 1 && this.datosserial.gemas == 0 && dentrotienda == false)
			{
				audiocat.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 1 && this.datosserial.gemas <= 3 && datosserial.tengovel == 0 && dentrotienda == false)
			{
				audio1cat.Play();
			}
			
			if (this.piso == 1 && this.datosserial.gemas >= 3 && this.datosserial.gemas <= 6 && dentrotienda == false && datosserial.tengovel == 1 && datosserial.tengocoche == 0)
			{
				audio2cat.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 6 && this.datosserial.gemas <= 9 && datosserial.tengocoche == 1 && dentrotienda == false && datosserial.tengosalto == 0)
			{
				audio3cat.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 9 && this.datosserial.gemas <= 12 && datosserial.tengosalto == 1 && dentrotienda == false && datosserial.tengonave == 0)
			{
				audio4cat.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas >= 12 && datosserial.tengonave == 1 && dentrotienda == false && datosserial.fragmento < 3 && datosserial.tengomejora == 0 && datosserial.tengollave4 == 0)
			{
				audio5cat.Play();
			}
			if (this.piso == 1 && this.datosserial.gemas == 15 && datosserial.tengomejora == 0 && dentrotienda == false && datosserial.fragmento == 3 && datosserial.tengollave4 == 0 && datosserial.monedas == 50)
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

	// Token: 0x04000028 RID: 40
	public int espacio = 0;


	public Text mision;

	public Text mision2;

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
		jugador_al1 jugador = UnityEngine.Object.FindObjectOfType<jugador_al1>();
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		pushup push = UnityEngine.Object.FindObjectOfType<pushup>();
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
		if(trofeoact == 5 && datosserial.gemas >= 1 && datostrof.alien1consigue1gema == 0)
		{
			datostrof.alien1consigue1gema = 1;
			push.push(7);
		}
		if(trofeoact == 5 && datosserial.gemas >= 15 && datostrof.alien1consigue15gemas == 0)
		{
			datostrof.alien1consigue15gemas = 1;
			push.push(9);
		}
		if(trofeoact == 5 && datosserial.monedas >= 10 && datostrof.alien1consigue10monedas == 0)
		{
			datostrof.alien1consigue10monedas = 1;
			push.push(8);
		}
		if(trofeoact == 5 && datosserial.monedas >= 50 && datosserial.fragmento >= 3 && datostrof.alien1consigue50monedas == 0)
		{
			datostrof.alien1consigue50monedas = 1;
			push.push(10);
		}
		if(trofeoact == 7 && datosserial.monedas >= 50 && datosserial.fragmento < 3 && datostrof.alien1consigue50monedas == 0)
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
		

	if(datosconfig.idioma == "es")
	{
		if(tuto == -2)
		{
			boton2.text = "muevete con los botones de (wasd) o joystick";
			boton3.text = "pulsa (x) o click izquierdo para subir y pulsa (b) o click derecho  para bajar en el ascensor";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == -1)
		{
			boton2.text = "muevete con los botones de (wasd) o joystick pulsa (espacio) o (a) para avanzar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 1)
		{
			boton2.text = "wasd o joystick para moverse pulsa (espacio) o (a) para saltar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 2)
		{
			boton2.text = "pulsa y manten (espacio) o (a) para planear";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 3)
		{
			boton2.text = "pulsa (a) y (d) o joystick para desplazarte lateralmente apreta (click derecho) o (b) para cambiar de prespectiva y (espacio) o (a) para saltar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 4)
		{
			boton2.text = "toca las fichas aceleradoras para aumentar la logitud de los saltos";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 8)
		{
			boton2.text = "wasd o joystick para moverse, pulsa (espacio) o (a) para acelerar apreta (click derecho) o (b) para ir atras,agarra los aceleradores para ir mas rapido queda puesto 1 para ganar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 9)
		{
			boton2.text = "wasd o joystick para moverse, pulsa (espacio) o (a) para acelerar apreta (click derecho) o (b) para ir atras,agarra los aceleradores para ir mas rapido esquiva los obstaculos, queda puesto 1 para ganar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 10)
		{
			boton2.text = "apreta (espacio) encima de un saltador para llegar mas alto";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 11)
		{
			boton2.text = "wasd o joystick para moverse, pulsa (espacio) o (a) para acelerar apreta (click derecho) o (b) para ir atras,agarra los aceleradores para ir mas rapido esquiva los obstaculos y queda puesto 1 para ganar acelera en el saltador para subir a la roca";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 12)
		{
			boton2.text = "wasd o joystick para moverse ypulsa (espacio) o (a) para saltar toca la nave enemiga para ganary no te olvides de agarrar las monedas de velocidad para alanzar al la nave de vendedor";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(estados == 1)
		{
			boton1.text = "pulsa (click derecho) o (b) para subir a nave";
		}
		if(estados == 2)
		{
			boton1.text = "pulsa (click derecho) o (b) para subir al ascensor";
		}
		if(estados == 3)
		{
			boton1.text = "(click izquierdo) o (x) para bajar de planta";
			boton2.text = "tiempos";
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
			boton1.text = "borrar partida";
			boton2.text = "opciones";
			boton3.text = "comenzar partida";
			boton4.text = "salir";
		}
		if(menu == -1)
		{
			boton1.text = "presenta";
		}
		if(menu == -2)
		{
			boton1.text = "saltar";
		}
		if(menu == 2)
		{
			boton1.text = "estas seguro?";
			boton2.text = "borrar partida";
			boton3.text = "volver atras";
		}
		if(menu == 3)
		{
			boton1.text = "controles";
			boton2.text = "teclado y raton o mando";
			boton3.text = "tactil (solo android)";
			boton4.text = "idioma";
		}
		if(menu == 4)
		{
			boton1.text = "FIN";
			boton2.text = "volver al menu";

		}
		if(menu == 5)
		{
			boton1.text = "controles";
			boton2.text = "pc o consola";
			boton3.text = "dispositivo tactil";
			boton4.text = "en que dispositivo estas jugando?";
			boton5.text = "si estas jugando en un pc tableta o android selecciona dispositivo tactil si estas en los anteriores dispositivos con un mando o en pc o consola selecciona pc o consola";
			boton6.text = "una vez selecionado para cambiarlo entra a opciones";
		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == true && pauseact == false)
		{
			this.cuentamonedas.text = "monedas:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gemas:  " + this.datosserial.gemas+"/15";
			this.cuentafrag.text = "fragmentos de gran gema: " + this.datosserial.fragmento + "/3";

		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 2 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 3 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 4 && dentrotienda == false && pauseact == false)
		{
			this.cuentamonedas.text = "monedas:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gemas:  " + this.datosserial.gemas+"/15";
			this.cuentafrag.text = "fragmentos de gran gema: " + this.datosserial.fragmento + "/3";

			if (datosserial.gemas == 0)
			{
				this.mision.text = "MISION: cruza una puerta y consigue una gema completando un nivel";
			}
			if (datosserial.gemas == 1 && datosserial.monedas < 10)
			{
				this.mision.text = "MISION: haz los 2 niveles que quedan y baja abajo y consigue 10 monedas";
			}
			if (datosserial.gemas == 2 && datosserial.monedas < 10)
			{
				this.mision.text = "MISION: haz el nivel que te queda y baja abajo y consigue 10 monedas";
			}
			if (datosserial.gemas == 3 && datosserial.monedas < 10)
			{
				this.mision.text = "MISION: baja abajo y consigue 10 monedas";
			}
			if (datosserial.gemas == 1 && datosserial.monedas == 10)
			{
				this.mision.text = "MISION: haz los 2 niveles que quedan";
			}
			if (datosserial.gemas == 2 && datosserial.monedas == 10)
			{
				this.mision.text = "MISION: haz el nivel que te queda";
			}
			if (datosserial.gemas == 3 && datosserial.monedas == 10 && datosserial.tengovel == 0)
			{
				this.mision.text = "MISION: ve a la tienda del primer  piso y recoge el acelerador";
			}
			if (datosserial.gemas <= 6 && datosserial.monedas <= 20 && datosserial.tengovel == 1)
			{
				this.mision.text = "MISION: sube al segundo piso y consigue 6 gemas  baja al espacio y llega a las 20 monedas usando el acelerador";
			}
			if (datosserial.gemas == 6 && datosserial.monedas == 20 && datosserial.tengocoche == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge tu nuevo coche";
			}
			if (datosserial.gemas <= 9 && datosserial.monedas <= 30 && datosserial.tengocoche == 1)
			{
				this.mision.text = "MISION: sube al tercer piso y consigue 9 gemas                                                     baja al espacio y llega a las 30 monedas usando el coche para usarlo tocalo";
			}
			if (datosserial.gemas == 9 && datosserial.monedas == 30 && datosserial.tengosalto == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge el saltador";
			}
			if (datosserial.gemas <= 12 && datosserial.monedas <= 40 && datosserial.tengosalto == 1)
			{
				this.mision.text = "MISION: sube al cuarto piso y consigue 12 gemas                                                     baja al espacio y llega a las 40 monedas usando el saltador";
			}
			if (datosserial.gemas == 12 && datosserial.monedas == 40 && datosserial.tengonave == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge la nave espacial";
			}
			if (datosserial.gemas == 12 && datosserial.monedas == 40 && datosserial.tengonave == 1)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 13 gemas";
			}
			if (datosserial.gemas == 13 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2 ";
			}
			if (datosserial.gemas == 13 &&  datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 14 gemas";
			}
			if (datosserial.gemas == 14 && datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 3 ";
			}
			if (datosserial.gemas == 14 &&  datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 15 gemas";
			}
			if (datosserial.gemas == 15 && datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 4 ";
			}
			if (datosserial.gemas == 14 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0 && datosserial.tengollave2 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2 y 3 ";
			}
			if (datosserial.gemas == 15 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2,3 y 4 ";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 0 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al cuarto piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (datosserial.fragmento == 3 && datosserial.monedas < 50 && datosserial.tengollave4 == 0)
			{
				this.mision.text = "MISION fase 3: consigue 50 monedas por el espacio";
			}
			if (datosserial.fragmento == 3 && datosserial.monedas == 50 && datosserial.tengollave4 == 0)
			{
				this.mision.text = "MISION fase 3: ve a la tienda y recoje la llave del quinto piso";
			}

			if (datosserial.fragmento == 3 && datosserial.tengollave4 == 1 && datosserial.tengomejora == 0)
			{
				this.mision.text = "MISION fase 3: recoje el hiperpropulsor en el quinto piso";
			}
			if (datosserial.fragmento == 3 && datosserial.tengomejora == 1)
			{
				this.mision.text = "MISION fase final: ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera tus records";
			}
			

			
		}
		if (piso == 5 && datosserial.tengomejora == 1)
		{
			this.mision.text = "MISION fase final: ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera los records negtivos";
		}
		if (this.juego == 4 && this.piso == 10  && pauseact == false|| this.juego == 1 && this.piso == 10  && pauseact == false|| this.juego == 4 && this.piso == 1 && pauseact == false)
		{
			this.cuentagemas.text = "gemas:  " + this.datosserial.gemas+"/15";
			this.cuentamonedas.text = "monedas:  " + this.datosserial.monedas+"/50";
			
		}
				if (this.juego == 4 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 1 && this.piso == 10 && this.mundos == true && pauseact == false || this.juego == 4 && this.piso == 1 && this.mundos == true && pauseact == false)
		{
			this.cuentagemas.text = "gemas:  " + this.datosserial.gemas+"/15";
			this.cuentamonedas.text = "monedas:  " + this.datosserial.monedas+"/50";
		}
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			this.mision.text = "MISION fase final: vuela arriba a la plataforma de aterrizaje y sal de esta galaxia";
		}
		}
	if(datosconfig.idioma == "en")
	{
		if(tuto == -2)
		{
			boton2.text = "move with the buttons (wasd) or joystick";
			boton3.text = "press (x) or (left click) to go up and press (b) or (right click) to go down in the elevator";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == -1)
		{
			boton2.text = "muevete con los botones de (wasd) o joystick pulsa (espacio) o (a) para avanzar";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 1)
		{
			boton2.text = "wasd o joystick para moverse pulsa (espacio) o (a) para saltar";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 2)
		{
			boton2.text = "press and hold (space) or (a) to glide";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 3)
		{
			boton2.text = "press (a) and (d) or joystick to move laterally press (right click) or (b) to change perspective and (space) or (a) to jump";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 4)
		{
			boton2.text = "tap the speed up tiles to increase the length of the jumps";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 8)
		{
			boton2.text = "wasd or joystick to move, press (space) or (a) to accelerate press (right click) or (b) to go back, grab the accelerators to go faster stay on 1 to win";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 9)
		{
			boton2.text = "wasd or joystick to move, press (space) or (a) to accelerate press (right click) or (b) to go back, grab the accelerators to go faster avoid the obstacles, stay on 1 to win";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 10)
		{
			boton2.text = "squeeze space on top of a jumper to get higherapreta espacio encima de un saltador para llegar mas alto";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 11)
		{
			boton2.text = "wasd or joystick to move, press (space) or (a) to accelerate press (right click) or (b) to go back, grab the accelerators to go faster dodge the obstacles and stay on 1 to win speed up the jumper to climb the rock";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 12)
		{
			boton2.text = "wasd or joystick to move and press (space) or (a) to jump touch the enemy ship to win and don't forget to grab the speed coins to launch the vendor ship";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(estados == 1)
		{
			boton1.text = "press (right click) or (b) to go up to ship";
		}
		if(estados == 2)
		{
			boton1.text = "press (right click) or (b) to get on the elevator";
		}
		if(estados == 3)
		{
			boton1.text = "(left click) or (x) to go down the floor";
			boton2.text = "time";
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
			boton1.text = "delete data";
			boton2.text = "settings";
			boton3.text = "start adventure";
			boton4.text = "exit";
		}
		if(menu == -1)
		{
			boton1.text = "presents";
		}
		if(menu == -2)
		{
			boton1.text = "skip";
		}
		if(menu == 2)
		{
			boton1.text = "you're sure?";
			boton2.text = "delete data";
			boton3.text = "Go back";
		}
		if(menu == 3)
		{
			boton1.text = "controls";
			boton2.text = "keyboard and mouse or controller";
			boton3.text = "touch controls";
			boton4.text = "language";
		}
		if(menu == 4)
		{
			boton1.text = "the end";
			boton2.text = "back to menu";

		}
		if(menu == 5)
		{
			boton1.text = "controls";
			boton2.text = "pc or console";
			boton3.text = "touch device";
			boton4.text = "what device are you playing on?";
			boton5.text = "if you are playing on a tablet or android pc select touch device if you are on the above devices with a controller or on pc or console select pc or console";
			boton6.text = "once selected to change it go to settings";
		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == true && pauseact == false)
		{
			this.cuentamonedas.text = "coins:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gems:  " + this.datosserial.gemas+"/15";
			this.cuentafrag.text = "special gem fragments: " + this.datosserial.fragmento + "/3";

		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 2 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 3 && dentrotienda == false && pauseact == false|| this.juego == 0 && this.piso == 4 && dentrotienda == false && pauseact == false)
		{
			this.cuentamonedas.text = "coins:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gems:  " + this.datosserial.gemas+"/15";
			this.cuentafrag.text = "special gem fragments: " + this.datosserial.fragmento + "/3";

			if (datosserial.gemas == 0)
			{
				this.mision.text = "MISSION: Go through a door and get a gem by completing a level";
			}
			if (datosserial.gemas == 1 && datosserial.monedas < 10)
			{
				this.mision.text = "MISSION: do the remaining 2 levels and go downstairs and get 10 coins";
			}
			if (datosserial.gemas == 2 && datosserial.monedas < 10)
			{
				this.mision.text = "MISSION: do the level you have left and go down below and get 10 coins";
			}
			if (datosserial.gemas == 3 && datosserial.monedas < 10)
			{
				this.mision.text = "MISSION: go downstairs and get 10 coins";
			}
			if (datosserial.gemas == 1 && datosserial.monedas == 10)
			{
				this.mision.text = "MISSION: do the remaining 2 levels";
			}
			if (datosserial.gemas == 2 && datosserial.monedas == 10)
			{
				this.mision.text = "MISSION: do the level you have left";
			}
			if (datosserial.gemas == 3 && datosserial.monedas == 10 && datosserial.tengovel == 0)
			{
				this.mision.text = "MISSION: go to the shop on the first floor and pick up the accelerator";
			}
			if (datosserial.gemas <= 6 && datosserial.monedas <= 20 && datosserial.tengovel == 1)
			{
				this.mision.text = "MISSION: go up to the second floor and get 6 gems go down to space and reach 20 coins using the accelerator";
			}
			if (datosserial.gemas == 6 && datosserial.monedas == 20 && datosserial.tengocoche == 0)
			{
				this.mision.text = "MISSION: go to the store and pick up your new car";
			}
			if (datosserial.gemas <= 9 && datosserial.monedas <= 30 && datosserial.tengocoche == 1)
			{
				this.mision.text = "MISSION: go up to the third floor and get 9 gems go down to space and reach 30 coins using the car to use it touch it";
			}
			if (datosserial.gemas == 9 && datosserial.monedas == 30 && datosserial.tengosalto == 0)
			{
				this.mision.text = "MISSION: go to the store and pick up the jumper";
			}
			if (datosserial.gemas <= 12 && datosserial.monedas <= 40 && datosserial.tengosalto == 1)
			{
				this.mision.text = "MISSION: go up to the fourth floor and get 12 gems go down to space and reach 40 coins using the jumper";
			}
			if (datosserial.gemas == 12 && datosserial.monedas == 40 && datosserial.tengonave == 0)
			{
				this.mision.text = "MISSION: go to the store and pick up the spaceship";
			}
			if (datosserial.gemas == 12 && datosserial.monedas == 40 && datosserial.tengonave == 1)
			{
				this.mision.text = "MISSION phase 1: use the spaceship on your property by touching it in the free zone and travel to asteroids and reach all 13 gems";
			}
			if (datosserial.gemas == 13 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 2";
			}
			if (datosserial.gemas == 13 &&  datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: use the spaceship on your property by touching it in the free zone and travel to asteroids and reach 14 gems";
			}
			if (datosserial.gemas == 14 && datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 3";
			}
			if (datosserial.gemas == 14 &&  datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: use the spaceship on your property by touching it in the free zone and travel to asteroids and reach 15 gems";
			}
			if (datosserial.gemas == 15 && datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 4";
			}
			if (datosserial.gemas == 14 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0 && datosserial.tengollave2 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 2 and 3";
			}
			if (datosserial.gemas == 15 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floors 2, 3 and 4";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISSION phase 2: go to the second floor and get a large gem fragment in the secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2 and 3 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2, 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to the second floor and get a large gem fragment in the secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to the third floor and get a large gem fragment in the secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 0 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2, 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to the fourth floor and get a large gem fragment in the secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2 and 3 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to the second floor and get a large gem fragment in the secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2 and 4 and get a large gem fragment in their respective secret level";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to the third floor and get a large gem fragment in the secret level";
			}
			if (datosserial.fragmento == 3 && datosserial.monedas < 50 && datosserial.tengollave4 == 0)
			{
				this.mision.text = "MISSION phase 3: get 50 coins for space";
			}
			if (datosserial.fragmento == 3 && datosserial.monedas == 50 && datosserial.tengollave4 == 0)
			{
				this.mision.text = "MISSION phase 3: go to the store and collect the key to the fifth floor";
			}

			if (datosserial.fragmento == 3 && datosserial.tengollave4 == 1 && datosserial.tengomejora == 0)
			{
				this.mision.text = "MISSION phase 3: Pick up the hyperdrive on the fifth floor";
			}
			if (datosserial.fragmento == 3 && datosserial.tengomejora == 1)
			{
				this.mision.text = "MISSION final phase: go to space with the ship and get out of this galaxy you have unlocked the tower of time go up to the fifth floor and beat your records";
			}
			

			
		}
		if (piso == 5 && datosserial.tengomejora == 1)
		{
			this.mision.text = "MISSION final phase: go to space with the ship and get out of this galaxy you have unlocked the tower of time go up to the fifth floor and beat your recordss";
		}
		if (this.juego == 4 && this.piso == 10  && pauseact == false|| this.juego == 1 && this.piso == 10 && pauseact == false || this.juego == 4 && this.piso == 1 && pauseact == false)
		{
			this.cuentagemas.text = "gems:  " + this.datosserial.gemas+"/15";
			this.cuentamonedas.text = "coins:  " + this.datosserial.monedas+"/50";
		}
				if (this.juego == 4 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 1 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 4 && this.piso == 1 && this.mundos == true && pauseact == false)
		{
			this.cuentagemas.text = "gems:  " + this.datosserial.gemas+"/15";
			this.cuentamonedas.text = "coins:  " + this.datosserial.monedas+"/50";
		}
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			this.mision.text = "MISSION final phase: fly up to the landing platform and get out of this galaxy";
		}
		}
	if(datosconfig.idioma == "cat")
	{
		if(tuto == -2)
		{
			boton2.text = "Et Pots moure amb (wasd) o joystick";
			boton3.text = "pren (x) o click esquerre per pujar i pren (b) o click dret  per baixar el ascensor";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == -1)
		{
			boton2.text = "Et Pots moure amb (wasd) o joystick pren (espai) o (a) per avancar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 1)
		{
			boton2.text = "wasd o joystick per moure's pren (espai) o (a) per saltar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 2)
		{
			boton2.text = "pren i manteneix (espai) o (a) per planejar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 3)
		{
			boton2.text = "pren (a) y (d) o joystick per desplacarte lateralment pren (click dret) o (b) per canviar de prespectiva y (espaio) o (a) per saltar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 4)
		{
			boton2.text = "toca les fitxes aceleradores per aumentar la logitud de dels saltos";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 8)
		{
			boton2.text = "wasd o joystick per moure's, pren (espai) o (a) per acelerar pren (click dret) o (b) per anar atras,agafa els aceleradors per anar mes rapid arriba lloc 1 per guanyar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 9)
		{
			boton2.text = "wasd o joystick per moure's, pren (espai) o (a) per acelerar pren (click dret) o (b) per anar atras,agafa els aceleradors per anar mes rapid esquiva els obstacles, queda lloc 1 per guanyar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 10)
		{
			boton2.text = "pren (espai) a sobre d un saltador per arribar molt alt";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 11)
		{
			boton2.text = "wasd o joystick per moures, pren (espai) o (a) per acelerar pren (click dret) o (b) per anar atras,agafa els aceleradors per anar mes rapid esquiva els obstacles y arriba al lloc 1 per guanyar acelera al saltador per putjtar a la pedra";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 12)
		{
			boton2.text = "wasd o joystick para moverse ypulsa (espacio) o (a) para saltar toca la nave enemiga para ganary no te olvides de agarrar las monedas de velocidad para alanzar al la nave de vendedor";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(estados == 1)
		{
			boton1.text = "pren (click dret) o (b) per putjar a la nau";
		}
		if(estados == 2)
		{
			boton1.text = "pren (click dret) o (b) per putjar al ascensor";
		}
		if(estados == 3)
		{
			boton1.text = "(click esquerre) o (x) per baixar de planta";
			boton2.text = "tiempos";
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
			boton2.text = "opcions";
			boton3.text = "comencar joc";
			boton4.text = "sortir";
		}
		if(menu == -1)
		{
			boton1.text = "presenta";
		}
		if(menu == -2)
		{
			boton1.text = "saltar";
		}
		if(menu == 2)
		{
			boton1.text = "estas segur?";
			boton2.text = "esborra data";
			boton3.text = "tornar andarrere";
		}
		if(menu == 3)
		{
			boton1.text = "controls";
			boton2.text = "teclat y ratoli o control";
			boton3.text = "tactil (sol android)";
			boton4.text = "idioma";
		}
		if(menu == 4)
		{
			boton1.text = "FI";
			boton2.text = "tornar al menu";

		}
		if(menu == 5)
		{
			boton1.text = "controls";
			boton2.text = "pc o consola";
			boton3.text = "dispositiu tactil";
			boton4.text = "en quin dispositiu estas jugan?";
			boton5.text = "si estas jugan a un pc tableta o android selecciona dispositiu tactil si estas als anteriors dispositius amb un control o a un pc o consola selecciona pc o consola";
			boton6.text = "una vegada selecionat per cambiaro entra a opcions";
		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == true && pauseact == false)
		{
			this.cuentamonedas.text = "diners:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gemmes:  " + this.datosserial.gemas+"/15";
			this.cuentafrag.text = "fragments de gran gemme: " + this.datosserial.fragmento + "/3";

		}
		if (this.juego == 0 && this.piso == 1 && dentrotienda == false  && pauseact == false || this.juego == 0 && this.piso == 2 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 3 && dentrotienda == false  && pauseact == false|| this.juego == 0 && this.piso == 4 && dentrotienda == false && pauseact == false)
		{
			this.cuentamonedas.text = "diners:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gemmes:  " + this.datosserial.gemas+"/15";
			this.cuentafrag.text = "fragments de gran gemme: " + this.datosserial.fragmento + "/3";

			if (datosserial.gemas == 0)
			{
				this.mision.text = "MISIO: creua una porta i consegueix una gema completan un nivell";
			}
			if (datosserial.gemas == 1 && datosserial.monedas < 10)
			{
				this.mision.text = "MISIO: fes els 2 niveles que queden i baixa abaix i agafa 10 monedes";
			}
			if (datosserial.gemas == 2 && datosserial.monedas < 10)
			{
				this.mision.text = "MISIO: fes el nivell que et queda i baixa abaix i agafa 10 monedes";
			}
			if (datosserial.gemas == 3 && datosserial.monedas < 10)
			{
				this.mision.text = "MISIO: baixa abaix i agafa 10 monedes";
			}
			if (datosserial.gemas == 1 && datosserial.monedas == 10)
			{
				this.mision.text = "MISIO: fes els 2 niveles que queden";
			}
			if (datosserial.gemas == 2 && datosserial.monedas == 10)
			{
				this.mision.text = "MISIO: fes el nivell que et queda";
			}
			if (datosserial.gemas == 3 && datosserial.monedas == 10 && datosserial.tengovel == 0)
			{
				this.mision.text = "MISIO: ves a la tenda del primer  pis i agafa el acelerador";
			}
			if (datosserial.gemas <= 6 && datosserial.monedas <= 20 && datosserial.tengovel == 1)
			{
				this.mision.text = "MISIO: puja al segon pis i agafa 6 gemmes  baixa al espai y arriba a les 20 monedes fent servir el acelerador";
			}
			if (datosserial.gemas == 6 && datosserial.monedas == 20 && datosserial.tengocoche == 0)
			{
				this.mision.text = "MISIO: ves a la tenda i agafa el teu nuo cotxe";
			}
			if (datosserial.gemas <= 9 && datosserial.monedas <= 30 && datosserial.tengocoche == 1)
			{
				this.mision.text = "MISIO: puja al tercer pis i agafa 9 gemmes                                                     baixa al espai y arriba a les 30 monedes fent servir el cotxe per ferlo servir tocal";
			}
			if (datosserial.gemas == 9 && datosserial.monedas == 30 && datosserial.tengosalto == 0)
			{
				this.mision.text = "MISIO: ves a la tenda y agafa el saltador";
			}
			if (datosserial.gemas <= 12 && datosserial.monedas <= 40 && datosserial.tengosalto == 1)
			{
				this.mision.text = "MISIO: puja al quart pis i agafa 12 gemmes                                                    baixa al espai i arriba a les 40 monedes fent servir el saltador";
			}
			if (datosserial.gemas == 12 && datosserial.monedas == 40 && datosserial.tengonave == 0)
			{
				this.mision.text = "MISIO: ves a la tenda y agafa la nau espacial";
			}
			if (datosserial.gemas == 12 && datosserial.monedas == 40 && datosserial.tengonave == 1)
			{
				this.mision.text = "MISIO fase 1: fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 13 gemmes";
			}
			if (datosserial.gemas == 13 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda y recull la clau secreta de les mines del pis 2 ";
			}
			if (datosserial.gemas == 13 &&  datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 14 gemmes";
			}
			if (datosserial.gemas == 14 && datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda i recull la clau secreta de les mines del pis 3";
			}
			if (datosserial.gemas == 14 &&  datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 15 gemmes";
			}
			if (datosserial.gemas == 15 && datosserial.tengonave == 1 && datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda i recull la clau secreta de les mines del pis 4 ";
			}
			if (datosserial.gemas == 14 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0 && datosserial.tengollave2 == 0)
			{
				this.mision.text = "MISIO fase 1:ves a la tenda i recull la clau secreta de les mines del pis 2 i 4 ";
			}
			if (datosserial.gemas == 15 && datosserial.tengonave == 1 && datosserial.tengollave1 == 0 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda i recull la clau secreta de les mines del pis 2,3 i 4";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 0 && datosserial.tengollave3 == 0 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISIO fase 2: s al segon pis i agafa un fragment de gran gemmme en el nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2 i 3 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2, 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al segon pis y agafa el fragment de gran gemme en el nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 0 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al tercer pis y agafa el fragment de gran gemme en el nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 0 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2, 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al quart pis i agafa un fragment de gran gemmme en el nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2 i 3 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al seguon pis i agafa un fragment de gran gemme en el nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 1 && datosserial.fragmentoN1 == 0 && datosserial.fragmentoN2 == 1 && datosserial.fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2 y 4 i agafa un fragment de gran gemme en el seu respectiu nivell secret";
			}
			if (datosserial.tengollave1 == 1 && datosserial.tengollave2 == 1 && datosserial.tengollave3 == 1 && datosserial.fragmento == 2 && datosserial.fragmentoN1 == 1 && datosserial.fragmentoN2 == 0 && datosserial.fragmentoN3 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al tercer pis y agafa un fragment de gran gemme en el nivell secret";
			}
			if (datosserial.fragmento == 3 && datosserial.monedas < 50 && datosserial.tengollave4 == 0)
			{
				this.mision.text = "MISIO fase 3: agafa 50 monedes en el espai amb la nau";
			}
			if (datosserial.fragmento == 3 && datosserial.monedas == 50 && datosserial.tengollave4 == 0)
			{
				this.mision.text = "MISIO fase 3: ves a la tenda i agafa la calu del cinque pis";
			}

			if (datosserial.fragmento == 3 && datosserial.tengollave4 == 1 && datosserial.tengomejora == 0)
			{
				this.mision.text = "MISIO fase 3: recull el hiperpropulsor en el cinque pis";
			}
			if (datosserial.fragmento == 3 && datosserial.tengomejora == 1)
			{
				this.mision.text = "MISIO fase final: ves al espaci amb la nau i vesten d aquesta galaxia                 has desbloquejat la torre del temps puja a d alt del cinque pis y supera els records negatius";
			}
			

			
		}
		if (piso == 5 && datosserial.tengomejora == 1)
		{
			this.mision.text = "MISIO fase final: ves al espai amb la nau y vesten de aquesta galaxia                 has desbloquejat la torre del temps puja a d alt del cinque pis y supera els records negatius";
		}
		if (this.juego == 4 && this.piso == 10  && pauseact == false|| this.juego == 1 && this.piso == 10  && pauseact == false|| this.juego == 4 && this.piso == 1 && pauseact == false)
		{
			this.cuentamonedas.text = "diners:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gemmes:  " + this.datosserial.gemas+"/15";
		}
		if (this.juego == 4 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 1 && this.piso == 10 && this.mundos == true  && pauseact == false|| this.juego == 4 && this.piso == 1 && this.mundos == true  && pauseact == false)
		{
			this.cuentamonedas.text = "diners:  " + this.datosserial.monedas+"/50";
			this.cuentagemas.text = "gemmes:  " + this.datosserial.gemas+"/15";
		}
		if (juego == 6 && datosserial.tengomejora == 1)
		{
			this.mision.text = "MISION fase final: vola a d alt d la plataforma de aterricaje y surt d aquesta galaxia";
		}
		}



	}


}
