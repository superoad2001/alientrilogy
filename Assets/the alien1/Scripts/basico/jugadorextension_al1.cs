using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;
using System.Linq;

// Token: 0x0200000A RID: 10
public class jugadorextension_al1 : MonoBehaviour
{
	public manager_al1 manager;

	private void Start()
	{

		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));


		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}

		if(GameObject.Find("muerteaudiojug") == true)
		{muertesjug = GameObject.Find("muerteaudiojug").GetComponent<AudioSource>();}

		if(GameObject.Find("disp") == true)
		{disp = GameObject.Find("disp").GetComponent<AudioSource>();}

		if(GameObject.Find("iconodedisparo") == true)
		{iconodisp = GameObject.Find("iconodedisparo").GetComponent<Image>();}

		if(GameObject.Find("armapaloimg") == true)
		{paloimg = GameObject.Find("armapaloimg").GetComponent<Image>();}

		if(GameObject.Find("backarmapaloimg") == true)
		{backpaloimg = GameObject.Find("backarmapaloimg").GetComponent<Image>();}

		if(GameObject.Find("armapapaimg") == true)
		{pistolaimg = GameObject.Find("armapapaimg").GetComponent<Image>();}

		if(GameObject.Find("armarelimg") == true)
		{relentizarimg= GameObject.Find("armarelimg").GetComponent<Image>();}

		if(GameObject.Find("armadefimg") == true)
		{armadefimg = GameObject.Find("armadefimg").GetComponent<Image>();}
	}
	private int cambioruedaact;

	private static GameObject FindGameObjectsAll(string name) { return Resources.FindObjectsOfTypeAll<GameObject>().First(x => x.name == name); }
	private GameObject []target = new GameObject[3];
	public GameObject camarainterna;
	public Text levelexpt;
	public Text levelarmat;
	public Text balaarmat;
	public AudioSource tragar;
	public AudioSource pistolabueno;
	public AudioSource pistolamalo;
	public gravitybody_al1 grav;
	public GameObject ex;

	public GameObject tarboss;
	public GameObject objetivotarget;

	public GameObject slash;
	public AudioSource inbuir;
	public AudioSource dashson;
	public AudioSource espiraloaud;
	public AudioSource escudoaud;
	public AudioSource dashairson;
	public AudioSource golpeson;
	public AudioSource lanzarson;
	public GameObject balaprefabpapa;
	public GameObject balaprefabrel;
	public GameObject balaprefabdef;
	public Image paloimg;
	public Image pistolaimg;
	public Image relentizarimg;
	public Image armadefimg;

	public Image backpistolaimg;
	public Image backrelentizarimg;
	public Image backarmadefimg;

	public Sprite pocionvidaimg;

	public Sprite pocionhabrec;
	public Sprite pocionrecimg;
	public Sprite berserkimg;
	public Text numpoct;
	public Text numpoc1t;
	public Text numpoc2t;
	public Text numpoc3t;
	public Text numpoc4t;

	public Sprite nopimg;

	public Sprite armapaparueda;
	public Sprite armarelrueda;
	public Sprite armadefrueda;
	public GameObject palo;
	public npc_al1 npcbase;
	public GameObject respawn;
	public GameObject balaprefab;
	public Text textnpc;
	public AudioSource audio1;
	public AudioSource disp;
	public AudioSource disprel;
	public AudioSource dispdef;
	public GameObject explosion;
	public AudioSource escudohabaud;
	public GameObject camara;
	public GameObject tut10;
	public GameObject mod;
	public GameObject pistolap;
	public GameObject tactil;
	public Animator anim;
	public AudioSource pasosnave;
	public AudioSource pasos1;
	public AudioSource pasos2;
	public AudioSource muertes;
	public AudioSource muertesjug;
	public Animator menushow;
	public DialogueManager menuoff;

	public enemigo1boss_al1 eneboss1;
	public GameObject juego;
    public GameObject pausa1;
	public Image vidab;
	public Image vidaeneimg;
	public Image iconodisp;
	public Image backpaloimg;
	public Sprite arma1;

	public Sprite arma1_1;
	public Sprite arma1_2;
	public Sprite arma1_3;
	public Sprite arma1_4;
	public Sprite arma1_5;

	public Sprite arma2;
	public Sprite arma3;
	public Sprite arma4;


	// Token: 0x04000019 RID: 25
	public GameObject giro;

	// Token: 0x0400001E RID: 30
	public Text ascensortut;

	// Token: 0x0400001F RID: 31
	public Text ascensortut2;


	public GameObject []prebaladefl;
	public GameObject []prebalarell;
	public GameObject []prebalapapal;
	
}
