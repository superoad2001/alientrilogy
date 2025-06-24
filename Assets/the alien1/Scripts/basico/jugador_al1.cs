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
public class jugador_al1 : MonoBehaviour
{
    public List<GameObject> enemigosEnContacto = new List<GameObject>();
	private bool enetouch;
	public bool dispF;
	private float tempaerodash = 9;
	public GameObject tiendaG;
	public AudioSource musicajuego;
	public AudioSource musicaC;
	public AudioSource musicanoC;
	public AudioSource combini;
	public AudioSource combfin;
	private float menupadH;
	private float menupadV;
	public Vector3 planetUp;
	public bool static_ev = false;
	public int toquespalo;
	public Vector3 planetCenter;
	public tutorialbase_al1 eventotut;
	public eventosdialogue eventosdialogueE;
	public bool eventoini;
	private int cambioruedaact;
	private Vector3 direccion;
	public float staminaact = 50;
	private float velrecextra = 1;
	public Vector3 enmovdirectaux;
	private bool berserkfin;
	private bool inbuiract;
	public float temppause;
	private float tempinbuir;
	private bool velrecfin;
	private float danoextra = 1;
	private float tempberserk;
	private float tempvelrec;
	private float vidaberserk;
	public bool actzonaespecial;
	public int indicetarget = -1;
	private float angulomod;
	public float r3;
	public GameObject pistolatiempo;
	public GameObject pistolabazoka;
	private float camaux = 0;
	private float modaux = 0;
	private int palosel;
	private bool papaagotada;
	public float tempempujon;
	public bool tarbossact;
	private bool actTarget;
	private float xp;
	public float girodir = -90;

	public int combo;
	private float temppalo = 60;
	private float tempatk;
	private int numpociones;
	public float disjugsave;
	public bool camnomov;
	public float vida = 5;
	private float tiempodialogue;
	public bool dialogueact;
	public float balavel = 20;
	private float velcorr = 12;
	public bool controlact = true;
	private float temppaso = 1;
	public float rotspeed = 3;
	public Quaternion fij;
	public Vector3 eneempujp;
	private float cameraverticalangle;
	private float cameraverticalangle2;
	public Vector3 rotationinput;
	public float speed = 3;
	private bool suelo;
	public bool velact;
	private float tiempodisp;
	public float girovalor;
	private bool girotder = false;
	private bool girotizq = false;
	private bool girotd_der = false;
	private bool girotd_izq = false;
	public bool jugadorEntrando;
	public GameObject objplaneta;
	public float lhorizontalc;
	public float lverticalc;
	public float rhorizontalc;
	public float rverticalc;
	private float a;
	private float b;
	private float x;
	private float y;
	private float rb;
	public float rt;
	private float lt;
	private float l3;
	private float horizontalpad;
	private float verticalpad;
	private int randompaso;
	private float pausac;
	private float selectc;
	private float pasotiempo;
	public float tempgir = 0;
	private float tempdash = 12;
	private float tempdash2 = 12;
	private float velocidadalien;

	public float tempdefrec = 60f; 
	public float temprelrec = 40f; 
	public float temppaparec = 20f; 

	public float vidabasetut = 9;
    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;

    public float fuebasetut = 1;
    public float fuebase = 2;
    public float fuebasemax = 5;
    public float fueplusmax = 10;


    public float nivelfuerza;
    public float nivelvida;
    public float []nivelfuerza_a = new float[100];
    public float []nivelvida_a = new float[100];

	public float []armapalosignv = new float[5];
	public float []armadefsignv = new float[5];
	public float []armapapasignv = new float[5];
	public float []armarelsignv = new float[5];

	public float vidamax;
	public bool tposepause;
	public float jugpos;
	public bool bocaabajo;
	private Vector3 inputDirection1;
	public bool invertirHorizontal = false;
	private bool controlActivo = false; 
	public float horizontalFinal;
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

		musicajuego = musicanoC;
		musicajuego.Play();
		musicajuego.time = Random.Range(0,20);
		stamina = staminamax;
		tiempovelint = 3;

		
		if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}
		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

		camarascript = (camara_al1)FindFirstObjectByType(typeof(camara_al1));
		

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


		if(manager.juego == 0 || manager.juego == 4)
		{
			camara.transform.eulerAngles = new Vector3(0,0,0);
		}
		if(manager.juego == 3 || manager.juego == 4)
		{

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
		}


		if((enemigo1boss_al1)FindFirstObjectByType(typeof(enemigo1boss_al1)) != null)
		{
			eneboss1 = (enemigo1boss_al1)FindFirstObjectByType(typeof(enemigo1boss_al1));
		}
		numpociones = manager.datosserial.pocionesmax;
		
		if(manager.juego != -1)
		{
			if(manager.datosconfig.plat == 1)
			{
				tactil.SetActive(false);
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			}
			if(manager.datosconfig.plat == 2)
			{
				tactil.SetActive(true);
			}
		}
		if(manager.juego == 4 || manager.juego == 3)
		{
			velocidad = 8;
			velocidadaux = 8;
			velocidadmaxima = 13;
			jumpforce = 700;
			camara.transform.rotation = Quaternion.Euler(0,180,0);
		}
		if(manager.juego ==0)
		{
			velocidad = 4;
			velocidadaux = 4;
			velocidadmaxima = 8;
			jumpforce = 200;
			camara.transform.rotation = Quaternion.Euler(0,180,0);
		}
		this._rb = base.GetComponent<Rigidbody>();
		velocidadaux = velocidad;
		girovalor = base.transform.eulerAngles.y;
		jumpforcebase = jumpforce;
		if(manager.juego == 3)
        { 
                this.jugadorEntrando = true;
        }
        if(manager.juego == 4)
        { 
                this.jugadorEntrando = false;
        }
		if(anim != null)
		{
			anim.updateMode = AnimatorUpdateMode.Fixed;
		}
		if(manager.juego == 4 || manager.juego == 3 || manager.juego == 0)
		{
			mod = this.gameObject.transform.GetChild(0).gameObject;
		}
		vida = vidamax;
		if(manager.datosserial.tengopalo == false)
		{

			if(manager.juego == 4 || manager.juego == 3 || manager.juego == 0)
			{
			palo.SetActive(false);
			}
		}
		if(manager.juego == 4 || manager.juego == 3)
		{
			vidaenebarra.SetActive(false);
		}
		if(dimensiion == true)
		{
			jugpos = transform.localPosition.x;
		}
		else if(dimensiion == false)
		{
			jugpos = transform.localPosition.z;
		}
		if(manager.juego == 4 )
		{
			camara.transform.eulerAngles = new Vector3(camara.transform.eulerAngles.x,transform.eulerAngles.y,camara.transform.eulerAngles.z);
		}
		
	}
	public float tiempoascensor = 0;
	private bool subir0 = false;
	private bool bajar1 = false;
	private bool subir1 = false;
	private bool bajar2 = false; 
	private bool subir2 = false;
	private bool bajar3 = false;
	private bool subir3 = false;
	private bool bajar4 = false;
	private bool subir4 = false;
	private bool bajar5 = false;
	private bool subir5 = false;
	private bool bajart1 = false;
	private bool subirt1 = false;
	private bool bajart2 = false;
	private bool subirt2 = false;
	private bool bajart3 = false;
	private bool subirt3 = false;
	private bool bajart4 = false;
	private bool subirt4 = false;
	private bool bajart5 = false;
	private bool bajar1esp = false;
	public bool bajar = false;
	public bool subir = false;
	private bool moverdelante = true;
	private float temp9;
	public float temp10;
	public bool dashaeract;

	private float dash = 0.3f;
	private float dash2 = 0.3f;
	public bool ascact;
	public bool muerte;
	public bool cronoact;
	public float lb;

	public float vidaeneui;
	public float vidaeneuimax;
	public bool vidaeneact;
	public float staminamax = 100;
	public float stamina;
	public float vidaescudoene;
	public float vidaescudomaxene;
	public bool escudoeneact;
	private bool _peligro;
	public bool peligro
	{
		get { return _peligro; }
		set 
		{ 
			if (_peligro != value)
			{
				_peligro = value;
				fixedActualizarMusica();
			}
		}
	}
	// Token: 0x0600001E RID: 30 RVA: 0x00002604 File Offset: 0x00000804
	public void fixedActualizarMusica()
	{
		if(peligro && manager.juego == 3 && tarbossact == false || peligro && manager.juego == 4 && tarbossact == false)
		{
			musicajuego.Stop();
			musicajuego = musicaC;
			musicajuego.Play();
			combini.Play();
			musicajuego.time = Random.Range(0,20);
		}
		if( peligro == false && manager.juego == 3 && tarbossact == false || peligro == false && manager.juego == 4 && tarbossact == false)
		{
			combini.Stop();
			musicajuego.Stop();
			musicajuego = musicanoC;
			musicajuego.Play();
			musicajuego.time = Random.Range(0,20);
		}
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
	
	
	noarmasel.SetActive(false);
	if(manager.datosserial.tengolanzar == true || manager.datosserial.armapapa == true || manager.datosserial.armarelen == true || manager.datosserial.armadef == true)
	{
		noarmasel.SetActive(true);
	}
	if(vidaeneact)
	{vidaeneimg.fillAmount = vidaeneui/vidaeneuimax;}

	if(escudoeneact)
	{
		escudoeneimg.fillAmount = vidaescudoene/vidaescudomaxene;
	}
	else
	{
		escudoeneimg.fillAmount = 0;
	}

	if(manager.juego == 1)
	{
		anim.SetBool("act2",true);
	}
	if(manager.juego == 2)
	{
		anim.SetBool("act",true);
	}
	if(vida < 1)
	{
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
			SceneManager.LoadScene("tutorialcin2enc_al1");
		}
		
	}
	if(manager.juego != 6 && manager.juego != 0 && manager.juego != 1  && manager.juego != 2 && cronoact == false )
	{
		vidab.fillAmount = vida/vidamax; 
		vidat.text = "VIT:"+(int)vida+"/"+(int)vidamax;
		niverlbarra.fillAmount = manager.datosserial.nivelexp/manager.datosserial.signivelexp; 
		niveluit.text = "LEVEL "+ manager.datosserial.niveljug;
		staminabarra.fillAmount = stamina/staminamax;
	}
	if(ascensors != null && ascact == true)
	{
		ascensors.SetFloat("asc",0);
		ascensors.SetFloat("asc2",0);
	}
	else if(ascensors != null && ascact == false)
	{
		if(manager.datosserial.asc == 0)
		{
			tiempoascensor = 3;
		}
		ascensors.SetFloat("asc",manager.datosserial.asc);
		manager.datosserial.asc = 0;
		manager.guardar();
		ascact = true;

	}
	
	if(tiempoascensor < 15)	
	{tiempoascensor += Time.deltaTime;}

	if(controlact == true)
	{

		if(manager.juego == 3)
		{
			rhorizontalc = controles.al1_2d.rhorizontal.ReadValue<float>();
			rverticalc = controles.al1_2d.rvertical.ReadValue<float>();


			lhorizontalc = controles.al1_2d.lhorizontal.ReadValue<float>();
			lverticalc = controles.al1_2d.lvertical.ReadValue<float>();
			


			



			if(controles.al1_2d.padder.ReadValue<float>() > 0 && horizontalpad >= 0)
			{
				horizontalpad = controles.al1_2d.padder.ReadValue<float>();
			}
			else if(controles.al1_2d.padizq.ReadValue<float>() > 0 && horizontalpad <= 0)
			{
				horizontalpad = controles.al1_2d.padizq.ReadValue<float>() - (controles.al1_2d.padizq.ReadValue<float>() * 2);
			}
			else{horizontalpad = 0;}


			if(controles.al1_2d.padarr.ReadValue<float>() > 0 && verticalpad >= 0)
			{
				verticalpad = controles.al1_2d.padarr.ReadValue<float>();
			}
			else if(controles.al1_2d.padabj.ReadValue<float>() > 0 && verticalpad <= 0)
			{
				verticalpad = controles.al1_2d.padabj.ReadValue<float>() - (controles.al1_2d.padabj.ReadValue<float>() * 2);
			}
			else{verticalpad = 0;}

		}
		else if(manager.juego == 4)
		{

			rhorizontalc = controles.al1_3d.rhorizontal.ReadValue<float>();
			rverticalc = controles.al1_3d.rvertical.ReadValue<float>();
			

			lhorizontalc = controles.al1_3d.lhorizontal.ReadValue<float>();
			lverticalc = controles.al1_3d.lvertical.ReadValue<float>();





			if(controles.al1_3d.padder.ReadValue<float>() > 0 && horizontalpad >= 0)
			{
				horizontalpad = controles.al1_3d.padder.ReadValue<float>();
			}
			else if(controles.al1_3d.padizq.ReadValue<float>() > 0 && horizontalpad <= 0)
			{
				horizontalpad = controles.al1_3d.padizq.ReadValue<float>() - (controles.al1_3d.padizq.ReadValue<float>() * 2);
			}
			else{horizontalpad = 0;}

			if(controles.al1_3d.padarr.ReadValue<float>() > 0 && verticalpad >= 0)
			{
				verticalpad = controles.al1_3d.padarr.ReadValue<float>();
			}
			else if(controles.al1_3d.padabj.ReadValue<float>() > 0 && verticalpad <= 0)
			{
				verticalpad = controles.al1_3d.padabj.ReadValue<float>() - (controles.al1_3d.padabj.ReadValue<float>() * 2);
			}
			else{verticalpad = 0;}
		}
		else
		{

			
			rhorizontalc = controles.al1_general.rhorizontal.ReadValue<float>();
			rverticalc = controles.al1_general.rvertical.ReadValue<float>();
			

			lhorizontalc = controles.al1_general.lhorizontal.ReadValue<float>();
			lverticalc = controles.al1_general.lvertical.ReadValue<float>();


			



			if(controles.al1_general.padder.ReadValue<float>() > 0 && horizontalpad >= 0)
			{
				horizontalpad = controles.al1_general.padder.ReadValue<float>();
			}
			else if(controles.al1_general.padizq.ReadValue<float>() > 0 && horizontalpad <= 0)
			{
				horizontalpad = controles.al1_general.padizq.ReadValue<float>() - (controles.al1_general.padizq.ReadValue<float>() * 2);
			}
			else{horizontalpad = 0;}

			if(controles.al1_general.padarr.ReadValue<float>() > 0 && verticalpad >= 0)
			{
				verticalpad = controles.al1_general.padarr.ReadValue<float>();
			}
			else if(controles.al1_general.padabj.ReadValue<float>() > 0 && verticalpad <= 0)
			{
				verticalpad = controles.al1_general.padabj.ReadValue<float>() - (controles.al1_general.padabj.ReadValue<float>() * 2);
			}
			else{verticalpad = 0;}
		}

		if(controles.al1_general.lder.ReadValue<float>() > 0 && menupadH >= 0)
		{
			menupadH = controles.al1_general.lder.ReadValue<float>();
		}
		else if(controles.al1_general.lizq.ReadValue<float>() > 0 && menupadH <= 0)
		{
			menupadH = controles.al1_general.lizq.ReadValue<float>() - (controles.al1_general.lizq.ReadValue<float>() * 2);
		}
		else{menupadH = 0;}

		if(controles.al1_general.larr.ReadValue<float>() > 0 && menupadV >= 0)
		{
			menupadV = controles.al1_general.larr.ReadValue<float>();
		}
		else if(controles.al1_general.labj.ReadValue<float>() > 0 && menupadV <= 0)
		{
			menupadV = controles.al1_general.labj.ReadValue<float>() - (controles.al1_general.labj.ReadValue<float>() * 2);
		}
		else{menupadV = 0;}



		a = controles.al1_general.a.ReadValue<float>();
		b = controles.al1_general.b.ReadValue<float>();
		x = controles.al1_general.x.ReadValue<float>();
		xp = controles.al1_general.xpress.ReadValue<float>();
		y = controles.al1_general.y.ReadValue<float>();

		
		rt = controles.al1_general.rt.ReadValue<float>();
		lb = controles.al1_general.lb.ReadValue<float>();
		
		l3 = controles.al1_general.l3.ReadValue<float>();
		r3 = controles.al1_general.r3.ReadValue<float>();


		if(manager.datosconfig.plat == 2)
		{
			if(manager.juego == 4)
			{
				if(controles.al1_general.lt.ReadValue<float>() > 0 && lt == 1 && temp9 > 0.5f)
				{
					lt = 0;
					temp9 = 0;
				}
				else if(controles.al1_general.lt.ReadValue<float>() > 0 && lt == 0  && temp9 > 0.5f)
				{
					lt = 1;
					temp9 = 0;
				}

				if(controles.al1_general.rb.ReadValue<float>() > 0 && rb == 1 && temp9 > 0.5f)
				{
					lt = 0;
					temp9 = 0;
				}
				else if(controles.al1_general.rb.ReadValue<float>() > 0 && rb == 0  && temp9 > 0.5f)
				{
					lt = 1;
					temp9 = 0;
				}
			}
			if(manager.juego == 3)
			{

				if(controles.al1_general.rb.ReadValue<float>() > 0 && rb == 1 && temp9 > 0.5f)
				{
					lt = 0;
					temp9 = 0;
				}
				else if(controles.al1_general.rb.ReadValue<float>() > 0 && rb == 0  && temp9 > 0.5f)
				{
					lt = 1;
					temp9 = 0;
				}
			}
			else
			{		
				lt = controles.al1_general.lt.ReadValue<float>();
				rb = controles.al1_general.rb.ReadValue<float>();		
			}
			
		}
		else
		{
		rb = controles.al1_general.rb.ReadValue<float>();
		lt = controles.al1_general.lt.ReadValue<float>();
		}

		pausac = controles.al1_general.pausa.ReadValue<float>();

		selectc = controles.al1_general.select.ReadValue<float>();
		

		if (pausac > 0 && temp10 > 0.7f)
		{
			Time.timeScale = 0;
			manager.pauseact = true;
			pausa1.SetActive(true);
			controlact = false;
			combo = 0;
			if(manager.juego == 1)
			{
				anim.SetBool("act2",true);
			}
			if(manager.juego == 2)
			{
				anim.SetBool("act",true);
			}
			pausac = 0;
			temp10 = 0;
			if(manager.datosconfig.plat == 2)
			{
				tactil.SetActive(false);
			}
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}

		else if (selectc > 0 && temp10 > 0.7f)
		{
			Time.timeScale = 0;
			manager.pauseact = true;
			select1.SetActive(true);
			controlact = false;
			combo = 0;
			if(manager.juego == 1)
			{
				anim.SetBool("act2",true);
			}
			if(manager.juego == 2)
			{
				anim.SetBool("act",true);
			}
			selectc = 0;
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
		if(manager.juego == 3)
		{
		rhorizontalc = controles.al1_2d.lhorizontal.ReadValue<float>();
		rverticalc = controles.al1_2d.rvertical.ReadValue<float>();
		}
		if(manager.juego == 4)
		{
		rhorizontalc = controles.al1_3d.rhorizontal.ReadValue<float>();
		rverticalc = controles.al1_3d.rvertical.ReadValue<float>();
		}
		else
		{
		rhorizontalc = controles.al1_general.rhorizontal.ReadValue<float>();
		rverticalc = controles.al1_general.rvertical.ReadValue<float>();
		}
	}
	if(manager.juego == 4 || manager.juego == 3)
	{
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
		
		if(lb == 0)
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
					backpaloimg.sprite = arma1;
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
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,0.1f);
							backpistolaimg.sprite = armapaparueda;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1)
					{
						paloimg.sprite = arma1_2;
						paloimg.color = new Color(1,1,1,1);
						backpaloimg.sprite = arma1_2;
						if(temppalo < 40)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,1);
							backpistolaimg.sprite = armapaparueda;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2)
					{
						paloimg.sprite = arma1_3;
						paloimg.color = new Color(1,1,1,1);
						backpaloimg.sprite = arma1_3;
						if(temppalo < 5)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,1);
							backpistolaimg.sprite = armapaparueda;
						}
						
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3)
					{
						paloimg.sprite = arma1_4;
						paloimg.color = new Color(1,1,1,1);
						backpaloimg.sprite = arma1_4;
						if(temppalo < 30)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,1);
							backpistolaimg.sprite = armapaparueda;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4)
					{
						paloimg.sprite = arma1_5;
						paloimg.color = new Color(1,1,1,1);
						backpaloimg.sprite = arma1_5;
						if(temppalo < 60)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,1);
							backpistolaimg.sprite = armapaparueda;
						}
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5)
					{
						paloimg.sprite = arma1_1;
						paloimg.color = new Color(1,1,1,1);
						backpaloimg.sprite = arma1_1;
						if(temppalo < 3)
						{
							pistolaimg.sprite = nopimg;
							pistolaimg.color = new Color(1,1,1,1);
							backpistolaimg.sprite = armapaparueda;
						}
					}
				}

				if(manager.datosserial.armapapa == false)
				{
					pistolaimg.sprite = nopimg;
					pistolaimg.color = new Color(1,1,1,1);
					backpistolaimg.sprite = armapaparueda;
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
					backrelentizarimg.sprite = armarelrueda;
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
							relentizarimg.sprite = nopimg;
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
							relentizarimg.sprite = nopimg;
							relentizarimg.color = new Color(1,1,1,0.1f);
							backrelentizarimg.sprite = armarelrueda;
						}
					}
				}
				
				if(manager.datosserial.armadef == false)
				{
					armadefimg.sprite = nopimg;
					armadefimg.color = new Color(1,1,1,1);
					backarmadefimg.sprite = armadefrueda;
					
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
							armadefimg.sprite = nopimg;
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
							armadefimg.sprite = nopimg;
							armadefimg.color = new Color(1,1,1,0.1f);
							backarmadefimg.sprite = armadefrueda;
						}
					}
				}
				cambioruedaact = 1;
			}

			if(verticalpad > 0.5f && manager.juego == 4 || rverticalc > 0.5f && manager.juego == 3)
			{
				if(manager.datosserial.tengolanzar == true && tiempodisp > 0.2f)
				{
					paloimg.color = new Color(1,1,1,1f);
					pistolaimg.color = new Color(1,1,1,0.1f);
					relentizarimg.color = new Color(1,1,1,0.1f);
					armadefimg.color = new Color(1,1,1,0.1f);
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
			if(verticalpad < -0.5f && manager.juego == 4 || rverticalc < -0.5f && manager.juego == 3)
			{
				
				if(manager.datosserial.armadef == true && tiempodisp > 0.2f)
				{
					paloimg.color = new Color(1,1,1,0.1f);
					pistolaimg.color = new Color(1,1,1,0.1f);
					relentizarimg.color = new Color(1,1,1,0.1f);
					armadefimg.color = new Color(1,1,1,1f);


					balaprefabpapa = prebalapapal[manager.datosserial.nivelarmapapa -1];
					tiempodisp = 0;
					manager.datosserial.armasel = 3;
					manager.datosserial.palosel = 1;
					manager.guardar();
					iconodisp.sprite = arma3;
					if(manager.datosserial.tengolanzar == true)
					{paloimg.sprite = arma1;}
					else
					{paloimg.sprite = nopimg;}
					backpaloimg.sprite = arma1;
					pistolap.SetActive(false);
					pistolatiempo.SetActive(false);
					pistolabazoka.SetActive(true);
					
				}
			}
			if(horizontalpad > 0.5f && manager.juego == 4 || rhorizontalc > 0.5f && manager.juego == 3)
			{
				if(manager.datosserial.armapapa == true && tiempodisp > 0.2f)
				{
					paloimg.color = new Color(1,1,1,0.1f);
					pistolaimg.color = new Color(1,1,1,1f);
					relentizarimg.color = new Color(1,1,1,0.1f);
					armadefimg.color = new Color(1,1,1,0.1f);

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
					{paloimg.sprite = nopimg;}
					backpaloimg.sprite = arma1;
					pistolap.SetActive(true);
					pistolatiempo.SetActive(false);
					pistolabazoka.SetActive(false);
				}
			}
			if(horizontalpad < -0.5f && manager.juego == 4 || rhorizontalc < -0.5f && manager.juego == 3)
			{
				if(manager.datosserial.armarelen == true && tiempodisp > 0.2f)
				{

					paloimg.color = new Color(1,1,1,0.1f);
					pistolaimg.color = new Color(1,1,1,0.1f);
					relentizarimg.color = new Color(1,1,1,1f);
					armadefimg.color = new Color(1,1,1,0.1f);


					balaprefabdef = prebaladefl[manager.datosserial.nivelarmadef -1];
					tiempodisp = 0;
					manager.datosserial.armasel = 4;
					manager.datosserial.palosel = 1;
					manager.guardar();
					iconodisp.sprite = arma4;
					if(manager.datosserial.tengolanzar == true)
					{paloimg.sprite = arma1;}
					else
					{paloimg.sprite = nopimg;}
					backpaloimg.sprite = arma1;
					pistolap.SetActive(false);
					pistolatiempo.SetActive(true);
					pistolabazoka.SetActive(false);
				}
			}
		}
		if(lb > 0 && manager.datosserial.tengolanzar == true)
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
			if(verticalpad > 0.5f && manager.juego == 4 || rverticalc > 0.5f && manager.juego == 3)
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

			if(verticalpad < -0.5f && manager.juego == 4 || rverticalc < -0.5f && manager.juego == 3)
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
			if(horizontalpad > 0.5f && manager.juego == 4 || rhorizontalc > 0.5f && manager.juego == 3)
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
			if(horizontalpad < -0.5f && manager.juego == 4 || rhorizontalc < -0.5f && manager.juego == 3)
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

	}
	if(manager.datosserial.jefeV[0] == false && manager.datosserial.economia[1] >= 1 && manager.piso == 1 && tiempoascensor > 2f && manager.juego == 0)
	{
		manager.portalg.SetActive(true);
	}
	if(manager.datosserial.jefeV[1] == false && manager.datosserial.economia[1] >= 2 && manager.piso == 2 && tiempoascensor > 2f && manager.juego == 0)
	{
		manager.portalg.SetActive(true);
	}
	if(manager.datosserial.jefeV[2] == false && manager.datosserial.economia[1]  >= 3 && manager.piso == 3 && tiempoascensor > 2f && manager.juego == 0)
	{
		manager.portalg.SetActive(true);
	}
	if(manager.datosserial.jefeV[3] == false && manager.datosserial.economia[1]  >= 4 && manager.piso == 4 && tiempoascensor > 2f && manager.juego == 0)
	{
		manager.portalg.SetActive(true);
	}


		if (this.ascensor && manager.juego == 0 && manager.piso == 1)
		{
			
			if (rt > 0f && manager.datosserial.tengovel == 1 && bajar1 == false && bajar1esp == false && tiempoascensor > 2f)
			{
				subir1 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
				
			}
			if (lt > 0f && manager.datosserial.tengonave == 1 && manager.datosserial.cinematicaf == 1 && subir1 == false && tiempoascensor > 2f)
			{
				bajar1esp = true;
				bajar = true;
				manager.portalg.SetActive(false);
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
			}
			else if (lt> 0f && manager.datosserial.economia[0] >= 1 && subir1 == false && tiempoascensor > 2f)
			{
				bajar1 = true;
				bajar = true;
				manager.portalg.SetActive(false);
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajar1 == true){ascensors.SetFloat("asc2",-1);}
			if (subir1 == true){ascensors.SetFloat("asc2",1);}
			if (bajar1esp == true){ascensors.SetFloat("asc2",-1);}
			
			
			
		}
		if (this.ascensor && manager.juego == 4 && manager.piso == 10 && rt > 0f && tiempoascensor > 2f)
		{
			subir0 = true;
			subir = true;
			tiempoascensor = 0;
			manager.datosserial.asc = 1;
			manager.guardar();
		}
		
		if (subir0 == true){ascensors.SetFloat("asc2",1);}
		if (this.ascensor && manager.juego == 0 && manager.piso == 2 && tiempoascensor > 2f)
		{
			if (rt > 0f && manager.datosserial.tengocoche == 1 && bajar2 == false)
			{
				subir2 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lt > 0f && subir2 == false)
			{
				bajar2 = true;
				bajar = true;
				manager.portalg.SetActive(false);
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajar2 == true){ascensors.SetFloat("asc2",-1);}
			if (subir2 == true){ascensors.SetFloat("asc2",1);}
			
		}
		if (this.ascensor && manager.juego == 0 && manager.piso == 3 && tiempoascensor > 2f)
		{
			if (rt > 0f && manager.datosserial.tengosalto == 1 && bajar3 == false )
			{
				subir3 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
			}
			if (lt > 0f && subir3 == false )
			{
				bajar3 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.portalg.SetActive(false);
				manager.datosserial.asc = -1;
				manager.guardar();
			}
			if (bajar3 == true){ascensors.SetFloat("asc2",-1);}
			if (subir3 == true){ascensors.SetFloat("asc2",1);}
			
		}
		if (this.ascensor && manager.juego == 0 && manager.piso == 5 && lt > 0f && subir5 == false && tiempoascensor > 2f)
		{
				bajar5 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
		}
				if (this.ascensor && manager.juego == 0 && manager.piso == 5 && rt > 0f && bajar5 == false && tiempoascensor > 2f)
		{
				subir5 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
		}

		if (bajar5 == true){ascensors.SetFloat("asc2",-1);}

		if (subir5 == true){ascensors.SetFloat("asc2",1);}
		if (this.ascensor && manager.juego == 0 && manager.piso == 4 && tiempoascensor > 2f)
		{
			if (rt > 0f && manager.datosserial.economia[1] >= 4 && bajar4 == false)
			{
				subir4 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lt > 0f && subir4 == false ) 
			{
				bajar4 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajar4 == true){ascensors.SetFloat("asc2",-1);}
			if (subir4 == true){ascensors.SetFloat("asc2",1);}
			
		}
			if (this.ascensor && manager.juego == 0 && manager.piso == -1 && tiempoascensor > 2f)
		{
			if (rt > 0f && bajart1 == false )
			{
				subirt1 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lt> 0f && subirt1 == false) 
			{
				bajart1 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajart1 == true){ascensors.SetFloat("asc2",-1);}
			if (subirt1 == true){ascensors.SetFloat("asc2",1);}
			
		}
			if (this.ascensor && manager.juego == 0 && manager.piso == -2 && tiempoascensor > 2f)
		{
			if (rt > 0f && bajart2 == false)
			{
				subirt2= true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lt > 0f && subirt2 == false) 
			{
				bajart2 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajart2 == true){ascensors.SetFloat("asc2",-1);}
			if (subirt2 == true){ascensors.SetFloat("asc2",1);}

		}
			if (this.ascensor && manager.juego == 0 && manager.piso == -3 && tiempoascensor > 2f)
		{
			if (rt > 0f && bajart3 == false)
			{
				subirt3 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lt > 0f && subirt3 == false ) 
			{
				bajart3 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajart3 == true){ascensors.SetFloat("asc2",-1);}
			if (subirt3 == true){ascensors.SetFloat("asc2",1);}

		}
		if (this.ascensor && manager.juego == 0 && manager.piso == -4 && tiempoascensor > 2f)
		{
			anim.SetFloat("velx",lhorizontalc);
        anim.SetFloat("vely",lverticalc);
			if (rt > 0f && bajart4 == false )
			{
				subirt4 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lt > 0f && subirt4 == false ) 
			{
				bajart4 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajart4 == true){ascensors.SetFloat("asc2",-1);}
			if (subirt4 == true){ascensors.SetFloat("asc2",1);}

		}
			if (this.ascensor && manager.juego == -1 && manager.piso == -5 && tiempoascensor > 2f)
		{
			if (lt > 0f ) 
			{
				bajart5 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
				
			}
			if (bajart5 == true){ascensors.SetFloat("asc2",-1);}
		}
		if (manager.juego == 1)
		{
			base.transform.rotation = this.rotacion1;
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
		
			if(bajar1esp == true && tiempoascensor > 0.9f)
			{
				manager.datosserial.cinematicaf = 0;
				manager.guardar();
				SceneManager.LoadScene("cinematicafinal_al1");
			}
		if(subir0 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1_al1");}
		if(bajar5 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4_al1");}
		if(subir5 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1t_al1");}
		if(subirt1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2t_al1");}
		if(bajart1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso5_al1");}
		if(subirt2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3t_al1");}
		if(bajart2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1t_al1");}
		if(subirt3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4t_al1");}
		if(bajart3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2t_al1");}
		if(subirt4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso5t_al1");}
		if(bajart4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3t_al1");}
		if(bajart5 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4t_al1");}

		

		if(subir1 == true && tiempoascensor > 0f && manager.datosserial.jefeV[0] == false && manager.datosserial.economia[1]  >= 4){SceneManager.LoadScene("jefe1_al1");}
		else if(subir1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2_al1");}


		if(subir2 == true && tiempoascensor > 0f && manager.datosserial.jefeV[1] == false && manager.datosserial.economia[1]  >= 4){SceneManager.LoadScene("jefe2_al1");}
		else if(subir2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3_al1");}

		if(subir3 == true && tiempoascensor > 0f && manager.datosserial.jefeV[2] == false && manager.datosserial.economia[1]  >= 4){SceneManager.LoadScene("jefe3_al1");}
		else if(subir3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4_al1");}

		if(subir4 == true && tiempoascensor > 0f && manager.datosserial.jefeV[3] == false && manager.datosserial.economia[1]  >= 4){SceneManager.LoadScene("jefe4_al1");}
		else if(subir4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso5_al1");}
		

		if(bajar1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("mundo_al1");}

		if(bajar2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1_al1");}

		if(bajar3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2_al1");}

		if(bajar4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3_al1");}







		if (manager.juego == 2)
		{
			if (lverticalc != 0f && lhorizontalc != 0f)
            {
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidadjet, lverticalc * velocidadjet,velocidad));
            }
			else if(lverticalc == 0f && lhorizontalc == 0f)
            {
                _rb.linearVelocity = new Vector3 (0, 0, velocidad);
            }
			if(rt > 0 && tiempodisp > 0.5f)
            {
				GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

				Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

				rb.AddForce(transform.forward * 110 * balavel);

				Destroy(BalaTemporal, 1.0f);

				dispdef.Play();

				tiempodisp = 0;
            }
		}
		if (manager.juego == 11)
		{
			if (lverticalc != 0f && lhorizontalc != 0f)
            {
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidadjet, lverticalc * velocidadjet,velocidad));
            }
			else if(lverticalc == 0f && lhorizontalc == 0f)
            {
                _rb.linearVelocity = new Vector3 (0, 0, velocidad);
            }
		}
		if (manager.juego == 6)
		{
			if (lhorizontalc > 0f )  
			{
				base.transform.Rotate(Vector3.up, Time.deltaTime * 50f);
			}
			if (lhorizontalc < 0f )
			{
				base.transform.Rotate(Vector3.down, Time.deltaTime * 50f);
			}
			if (lverticalc > 0f )
			{
				base.transform.Rotate(Vector3.right, Time.deltaTime * -50f);
			}
			if (lverticalc < 0f )
			{
				base.transform.Rotate(Vector3.left, Time.deltaTime * -50f);
			}
			if (a > 0f && dialogueact == false)
			{
				slash.SetActive(true);
				pasosnave.UnPause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,1 * velocidad));
			}
			else
			{
				slash.SetActive(false);
				pasosnave.Pause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,0));
			}
			if(rhorizontalc != 0)
            {rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;}
            else{rotationinput.x = 0;}

			if(rverticalc != 0)
            {rotationinput.y = rverticalc * rotspeed * Time.deltaTime;}
            else{rotationinput.y = 0;}
            
            transform.Rotate(Vector3.up * rotationinput.x);
			transform.Rotate(Vector3.left * rotationinput.y);
		}
		if (manager.juego == 1)
		{
			if (rt > 0f )
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,1 * velocidad));
				pasosnave.UnPause();
			}
			else if (lt > 0f )
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,-1 * velocidad));
				pasosnave.UnPause();
			}
			else{pasosnave.Pause();}
			if (lhorizontalc > 0f )
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (1 * velocidad,_rb.linearVelocity.y,_rb.linearVelocity.z));
			}
			if (lhorizontalc < 0f)
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (-1 * velocidad,_rb.linearVelocity.y,_rb.linearVelocity.z));
			}
		}
		
		if (tiempogiro2 > 1f)
		{
			if (girotd_izq == true)
			{
				transform.rotation = Quaternion.Euler(0,0,0);

				 

			}
			if (girotd_der == true)
			{

				transform.rotation = Quaternion.Euler(0,90,0);

			}
			girotd_der = false;
			girotd_izq = false;
		}
		if (girotd_izq == true)
		{
			if (base.transform.eulerAngles.y >= girovalor - 180f)
			{
				transform.Rotate(Vector3.up,-180f * Time.deltaTime);

			}

		}
		if (girotd_der == true)
		{
			if (base.transform.eulerAngles.y <= girovalor + 180f)
			{
				transform.Rotate(Vector3.up,180f * Time.deltaTime);

			}

		}
		if(tiempogiro2 < 1.5f)
		{
			_rb.linearVelocity = Vector3.zero;
			horizontalpad = 0;
		}
			this.tiempogiro2 += Time.deltaTime;

		if (manager.juego == 3 && this.dimensiion )
		{
			transform.localPosition = new Vector3(jugpos,transform.localPosition.y,transform.localPosition.z);
			
			

			anim.SetFloat("velx",horizontalpad);
			Vector3 movdirnow = transform.TransformDirection(new Vector3 (0,0, -horizontalpad)).normalized;

				if (objplaneta != null && tiempogiro2 > 1.5f)
				{					
					// Calcular la dirección de movimiento basada en la orientación del jugador
					Vector3 direccionDerecha = Vector3.Cross(transform.up, transform.forward).normalized;
					Vector3 direccionAdelante = Vector3.Cross(direccionDerecha, transform.up).normalized;
					
					// Preservar la velocidad vertical (relativa a la superficie del planeta)
					float velocidadVertical = Vector3.Dot(_rb.linearVelocity, transform.up);


					// Obtener la inclinación del jugador
					float inclinacionZ = transform.rotation.eulerAngles.z;
					
					// Normalizar ángulos a rango -180 a 180
					if (inclinacionZ > 180) inclinacionZ -= 360;

					// Si el jugador está presionando el control de movimiento
					if (horizontalpad != 0)
					{
						// Si el control acaba de ser activado (no estaba activo antes)
						if (!controlActivo)
						{
							controlActivo = true;
							// Comprobar si la inclinación justifica la inversión
							if (Mathf.Abs(inclinacionZ) > 90)
							{
								invertirHorizontal = true; // Invertir el estado
							}
							else
							{
								invertirHorizontal = false;
							}
						}
						
						// Aplicar la inversión si es necesario
						horizontalFinal = invertirHorizontal ? -horizontalpad : horizontalpad;
						
						// Usar las variables existentes para el movimiento

						_rb.linearVelocity = direccionDerecha * -horizontalFinal * velocidad + transform.up * velocidadVertical;

						if(invertirHorizontal)
						{
							if (horizontalpad > 0f )
							{
								girodir = 90;
							}
							if (horizontalpad < 0f)
							{
								girodir = -90;
								
							}
						}
						else
						{
							if (horizontalpad > 0f )
							{
								girodir = -90;
							}
							if (horizontalpad < 0f)
							{
								girodir = 90;
								
							}
						}

					}
					else
					{
						// Detener el movimiento horizontal pero mantener la velocidad vertical
						controlActivo = false; // Resetear el estado del control
								// Mantener la velocidad actual o detener si no hay input
						_rb.linearVelocity = transform.up * Vector3.Dot(_rb.linearVelocity, transform.up); 
					}
				}
				else if (tiempogiro2 > 1.5f)
				{
					if (horizontalpad > 0f )
					{
						girodir = -90;
					}
					if (horizontalpad < 0f)
					{
						girodir = 90;
					}

					jugadorEntrando = true;
					// Mantener el movimiento horizontal y la velocidad vertical
					_rb.linearVelocity = new Vector3(0f, _rb.linearVelocity.y, horizontalpad * velocidad);
					
					// Volver gradualmente a la rotación normal (gravedad hacia abajo)
					Quaternion rotacionNormal = Quaternion.Euler(0, 90, 0);
					transform.rotation = Quaternion.Slerp(transform.rotation, rotacionNormal, Time.fixedDeltaTime * 3f);
				}

			
			mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,girodir,0),30* Time.deltaTime);
           	movdire = transform.TransformDirection(movdirnow * velocidad);
            movdire.y = 0;
            float distaxe = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(horizontalpad == 0f || _rb.SweepTest(movdire,out hit,distaxe,QueryTriggerInteraction.Ignore))
            {
				dashefect = false;
                _rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
				anim.SetBool("stat",true);
            }
			else
			{
				anim.SetBool("stat",false);
			}
			if(suelo == true && horizontalpad < 0f|| suelo == true && horizontalpad > 0f)
				{
				if(temppaso > pasotiempo)
				{
				randompaso = Random.Range(1,3);
				if(randompaso == 1)
				{
					pasos1.Play();
				}
				if(randompaso == 2)
				{
					pasos2.Play();
				}
				temppaso = 0;
				pasotiempo = Random.Range(0.4f,0.6f);
				}
				if(temppaso < 15)
				{temppaso += 1 * Time.deltaTime;}
				}
			this.tiempogiro2 += Time.deltaTime;
				if(lverticalc != 0)
				{rotationinput.y = lverticalc * rotspeed * Time.deltaTime;}
				else{rotationinput.y = 0;}
				

					rotationinput = rotationinput.normalized;
					rotationinput = Vector3.ClampMagnitude(rotationinput, 1f);

					Vector3 vercam = new Vector3(0,0,0);

					
					vercam = Vector3.right * rotationinput.y;

				
					camara.transform.localEulerAngles += vercam;

				Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
				float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
				float fixedAngle_f = angle_f;
				if (xRotationx.eulerAngles.x>180)
				{
					fixedAngle_f *= -1;
				}
				float clampedX = Mathf.Clamp(fixedAngle_f, -10, 30);
				camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);
				
				camaux = camara.transform.eulerAngles.y;
		
			
			
			
			
		}
		if (manager.juego == 3 && !this.dimensiion )
		{
			
			transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y,jugpos);
			anim.SetFloat("velx",horizontalpad);
			Vector3 movdirnow = transform.TransformDirection(new Vector3 (-horizontalpad,0, 0)).normalized;
				if (objplaneta != null && tiempogiro2 > 1.5f)
				{

					// Calcular la dirección de movimiento basada en la orientación del jugador
					Vector3 direccionDerecha = Vector3.Cross(transform.up, transform.forward).normalized;
					Vector3 direccionAdelante = Vector3.Cross(direccionDerecha, transform.up).normalized;
					
					// Preservar la velocidad vertical (relativa a la superficie del planeta)
					float velocidadVertical = Vector3.Dot(_rb.linearVelocity, transform.up);


					// Obtener la inclinación del jugador
					float inclinacionZ = transform.rotation.eulerAngles.z;
					
					// Normalizar ángulos a rango -180 a 180
					if (inclinacionZ > 180) inclinacionZ -= 360;

					// Si el jugador está presionando el control de movimiento
					if (horizontalpad != 0)
					{
						// Si el control acaba de ser activado (no estaba activo antes)
						if (!controlActivo)
						{
							controlActivo = true;
							// Comprobar si la inclinación justifica la inversión
							if (Mathf.Abs(inclinacionZ) > 90)
							{
								invertirHorizontal = true; // Invertir el estado
							}
							else
							{
								invertirHorizontal = false;
							}
						}
						
						// Aplicar la inversión si es necesario
						horizontalFinal = invertirHorizontal ? -horizontalpad : horizontalpad;
						
						// Usar las variables existentes para el movimiento

						_rb.linearVelocity = direccionDerecha * -horizontalFinal * velocidad + transform.up * velocidadVertical;

						if(invertirHorizontal)
						{
							if (horizontalpad > 0f )
							{
								girodir = 90;
							}
							if (horizontalpad < 0f)
							{
								girodir = -90;
								
							}
						}
						else
						{
							if (horizontalpad > 0f )
							{
								girodir = -90;
							}
							if (horizontalpad < 0f)
							{
								girodir = 90;
								
							}
						}

					}
					else
					{
						// Detener el movimiento horizontal pero mantener la velocidad vertical
						controlActivo = false; // Resetear el estado del control
								// Mantener la velocidad actual o detener si no hay input
						_rb.linearVelocity = transform.up * Vector3.Dot(_rb.linearVelocity, transform.up); 
					}
				}
				else if (tiempogiro2 > 1.5f)
				{
					// Mantener el movimiento horizontal y la velocidad vertical
					_rb.linearVelocity = new Vector3(-horizontalpad * velocidad, _rb.linearVelocity.y, 0);

					if (horizontalpad > 0f )
					{
						girodir = -90;
					}
					if (horizontalpad < 0f)
					{
						girodir = 90;
					}
					jugadorEntrando = true;
					// Volver gradualmente a la rotación normal (gravedad hacia abajo)
					Quaternion rotacionNormal = Quaternion.Euler(0, 0, 0);
					transform.rotation = Quaternion.Slerp(transform.rotation, rotacionNormal, Time.fixedDeltaTime * 3f);
				}
				

				
			
			mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,girodir,0),30* Time.deltaTime);
            movdire = transform.TransformDirection(movdirnow * velocidad);
            movdire.y = 0;
            float distaxe = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(horizontalpad == 0f || _rb.SweepTest(movdire,out hit,distaxe,QueryTriggerInteraction.Ignore))
            {
				dashefect = false;
                _rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
				anim.SetBool("stat",true);
            }
			else
			{
				anim.SetBool("stat",false);
			}
			if(suelo == true && horizontalpad< 0f|| suelo == true && horizontalpad > 0f)
				{
				if(temppaso > pasotiempo)
				{
				randompaso = Random.Range(1,3);
				if(randompaso == 1)
				{
					pasos1.Play();
				}
				if(randompaso == 2)
				{
					pasos2.Play();
				}
				temppaso = 0;
				pasotiempo = Random.Range(0.4f,0.6f);
				}
				if(temppaso < 15)
				{temppaso += 1 * Time.deltaTime;}
				}
				this.tiempogiro2 += Time.deltaTime;

				if(lverticalc != 0)
				{rotationinput.y = lverticalc * rotspeed * Time.deltaTime;}
				else{rotationinput.y = 0;}
				
				rotationinput = rotationinput.normalized;
				rotationinput = Vector3.ClampMagnitude(rotationinput, 1f);
	


				Vector3 vercam = new Vector3(0,0,0);
				

				vercam = Vector3.right * -rotationinput.y;
				
				

				
				camara.transform.localEulerAngles += vercam;

				Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
				float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
				float fixedAngle_f = angle_f;
				if (xRotationx.eulerAngles.x>180)
				{
					fixedAngle_f *= -1;
				}
				float clampedX = Mathf.Clamp(fixedAngle_f, -10, 30);
				camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);

				camaux = camara.transform.eulerAngles.y;
				
				
		}
		if (manager.juego == 4 || manager.juego == 3)
		{
			
			if(r3 > 0 && temp10 > 0.2f)
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
					vidaenebarra.SetActive(false);
				
				}
				if(objetivotarget == tarboss && tarbossact && objetivotarget != null)
				{findchild(tarboss,true,"selectar");}
				else if(objetivotarget != tarboss && tarbossact)
				{findchild(tarboss,false,"selectar");}
			}
			else if(indicetarget != -1)
			{
				if(rhorizontalc > 0 && temp10 > 0.7f)
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
				else if(rhorizontalc < 0 && temp10 > 0.7f)
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
		}
		if (manager.juego == 4 )
		{
			camarascript.maxdis = 20;
			
			
			
			if(lt == 0 || ascensor == true || objplaneta != null)
            {

				anim.SetBool("movlat",false);
				anim.SetBool("latizq",false);
                anim.SetBool("latder",false);
                anim.SetBool("saltoatras",false);



				if(subir == false && bajar == false)
				{
					anim.SetFloat("velx",lhorizontalc);
					anim.SetFloat("vely",lverticalc);
					if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
					{
						lhorizontalc = 0;
						lverticalc = 0;
					}
					

					Vector3 movdirnow = new Vector3 (lhorizontalc,0, lverticalc).normalized;

					if (objplaneta != null)
					{
						jugadorEntrando = true;
						camarascript.maxdis = 40;
						
						
						// Manejar la rotación de la cámara
						// Actualizar ángulos de rotación basados en la entrada del usuario
						cameraverticalangle += rverticalc / 3;
						cameraverticalangle = Mathf.Clamp(cameraverticalangle, -20, 20); // Limitar ángulo vertical
						
						cameraverticalangle2 += rhorizontalc;
						
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
							if (lhorizontalc != 0 || lverticalc != 0)
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
								horizontalFinal = invertirHorizontal ? -lhorizontalc : lhorizontalc;
								
								// Usar las variables existentes para el movimiento
								_rb.linearVelocity = (direccionDerecha1 * horizontalFinal + direccionAdelante1 * lverticalc) * velocidad + transform.up * velocidadVertical2;
								planetUp = (transform.position - planetCenter).normalized;

								angulomod = Mathf.Atan2(horizontalFinal, lverticalc) * Mathf.Rad2Deg;
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
							Vector3 moveDirection = new Vector3(lhorizontalc, 0, lverticalc).normalized;

							if(lverticalc == 0f && lhorizontalc == 0f)
							{
								anim.SetBool("stat",true);
								dashefect = false;
								_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
							}
							else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore))
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
							if(suelo == true && lverticalc < 0f || suelo == true && lverticalc > 0f || suelo == true && lhorizontalc < 0f|| suelo == true && lhorizontalc > 0f)
							{
								if(temppaso > pasotiempo)
								{
									randompaso = Random.Range(1,3);
									if(randompaso == 1)
									{
										pasos1.Play();
									}
									if(randompaso == 2)
									{
										pasos2.Play();
									}
									temppaso = 0;
									pasotiempo = Random.Range(0.4f,0.6f);
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
						camarascript.maxdis = 30;
						if(lhorizontalc != 0 || lverticalc != 0)
						{
							// Movimiento normal cuando no está en modo planeta
							_rb.linearVelocity = transform.TransformDirection(new Vector3(movdirnow.x * velocidad, _rb.linearVelocity.y, movdirnow.z * velocidad));
							
							// Rotar el modelo en la dirección del movimiento
							angulomod = Mathf.Atan2(lhorizontalc, lverticalc) * Mathf.Rad2Deg;
							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
																		Quaternion.Euler(mod.transform.localEulerAngles.x, angulomod, mod.transform.localEulerAngles.z),
																		2 * Time.deltaTime);
							
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
						Vector3 moveDirection = new Vector3(lhorizontalc, 0, lverticalc).normalized;

						
						
						if(lverticalc == 0f && lhorizontalc == 0f)
						{
							anim.SetBool("stat",true);
							dashefect = false;
							_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
						}
						else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore))
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
						
						

						if(suelo == true && lverticalc < 0f || suelo == true && lverticalc > 0f || suelo == true && lhorizontalc < 0f|| suelo == true && lhorizontalc > 0f)
						{
							if(temppaso > pasotiempo)
							{
								randompaso = Random.Range(1,3);
								if(randompaso == 1)
								{
									pasos1.Play();
								}
								if(randompaso == 2)
								{
									pasos2.Play();
								}
								temppaso = 0;
								pasotiempo = Random.Range(0.4f,0.6f);
							}
							if(temppaso < 15)
							{temppaso += 1 * Time.deltaTime;}
						}
						if(objetivotarget == null)
						{
						if(rhorizontalc != 0)
						{rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;}
						else{rotationinput.x = 0;}
						}

						if(rverticalc != 0)
						{rotationinput.y = rverticalc * rotspeed * Time.deltaTime;}
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

							if (lhorizontalc != 0f && rhorizontalc != 0f|| lverticalc != 0 && rhorizontalc != 0f || lhorizontalc != 0f || lverticalc != 0)
							{
								transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
								camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
							}
								


						}
					}

					

						

				}
					
				


				

			}
			else if(lt > 0 && ascensor == false && objplaneta == null)
            {
				
				
				camarascript.maxdis = 20;
				anim.SetBool("movlat",true);
                camnomov = false;
				anim.SetFloat("velx",lhorizontalc);
				anim.SetFloat("vely",lverticalc);
				if(subir == false && bajar == false)
				{
					if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
					{
						lhorizontalc = 0;
						lverticalc = 0;
					}

					Vector3 movdirnow = new Vector3 (lhorizontalc,0, lverticalc).normalized;
					if(lhorizontalc != 0 || lverticalc != 0)
					{

						_rb.linearVelocity = transform.TransformDirection(new Vector3 (movdirnow.x * velocidad,_rb.linearVelocity.y,movdirnow.z * velocidad));

						angulomod =  Mathf.Atan2(lhorizontalc,lverticalc)* Mathf.Rad2Deg;


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

					if(lverticalc == 0f && lhorizontalc == 0f)
					{
						anim.SetBool("stat",true);
						dashefect = false;
						_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
					}
					else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore))
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


					


					if (lhorizontalc >= 0.70f)
					{
						anim.SetBool("latder",true);
						anim.SetBool("latizq",false);
						anim.SetBool("saltoatras",false);
					}
					else if (lhorizontalc <= -0.70f)
					{
						anim.SetBool("latizq",true);
						anim.SetBool("latder",false);
						anim.SetBool("saltoatras",false);
					}
					else if (lverticalc <= -0.70f)
					{
						anim.SetBool("saltoatras",true);
						anim.SetBool("latder",false);
						anim.SetBool("latizq",false);
					}
					else if (lverticalc >= 0.70f)
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
                if(suelo == true && lverticalc < 0f || suelo == true && lverticalc > 0f || suelo == true && lhorizontalc < 0f|| suelo == true && lhorizontalc > 0f)
                {
                    if(temppaso > pasotiempo)
                    {
                        randompaso = Random.Range(1,3);
                        if(randompaso == 1)
                        {
                            pasos1.Play();
                        }
                        if(randompaso == 2)
                        {
                            pasos2.Play();
                        }
                        temppaso = 0;
                        pasotiempo = Random.Range(0.4f,0.6f);
                    }
                    if(temppaso < 15)
                    {temppaso += 1 * Time.deltaTime;}
                }
                anim.SetFloat("vely",lverticalc);


                if(objetivotarget == null)
				{
					if(rhorizontalc != 0)
					{rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;}
					else{rotationinput.x = 0;}
				}

				if(rverticalc != 0)
				{rotationinput.y = rverticalc * rotspeed * Time.deltaTime;}
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
            
		}
		if (manager.juego == 0 && subir == false && bajar == false )
		{
			anim.SetFloat("velx",lhorizontalc);
			anim.SetFloat("vely",lverticalc);
			if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
			{
				lhorizontalc = 0;
				lverticalc = 0;
			}
			

			Vector3 movdirnow = new Vector3 (lhorizontalc,0, lverticalc).normalized;
			camarascript.maxdis = 10;
			if(tiempoascensor > 1.7f)
			{
				if(lhorizontalc != 0 || lverticalc != 0)
						{
							// Movimiento normal cuando no está en modo planeta
							_rb.linearVelocity = transform.TransformDirection(new Vector3(movdirnow.x * velocidad, _rb.linearVelocity.y, movdirnow.z * velocidad));
							
							// Rotar el modelo en la dirección del movimiento
							angulomod = Mathf.Atan2(lhorizontalc, lverticalc) * Mathf.Rad2Deg;
							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
																		Quaternion.Euler(mod.transform.localEulerAngles.x, angulomod, mod.transform.localEulerAngles.z),
																		2 * Time.deltaTime);
							
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
						Vector3 moveDirection = new Vector3(lhorizontalc, 0, lverticalc).normalized;

						
						
						if(lverticalc == 0f && lhorizontalc == 0f)
						{
							anim.SetBool("stat",true);
							dashefect = false;
							_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
						}
						else if(Physics.Raycast(transform.position + new Vector3(0,2,0),movdire,out hit,Mathf.Infinity,0,QueryTriggerInteraction.Ignore))
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
						
						

						if(suelo == true && lverticalc < 0f || suelo == true && lverticalc > 0f || suelo == true && lhorizontalc < 0f|| suelo == true && lhorizontalc > 0f)
						{
							if(temppaso > pasotiempo)
							{
								randompaso = Random.Range(1,3);
								if(randompaso == 1)
								{
									pasos1.Play();
								}
								if(randompaso == 2)
								{
									pasos2.Play();
								}
								temppaso = 0;
								pasotiempo = Random.Range(0.4f,0.6f);
							}
							if(temppaso < 15)
							{temppaso += 1 * Time.deltaTime;}
						}
				
			}

		}
		if (manager.juego == 0 )
		{
			

			camarascript.maxdis = 5;
			if(tiempoascensor > 1.7f)
			{

						if(rhorizontalc != 0)
						{rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;}
						else{rotationinput.x = 0;}
						

						if(rverticalc != 0)
						{rotationinput.y = rverticalc * rotspeed * Time.deltaTime;}
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
						


						camaux = camara.transform.eulerAngles.y;


						if (lhorizontalc != 0f && rhorizontalc != 0f|| lverticalc != 0 && rhorizontalc != 0f || lhorizontalc != 0f || lverticalc != 0)
						{
							transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
							camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
						}

			}
		}
		if (manager.juego == 10)
		{
			if (lhorizontalc < 0f )
			{
				base.transform.Rotate(Vector3.down, Time.deltaTime * 50f);
			}
			if (lhorizontalc > 0f)
			{
				base.transform.Rotate(Vector3.up, Time.deltaTime * 50f);
			}
			if (lverticalc > 0f)
			{
				base.transform.Translate(-Vector3.back * 10f * Time.deltaTime);
			}
			if (lverticalc < 0f )
			{
				base.transform.Translate(-Vector3.forward * 10f * Time.deltaTime);
			}
		}
		if (manager.juego == 3)
		{
			this.tiemposalto -= Time.deltaTime;
			if (this.tiemposalto <= 0f && a > 0f && dialogueact == false && temppause > 0.4f && objplaneta == null && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
					
			}
			else if (this.tiemposalto <= 0f && a > 0f && dialogueact == false && temppause > 0.4f && objplaneta != null && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce((jumpforce + 200f) * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f ;
					anim.SetBool("salto",true);
					
			}
		}
		if (manager.juego == 0)
		{
			this.tiemposalto -= Time.deltaTime;
			if (this.tiemposalto <= 0f && a > 0f && dialogueact == false && temppause > 0.4f && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
			
		}
		if (manager.juego == 4)
		{
			this.tiemposalto -= Time.deltaTime;
			if (this.tiemposalto <= 0f && a > 0f && dialogueact == false && temppause > 0.4f && objplaneta == null && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
			else if (this.tiemposalto <= 0f && a > 0f && dialogueact == false && temppause > 0.4f && objplaneta != null && tiempodialogue > 0.7f)
			{
					if(jumpforce == jumpforcebase)
					{tiempodisp = 0;}
					this._rb.AddRelativeForce((jumpforce + 700f) * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f ;
					anim.SetBool("salto",true);
					
			}
		}
		if(manager.juego == 3 || manager.juego == 4)
		{
			if(manager.datosserial.tengolanzar == true )
			{

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1 && temppalo > 3  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  rt > 0 && ascensor == false )
					{
						tiempodisp = 0;
						temppalo -= 3;
						toquespalo = 2;
						palo.GetComponent<golpe_al1>().dano = 3 * danoextra * nivelfuerza;
						anim.Play("arma3");
						anim.SetBool("arma3",true);
						tempatk = 0; 
						lanzarson.Play();
						if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true)
						{
							manager.datosserial.nivelarmapaloexp += 1;
						}

						
						if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1])
						{
							manager.datosserial.nivelarmapalo++;
							manager.datosserial.nivelarmapaloexp = 0;
						}
						manager.guardar();
					}
					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2 && temppalo > 40 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  rt > 0 && ascensor == false )
					{
						tiempodisp = 0;
						temppalo -= 40;
						palo.GetComponent<golpe_al1>().dano = 1.5f * danoextra * nivelfuerza;
						toquespalo = 999;
						anim.Play("escudogiratorio");
						tempatk = 0; 
						escudohabaud.Play();
						if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true)
						{
							manager.datosserial.nivelarmapaloexp += 7;
						}

						
						if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1])
						{
							manager.datosserial.nivelarmapalo++;
							manager.datosserial.nivelarmapaloexp = 0;
						}
						manager.guardar();
					}

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && suelo == true && tiempodisp > 0.5f &&  rt > 0 && ascensor == false )
					{
						tiempodisp = 0;
						temppalo -= 5 * Time.deltaTime;
						palo.GetComponent<golpe_al1>().dano = 5 * danoextra * nivelfuerza;
						tempatk = 0;
						toquespalo = 999;
						transform.position = Vector3.MoveTowards(transform.position,transform.position + mod.transform.forward * 5, 20 * Time.deltaTime);
						anim.Play("dashtierra");
						anim.SetBool("dashtierra",true);
						dashairson.loop = true;
						dashairson.Play();
						mod.transform.rotation = Quaternion.Lerp(mod.transform.rotation,Quaternion.Euler(mod.transform.eulerAngles.x,camara.transform.eulerAngles.y,mod.transform.eulerAngles.z),10* Time.deltaTime);
						if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true)
						{
							manager.datosserial.nivelarmapaloexp += 0.1f;
						}

						
						if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1])
						{
							manager.datosserial.nivelarmapalo++;
							manager.datosserial.nivelarmapaloexp = 0;
						}
						manager.guardar();
					}
					else if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra") && suelo == true &&  rt > 0 && ascensor == false )
					{
						tiempodisp = 0;
						temppalo -= 5 * Time.deltaTime;
						toquespalo = 999;
						palo.GetComponent<golpe_al1>().dano = 5 * danoextra * nivelfuerza;
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

					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4 && temppalo > 30 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  rt > 0 && ascensor == false )
					{
						tiempodisp = 0;
						temppalo -= 30;
						palo.GetComponent<golpe_al1>().dano = 5 * danoextra * nivelfuerza;
						tempatk = 0; 
						toquespalo = 15;
						anim.Play("espiralarea");
						dashairson.Play();
						if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true)
						{
							manager.datosserial.nivelarmapaloexp += 5;
						}

						
						if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1])
						{
							manager.datosserial.nivelarmapalo++;
							manager.datosserial.nivelarmapaloexp = 0;
						}
						manager.guardar();
					}
					if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5 && temppalo >= 60 && inbuiract == false && tempinbuir  == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  rt > 0 && ascensor == false )
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
						if(manager.datosserial.licenciaarmapalo[manager.datosserial.nivelarmapalo-1] == true)
						{
							manager.datosserial.nivelarmapaloexp += 10;
						}

						
						if(manager.datosserial.nivelarmapaloexp >= armapalosignv[manager.datosserial.nivelarmapalo-1])
						{
							manager.datosserial.nivelarmapalo++;
							manager.datosserial.nivelarmapaloexp = 0;
						}
						manager.guardar();
					}
				
				if(xp > 0 && suelo == true && tiempodisp > 0.7f  && combo == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") &&  rt == 0 && stamina > 10 )
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
				else if(xp > 0 && suelo == true && tiempodisp > 0.2f && combo == 1 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk") &&  rt == 0 && stamina > 10 )
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
				else if(xp > 0 && suelo == true && tiempodisp > 0.3f && combo == 3 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk2") &&  rt == 0  && stamina > 10)
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


				else if(xp > 0 && suelo == true && combo == 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk3") &&  rt == 0 && stamina > 10 )
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
				else if(xp > 0 && suelo == true && tiempodisp > 0.2f && combo == 7 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk4") &&  rt == 0 && stamina > 10)
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


				else if(xp > 0 && suelo == false && ascensor == false &&  rt == 0  && stamina > 20)
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
				if(rt > 0 && ascensor == false && temppaparec >= balapapamun[manager.datosserial.nivelarmapapa -1] && tiempodisp > balapadrecaden[manager.datosserial.nivelarmapapa-1] && papaagotada == false)
				{
					if(manager.datosserial.licenciaarmapapa[manager.datosserial.nivelarmapapa-1] == true)
					{
						manager.datosserial.nivelarmapapaexp++;
					}

					
					if(manager.datosserial.nivelarmapapaexp >= armapapasignv[manager.datosserial.nivelarmapapa-1])
					{
						manager.datosserial.nivelarmapapa++;
						manager.datosserial.nivelarmapapaexp = 0;
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
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balapadredano[manager.datosserial.nivelarmapapa-1] * nivelfuerza;
					

					disp.Play();

				}
				else if(rt > 0 && ascensor == false && temppaparec <= 1 && papaagotada == false)
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
				if(rt > 0 && ascensor == false && tiempodisp > 0.5f && temprelrec >= 40f)
				{
					

					if(manager.datosserial.licenciaarmarel[manager.datosserial.nivelarmarel-1] == true)
					{
						manager.datosserial.nivelarmarelexp++;
					}

					
					if(manager.datosserial.nivelarmarelexp >= armarelsignv[manager.datosserial.nivelarmarel-1])
					{
						manager.datosserial.nivelarmarel++;
						manager.datosserial.nivelarmarelexp = 0;
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
				if(rt > 0 && ascensor == false && tiempodisp > 0.5f && tempdefrec >= 60f && manager.datosserial.armadefdesbloqueada == true || dispF == true)
				{

					
					if(manager.datosserial.licenciaarmadef[manager.datosserial.nivelarmadef-1] == true)
					{
						manager.datosserial.nivelarmadefexp++;
					}

					
					if(manager.datosserial.nivelarmadefexp >= armadefsignv[manager.datosserial.nivelarmadef-1])
					{
						manager.datosserial.nivelarmadef++;
						manager.datosserial.nivelarmadefexp = 0;
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
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = baladefdano[manager.datosserial.nivelarmadef-1] * nivelfuerza;
					dispF = false;
					dispdef.Play();

				}
				else if(rt > 0 && ascensor == false && tiempodisp > 0.5f && tempdefrec >= 60f && manager.datosserial.armadefdesbloqueada == false)
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
			

				
			
			if(manager.juego == 4 || manager.juego == 3)
			{
				if(b > 0 && tempdash > dash && suelo == false && manager.datosserial.tengodash == true && tiempodisp2 > 0.95f && tempaerodash > 2.5f && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && stamina > 0 && temppause > 0.4f && movdire != new Vector3(0,0,0))
				{
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
				else if(b > 0 && tempdash2 > dash2 && suelo == true && tiempodisp2 > 0.7f  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && stamina > 0 && temppause > 0.4f  && movdire != new Vector3(0,0,0))
				{
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
				else if(b > 0 && tempdash2 > dash2 && suelo == true && tiempodisp2 > 0.05f  && anim.GetCurrentAnimatorStateInfo(1).IsName("arma3") && stamina > 0 && temppause > 0.4f  && movdire != new Vector3(0,0,0))
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
			}

		}
		Debug.DrawRay(transform.position + new Vector3(0,3,0),movdirectaux * 300, Color.green);
		if(manager.juego == 3 || manager.juego == 4)
		{
			if(rb > 0 && velact != true && stamina > 0)
			{
				stamina -= 7 * Time.deltaTime;
				staminaact = 0;
				velocidad = velocidadmaxima;
			}
			else if (velact != true){velocidad = velocidadaux;}
		}
		if(temp10 < 15)
        {temp10 += 1 * Time.deltaTime;}
		if(tempaerodash < 15)
        {tempaerodash  += 1 * Time.deltaTime;}
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


		if(manager.juego == 0 || manager.juego == 3 || manager.juego == 4 )
		{
			if(tempdash > dash)
			{anim.SetBool("dash",false);}

			if(tempdash2 > dash2)
			{anim.SetBool("rueda",false);}
		}
		if(tempgir > 0 && manager.juego == 6)
		{
			this.transform.rotation = Quaternion.RotateTowards(transform.rotation, fij,  90 * Time.deltaTime);
		}
		if(tiempodialogue < 15)
        {tiempodialogue += 1 * Time.deltaTime;}

		if(tempatk < 15)
        {tempatk += 1 * Time.deltaTime;}


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



		lhorizontalc = 0;
		lverticalc = 0;


		rhorizontalc = 0;
		rverticalc = 0;

		horizontalpad = 0;
		verticalpad = 0;

		a = 0;
		b = 0;
		x = 0;
		y = 0;

		
		rt = 0;
		lt = 0;
		rb = 0;
		lb = 0;
		
		l3 = 0;
		r3 = 0;
		
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003149 File Offset: 0x00001349
	public void velozidad()
	{
		this.tiempovel = 0f;
		this.tiempovelint = 0;
		
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003169 File Offset: 0x00001369
	public void saltoalto()
	{
			this._rb.AddRelativeForce(this.jumpforce * 0.2f * Vector3.up);
			audio1.Play();
	}
    public void saltoalto2()
	{
			this._rb.AddRelativeForce(this.jumpforce * 1f * Vector3.up);
			audio1.Play();
		
	}
	public void saltoalto3()
	{

			this._rb.AddRelativeForce(this.jumpforce * 3f * Vector3.up);
			audio1.Play();

	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000318C File Offset: 0x0000138C
	public void OnCollisionEnter(Collision col)
	{
		if (manager.juego == 6)
		{
			tempgir = 3;
			fij = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y + 180f,transform.rotation.eulerAngles.z);
			
		}
		if (col.gameObject.tag == "suelo"  && manager.juego != 1 || col.gameObject.tag == "ascensor" && manager.juego != 1)
		{
			jumpforce = jumpforcebase;
			anim.SetBool("salto",false);
			dashaeract = false;

		
		}
		if (col.gameObject.tag == "enemigo" && cronoact == true|| col.gameObject.tag == "respawn")
		{
			muerte = true;
		}
		if (col.gameObject.tag == "enemigo" && cronoact == false)
		{

			
			if(col.gameObject.GetComponent<enemigo2_al1>() != null)
			{

				eneempuj = col.gameObject;
				enmovdirectaux = transform.TransformDirection((eneempuj.transform.forward *70) + (eneempuj.transform.up * -50));
				enmovdirectaux = enmovdirectaux.normalized;
				tempempujon = 0;
				empujon = true;

				muertesjug.Play();
				enemigo2_al1 enec = col.gameObject.GetComponent<enemigo2_al1>();
				vida -= enec.danoj;


				
			}

			
		}
		if (col.gameObject.tag == "enemigo" && cronoact == true)
		{
			muertes.Play();
		}
		if (col.gameObject.tag == "gas"  && manager.juego == 1)
		{
			SceneManager.LoadScene("mundoc2_al1");
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000031C0 File Offset: 0x000013C0
	private void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "ascensor" && manager.juego == 0)
		{
			tut10.SetActive(true);
			this.ascensor = true;
			tempaerodash = 9;
			
			
		}
		if (col.gameObject.tag == "ascensor" && manager.juego == 4)
		{
			tut10.SetActive(true);
			this.ascensor = true;
			suelo = true;
			tempaerodash = 9;
		}
		if (col.gameObject.tag == "suelo")
		{
			if(tiempovelint > 2)
			{suelo = true;}
			tempaerodash = 9;
		
		}
		if (col.gameObject.tag == "suelo"  && manager.juego != 1 || col.gameObject.tag == "ascensor"  && manager.juego != 1)
		{
			anim.SetBool("salto",false);
			
		}

	}


	// Token: 0x06000023 RID: 35 RVA: 0x00003284 File Offset: 0x00001484
	private void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "ascensor" && manager.juego == 4)
		{
			if (!this.dentrotienda)
			{
				tut10.SetActive(false);
			}
			this.ascensor = false;
			anim.SetBool("salto",true);
			suelo = false;
			

		}
		if (col.gameObject.tag == "ascensor" && manager.juego == 0)
		{
			if (!this.dentrotienda)
			{
				tut10.SetActive(false);
			}
			this.ascensor = false;
			anim.SetBool("salto",true);
		}
		if (col.gameObject.tag == "suelo"  && manager.juego != 1)
		{
			anim.SetBool("salto",true);
			suelo = false;
		}
	
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "enemigo")
		{
			enetouch = true;
		}
		else if (col.gameObject.tag == "pisar" && col.gameObject.tag != "enemigo" && enetouch == false )
		{
					if(col.gameObject.GetComponent<pisar_al1>().enemigo == 1 )
					{
						
							enemigo1_al1 enec = col.gameObject.transform.parent.gameObject.transform.Find("enemigo").GetComponent<enemigo1_al1>();
							enec.vidapisar = true;
							if(enec.temprb == 0)
							{
								if(col.gameObject != null)
								{
									
								
									enec.rb_.AddRelativeForce(transform.forward * 110 * 2 * (enec.tamano + 1));
									enec.danoene.Play();
									enec.temprb = 1;
								}
								if(enec.tamano == 0)
								{enec.vida -= enec.vidamax;}
								else if(enec.tamano == 1)
								{enec.vida -= enec.vidamax/3;}
								else if(enec.tamano == 2)
								{enec.vida -= enec.vidamax/6;}
								else if(enec.tamano == 3)
								{enec.vida -= enec.vidamax/9;}
								_rb.AddRelativeForce(transform.up * 110 * 3);
								vidaeneact = true;			
								vidaeneui = enec.vida;
								vidaeneuimax = enec.vidamax;
								niveleneui.text = enec.nivelactual.ToString();
								vidaenebarra.SetActive(true);
								if(eventotut != null)
								{eventotut.evento();}
							}
						
						
						
					}
					if(col.gameObject.GetComponent<pisar_al1>().enemigo == 2 )
					{
						
							enemigo2_al1 enec = col.gameObject.transform.parent.gameObject.transform.Find("enemigo").GetComponent<enemigo2_al1>();
							if(enec.temprb == 0)
							{
							enec.vida -= 1;
							if(col.gameObject != null)
							{
								_rb.AddRelativeForce(transform.up * 110 * 2);
								enec.danoene.Play();
								enec.temprb = 1;
								
							}
							vidaeneact = true;			
							vidaeneui = enec.vida;
							vidaeneuimax = enec.vidamax;
							niveleneui.text = enec.nivelactual.ToString();
							vidaenebarra.SetActive(true);
							}
						
				}
			
		}
		if (col.gameObject.tag == "cambio")
        {
            menushow.SetBool("show",true);
			comando.text = "cambiar direccion de compresion";
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
				eneempuj = col.gameObject;
				enmovdirectaux = transform.TransformDirection((eneempuj.transform.forward *70) + (eneempuj.transform.up * -50));
				enmovdirectaux = enmovdirectaux.normalized;
				tempempujon = 0;
				empujon = true;
		
				golpe_al1 enec = col.gameObject.GetComponent<golpe_al1>();
				vida -= enec.dano;
				enec.dest.Play();
			}
		}
		if (col.gameObject.tag == "pisarboss")
		{
			GameObject explosiont = Instantiate(explosion, col.transform.position,col.transform.rotation) as GameObject;
			muertes.Play();
            Destroy(explosiont, 1f);
			eneboss1.vida -= eneboss1.vidamax/4;
			eneboss1.rb_.AddRelativeForce(transform.forward * 110 * 20);
			_rb.AddRelativeForce(transform.up * 110 * 10);
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

		if (col.gameObject.tag == "enemigo")
		{
			enetouch = false;
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
		if (col.gameObject.tag == "npc")
		{
			if (controles.al1_general.y.ReadValue<float>() > 0f && dialogueact == false && tiempodialogue > 0.7f)
			{
				
				menushow.SetBool("show",false);
				if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
				{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
				
				manager.misionS = col.gameObject.GetComponent<npc_al1>().mision;
				misionA.npcid = col.gameObject.GetComponent<npc_al1>().managernpc.npcID;
				misionA.premiocant = col.gameObject.GetComponent<npc_al1>().npc_precio;
				menuoff.StartDialogue(npcbase.DialogueSO,npcbase.dialogueid);
				dialogueact = true;
				tiempodialogue = 0;
				manager.controlene = false;

				
			}
			else if (controles.al1_general.cinnext.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
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
		if (col.gameObject.tag == "cambio")
        {
            giro2D();
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
				if (controles.al1_general.cinnext.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
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
	public void giro2D()
	{
		if (manager.juego == 3 && controles.al1_general.y.ReadValue<float>() > 0f )
		{

			
			if (!this.dimensiion && this.tiempogiro2 > 1.5f)
			{
				this.dimensiion = true;
				this.tiempogiro2 = 0f;
				girovalor = base.transform.eulerAngles.y;
				girotd_der = true;
			}
			else if (this.dimensiion && this.tiempogiro2 > 1.5f)
			{
				this.tiempogiro2 = 0f;
				this.dimensiion = false;
				girovalor = base.transform.eulerAngles.y;
				girotd_izq = true;
			}
			if(dimensiion == true)
			{
				jugpos = transform.localPosition.x;
			}
			else if(dimensiion == false)
			{
				jugpos = transform.localPosition.z;
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
			if(manager.juego == 1)
			{
				anim.SetBool("act2",true);
			}
			if(manager.juego == 2)
			{
				anim.SetBool("act",true);
			}
			rt = 0;
			temp10 = 0;
			if(manager.datosconfig.plat == 2)
			{
				tactil.SetActive(false);
			}
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
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
		if(manager.juego == 1)
		{
			anim.SetBool("act2",true);
		}
		if(manager.juego == 2)
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
		if(manager.juego == 1)
		{
			anim.SetBool("act2",true);
		}
		if(manager.juego == 2)
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
		if(manager.juego == 1)
		{
			anim.SetBool("act2",true);
		}
		if(manager.juego == 2)
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
	public AudioSource subirnivelaud;
	public GameObject subirnivelexpl;

	

	// Token: 0x0400000C RID: 12
	public float velocidad = 8;

	// Token: 0x0400000D RID: 13
	public float velocidadjet = 2;

	// Token: 0x0400000E RID: 14
	public float velocidadr = 20f;

	// Token: 0x0400000F RID: 15
	public Rigidbody _rb;

	// Token: 0x04000010 RID: 16
	private float jumpforce = 500f;

	// Token: 0x04000011 RID: 17
	private float jumpforce2 = 200f;

	public float jumpforcebase = 0f;

	// Token: 0x04000012 RID: 18
	public float tiemposalto;

	// Token: 0x04000013 RID: 19
	public float tiempovel;

	// Token: 0x04000014 RID: 20
	public int tiempovelint;

	// Token: 0x04000015 RID: 21
	private float velocidadmaxima = 13;
	

	// Token: 0x04000016 RID: 22
	public float velocidadaux;

	// Token: 0x04000017 RID: 23
	public Quaternion rotacion1 = Quaternion.Euler(new Vector3(0f, 0f, 0f));

	// Token: 0x04000018 RID: 24
	private Vector3 punto;


	// Token: 0x0400001A RID: 26
	public bool dimensiion;

	// Token: 0x0400001B RID: 27
	private float tiempogiro;

	// Token: 0x0400001C RID: 28
	private float tiempogiro2;

	// Token: 0x0400001D RID: 29
	public bool ascensor = true;



	// Token: 0x04000020 RID: 32
	public bool dentrotienda;
	private bool dashefect;
	public GameObject eneempuj;
	public bool empujon;
	private float disdash = 10;
	private float veldash = 30;
	private Vector3 movdire;
	private Vector3 movdirect;
	private Vector3 movdirectaux;
	public RaycastHit hit;
	
	public float []balapadrevel;
	public float []balapadredano;
	public float []balapadrecaden;

	public float []baladefdano;
	public float []balareldano;
	public float []balapapamun;

	private float tiempodisp2;




	public Text niveluit;
	public Image niverlbarra;

	private static GameObject FindGameObjectsAll(string name) { return Resources.FindObjectsOfTypeAll<GameObject>().First(x => x.name == name); }
	public GameObject []target = new GameObject[3];
	public GameObject camarainterna;
	public Text levelexpt;
	public Text levelarmat;
	public Text balaarmat;
	public AudioSource tragar;
	public AudioSource pistolabueno;
	public AudioSource pistolamalo;
	public gravitybody_al1 grav;

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
	public GameObject misionUI;
	public enemigo1boss_al1 eneboss1;
	public GameObject juego;
    public GameObject pausa1;
	public GameObject select1;
	public Image vidab;
	public Image vidaeneimg;
	public Image escudoeneimg;
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
	public misionA_al1 misionA;

	public Controles controles;
	public manager_al1 manager;
	public Text vidat;
	public Animator ascensors;
	public GameObject vidaenebarra;
	public GameObject escudoenebarra;
	public Image barraarmaimgnv1;
	public Image barraarmaimgnv2;
	public Image barraarmaimgnv3;
	public Image barraarmaimgnv4;
	public GameObject boxcam2;
	public GameObject armadefpassC;
	public Text armanvt;
	public Image staminabarra;
	public Text conseguido;
	public Animator conseguidoa;
	public Text niveleneui;
	public Text comando;
	public camara_al1 camarascript; 
	public GameObject noarmasel;
	public AudioSource vozMeet;
	public AudioSource tiendaMus;
	
	
}
