using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

[Serializable]
public class datos2
{
	//[System.NonSerialized] usar para reiniciar datos


	//economia[0]  gemas;
	//economia[1]  llaves;
	//economia[2]  fragllave;
	//economia[3]  monedasrojas;
	//economia[4]  monedasmoradas;
	//economia[5]  monedasamarillas;
	//economia[6]  licencias;
	public bool newgameplus1;


	public float[] armajugtiempo = new float[12];
	public float[] armajugcadencia = new float[12];
	public float[] armajugdano = new float[12];
	public float[] armajugvel = new float[12];
	public float[] armajugmunicion = new float[12];
	public float[] armajugsignv = new float[12];

	public bool datos_llenos;
	public bool begin;
	public int palosel;
	public string nivelu;
	public int ruletainterior_armas;
	public int ruletainterior_artilugios;
	public int ruletatipo_armas;
	public int armasel;
	public int HabilidadesObtenidas;
	public List<string> nameCH = new List<string>();

	public int[] nivelarmasjug = new int [12] {1,1,1,1,1,1,1,1,1,1,1,1};
	public int[] nivelarmasexpjug = new int [12]{0,0,0,0,0,0,0,0,0,0,0,0};
	public int[] nivelarmasnave = new int [8];
	public bool[] artilugiosjug = new bool [8]{false,false,false,false,false,false,false,false};
	public bool[] armasjug = new bool [12]{false,false,false,false,false,false,false,false,false,false,false,false};
	public bool[] armasnave = new bool [8]{false,false,false,false,false,false,false,false};
	public bool[] eventos = new bool[999];

	public float[] armasmun_max = new float[12]{25,50,10,2,2,8,150,12,6,5,4,1};
	public float[] armasmun = new float[12]{25,50,10,2,2,8,150,12,6,5,4,1};

	public float[] artilugiosmun = new float[8]{0,0,0,0,5,5,0,0};
	public float[] artilugiosmun_max = new float[8]{0,0,0,0,5,5,0,0};

	public int[] misiones = new int[200];
    public int horas;
	public int minutos;
	public float segundos;

	public int[] npcF = new int[100];
	public int niveljugnave = 1;

	public int actual_checkpoint;
	public int niveljug = 1;
	public float nivelexp = 0;
	public float signivelexp = 3;

	public int[] licenciaarmas = new int[12]{0,0,0,0,0,0,0,0,0,0,0,0};

	public bool[] notas = new bool[20];
	public bool[] gemaT = new bool[100];
	public bool[] LlaveT = new bool[100];
	



	public int pocionesmax;

	public int[] monedaM= new int[150]; 
	public int[] monedaR= new int[150]; 

	public string misionS = "";
	public string misiondescS = "";
	

	public int ArmasNaveObtenidas;
	public int ArmasAlienObtenidas;


	public string salirnivelsala;
	public Vector3 puertapos;
	public bool puertaposact;
	public int puertagir;
	public bool puertagiract;
	public bool[] puertasdesbloqueadas = new bool [20];



	public int[] economia = new int[7];

	public bool demoFIN;



    public int plat = 0;
	public int inicio;
	public int Logros;
	public int asesinatos;
	public int muertes;
	public bool sala_secreta;
	public bool final_alt;

	public int tuto = 0;
	public int JefesVen;
	public int estado = 0;
	public int menu = 0;

	public bool pause = false;
	public int block1;

	public int block2;

	public int block3;

	public int block4;

	public int block5;
	public int checkpoints;

	public bool alien2muere;

	public int llaveN1;

	public int llaveN2;

	public int llaveN3;

	public int llaveN4;

	public int llaveN5;

	public int llaveN6;

	public int llaveN7;

	public int llaveN8;

	public int llaveN9;

	public int llaveN10;

	public int llaveN11;

	public int llaveN12;

	public int llaveN13;

	public int llaveN14;

	public int llaveN15;

	public int llaveN16;

	public int llaveN17;

	public int llaveN18;

	public int llaveN19;

	public int llaveN20;

	public int pagina1;

	public int pagina2;

	public int pagina3;

	public int pagina4;

	public int pagina5;

	public int pagina6;

	public int pagina7;

	public int pagina8;

	public int pagina9;

	public int pagina10;

	public int pagina11;

	public int pagina12;

	public int pagina13;

	public int pagina14;

	public int pagina15;

	public int pagina16;

	public int pagina17;

	public int pagina18;

	public int pagina19;

	public int pagina20;

	public int trozosnv1;

	public int trozo1nv1;

	public int trozo2nv1;

	public int trozo3nv1;

	public int trozosnv2;

	public int trozo1nv2;

	public int trozo2nv2;

	public int trozo3nv2;

	public int trozosnv3;

	public int trozo1nv3;

	public int trozo2nv3;

	public int trozo3nv3;

	public int trozosnv4;

	public int trozo1nv4;

	public int trozo2nv4;

	public int trozo3nv4;

	public int trozosnv5;

	public int trozo1nv5;

	public int trozo2nv5;

	public int trozo3nv5;

	public int trozosnv6;

	public int trozo1nv6;

	public int trozo2nv6;

	public int trozo3nv6;

	public int trozosnv7;

	public int trozo1nv7;

	public int trozo2nv7;

	public int trozo3nv7;

	public int trozosnv8;

	public int trozo1nv8;

	public int trozo2nv8;

	public int trozo3nv8;

	public int trozosnv9;

	public int trozo1nv9;

	public int trozo2nv9;

	public int trozo3nv9;

	public int trozosnv10;

	public int trozo1nv10;

	public int trozo2nv10;

	public int trozo3nv10;

	public int trozosnv11;

	public int trozo1nv11;

	public int trozo2nv11;

	public int trozo3nv11;

	public int trozosnv12;

	public int trozo1nv12;

	public int trozo2nv12;

	public int trozo3nv12;

	public int trozosnv13;

	public int trozo1nv13;

	public int trozo2nv13;

	public int trozo3nv13;

	public int trozosnv14;

	public int trozo1nv14;

	public int trozo2nv14;

	public int trozo3nv14;

	public int trozosnv15;

	public int trozo1nv15;

	public int trozo2nv15;

	public int trozo3nv15;

	public int trozosnv16;

	public int trozo1nv16;

	public int trozo2nv16;

	public int trozo3nv16;

	public int trozosnv17;

	public int trozo1nv17;

	public int trozo2nv17;

	public int trozo3nv17;

	public int trozosnv18;

	public int trozo1nv18;

	public int trozo2nv18;

	public int trozo3nv18;

	public int trozosnv19;

	public int trozo1nv19;

	public int trozo2nv19;

	public int trozo3nv19;

	public int trozosnv20;

	public int trozo1nv20;

	public int trozo2nv20;

	public int trozo3nv20;

	public int finalmalo;

	public int finalbueno;

	public bool mundos;

	public bool unavez;

	public float tiement;

	public int respawntipo;

	public bool tutorial;

	public int personaje;

	public int espacio;

	public int fragmentoN1;

	public int fragmentoN2;

	public int fragmentoN3;

	public int tienda1c;
	public int tienda2c;
	public int tienda3c;
	public int tienda4c;
	public int tienda5c;
	public int tienda6c;
	public int tienda7c;


	public int pociones;

	public int pocionvel;

	public int pocioninvul;

	public int pocionsalt;

	public int vidamaxima = 2;

	public int tengosaltod;

	public int tengodisparo;

	public int tengomental;

	public int mejoravida1;

	public int mejoravida2;

	public int mejoravida3;

	public int mejoravida4;

	public int disparos;

	public int llaves;

	public int nivelc;

	public int nivel1c;

	public int nivel2c;

	public int nivel3c;

	public int nivel4c;

	public int nivel5c;

	public int nivel6c;

	public int nivel7c;

	public int nivel8c;

	public int nivel9c;

	public int nivel10c;

	public int nivel11c;

	public int nivel12c;

	public int nivel13c;

	public int nivel14c;

	public int nivel15c;

	public int nivel16c;

	public int nivel17c;

	public int nivel18c;

	public int nivel19c;

	public int nivel20c;

	public int nivel1ch1;

	public int nivel1ch2;

	public int nivel2ch1;

	public int nivel2ch2;

	public int nivel3ch1;

	public int nivel3ch2;

	public int nivel4ch1;

	public int nivel4ch2;

	public int nivel5ch1;

	public int nivel5ch2;

	public int nivel6ch1;

	public int nivel6ch2;

	public int nivel7ch1;

	public int nivel7ch2;

	public int nivel8ch1;

	public int nivel8ch2;

	public int nivel9ch1;

	public int nivel9ch2;

	public int nivel10ch1;

	public int nivel10ch2;

	public int nivel11ch1;

	public int nivel11ch2;

	public int nivel12ch1;

	public int nivel12ch2;

	public int nivel13ch1;

	public int nivel13ch2;

	public int nivel14ch1;

	public int nivel14ch2;

	public int nivel15ch1;

	public int nivel15ch2;

	public int nivel16ch1;

	public int nivel16ch2;

	public int nivel17ch1;

	public int nivel17ch2;

	public int nivel18ch1;

	public int nivel18ch2;

	public int nivel19ch1;

	public int nivel19ch2;

	public int nivel20ch1;

	public int nivel20ch2;

	public int monedas;

	public int tengocoche;

	public int tengonave;

	public int fragmento;

	public int tengollave1;

	public int tengollave2;

	public int tengollave3;

	public int tengollave4;

	public int cinematicaf;

	public int tengomejora;
	public int univel;

	public int mejora1c;
	public int mejora2c;
	public int mejora3c;
	public int mejora4c;
	public int mejora5c;
	public int tiendasc;
	public string idioma = "no";

    public float recordnv1 = 888;
    public float recordnv2 = 888;
    public float recordnv3 = 888;
    public float recordnv4 = 888;
    public float recordnv5 = 888;
    public float recordnv6 = 888;
    public float recordnv7 = 888;
    public float recordnv8 = 888;
    public float recordnv9 = 888;
    public float recordnv10 = 888;
    public float recordnv11 = 888;
    public float recordnv12 = 888;
    public float recordnv13 = 888;
    public float recordnv14 = 888;
    public float recordnv15 = 888;
    public float recordnv16 = 888;
    public float recordnv17 = 888;
    public float recordnv18 = 888;
    public float recordnv19 = 888;
    public float recordnv20 = 888;

	public int niveltc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
