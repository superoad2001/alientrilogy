using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class pushup : MonoBehaviour
{

    [SerializeField]
	public datosconfig datosconfig;
    [SerializeField]
	public datosextra datostrof;
	public string repath;
    public string repathtro;
    public Animator anim;
    public Text mensaje;
    public Text trofeo;
    public AudioSource ping;

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
    public void push(int trofeonum)
    {

        if(datosconfig.idioma == "es")
        {
            if(trofeonum == 1) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "comienza la aventura";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 2) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "rapido como el viento";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 3) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "licencia de conducir";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 4) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "salto estratosferico";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 5) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "preparado";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 6) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "con ganas de volver";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 7) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "rico una vez";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 8) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "ahorrador primerizo";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 9) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "coleccionista";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 10) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "adicto al dinero";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 11) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "consigue la gran gema";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 12) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "conductor novato";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 13) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "piloto novato";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 14) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "explorador espacial";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 15) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "me conformo pero y si...";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 16) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "me gustan los finales felices";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 17) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "el placer de morir una vez";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 18) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "rey goloso";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 19) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "el rey espera";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 20) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "secretos en el universo";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 21) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "explorador nato";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 22) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "no me e rendido";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 23) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "la muerte me odia";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 24) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "conserje";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 25) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "recopilador accidentado";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 26) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "escucha una historia";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 27) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "recopilador de informacion";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 28) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "discusiones de pareja";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 29) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "amigo de la muerte";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 30) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "explorador pensante";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 31) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "explorador curioso";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 32) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "botas especiales";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 33) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "permiso para matar";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 34) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "licecia descaducada";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 35) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "artilugio extraño";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 36) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "recuperando lo mio";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 37) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "corredor experto";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 38) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "saltador experto";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 39) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "conductor experimentado";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 40) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "manipulador";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 41) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "piloto experiementado";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 42) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "esta nave la e visto antes";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 43) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "morir no es lo que queria";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 44) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "vivieron felices y comieron perdices";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 45) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "padre ahorrador";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 46) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "derrochador";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 47) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "reyes caprichosos";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 48) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "morir es vivir";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 49) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "buena salud";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 50) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "creo que olvido algo";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 51) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "se puede ver al rey una segunda vez";
                anim.SetBool("trof",true);

            }


            
            if(trofeonum == 52) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "esto no tiene gracia";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 53) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "pequeño pero maton";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 54) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "prometo la revancha";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 55) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "por encima de un dios";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 56) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "mi venganza";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 57) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "el fin de una historia";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 58) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "aviador novato";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 59) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "experto aviador";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 60) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "me congelo";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 61) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "campos y montañas";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 62) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "guarida oculta";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 63) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "cerca de un volcan";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 64) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "hundido en el foso";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 65) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "minas de oro";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 66) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "luna morada";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 67) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "fortaleza enemiga";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 68) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "lugar varado";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 69) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "de vacaciones";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 70) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "ciudad salvaje";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 71) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "cerca del final";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 72) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "guarida abandonada";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 73) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "futuro hogar";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 74) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "el hijo regresa a casa";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 75) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "recurdos de otro";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 76) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "mundo final";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 77) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "aprendiendo";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 78) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "por curiosidad";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 79) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "dinamismo";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 80) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "mi padre tenia 15 queda poco";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 81) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "energia pa mi jetpack";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 82) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "necesito mas energia";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 83) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "energia nuclear";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 84) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "monpolio energetico";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 85) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "necesito la ubicacion";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 86) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "cotilla";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 87) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "se avecina un tormenta";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 88) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "futuro misterioso";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 89) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "promesa de venganza";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 90) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "herencia";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 91) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "hijo ahorrador";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 92) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "armado y preparad";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 93) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "primera defensa";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 94) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "primer paso";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 95) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "salud de hierro";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 96) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "estan todos muertos";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 97) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "caballero";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 98) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "guerrero";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 99) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "hasta que no quede ni una";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 100) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "la trotilla del rey";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 101) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "tal palo tal astilla";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 102) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "asesino en serie";
                anim.SetBool("trof",true);

            }
            if(trofeonum == 103) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "asesino en masa";
                anim.SetBool("trof",true);

            }
            ping.Play();
 
        }
        if(datosconfig.idioma == "en")
        {
            if(trofeonum == 1)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "the adventure begins";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 2)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "fast as the wind";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 3)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "driver's license";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 4)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "stratospheric jump";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 5)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "ready";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 6)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "looking forward to coming back";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 7)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "rich once";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 8)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "first-time saver";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 9)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "collector";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 10)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "addicted to money";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 11)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "get the big gem";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 12)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "novice driver";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 13)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "rookie pilot";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 14)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "space explorer";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 15)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I agree but what if...";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 16)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I like happy endings";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 17)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "the pleasure of dying once";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 18)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "sweet tooth king";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 19)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "the king is waiting";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 20)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "secrets in the universe";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 21)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "born explorer";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 22)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I have not given up";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 23)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "death hates me";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 24)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "concierge";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 25)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "crashed collector";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 26)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "listen to a story";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 27)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "information collector";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 28)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "couple discussions";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 29)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "friend of death";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 30)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "thinking explorer";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 31)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "curious explorer";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 32)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "special boots";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 33)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "permission to kill";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 34)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "licecia descaducada";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 35)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "strange gadget";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 36)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "recuperando lo mio";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 37)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "expert broker";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 38)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "expert jumper";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 39)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "experienced driver";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 40)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "manipulative";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 41)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "experienced pilot";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 42)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I've seen this ship before";
            anim.SetBool("trof", true);

            }
                        if(trofeonum == 43)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "dying is not what I wanted";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 44)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "they lived happily and ate partridges";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 45)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "thrifty dad";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 46)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "wasteful";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 47)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "capricious kings";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 48)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "to die is to live";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 49)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "good health";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 50)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I think I'm forgetting something";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 51)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "you can see the king a second time";
            anim.SetBool("trof", true);

            }



            if(trofeonum == 52)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "this is not funny";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 53)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "small but bully";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 54)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I promise the rematch";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 55)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "above a god";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 56)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "my revenge";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 57)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "the end of a story";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 58)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "rookie aviator";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 59)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "expert aviator";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 60)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I'm freezing";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 61)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "fields and mountains";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 62)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "hidden lair";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 63)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "near a volcano";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 64)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "sunk in the pit";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 65)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "gold mines";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 66)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "purple moon";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 67)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "enemy fortress";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 68)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "stranded place";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 69)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "on vacation";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 70)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "wild city";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 71)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "near the end";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 72)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "abandoned lair";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 73)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "future home";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 74)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "the son is coming home";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 75)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "recurred from another";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 76)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "final world";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 77)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "learning";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 78)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "out of curiosity";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 79)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "dynamism";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 80)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "my father was 15 there is little left";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 81)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "energia pa mi jetpack";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 82)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "I need more energy";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 83)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "nuclear energy";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 84)
            {
            mensaje.text = "trophy obtained trophy n"+trofeonum;
            trofeo.text = "monpolio energetico";
            anim.SetBool("trof", true);

            }
            if(trofeonum == 85) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "I need the location";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 86) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "gossip";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 87) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "a storm is coming";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 88) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "mysterious future";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 89) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "promise of revenge";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 90) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "inheritance";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 91) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "thrifty son";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 92) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "armed and ready";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 93) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "first defense";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 94) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "first step";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 95) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "iron health";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 96) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "they're all dead";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 97) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "gentleman";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 98) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "warrior";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 99) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "until there is not one left";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 100) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "the King's trotter";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 101) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "like father like son";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 102) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "serial killer";
                anim.SetBool("trof", true);

            }
            if(trofeonum == 103) 
            {
                mensaje.text = "trophy obtained trophy n"+trofeonum;
                trofeo.text = "mass murderer";
                anim.SetBool("trof", true);

            }
            ping.Play();
 
        }
        if(datosconfig.idioma == "cat")
        {
            if (trofeonum == 1)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "comença l'aventura";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 2)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "ràpid com el vent";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 3)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "llicència de conduir";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 4)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "salt estratosfèric";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 5)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "llest";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 6)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "amb ganes de tornar";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 7)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "ric una vegada";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 8)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "primer estalvi de temps";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 9)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "coleccionista";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 10)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "addicte als diners";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 11)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "aconsegueix la gran joia";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 12)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "controlador novell";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 13)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "pilot novell";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 14)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "explorador espacial";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 15)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = " estic d'acord, però i si...";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 16)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "m'agraden els finals feliços";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 17)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "el plaer de morir una vegada";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 18)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "rei dels dolços";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 19)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "el rei està esperant";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 20)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "secrets a l'univers";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 21)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "explorador nascut";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 22)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "no m'he rendit";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 23)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "la mort m'odia";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 24)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "consergeria";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 25)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "collector estavellat";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 26)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "escolta una història";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 27)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "recopilador d'informació";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 28)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "discussions de parella";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 29)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "amic de la mort";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 30)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "explorador de pensament";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 31)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "explorador curiós";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 32)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "botes especials";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 33)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "permís per matar";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 34)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "licècia descaducada";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 35)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "gadget estrany";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 36)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "recuperant el meu";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 37)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "corredor expert";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 38)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "pont expert";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 39)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "conductor experimentat";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 40)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "manipulació";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 41)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "pilot experimentat";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 42)
            {
            mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
            trofeo.text = "he vist aquest vaixell abans";
            anim.SetBool ("trof", true);

            }
            if (trofeonum == 43) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "morir no és el que jo volia";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 44) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "vivien feliços i menjaven perdius";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 45) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "pare estalviador";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 46) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "malbaratament";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 47) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "reis capritxosos";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 48) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "morir és viure";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 49) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "bona salut";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 50) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "crec que m'estic oblidant d'alguna cosa";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 51) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "pots veure el rei per segona vegada";
                anim.SetBool ("trof", true);

            }


            
            if (trofeonum == 52) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "això no és divertit";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 53) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "petit però assetjador";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 54) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "prometo la revenja";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 55) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "per sobre d'un déu";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 56) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "la meva venjança";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 57) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "el final d'una història";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 58) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "aviador novell";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 59) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "aviador expert";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 60) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "estic congelant";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 61) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "camps i muntanyes";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 62) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "cau ocult";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 63) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "a prop d'un volcà";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 64) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "enfonsat a la fossa";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 65) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "mines d'or";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 66) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "lluna porpra";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 67) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "fortalesa enemiga";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 68) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "lloc encallat";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 69) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "de vacances";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 70) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "ciutat salvatge";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 71) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "a prop del final";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 72) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "cau abandonat";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 73) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "llar futur";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 74) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "el fill torna a casa";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 75) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "recurrència d'un altre";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 76) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "món final";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 77) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "aprenentatge";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 78) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "per curiositat";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 79) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "dinamisme";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 80) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "el meu pare tenia 15 anys ja queda poc";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 81) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "energia pa meu motxilla";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 82) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "necessito més energia";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 83) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "energia nuclear";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 84) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "monpolio energètic";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 85) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "necessito la ubicació";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 86) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "xafarderies";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 87) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "s'acosta una tempesta";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 88) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "futur misteriós";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 89) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "promesa de venjança";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 90) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "herència";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 91) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "fill estalviador";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 92) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "armat i llest";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 93) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "primera defensa";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 94) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "primer pas";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 95) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "salut de ferro";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 96) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "tots són morts";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 97) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "cavaller";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 98) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "guerrer";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 99) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "fins que no en quedi cap";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 100) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "el trot Del Rei";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 101) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "com el pare com el fill";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 102) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "assassí en sèrie";
                anim.SetBool ("trof", true);

            }
            if (trofeonum == 103) 
            {
                mensaje.text = "trofeu obtingut trofeu n" +trofeonum;
                trofeo.text = "assassí en massa";
                anim.SetBool ("trof", true);

            }
            ping.Play();
 
        }
    }
    void Awake()
    {
        cargar();
        cargartro();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
