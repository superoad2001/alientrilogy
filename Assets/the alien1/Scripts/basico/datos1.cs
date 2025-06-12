using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class datos1
{

	public bool []eventos = new bool[999];
	public bool newgameplus1;

	public float asc;
    public int plat;
	public int nivelarmapapa = 1;
	public int nivelarmarel = 1;
	public int nivelarmadef = 1;
	public int nivelarmapalo = 1;
	
	public bool[] licenciaarmapalo = new bool[5];
	public bool[] licenciaarmapapa = new bool[5];
	public bool[] licenciaarmarel = new bool[5];
	public bool[] licenciaarmadef = new bool[5];

	public bool[] notas = new bool[7];

	public int[] misiones = new int[200];

	


	public float nivelarmapapaexp;
	public float nivelarmarelexp;
	public float nivelarmadefexp;
	public float nivelarmapaloexp;

	public int niveljug = 1;
	public float nivelexp = 0;

	public float signivelexp = 20;

	public float danoarmapapa = 2;
	public float danoarmarel = 0;
	public float danoarmadef = 25;
	public float cadarmapapa = 2;
	public float velarmapapa = 5;
	public int pocionesmax;

    public string idioma;
	public int muertes;
	public int asesinatos;
	public bool salasecreta;

	public bool jefe1;
	public bool jefe2;
	public bool jefe3;
	public bool jefe4;

	public bool tengopalo;

	public bool tengolanzar;

	public bool tengodash;

	public bool begin;

	public string nivelu;

	public float vidamax = 50;

	public string carganivel;


	public int gemaN1;

	public int gemaN2;

	public int gemaN3;

	public int gemaN4;

	public int gemaN5;

	public int gemaN6;

	public int gemaN7;

	public int gemaN8;

	public int gemaN9;

	public int gemaN10;

	public int gemaN11;

	public int gemaN12;
	public int gemaN13;
	public int gemaN14;
	public int gemaN15;

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

	public bool armadef;

	public bool alien1muere;

	public int tengonave;

	public int fragmento;

	

	public int []llave = new int[10]; 

	public int cinematicaf;

	public int tengomejora;

    public int mejora1;
	public int mejora2;
	public int mejora3;
	public int mejora4;
	public int mejora5;

	public int []moneda = new int[150]; 

	public int monedasrmax;
	public int monedasmax;
	public int monedasamax;



	public int []economia = new int[7];


    // Start is called before the first frame update
    void Start()
    {
        //economia[0]  gemas;
		//economia[1]  llaves;
		//economia[2]  fragllave;
		//economia[3]  monedasrojas;
		//economia[4]  monedasmoradas;
		//economia[5]  monedasamarillas;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
