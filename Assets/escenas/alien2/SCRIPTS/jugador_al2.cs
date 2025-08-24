using UnityEngine;
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

public abstract class jugador_al2 : MonoBehaviour
{

	[Header("Posición")]
	public int movact;
    public bool controlact = true;
	public GameObject objplaneta;
	public float disjugsave;
	public Vector3 planetCenter;
	public float jugpos;
    public List<GameObject> enemigosEnContacto = new List<GameObject>();
	[HideInInspector]public float misilbalas;
	[HideInInspector]public float minabalas;
	[HideInInspector]public float escopetabalas;
	[HideInInspector]public bool dispF;
	public float tempdano;
	public int blanco;
	public AudioSource audio2;
	public int objeto;
	public bool saltador;
	public float tempboton;
	public GameObject tiendaG;
	public AudioSource musicajuego;
	public AudioSource musicaC;
	public AudioSource musicanoC;
	public AudioSource combini;
	[HideInInspector]public bool static_ev = false;
	[HideInInspector]public int toquespalo;
	public tutorialbase_al1 eventotut;
	[HideInInspector]public float velrecextra = 1;
	public Vector3 enmovdirectaux;
	[HideInInspector]public float temppause;
	[HideInInspector]public float tempempujon;
	public bool tarbossact;
	[HideInInspector]public int combo;
	public float vida = 9;
	[HideInInspector]public bool dialogueact;
	[HideInInspector]public float speed = 3;
	[HideInInspector]public bool suelo;
	[HideInInspector]public bool velact;
	[HideInInspector]public float tiempodisp;
    [HideInInspector]public float nivelfuerza;
    [HideInInspector]public float nivelvida;
	[HideInInspector]public GameObject objetivotarget2;
    [HideInInspector]public float []nivelfuerza_a = new float[100];
    [HideInInspector]public float []nivelvida_a = new float[100];
	public float []armapalosignv;
	public float []armadefsignv;
	public float []armapapasignv;
	public float []armarelsignv;
	[HideInInspector]public bool bajar = false;
	public float tempretarget;
	[HideInInspector]public bool subir = false;
	[HideInInspector]public bool moverdelante = true;
	[HideInInspector]public float temp10;
	[HideInInspector]public bool dashaeract;
	[HideInInspector]public bool muerte;
	[HideInInspector]public float vidaeneui;
	[HideInInspector]public float vidaeneuimax;
	[HideInInspector]public bool vidaeneact;
	[HideInInspector]public float staminamax = 100;
	[HideInInspector]public float stamina;
	[HideInInspector]public int escudosene = 0;
	[HideInInspector]public float vidaescudoene1;
	[HideInInspector]public float vidaescudoene2;
	[HideInInspector]public float vidaescudoene3;
	[HideInInspector]public float vidaescudomaxene;
	[HideInInspector]public bool escudoeneact;
	[HideInInspector]public bool _peligro;
	public float vidamax;
	public AudioSource subirnivelaud;
	public GameObject subirnivelexpl;
	[HideInInspector]public float velocidad = 8;
	[HideInInspector]public Rigidbody _rb;
	[HideInInspector]public float jumpforce = 500f;
	[HideInInspector]public float tiemposalto;
	[HideInInspector]public float tiempovel;
	[HideInInspector]public float tiempovelint;
	[HideInInspector]public float velocidadaux;
	[HideInInspector]public bool dimensiion;
	[HideInInspector]public float girodir = -90;
	public bool dentrotienda;
	[HideInInspector]public bool dashefect;
	[HideInInspector]public GameObject eneempuj;
	[HideInInspector]public bool empujon;
	[HideInInspector]public float disdash = 10;
	[HideInInspector]public float veldash = 30;
	[HideInInspector]public float vidamaxN;
	public bool noene;
	[HideInInspector]public Vector3 movdire;
	[HideInInspector]public Vector3 movdirect;
	[HideInInspector]public Vector3 movdirectaux;
	[HideInInspector]public RaycastHit hit;
	[HideInInspector]public float marcarc;
	[HideInInspector]public bool enetouch;
	public float[] balapadrevel = new float[5];
	public float[] balapadredano = new float[5];
	public float[] balapadrecaden = new float[5];
	public float[] balapapamun = new float[5];
	public float[] baladefdano = new float[5];
	public float[] balareldano = new float[5];
	public float tiempodisp2;
	public Text niveluit;
	public Image niverlbarra;
	public GameObject objetivotarget;
	public Sprite nopimg;
	public GameObject respawn;
	public GameObject balaprefab;
	public AudioSource saltadorson;
	public GameObject explosion;
	public AudioSource escudohabaud;
	public GameObject camara;
	public GameObject tactil;
	public Animator anim;
	public AudioSource muertes;
	public AudioSource muertesjug;
	public Animator menushow;
	public DialogueManager menuoff;
	public GameObject misionUI;
	public enemigo1boss_al1 eneboss1;
    public GameObject pausa1;
	public GameObject select1;
	public Image vidab;
	public Image vidaeneimg;
	public Image escudoeneimg1;
	public Image escudoeneimg2;
	public Image escudoeneimg3;
	public Image iconodisp;
	public misionA_al1 misionA;
	public string modo;
	public manager_al1 manager;
	public Animator ascensors;
	public GameObject vidaenebarra;
	public GameObject escudoenebarra;
	public GameObject boxcam2;
	public Text armanvt;
	public Text conseguido;
	public Animator conseguidoa;
	public Text niveleneui;
	public AudioSource tiendaMus;
	public bool desactivarmusicacombate;

	private bool musicaCombateActiva = false;
	private bool musicaNormalActiva = false;

	
	
	[Header("resto")]
	public Controles controles;

	public void Update()
	{
		
	}
	
	public void saltoalto()
	{
			this._rb.AddRelativeForce(this.jumpforce * 0.2f * Vector3.up);
			saltadorson.Play();
	}
    public void saltoalto2()
	{
			this._rb.AddRelativeForce(this.jumpforce * 1f * Vector3.up);
			saltadorson.Play();
		
	}
	public void saltoalto3()
	{

			this._rb.AddRelativeForce(this.jumpforce * 3f * Vector3.up);
			saltadorson.Play();

	}
	public void velozidad()
	{
		this.tiempovel = 0f;
		this.tiempovelint = 0;
		
	}
	public bool peligro
	{
		get { return _peligro; }
		set 
		{ 
			if (_peligro != value)
			{
				_peligro = value;
				ActualizarMusica();
			}
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002604 File Offset: 0x00000804
	public void ActualizarMusica()
	{
		if(peligro && modo == "2D" && tarbossact == false || peligro && modo == "3D" && tarbossact == false && desactivarmusicacombate == false)
		{
			musicanoC.Pause();
			musicaC.UnPause();
			musicajuego = musicaC;
			combini.Play();
			musicajuego.time = Random.Range(0,20);
		}
		if( peligro == false &&  modo == "2D" && tarbossact == false || peligro == false && modo == "3D" && tarbossact == false && desactivarmusicacombate == false)
		{
			
			musicaC.Pause();
			musicanoC.UnPause();
			musicajuego = musicanoC;
			combini.Stop();
			musicajuego.time = Random.Range(0,20);
		}
	}
	



	public void nivel2()
	{
			manager.datosserial.nivelexp = 0;
			manager.datosserial.niveljug = 2;
			manager.datosserial.signivelexp += 7;
			subirnivel();
	}
	public void subirnivel()
	{
		subirnivelaud.Play();
		
		GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

        expltemp.transform.SetParent(this.gameObject.transform);

		nivelfuerza = nivelfuerza_a[manager.datosserial.niveljug - 1];
        nivelvida = nivelvida_a[manager.datosserial.niveljug -1];
        vidamax = nivelvida;
		vida = vidamax;

        Destroy(expltemp,5f);
		conseguido.text = "subiste al nivel "+manager.datosserial.niveljug;
		conseguidoa.Play("nivelsub2");

	}
	
	public void tiendaact()
	{
		Time.timeScale = 0;
		manager.pauseact = true;
		musicajuego.Stop();
		tiendaG.SetActive(true);
		tiendaMus.Play();
		controlact = false;
		combo = 0;
		if(modo == "Coche")
		{
			anim.SetBool("act2",true);
		}
		if(modo == "Nave")
		{
			anim.SetBool("act",true);
		}
		temp10 = 0;
		if(manager.datosconfig.plat == 2)
		{
			tactil.SetActive(false);
		}
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	public void mision_aceptar()
	{
		
		Time.timeScale = 0;
		manager.pauseact = true;
		misionUI.SetActive(true);
		misionA.modo = 1;
		controlact = false;
		combo = 0;
		if(modo == "Coche")
		{
			anim.SetBool("act2",true);
		}
		if(modo == "Nave")
		{
			anim.SetBool("act",true);
		}
		temp10 = 0;
		if(manager.datosconfig.plat == 2)
		{
			tactil.SetActive(false);
		}
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	public void mision_fin()
	{
		
		Time.timeScale = 0;
		manager.pauseact = true;
		misionUI.SetActive(true);
		misionA.modo = 2;
		controlact = false;
		combo = 0;
		if(modo == "Coche")
		{
			anim.SetBool("act2",true);
		}
		if(modo == "Nave")
		{
			anim.SetBool("act",true);
		}
		temp10 = 0;
		if(manager.datosconfig.plat == 2)
		{
			tactil.SetActive(false);
		}
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	




}
