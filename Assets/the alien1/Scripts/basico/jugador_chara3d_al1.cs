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
public class jugador_chara3d_al1 : jugador_al1
{
	
	[Header("Propio 3D")]
	private float temprebote;
	public AudioSource dest;
	public AudioSource critico;
	public Image Critobj;
    public float colorC;
    private float vidaescudoUI1;
	private float vidaescudoUI2;
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
	public float tiempoascensor = 0;
	public bool ascensor ;
	public Vector3 rotationinput;
	public float rotspeed = 3;
	public float tempgir = 0;
	public int indicetarget = -1;
	public GameObject []target = new GameObject[3];
	private float cameraverticalangle2;
	public bool ascact;
	private float staminaobj;
	public AudioSource inbuir;
	public Image staminabarra;
	private float temp9;
	private float xp;
	public GameObject balaprefabpapa;
	public GameObject balaprefabrel;
	public GameObject balaprefabdef;
	public AudioSource tragar;
	private float tempberserk;
	private float vidaberserk;
	private float danoextra = 1;
	private bool berserkfin;
	private float tempvelrec;
	private bool velrecfin;
	private float tempinbuir;
	private bool inbuiract;
	private float vidaobj;
	public AudioSource espiraloaud;
	public AudioSource escudoaud;
	public AudioSource golpeson;
	public AudioSource lanzarson;
	private bool papaagotada;
	public Sprite armapaparueda;
	public Sprite armarelrueda;
	public Sprite armadefrueda;
	public GameObject []prebaladefl;
	public GameObject []prebalarell;
	public GameObject []prebalapapal;


	public float tempdefrec = 60f; 
	public float temprelrec = 40f; 
	public float temppaparec = 20f; 

	public AudioSource pistolabueno;
	public AudioSource pistolamalo;
	public Text balaarmat;
	private int cambioruedaact;
	public Text numpoct;
	public Text numpoc1t;
	public Text numpoc2t;
	public Text numpoc3t;
	public Text numpoc4t;


	public Text vidat;
	public Text comando;
	public bool jugadorEntrando;
	private bool cargainicial;
	private int randompaso;
	public AudioSource pasos1;
	public AudioSource pasos2;
	public AudioSource sonidoTP;
    public GameObject expTP;
	public bool carga;
	public bool eventoini;
	private float angulomod;
	private float pasotiempo;
	private float temppaso = 1;
	public GameObject tarboss;
	public GameObject slash;
	public Sprite arma1;
	public Sprite arma2;
	public Sprite arma3;
	public Sprite arma4;
	public GameObject pistolatiempo;
	public GameObject pistolabazoka;
	public float staminaact = 50;
	public camara_al1 camarascript; 
	private float tempaerodash = 9;
	public AudioSource dashson;
	public AudioSource dashairson;
	private float dash = 0.3f;
	private float dash2 = 0.3f;
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
	public GameObject pistolap;
	public Image backpaloimg;
	public Image paloimg;
	public Image pistolaimg;
	public Image relentizarimg;
	public Image armadefimg;
	public Image circulopaloimg;
	public Image circulopistolaimg;
	public Image circulorelentizarimg;
	public Image circuloarmadefimg;

	public Image backpistolaimg;
	public Image backrelentizarimg;
	public Image backarmadefimg;

	public Sprite pocionvidaimg;

	public Sprite pocionhabrec;
	public Sprite pocionrecimg;
	public Sprite berserkimg;
	private float temppalo = 60;
	private float tempatk;
	private int numpociones;
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
	public GameObject mod;
	public GameObject palo;
	public npc_al1 npcbase;
	private float jumpforcebase = 0f;
	public eventosdialogue eventosdialogueE;
	public Animator animcam;
	public AudioSource vozMeet;
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
	private float golpearMc;
	private float interactuarc;
	private float dispararc;
	private float ruletac;
	private float UIreducidoc;
	private float correrc;
	private float menu1c;
	private float menu2c;
	public float lateralc;		
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
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

		if(manager.nivelact)
		{
			controlact = false;
			animcam.Play("comenzarnivel");
			sonidoTP.Play();
			GameObject exptemp = Instantiate(expTP, transform.position,transform.rotation) as GameObject;
			Destroy(exptemp,1);
		}

		camarascript = (camara_al1)FindFirstObjectByType(typeof(camara_al1));

		
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



		

			if(manager.datosserial.tengopalo == false)
			{
				paloimg.sprite = nopimg;
			}


			if(manager.datosserial.armapapa == false)
			{
				pistolaimg.sprite = nopimg;
			}

			if(manager.datosserial.armarelen == false)
			{
				relentizarimg.sprite = nopimg;
			}
			
			if(manager.datosserial.armadef == false)
			{
				armadefimg.sprite = nopimg;
			}

			
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1)
			{
				iconodisp.sprite = arma1_1;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);

			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2)
			{
				iconodisp.sprite = arma1_2;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);
			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3)
			{
				iconodisp.sprite = arma1_3;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);
			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4)
			{
				iconodisp.sprite = arma1_4;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);
			}
			if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5)
			{
				iconodisp.sprite = arma1_5;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);
			}



			if(manager.datosserial.armasel == 3)
			{
				iconodisp.sprite = arma3;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(true);
			}
			if(manager.datosserial.armasel == 2)
			{
				iconodisp.sprite = arma2;
				pistolap.SetActive(true);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);
			}
			if(manager.datosserial.armasel == 4)
			{
				iconodisp.sprite = arma4;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(true);
				pistolabazoka.SetActive(false);
			}
			if(manager.datosserial.armasel == 0)
			{
				iconodisp.sprite = nopimg;
				pistolap.SetActive(false);
				pistolatiempo.SetActive(false);
				pistolabazoka.SetActive(false);
			}
			balapadrevel = new float[5];
			balapadredano = new float[5];
			balapadrecaden = new float[5];
			balapapamun = new float[5];
			baladefdano = new float[5];
			balareldano = new float[5];


			armapalosignv = new float[5];
			armadefsignv = new float[5];
			armapapasignv = new float[5];
			armarelsignv = new float[5];

			armapalosignv[0] = 80;
			armadefsignv[0] = 10;
			armapapasignv[0] = 300;
			armarelsignv[0] = 20;

			armapalosignv[1] = 100;
			armadefsignv[1] = 30;
			armapapasignv[1] = 600;
			armarelsignv[1] = 30;
			
			armapalosignv[2] = 120;
			armadefsignv[2] = 60;
			armapapasignv[2] = 1000;
			armarelsignv[2] = 50;

			armapalosignv[3] = 140;
			armadefsignv[3] = 90;
			armapapasignv[3] = 2000;
			armarelsignv[3] = 80;





			balapadrevel[0] = 10f;
			balapadredano[0] = 1.5f;
			balapadrecaden[0] = 0.8f;
			balapapamun[0] = 1.2f;

			balapadrevel[1] = 14f;
			balapadredano[1] = 2f;
			balapadrecaden[1] = 0.7f;
			balapapamun[1] = 0.9f;

			balapadrevel[2] = 22f;
			balapadredano[2] = 2.5f;
			balapadrecaden[2] = 0.5f;
			balapapamun[2] = 0.60f;

			balapadrevel[3] = 25f;
			balapadredano[3] = 2.5f;
			balapadrecaden[3] = 0.3f;
			balapapamun[3] = 0.35f;

			balapadrevel[4] = 35f;
			balapadredano[4] = 2.3f;
			balapadrecaden[4] = 0.2f;
			balapapamun[4] = 0.25f;

			baladefdano[0] = 20;
			baladefdano[1] = 30;
			baladefdano[2] = 40;
			baladefdano[3] = 50;
			baladefdano[4] = 60;

			balareldano [0]= 0;
			balareldano [1]= 0;
			balareldano [2]= 0;
			balareldano [3]= 1.2f;
			balareldano [4]= 2;
		


		if((enemigo1boss_al1)FindFirstObjectByType(typeof(enemigo1boss_al1)) != null)
		{
			eneboss1 = (enemigo1boss_al1)FindFirstObjectByType(typeof(enemigo1boss_al1));
		}
		numpociones = manager.datosserial.pocionesmax;
		

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
		if(manager.datosserial.tengopalo == false)
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
		
		
	}
	public void fixedStart()
	{
		
	}
	
	private void fixedUpdate()
	{
		if (enemigosEnContacto.Count == 0)
		{
			peligro = false;
		}
	}
	private void Update()
	{

		
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

		if(vida < ((vidamax/100)* 30))
		{
            colorC = ((((vidamax/100)* 30) - (((vidabase/vidamax))) * 100))/300*4;
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
			
			manager.datosserial.alien1muere = true;
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
			manager.datosconfig.carga = "tutorialcin2enc_al1";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");
		}
		
	}

		staminaobj = Mathf.Lerp(staminaobj, stamina, Time.deltaTime * 4f);
		vidaobj = Mathf.Lerp(vidaobj, vida, Time.deltaTime * 2f);
		vidab.fillAmount = vidaobj/vidamax; 
		vidat.text = "VIT:"+(int)vida+"/"+(int)vidamax;
		niverlbarra.fillAmount = manager.datosserial.nivelexp/manager.datosserial.signivelexp; 
		niveluit.text = "LEVEL "+ manager.datosserial.niveljug;
		staminabarra.fillAmount = staminaobj/staminamax;
	
	if(controlact == false)
	{
		anim.SetBool("stat",true);
	}
	if(controlact == true)
	{

		
			ruletaXc = controles.al1_3d.ruletaPAD.ReadValue<Vector2>().x;
			ruletaYc = controles.al1_3d.ruletaPAD.ReadValue<Vector2>().y;



			
			camXc = controles.al1_3d.camX.ReadValue<float>();
			camYc = controles.al1_3d.camY.ReadValue<float>();
			


			


			if(movact == 0)
			{
				movXc = controles.al1_3d.mov.ReadValue<Vector2>().x;
				movYc = controles.al1_3d.mov.ReadValue<Vector2>().y;
				saltarc = controles.al1_3d.saltar.ReadValue<float>();
			}

		

		lateralc = controles.al1_3d.lateral.ReadValue<float>();
		UIXc = controles.al1_UI.UIX.ReadValue<float>();
		UIYc = controles.al1_UI.UIY.ReadValue<float>();	
		dispararc = controles.al1_3d.disparar.ReadValue<float>();	
		dashc = controles.al1_3d.dash.ReadValue<float>();
		golpearc = controles.al1_3d.golpear.ReadValue<float>();
		golpearMc = controles.al1_3d.golpearM.ReadValue<float>();
		interactuarc = controles.al1_3d.interactuar.ReadValue<float>();		
		
		ruletac = controles.al1_3d.ruleta.ReadValue<float>();	
		UIreducidoc = controles.al1_3d.UIreducido.ReadValue<float>();
		marcarc = controles.al1_3d.marcar.ReadValue<float>();
		correrc = controles.al1_3d.correr.ReadValue<float>();
		menu1c = controles.al1_3d.menu1.ReadValue<float>();
		menu2c = controles.al1_3d.menu2.ReadValue<float>();
		
		

		if (menu1c > 0 && temp10 > 0.7f)
		{
			Time.timeScale = 0;
			manager.pauseact = true;
			pausa1.SetActive(true);
			controlact = false;
			combo = 0;
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
			var pausatemp = select1.GetComponent<pausa_al1>();
			pausatemp.mapa_();
			pausatemp.RestoreOriginalControls();
			controlact = false;
			combo = 0;
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
		
		camXc = controles.al1_3d.camX.ReadValue<float>();
		camYc = controles.al1_3d.camY.ReadValue<float>();
		marcarc = controles.al1_3d.marcar.ReadValue<float>();
		dispararc = controles.al1_3d.disparar.ReadValue<float>();
		
		
	}
	
			if(papaagotada == true && temppaparec > 10)
			{
				pistolabueno.Play();
				papaagotada = false;
				iconodisp.sprite = nopimg;
			}


			if(manager.datosserial.armasel == 1)
			{
				balaarmat.text = (int)((temppalo/60)*100)+"%";
				armanvt.text = "nv"+manager.datosserial.nivelarmapalo;
				if(manager.datosserial.nivelarmapalo == 1)
				{
					barraarmaimgnv1.fillAmount = manager.datosserial.nivelarmapaloexp/armapalosignv[manager.datosserial.nivelarmapalo-1];
					barraarmaimgnv2.fillAmount = 0;
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmapalo == 2)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = manager.datosserial.nivelarmapaloexp/armapalosignv[manager.datosserial.nivelarmapalo-1];
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmapalo == 3)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = manager.datosserial.nivelarmapaloexp/armapalosignv[manager.datosserial.nivelarmapalo-1];
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmapalo == 4)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = manager.datosserial.nivelarmapaloexp/armapalosignv[manager.datosserial.nivelarmapalo-1];
				}
				else if(manager.datosserial.nivelarmapalo == 5)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = 1;
				}
				

			}
			if(manager.datosserial.armasel == 2)
			{
				balaarmat.text = (int)((temppaparec/20)*100)+"%";
				armanvt.text = "nv"+manager.datosserial.nivelarmapapa;


				if(manager.datosserial.nivelarmapapa == 1)
				{
					barraarmaimgnv1.fillAmount = manager.datosserial.nivelarmapapaexp/armapapasignv[manager.datosserial.nivelarmapapa-1];
					barraarmaimgnv2.fillAmount = 0;
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmapapa == 2)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = manager.datosserial.nivelarmapapaexp/armapapasignv[manager.datosserial.nivelarmapapa-1];
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmapapa == 3)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = manager.datosserial.nivelarmapapaexp/armapapasignv[manager.datosserial.nivelarmapapa-1];
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmapapa == 4)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = manager.datosserial.nivelarmapapaexp/armapapasignv[manager.datosserial.nivelarmapapa-1];
				}
				else if(manager.datosserial.nivelarmapapa == 5)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = 1;
				}
			}
			if(manager.datosserial.armasel == 3)
			{
				balaarmat.text = (int)((tempdefrec/60)*100)+"%";
				armanvt.text = "nv"+manager.datosserial.nivelarmadef;
				if(manager.datosserial.nivelarmadef == 1)
				{
					barraarmaimgnv1.fillAmount = manager.datosserial.nivelarmadefexp/armadefsignv[manager.datosserial.nivelarmadef-1];
					barraarmaimgnv2.fillAmount = 0;
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmadef == 2)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = manager.datosserial.nivelarmadefexp/armadefsignv[manager.datosserial.nivelarmadef-1];
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmadef == 3)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = manager.datosserial.nivelarmadefexp/armadefsignv[manager.datosserial.nivelarmadef-1];
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmadef == 4)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = manager.datosserial.nivelarmadefexp/armadefsignv[manager.datosserial.nivelarmadef-1];
				}
				else if(manager.datosserial.nivelarmadef == 5)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = 1;
				}
				
			}
			if(manager.datosserial.armasel == 4)
			{
				balaarmat.text = (int)((temprelrec/40)*100)+"%";
				armanvt.text = "nv"+manager.datosserial.nivelarmarel;
				if(manager.datosserial.nivelarmarel == 1)
				{
					barraarmaimgnv1.fillAmount = manager.datosserial.nivelarmarelexp/armarelsignv[manager.datosserial.nivelarmarel-1];
					barraarmaimgnv2.fillAmount = 0;
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmarel == 2)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = manager.datosserial.nivelarmarelexp/armarelsignv[manager.datosserial.nivelarmarel-1];
					barraarmaimgnv3.fillAmount = 0;
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmarel == 3)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = manager.datosserial.nivelarmarelexp/armarelsignv[manager.datosserial.nivelarmarel-1];
					barraarmaimgnv4.fillAmount = 0;
				}
				else if(manager.datosserial.nivelarmarel == 4)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = manager.datosserial.nivelarmarelexp/armarelsignv[manager.datosserial.nivelarmarel-1];
				}
				else if(manager.datosserial.nivelarmarel == 5)
				{
					barraarmaimgnv1.fillAmount = 1;
					barraarmaimgnv2.fillAmount = 1;
					barraarmaimgnv3.fillAmount = 1;
					barraarmaimgnv4.fillAmount = 1;
				}
				
			}
		
		if(ruletac == 0)
		{
			
			if(manager.datosserial.tengolanzar == true)
			{

				paloimg.fillAmount = temppalo/60;
				circulopaloimg.fillAmount = temppalo/60;

				

				
			}
			if(manager.datosserial.armapapa == true)
			{
				pistolaimg.fillAmount = temppaparec/20; 
				circulopistolaimg.fillAmount = temppaparec/20;
			}
			if(manager.datosserial.armarelen == true)
			{
				relentizarimg.fillAmount = temprelrec/40; 
				circulorelentizarimg.fillAmount = temprelrec/40;
			}
			if(manager.datosserial.armadef == true)
			{
				armadefimg.fillAmount = tempdefrec/60; 
				circuloarmadefimg.fillAmount = tempdefrec/60;
			}
			if(cambioruedaact == 0)
			{
				numpoct.text = "";
				numpoc1t.text = "";
				numpoc2t.text = "";
				numpoc3t.text = "";
				numpoc4t.text = "";
				

				if(manager.datosserial.tengolanzar == false)
				{
					paloimg.sprite = nopimg;
					paloimg.color = new Color(1,1,1,1);
					backpaloimg.sprite = nopimg;
				}
				else
				{
					if(manager.datosserial.armasel != 1 && manager.datosserial.palosel == 1)
					{
						paloimg.sprite = arma1;
						paloimg.color = new Color(1,1,1,0.1f);
						backpaloimg.sprite = arma1;
						if(temppalo < 3)
						{
							paloimg.sprite = arma1;
							paloimg.color = new Color(1,1,1,0.1f);
							backpaloimg.sprite = arma1;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1)
					{
						if(manager.datosserial.nivelarmapalo == 1)
						{
							paloimg.sprite = arma1;
							backpaloimg.sprite = arma1;
						}
						else
						{
							paloimg.sprite = arma1_2;
							backpaloimg.sprite = arma1_2;
							
						}
						paloimg.color = new Color(1,1,1,1);						
						if(temppalo < 40)
						{
							paloimg.sprite = arma1;
							paloimg.color = new Color(1,1,1,1);
							backpaloimg.sprite = arma1;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2)
					{
						if(manager.datosserial.nivelarmapalo == 2)
						{
							paloimg.sprite = arma1_1;
							backpaloimg.sprite = arma1_1;
						}
						else
						{
							paloimg.sprite = arma1_3;
							backpaloimg.sprite = arma1_3;
						}
						paloimg.color = new Color(1,1,1,1);
						
						if(temppalo < 5)
						{
							paloimg.sprite = arma1;
							paloimg.color = new Color(1,1,1,1);
							backpaloimg.sprite = arma1;
						}
						
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3)
					{
						if(manager.datosserial.nivelarmapalo == 3)
						{
							paloimg.sprite = arma1_1;
							backpaloimg.sprite = arma1_1;
						}
						else
						{
							paloimg.sprite = arma1_4;
							backpaloimg.sprite = arma1_4;
						}
						paloimg.color = new Color(1,1,1,1);
						
						if(temppalo < 30)
						{
							paloimg.sprite = arma1;
							paloimg.color = new Color(1,1,1,1);
							backpaloimg.sprite = arma1;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4)
					{
						if(manager.datosserial.nivelarmapalo == 4)
						{
							paloimg.sprite = arma1_1;
							backpaloimg.sprite = arma1_1;
						}
						else
						{
							paloimg.sprite = arma1_5;
							backpaloimg.sprite = arma1_5;
						}
						paloimg.color = new Color(1,1,1,1);
						
						if(temppalo < 60)
						{
							paloimg.sprite = arma1;
							paloimg.color = new Color(1,1,1,1);
							backpaloimg.sprite = arma1;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5)
					{
						paloimg.sprite = arma1_1;
						paloimg.color = new Color(1,1,1,1);
						backpaloimg.sprite = arma1_1;
						if(temppalo < 3)
						{
							paloimg.sprite = arma1;
							paloimg.color = new Color(1,1,1,1);
							backpaloimg.sprite = arma1;
						}
					}
				}

				if(manager.datosserial.armapapa == false)
				{
					pistolaimg.sprite = nopimg;
					pistolaimg.color = new Color(1,1,1,1);
					backpistolaimg.sprite = nopimg;
				}
				else 
				{
					if(manager.datosserial.armasel == 2)
					{

						pistolaimg.sprite = armapaparueda;

						
						pistolaimg.color = new Color(1,1,1,1);
						backpistolaimg.sprite = armapaparueda;
						if(papaagotada == true)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,1);
							backpistolaimg.sprite = armapaparueda;
						}
					}
					else
					{
						pistolaimg.sprite = armapaparueda;
						pistolaimg.color = new Color(1,1,1,0.1f);
						backpistolaimg.sprite = armapaparueda;
						if(papaagotada == true)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,0.1f);
							backpistolaimg.sprite = armapaparueda;
						}
					}

				}

				if(manager.datosserial.armarelen == false)
				{
					relentizarimg.sprite = nopimg;
					relentizarimg.color = new Color(1,1,1,1);
					backrelentizarimg.sprite = nopimg;
				}
				else
				{
					if(manager.datosserial.armasel == 4)
					{
						relentizarimg.sprite = armarelrueda;
						relentizarimg.color = new Color(1,1,1,1);
						backrelentizarimg.sprite = armarelrueda;
						if(temprelrec < 40)
						{
							relentizarimg.sprite = armarelrueda;
							relentizarimg.color = new Color(1,1,1,1);
							backrelentizarimg.sprite = armarelrueda;
						}
					}
					else
					{
						relentizarimg.sprite = armarelrueda;
						relentizarimg.color = new Color(1,1,1,0.1f);
						backrelentizarimg.sprite = armarelrueda;
						if(temprelrec < 40)
						{
							relentizarimg.sprite =  armarelrueda;
							relentizarimg.color = new Color(1,1,1,0.1f);
							backrelentizarimg.sprite = armarelrueda;
						}
					}
				}
				
				if(manager.datosserial.armadef == false)
				{
					armadefimg.sprite = nopimg;
					armadefimg.color = new Color(1,1,1,1);
					backarmadefimg.sprite = nopimg;
					
				}
				else
				{
					if(manager.datosserial.armasel == 3)
					{
						armadefimg.sprite = armadefrueda;
						armadefimg.color = new Color(1,1,1,1);
						backarmadefimg.sprite = armadefrueda;
						if(tempdefrec < 60)
						{
							armadefimg.sprite = armadefrueda;
							armadefimg.color = new Color(1,1,1,1);
							backarmadefimg.sprite = armadefrueda;
						}
					}
					else
					{
						armadefimg.sprite = armadefrueda;
						armadefimg.color = new Color(1,1,1,0.1f);
						backarmadefimg.sprite = armadefrueda;
						if(tempdefrec < 60)
						{
							armadefimg.sprite = armadefrueda;
							armadefimg.color = new Color(1,1,1,0.1f);
							backarmadefimg.sprite = armadefrueda;
						}
					}
				}
				cambioruedaact = 1;
			}

			if(ruletaYc > 0f )
			{
				if(manager.datosserial.tengolanzar == true && tiempodisp > 0.2f)
				{
					paloimg.color = new Color(1,1,1,1f);

					if(manager.datosserial.armadef)
					{armadefimg.color = new Color(1,1,1,0.1f);}
					if(manager.datosserial.armarelen)
					{relentizarimg.color = new Color(1,1,1,0.1f);}
					if(manager.datosserial.armapapa)
					{pistolaimg.color = new Color(1,1,1,0.1f);}

					
					backpaloimg.color = new Color(1,1,1,0f);
					if(manager.datosserial.armasel != 1 || manager.datosserial.nivelarmapalo == manager.datosserial.palosel)
					{
						tiempodisp = 0;
						manager.datosserial.armasel = 1;
						manager.datosserial.palosel = 1;
						manager.guardar();
						iconodisp.sprite = arma1_1;
						if(manager.datosserial.nivelarmapalo == 1) 
						{
							paloimg.sprite = arma1;
							backpaloimg.sprite = arma1;
						}
						else if(manager.datosserial.nivelarmapalo >= 2)
						{
							paloimg.sprite = arma1_2;
							backpaloimg.sprite = arma1_2;
						}
					}
					else if(manager.datosserial.palosel == 1 && manager.datosserial.nivelarmapalo >= 2)
					{
						tiempodisp = 0;
						manager.datosserial.armasel = 1;
						manager.datosserial.palosel = 2;
						manager.guardar();
						iconodisp.sprite = arma1_2;
						paloimg.sprite = arma1_3;
						backpaloimg.sprite = arma1_3;


					}
					else if(manager.datosserial.palosel == 2 && manager.datosserial.nivelarmapalo >= 3)
					{
						tiempodisp = 0;
						manager.datosserial.armasel = 1;
						manager.datosserial.palosel = 3;
						manager.guardar();
						iconodisp.sprite = arma1_3;
						paloimg.sprite = arma1_4;
						backpaloimg.sprite = arma1_4;
					}
					else if(manager.datosserial.palosel == 3 && manager.datosserial.nivelarmapalo >= 4)
					{
						tiempodisp = 0;
						manager.datosserial.armasel = 1;
						manager.datosserial.palosel = 4;
						manager.guardar();
						iconodisp.sprite = arma1_4;
						paloimg.sprite = arma1_5;
						backpaloimg.sprite = arma1_5;	
					}
					else if(manager.datosserial.palosel == 4 && manager.datosserial.nivelarmapalo == 5)
					{
						tiempodisp = 0;
						manager.datosserial.armasel = 1;
						manager.datosserial.palosel = 5;
						manager.guardar();
						iconodisp.sprite = arma1_5;
						paloimg.sprite = arma1_1;
						backpaloimg.sprite = arma1_1;
					}
					pistolap.SetActive(false);
					pistolatiempo.SetActive(false);
					pistolabazoka.SetActive(false);
					
				}
			}
			if(ruletaYc < -0f )
			{
				
				if(manager.datosserial.armadef == true && tiempodisp > 0.2f)
				{
					if(manager.datosserial.tengolanzar)
					{paloimg.color = new Color(1,1,1,0.1f);}

					if(manager.datosserial.armarelen)
					{relentizarimg.color = new Color(1,1,1,0.1f);}

					if(manager.datosserial.armapapa)
					{pistolaimg.color = new Color(1,1,1,0.1f);}


					
					
					
					armadefimg.color = new Color(1,1,1,1f);
					backpaloimg.color = new Color(1,1,1,0.3f);


					balaprefabpapa = prebalapapal[manager.datosserial.nivelarmapapa -1];
					tiempodisp = 0;
					manager.datosserial.armasel = 3;
					manager.datosserial.palosel = 1;
					manager.guardar();
					iconodisp.sprite = arma3;
					if(manager.datosserial.tengolanzar == true)
					{paloimg.sprite = arma1;}
					else
					{
						paloimg.sprite = nopimg;
						backpaloimg.sprite = nopimg;
					}
					
					pistolap.SetActive(false);
					pistolatiempo.SetActive(false);
					pistolabazoka.SetActive(true);
					
				}
			}
			if(ruletaXc > 0f )
			{
				if(manager.datosserial.armapapa == true && tiempodisp > 0.2f)
				{
					pistolaimg.color = new Color(1,1,1,1f);


					if(manager.datosserial.tengolanzar)
					{paloimg.color = new Color(1,1,1,0.1f);}

					if(manager.datosserial.armarelen)
					{relentizarimg.color = new Color(1,1,1,0.1f);}

					if(manager.datosserial.armadef)
					{armadefimg.color = new Color(1,1,1,0.1f);}

					

					backpaloimg.color = new Color(1,1,1,0.3f);

					balaprefabrel = prebalarell[manager.datosserial.nivelarmarel -1];
					tiempodisp = 0;
					manager.datosserial.armasel = 2;
					manager.datosserial.palosel = 1;
					manager.guardar();
					if(papaagotada == true)
					{
						iconodisp.sprite = nopimg;
					}
					else
					{
						iconodisp.sprite = arma2;
					}
					
					if(manager.datosserial.tengolanzar == true)
					{paloimg.sprite = arma1;}
					else
					{
						paloimg.sprite = nopimg;
						backpaloimg.sprite = nopimg;
					}
					
					pistolap.SetActive(true);
					pistolatiempo.SetActive(false);
					pistolabazoka.SetActive(false);
				}
			}
			if(ruletaXc < -0f )
			{
				if(manager.datosserial.armarelen == true && tiempodisp > 0.2f)
				{
					
					if(manager.datosserial.tengolanzar)
					{paloimg.color = new Color(1,1,1,0.1f);}

					if(manager.datosserial.armapapa)
					{pistolaimg.color = new Color(1,1,1,0.1f);}

					if(manager.datosserial.armadef)
					{armadefimg.color = new Color(1,1,1,0.1f);}


					relentizarimg.color = new Color(1,1,1,1f);
					backpaloimg.color = new Color(1,1,1,0.3f);


					balaprefabdef = prebaladefl[manager.datosserial.nivelarmadef -1];
					tiempodisp = 0;
					manager.datosserial.armasel = 4;
					manager.datosserial.palosel = 1;
					manager.guardar();
					iconodisp.sprite = arma4;
					if(manager.datosserial.tengolanzar == true)
					{paloimg.sprite = arma1;}
					else
					{
						paloimg.sprite = nopimg;
						backpaloimg.sprite = nopimg;
					}
					
					pistolap.SetActive(false);
					pistolatiempo.SetActive(true);
					pistolabazoka.SetActive(false);
				}
			}
		}
		if(ruletac > 0 && manager.datosserial.pocionesmax > 0)
		{

			circulopaloimg.fillAmount = 1;
			circulopistolaimg.fillAmount = 1;
			circuloarmadefimg.fillAmount = 1;
			circulorelentizarimg.fillAmount = 1;
			paloimg.fillAmount = 1;
			pistolaimg.fillAmount = 1;
			armadefimg.fillAmount = 1;
			relentizarimg.fillAmount = 1;

			if(papaagotada == true && temppaparec > 10)
			{
				papaagotada = false;
			}
			if(cambioruedaact == 1)
			{
				paloimg.color = new Color(1,1,1,1);
				pistolaimg.color = new Color(1,1,1,1);
				relentizarimg.color = new Color(1,1,1,1);
				armadefimg.color = new Color(1,1,1,1);

				if(manager.datosserial.pocionesmax >=1)
				{
					numpoc1t.text = "1";

					paloimg.sprite = pocionvidaimg;
					backpaloimg.sprite = pocionvidaimg;

					numpoc2t.text = "1";


					armadefimg.sprite = pocionhabrec;
					backarmadefimg.sprite = pocionhabrec;
				}
				else
				{
					numpoc1t.text = "";

					paloimg.sprite = nopimg;
					backpaloimg.sprite = pocionvidaimg;

					numpoc2t.text = "";


					armadefimg.sprite = nopimg;
					backarmadefimg.sprite = pocionhabrec;
				}

				if(manager.datosserial.pocionesmax >=2)
				{
					numpoc3t.text = "2";



					relentizarimg.sprite = pocionrecimg;
					backrelentizarimg.sprite = pocionrecimg;
				}
				else
				{
					numpoc3t.text = "";

					relentizarimg.sprite = nopimg;
					backrelentizarimg.sprite = pocionrecimg;
				}

				if(manager.datosserial.pocionesmax >=3)
				{
					numpoc4t.text = "3";


					pistolaimg.sprite = berserkimg;
					backpistolaimg.sprite = berserkimg;
				}
				else
				{
					numpoc4t.text = "";
					pistolaimg.sprite = nopimg;
					backpistolaimg.sprite = berserkimg;
				}

				

				

				


				
				
				cambioruedaact = 0;
			}
			numpoct.text = numpociones.ToString();
			if(ruletaYc > 0f )
			{
				if(tiempodisp > 0.5f && numpociones >= 1 &&  vida < vidamax)
				{
					numpociones -= 1;
					tragar.Play();
					vida += vidamax/3.3f;
					if(vida > vidamax)
					{
						vida = vidamax;
					}
				}
			}

			if(ruletaYc < -0f )
			{
				if(tiempodisp > 0.5f && numpociones >= 1)
				{
					if(tempdefrec < 60 || temprelrec < 40 || temppalo < 60 || temppaparec < 20)
					{
					numpociones -= 1;
					tragar.Play();
					tempdefrec = 60;
					temprelrec = 40;
					temppalo = 60;
					temppaparec = 20;
					}
				}
			}
			if(ruletaXc > 0f )
			{
				if(tiempodisp > 0.5f && numpociones >= 3 && tempberserk == 0)
				{
					tragar.Play();
					numpociones -= 3;
					tempberserk = 20;
					vidaberserk = vida;
					danoextra += 2;
					berserkfin = true;
					
				}
			}
			if(ruletaXc < -0f )
			{
				if(tiempodisp > 0.5f && numpociones >= 2 && tempvelrec == 0 )
				{
					tragar.Play();
					numpociones -= 2;
					tempvelrec = 60;
					velrecextra += 2;
					velrecfin = true;
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

		if(tempvelrec == 0 && velrecfin == true)
		{
			danoextra += -2;
			velrecfin = false;
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
			
			
			
			if(lateralc == 0 && controlact == true|| ascensor == true && controlact == true|| objplaneta != null && controlact == true )
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

					if (objplaneta != null)
					{
						jugadorEntrando = true;
						camarascript.maxdis = 40;
						
						
						// Manejar la rotación de la cámara
						// Actualizar ángulos de rotación basados en la entrada del usuario
						cameraverticalangle += camYc / 3;
						cameraverticalangle = Mathf.Clamp(cameraverticalangle, -20, 20); // Limitar ángulo vertical
						
						cameraverticalangle2 += camXc;
						
						// Configurar boxcam2 para que esté correctamente orientado respecto a la superficie del planeta
							boxcam2.transform.rotation = Quaternion.LookRotation(
							Vector3.ProjectOnPlane(transform.forward, planetUp), 
							planetUp);
						 // Calcular vectores de dirección relativos a la superficie del planeta
							Vector3 direccionDerecha1 = Vector3.Cross(transform.up, transform.forward).normalized;
							Vector3 direccionAdelante1 = Vector3.Cross(direccionDerecha1, transform.up).normalized;
							
							// Preservar la velocidad vertical (relativa a la superficie del planeta)
							float velocidadVertical2 = Vector3.Dot(_rb.linearVelocity, transform.up);
							
							// Aplicar velocidad tangencial a la superficie del planeta usando ambas entradas
							
							
							// Calcular ángulo para la rotación del modelo basado en la dirección de entrada
							
							
							// Obtener la inclinación del jugador
							float inclinacionX = transform.rotation.eulerAngles.x;
							float inclinacionZ = transform.rotation.eulerAngles.z;
							
							// Normalizar ángulos a rango -180 a 180
							if (inclinacionX > 180) inclinacionX -= 360;
							if (inclinacionZ > 180) inclinacionZ -= 360;

							// Si el jugador está presionando el control de movimiento
							if (movXc != 0 || movYc != 0)
							{
								// Si el control acaba de ser activado (no estaba activo antes)
								if (!controlActivo)
								{
									controlActivo = true;
									// Comprobar si la inclinación justifica la inversión
									if (inclinacionX > 100 || inclinacionX < -100 || Mathf.Abs(inclinacionZ) > 90)
									{
										invertirHorizontal = true; // Invertir el estado
									}
									else
									{
										invertirHorizontal = false;
									}
								}
								
								// Aplicar la inversión si es necesario
								horizontalFinal = invertirHorizontal ? -movXc : movXc;
								
								// Usar las variables existentes para el movimiento
								_rb.linearVelocity = (direccionDerecha1 * horizontalFinal + direccionAdelante1 * movYc) * velocidad + transform.up * velocidadVertical2;
								planetUp = (transform.position - planetCenter).normalized;

								angulomod = Mathf.Atan2(horizontalFinal, movYc) * Mathf.Rad2Deg;
								mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, Quaternion.Euler(0, angulomod, 0), 30 * Time.deltaTime);

							}
							else // Si el jugador no está presionando el control de movimiento
							{
								controlActivo = false; // Resetear el estado del control
								// Mantener la velocidad actual o detener si no hay input
								_rb.linearVelocity = transform.up * Vector3.Dot(_rb.linearVelocity, transform.up); // Solo mantener la velocidad vertical
							}

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
							else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore) && dashefect == true)
							{
								if(hit.distance < 1f)
								{
								anim.SetBool("stat",true);
								dashefect = false;
								_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
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
							
						
					}
					else
					{


						if (jugadorEntrando == true)
						{
								
								boxcam2.transform.localRotation = Quaternion.Euler(0.35f, 0, 0);
								this.jugadorEntrando = false;
						}				
						
						if(movXc != 0 || movYc != 0)
						{
							// Movimiento normal cuando no está en modo planeta
							_rb.linearVelocity = transform.TransformDirection(new Vector3(movdirnow.x * velocidad, _rb.linearVelocity.y, movdirnow.z * velocidad));
							
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
						else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore)&& dashefect == true)
						{
							if(hit.distance < 1f)
							{
							anim.SetBool("stat",true);
							dashefect = false;
							_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
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
					
				


				

			}
			else if(lateralc > 0 && ascensor == false && objplaneta == null && controlact == true)
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

						_rb.linearVelocity = transform.TransformDirection(new Vector3 (movdirnow.x * velocidad,_rb.linearVelocity.y,movdirnow.z * velocidad));

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
					movdire = transform.TransformDirection(movdirnow * velocidad);
					float distaxe = movdire.magnitude * Time.fixedDeltaTime;
					movdire.Normalize();
					RaycastHit hit;

					if(movYc == 0f && movXc == 0f)
					{
						anim.SetBool("stat",true);
						dashefect = false;
						_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
					}
					else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore)&& dashefect == true)
					{
						if(hit.distance < 1f)
						{
						anim.SetBool("stat",true);
						dashefect = false;
						_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
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
            
		


		
		
			this.tiemposalto -= Time.deltaTime;
			if (this.tiemposalto <= 0f && saltarc > 0f && dialogueact == false && temppause > 0.4f && objplaneta == null && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
			else if (this.tiemposalto <= 0f && saltarc > 0f && dialogueact == false && temppause > 0.4f && objplaneta != null && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce((jumpforce + 700f) * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f ;
					anim.SetBool("salto",true);
					
			}
		
		
			if(manager.datosserial.tengolanzar == true )
			{

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1 && temppalo > 3  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && ascensor == false && controlact == true)
					{
						tiempodisp = 0;
						temppalo -= 3;
						toquespalo = 2;
						palo.GetComponent<golpe_al1>().dano = 2 * danoextra * nivelfuerza;
						anim.Play("arma3");
						anim.SetBool("arma3",true);
						tempatk = 0; 
						lanzarson.Play();
						if(manager.datosserial.nivelarmapalo < 5)
						{
							if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true )
							{
								manager.datosserial.nivelarmapaloexp += 5;
							}

							
							if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1] )
							{
								manager.datosserial.nivelarmapalo++;
								manager.datosserial.nivelarmapaloexp = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = "subiste La ParteCraneos a nivel "+manager.datosserial.nivelarmapalo;
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2 && temppalo > 40 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && ascensor == false && controlact == true )
					{
						tiempodisp = 0;
						temppalo -= 40;
						palo.GetComponent<golpe_al1>().dano = 5f * danoextra * nivelfuerza;
						toquespalo = 999;
						anim.Play("escudogiratorio");
						tempatk = 0; 
						
						escudohabaud.Play();
						if(manager.datosserial.nivelarmapalo < 5)
						{
							if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true )
							{
								manager.datosserial.nivelarmapaloexp += 5;
							}

							
							if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1] )
							{
								manager.datosserial.nivelarmapalo++;
								manager.datosserial.nivelarmapaloexp = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = "subiste La ParteCraneos a nivel "+manager.datosserial.nivelarmapalo;
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					if(anim.GetCurrentAnimatorStateInfo(1).IsName("escudogiratorio"))
					{
						stamina = 100;

					}

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && suelo == true && tiempodisp > 0.5f &&  dispararc > 0 && ascensor == false && controlact == true )
					{
						tiempodisp = 0;
						temppalo -= 5 * Time.deltaTime;
						palo.GetComponent<golpe_al1>().dano = 2 * danoextra * nivelfuerza;
						tempatk = 0;
						toquespalo = 999;
						transform.position = Vector3.MoveTowards(transform.position,transform.position + mod.transform.forward * 5, 20 * Time.deltaTime);
						anim.Play("dashtierra");
						anim.SetBool("dashtierra",true);
						dashairson.loop = true;
						dashairson.Play();
						mod.transform.rotation = Quaternion.Lerp(mod.transform.rotation,Quaternion.Euler(mod.transform.eulerAngles.x,camara.transform.eulerAngles.y,mod.transform.eulerAngles.z),10* Time.deltaTime);
						if(manager.datosserial.nivelarmapalo < 5)
						{
							if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true )
							{
								manager.datosserial.nivelarmapaloexp += 5;
							}

							
							if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1] )
							{
								manager.datosserial.nivelarmapalo++;
								manager.datosserial.nivelarmapaloexp = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = "subiste La ParteCraneos a nivel "+manager.datosserial.nivelarmapalo;
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra") && suelo == true &&  dispararc > 0 && ascensor == false && controlact == true )
					{
						tiempodisp = 0;
						temppalo -= 5 * Time.deltaTime;
						toquespalo = 999;
						palo.GetComponent<golpe_al1>().dano = 2 * danoextra * nivelfuerza;
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

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4 && temppalo > 30 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && ascensor == false && controlact == true)
					{
						tiempodisp = 0;
						temppalo -= 30;
						palo.GetComponent<golpe_al1>().dano = 15 * danoextra * nivelfuerza;
						tempatk = 0; 
						toquespalo = 15;
						anim.Play("espiralarea");
						dashairson.Play();
						if(manager.datosserial.nivelarmapalo < 5)
						{
							if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true )
							{
								manager.datosserial.nivelarmapaloexp += 5;
							}

							
							if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1] )
							{
								manager.datosserial.nivelarmapalo++;
								manager.datosserial.nivelarmapaloexp = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = "subiste La ParteCraneos a nivel "+manager.datosserial.nivelarmapalo;
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5 && temppalo >= 60 && inbuiract == false && tempinbuir  == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 && ascensor == false && controlact == true)
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
						if(manager.datosserial.nivelarmapalo < 5)
						{
							if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true )
							{
								manager.datosserial.nivelarmapaloexp += 5;
							}

							
							if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1] )
							{
								manager.datosserial.nivelarmapalo++;
								manager.datosserial.nivelarmapaloexp = 0;
								GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

								expltemp.transform.SetParent(this.gameObject.transform);

								Destroy(expltemp,5f);
								conseguido.text = "subiste La ParteCraneos a nivel "+manager.datosserial.nivelarmapalo;
								conseguidoa.Play("nivelsub2");
								
							}
						}
						manager.guardar();
					}
				
				if(golpearMc > 0 && suelo == true && tiempodisp > 0.7f  && combo == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") &&  dispararc == 0 && stamina > 10 )
				{
					anim.SetBool("atk",true);
					tiempodisp = 0;
					tempatk = 0; 
					palo.GetComponent<golpe_al1>().dano = 0.3f * danoextra * nivelfuerza;
					toquespalo = 999;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 1;
					stamina -= 10;
					staminaact = -2;
				}
				else if(golpearMc > 0 && suelo == true && tiempodisp > 0.2f && combo == 1 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk") &&  dispararc == 0 && stamina > 10 )
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
					palo.GetComponent<golpe_al1>().dano = 0.2f * danoextra;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 3;
				}
				else if(golpearMc > 0 && suelo == true && tiempodisp > 0.3f && combo == 3 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk2") &&  dispararc == 0  && stamina > 10)
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
					palo.GetComponent<golpe_al1>().dano = 0.5f * danoextra * nivelfuerza;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 5;
				}


				else if(golpearMc > 0 && suelo == true && combo == 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk3") &&  dispararc == 0 && stamina > 10 )
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
					palo.GetComponent<golpe_al1>().dano = 0.1f * danoextra * nivelfuerza;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 7;
				}
				else if(golpearMc > 0 && suelo == true && tiempodisp > 0.2f && combo == 7 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk4") &&  dispararc == 0 && stamina > 10)
				{
					anim.SetBool("atk5",true);
					combo = 8;
					stamina -= 10;
					staminaact = -2;
					
				}
				else if(suelo == true && combo == 8 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk5"))
				{
					tiempodisp = 0;
					tempatk = 0; 
					toquespalo = 999;
					palo.GetComponent<golpe_al1>().dano = 2 * danoextra * nivelfuerza;
					GameObject slasht = Instantiate(slash, mod.transform.position,mod.transform.rotation) as GameObject;
					slasht.transform.SetParent(mod.transform);
					Destroy(slasht,1f);
					golpeson.Play();
					combo = 0;
				}


				else if(golpearMc > 0 && suelo == false && ascensor == false &&  dispararc == 0  && stamina > 20)
				{
					anim.SetBool("atks",true);
					tiempodisp = 0;
					toquespalo = 999;
					palo.GetComponent<golpe_al1>().dano = 0.1f * danoextra * nivelfuerza;
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
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("staticar" ) )
				{
					anim.SetBool("atk2",false);
					anim.SetBool("atk3",false);
				}
				if(anim.GetCurrentAnimatorStateInfo(1).IsName("staticar" ) && anim.GetBool("atk")  == false && anim.GetBool("atk2")  == false && anim.GetBool("atk3") == false )
				{
					combo = 0;
				}
				if(manager.datosserial.armasel == 1)
				{
					if(ascensor == true)
					{
						iconodisp.sprite = nopimg;
					}
					if(ascensor == false)
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

			}
			if(manager.datosserial.armapapa == true && manager.datosserial.armasel == 2)
			{
				if(dispararc > 0 && ascensor == false && temppaparec >= balapapamun[manager.datosserial.nivelarmapapa -1] && tiempodisp > balapadrecaden[manager.datosserial.nivelarmapapa-1] && papaagotada == false && controlact == true)
				{
					if(manager.datosserial.nivelarmapapa < 5)
					{
						if(manager.datosserial.licenciaarmapapa[manager.datosserial.nivelarmapapa-1] == true )
						{
							manager.datosserial.nivelarmapapaexp++;
						}

						
						if(manager.datosserial.nivelarmapapaexp >= armapapasignv[manager.datosserial.nivelarmapapa-1])
						{
							manager.datosserial.nivelarmapapa++;
							manager.datosserial.nivelarmapapaexp = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = "subiste El Gatillazonador a nivel "+manager.datosserial.nivelarmapapa;
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefabpapa = prebalapapal[manager.datosserial.nivelarmapapa -1];
					tiempodisp = 0;
					temppaparec -= balapapamun[manager.datosserial.nivelarmapapa -1];

					GameObject BalaTemporal = Instantiate(balaprefabpapa, pistolap.transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * balapadrevel[manager.datosserial.nivelarmapapa-1]);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * balapadrevel[manager.datosserial.nivelarmapapa-1]);
					}

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 10;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balapadredano[manager.datosserial.nivelarmapapa-1] * nivelfuerza;
					

					disp.Play();

				}
				else if(dispararc > 0 && ascensor == false && temppaparec <= 1 && papaagotada == false)
				{
					papaagotada = true;
					temppaparec -= balapapamun[manager.datosserial.nivelarmapapa -1];
					iconodisp.sprite = nopimg;
					pistolamalo.Play();
				}
				if(ascensor == false)
				{
					iconodisp.sprite = arma2;
				}
				else if( ascensor == true)
				{
					iconodisp.sprite = nopimg;
				}
			}
			if(manager.datosserial.armarelen == true  && manager.datosserial.armasel == 4)
			{
				if(dispararc > 0 && ascensor == false && tiempodisp > 0.5f && temprelrec >= 40f && controlact == true)
				{
					

					if(manager.datosserial.nivelarmarel < 5)
					{
						if(manager.datosserial.licenciaarmarel[manager.datosserial.nivelarmarel-1] == true  )
						{
							manager.datosserial.nivelarmarelexp++;
						}

						
						if(manager.datosserial.nivelarmarelexp >= armarelsignv[manager.datosserial.nivelarmarel-1] )
						{
							manager.datosserial.nivelarmarel++;
							manager.datosserial.nivelarmarelexp = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = "subiste la HARMONIZADORA a nivel "+manager.datosserial.nivelarmarel;
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefabrel = prebalarell[manager.datosserial.nivelarmarel -1];
					temprelrec = 0;
					tiempodisp = 0; 

					GameObject BalaTemporal = Instantiate(balaprefabrel, pistolatiempo.transform.position,mod.transform.rotation) as GameObject;

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

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 15f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 50;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balareldano[manager.datosserial.nivelarmarel-1] * nivelfuerza;

					disprel.Play();

				}
				else if(tempdefrec >= 40f && ascensor == false)
				{
					iconodisp.sprite = arma4;
				}
				else if(tempdefrec < 40f || ascensor == true)
				{
					iconodisp.sprite = nopimg;
				}
			}
			if(manager.datosserial.armadef == true  && manager.datosserial.armasel == 3)
			{
				if(dispararc > 0 && ascensor == false && tiempodisp > 0.5f && tempdefrec >= 60f && manager.datosserial.armadefdesbloqueada == true && controlact == true || dispF == true && controlact == true)
				{

					
					if(manager.datosserial.nivelarmadef < 5)
					{
						if(manager.datosserial.licenciaarmadef[manager.datosserial.nivelarmadef-1] == true )
						{
							manager.datosserial.nivelarmadefexp++;
						}

						
						if(manager.datosserial.nivelarmadefexp >= armadefsignv[manager.datosserial.nivelarmadef-1] )
						{
							manager.datosserial.nivelarmadef++;
							manager.datosserial.nivelarmadefexp = 0;
							GameObject expltemp = Instantiate(subirnivelexpl, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

							expltemp.transform.SetParent(this.gameObject.transform);

							Destroy(expltemp,5f);
							conseguido.text = "subiste la PX4000 a nivel "+manager.datosserial.nivelarmadef;
							conseguidoa.Play("nivelsub2");
						}
					}
					manager.guardar();
					balaprefabdef = prebaladefl[manager.datosserial.nivelarmadef -1];
					tempdefrec = 0;
					tiempodisp = 0; 

					GameObject BalaTemporal = Instantiate(balaprefabdef, pistolabazoka.transform.position,mod.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
						rbb.AddForce(new Vector3(0,mod.transform.up.y,dirTarget.z) * 110 * 10);
					}
					else
					{
						rbb.AddForce(new Vector3(0,mod.transform.up.y,mod.transform.forward.z) * 110 * 10);
					}

					

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 30f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 300;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = baladefdano[manager.datosserial.nivelarmadef-1] * nivelfuerza;
					dispF = false;
					dispdef.Play();

				}
				else if(dispararc > 0 && ascensor == false && tiempodisp > 0.5f && tempdefrec >= 60f && manager.datosserial.armadefdesbloqueada == false && controlact == true)
				{
					armadefpass();

				}
				else if(tempdefrec >= 60f && ascensor == false)
				{
					iconodisp.sprite = arma3;
				}
				else if(tempdefrec < 60f || ascensor == true)
				{
					iconodisp.sprite = nopimg;
				}
			}
			

				
			
			
				
				if(dashc > 0 && tempdash > dash && suelo == false && manager.datosserial.tengodash == true && tiempodisp2 > 0.95f && tempaerodash > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && stamina > 0 && temppause > 0.4f && movdire != new Vector3(0,0,0)
				|| dashc > 0 && tempdash > dash && suelo == false && manager.datosserial.tengodash == true && tiempodisp2 > 0.95f && tempaerodash > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("escudogiratorio") && stamina > 0 && temppause > 0.4f && movdire != new Vector3(0,0,0))
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
					tiempodisp2 = 0;
					disdash = 10;
					veldash = 120;
					tempdash = 0;
					dashaeract = true;
					movdirectaux = movdire;
					dashairson.Play();
					stamina -= 15;
					staminaact = -2;
					tempaerodash = 0;
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
					dashefect = true;
					tiempodisp2 = 0;
					disdash = 10;
					veldash = 80;
					tempdash2 = 0;
					movdirectaux = movdire;
					dashson.Play();
					stamina -= 15;
					staminaact = -2;
					palo.GetComponent<golpe_al1>().dano = 0.1f * danoextra * nivelfuerza;
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
					dashefect = true;
					tiempodisp2 = 0;
					disdash = 10;
					veldash = 80;
					tempdash2 = 0;
					movdirectaux = movdire;
					dashson.Play();
					stamina -= 15;
					staminaact = -2;
					palo.GetComponent<golpe_al1>().dano = 0.1f * danoextra * nivelfuerza;
					toquespalo = 999;
				}
				Debug.DrawRay(transform.position + new Vector3(0,2,0),movdire * 100f, Color.green);
				if(tempdash > dash && tempdash2 > dash2 )
				{
					dashefect = false;
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
						
						if(hit.distance > veldash * Time.deltaTime)
						{
							Debug.Log("llego");
							transform.position = Vector3.MoveTowards(transform.position,transform.position + movdirectaux * disdash, veldash * Time.deltaTime);
						}
						else
						{
							Debug.Log("llego2");
							anim.SetBool("rueda",false);
							tempdash = 4;
							tempdash2 = 4;
							dashefect = false;
						}
					
					}
					else
					{
						Debug.Log("llego3");
						anim.SetBool("rueda",false);
						tempdash = 4;
						tempdash2 = 4;
						dashefect = false;
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
	
			if(correrc > 0 && velact != true && stamina > 0 && movYc != 0 && controlact == true
			|| correrc > 0 && velact != true && stamina > 0 && movXc != 0 && controlact == true)
			{
				stamina -= 7 * Time.deltaTime;
				staminaact = 0;
				velocidad = velocidadmaxima;
			}
			else if (velact != true){velocidad = velocidadaux;}
		
		if(temp10 < 15)
        {temp10 += 1 * Time.deltaTime;}
		if(tempaerodash < 15)
        {tempaerodash  += 1 * Time.deltaTime;}
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
		if(temppalo< 60)
        {temppalo += 1 * velrecextra * Time.deltaTime;}

		if(temppaparec < 0)
		{temppaparec = 0;}

		if(temppaparec< 20 && papaagotada == false)
        {temppaparec += 0.5f * velrecextra * Time.deltaTime;}
		else if(temppaparec< 20)
        {temppaparec += 0.25f * velrecextra * Time.deltaTime;}
		else{temppaparec = 20;}
		
		if(temppause < 20)
        {temppause  += 1 * Time.deltaTime;}
		else{temppause  = 20;}

		if(temprelrec< 40)
        {temprelrec += 1 * velrecextra * Time.deltaTime;}
		else{temprelrec = 40;}

		if(tempdefrec< 60)
        {tempdefrec += 1 * velrecextra * Time.deltaTime;}
		else{tempdefrec = 60;}

		if(tempberserk > 0)
        {tempberserk -= 1 * Time.deltaTime;}
		else{tempberserk = 0;}

		if(tempvelrec > 0)
        {tempvelrec -= 1 * Time.deltaTime;}
		else{tempvelrec = 0;}

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


		
			if(tempdash > dash)
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
		




		movXc = 0;
		movYc = 0;


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
		
		if (col.gameObject.tag == "suelo" || col.gameObject.tag == "ascensor" )
		{
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

		if (col.gameObject.tag == "suelo")
		{
			
			if(tiempovelint > 2)
			{suelo = true;}
			tempaerodash = 9;
		
		}
		if (col.gameObject.tag == "suelo"  || col.gameObject.tag == "ascensor" )
		{
			anim.SetBool("salto",false);
			
		}

	}


	// Token: 0x06000023 RID: 35 RVA: 0x00003284 File Offset: 0x00001484
	private void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "suelo" )
		{
			anim.SetBool("salto",true);
			suelo = false;
		}
	
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "suelo"   || col.gameObject.tag == "ascensor")
		{
			jumpforce = jumpforcebase;
			anim.SetBool("salto",false);
			dashaeract = false;

		
		}

		if (col.gameObject.tag == "dañox10" )
		{
			if(col.gameObject.GetComponent<romperbala_al1>() != null)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.armadef == false)
				{
					
					if(enec.salir == false && enec.paloact == false)
					{
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
			if(col.gameObject.GetComponent<baladef_exp_al1>() != null)
			{
				baladef_exp_al1 enec = col.gameObject.GetComponent<baladef_exp_al1>();

					
					if(enec.paloact == false)
					{


						muertesjug.Play();

						vida -= enec.danoj;
					}
				
			}
		}
		if (col.gameObject.tag == "pisar" )
		{
					Debug.Log("pisar");
					if(col.gameObject.GetComponent<pisar_al1>().enemigo == 1 )
					{
						
						
							enemigo1_al1 enec = col.gameObject.transform.parent.gameObject.transform.Find("enemigo").GetComponent<enemigo1_al1>();
							enec.vidapisar = true;


								if(col.gameObject != null)
								{
									
								
									if(enec.rb_ != null)
									{
										enec.rb_.AddRelativeForce(transform.forward * 110 * 2 * (enec.tamano + 1));
									}
									
									enec.danoene.Play();
									enec.temprb = 3;
								}
								if(enec.tamano == 0)
								{enec.vida -= enec.vidamax;}
								else if(enec.tamano == 1)
								{enec.vida -= enec.vidamax/3;}
								else if(enec.tamano == 2)
								{enec.vida -= enec.vidamax/6;}
								else if(enec.tamano == 3)
								{enec.vida -= enec.vidamax/9;}
								_rb.AddRelativeForce(transform.up * 110 * 7);
								vidaeneact = true;			
								vidaeneui = enec.vida;
								vidaeneuimax = enec.vidamax;
								niveleneui.text = enec.nivelactual.ToString();
								vidaenebarra.SetActive(true);
								if(eventotut != null)
								{eventotut.evento();}
								if(enec.vida < 1)
								{enec.temprb = 0;}
                				temprebote = 0;




            }
					if(col.gameObject.GetComponent<pisar_al1>().enemigo == 2 && manager.datosserial.niveljug > 1)
					{
						
							enemigo2_al1 enec = col.gameObject.transform.parent.gameObject.transform.Find("enemigo").GetComponent<enemigo2_al1>();
							enec.vida -= 1;
							if(col.gameObject != null)
							{
								_rb.AddRelativeForce(transform.up * 110 * 7);
								enec.danoene.Play();
								enec.temprb = 1;
								
							}
							vidaeneact = true;			
							vidaeneui = enec.vida;
							vidaeneuimax = enec.vidamax;
							niveleneui.text = enec.nivelactual.ToString();
							vidaenebarra.SetActive(true);
							if(enec.vida < 1)
							{enec.temprb = 0;}
							
						
				}
			
		}
		if (col.gameObject.tag == "cambio")
        {
            menushow.SetBool("show",true);
			comando.text = "cambiar direccion de compresion";
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
			if(col.gameObject.GetComponent<golpe_al1>() != null)
			{
				golpe_al1 enec = col.gameObject.GetComponent<golpe_al1>();
				if(enec.toquespalo > 0 && enec.paloact == false)
				{
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
			if(col.gameObject.GetComponent<golpe_al1>() != null)
			{
				golpe_al1 enec = col.gameObject.GetComponent<golpe_al1>();
				if(enec.toquespalo > 0 && enec.minmun == true  && enec.paloact == false)
				{
					eneempuj = col.gameObject;
					enmovdirectaux = transform.TransformDirection((enec.guia.transform.forward *70) + (enec.guia.transform.up * -50));
					enmovdirectaux = enmovdirectaux.normalized;
					tempempujon = 0;
					empujon = true;
					enec.toquespalo--;
					temppalo = 0;
					temppaparec = 0;
					tempdefrec = 0;
					temprelrec = 0;
					dest.Play();
				}
				else if(enec.toquespalo > 0 && enec.ultimo == true && enec.paloact == false)
				{
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
		if (col.gameObject.tag == "pisarboss" )
		{
			if(eneboss1.recdano <= 0)
			{
			GameObject explosiont = Instantiate(explosion, col.transform.position,col.transform.rotation) as GameObject;
			muertes.Play();
            Destroy(explosiont, 1f);
			eneboss1.vida -= eneboss1.vidamax/4;
			eneboss1.rb_.AddRelativeForce(transform.forward * 110 * -50);
			eneboss1.recdano = 5;
			transform.position = new Vector3(34.4f,510.2672f,417.3754f);
			transform.eulerAngles = new Vector3(0,0,0);
			camara.transform.eulerAngles = new Vector3(0,0,0);
			GameObject explosiont2 = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
			Destroy(explosiont2, 1f);
			}
		}
		if (col.gameObject.tag == "npc")
		{
			npcbase = col.GetComponent<npc_al1>();
			comando.text = npcbase.es_frase;
	    	menushow.SetBool("show",true);		
			dialogueact = false;
		}
		if (col.gameObject.tag == "evento")
		{
			eventosdialogueE = col.GetComponent<eventosdialogue>();
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

	}
	public void OnTriggerExit(Collider col)
	{
		

		if (col.gameObject.tag == "dañox10")
		{
			if(col.gameObject.GetComponent<romperbala_al1>() != null)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.armadef == false)
				{
					
					if(enec.salir == true && enec.paloact == false)
					{
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
	}
	public void OnTriggerStay(Collider col)
	{

		if (col.gameObject.tag == "pisar" && temprebote > 0.5f)
		{
					Debug.Log("pisar");
					if(col.gameObject.GetComponent<pisar_al1>().enemigo == 1 )
					{
						
						
							enemigo1_al1 enec = col.gameObject.transform.parent.gameObject.transform.Find("enemigo").GetComponent<enemigo1_al1>();
							enec.vidapisar = true;


								if(col.gameObject != null)
								{
									
								
									if(enec.rb_ != null)
									{
										enec.rb_.AddRelativeForce(transform.forward * 110 * 2 * (enec.tamano + 1));
									}
									
									enec.danoene.Play();
									enec.temprb = 3;
								}
								if(enec.tamano == 0)
								{enec.vida -= enec.vidamax;}
								else if(enec.tamano == 1)
								{enec.vida -= enec.vidamax/3;}
								else if(enec.tamano == 2)
								{enec.vida -= enec.vidamax/6;}
								else if(enec.tamano == 3)
								{enec.vida -= enec.vidamax/9;}
								_rb.AddRelativeForce(transform.up * 110 * 7);
								vidaeneact = true;			
								vidaeneui = enec.vida;
								vidaeneuimax = enec.vidamax;
								niveleneui.text = enec.nivelactual.ToString();
								vidaenebarra.SetActive(true);
								if(eventotut != null)
								{eventotut.evento();}
								if(enec.vida < 1)
								{enec.temprb = 0;}
                				temprebote = 0;




            }
					if(col.gameObject.GetComponent<pisar_al1>().enemigo == 2 && manager.datosserial.niveljug > 1)
					{
						
							enemigo2_al1 enec = col.gameObject.transform.parent.gameObject.transform.Find("enemigo").GetComponent<enemigo2_al1>();
							enec.vida -= 1;
							if(col.gameObject != null)
							{
								_rb.AddRelativeForce(transform.up * 110 * 7);
								enec.danoene.Play();
								enec.temprb = 1;
								
							}
							vidaeneact = true;			
							vidaeneui = enec.vida;
							vidaeneuimax = enec.vidamax;
							niveleneui.text = enec.nivelactual.ToString();
							vidaenebarra.SetActive(true);
							if(enec.vida < 1)
							{enec.temprb = 0;}
							
						
				}
			
		}
		
		if (col.gameObject.tag == "npc")
		{
			if (controles.al1_UI.interactuar.ReadValue<float>() > 0f && dialogueact == false && tiempodialogue > 0.7f)
			{
				
				menushow.SetBool("show",false);
				if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
				{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
				
				
				if(misionA.tiendaact == false)
				{
				manager.misionS = col.gameObject.GetComponent<npc_al1>().mision;
				misionA.misionS = col.gameObject.GetComponent<npc_al1>().mision;
				misionA.npcid = col.gameObject.GetComponent<npc_al1>().managernpc.npcID;
				misionA.premiocant = col.gameObject.GetComponent<npc_al1>().npc_precio;
				}

				menuoff.StartDialogue(npcbase.DialogueSO,npcbase.dialogueid);
				dialogueact = true;
				tiempodialogue = 0;
				manager.controlene = false;

				
			}
			else if (controles.al1_UI.cinnext.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
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
			eventosdialogueE = col.GetComponent<eventosdialogue>();
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
				if (controles.al1_UI.cinnext.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
				{
					if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == true)
					{
						vozMeet.Stop();
						menuoff.SkipDialogue();
						tiempodialogue = 0;
						tiemposalto = 0.7f;
					}
					
				}
				if(menuoff != null)
				{
					if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == false && eventoini == false)
					{
						dialogueact = false;
						manager.controlene = true;
						controlact = true;
						tiemposalto = 0.7f;
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
	public void armadefpass()
	{

			Time.timeScale = 0;
			manager.pauseact = true;
			armadefpassC.SetActive(true);
			controlact = false;
			combo = 0;
			dispararc = 0;
			temp10 = 0;
			if(manager.datosconfig.plat == 2)
			{
				tactil.SetActive(false);
			}
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
	}

	
	
}
