using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class datos1
{

	public bool[] eventos = new bool[999];
	public bool newgameplus1;
	public float puertagir;
	public Vector3 puertapos;
	public bool puertagiract;
	public bool puertaposact;
	public string salirnivelsala;
	public int nivelnavejug;

	public bool[] puertasdesbloqueadas = new bool[100];
	public int actual_checkpoint;

	public int[] npcF = new int[100];
	public int niveljugnave = 1;
	public int Logros;
	public int JefesVen;

	public float asc;
    public int plat;
	public int nivelarmapapa = 1;
	public int nivelarmarel = 1;
	public int nivelarmadef = 1;
	public int nivelarmapalo = 1;

	public int nivelarmanave1 = 1;
	public int nivelarmanave2 = 1;
	public int nivelarmanave3 = 1;
	public int nivelarmanave4 = 1;

	public bool tengoarmanave2;
	public bool tengoarmanave3;
	public bool tengoarmanave4;
	
	public bool[] licenciaarmapalo = new bool[5];
	public bool[] licenciaarmapapa = new bool[5];
	public bool[] licenciaarmarel = new bool[5];
	public bool[] licenciaarmadef = new bool[5];

	public bool[] notas = new bool[7];

	public int[] misiones = new int[200];

	public int[] LlaveT = new int[100];
	public bool[] llaveC = new bool[99];
	public bool[] pociones = new bool[9];
	public bool armadefdesbloqueada;
	public int MisionesCumplidas;


	


	public float nivelarmapapaexp;
	public float nivelarmarelexp;
	public float nivelarmadefexp;
	public float nivelarmapaloexp;

	public int niveljug = 1;
	public float nivelexp = 0;

	public float signivelexp = 20;

	public int ObjetosEnTienda = 99;
	public int CochesObtenidos;
	public int HabilidadesObtenidas;

	public float puntoskarting;

	public float danoarmapapa = 2;
	public float danoarmarel = 0;
	public float danoarmadef = 25;
	public float cadarmapapa = 2;
	public float velarmapapa = 5;
	public int pocionesmax;

	public int muertes;
	public int asesinatos;
	public bool salasecreta;

	public bool[] jefeV = new bool[99];

	public bool tengopalo;

	public bool tengolanzar;

	public bool tengodash;

	public bool begin;

	public string nivelu;


	public string carganivel;


	public int[] gemaT = new int[100];

	public int fragmentoN1;

	public int fragmentoN2;

	public int fragmentoN3;


	public int tengovel;

	public int tengocoche;

	public int tengosalto;

	public int armasel = 1;
	
	public int palosel = 1;
	public bool armapapa;

	public bool armarelen;

	public bool armadef = true;

	public bool alien1muere;

	public int tengonave;	
	public int ArmasNaveObtenidas;
	public int ArmasAlienObtenidas;


	public int cinematicaf;

	public int tengomejora;

    public int mejora1;
	public int mejora2;
	public int mejora3;
	public int mejora4;
	public int mejora5;

	public int[] monedaM= new int[150]; 
	public int[] monedaR= new int[150]; 

	public string misionS = "";
	public string misiondescS = "";

	



	public int[] economia = new int[7];


    // Start is called before the first frame update
    void Start()
    {
        //economia[0]  gemas;
		//economia[1]  llaves;
		//economia[2]  fragllave;
		//economia[3]  monedasrojas;
		//economia[4]  monedasmoradas;
		//economia[5]  monedasamarillas;
		//economia[6]  licencias;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
