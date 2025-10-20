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
using System;

// Token: 0x0200000A RID: 10
public class jugador_chara3d_al2 : jugador_al2
{
	
	[Header("Propio 3D")]
	private bool pulso;	
	private golpe_al2 paloSC;
	private float tiempocarga;
    private GameObject cargaalmacenada;
	public GameObject explosioncarga;
    public jugador2_al2 jugador2;
	private GameObject balasaltadorR;
	public GameObject balasaltador;
	private GameObject balavelR;
	public GameObject balavel;
	private GameObject pared;
	public BoxCollider skatecol;
	public SphereCollider skatecol2;
	private float temprebote;
	private int ruletainterior;
	private bool salto2;
	public AudioSource dest;
	public AudioSource critico;
	public Image Critobj;
    public float colorC;
    private float vidaescudoUI1;
	private float vidaescudoUI2;
	public bool movPH;
	public bool viento;
	public float verticalVel;
	private float vidaescudoUI3;
	public bool invertirHorizontal = false;
	public GameObject ascensorui;
	public bool camnomov;
	private bool controlActivo = false; 
	public float horizontalFinal;
	public GameObject armadefpassC;
	private float cameraverticalangle;
	public GameObject giro;
	private bool subir0 = false;
	public Vector3 planetUp;
	public Vector3 rotationinput;
	public float rotspeed = 3;
	public float tempgir = 0;
	public int indicetarget = -1;
	public GameObject []target = new GameObject[3];
	private float cameraverticalangle2;
	public bool ascact;
	private float staminaobj;
	public AudioSource inbuir;
	public Text comandoarma;
	public Image staminabarra;
	private float temp9;
	private float xp;
	public AudioSource tragar;
	private float tempberserk;
	private float vidaberserk;
	private float danoextra = 1;
	private bool berserkfin;
	private bool velrecfin;
	private float tempinbuir;
	private bool inbuiract;
	private float vidaobj;
	public AudioSource espiraloaud;
	public AudioSource escudoaud;
	public AudioSource golpeson;
	public AudioSource lanzarson;
	public Text armaname;
	public Sprite[] armasspriterueda = new Sprite[12];
	private float VelSkate;
	public Sprite[] artilugiosrueda = new Sprite[8];
	public Sprite[] artilugiosequipados = new Sprite[8];

	public GameObject[] prebaladefl = new GameObject[10];
	public GameObject[] prebalarell = new GameObject[10];
	public GameObject[] prebalapapal = new GameObject[10];


	public AudioSource pistolabueno;
	public AudioSource pistolamalo;
	public Text balaarmat;
	private int cambioruedaact;
	public Text numpoct;
	public Text numpoc1t;
	public Text numpoc2t;
	public Text numpoc3t;
	public Text numpoc4t;
	public int personaje = 0;


	public Text vidat;
	public Text comando;
	public bool jugadorEntrando;
	private bool cargainicial;
	private int randompaso;
	public AudioSource pasos1;
	public AudioSource pasos2;
	public AudioSource sonidoTP;
    public GameObject expTP;
	public GameObject skateobj;
	public bool carga;
	public bool eventoini;
	private float angulomod;
	private float pasotiempo;
	private float temppaso = 1;
	public GameObject tarboss;
	public GameObject slash;
	public Sprite[] armasspriteequipada = new Sprite[12];
	public float staminaact = 50;
	public camara_al2 camarascript; 
	private float tempaerodash = 9;
	private float tempaerodash2 = 9;
	public AudioSource dashson;
	public AudioSource dashairson;
	private float dash = 0.3f;
	private float dash2 = 0.3f;
	private float dash3 = 0.3f;
	public AudioSource disp;
	public AudioSource disprel;
	public AudioSource dispdef;
	public Image barraarmaimgnv1;
	public Image barraarmaimgnv2;
	public Image barraarmaimgnv3;
	public Image barraarmaimgnv4;
	public Sprite arma1_1;
	public Sprite arma1_2;
	public Sprite arma1_3;
	public Sprite arma1_4;
	public Sprite arma1_5;
	public GameObject[] pistolamodels = new GameObject[12];
	public Image[] backarmaimg = new Image[4];
	public Image[] armaimg = new Image[4];
	public Image[] circuloarmaimg = new Image[4];
	public Sprite[] pocionsprite = new Sprite[4];

	private float temppalo = 60;
	private float tempatk;
	public bool escalar;
	private float velocidadmaxima = 13;
	public float vidabasetut = 9;
    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;
	private float camaux = 0;
	private float tiempodialogue = 2;
    public float fuebasetut = 1;
    public float fuebase = 2;
    public float fuebasemax = 5;
    public float fueplusmax = 10;
	public GameObject palo;
	public npc_al2 npcbase;
	private float jumpforcebase = 0f;
	public eventosdialogue_al2 eventosdialogueE;
	public Animator animcam;
	public AudioSource vozMeet;
	public AudioSource saltodo;
	private float tempdash = 12;
	private float tempdash2 = 12;
	private float ruletaXc;
	private float ruletaYc;
	private float camXc;
	private float camYc;
	private float movXc;
	private float movYc;
	private float UIXc;
	private float UIYc;	
	private float saltarc;
	private float dashc;
	private float golpearc;
	private float interactuarc;
	private float dispararc;
	private float ruletac;
	private float ruletapressc;
	private float UIreducidoc;
	private float correrc;
	private float menu1c;
	private float menu2c;
	public float lateralc;
	public int ruletas;	
    private float teh; 
	private float teh2; 
    private bool peh;
    private bool fired;
	private float tehg; 
    private bool firedg;
	private float teh2g; 
    private bool pehg;
	private Vector3 moveDirSK;
	public GameObject skatevis;
	private Camera camaracom;
	public prefabbala_al2 armasbalas;
	public void Awake()
    {
        controles = new Controles();
		
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
	// Token: 0x0600001D RID: 29 RVA: 0x000025E8 File Offset: 0x000007E8
	private void Start()
	{
		
		critico.Pause();

		fuebasetut = 1;
		fuebase = 2;
		fuebasemax = 30;
		fueplusmax = 120;
		
		rotspeed = 100;
		
		if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}
		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));

		

		if(manager.nivelact)
		{
			controlact = false;
			animcam.Play("comenzarnivel");
			sonidoTP.Play();
			GameObject exptemp = Instantiate(expTP, transform.position,transform.rotation) as GameObject;
			Destroy(exptemp,1);
		}

		camarascript = (camara_al2)FindFirstObjectByType(typeof(camara_al2));

		camaracom = camarascript.transform.GetComponent<Camera>();

		
		nivelvida_a[0] = vidabasetut;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelvida_a[i] = (vidabase) + (((vidabasemax-vidabase)/48) * (i -1 ));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            nivelvida_a[i] = (vidabasemax) + (((vidaplusmax - vidabasemax)/50) * (i - 49));
        }

        nivelfuerza_a[0] = fuebasetut;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelfuerza_a[i] = (fuebase) + (((fuebasemax-fuebase)/48) * (i - 2));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            nivelfuerza_a[i] = (fuebasemax) + (((fueplusmax -fuebasemax)/50) * (i - 49));
        }

        nivelfuerza = nivelfuerza_a[manager.datosserial.niveljug - 1];
        nivelvida = nivelvida_a[manager.datosserial.niveljug -1];
        vidamax = nivelvida;



		

			if(manager.datosserial.armasjug[0] == false)
			{
				armaimg[0].sprite = nopimg;
			}


			if(manager.datosserial.armasjug[1] == false)
			{
				armaimg[1].sprite = nopimg;
			}

			if(manager.datosserial.armasjug[3] == false)
			{
				armaimg[3].sprite = nopimg;
			}
			
			if(manager.datosserial.armasjug[2] == false)
			{
				armaimg[2].sprite = nopimg;
			}

			ruletas = manager.datosserial.ruletatipo_armas;
			if(ruletas == 0)
			{
				ruletainterior = manager.datosserial.ruletainterior_armas;
			}
			if(ruletas == 1)
			{
				ruletainterior = manager.datosserial.ruletainterior_artilugios;
			}

			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1)
			{
				iconodisp.sprite = arma1_1;

			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2)
			{
				iconodisp.sprite = arma1_2;

			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3)
			{
				iconodisp.sprite = arma1_3;

			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4)
			{
				iconodisp.sprite = arma1_4;

			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5)
			{
				iconodisp.sprite = arma1_5;

			}



			if(manager.datosserial.armasel == 1 )
			{
				armaname.text = "ParteCraneos";
			}
			if(manager.datosserial.armasel == 2)
			{
				armaname.text = "EL Gatillonizador";
				iconodisp.sprite = armasspriteequipada[1];
				cambiar_modelo_arma();
				pistolamodels[1].SetActive(true);
			}
			if(manager.datosserial.armasel == 3)
			{
				armaname.text = "PX4000 Quebrada";
				iconodisp.sprite = armasspriteequipada[2];
				cambiar_modelo_arma();
				pistolamodels[3].SetActive(true);
			}
			if(manager.datosserial.armasel == 4)
			{
				armaname.text = "HARMONIZADORA";
				iconodisp.sprite = armasspriteequipada[3];
				cambiar_modelo_arma();
				pistolamodels[2].SetActive(true);
			}


			if(manager.datosserial.armasel == 5)
			{
				armaname.text = "CopiaEspejo";
				iconodisp.sprite = armasspriteequipada[4];
				cambiar_modelo_arma();
				pistolamodels[4].SetActive(true);
			}
			if(manager.datosserial.armasel == 6)
			{
				armaname.text = "Generador de Pulsos";
				iconodisp.sprite = armasspriteequipada[5];
				cambiar_modelo_arma();
				pistolamodels[5].SetActive(true);
			}
			if(manager.datosserial.armasel == 7)
			{
				armaname.text = "RataTaPUM V1";
				iconodisp.sprite = armasspriteequipada[6];
				cambiar_modelo_arma();
				pistolamodels[6].SetActive(true);
			}
			if(manager.datosserial.armasel == 8)
			{
				armaname.text = "Carnicera";
				iconodisp.sprite = armasspriteequipada[7];
				cambiar_modelo_arma();
				pistolamodels[7].SetActive(true);
			}




			if(manager.datosserial.armasel == 9)
			{
				armaname.text = "Matasuegras";
				iconodisp.sprite = armasspriteequipada[8];
				cambiar_modelo_arma();
				pistolamodels[8].SetActive(true);
			}
			if(manager.datosserial.armasel == 10)
			{
				armaname.text = "S/C egadora";
				iconodisp.sprite = armasspriteequipada[9];
				cambiar_modelo_arma();
				pistolamodels[9].SetActive(true);
			}
			if(manager.datosserial.armasel == 11)
			{
				armaname.text = "SantosCielos";
				iconodisp.sprite = armasspriteequipada[10];
				cambiar_modelo_arma();
				pistolamodels[10].SetActive(true);
			}
			if(manager.datosserial.armasel == 12)
			{
				armaname.text = "Mina Guardian V1";
				iconodisp.sprite = armasspriteequipada[11];
				cambiar_modelo_arma();
				pistolamodels[11].SetActive(true);
			}



			if(manager.datosserial.armasel == 101)
			{
				armaname.text = "Hypertabla";
				iconodisp.sprite = artilugiosequipados[0];
				cambiar_modelo_arma();
			}
			if(manager.datosserial.armasel == 102)
			{
				armaname.text = "Caña de Pesca";
				iconodisp.sprite = artilugiosequipados[1];
				cambiar_modelo_arma();
				pistolamodels[13].SetActive(true);
			}
			if(manager.datosserial.armasel == 103)
			{
				armaname.text = "CortaReflejos";
				iconodisp.sprite = artilugiosequipados[2];
				cambiar_modelo_arma();
				pistolamodels[14].SetActive(true);
			}
			if(manager.datosserial.armasel == 104)
			{
				armaname.text = "Mano Obrera";
				iconodisp.sprite = artilugiosequipados[3];
				cambiar_modelo_arma();
				pistolamodels[15].SetActive(true);
			}


			if(manager.datosserial.armasel == 105)
			{
				armaname.text = "Arcana Modo 1";
				iconodisp.sprite = artilugiosequipados[4];
				cambiar_modelo_arma();
				pistolamodels[16].SetActive(true);
			}
			if(manager.datosserial.armasel == 106)
			{
				armaname.text = "Arcana Modo 2";
				iconodisp.sprite = artilugiosequipados[5];
				cambiar_modelo_arma();
				pistolamodels[17].SetActive(true);
			}
			if(manager.datosserial.armasel == 107)
			{
				armaname.text = "Mando de la Nave";
				iconodisp.sprite = artilugiosequipados[6];
				cambiar_modelo_arma();
			}
			if(manager.datosserial.armasel == 108)
			{
				armaname.text = "Persuasora";
				iconodisp.sprite = artilugiosequipados[7];
				cambiar_modelo_arma();
				pistolamodels[19].SetActive(true);
			}

			if(manager.datosserial.armasel == 1)
			{
				cambiar_modelo_arma();
			}
			if(manager.datosserial.armasel == 0)
			{
				iconodisp.sprite = nopimg;
				cambiar_modelo_arma();
				
			}

		



		

			velocidad = 8;
			velocidadaux = 8;
			velocidadmaxima = 13;
			jumpforce = 700;
		

		this._rb = base.GetComponent<Rigidbody>();
		velocidadaux = velocidad;
		jumpforcebase = jumpforce;

        this.jugadorEntrando = false;
        
		if(anim != null)
		{
			anim.updateMode = AnimatorUpdateMode.Fixed;
		}

			mod = this.gameObject.transform.GetChild(0).gameObject;
		
		vida = vidamax;
		if(manager.datosserial.armasjug[0] == false)
		{

		
			palo.SetActive(false);
			
		}
		
		vidaenebarra.SetActive(false);
		

			camara.transform.eulerAngles = new Vector3(camara.transform.eulerAngles.x,transform.eulerAngles.y,camara.transform.eulerAngles.z);
		

		musicajuego = musicanoC;
		musicajuego.Play();
		musicajuego.time = UnityEngine.Random.Range(0,20);
		

		stamina = staminamax;
		
		tiempovelint = 3;
		vidaobj = vida;
		staminaobj = stamina;

		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if(manager.datosconfig.plat == 2)
        {
            tactil.SetActive(true);

        }
		paloSC = palo.GetComponent<golpe_al2>();

		
		
		
	}
	public void fixedStart()
	{
		
	}
	
	private void FixedUpdate()
	{

		if (enemigosEnContacto.Count == 0)
		{
			peligro = false;
		}
		
		if(movact == 0 && controlact == true && movPH == true && manager.personaje != 2)
		{
			
			if(escalar == true && movYc > 0)
			{
				movYc = 0;
			}

			Vector3 movdirnow = (transform.TransformDirection(new Vector3 (movXc,0, movYc).normalized)) * velocidad;

			Vector3 moveDir =  movdirnow;

            // Raycast para detectar colisión en la dirección del movimiento
            if (Physics.Raycast(transform.position + new Vector3(0,1.5f,0),moveDir, out RaycastHit hit,Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,1.5f,0),moveDir * 300, Color.yellow);
				if(hit.distance < 2)
                {moveDir = new Vector3(0,0,0);}
               
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,1.5f,0),moveDir * 300, Color.red);
			}
			if (Physics.Raycast(transform.position + new Vector3(0,-1.5f,0),moveDir, out RaycastHit hit2, Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,-1.5f,0),moveDir * 300, Color.yellow);
				if(hit2.distance < 2)
                {moveDir = new Vector3(0,0,0);}
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,-1.5f,0),moveDir * 300, Color.red);
			}
			if (Physics.Raycast(transform.position,moveDir, out RaycastHit hit3,Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,0,0),moveDir * 300, Color.yellow);
				if(hit3.distance < 2)
                {moveDir = new Vector3(0,0,0);}
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,0,0),moveDir * 300, Color.red);
			}

			
			
			
			


			_rb.linearVelocity = new Vector3(moveDir.x,_rb.linearVelocity.y,moveDir.z);

			

		}
		if(movact == 0 && controlact == true && movskate == true)
		{
			
			

			Vector3 movdirnow = (transform.TransformDirection(new Vector3 (movXc,0, movYc).normalized)) ;

			moveDirSK =  movdirnow;
			VelSkate = 17;

            // Raycast para detectar colisión en la dirección del movimiento
            if (Physics.Raycast(transform.position + new Vector3(0,1.5f,0),moveDirSK, out RaycastHit hit,Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,1.5f,0),moveDirSK * 300, Color.yellow);
				if(hit.distance < 2)
                {moveDirSK = new Vector3(0,0,0);}
               
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,1.5f,0),moveDirSK * 300, Color.red);
			}
			if (Physics.Raycast(transform.position + new Vector3(0,-1.5f,0),moveDirSK, out RaycastHit hit2, Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,-1.5f,0),moveDirSK * 300, Color.yellow);
				if(hit2.distance < 2)
                {moveDirSK = new Vector3(0,0,0);}
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,-1.5f,0),moveDirSK * 300, Color.red);
			}
			if (Physics.Raycast(transform.position,moveDirSK, out RaycastHit hit3,Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,0,0),moveDirSK * 300, Color.yellow);
				if(hit3.distance < 2)
                {moveDirSK = new Vector3(0,0,0);}
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,0,0),moveDirSK * 300, Color.red);
			}

			if(viento == false)
			{
				verticalVel = _rb.linearVelocity.y;
				
			}

			if(movact == 0 && controlact == true && skate == true && grind == false)
			{
		
				_rb.linearVelocity = new Vector3(moveDirSK.x* VelSkate, _rb.linearVelocity.y,moveDirSK.z* VelSkate) ;

				

			}
			

			
			
			
			


			

		}
	}
	private void Update()
	{	
		if(manager.personaje == 2)
		{
			
			camaracom.enabled = false;
		}
		else
		{
			camaracom.enabled = true;
		}
		if(viento == false)
		{
			verticalVel = _rb.linearVelocity.y;
			
		}
		if(skate == true)
		{
			skatecol2.enabled = true;
		}
		else if(skate == false )
		{
			
			skatecol2.enabled = false;
		}

		if(anim.GetCurrentAnimatorStateInfo(0).IsName("skate") && skate  == true)
		{
			skateobj.SetActive(true);
			skatevis.SetActive(true);
		}
		else if(anim.GetCurrentAnimatorStateInfo(0).IsName("staticar") && skate  == false)
		{
			skateobj.SetActive(false);
			
		}

		VelSkate -= 20 * Time.deltaTime;
		if(VelSkate < 0)
		{
			VelSkate = 0;
		}
		
		if(animcam.GetCurrentAnimatorStateInfo(0).IsName("staticcam") && carga == false && temp10 > 1)
		{
			controlact = true;
			carga = true;
		}
		if(vida < ((vidamax/100)* 25))
		{

			critico.UnPause();
				
		}
		else
		{
			critico.Pause();
		}

		float porcentaje = (vida * 100.0f) / vidamax;
		if (porcentaje <= 30)
		{
			float x_min = 5.0f;
			float x_max = 30.0f;
			float y_min = 0.5f;
			float y_max = 0.1f;

			colorC = y_min + ((porcentaje - x_min) / (x_max - x_min)) * (y_max - y_min);
		}
        else
        {
            colorC = 0;
        }
		Critobj.color = new Color(Critobj.color.r,Critobj.color.g,Critobj.color.b,Mathf.Lerp(Critobj.color.a,colorC, Time.deltaTime * 2f));





        if(vidaeneact)
		{
			vidaeneimg.fillAmount = vidaeneui/vidaeneuimax;
		}

		if(peligro && modo == "2D" && tarbossact == false || peligro && modo == "3D" && tarbossact == false && desactivarmusicacombate == false)
		{
			musicanoC.Pause();
			musicaC.UnPause();
		}
		if( peligro == false &&  modo == "2D" && tarbossact == false || peligro == false && modo == "3D" && tarbossact == false && desactivarmusicacombate == false)
		{
			
			musicaC.Pause();
			musicanoC.UnPause();
		}

		if(escudoeneact)
		{
			escudoenebarra.SetActive(true);
			if(escudosene >= 1)
			{
				vidaescudoUI1 = Mathf.Lerp(vidaescudoUI1,  vidaescudoene1, Time.deltaTime * 2f);
			}
			if(escudosene >= 2)
			{
				vidaescudoUI2 = Mathf.Lerp(vidaescudoUI2, vidaescudoene2, Time.deltaTime * 2f);
			}
			if(escudosene == 3)
			{
				vidaescudoUI3 = Mathf.Lerp(vidaescudoUI3,  vidaescudoene3, Time.deltaTime * 2f);
			}

			if(escudosene == 1)
			{
				escudoeneimg3.fillAmount = vidaescudoUI1/vidaescudomaxene;
				escudoeneimg2.fillAmount = 0;
				escudoeneimg1.fillAmount = 0;
			}
			if(escudosene == 2)
			{
				escudoeneimg3.fillAmount = vidaescudoUI1/vidaescudomaxene;
				escudoeneimg2.fillAmount = vidaescudoUI2/vidaescudomaxene;
				escudoeneimg1.fillAmount = 0;
			}
			if(escudosene == 3)
			{
				escudoeneimg3.fillAmount = vidaescudoUI1/vidaescudomaxene;
				escudoeneimg2.fillAmount = vidaescudoUI2/vidaescudomaxene;
				escudoeneimg1.fillAmount = vidaescudoUI3/vidaescudomaxene;
			}
			
			
			
		}
		else
		{
			escudoenebarra.SetActive(false);
			escudoeneimg1.fillAmount = 0;
			escudoeneimg2.fillAmount = 0;
			escudoeneimg3.fillAmount = 0;
			
			
		}
	
	if(vida < 1)
	{
		critico.Pause();
		vida = 0;
		muerte = true;
	}
	if(muerte == true)
	{
		if(!manager.tutorial)
		{
			
			muertesjug.Play();
			
			manager.datosserial.alien2muere = true;
			manager.datosserial.muertes++;
			manager.guardar();
			if(manager.datosconfig.plat == 2)
			{
				tactil.SetActive(false);
			}
			respawn.SetActive(true);
			this.gameObject.SetActive(false);
		}
		else
		{
			manager.datosserial.eventos[0] = true;
			manager.guardar();
			manager.datosconfig.carga = "tutorialcin2enc_al2";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");
		}
		
	}

		staminaobj = Mathf.Lerp(staminaobj, stamina, Time.deltaTime * 4f);
		vidaobj = Mathf.Lerp(vidaobj, vida, Time.deltaTime * 2f);
		vidab.fillAmount = vidaobj/vidamax; 
		vidat.text = string.Concat("VIT:",(int)vida,"/",(int)vidamax);
		nivelbarra.fillAmount = manager.datosserial.nivelexp/manager.datosserial.signivelexp; 
		niveluit.text = string.Concat("LEVEL ", manager.datosserial.niveljug);
		staminabarra.fillAmount = staminaobj/staminamax;
	
	if(controlact == false)
	{
		anim.SetBool("stat",true);
	}

	if(manager.personaje != 2)
    {
		if(controlact == true)
		{

			
				ruletaXc = controles.al2_3d.ruletaPAD.ReadValue<Vector2>().x;
				ruletaYc = controles.al2_3d.ruletaPAD.ReadValue<Vector2>().y;



				
				camXc = controles.al2_3d.camX.ReadValue<float>();
				camYc = controles.al2_3d.camY.ReadValue<float>();
				


				


				if(movact == 0)
				{
					movXc = controles.al2_3d.mov.ReadValue<Vector2>().x;
					movYc = controles.al2_3d.mov.ReadValue<Vector2>().y;
					saltarc = controles.al2_3d.saltar.ReadValue<float>();
				}
				else
				{
					
					movXc = 0;
					movYc = 0;
				}

			

			lateralc = controles.al2_3d.lateral.ReadValue<float>();
			UIXc = controles.al2_UI.UIX.ReadValue<float>();
			UIYc = controles.al2_UI.UIY.ReadValue<float>();	
			dispararc = controles.al2_3d.disparar.ReadValue<float>();	
			dashc = controles.al2_3d.dash.ReadValue<float>();
			interactuarc = controles.al2_3d.interactuar.ReadValue<float>();		
			
			
			UIreducidoc = controles.al2_3d.UIreducido.ReadValue<float>();
			marcarc = controles.al2_3d.marcar.ReadValue<float>();
			correrc = controles.al2_3d.correr.ReadValue<float>();
			menu1c = controles.al2_3d.menu1.ReadValue<float>();
			menu2c = controles.al2_3d.menu2.ReadValue<float>();

			if (controles.al2_3d.ruletapress.ReadValue<float>() > 0) { teh += Time.deltaTime; if (!fired && teh >= 0.5f) { ruletapressc = 1;fired = true;} }
			else { teh = 0; ruletapressc = 0;fired = false; }

			bool beh = controles.al2_3d.ruleta.ReadValue<float>() > 0;

			if (beh && !peh) { peh = true; teh2 = 0; }       // empezamos a contar
			if (beh && peh) teh2 += Time.deltaTime;        // acumulamos tiempo
			if (!beh && peh)                            // se soltó
			{
				if (teh2 < 0.5f) ruletac = 1;
				peh = false;
			}

			if (controles.al2_3d.golpearM.ReadValue<float>() > 0) { tehg += Time.deltaTime; if (!firedg && tehg >= 0.5f) { golpearMc = 1;firedg = true;} }
			else { tehg = 0; golpearMc = 0;firedg = false; }

			bool behg = controles.al2_3d.golpear.ReadValue<float>() > 0;

			if (behg && !pehg) { pehg = true; teh2g = 0; }       // empezamos a contar
			if (behg && pehg) teh2g += Time.deltaTime;        // acumulamos tiempo
			if (!behg && pehg)                            // se soltó
			{
				if (teh2g < 0.5f) golpearc = 1;
				pehg = false;
			}


			
			

			if (menu1c > 0 && temp10 > 0.7f)
			{
				Time.timeScale = 0;
				manager.pauseact = true;
				pausa1.SetActive(true);
				controlact = false;
				combo = 0;
				comboa = 0;
				menu1c = 0;
				temp10 = 0;
				if(manager.datosconfig.plat == 2)
				{
					tactil.SetActive(false);
				}
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}

			else if (menu2c > 0 && temp10 > 0.7f)
			{
				Time.timeScale = 0;
				manager.pauseact = true;
				select1.SetActive(true);
				var pausatemp = select1.GetComponent<pausa_al2>();
				pausatemp.mapa_();
				pausatemp.RestoreOriginalControls();
				controlact = false;
				combo = 0;
				comboa = 0;
				menu2c = 0;
				temp10 = 0;
				if(manager.datosconfig.plat == 2)
				{
					tactil.SetActive(false);
				}
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
			

			
		}
		else
		{
			
			camXc = controles.al2_3d.camX.ReadValue<float>();
			camYc = controles.al2_3d.camY.ReadValue<float>();
			marcarc = controles.al2_3d.marcar.ReadValue<float>();
			dispararc = controles.al2_3d.disparar.ReadValue<float>();
			
			movXc = 0;
			movYc = 0;
			
			
		}
	}


			if(manager.datosserial.armasel == 1)
			{
				balaarmat.text = string.Concat((int)((temppalo/60)*100),"%");
				armanvt.text = string.Concat("nv",manager.datosserial.nivelarmasjug[0]);		
			}
			if(manager.datosserial.armasel != 1 && manager.datosserial.armasel <= 100 && manager.datosserial.armasel > 0)
			{
				balaarmat.text = string.Concat(manager.datosserial.armasmun[manager.datosserial.armasel-1],"/",manager.datosserial.armasmun_max[manager.datosserial.armasel-1]);
				armanvt.text = string.Concat("nv",manager.datosserial.nivelarmasjug[1]);			
			}
			if(manager.datosserial.armasel > 100 && manager.datosserial.armasel < 105 || manager.datosserial.armasel == 107 || manager.datosserial.armasel == 108)
			{
				balaarmat.text = string.Concat("infinity");
				armanvt.text = string.Concat("Ar");			
			}
			if(manager.datosserial.armasel == 105)
			{
				balaarmat.text = string.Concat(manager.datosserial.artilugiosmun[4],"/",manager.datosserial.artilugiosmun_max[4]);
				armanvt.text = string.Concat("Ar");		
			}
			if(manager.datosserial.armasel == 106)
			{
				balaarmat.text = string.Concat(manager.datosserial.artilugiosmun[5],"/",manager.datosserial.artilugiosmun_max[5]);
				armanvt.text = string.Concat("Ar");		
			}
			if(manager.datosserial.armasel != 0 && manager.datosserial.armasel <= 100)
			{
				if(manager.datosserial.nivelarmasjug[manager.datosserial.armasel-1] == 1)
				{
					barraarmaimgnv1.fillAmount = manager.datosserial.nivelarmasexpjug[manager.datosserial.armasel-1]/manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]];
					barraarmaimgnv2.fillAmount = 0;
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmasjug[manager.datosserial.armasel-1] == 2)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = manager.datosserial.nivelarmasexpjug[manager.datosserial.armasel-1]/manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[1]];
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmasjug[manager.datosserial.armasel-1] == 3)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = manager.datosserial.nivelarmasexpjug[manager.datosserial.armasel-1]/manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[2]];
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmasjug[manager.datosserial.armasel-1] == 4)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = manager.datosserial.nivelarmasexpjug[manager.datosserial.armasel-1]/manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[3]];
				}
				else if(manager.datosserial.nivelarmasjug[manager.datosserial.armasel-1] == 5)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = 1;
				}
			}
			else if(manager.datosserial.armasel >= 101 && manager.datosserial.armasel <= 108 )
			{
				barraarmaimgnv1.fillAmount = 1;
				barraarmaimgnv2.fillAmount = 1;
				barraarmaimgnv3.fillAmount = 1;
				barraarmaimgnv4.fillAmount = 1;	
			}
			else
			{
				barraarmaimgnv1.fillAmount = 1;
				barraarmaimgnv2.fillAmount = 0;
				barraarmaimgnv3.fillAmount = 0;
				barraarmaimgnv4.fillAmount = 0;
			}
		if(ruletapressc > 0 && tiempodisp > 0.2  && skate == false && tiendat == false)
		{
			ruletas++;
			if(ruletas >= 3)
			{ruletas = 0;}

			if(ruletas == 0)
			{ruletainterior = manager.datosserial.ruletainterior_armas;}
			if(ruletas == 1)
			{ruletainterior = manager.datosserial.ruletainterior_artilugios;}
			if(ruletas == 2)
			{ruletainterior = 0;}

			cambioruedaact = 0;
			tiempodisp = 0;
			
		}
		
		if(ruletas == 0 && tiendat == false)
		{

			if(ruletac > 0 && tiempodisp > 0.2f)
			{

				ruletainterior++;
				if(ruletainterior >= 3)
				{ruletainterior = 0;}
				cambioruedaact = 0;
				tiempodisp = 0;
				
			}
			if(ruletainterior == 0)
			{
				comandoarma.text = "Armas 1";
				if(manager.datosserial.armasjug[0] == true)
				{

					armaimg[0].fillAmount = temppalo/60;
					circuloarmaimg[0].fillAmount = temppalo/60;

					

					
				}
				if(manager.datosserial.armasjug[1] == true)
				{
					armaimg[1].fillAmount = manager.datosserial.armasmun[1]/manager.datosserial.armasmun_max[1];
					circuloarmaimg[1].fillAmount = manager.datosserial.armasmun[1]/manager.datosserial.armasmun_max[1];
				}
				if(manager.datosserial.armasjug[2] == true)
				{
					armaimg[2].fillAmount = manager.datosserial.armasmun[2]/manager.datosserial.armasmun_max[2];
					circuloarmaimg[2].fillAmount = manager.datosserial.armasmun[2]/manager.datosserial.armasmun_max[2];
				}
				if(manager.datosserial.armasjug[3] == true)
				{
					armaimg[3].fillAmount = manager.datosserial.armasmun[3]/manager.datosserial.armasmun_max[3];
					circuloarmaimg[3].fillAmount = manager.datosserial.armasmun[3]/manager.datosserial.armasmun_max[3];
				}
				if(cambioruedaact == 0)
				{
					numpoct.text = "";
					numpoc1t.text = "";
					numpoc2t.text = "";
					numpoc3t.text = "";
					numpoc4t.text = "";
					

					if(manager.datosserial.armasjug[0] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else
					{
						if(manager.datosserial.armasel != 1 && manager.datosserial.palosel == 1)
						{
							armaimg[0].sprite = armasspriteequipada[0];
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].sprite = armasspriteequipada[0];
							if(temppalo < 3)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								armaimg[0].color = new Color(1,1,1,0.1f);
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
						}
						else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1)
						{
							if(manager.datosserial.nivelarmasjug[0] == 1)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
							else
							{
								armaimg[0].sprite = arma1_2;
								backarmaimg[0].sprite = arma1_2;
								
							}
							armaimg[0].color = new Color(1,1,1,1);						
							if(temppalo < 40)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								armaimg[0].color = new Color(1,1,1,1);
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
						}
						else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2)
						{
							if(manager.datosserial.nivelarmasjug[0] == 2)
							{
								armaimg[0].sprite = arma1_1;
								backarmaimg[0].sprite = arma1_1;
							}
							else
							{
								armaimg[0].sprite = arma1_3;
								backarmaimg[0].sprite = arma1_3;
							}
							armaimg[0].color = new Color(1,1,1,1);
							
							if(temppalo < 5)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								armaimg[0].color = new Color(1,1,1,1);
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
							
						}
						else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3)
						{
							if(manager.datosserial.nivelarmasjug[0] == 3)
							{
								armaimg[0].sprite = arma1_1;
								backarmaimg[0].sprite = arma1_1;
							}
							else
							{
								armaimg[0].sprite = arma1_4;
								backarmaimg[0].sprite = arma1_4;
							}
							armaimg[0].color = new Color(1,1,1,1);
							
							if(temppalo < 30)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								armaimg[0].color = new Color(1,1,1,1);
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
						}
						else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4)
						{
							if(manager.datosserial.nivelarmasjug[0] == 4)
							{
								armaimg[0].sprite = arma1_1;
								backarmaimg[0].sprite = arma1_1;
							}
							else
							{
								armaimg[0].sprite = arma1_5;
								backarmaimg[0].sprite = arma1_5;
							}
							armaimg[0].color = new Color(1,1,1,1);
							
							if(temppalo < 60)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								armaimg[0].color = new Color(1,1,1,1);
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
						}
						else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5)
						{
							armaimg[0].sprite = arma1_1;
							armaimg[0].color = new Color(1,1,1,1);
							backarmaimg[0].sprite = arma1_1;
							if(temppalo < 3)
							{
								armaimg[0].sprite = armasspriteequipada[0];
								armaimg[0].color = new Color(1,1,1,1);
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
						}
					}

					if(manager.datosserial.armasjug[1] == false)
					{
						armaimg[1].sprite = nopimg;
						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 2)
						{

							armaimg[1].sprite = armasspriterueda[1];

							
							armaimg[1].color = new Color(1,1,1,1);
							backarmaimg[1].sprite = armasspriterueda[1];
						}
						else
						{
							armaimg[1].sprite = armasspriterueda[1];
							armaimg[1].color = new Color(1,1,1,0.1f);
							backarmaimg[1].sprite = armasspriterueda[1];
						}

					}

					if(manager.datosserial.armasjug[3] == false)
					{
						armaimg[3].sprite = nopimg;
						armaimg[3].color = new Color(1,1,1,1);
						backarmaimg[3].sprite = nopimg;
					}
					else
					{
						if(manager.datosserial.armasel == 4)
						{
							armaimg[3].sprite = armasspriterueda[3];
							armaimg[3].color = new Color(1,1,1,1);
							backarmaimg[3].sprite = armasspriterueda[3];
						}
						else
						{
							armaimg[3].sprite = armasspriterueda[3];
							armaimg[3].color = new Color(1,1,1,0.1f);
							backarmaimg[3].sprite = armasspriterueda[3];
						}
					}
					
					if(manager.datosserial.armasjug[2] == false)
					{
						armaimg[2].sprite = nopimg;
						armaimg[2].color = new Color(1,1,1,1);
						backarmaimg[2].sprite = nopimg;
						
					}
					else
					{
						if(manager.datosserial.armasel == 3)
						{
							armaimg[2].sprite = armasspriterueda[2];
							armaimg[2].color = new Color(1,1,1,1);
							backarmaimg[2].sprite = armasspriterueda[2];

						}
						else
						{
							armaimg[2].sprite = armasspriterueda[2];
							armaimg[2].color = new Color(1,1,1,0.1f);
							backarmaimg[2].sprite = armasspriterueda[2];

						}
					}
					cambioruedaact = 1;
				}

				if(ruletaYc > 0f )
				{
					if(manager.datosserial.armasjug[0] == true && tiempodisp > 0.2f)
					{
						armaname.text = "ParteCraneos";
						armaimg[0].color = new Color(1,1,1,1f);

						if(manager.datosserial.armasjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}
						if(manager.datosserial.armasjug[2])
						{armaimg[3].color = new Color(1,1,1,0.1f);}
						if(manager.datosserial.armasjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						
						backarmaimg[0].color = new Color(1,1,1,0f);
						if(manager.datosserial.armasel != 1 || manager.datosserial.nivelarmasjug[0] == 1)
						{
							tiempodisp = 0;
							
							manager.datosserial.armasel = 1;
							manager.datosserial.palosel = 1;
							manager.datosserial.ruletainterior_armas = 0;
							manager.datosserial.ruletatipo_armas = 0;
							manager.guardar();
							iconodisp.sprite = arma1_1;
							if(manager.datosserial.nivelarmasjug[0] == 1) 
							{
								armaimg[0].sprite = armasspriteequipada[0];
								backarmaimg[0].sprite = armasspriteequipada[0];
							}
							else if(manager.datosserial.nivelarmasjug[0] >= 3)
							{
								armaimg[0].sprite = arma1_2;
								backarmaimg[0].sprite = arma1_2;
							}
						}
						else if(manager.datosserial.palosel == 1 && manager.datosserial.nivelarmasjug[0] >= 3)
						{
							tiempodisp = 0;
							manager.datosserial.armasel = 1;
							manager.datosserial.palosel = 2;
							manager.datosserial.ruletainterior_armas = 0;
							manager.datosserial.ruletatipo_armas = 0;
							manager.guardar();
							iconodisp.sprite = arma1_2;
							armaimg[0].sprite = arma1_3;
							backarmaimg[0].sprite = arma1_3;


						}
						else if(manager.datosserial.palosel == 2 && manager.datosserial.nivelarmasjug[0] >= 5)
						{
							tiempodisp = 0;
							manager.datosserial.armasel = 1;
							manager.datosserial.palosel = 3;
							manager.datosserial.ruletainterior_armas = 0;
							manager.datosserial.ruletatipo_armas = 0;
							manager.guardar();
							iconodisp.sprite = arma1_3;
							armaimg[0].sprite = arma1_4;
							backarmaimg[0].sprite = arma1_4;
						}
						else if(manager.datosserial.palosel == 3 && manager.datosserial.nivelarmasjug[0] >= 7)
						{
							tiempodisp = 0;
							manager.datosserial.armasel = 1;
							manager.datosserial.palosel = 4;
							manager.datosserial.ruletainterior_armas = 0;
							manager.datosserial.ruletatipo_armas = 0;
							manager.guardar();
							iconodisp.sprite = arma1_4;
							armaimg[0].sprite = arma1_5;
							backarmaimg[0].sprite = arma1_5;	
						}
						else if(manager.datosserial.palosel == 4 && manager.datosserial.nivelarmasjug[0] == 8)
						{
							tiempodisp = 0;
							manager.datosserial.armasel = 1;
							manager.datosserial.palosel = 5;
							manager.datosserial.ruletainterior_armas = 0;
							manager.datosserial.ruletatipo_armas = 0;
							manager.guardar();
							iconodisp.sprite = arma1_5;
							armaimg[0].sprite = arma1_1;
							backarmaimg[0].sprite = arma1_1;
						}
						cambiar_modelo_arma();
						
					}
				}
			
				if(ruletaXc > 0f )
				{
					if(manager.datosserial.armasjug[1] == true && tiempodisp > 0.2f)
					{
						armaname.text = "EL Gatillazonador";
						armaimg[1].color = new Color(1,1,1,1f);


						if(manager.datosserial.armasjug[0])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}
						
						if(manager.datosserial.armasjug[3])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						
						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].color = new Color(1,1,1,0.3f);


						
						tiempodisp = 0;
						manager.datosserial.armasel = 2;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 0;
						manager.datosserial.ruletatipo_armas = 0;
						iconodisp.sprite = armasspriteequipada[1];
						manager.guardar();
						
						if(manager.datosserial.armasjug[0] == true)
						{armaimg[0].sprite = armasspriteequipada[0];}
						else
						{
							armaimg[0].sprite = nopimg;
							backarmaimg[0].sprite = nopimg;
						}
						cambiar_modelo_arma();
						pistolamodels[1].SetActive(true);
					}
				}
				if(ruletaYc < 0f )
				{
					armaname.text = "HARMONIZADORA";
					if(manager.datosserial.armasjug[2] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.armasjug[0])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[2])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[2].color = new Color(1,1,1,1f);
						backarmaimg[2].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 3;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 0;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[3];

						if(manager.datosserial.armasjug[0] == true)
						{armaimg[0].sprite = armasspriteequipada[0];}
						else
						{
							armaimg[0].sprite = nopimg;
							backarmaimg[0].sprite = nopimg;
						}
						
						cambiar_modelo_arma();
						pistolamodels[3].SetActive(true);
						
					}
				}
				if(ruletaXc < 0f )
				{
					armaname.text = "PX4000 Quebrada";
					if(manager.datosserial.armasjug[2] == true && tiempodisp > 0.2f)
					{
						
						if(manager.datosserial.armasjug[0])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}


						armaimg[3].color = new Color(1,1,1,1f);
						backarmaimg[3].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 4;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 0;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[2];
						if(manager.datosserial.armasjug[0] == true)
						{armaimg[0].sprite = armasspriteequipada[0];}
						else
						{
							armaimg[0].sprite = nopimg;
							backarmaimg[0].sprite = nopimg;
						}
						
						cambiar_modelo_arma();
						pistolamodels[2].SetActive(true);
					}
				}
			}
			if(ruletainterior == 1)
			{

				comandoarma.text = "Armas 2";
				if(manager.datosserial.armasjug[4] == true)
				{
					armaimg[0].fillAmount = manager.datosserial.armasmun[4]/manager.datosserial.armasmun_max[4];
					circuloarmaimg[0].fillAmount = manager.datosserial.armasmun[4]/manager.datosserial.armasmun_max[4];
				}
				if(manager.datosserial.armasjug[5] == true)
				{
					armaimg[1].fillAmount = manager.datosserial.armasmun[5]/manager.datosserial.armasmun_max[5];
					circuloarmaimg[1].fillAmount = manager.datosserial.armasmun[5]/manager.datosserial.armasmun_max[5];
				}
				if(manager.datosserial.armasjug[6] == true)
				{
					armaimg[2].fillAmount = manager.datosserial.armasmun[6]/manager.datosserial.armasmun_max[6];
					circuloarmaimg[2].fillAmount = manager.datosserial.armasmun[6]/manager.datosserial.armasmun_max[6];
				}
				if(manager.datosserial.armasjug[7] == true)
				{
					armaimg[3].fillAmount = manager.datosserial.armasmun[7]/manager.datosserial.armasmun_max[7];
					circuloarmaimg[3].fillAmount = manager.datosserial.armasmun[7]/manager.datosserial.armasmun_max[7];
				}
				if(cambioruedaact == 0)
				{
					numpoct.text = "";
					numpoc1t.text = "";
					numpoc2t.text = "";
					numpoc3t.text = "";
					numpoc4t.text = "";
					
					if(manager.datosserial.armasjug[4] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 5)
						{

							armaimg[0].sprite = armasspriterueda[4];

							
							armaimg[0].color = new Color(1,1,1,1);
							backarmaimg[0].sprite = armasspriterueda[4];
						}
						else
						{
							armaimg[0].sprite = armasspriterueda[4];
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].sprite = armasspriterueda[4];
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

					}

					if(manager.datosserial.armasjug[5] == false)
					{
						armaimg[1].sprite = nopimg;
						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 6)
						{

							armaimg[1].sprite = armasspriterueda[5];

							
							armaimg[1].color = new Color(1,1,1,1);
							backarmaimg[1].sprite = armasspriterueda[5];
						}
						else
						{
							armaimg[1].sprite = armasspriterueda[5];
							armaimg[1].color = new Color(1,1,1,0.1f);
							backarmaimg[1].sprite = armasspriterueda[5];
						}

					}
					if(manager.datosserial.armasjug[6] == false)
					{
						armaimg[2].sprite = nopimg;
						armaimg[2].color = new Color(1,1,1,1);
						backarmaimg[2].sprite = nopimg;
						
					}
					else
					{
						if(manager.datosserial.armasel == 7)
						{
							armaimg[2].sprite = armasspriterueda[6];
							armaimg[2].color = new Color(1,1,1,1);
							backarmaimg[2].sprite = armasspriterueda[6];

						}
						else
						{
							armaimg[2].sprite = armasspriterueda[6];
							armaimg[2].color = new Color(1,1,1,0.1f);
							backarmaimg[2].sprite = armasspriterueda[6];

						}
					}
					if(manager.datosserial.armasjug[7] == false)
					{
						armaimg[3].sprite = nopimg;
						armaimg[3].color = new Color(1,1,1,1);
						backarmaimg[3].sprite = nopimg;
					}
					else
					{
						if(manager.datosserial.armasel == 8)
						{
							armaimg[3].sprite = armasspriterueda[7];
							armaimg[3].color = new Color(1,1,1,1);
							backarmaimg[3].sprite = armasspriterueda[7];
						}
						else
						{
							armaimg[3].sprite = armasspriterueda[7];
							armaimg[3].color = new Color(1,1,1,0.1f);
							backarmaimg[3].sprite = armasspriterueda[7];
						}
					}
					
					
					cambioruedaact = 1;
				}


				if(ruletaYc > 0f )
				{
					if(manager.datosserial.armasjug[4] == true && tiempodisp > 0.2f)
					{
						armaname.text = "CopiaEspejo";
						if(manager.datosserial.armasjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[0].color = new Color(1,1,1,1f);
						backarmaimg[0].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 5;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 1;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[4];

						cambiar_modelo_arma();
						pistolamodels[4].SetActive(true);
						
					}
				}	
				if(ruletaXc > 0f )
				{
					armaname.text = "Generador de Pulsos";
					if(manager.datosserial.armasjug[5] == true && tiempodisp > 0.2f)
					{
						armaimg[1].color = new Color(1,1,1,1f);


						if(manager.datosserial.armasjug[4])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						
						armaimg[1].color = new Color(1,1,1,1f);
						backarmaimg[1].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 6;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 1;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[5];
						cambiar_modelo_arma();
						pistolamodels[5].SetActive(true);
					}
				}
				if(ruletaYc < 0f )
				{
					armaname.text = "RataTaPUM V1";
					
					if(manager.datosserial.armasjug[6] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.armasjug[4])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[2].color = new Color(1,1,1,1f);
						backarmaimg[2].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 7;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 1;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[6];
						cambiar_modelo_arma();
						pistolamodels[6].SetActive(true);
						
					}
				}
				if(ruletaXc < -0f )
				{
					armaname.text = " Carnicera";
					if(manager.datosserial.armasjug[7] == true && tiempodisp > 0.2f)
					{
						
						if(manager.datosserial.armasjug[4])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}


						armaimg[3].color = new Color(1,1,1,1f);
						backarmaimg[3].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 8;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 1;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[7];
						cambiar_modelo_arma();
						pistolamodels[7].SetActive(true);
					}
				}
			}
			if(ruletainterior == 2)
			{
				comandoarma.text = "Armas 3";
				if(manager.datosserial.armasjug[8] == true)
				{
					armaimg[0].fillAmount = manager.datosserial.armasmun[8]/manager.datosserial.armasmun_max[8];
					circuloarmaimg[0].fillAmount = manager.datosserial.armasmun[8]/manager.datosserial.armasmun_max[8];
				}
				if(manager.datosserial.armasjug[9] == true)
				{
					armaimg[1].fillAmount = manager.datosserial.armasmun[9]/manager.datosserial.armasmun_max[9];
					circuloarmaimg[1].fillAmount = manager.datosserial.armasmun[9]/manager.datosserial.armasmun_max[9];
				}
				if(manager.datosserial.armasjug[10] == true)
				{
					armaimg[2].fillAmount = manager.datosserial.armasmun[10]/manager.datosserial.armasmun_max[10];
					circuloarmaimg[2].fillAmount = manager.datosserial.armasmun[10]/manager.datosserial.armasmun_max[10];
				}
				if(manager.datosserial.armasjug[11] == true)
				{
					armaimg[3].fillAmount = manager.datosserial.armasmun[11]/manager.datosserial.armasmun_max[11];
					circuloarmaimg[3].fillAmount = manager.datosserial.armasmun[11]/manager.datosserial.armasmun_max[11];
				}
				if(cambioruedaact == 0)
				{
					numpoct.text = "";
					numpoc1t.text = "";
					numpoc2t.text = "";
					numpoc3t.text = "";
					numpoc4t.text = "";
					
					if(manager.datosserial.armasjug[8] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 9)
						{

							armaimg[0].sprite = armasspriterueda[8];

							
							armaimg[0].color = new Color(1,1,1,1);
							backarmaimg[0].sprite = armasspriterueda[8];
						}
						else
						{
							armaimg[0].sprite = armasspriterueda[8];
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].sprite = armasspriterueda[8];
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

					}

					if(manager.datosserial.armasjug[9] == false)
					{
						armaimg[1].sprite = nopimg;
						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 10)
						{

							armaimg[1].sprite = armasspriterueda[9];		
							armaimg[1].color = new Color(1,1,1,1);
							backarmaimg[1].sprite = armasspriterueda[9];
						}
						else
						{
							armaimg[1].sprite = armasspriterueda[9];
							armaimg[1].color = new Color(1,1,1,0.1f);
							backarmaimg[1].sprite = armasspriterueda[9];
						}

					}
					if(manager.datosserial.armasjug[10] == false)
					{
						armaimg[2].sprite = nopimg;
						armaimg[2].color = new Color(1,1,1,1);
						backarmaimg[2].sprite = nopimg;
						
					}
					else
					{
						if(manager.datosserial.armasel == 11)
						{
							armaimg[2].sprite = armasspriterueda[10];
							armaimg[2].color = new Color(1,1,1,1);
							backarmaimg[2].sprite = armasspriterueda[10];

						}
						else
						{
							armaimg[2].sprite = armasspriterueda[10];
							armaimg[2].color = new Color(1,1,1,0.1f);
							backarmaimg[2].sprite = armasspriterueda[10];

						}
					}
					if(manager.datosserial.armasjug[11] == false)
					{
						armaimg[3].sprite = nopimg;
						armaimg[3].color = new Color(1,1,1,1);
						backarmaimg[3].sprite = nopimg;
					}
					else
					{
						if(manager.datosserial.armasel == 12)
						{
							armaimg[3].sprite = armasspriterueda[11];
							armaimg[3].color = new Color(1,1,1,1);
							backarmaimg[3].sprite = armasspriterueda[11];
						}
						else
						{
							armaimg[3].sprite = armasspriterueda[11];
							armaimg[3].color = new Color(1,1,1,0.1f);
							backarmaimg[3].sprite = armasspriterueda[11];
						}
					}
					
					
					cambioruedaact = 1;
				}
				if(ruletaYc > 0f )
				{
					armaname.text = "Matasuegras";
					if(manager.datosserial.armasjug[8] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.armasjug[10])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[11])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[9])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[0].color = new Color(1,1,1,1f);
						backarmaimg[0].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 9;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 2;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[8];

						cambiar_modelo_arma();
						pistolamodels[8].SetActive(true);
						
					}
				}	
				if(ruletaXc > 0f )
				{
					if(manager.datosserial.armasjug[9] == true && tiempodisp > 0.2f)
					{
						armaname.text = "Mina Guardian V1";
						armaimg[1].color = new Color(1,1,1,1f);


						if(manager.datosserial.armasjug[8])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}
						

						if(manager.datosserial.armasjug[11])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[10])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						
						armaimg[1].color = new Color(1,1,1,1f);
						backarmaimg[1].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 10;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 2;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[9];
						cambiar_modelo_arma();
						pistolamodels[9].SetActive(true);
					}
				}
				if(ruletaYc < 0f )
				{
					armaname.text = "SantosCielos";
					
					if(manager.datosserial.armasjug[10] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.armasjug[8])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[11])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[9])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[2].color = new Color(1,1,1,1f);
						backarmaimg[2].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 11;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 2;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[10];
						cambiar_modelo_arma();
						pistolamodels[10].SetActive(true);
						
					}
				}
				if(ruletaXc < -0f )
				{
					armaname.text = "S/C egadora";
					if(manager.datosserial.armasjug[11] == true && tiempodisp > 0.2f)
					{
						
						if(manager.datosserial.armasjug[8])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.armasjug[9])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[10])
						{armaimg[2].color = new Color(1,1,1,0.1f);}


						armaimg[3].color = new Color(1,1,1,1f);
						backarmaimg[3].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 12;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_armas = 2;
						manager.datosserial.ruletatipo_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[11];
						cambiar_modelo_arma();
						pistolamodels[11].SetActive(true);
					}
				}
			}
		}
		if(ruletas == 1 && tiendat == false)
		{
			if(ruletac > 0 && tiempodisp > 0.2f)
			{
				ruletainterior++;
				if(ruletainterior >= 2)
				{ruletainterior = 0;}
				cambioruedaact = 0;
				tiempodisp = 0;
				
			}
			if(ruletainterior == 0)
			{
				comandoarma.text = "Artilugios 1";
				if(manager.datosserial.artilugiosjug[0] == true)
				{
					armaimg[0].fillAmount = 1;
					circuloarmaimg[0].fillAmount = 1;
				}
				if(manager.datosserial.artilugiosjug[1] == true)
				{
					armaimg[1].fillAmount = 1;
					circuloarmaimg[1].fillAmount = 1;
				}
				if(manager.datosserial.artilugiosjug[2] == true)
				{
					armaimg[2].fillAmount = 1;
					circuloarmaimg[2].fillAmount = 1;
				}
				if(manager.datosserial.artilugiosjug[3] == true)
				{
					armaimg[3].fillAmount = 1;
					circuloarmaimg[3].fillAmount = 1;
				}
				if(cambioruedaact == 0)
				{
					numpoct.text = "";
					numpoc1t.text = "";
					numpoc2t.text = "";
					numpoc3t.text = "";
					numpoc4t.text = "";
					
					if(manager.datosserial.artilugiosjug[0] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 101)
						{

							armaimg[0].sprite = artilugiosrueda[0];

							
							armaimg[0].color = new Color(1,1,1,1);
							backarmaimg[0].sprite = artilugiosrueda[0];
						}
						else
						{
							armaimg[0].sprite = artilugiosrueda[0];
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].sprite = artilugiosrueda[0];
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

					}

					if(manager.datosserial.artilugiosjug[1] == false)
					{
						armaimg[1].sprite = nopimg;
						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 102)
						{

							armaimg[1].sprite = artilugiosrueda[1];	
							armaimg[1].color = new Color(1,1,1,1);
							backarmaimg[1].sprite = artilugiosrueda[1];
						}
						else
						{
							armaimg[1].sprite = artilugiosrueda[1];
							armaimg[1].color = new Color(1,1,1,0.1f);
							backarmaimg[1].sprite = artilugiosrueda[1];
						}

					}
					if(manager.datosserial.artilugiosjug[2] == false)
					{
						armaimg[2].sprite = nopimg;
						armaimg[2].color = new Color(1,1,1,1);
						backarmaimg[2].sprite = nopimg;
						
					}
					else
					{
						if(manager.datosserial.armasel == 103)
						{
							armaimg[2].sprite = artilugiosrueda[2];
							armaimg[2].color = new Color(1,1,1,1);
							backarmaimg[2].sprite = artilugiosrueda[2];

						}
						else
						{
							armaimg[2].sprite = artilugiosrueda[2];
							armaimg[2].color = new Color(1,1,1,0.1f);
							backarmaimg[2].sprite = artilugiosrueda[2];

						}
					}
					if(manager.datosserial.artilugiosjug[3] == false)
					{
						armaimg[3].sprite = nopimg;
						armaimg[3].color = new Color(1,1,1,1);
						backarmaimg[3].sprite = nopimg;
					}
					else
					{
						if(manager.datosserial.armasel == 104)
						{
							armaimg[3].sprite = artilugiosrueda[3];
							armaimg[3].color = new Color(1,1,1,1);
							backarmaimg[3].sprite = artilugiosrueda[3];
						}
						else
						{
							armaimg[3].sprite = artilugiosrueda[3];
							armaimg[3].color = new Color(1,1,1,0.1f);
							backarmaimg[3].sprite = artilugiosrueda[3];
						}
					}
					
					
					cambioruedaact = 1;
				}
				if(ruletaYc > 0f  && skate == false)
				{
					armaname.text = "Hypertabla";
					if(manager.datosserial.artilugiosjug[0] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.artilugiosjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[3])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[0].color = new Color(1,1,1,1f);
						backarmaimg[0].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 101;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios = 0;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[0];

						cambiar_modelo_arma();
						
					}
				}	
				if(ruletaXc > 0f  && skate == false)
				{
					if(manager.datosserial.artilugiosjug[0] == true && tiempodisp > 0.2f)
					{
						armaname.text = "Caña de Pesca";
						armaimg[1].color = new Color(1,1,1,1f);


						if(manager.datosserial.artilugiosjug[0])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}
						

						if(manager.datosserial.artilugiosjug[3])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						
						armaimg[1].color = new Color(1,1,1,1f);
						backarmaimg[1].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 102;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios = 0;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[1];
						cambiar_modelo_arma();
						pistolamodels[13].SetActive(true);
					}
				}
				if(ruletaYc < 0f  && skate == false)
				{
					armaname.text = "CortaReflejos";
					if(manager.datosserial.artilugiosjug[2] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.artilugiosjug[0])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.artilugiosjug[3])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[2].color = new Color(1,1,1,1f);
						backarmaimg[2].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 103;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios = 0;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[2];
						cambiar_modelo_arma();
						pistolamodels[14].SetActive(true);
						
					}
				}
				if(ruletaXc < -0f  && skate == false)
				{
					if(manager.datosserial.artilugiosjug[3] == true && tiempodisp > 0.2f)
					{
						armaname.text = "Mano Obrera";
						
						if(manager.datosserial.artilugiosjug[0])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.artilugiosjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}


						armaimg[3].color = new Color(1,1,1,1f);
						backarmaimg[3].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 104;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios = 0;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[3];
						cambiar_modelo_arma();
						pistolamodels[15].SetActive(true);
					}
				}


			}
			if(ruletainterior == 1)
			{
				comandoarma.text = "Artilugios 2";
				if(manager.datosserial.artilugiosjug[4] == true)
				{
					armaimg[0].fillAmount = manager.datosserial.artilugiosmun[4]/manager.datosserial.artilugiosmun_max[4];
					circuloarmaimg[0].fillAmount = manager.datosserial.artilugiosmun[4]/manager.datosserial.artilugiosmun_max[4];
				}
				if(manager.datosserial.artilugiosjug[5] == true)
				{
					armaimg[1].fillAmount = manager.datosserial.artilugiosmun[5]/manager.datosserial.artilugiosmun_max[5];
					circuloarmaimg[1].fillAmount = manager.datosserial.artilugiosmun[5]/manager.datosserial.artilugiosmun_max[5];
				}
				if(manager.datosserial.artilugiosjug[6] == true)
				{
					armaimg[2].fillAmount = 1;
					circuloarmaimg[2].fillAmount = 1;
				}
				if(manager.datosserial.artilugiosjug[7] == true)
				{
					armaimg[3].fillAmount = 1;
					circuloarmaimg[3].fillAmount = 1;
				}
				if(cambioruedaact == 0)
				{
					numpoct.text = "";
					numpoc1t.text = "";
					numpoc2t.text = "";
					numpoc3t.text = "";
					numpoc4t.text = "";
					
					if(manager.datosserial.artilugiosjug[4] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 105)
						{

							armaimg[0].sprite = artilugiosrueda[4];

							
							armaimg[0].color = new Color(1,1,1,1);
							backarmaimg[0].sprite = artilugiosrueda[0];
						}
						else
						{
							armaimg[0].sprite = artilugiosrueda[4];
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].sprite = artilugiosrueda[4];
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

					}

					if(manager.datosserial.artilugiosjug[5] == false)
					{
						armaimg[1].sprite = nopimg;
						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].sprite = nopimg;
					}
					else 
					{
						if(manager.datosserial.armasel == 106)
						{

							armaimg[1].sprite = artilugiosrueda[5];	
							armaimg[1].color = new Color(1,1,1,1);
							backarmaimg[1].sprite = artilugiosrueda[5];
						}
						else
						{
							armaimg[1].sprite = artilugiosrueda[5];
							armaimg[1].color = new Color(1,1,1,0.1f);
							backarmaimg[1].sprite = artilugiosrueda[5];
						}

					}
					if(manager.datosserial.artilugiosjug[6] == false)
					{
						armaimg[2].sprite = nopimg;
						armaimg[2].color = new Color(1,1,1,1);
						backarmaimg[2].sprite = nopimg;
						
					}
					else
					{
						if(manager.datosserial.armasel == 107)
						{
							armaimg[2].sprite = artilugiosrueda[6];
							armaimg[2].color = new Color(1,1,1,1);
							backarmaimg[2].sprite =artilugiosrueda[6];

						}
						else
						{
							armaimg[2].sprite = artilugiosrueda[6];
							armaimg[2].color = new Color(1,1,1,0.1f);
							backarmaimg[2].sprite = artilugiosrueda[6];

						}
					}
					if(manager.datosserial.artilugiosjug[7] == false )
					{
						armaimg[3].sprite = nopimg;
						armaimg[3].color = new Color(1,1,1,1);
						backarmaimg[3].sprite = nopimg;
					}
					else
					{
						if(manager.datosserial.armasel == 108)
						{
							armaimg[3].sprite = artilugiosrueda[7];
							armaimg[3].color = new Color(1,1,1,1);
							backarmaimg[3].sprite = artilugiosrueda[7];
						}
						else
						{
							armaimg[3].sprite = artilugiosrueda[7];
							armaimg[3].color = new Color(1,1,1,0.1f);
							backarmaimg[3].sprite = artilugiosrueda[7];
						}
					}
					
					
					cambioruedaact = 1;
				}
				if(ruletaYc > 0f  && skate == false)
				{
					armaname.text = "Arcana Modo 1";
					if(manager.datosserial.artilugiosjug[4] == true && tiempodisp > 0.2f)
					{
						if(manager.datosserial.artilugiosjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[0].color = new Color(1,1,1,1f);
						backarmaimg[0].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 105;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios= 1;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[4];

						cambiar_modelo_arma();
						pistolamodels[16].SetActive(true);
						
					}
				}	
				if(ruletaXc > 0f  && skate == false)
				{
					if(manager.datosserial.artilugiosjug[5] == true && tiempodisp > 0.2f)
					{
						armaname.text = "Arcana Modo 2";
						armaimg[1].color = new Color(1,1,1,1f);


						if(manager.datosserial.artilugiosjug[4])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}
						

						if(manager.datosserial.artilugiosjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						
						armaimg[1].color = new Color(1,1,1,1f);
						backarmaimg[1].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 106;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios= 1;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[5];
						cambiar_modelo_arma();
						pistolamodels[17].SetActive(true);
					}
				}
				if(ruletaYc < 0f  && skate == false)
				{
					
					if(manager.datosserial.artilugiosjug[6] == true && tiempodisp > 0.2f)
					{
						armaname.text = "Mando de la Nave";
						if(manager.datosserial.artilugiosjug[4])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.artilugiosjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[2].color = new Color(1,1,1,1f);
						backarmaimg[2].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						manager.datosserial.armasel = 107;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios = 1;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[6];
						cambiar_modelo_arma();
						
					}
				}
				if(ruletaXc < -0f  && skate == false)
				{
					armaname.text = "Persusora";
					if(manager.datosserial.artilugiosjug[7] == true && tiempodisp > 0.2f)
					{
						
						if(manager.datosserial.artilugiosjug[4])
						{
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].color = new Color(1,1,1,0.3f);
						}

						if(manager.datosserial.artilugiosjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.artilugiosjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}


						armaimg[3].color = new Color(1,1,1,1f);
						backarmaimg[3].color = new Color(1,1,1,0.3f);

						
						tiempodisp = 0;
						manager.datosserial.armasel = 108;
						manager.datosserial.palosel = 1;
						manager.datosserial.ruletainterior_artilugios= 1;
						manager.datosserial.ruletatipo_armas = 1;
						manager.guardar();
						iconodisp.sprite = artilugiosequipados[7];
						cambiar_modelo_arma();
						pistolamodels[19].SetActive(true);
					}
				}
			}
		}
		if(ruletas == 2 && tiendat == false)
		{
			comandoarma.text = "Pociones";

			circuloarmaimg[0].fillAmount = 1;
			circuloarmaimg[1].fillAmount = 1;
			circuloarmaimg[2].fillAmount = 1;
			circuloarmaimg[3].fillAmount = 1;
			armaimg[0].fillAmount = 1;
			armaimg[1].fillAmount = 1;
			armaimg[2].fillAmount = 1;
			armaimg[3].fillAmount = 1;

			if(cambioruedaact == 0)
			{
				armaimg[0].color = new Color(1,1,1,1);
				armaimg[1].color = new Color(1,1,1,1);
				armaimg[3].color = new Color(1,1,1,1);
				armaimg[2].color = new Color(1,1,1,1);

				if(manager.datosserial.pocionesmax >=1)
				{
					numpoc1t.text = "1";

					armaimg[0].sprite = pocionsprite[0];
					backarmaimg[0].sprite = pocionsprite[0];
				}
				else
				{
					numpoc1t.text = "";

					armaimg[0].sprite = nopimg;
					backarmaimg[0].sprite = pocionsprite[0];

				}
				if(manager.datosserial.pocionesmax >= 3)
				{
					numpoc4t.text = "3";


					armaimg[1].sprite = pocionsprite[2];
					backarmaimg[1].sprite = pocionsprite[2];
				}
				else
				{
					numpoc4t.text = "";
					armaimg[1].sprite = nopimg;
					backarmaimg[1].sprite = pocionsprite[2];
				}
				if(manager.datosserial.pocionesmax >=2)
				{

					numpoc2t.text = "2";


					armaimg[2].sprite = pocionsprite[1];
					backarmaimg[2].sprite = pocionsprite[1];
				}
				else
				{

					numpoc2t.text = "";


					armaimg[2].sprite = nopimg;
					backarmaimg[2].sprite = pocionsprite[1];
				}

				if(manager.datosserial.pocionesmax >= 4)
				{
					numpoc3t.text = "4";



					armaimg[3].sprite = pocionsprite[3];
					backarmaimg[3].sprite = pocionsprite[3];
				}
				else
				{
					numpoc3t.text = "";

					armaimg[3].sprite = nopimg;
					backarmaimg[3].sprite = pocionsprite[3];
				}

				

				

				

				


				
				
				cambioruedaact = 1;
			}


			numpoct.text = manager.datosserial.pociones.ToString();
			if(ruletaYc > 0f )
			{
				if(tiempodisp > 0.5f && manager.datosserial.pociones >= 1 &&  vida < vidamax)
				{
					manager.datosserial.pociones -= 1;
					tragar.Play();
					vida += vidamax/3.3f;
					if(vida > vidamax)
					{
						vida = vidamax;
					}
				}
			}

			if(ruletaYc < 0f )
			{
				if(tiempodisp > 0.5f && manager.datosserial.pociones >= 2 && inbuiract == false && tempinbuir  == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f && controlact == true)
				{	

						manager.datosserial.pociones -= 3;
						tiempodisp = 0;
						anim.Play("inbuir");
						anim.Play("inbuirmant");
						tempatk = 0;
						inbuir.Play();
						danoextra += 1;
						inbuiract = true;
						tempinbuir = 30;
						manager.guardar();
					
				}
			}
			if(ruletaXc > 0f )
			{
				if(tiempodisp > 0.5f && manager.datosserial.pociones >= 3 )
				{
					manager.datosserial.pociones -= 3;
					manager.datosserial.armasmun = manager.datosserial.armasmun_max;
					manager.guardar();
				}
			}
			if(ruletaXc < 0f )
			{
				if(tiempodisp > 0.5f && manager.datosserial.pociones >= 4 && tempberserk == 0)
				{
					tragar.Play();
					manager.datosserial.pociones -= 4;
					tempberserk = 20;
					vidaberserk = vida;
					danoextra += 2;
					berserkfin = true;
					
				}
			}



		}
		if(tempberserk > 0)
		{
			vida = vidaberserk;
			
		}
		else if(tempberserk == 0 && berserkfin == true)
		{
			danoextra += -2;
			berserkfin = false;
		}

		if(tempinbuir == 0 && inbuiract == true)
		{
			danoextra += -1;
			inbuiract = false;
			inbuir.Play();
		}

	
	

		
		
		



		if (this.tiempovelint > 1 && suelo == false && velact == true)
		{
			
			velocidad = velocidadaux;
			tiempovelint = 0;
			velact = false;
			
			
		}
		else if (this.tiempovelint > 2 && suelo == true && velact == true)
		{
			velocidad = velocidadaux;
			tiempovelint = 0;
			velact = false;
		}
		else if(velact == true)
		{
			this.tiempovel += Time.deltaTime;
			this.tiempovelint = (int)this.tiempovel;
			
		}
		










		




			
			if(marcarc > 0 && temp10 > 0.2f)
			{
				escudoeneact = false;
				temp10 = 0;
				if(indicetarget == -1)
				{
					if(tarbossact)
					{
						indicetarget = 3;
						objetivotarget = tarboss;
						vidaenebarra.SetActive(false);
					}
					else if(target[0] != null)
					{
						indicetarget = 0;
						objetivotarget = target[0];
						vidaenebarra.SetActive(true);
					}
					else
					{
						indicetarget = -1;
						objetivotarget = null;
						vidaenebarra.SetActive(false);
					}
				}
				else if(indicetarget != -1)
				{
					indicetarget = -1;
					objetivotarget = null;
					objetivotarget2 = null;
					vidaenebarra.SetActive(false);
				
				}
				if(objetivotarget == tarboss && tarbossact && objetivotarget != null)
				{findchild(tarboss,true,"selectar");}
				else if(objetivotarget != tarboss && tarbossact)
				{findchild(tarboss,false,"selectar");}
			}
			else if(indicetarget != -1)
			{
				if(camXc > 0 && temp10 > 0.7f)
				{
					escudoeneact = false;
					temp10 = 0;
					if(indicetarget == 3)
					{
						objetivotarget = tarboss;
						if(target[0] != null)
						{
							indicetarget = 0;
							objetivotarget = target[0];
							vidaenebarra.SetActive(true);
						}
						else if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);
						}
			
					}
					else if(indicetarget == 0)
					{
						objetivotarget = target[0];
						if(target[1] != null)
						{
							indicetarget = 1;
							objetivotarget = target[1];
							vidaenebarra.SetActive(true);
						}
						else if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);
						}

					}
					else if(indicetarget == 1)
					{
						objetivotarget = target[1];
						if(target[2] != null)
						{
							indicetarget = 2;
							objetivotarget = target[2];
							vidaenebarra.SetActive(true);
						}
						else if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);
						}

					}
					else if(indicetarget == 2)
					{
						if(tarbossact)
						{

							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);

						}
						else if(target[0] != null)
						{
							indicetarget = 0;
							objetivotarget = target[0];
							vidaenebarra.SetActive(true);
						}

					}
					if(objetivotarget == tarboss && tarbossact && objetivotarget != null)
					{findchild(tarboss,true,"selectar");}
					else if(objetivotarget != tarboss && tarbossact)
					{findchild(tarboss,false,"selectar");}
				}
				else if(camXc < 0 && temp10 > 0.7f)
				{
					escudoeneact = false;
					temp10 = 0;
					if(indicetarget == 3)
					{
						objetivotarget = tarboss;
						if(target[2] != null)
						{
							indicetarget = 2;
							objetivotarget = target[2];
							vidaenebarra.SetActive(true);
						}
						else if(target[1] != null)
						{
							indicetarget = 1;
							objetivotarget = target[1];
							vidaenebarra.SetActive(true);
						}
						else if(target[0] != null)
						{
							indicetarget = 0;
							objetivotarget = target[0];
							vidaenebarra.SetActive(true);
						}
						else if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);
						}
			
					}
					else if(indicetarget == 0)
					{
						objetivotarget = target[0];
						if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);
						}
						else if(target[2] != null)
						{
							indicetarget = 2;
							objetivotarget = target[2];
							vidaenebarra.SetActive(true);
						}
						else if(target[1] != null)
						{
							indicetarget = 1;
							objetivotarget = target[1];
							vidaenebarra.SetActive(true);
						}
						else if(target[0] != null)
						{
							indicetarget = 0;
							objetivotarget = target[0];
							vidaenebarra.SetActive(true);
						}

					}
					else if(indicetarget == 1)
					{
						objetivotarget = target[1];
						if(target[0] != null)
						{
							indicetarget = 0;
							objetivotarget = target[0];
							vidaenebarra.SetActive(true);
						}
						else if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);
						}
						else if(target[2] != null)
						{
							indicetarget = 2;
							objetivotarget = target[2];
							vidaenebarra.SetActive(true);
						}
						else if(target[1] != null)
						{
							indicetarget = 1;
							objetivotarget = target[1];
							vidaenebarra.SetActive(true);
						}
						

					}
					else if(indicetarget == 2)
					{
						objetivotarget = target[2];
						if(target[1] != null)
						{
							indicetarget = 1;
							objetivotarget = target[1];
							vidaenebarra.SetActive(true);
						}
						else if(target[0] != null)
						{
							indicetarget = 0;
							objetivotarget = target[0];
							vidaenebarra.SetActive(true);
						}
						else if(tarbossact)
						{
							indicetarget = 3;
							objetivotarget = tarboss;
							vidaenebarra.SetActive(false);

						}
						else if(target[2] != null)
						{
							indicetarget = 2;
							objetivotarget = target[2];
							vidaenebarra.SetActive(true);
						}
						if(objetivotarget == tarboss && tarbossact && objetivotarget != null)
						{findchild(tarboss,true,"selectar");}
						else if(objetivotarget != tarboss && tarbossact)
						{findchild(tarboss,false,"selectar");}
					}
				}				
				
			}
		
		
			camarascript.maxdis = 20;
			
			
		if(skate == false)	
		{
			

			movskate = false;
			if(lateralc == 0 && controlact == true)
            {

				anim.SetBool("movlat",false);
				anim.SetBool("latizq",false);
                anim.SetBool("latder",false);
                anim.SetBool("saltoatras",false);



				if(subir == false && bajar == false)
				{
					anim.SetFloat("velx",movXc);
					anim.SetFloat("vely",movYc);
					if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
					{
						movXc = 0;
						movYc = 0;
					}
					

					Vector3 movdirnow = new Vector3 (movXc,0, movYc).normalized;




						if (jugadorEntrando == true)
						{
								
								boxcam2.transform.localRotation = Quaternion.Euler(0.35f, 0, 0);
								this.jugadorEntrando = false;
						}				
						
						if(movXc != 0 || movYc != 0)
						{

							movPH = true;
							
							// Rotar el modelo en la dirección del movimiento
							angulomod = Mathf.Atan2(movXc, movYc) * Mathf.Rad2Deg;
							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
																		Quaternion.Euler(mod.transform.localEulerAngles.x, angulomod, mod.transform.localEulerAngles.z),
																		10 * Time.deltaTime);
							
							// Rotar el personaje para que mire en la dirección de la cámara
							float camaraYRotation = camara.transform.eulerAngles.y;
							transform.rotation = Quaternion.Slerp(transform.rotation, 
																Quaternion.Euler(0, camaraYRotation, 0),
																1 * Time.deltaTime);
						}
						else
						{
							movPH = false;
						}
						
						// Gradualmente volver a la rotación normal cuando no está en modo planeta
						Quaternion rotacionNormal = Quaternion.Euler(0, transform.eulerAngles.y, 0);
						transform.rotation = Quaternion.Slerp(transform.rotation, rotacionNormal, Time.fixedDeltaTime * 3f);

						
						
						
						
						movdire = transform.TransformDirection(movdirnow * velocidad);
						float distaxe = movdire.magnitude * Time.fixedDeltaTime;
						movdire.Normalize();
						RaycastHit hit;
						Vector3 moveDirection = new Vector3(movXc, 0, movYc).normalized;

						
						
						if(movYc == 0f && movXc == 0f)
						{
							anim.SetBool("stat",true);
							dashefect = false;
							_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
						}
						else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity)&& dashefect == true)
						{
							if(hit.distance < 1f)
							{
							anim.SetBool("stat",true);
							dashefect = false;
							dashefect2 = false;
							}
							else
							{
								anim.SetBool("stat",false);
							}
							Debug.Log(hit.distance);
						}
						else
						{
							anim.SetBool("stat",false);
						}
						
						

						if(suelo == true && movYc < 0f || suelo == true && movYc > 0f || suelo == true && movXc < 0f|| suelo == true && movXc > 0f)
						{
							if(temppaso > pasotiempo)
							{
								randompaso = UnityEngine.Random.Range(1,3);
								if(randompaso == 1)
								{
									pasos1.Play();
								}
								if(randompaso == 2)
								{
									pasos2.Play();
								}
								temppaso = 0;
								pasotiempo = UnityEngine.Random.Range(0.4f,0.6f);
							}
							if(temppaso < 15)
							{temppaso += 1 * Time.deltaTime;}
						}

						if(objetivotarget == null)
						{
						if(camXc != 0)
						{rotationinput.x = camXc * rotspeed * Time.deltaTime;}
						else{rotationinput.x = 0;}
						}

						if(camYc != 0)
						{rotationinput.y = camYc * rotspeed * Time.deltaTime;}
						else{rotationinput.y = 0;}
						Debug.Log("camara");
						

							Vector3 horcam = Vector3.up * rotationinput.x;
							Vector3 vercam = new Vector3(0,0,0);

							
							vercam = Vector3.right * -rotationinput.y;

						
							camara.transform.localEulerAngles += vercam + horcam;

						Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
						float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
						float fixedAngle_f = angle_f;
						if (xRotationx.eulerAngles.x>180)
						{
							fixedAngle_f *= -1;
						}
						float clampedX = Mathf.Clamp(fixedAngle_f, -20, 50);
						camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);
						

						if(objetivotarget != null)
						{
							Vector3 directiontt = objetivotarget.transform.position - transform.position;
							Quaternion rotation = Quaternion.LookRotation(directiontt);
							transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),30f * Time.deltaTime);
							camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
						}


						camaux = camara.transform.eulerAngles.y;
						if(objetivotarget == null)
						{

							if (movXc != 0f && camXc != 0f|| movYc != 0 && camXc != 0f || movXc != 0f || movYc != 0)
							{
								transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
								camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
							}
								


						}
					

					

						

				}
					
				


				

			}
			else if(lateralc > 0 && controlact == true)
            {
				
				
				camarascript.maxdis = 20;
				anim.SetBool("movlat",true);
                camnomov = false;
				anim.SetFloat("velx",movXc);
				anim.SetFloat("vely",movYc);
				if(subir == false && bajar == false)
				{
					if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
					{
						movXc = 0;
						movYc = 0;
					}

					Vector3 movdirnow = new Vector3 (movXc,0, movYc).normalized;
					if(movXc != 0 || movYc != 0)
					{

						movPH = true;

						angulomod =  Mathf.Atan2(movXc,movYc)* Mathf.Rad2Deg;


						if(dash + 0.5f > tempdash)
						{
							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(mod.transform.localEulerAngles.x,angulomod,mod.transform.localEulerAngles.z),10* Time.deltaTime);
						}
						else
						{
							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(mod.transform.localEulerAngles.x,0,mod.transform.localEulerAngles.z),10* Time.deltaTime);
						}

						
						
					}
					else
					{
						movPH = false;
					}
					movdire = transform.TransformDirection(movdirnow * velocidad);
					float distaxe = movdire.magnitude * Time.fixedDeltaTime;
					movdire.Normalize();
					RaycastHit hit;

					if(movYc == 0f && movXc == 0f)
					{
						anim.SetBool("stat",true);
						dashefect = false;
						dashefect2 = false;
						_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
					}
					else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity)&& dashefect == true)
					{
						if(hit.distance < 1f)
						{
						anim.SetBool("stat",true);
						dashefect = false;
						dashefect2 = false;
						}
						else
						{
							anim.SetBool("stat",false);
						}
						Debug.Log(hit.distance);
					}
					else
					{
						anim.SetBool("stat",false);
					}


					


					if (movXc >= 0.70f)
					{
						anim.SetBool("latder",true);
						anim.SetBool("latizq",false);
						anim.SetBool("saltoatras",false);
					}
					else if (movXc <= -0.70f)
					{
						anim.SetBool("latizq",true);
						anim.SetBool("latder",false);
						anim.SetBool("saltoatras",false);
					}
					else if (movYc <= -0.70f)
					{
						anim.SetBool("saltoatras",true);
						anim.SetBool("latder",false);
						anim.SetBool("latizq",false);
					}
					else if (movYc >= 0.70f)
					{
						anim.SetBool("saltoatras",false);
						anim.SetBool("latder",false);
						anim.SetBool("latizq",false);
					}
					else
					{
						anim.SetBool("saltoatras",false);
						anim.SetBool("latder",false);
						anim.SetBool("latizq",false);
					
					}
				}
                if(suelo == true && movYc < 0f || suelo == true && movYc > 0f || suelo == true && movXc < 0f|| suelo == true && movXc > 0f)
                {
                    if(temppaso > pasotiempo)
                    {
                        randompaso = UnityEngine.Random.Range(1,3);
                        if(randompaso == 1)
                        {
                            pasos1.Play();
                        }
                        if(randompaso == 2)
                        {
                            pasos2.Play();
                        }
                        temppaso = 0;
                        pasotiempo = UnityEngine.Random.Range(0.4f,0.6f);
                    }
                    if(temppaso < 15)
                    {temppaso += 1 * Time.deltaTime;}
                }
                anim.SetFloat("vely",movYc);


                if(objetivotarget == null)
				{
					if(camXc != 0)
					{rotationinput.x = camXc * rotspeed * Time.deltaTime;}
					else{rotationinput.x = 0;}
				}

				if(camYc != 0)
				{rotationinput.y = camYc * rotspeed * Time.deltaTime;}
				else{rotationinput.y = 0;}
				

					Vector3 horcam = Vector3.up * rotationinput.x;
					Vector3 vercam = new Vector3(0,0,0);

					
					vercam = Vector3.right * -rotationinput.y;

				
					camara.transform.localEulerAngles += vercam;
					transform.localEulerAngles += horcam;

				Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
				float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
				float fixedAngle_f = angle_f;
				if (xRotationx.eulerAngles.x>180)
				{
					fixedAngle_f *= -1;
				}
				float clampedX = Mathf.Clamp(fixedAngle_f, -20, 30);
				camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);
				
				camaux = camara.transform.eulerAngles.y;


				

					

				

			
				
                
				if(objetivotarget == null)
				{
				
						camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,0,camara.transform.localEulerAngles.z),10f* Time.deltaTime);		
				
				}
				if(objetivotarget != null)
				{
					Vector3 directiontt = objetivotarget.transform.position - transform.position;
					Quaternion rotation = Quaternion.LookRotation(directiontt);
               		transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),30f * Time.deltaTime);
					camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);
				}


                
				
                
            }
			else if(controlact == false)
			{
				camarascript.maxdis = 30;

				
				if(objetivotarget == null)
				{
				if(camXc != 0)
				{rotationinput.x = camXc * rotspeed * Time.deltaTime;}
				else{rotationinput.x = 0;}
				}

				if(camYc != 0)
				{rotationinput.y = camYc * rotspeed * Time.deltaTime;}
				else{rotationinput.y = 0;}
				

					Vector3 horcam = Vector3.up * rotationinput.x;
					Vector3 vercam = new Vector3(0,0,0);

					
					vercam = Vector3.right * -rotationinput.y;

				
					camara.transform.localEulerAngles += vercam + horcam;

				Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
				float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
				float fixedAngle_f = angle_f;
				if (xRotationx.eulerAngles.x>180)
				{
					fixedAngle_f *= -1;
				}
				float clampedX = Mathf.Clamp(fixedAngle_f, -20, 30);
				camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);
				

				if(objetivotarget != null)
				{
					Vector3 directiontt = objetivotarget.transform.position - transform.position;
					Quaternion rotation = Quaternion.LookRotation(directiontt);
					transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),30f * Time.deltaTime);
					camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
				}


				camaux = camara.transform.eulerAngles.y;
				if(objetivotarget == null)
				{

					if (movXc != 0f && camXc != 0f|| movYc != 0 && camXc != 0f || movXc != 0f || movYc != 0)
					{
						transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
						camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
					}
						


				}
			}
		}
		if(skate == true)
		{

			if(viento == true)
			{
				if(_rb.linearVelocity.y < 8)
				{
					verticalVel += 3f * Time.deltaTime;
				}
				_rb.linearVelocity = new Vector3(_rb.linearVelocity.x, verticalVel,_rb.linearVelocity.z);
			}
			
			movPH = false;
			anim.SetFloat("velx",0);
			anim.SetFloat("vely",0);
			anim.SetBool("stat",true);
			

			Vector3 movdirnow = new Vector3 (movXc,0, movYc).normalized;




			if(movXc != 0  && grind == false || movYc != 0 && grind == false)
			{

				movskate = true;
				
				// Rotar el modelo en la dirección del movimiento
				angulomod = Mathf.Atan2(movXc, movYc) * Mathf.Rad2Deg;
				mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
															Quaternion.Euler(mod.transform.localEulerAngles.x, angulomod, mod.transform.localEulerAngles.z),
															10f * Time.deltaTime);
				
				// Rotar el personaje para que mire en la dirección de la cámara
				float camaraYRotation = camara.transform.eulerAngles.y;
				transform.rotation = Quaternion.Slerp(transform.rotation, 
													Quaternion.Euler(0, camaraYRotation, 0),
													1 * Time.deltaTime);
			}
			else
			{
				movskate = false;
			}

			if(movYc == 0f && movXc == 0f)
			{
				anim.SetBool("stat",true);
				dashefect = false;
				dashefect2 = false;
			}
			else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity)&& dashefect == true)
			{
				if(hit.distance < 1f)
				{
				anim.SetBool("stat",true);
				dashefect = false;
				dashefect2 = false;
				}
				else
				{
					anim.SetBool("stat",true);
				}
				Debug.Log(hit.distance);
			}
			else
			{
				anim.SetBool("stat",true);
			}

			if(objetivotarget == null)
			{
			if(camXc != 0)
			{rotationinput.x = camXc * rotspeed * Time.deltaTime;}
			else{rotationinput.x = 0;}
			}

			if(camYc != 0)
			{rotationinput.y = camYc * rotspeed * Time.deltaTime;}
			else{rotationinput.y = 0;}
			Debug.Log("camara");
			

				Vector3 horcam = Vector3.up * rotationinput.x;
				Vector3 vercam = new Vector3(0,0,0);

				
				vercam = Vector3.right * -rotationinput.y;

			
				camara.transform.localEulerAngles += vercam + horcam;

			Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
			float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
			float fixedAngle_f = angle_f;
			if (xRotationx.eulerAngles.x>180)
			{
				fixedAngle_f *= -1;
			}
			float clampedX = Mathf.Clamp(fixedAngle_f, -20, 50);
			camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);
						


			camaux = camara.transform.eulerAngles.y;
			if(objetivotarget == null)
			{

				if (movXc != 0f && camXc != 0f && grind == false|| movYc != 0 && camXc != 0f && grind == false|| movXc != 0f && grind == false || movYc != 0 && grind == false)
				{
					transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
					camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
				}
					


			}
					
		}
            
		


		
			if(tiemposalto < 15)
			{this.tiemposalto += Time.deltaTime;}

			if (saltarc > 0f && saltop == true  && tiendat == false)
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					saltop = false;
					salto2 = true;
					tiemposalto = 0;
					anim.SetBool("salto",true);

			}
			else if (saltarc > 0f && salto2 == true && tiemposalto > 0.3f && manager.datosserial.tengosaltod == 1  && tiendat == false)
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					saltodo.Play();
					salto2 = false;
					tiemposalto = 0;
					anim.SetBool("salto",true);

			}
		
		
			if(manager.datosserial.armasjug[0] == true && tiendat == false)
			{

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1 && temppalo > 3  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && controlact == true)
					{
						tiempodisp = 0;
						temppalo -= 3;
						toquespalo = 2;
						paloSC.dano = 2 * danoextra * nivelfuerza;
						paloSC.levantar = false;
						anim.Play("arma3");
						anim.SetBool("arma3",true);
						tempatk = 0; 
						lanzarson.Play();
						if(manager.datosserial.nivelarmasjug[0] < 5)
						{
							if(manager.datosserial.licenciaarmas[0] >= manager.datosserial.nivelarmasjug[0] )
							{
								manager.datosserial.nivelarmasexpjug[0] += 5;
							}

							
							if(manager.datosserial.nivelarmasexpjug[0] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]])
							{
								manager.datosserial.nivelarmasjug[0]++;
								manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]] = paloNV[manager.datosserial.nivelarmasjug[0]];
								manager.datosserial.nivelarmasexpjug[0] = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = string.Concat("subiste La ParteCraneos a nivel ",manager.datosserial.nivelarmasjug[0]);
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2 && temppalo > 40 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && controlact == true )
					{
						tiempodisp = 0;
						temppalo -= 40;
						paloSC.dano = 5f * danoextra * nivelfuerza;
						paloSC.levantar = false;
						toquespalo = 999;
						anim.Play("escudogiratorio");
						tempatk = 0; 
						
						escudohabaud.Play();
						if(manager.datosserial.nivelarmasjug[0] < 5)
						{
							if(manager.datosserial.licenciaarmas[0] >= manager.datosserial.nivelarmasjug[0] )
							{
								manager.datosserial.nivelarmasexpjug[0] += 5;
							}

							
							if(manager.datosserial.nivelarmasexpjug[0] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]])
							{
								manager.datosserial.nivelarmasjug[0]++;
								manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]] = paloNV[manager.datosserial.nivelarmasjug[0]];
								manager.datosserial.nivelarmasexpjug[0] = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = string.Concat("subiste La ParteCraneos a nivel ",manager.datosserial.nivelarmasjug[0]);
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					if(anim.GetCurrentAnimatorStateInfo(1).IsName("escudogiratorio"))
					{
						stamina = 100;

					}

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && suelo == true && tiempodisp > 0.5f &&  dispararc > 0 && controlact == true )
					{
						tiempodisp = 0;
						temppalo -= 5 * Time.deltaTime;
						paloSC.dano = 2 * danoextra * nivelfuerza;
						paloSC.levantar = false;
						tempatk = 0;
						toquespalo = 999;
						transform.position = Vector3.MoveTowards(transform.position,transform.position + mod.transform.forward * 5, 20 * Time.deltaTime);
						anim.Play("dashtierra");
						anim.SetBool("dashtierra",true);
						dashairson.loop = true;
						dashairson.Play();
						mod.transform.rotation = Quaternion.Lerp(mod.transform.rotation,Quaternion.Euler(mod.transform.eulerAngles.x,camara.transform.eulerAngles.y,mod.transform.eulerAngles.z),10* Time.deltaTime);
						if(manager.datosserial.nivelarmasjug[0] < 5)
						{
							if(manager.datosserial.licenciaarmas[0] >= manager.datosserial.nivelarmasjug[0] )
							{
								manager.datosserial.nivelarmasexpjug[0] += 5;
							}

							
							if(manager.datosserial.nivelarmasexpjug[0] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]])
							{
								manager.datosserial.nivelarmasjug[0]++;
								manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]] = paloNV[manager.datosserial.nivelarmasjug[0]];
								manager.datosserial.nivelarmasexpjug[0] = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = string.Concat("subiste La ParteCraneos a nivel ",manager.datosserial.nivelarmasjug[0]);
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra") && suelo == true &&  dispararc > 0 && controlact == true )
					{
						tiempodisp = 0;
						temppalo -= 5 * Time.deltaTime;
						toquespalo = 999;
						paloSC.dano = 2 * danoextra * nivelfuerza;
						paloSC.levantar = false;
						tempatk = 0;
						anim.SetBool("dashtierra",true);
						transform.position = Vector3.MoveTowards(transform.position,transform.position + mod.transform.forward * 5, 20 * Time.deltaTime);
						mod.transform.rotation = Quaternion.Lerp(mod.transform.rotation,Quaternion.Euler(mod.transform.eulerAngles.x,camara.transform.eulerAngles.y,mod.transform.eulerAngles.z),10* Time.deltaTime);
					}
					else if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
					{
						dashairson.loop = false;
						dashairson.Stop();
						anim.Play("staticar");
						anim.SetBool("dashtierra",false);
					}

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4 && temppalo > 30 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && controlact == true)
					{
						tiempodisp = 0;
						temppalo -= 30;
						paloSC.dano = 15 * danoextra * nivelfuerza;
						paloSC.levantar = false;
						tempatk = 0; 
						toquespalo = 15;
						anim.Play("espiralarea");
						dashairson.Play();
						if(manager.datosserial.nivelarmasjug[0] < 5)
						{
							if(manager.datosserial.licenciaarmas[0] >= manager.datosserial.nivelarmasjug[0] )
							{
								manager.datosserial.nivelarmasexpjug[0] += 5;
							}

							
							if(manager.datosserial.nivelarmasexpjug[0] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]])
							{
								manager.datosserial.nivelarmasjug[0]++;
								manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]] = paloNV[manager.datosserial.nivelarmasjug[0]];
								manager.datosserial.nivelarmasexpjug[0] = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = string.Concat("subiste La ParteCraneos a nivel ",manager.datosserial.nivelarmasjug[0]);
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5 && temppalo >= 60 && inbuiract == false && tempinbuir  == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && controlact == true)
					{
						tiempodisp = 0;
						temppalo = 0;
						anim.Play("inbuir");
						anim.Play("inbuirmant");
						tempatk = 0; 
						inbuir.Play();
						danoextra += 1;
						inbuiract = true;
						tempinbuir = 30;
						if(manager.datosserial.nivelarmasjug[0] < 5)
						{
							if(manager.datosserial.licenciaarmas[0] >= manager.datosserial.nivelarmasjug[0] )
							{
								manager.datosserial.nivelarmasexpjug[0] += 5;
							}

							
							if(manager.datosserial.nivelarmasexpjug[0] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]])
							{
								manager.datosserial.nivelarmasjug[0]++;
								manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[0]] = paloNV[manager.datosserial.nivelarmasjug[0]];
								manager.datosserial.nivelarmasexpjug[0] = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = string.Concat("subiste La ParteCraneos a nivel ",manager.datosserial.nivelarmasjug[0]);
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
				if(golpearMc > 0 && suelo == true && tiempodisp > 0.7f && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") &&  dispararc == 0 && stamina > 50 && skate == false)
				{
					anim.Play("levantar");
					tiempodisp = -0.5f;
					tempatk = 0; 
					paloSC.dano = 2f * danoextra * nivelfuerza;
					paloSC.levantar = true;
					toquespalo = 999;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					stamina -= 10;
					staminaact = -2;
				}
				else if(golpearc > 0 && tiempodisp > 0.1f && combosting < 2 && anim.GetCurrentAnimatorStateInfo(0).IsName("rueda") &&  dispararc == 0 && stamina > 10 && skate == false || golpearc > 0 &&  dispararc == 0 && tiempodisp > 0.1f && combosting < 2 && anim.GetCurrentAnimatorStateInfo(0).IsName("stinger") && stamina > 10 && skate == false)
				{
					anim.Play("stinger");
					tiempodisp = 0f;
					tempatk = 0; 
					paloSC.dano = 2f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					toquespalo = 999;
					golpeson.Play();
					stamina -= 10;
					staminaact = -2;

					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("dash",false);
					dashefect = true;
					tiempodisp2 = 0;
					disdash = 10;
					veldash = 80;
					tempdash2 = 0;
					dashson.Play();
					combosting++;
				}

				else if(golpearc > 0 && suelo == false && tiempodisp > 0.1f  && comboa == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") &&  dispararc == 0 && stamina > 10 && skate == false)
				{
					anim.Play("modoaereo");
					anim.SetBool("atka1",true);
					tiempodisp = 0;
					tempatk = 0; 
					paloSC.dano = 0.3f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					toquespalo = 999;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					comboa = 1;
					stamina -= 10;
					staminaact = -2;
					this._rb.AddForce(200 * Vector3.up);
				}
				else if(golpearc > 0 && suelo == false && tiempodisp > 0.3f && comboa == 1 && anim.GetCurrentAnimatorStateInfo(1).IsName("atka1") &&  dispararc == 0  && stamina > 10  && skate == false)
				{
					anim.SetBool("atka2",true);
					comboa = 2;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == false && comboa == 2  && anim.GetCurrentAnimatorStateInfo(1).IsName("atka2"))
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					paloSC.dano = 0.5f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					comboa = 3;
					this._rb.AddForce(this.jumpforce * Vector3.up);
				}
				else if(golpearc > 0 && suelo == false && tiempodisp > 0.2f && comboa == 3 && anim.GetCurrentAnimatorStateInfo(1).IsName("atka2") &&  dispararc == 0 && stamina > 10  && skate == false)
				{
					anim.SetBool("atka3",true);
					comboa = 4;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == false && comboa == 4 && anim.GetCurrentAnimatorStateInfo(1).IsName("atka3")  && skate == false)
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					paloSC.dano = 2 * danoextra * nivelfuerza;
					paloSC.levantar = false;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					comboa = 0;
					this._rb.AddForce(this.jumpforce * Vector3.up);
				}
				
				else if(golpearc > 0 && suelo == true && tiempodisp > 0.7f  && combo == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") &&  dispararc == 0 && stamina > 10 && skate == false)
				{
					anim.SetBool("atk",true);
					tiempodisp = 0;
					tempatk = 0; 
					paloSC.dano = 0.3f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					toquespalo = 999;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 1;
					stamina -= 10;
					staminaact = -2;
				}
				else if(golpearc > 0 && suelo == true && tiempodisp > 0.2f && combo == 1 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk") &&  dispararc == 0 && stamina > 10  && skate == false)
				{
					anim.SetBool("atk2",true);
					combo = 2;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == true && combo == 2 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk2"))
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					paloSC.dano = 0.2f * danoextra;
					paloSC.levantar = false;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 3;
				}
				else if(golpearc > 0 && suelo == true && tiempodisp > 0.3f && combo == 3 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk2") &&  dispararc == 0  && stamina > 10  && skate == false)
				{
					anim.SetBool("atk3",true);
					combo = 4;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == true && combo == 4 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk3"))
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					paloSC.dano = 0.5f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 5;
				}


				else if(golpearc > 0 && suelo == true && combo == 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk3") &&  dispararc == 0 && stamina > 10  && skate == false)
				{
					anim.SetBool("atk4",true);
					combo = 6;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == true && combo == 6 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk4"))
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					paloSC.dano = 0.1f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 7;
				}
				else if(golpearc > 0 && suelo == true && tiempodisp > 0.2f && combo == 7 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk4") &&  dispararc == 0 && stamina > 10  && skate == false)
				{
					anim.SetBool("atk5",true);
					combo = 8;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == true && combo == 8 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk5")  && skate == false)
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					paloSC.dano = 2 * danoextra * nivelfuerza;
					paloSC.levantar = false;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 0;
				}


				else if(golpearMc > 0 && suelo == false &&  dispararc == 0  && stamina > 20  && skate == false)
				{
					anim.SetBool("atks",true);
					tiempodisp = 0;
					toquespalo = 999;
					paloSC.dano = 0.1f * danoextra * nivelfuerza;
					paloSC.levantar = false;
					this._rb.AddRelativeForce(500 * 2f * -Vector3.up);
					lanzarson.Play();
					stamina -= 20;
					staminaact = -1;
				}
				else if(tiempodisp > 0.1f)
				{
					anim.SetBool("atks",false);
					
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atk" ))
				{
					anim.SetBool("atk",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atk2" ))
				{
					anim.SetBool("atk2",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atk3" ))
				{
					anim.SetBool("atk3",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atk4" ))
				{
					anim.SetBool("atk4",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atk5" ))
				{
					anim.SetBool("atk5",false);
				}

				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atka1" ))
				{
					anim.SetBool("atka1",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atka2" ))
				{
					anim.SetBool("atka2",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("atka3" ))
				{
					anim.SetBool("atka3",false);
				}

				if(anim.GetCurrentAnimatorStateInfo(1).IsName("staticar" ) && anim.GetBool("atk")  == false && anim.GetBool("atk2")  == false && anim.GetBool("atk3") == false && anim.GetBool("atk4") == false && anim.GetBool("atk5") == false )
				{
					combo = 0;
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("staticar" ) && anim.GetBool("atka1")  == false && anim.GetBool("atka2")  == false && anim.GetBool("atka3") == false )
				{
					comboa = 0;
				}
				if(manager.datosserial.armasel == 1)
				{

						if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1)
						{
							iconodisp.sprite = arma1_1;

						}
						if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2)
						{
							iconodisp.sprite = arma1_2;

						}
						if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3)
						{
							iconodisp.sprite = arma1_3;
						}
						if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4)
						{
							iconodisp.sprite = arma1_4;
						}
						if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5)
						{
							iconodisp.sprite = arma1_5;
						}
					
				}

			}
			if(manager.datosserial.armasjug[1] == true && manager.datosserial.armasel == 2 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > manager.datosserial.armajugcadencia[1]  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[1] < 10)
					{
						if(manager.datosserial.licenciaarmas[1] >= manager.datosserial.nivelarmasjug[1])
						{
							manager.datosserial.nivelarmasexpjug[1]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[1] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[1]])
						{
							manager.datosserial.nivelarmasjug[1]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[1]] = pistolaNV[manager.datosserial.nivelarmasjug[1]];
							manager.datosserial.nivelarmasexpjug[1] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste El Gatillonizador a nivel ",manager.datosserial.nivelarmasjug[1]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebalapapal[manager.datosserial.nivelarmasjug[1] -1];
					tiempodisp = 0;
				if(manager.datosserial.nivelarmasjug[1] < 3)
				{

					GameObject BalaTemporal = Instantiate(armasbalas.pistolaBalajug[manager.datosserial.nivelarmasjug[1]-1], pistolamodels[1].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * manager.datosserial.armajugvel[1]);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[1]);
					}

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[1];
				}
				else if(manager.datosserial.nivelarmasjug[1] >= 3 && manager.datosserial.nivelarmasjug[1] < 7)
				{

					GameObject BalaTemporal = Instantiate(armasbalas.pistolaBalajug[manager.datosserial.nivelarmasjug[1]-1], pistolamodels[1].transform.position + (pistolamodels[1].transform.right * -0.5f),mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * manager.datosserial.armajugvel[1]);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[1]);
					}

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[1];

					GameObject BalaTemporal2 = Instantiate(armasbalas.pistolaBalajug[manager.datosserial.nivelarmasjug[1]-1], pistolamodels[1].transform.position + (pistolamodels[1].transform.right * 0.5f),mod.transform.rotation) as GameObject;

					Rigidbody rbb2 = BalaTemporal2.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget2 = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb2.AddForce(dirTarget2 * 110 * manager.datosserial.armajugvel[1]);
					}
					else
					{
						rbb2.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[1]);
					}

					BalaTemporal2.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal2.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal2.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[1];
				}
				else if(manager.datosserial.nivelarmasjug[1] >= 7)
				{

					GameObject BalaTemporal = Instantiate(armasbalas.pistolaBalajug[manager.datosserial.nivelarmasjug[1]-1], pistolamodels[1].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * manager.datosserial.armajugvel[1]);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[1]);
					}

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[1];
					
					GameObject BalaTemporal2 = Instantiate(armasbalas.pistolaBalajug[manager.datosserial.nivelarmasjug[1]-1], pistolamodels[1].transform.position+ (pistolamodels[1].transform.right * 1f),mod.transform.rotation) as GameObject;

					Rigidbody rbb2 = BalaTemporal2.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget2 = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb2.AddForce(dirTarget2 * 110 * manager.datosserial.armajugvel[1]);
					}
					else
					{
						rbb2.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[1]);
					}

					BalaTemporal2.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal2.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal2.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[1];

					GameObject BalaTemporal3 = Instantiate(armasbalas.pistolaBalajug[manager.datosserial.nivelarmasjug[1]-1], pistolamodels[1].transform.position + (pistolamodels[1].transform.right * -1f),mod.transform.rotation) as GameObject;

					Rigidbody rbb3 = BalaTemporal3.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget3 = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb3.AddForce(dirTarget3 * 110 * manager.datosserial.armajugvel[1]);
					}
					else
					{
						rbb3.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[1]);
					}

					BalaTemporal3.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal3.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal3.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[1];
				}
					

					disp.Play();

				}
			}
			if(manager.datosserial.armasjug[3] == true  && manager.datosserial.armasel == 4 && tiendat == false)
			{
				if(dispararc > 0 && tiempodisp > 0.5f && controlact == true)
				{
					

					if(manager.datosserial.nivelarmasjug[3] < 5)
					{
						if(manager.datosserial.licenciaarmas[3] >= manager.datosserial.nivelarmasjug[3] )
						{
							manager.datosserial.nivelarmasexpjug[3]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[3] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[3]])
						{
							manager.datosserial.nivelarmasjug[3]++;	
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[3]] = relNV[manager.datosserial.nivelarmasjug[3]];
							manager.datosserial.nivelarmasexpjug[3] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste la HARMONIZADORA a nivel ",manager.datosserial.nivelarmasjug[3]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebalarell[manager.datosserial.nivelarmasjug[3] -1];
					tiempodisp = 0; 

					GameObject BalaTemporal = Instantiate(armasbalas.relBalajug[manager.datosserial.nivelarmasjug[3]-1], pistolamodels[3].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * 4);
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
						rbb.AddForce(dirTarget * 110 * 4);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * 4);
					}

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 15f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 50;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[3];

					disprel.Play();

				}
			}
			if(manager.datosserial.armasjug[2] == true  && manager.datosserial.armasel == 3 && tiendat == false)
			{
				if(dispararc > 0 && tiempodisp > 0.5f && controlact == true || dispF == true && controlact == true)
				{

					
					if(manager.datosserial.nivelarmasjug[2] < 5)
					{
						if(manager.datosserial.licenciaarmas[2] >= manager.datosserial.nivelarmasjug[2])
						{
							manager.datosserial.nivelarmasexpjug[2]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[2] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[2]])
						{
							manager.datosserial.nivelarmasjug[2]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[2]] = bombaNV[manager.datosserial.nivelarmasjug[2]];
							manager.datosserial.nivelarmasexpjug[2] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste la PX4000 Quebrada a nivel ",manager.datosserial.nivelarmasjug[2]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebaladefl[manager.datosserial.nivelarmasjug[2] -1];
					tiempodisp = 0; 

					GameObject BalaTemporal = Instantiate(armasbalas.bombaBalajug[manager.datosserial.nivelarmasjug[2]-1], pistolamodels[2].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(new Vector3(0,mod.transform.up.y,mod.transform.forward.z) * 110 * (5 + (BalaTemporal.GetComponent<baladef_al2>().escala/ 2)));
					


					

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 30f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 300;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[2];
					dispF = false;
					dispdef.Play();

				}
	
			}
			if(manager.datosserial.armasjug[4] == true  && manager.datosserial.armasel == 5 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > 2  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[4] < 5)
					{
						if(manager.datosserial.licenciaarmas[4] >= manager.datosserial.nivelarmasjug[4])
						{
							manager.datosserial.nivelarmasexpjug[4]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[4] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[4]])
						{
							manager.datosserial.nivelarmasjug[4]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[4]] = ceboNV[manager.datosserial.nivelarmasjug[4]];
							manager.datosserial.nivelarmasexpjug[4] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste CopiaEspejo a nivel ",manager.datosserial.nivelarmasjug[4]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					tiempodisp = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.ceboBalajug[manager.datosserial.nivelarmasjug[4]-1], mod.transform.position +( mod.transform.forward * 5.5f),mod.transform.rotation) as GameObject;
					GameObject expcebo = Instantiate(explosion, mod.transform.position +( mod.transform.forward * 5.5f),mod.transform.rotation) as GameObject;
                	expcebo.transform.localScale = BalaTemporal.transform.localScale;
                	Destroy(expcebo,0.7f);
					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();


					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 60f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[4];
					

					disp.Play();

				}
	
			}
			if(manager.datosserial.armasjug[5] == true  && manager.datosserial.armasel == 6 && tiendat == false)
			{
				if(dispararc > 0 && controlact == true && pulso == false && tiempodisp > 1)
				{
					pulso = true;
					GameObject BalaTemporal = Instantiate(armasbalas.recBalajug[manager.datosserial.nivelarmasjug[5]-1], mod.transform.position,mod.transform.rotation) as GameObject;
					BalaTemporal.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[5];
					cargaalmacenada = BalaTemporal;
					tiempocarga = 0;
				}
				else if(dispararc > 0 && controlact == true && pulso == true && tiempocarga < 3)
				{
					cargaalmacenada.transform.localScale += new Vector3(6 * Time.deltaTime,6 * Time.deltaTime,6 * Time.deltaTime);
                	cargaalmacenada.transform.position = mod.transform.position;
               		tiempocarga += 1 * Time.deltaTime;
				}
				else if(dispararc == 0  && controlact == true && pulso == true|| tiempocarga >= 3 && pulso == true)
				{
					GameObject BalaTemporal = Instantiate(explosioncarga, mod.transform.position,mod.transform.rotation) as GameObject;
					BalaTemporal.GetComponent<baladef_exp_al2>().danoesc = 10;
					BalaTemporal.GetComponent<baladef_exp_al2>().danoj = manager.datosserial.armajugdano[5];

					BalaTemporal.transform.localScale = cargaalmacenada.transform.localScale;
					Destroy(cargaalmacenada);
					if(manager.datosserial.nivelarmasjug[5] < 5)
					{
						if(manager.datosserial.licenciaarmas[5] >= manager.datosserial.nivelarmasjug[5])
						{
							manager.datosserial.nivelarmasexpjug[5]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[5] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[5]])
						{
							manager.datosserial.nivelarmasjug[5]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[5]] = cargaNV[manager.datosserial.nivelarmasjug[5]];
							manager.datosserial.nivelarmasexpjug[5] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste Generador de Pulsos a nivel ",manager.datosserial.nivelarmasjug[5]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					tiempodisp = 0;
					pulso = false;
					tiempocarga = 0;

					disp.Play();
					tiempodisp = 0;

				}
				
	
			}
			if(manager.datosserial.armasjug[6] == true  && manager.datosserial.armasel == 7 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > manager.datosserial.armajugcadencia[6] && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[6] < 5)
					{
						if(manager.datosserial.licenciaarmas[6] >= manager.datosserial.nivelarmasjug[6])
						{
							manager.datosserial.nivelarmasexpjug[6]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[6] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[6]])
						{
							manager.datosserial.nivelarmasjug[6]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[6]] = rataNV[manager.datosserial.nivelarmasjug[6]];
							manager.datosserial.nivelarmasexpjug[6] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste RataTaPUM V1 a nivel ",manager.datosserial.nivelarmasjug[6]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					tiempodisp = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.rataBalajug[manager.datosserial.nivelarmasjug[6]-1], pistolamodels[6].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[6]);
					

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[6];
					

					disp.Play();

				}
	
			}
			if(manager.datosserial.armasjug[7] == true  && manager.datosserial.armasel == 8 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > manager.datosserial.armajugcadencia[7]  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[7] < 5)
					{
						if(manager.datosserial.licenciaarmas[7] >= manager.datosserial.nivelarmasjug[7])
						{
							manager.datosserial.nivelarmasexpjug[7]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[7] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[7]])
						{
							manager.datosserial.nivelarmasjug[7]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[7]] = escopetaNV[manager.datosserial.nivelarmasjug[7]];
							manager.datosserial.nivelarmasexpjug[7] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste Carnicera a nivel ",manager.datosserial.nivelarmasjug[7]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					tiempodisp = 0;
					if(manager.datosserial.nivelarmasjug[7] < 7)
					{
					
					GameObject BalaTemporal = Instantiate(armasbalas.escopetaBalajug[manager.datosserial.nivelarmasjug[7]-1], pistolamodels[7].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();


					rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[7]);
					

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[7];
					

					disp.Play();
					}
					else if(manager.datosserial.nivelarmasjug[7] >= 7)
					{
					
					GameObject BalaTemporal = Instantiate(armasbalas.escopetaBalajug[manager.datosserial.nivelarmasjug[7]-1], pistolamodels[7].transform.position + (pistolamodels[7].transform.right * 3f),mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();


					rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[7]);
					

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[7];
					
					GameObject BalaTemporal2 = Instantiate(armasbalas.escopetaBalajug[manager.datosserial.nivelarmasjug[7]-1], pistolamodels[7].transform.position + (pistolamodels[7].transform.right * -3f),mod.transform.rotation) as GameObject;

					Rigidbody rbb2 = BalaTemporal2.GetComponent<Rigidbody>();


					rbb2.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[7]);
					

					BalaTemporal2.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal2.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal2.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[7];
					
					

					disp.Play();
					}


				}
	
			}

			if(manager.datosserial.armasjug[8] == true  && manager.datosserial.armasel == 9 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > 1f  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[8] < 5)
					{
						if(manager.datosserial.licenciaarmas[8] >= manager.datosserial.nivelarmasjug[8])
						{
							manager.datosserial.nivelarmasexpjug[8]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[8] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[8]])
						{
							manager.datosserial.nivelarmasjug[8]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[8]] = misilNV[manager.datosserial.nivelarmasjug[8]];
							manager.datosserial.nivelarmasexpjug[8] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste Matasuegras a nivel ",manager.datosserial.nivelarmasjug[8]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebalapapal[manager.datosserial.nivelarmasjug[8] -1];
					tiempodisp = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.misilBalajug[manager.datosserial.nivelarmasjug[8]-1], pistolamodels[8].transform.position+( mod.transform.forward * 7.5f),mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * manager.datosserial.armajugvel[8]);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * manager.datosserial.armajugvel[8]);
					}

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[8];
					

					disp.Play();

				}
	
			}
			if(manager.datosserial.armasjug[9] == true  && manager.datosserial.armasel == 12 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > 1.5f  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[9] < 5)
					{
						if(manager.datosserial.licenciaarmas[9] >= manager.datosserial.nivelarmasjug[9])
						{
							manager.datosserial.nivelarmasexpjug[9]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[9] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[9]])
						{
							manager.datosserial.nivelarmasjug[9]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[9]] = defNV[manager.datosserial.nivelarmasjug[9]];
							manager.datosserial.nivelarmasexpjug[9] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position + new Vector3 (0,1f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste S/C egadora a nivel ",manager.datosserial.nivelarmasjug[9]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebalapapal[manager.datosserial.nivelarmasjug[9] -1];
					tiempodisp = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.defBalajug[manager.datosserial.nivelarmasjug[9]-1], pistolamodels[9].transform.position +( mod.transform.forward * 3.5f),mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					rbb.AddForce(mod.transform.up + mod.transform.forward * 110 * 15);


					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 20f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[9];
					

					disp.Play();

				}
	
			}
			if(manager.datosserial.armasjug[10] == true  && manager.datosserial.armasel == 11 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > 1.5f  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[10] < 5)
					{
						if(manager.datosserial.licenciaarmas[10] >= manager.datosserial.nivelarmasjug[10])
						{
							manager.datosserial.nivelarmasexpjug[10]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[10] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[10]])
						{
							manager.datosserial.nivelarmasjug[10]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[10]] = pistolaNV[manager.datosserial.nivelarmasjug[10]];
							manager.datosserial.nivelarmasexpjug[10] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste SantosCielos a nivel ",manager.datosserial.nivelarmasjug[10]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebalapapal[manager.datosserial.nivelarmasjug[10] -1];
					tiempodisp = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.escudoBalajug[manager.datosserial.nivelarmasjug[10]-1], mod.transform.position +( mod.transform.forward * 6.5f)+new Vector3(0,2,0),mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					GameObject expescudo = Instantiate(explosion, mod.transform.position +( mod.transform.forward * 6.5f)+new Vector3(0,2,0),mod.transform.rotation) as GameObject;
                	expescudo.transform.localScale = BalaTemporal.transform.localScale;
                	Destroy(expescudo,0.7f);

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 60f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[10];
					

					disp.Play();

				}
	
			}
			if(manager.datosserial.armasjug[11] == true  && manager.datosserial.armasel == 10 && tiendat == false)
			{
				if(dispararc > 0  && tiempodisp > 1f  && controlact == true)
				{
					if(manager.datosserial.nivelarmasjug[11] < 5)
					{
						if(manager.datosserial.licenciaarmas[11] >= manager.datosserial.nivelarmasjug[11])
						{
							manager.datosserial.nivelarmasexpjug[11]++;
						}

						
						if(manager.datosserial.nivelarmasexpjug[11] >= manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[11]])
						{
							manager.datosserial.nivelarmasjug[11]++;
							manager.datosserial.armajugsignv[manager.datosserial.nivelarmasjug[11]] = minaNV[manager.datosserial.nivelarmasjug[11]];
							manager.datosserial.nivelarmasexpjug[11] = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = string.Concat("subiste Mina Guardian V1 a nivel ",manager.datosserial.nivelarmasjug[11]);
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefab = prebalapapal[manager.datosserial.nivelarmasjug[11] -1];
					tiempodisp = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.minaBalajug[manager.datosserial.nivelarmasjug[11]-1], pistolamodels[11].transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					
					rbb.AddForce(mod.transform.forward * 70 * manager.datosserial.armajugvel[11]);
					

					BalaTemporal.GetComponent<romperbalajug_al2>().destb = 60f;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al2>().danoj = manager.datosserial.armajugdano[11];
					

					disp.Play();

				}
	
			}




				//artilugios
				if(manager.datosserial.artilugiosjug[0] == true  && manager.datosserial.armasel == 101 && tiendat == false)
				{
					if(dispararc > 0 && tiempodisp > 1.5f && controlact == true )
					{
						if(skate == false)
						{anim.Play("skateact1");}
						else if (skate == true) 
						{
							anim.Play("skateact2");
							skatevis.SetActive(false);
						}
						skate = !skate;
						tiempodisp = 0;
						
					}
				}
				if(manager.datosserial.artilugiosjug[1] == true  && manager.datosserial.armasel == 102 && tiendat == false)
				{
					if(dispararc > 0 && tiempodisp > 0.5f && controlact == true )
					{
						//cana
					}
				}
				if(manager.datosserial.artilugiosjug[2] == true  && manager.datosserial.armasel == 103)
				{
					if(dispararc > 0 && controlact == true && tempdash3 > dash3 && tiempodisp > 0.95f && tempaerodash2 > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && temppause > 0.4f && movdire != new Vector3(0,0,0) 
					|| dispararc > 0 && controlact == true  && tempdash3 > dash3  && tiempodisp > 0.95f && tempaerodash2 > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("escudogiratorio") && temppause > 0.4f && movdire != new Vector3(0,0,0))
					{
								Debug.Log(tempdash);
								Debug.Log(dash);
								Debug.Log(suelo);
								Debug.Log(dash2);
								anim.SetBool("saltoatras",false);
								anim.SetBool("latder",false);
								anim.SetBool("latizq",false);
								anim.SetBool("dash",true);
								anim.SetBool("rueda",false);

								dashefect = true;
								dashefect2 = true;
								tiempodisp = 0;
								disdash = 10;
								veldash = 120;
								tempdash3 = 0;
								dashaeract = true;
								movdirectaux = movdire;
								dashairson.Play();
								stamina -= 15;
								staminaact = -2;
								tempaerodash2 = 0;
								
							
					}
				}
				if(manager.datosserial.artilugiosjug[3] == true  && manager.datosserial.armasel == 104 && tiendat == false)
				{
					if(dispararc > 0 && controlact == true )
					{
						if(movXc != 0f && escalar == true || movYc != 0f && escalar == true)
						{
							anim.SetBool("escalar",true);
							anim.Play("escalar");
							_rb.linearVelocity = new Vector3(_rb.linearVelocity.x,7,_rb.linearVelocity.z);
							Vector3 directionesc = pared.transform.position - transform.position;
							Quaternion rotationesc = Quaternion.LookRotation(directionesc);
							transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotationesc.eulerAngles.y,transform.rotation.eulerAngles.z),30f * Time.deltaTime);

							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
							Quaternion.Euler(mod.transform.localEulerAngles.x, 0, mod.transform.localEulerAngles.z),
							10 * Time.deltaTime);
						}
						else
						{
							anim.SetBool("escalar",false);
						}
					
					}
					else
					{
						anim.SetBool("escalar",false);
					}
			}
			else
			{
				anim.SetBool("escalar",false);
			}

			if(manager.datosserial.artilugiosjug[4] == true  && manager.datosserial.armasel == 105 && tiendat == false)
				{
					if(dispararc > 0 && controlact == true && tiempodisp > 0.7f)
					{
						if(balasaltadorR != null)
						{
							Destroy(balasaltadorR);
						}

						GameObject dispsaltador = Instantiate(balasaltador, mod.transform.position+ mod.transform.forward * 8,transform.rotation) as GameObject;
                        Destroy(dispsaltador, 30f);
                        tiempodisp = 0;         
						balasaltadorR = dispsaltador;
					
					}
			}
			if(manager.datosserial.artilugiosjug[6] == true  && manager.datosserial.armasel == 106 && tiendat == false)
				{
					if(dispararc > 0 && controlact == true && tiempodisp > 0.7f)
					{
						if(balavelR != null)
						{
							Destroy(balavelR);
						}

						GameObject dispvel = Instantiate(balavel, mod.transform.position+ mod.transform.forward * 6,transform.rotation) as GameObject;
                        Destroy(dispvel, 30f);
                        tiempodisp = 0;         
						balavelR = dispvel;
					
					}
			}
			if(manager.datosserial.artilugiosjug[6] == true  && manager.datosserial.armasel == 107 && tiendat == false)
				{
					if(dispararc > 0 && controlact == true && tiempodisp > 0.5f)
					{

						//teleport
					}
			}
			if(manager.datosserial.artilugiosjug[7] == true  && manager.datosserial.armasel == 108 && tiendat == false)
			{
				if(dispararc > 0 && controlact == true && tiempodisp > 0.5f)
				{

					//Control
				}
			}


			
			

				
			
			
				
				if(dashc > 0 && tempdash > dash && suelo == false && tiempodisp2 > 0.95f && tempaerodash > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && stamina > 0 && temppause > 0.4f && movdire != new Vector3(0,0,0)
				|| dashc > 0 && tempdash > dash && suelo == false && tiempodisp2 > 0.95f && tempaerodash > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("escudogiratorio") && stamina > 0 && temppause > 0.4f && movdire != new Vector3(0,0,0))
				{
					Debug.Log(tempdash);
					Debug.Log(dash);
					Debug.Log(suelo);
					Debug.Log(dash2);
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("dash",true);
					anim.SetBool("rueda",false);

					dashefect = true;
					tiempodisp = 0;
					disdash = 10;
					veldash = 120;
					tempdash = 0;
					tiempodisp2 = 0;
					dashaeract = true;
					stamina -= 15;
					staminaact = -2;
					movdirectaux = movdire;
					dashairson.Play();
					paloSC.dano = 0.1f * danoextra * nivelfuerza;
					tempaerodash = 0;
					toquespalo = 999;
				}
				else if(dashc > 0 && tempdash2 > dash2 && suelo == true && tiempodisp2 > 0.7f  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && stamina > 0 && temppause > 0.4f  && movdire != new Vector3(0,0,0)
				|| dashc > 0 && tempdash2 > dash2 && suelo == true && tiempodisp2 > 0.7f  && anim.GetCurrentAnimatorStateInfo(1).IsName("escudogiratorio") && stamina > 0 && temppause > 0.4f  && movdire != new Vector3(0,0,0))
				{
					Debug.Log(tempdash);
					Debug.Log(dash);
					Debug.Log(suelo);
					Debug.Log(dash2);
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("rueda",true);
					anim.SetBool("dash",false);
					combosting = 0;
					dashefect = true;
					tiempodisp2 = 0;
					disdash = 10;
					veldash = 80;
					tempdash2 = 0;
					movdirectaux = movdire;
					dashson.Play();
					stamina -= 15;
					staminaact = -2;
					paloSC.dano = 0.1f * danoextra * nivelfuerza;
					toquespalo = 999;
				}
				else if(dashc > 0 && tempdash2 > dash2 && suelo == true && tiempodisp2 > 0.05f  && anim.GetCurrentAnimatorStateInfo(1).IsName("arma3") && stamina > 0 && temppause > 0.4f  && movdire != new Vector3(0,0,0))
				{
					anim.SetBool("arma3",false);
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("rueda",true);
					anim.SetBool("dash",false);
					combosting = 0;
					
					dashefect = true;
					tiempodisp2 = 0;
					disdash = 10;
					veldash = 80;
					tempdash2 = 0;
					movdirectaux = movdire;
					dashson.Play();
					stamina -= 15;
					staminaact = -2;
					paloSC.dano = 0.1f * danoextra * nivelfuerza;
					toquespalo = 999;
				}
				Debug.DrawRay(transform.position + new Vector3(0,2,0),movdire * 100f, Color.green);
				if(tempdash > dash && tempdash2 > dash2 && tempdash3 > dash3)
				{
					dashefect = false;
					dashefect2 = false;
				}
				
				if (dashefect == true)
				{
					movdirectaux = movdire;
					Vector3 orig = transform.position;
					Ray ray = new Ray(orig,movdirectaux);
					if (!Physics.Raycast(ray,Mathf.Infinity))
					{
						Debug.Log("llego5");
						Debug.DrawRay(orig,movdirectaux, Color.green,100f);
						transform.position = Vector3.MoveTowards(transform.position,transform.position + movdirectaux * disdash, veldash * Time.deltaTime);
					}
					else if (Physics.Raycast(orig,movdirectaux,out hit,Mathf.Infinity))
					{
						Debug.Log("llego4");
						Debug.DrawRay(orig,movdirectaux, Color.green,hit.distance);
						var sitio_dash = hit.transform.position - (transform.position + movdirectaux * disdash);
						var distancia_dash = sitio_dash.magnitude;
						
						if(hit.distance > veldash * Time.deltaTime || hit.collider.CompareTag("pareddash") && dashefect2 == true)
						{
							Debug.Log("llego");
							transform.position = Vector3.MoveTowards(transform.position,transform.position + movdirectaux * disdash, veldash * Time.deltaTime);
						}
						else if(hit.distance <= veldash * Time.deltaTime)
						{
							Debug.Log("llego2");
							anim.SetBool("rueda",false);
							tempdash = 4;
							tempdash2 = 4;
							tempdash3 = 4;
							dashefect = false;
							dashefect2 = false;
						}
					
					}
					else
					{
						Debug.Log("llego3");
						anim.SetBool("rueda",false);
						tempdash = 4;
						tempdash2 = 4;
						tempdash3 = 4;
						dashefect = false;
						dashefect2 = false;
					}
			
					
				}


				if(tempempujon > 0.3f)
				{
					empujon = false;
				}
				if (empujon == true)
				{
					
					Vector3 orig = transform.position;
					Ray ray = new Ray(orig,enmovdirectaux);
					if (!Physics.Raycast(ray,Mathf.Infinity))
					{
						Debug.DrawRay(orig,enmovdirectaux, Color.blue,100f);
						transform.position = Vector3.MoveTowards(transform.position,transform.position - enmovdirectaux * 5, 50 * Time.deltaTime);
					}
					else if (Physics.Raycast(orig,enmovdirectaux,out hit,Mathf.Infinity))
					{
						Debug.DrawRay(orig,enmovdirectaux, Color.blue,hit.distance);
						var sitio_dash = hit.transform.position - (transform.position + enmovdirectaux * 5);
						var distancia_dash = sitio_dash.magnitude;
						
						if(hit.distance > 10 * Time.deltaTime)
						{
							transform.position = Vector3.MoveTowards(transform.position,transform.position - enmovdirectaux * 5, 50 * Time.deltaTime);
						}
						else
						{
							empujon = false;
							tempempujon = 10;
						}
					
					}
			
					
				}
			

		
		Debug.DrawRay(transform.position + new Vector3(0,3,0),movdirectaux * 300, Color.green);
	
			if(correrc > 0 && velact != true && stamina > 0 && movYc != 0 && controlact == true && suelo == true
			|| correrc > 0 && velact != true && stamina > 0 && movXc != 0 && controlact == true && suelo == true)
			{
				stamina -= 7 * Time.deltaTime;
				staminaact = 0;
				velocidad = velocidadmaxima;
			}
			else if (velact != true && suelo == true){velocidad = velocidadaux;}
		
		if(temp10 < 15)
        {temp10 += 1 * Time.deltaTime;}
		if(tempaerodash < 15)
        {tempaerodash  += 1 * Time.deltaTime;}
		if(tempaerodash2 < 15)
        {tempaerodash2  += 1 * Time.deltaTime;}
		if(tiempovelint < 15)
        {tiempovelint += 1 * Time.deltaTime;}
		if(temp9 < 15)
        {temp9 += 1 * Time.deltaTime;}
		if(tempgir > 0)
        {tempgir -= 1 * Time.deltaTime;}
		if(tiempodisp2 < 15)
        {tiempodisp2 += 1 * Time.deltaTime;}
		if(tiempodisp < 15)
        {tiempodisp += 1 * Time.deltaTime;}
		if(tempdash< 15)
        {tempdash += 1 * Time.deltaTime;}
		if(tempdash2< 15)
        {tempdash2 += 1 * Time.deltaTime;}
		if(tempdash3< 15)
        {tempdash3 += 1 * Time.deltaTime;}
		if(temppalo< 60)
        {temppalo += 1 * velrecextra * Time.deltaTime;}

		
		if(temppause < 20)
        {temppause  += 1 * Time.deltaTime;}
		else{temppause  = 20;}


		if(tempberserk > 0)
        {tempberserk -= 1 * Time.deltaTime;}
		else{tempberserk = 0;}

		if(tempinbuir > 0)
        {tempinbuir -= 1 * Time.deltaTime;}
		else{tempinbuir = 0;}

		if(tempempujon < 15)
        {tempempujon += 1 * Time.deltaTime;}
		else{tempempujon = 15;}

		if (tempinbuir == 0)
		{
			
			anim.Play("staticar2");
		}


		
			if(tempdash > dash && tempdash3 > dash3)
			{anim.SetBool("dash",false);}

			if(tempdash2 > dash2)
			{anim.SetBool("rueda",false);}
		
		if(tiempodialogue < 15)
        {tiempodialogue += 1 * Time.deltaTime;}

		if(tempatk < 15)
        {tempatk += 1 * Time.deltaTime;}
		if(temprebote < 15)
		{temprebote += 1 * Time.deltaTime;}


			if(staminaact > 0.7f)
			{
				if (stamina < 0)
				{stamina = 0;}
				if(stamina < 100)
				{stamina += 120 * Time.deltaTime;}
				else{stamina = 100;}
			}
			else
			{
				staminaact += 1 * Time.deltaTime;
			}
		






		camXc = 0;
		camYc = 0;

		ruletaXc = 0;
		ruletaYc = 0;

		saltarc = 0;
		dashc = 0;
		golpearc = 0;
		golpearMc = 0;
		interactuarc = 0;

		
		dispararc = 0;
		lateralc = 0;
		correrc = 0;
		ruletac = 0;
		ruletapressc=0;
		UIreducidoc = 0;
		marcarc = 0;
		
		
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003149 File Offset: 0x00001349
	public void velozidad()
	{
		this.tiempovel = 0f;
		this.tiempovelint = 0;
		
	}


	// Token: 0x06000021 RID: 33 RVA: 0x0000318C File Offset: 0x0000138C
	public void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava"  || col.gameObject.tag == "escalar")
		{
			saltop = true;
            salto2 = false;
			tempempujon = 5;
			jumpforce = jumpforcebase;
			anim.SetBool("salto",false);
			dashaeract = false;

		
		}
		if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}

		if (col.gameObject.tag == "enemigo")
		{
			muertes.Play();
		}

	}

	// Token: 0x06000022 RID: 34 RVA: 0x000031C0 File Offset: 0x000013C0
	private void OnCollisionStay(Collision col)
	{

		if (col.gameObject.tag == "suelo"  || col.gameObject.tag == "lava"  || col.gameObject.tag == "escalar")
		{
			if(tiempovelint > 2)
			{suelo = true;}
			tempaerodash = 9;
			tempaerodash2 = 9;
			comboa = 0;
		
		}
		if (col.gameObject.tag == "suelo"  || col.gameObject.tag == "lava"  || col.gameObject.tag == "escalar" )
		{
			anim.SetBool("salto",false);
			
		}

	}


	// Token: 0x06000023 RID: 35 RVA: 0x00003284 File Offset: 0x00001484
	private void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "escalar")
		{
			escalar = false;
		}
		if (col.gameObject.tag == "suelo" || col.gameObject.tag == "escalar" || col.gameObject.tag == "lava" )
		{
			anim.SetBool("salto",true);
			suelo = false;
		}
	
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "tiendat")
		{
            tienda = (tienda_al2)FindFirstObjectByType(typeof(tienda_al2));
			tiendat = true;
            if(manager.datosconfig.plat == 2)
            {
                tactil.SetActive(false);
            }
            tiendag.SetActive(true);
            if(manager.datosconfig.plat == 2)
            {
                tactil.SetActive(true);
            }
            Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
		}
		if (col.gameObject.tag == "escalar")
		{
			escalar = true;
			pared = col.gameObject;
		}
		if (col.gameObject.tag == "suelo"   || col.gameObject.tag == "lava")
		{
			jumpforce = jumpforcebase;
			anim.SetBool("salto",false);
			dashaeract = false;

		
		}
		if (col.gameObject.tag == "lava" && skate == false)
		{


		
		}
		if (col.gameObject.tag == "viento")
		{
			anim.SetBool("salto",false);
			viento = true;
		}

		if (col.gameObject.tag == "armaene" )
		{
			if(col.gameObject.GetComponent<romperbala_al2>() != null)
			{
				romperbala_al2 enec = col.gameObject.GetComponent<romperbala_al2>();
				if(enec.armadef == false)
				{
					
					if(enec.salir == false && enec.paloact == false)
					{
						manager.personaje = 1;
						eneempuj = col.gameObject;
						enmovdirectaux = transform.TransformDirection((eneempuj.transform.forward *70) + (eneempuj.transform.up * -50));
						enmovdirectaux = enmovdirectaux.normalized;
						tempempujon = 0;
						empujon = true;

						muertesjug.Play();
						if(enec.danofijo == true)
						{
							vida -= (vidamax/100) * enec.porcentaje;
						}
						else
						{vida -= enec.danoj;}
					}
				}
			}
			if(col.gameObject.GetComponent<baladef_exp_al2>() != null)
			{
				baladef_exp_al2 enec = col.gameObject.GetComponent<baladef_exp_al2>();

					
					if(enec.paloact == false)
					{

						manager.personaje = 1;
						muertesjug.Play();

						vida -= enec.danoj;
					}
				
			}
		}

			
		
		if (col.gameObject.tag == "cambio")
        {
            menushow.SetBool("show",true);
			comando.text = string.Concat("cambiar direccion de compresion");
        }
		if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}
		if (col.gameObject.tag == "enemigodet")
		{
			if(enemigosEnContacto.Contains(col.gameObject) == false)
			{
				enemigosEnContacto.Add(col.gameObject);
			}
			
			peligro = true;
			if(target[0] == null )
			{
				target[0]  = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
			}
			else if(target[0] != null && target[1] == null )
			{
				target[1] = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
			}
			else if(target[0]  != null && target[1] != null && target[2] == null )
			{
				target[2] = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
			}
			else if(target[0]  != null && target[1] != null && target[2] != null )
			{
				if(target[0] == objetivotarget)
				{
					target[1] = target[2];
					target[2] = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
				}
				else if(target[1] == objetivotarget)
				{
					target[0]  = target[2];
					target[2] = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
				}
				else if(target[2] == objetivotarget)
				{
					target[0]  = target[1];
					target[1] = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
				}
				else
				{
					target[0]  = target[1];
					target[1] = target[2];
					target[2] = col.transform.parent.gameObject.transform.Find("enemigo").gameObject;
				}
			
			}
			for(int i = 0;i == 3;i++ )
			{
				for(int t = 0;t == 3;t++ )
				{
					if(target[i] == target[t] && i != t)
					{
						target[t] = null;
					}
				}

			}
		}
		if (col.gameObject.tag == "dañox2")
		{
			if(col.gameObject.GetComponent<golpe_al2>() != null)
			{
				golpe_al2 enec = col.gameObject.GetComponent<golpe_al2>();
				if(enec.toquespalo > 0 && enec.paloact == false)
				{
					manager.personaje = 1;
					eneempuj = col.gameObject;
					enmovdirectaux = transform.TransformDirection((eneempuj.transform.forward *70) + (eneempuj.transform.up * -50));
					enmovdirectaux = enmovdirectaux.normalized;
					tempempujon = 0;
					empujon = true;
					
					
			
					
					enec.toquespalo--;
					vida -= enec.dano;
					dest.Play();
				}
			}
		}
		if (col.gameObject.tag == "dañox5" )
		{
			if(col.gameObject.GetComponent<golpe_al2>() != null)
			{
				golpe_al2 enec = col.gameObject.GetComponent<golpe_al2>();
				if(enec.toquespalo > 0 && enec.minmun == true  && enec.paloact == false)
				{
					manager.personaje = 1;
					eneempuj = col.gameObject;
					enmovdirectaux = transform.TransformDirection((enec.guia.transform.forward *70) + (enec.guia.transform.up * -50));
					enmovdirectaux = enmovdirectaux.normalized;
					tempempujon = 0;
					empujon = true;
					enec.toquespalo--;
					temppalo = 0;
					dest.Play();
				}
				else if(enec.toquespalo > 0 && enec.ultimo == true && enec.paloact == false)
				{
					manager.personaje = 1;
					eneempuj = col.gameObject;
					enmovdirectaux = transform.TransformDirection((enec.guia.transform.forward *70) + (enec.guia.transform.up * -50));
					enmovdirectaux = enmovdirectaux.normalized;
					tempempujon = 0;
					empujon = true;
					enec.toquespalo--;
					temppalo = 0;
					vida = 1;
					dest.Play();
				}
				else if(enec.toquespalo > 0  && enec.paloact == false)
				{
					manager.personaje = 1;
					eneempuj = col.gameObject;
					enmovdirectaux = transform.TransformDirection((enec.guia.transform.forward *70) + (enec.guia.transform.up * -50));
					enmovdirectaux = enmovdirectaux.normalized;
					tempempujon = 0;
					empujon = true;
					enec.toquespalo--;
					temppalo = 0;
					vida -= enec.dano;
					dest.Play();
				}
			}
		}
		if (col.gameObject.tag == "npc")
		{
			npcbase = col.GetComponent<npc_al2>();
			comando.text = npcbase.es_frase;
	    	menushow.SetBool("show",true);		
			dialogueact = false;
		}
		if (col.gameObject.tag == "evento")
		{
			eventosdialogueE = col.GetComponent<eventosdialogue_al2>();
			if(eventosdialogueE.jug == true)
			{
				dialogueact = false;

				if (dialogueact == false && tiempodialogue > 0.7f)
				{
					menushow.SetBool("show",false);
					if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
					{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
					menuoff.StartDialogue(eventosdialogueE.DialogueSO,eventosdialogueE.dialogueid);
					dialogueact = true;
					tiempodialogue = 0;
					controlact = false;
					manager.controlene = false;
					
				}
			}

		}
		if (col.gameObject.tag == "enemigo" )
		{
			

			
		}
		if (col.gameObject.tag == "control" && manager.datosserial.artilugiosjug[7] == true && manager.datosserial.armasel == 108 && manager.personaje != 2)
		{
			comando.text = "poser un aflamo";
			menushow.SetBool("show",true);
			control = true;
		}

	}
	public void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "tiendat")
		{
            tienda = (tienda_al2)FindFirstObjectByType(typeof(tienda_al2));
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
			tiendat = false;
            tienda.salir_();
		}
		if (col.gameObject.tag == "escalar")
		{
			escalar = false;
		}
		if (col.gameObject.tag == "viento")
		{
			viento = false;
		}

		if (col.gameObject.tag == "armaene")
		{
			if(col.gameObject.GetComponent<romperbala_al2>() != null)
			{
				romperbala_al2 enec = col.gameObject.GetComponent<romperbala_al2>();
				if(enec.armadef == false)
				{
					
					if(enec.salir == true && enec.paloact == false)
					{
						manager.personaje = 1;
						eneempuj = col.gameObject;
						enmovdirectaux = transform.TransformDirection((eneempuj.transform.forward *70) + (eneempuj.transform.up * -50));
						enmovdirectaux = enmovdirectaux.normalized;
						tempempujon = 0;
						empujon = true;

						muertesjug.Play();
						
						if(enec.danofijo == true)
						{
							vida -= (vidamax/100) * enec.porcentaje;
						}
						else
						{vida -= enec.danoj;}
					}
				}
				
			}
		}

		


		if (col.gameObject.tag == "npc")
		{
			menushow.SetBool("show",false);
			if(menuoff != null)
			{
			menuoff.MainUI.gameObject.SetActive(false);
			vozMeet.Stop();
			}
			dialogueact = false;
			manager.controlene = true;
		}
		if (col.gameObject.tag == "evento" && static_ev && eventosdialogueE != null)
		{
			if(eventosdialogueE.jug == true)
			{
				menushow.SetBool("show",false);
				if(menuoff != null)
				{
				menuoff.MainUI.gameObject.SetActive(false);
				}
				dialogueact = false;
			}
		}
		else if (col.gameObject.tag == "evento" && eventosdialogueE != null)
		{
			if(eventosdialogueE.jug == true)
			{
				menushow.SetBool("show",false);
				if(menuoff != null)
				{
				menuoff.MainUI.gameObject.SetActive(false);
				controlact = true;
				manager.controlene = true;
				}
				dialogueact = false;
			}
		}
		if (col.gameObject.tag == "enemigodet")
		{
			enemigosEnContacto.Remove(col.gameObject);
			if (enemigosEnContacto.Count == 0)
			{
				peligro = false;
			}
			if(objetivotarget  == col.gameObject)
			{
				if(objetivotarget != null)
				{findchild(objetivotarget,false,"selectar");}
				objetivotarget = null;
				indicetarget = -1;
			}
			for(int i = 0;i == 3;i++ )
			{
				for(int t = 0;t == 3;t++ )
				{
					if(target[i] == target[t] && i != t)
					{
						target[t] = null;
					}
				}

			}
			if(target[0]  == col.gameObject.transform.parent.gameObject)
			{
				if(target[0] != null)
				{findchild(target[0],false,"selectar");}
				target[0]  = target[1];
				target[1] = target[2];
				target[2] = null;
			}
			else if(target[1] == col.gameObject.transform.parent.gameObject)
			{
				if(target[1] != null)
				{findchild(target[1],false,"selectar");}
				target[1] = target[2];
				target[2] = null;
			}
			else if(target[2] == col.gameObject.transform.parent.gameObject)
			{
				if(target[2] != null)
				{findchild(target[2],false,"selectar");}
				target[2] = null;
			}

		}
		
		if (col.gameObject.tag == "cambio")
        {
            menushow.SetBool("show",false);
        }
		if (col.gameObject.tag == "control" && manager.personaje != 2)
		{
			menushow.SetBool("show",false);
			control = false;
		}
	}
	public void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "control" && manager.personaje != 2)
		{

			if(manager.datosserial.artilugiosjug[7] == true && manager.datosserial.armasel == 108 && control == false)
			{
				comando.text = "poser un aflamo";
				menushow.SetBool("show",true);
				control = true;
			}
			else if(controles.al2_3d.interactuar.ReadValue<float>() > 0f && control == true && tiempodisp > 0.5f && manager.datosserial.artilugiosjug[7] == true && manager.datosserial.armasel == 108)
			{
				_rb.linearVelocity = Vector3.zero;
				jugador2.tiempodisp = 0;
				tiempodisp = 0;
				manager.personaje = 2;

			}
			else if(manager.datosserial.artilugiosjug[7] == false && control == true || manager.datosserial.armasel != 108 && control == true)
			{
				menushow.SetBool("show",false);
				control = false;
			}
		}
		if (col.gameObject.tag == "viento")
		{
			anim.SetBool("salto",false);
			viento = true;
		}

		if (col.gameObject.tag == "npc")
		{
			if (controles.al2_UI.interactuar.ReadValue<float>() > 0f && dialogueact == false && tiempodialogue > 0.7f)
			{
				
				menushow.SetBool("show",false);
				if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
				{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
				
				
				manager.misionS = col.gameObject.GetComponent<npc_al2>().mision;
				misionA.misionS = col.gameObject.GetComponent<npc_al2>().mision;
				misionA.npcid = col.gameObject.GetComponent<npc_al2>().managernpc.npcID;
				misionA.premiocant = col.gameObject.GetComponent<npc_al2>().npc_precio;
				

				menuoff.StartDialogue(npcbase.DialogueSO,npcbase.dialogueid);
				dialogueact = true;
				tiempodialogue = 0;
				manager.controlene = false;

				
			}
			else if (controles.al2_UI.cinnext.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
			{
				if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == true)
				{
					vozMeet.Stop();
					menuoff.SkipDialogue();
					tiempodialogue = 0;
				}
				
			}
			if(menuoff != null)
			{
				if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == false)
				{
					menushow.SetBool("show",true);				
					dialogueact = false;
				}
			}
		}
		if (col.gameObject.tag == "evento" && eventoini == true)
		{
			eventosdialogueE = col.GetComponent<eventosdialogue_al2>();
			if(eventosdialogueE.jug == true)
			{
				dialogueact = false;
				controlact = false;
				manager.controlene = false;

				if (dialogueact == false && tiempodialogue > 0.7f)
				{
					menushow.SetBool("show",false);
					if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
					{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
					menuoff.StartDialogue(eventosdialogueE.DialogueSO,eventosdialogueE.dialogueid);
					dialogueact = true;
					tiempodialogue = 0;
					eventoini = false;
					
					
				}
			}

		}
		if (col.gameObject.tag == "evento")
		{	
			if(eventosdialogueE.jug == true)
			{
				if (controles.al2_UI.cinnext.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
				{
					if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == true)
					{
						vozMeet.Stop();
						menuoff.SkipDialogue();
						tiempodialogue = 0;
						tiemposalto = 0f;
					}
					
				}
				if(menuoff != null)
				{
					if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == false && eventoini == false)
					{
						dialogueact = false;
						manager.controlene = true;
						controlact = true;
						tiemposalto = 0;
						Destroy(eventosdialogueE.gameObject);
					}
				}
			}
		}
		
		
		if (col.gameObject.tag == "enemigodet")
		{
			if (enemigosEnContacto.Count == 0)
			{
				peligro = false;
			}
			for(int i = 0;i < 2;i++ )
			{
				for(int t = 0;t < 2;t++ )
				{
					if(target[i] == target[t] && i != t)
					{
						target[t] = null;
					}
				}

			}
			for(int i = 0;i < 2;i++ )
			{
				if(objetivotarget == target[i])
				{
					objetivotarget = target[i];
				}
			}
		}
		if (enemigosEnContacto.Count == 0)
		{
			peligro = false;
		}
	}
	public void findchild(GameObject objeto,bool des,string nombre)
	{
		for (int i = 0; i < objeto.transform.childCount; i++) 
		{
			if(objeto.transform.GetChild(i).name == nombre)
			{
				objeto.transform.GetChild(i).gameObject.SetActive(des);
			}
		}
	}
	public void cambiar_modelo_arma()
	{
				
		pistolamodels[1].SetActive(false);
		pistolamodels[2].SetActive(false);
		pistolamodels[3].SetActive(false);

		pistolamodels[4].SetActive(false);
		pistolamodels[5].SetActive(false);
		pistolamodels[6].SetActive(false);
		pistolamodels[7].SetActive(false);
		
		pistolamodels[8].SetActive(false);
		pistolamodels[9].SetActive(false);
		pistolamodels[10].SetActive(false);
		pistolamodels[11].SetActive(false);

		pistolamodels[13].SetActive(false);
		pistolamodels[14].SetActive(false);
		pistolamodels[15].SetActive(false);

		pistolamodels[16].SetActive(false);
		pistolamodels[17].SetActive(false);
		pistolamodels[19].SetActive(false);
	}


	
	
}
