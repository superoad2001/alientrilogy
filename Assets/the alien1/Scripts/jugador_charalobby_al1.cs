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
public class jugador_charalobby_al1 : jugador_al1
{
	[Header("Propio Lobby")]
	public GameObject armadefpassC;
	public Text balaarmat;
	private int cambioruedaact;
	public float staminaobj;
	public GameObject pistolatiempo;
	public GameObject pistolabazoka;
	private float vidaobj;
	public GameObject pistolap;
	public Sprite armapaparueda;
	public Sprite armarelrueda;
	public Sprite armadefrueda;
	public Text numpoct;
	public Text numpoc1t;
	public Text numpoc2t;
	public Text numpoc3t;
	public Text numpoc4t;
	public Sprite arma1;
	public Sprite arma2;
	public Sprite arma3;
	public Sprite arma4;
	public Sprite arma1_1;
	public Sprite arma1_2;
	public Sprite arma1_3;
	public Sprite arma1_4;
	public Sprite arma1_5;
	public Text vidat;
	public Image staminabarra;
	private bool berserkfin;
	private bool inbuiract;
	public float tempdefrec = 60f; 
	public float temprelrec = 40f; 
	public float temppaparec = 20f; 
	private float cameraverticalangle2;
	private float tempinbuir;
	private float xp;
	public GameObject slash;
	private float danoextra = 1;
	public AudioSource golpeson;
	public AudioSource lanzarson;
	private bool papaagotada;
	public bool ascact;
	public Text comando;
	private int randompaso;
	public AudioSource pasos1;
	public AudioSource pasos2;
	public bool eventoini;
	private bool bajar1esp = false;
	public bool ascensor = true;
	private float angulomod;
	private float pasotiempo;
	public float rotspeed = 3;
	private float temppaso = 1;
	public Vector3 rotationinput;

	public GameObject ascensorui;
	public float staminaact = 50;
	public camara_al1 camarascript; 
	private float tempaerodash = 9;
	public AudioSource dashson;
	public AudioSource dashairson;
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
	private float dash = 0.3f;
	private float dash2 = 0.3f;
	public Image barraarmaimgnv1;
	public Image barraarmaimgnv2;
	public Image barraarmaimgnv3;
	public Image barraarmaimgnv4;

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
	private float velocidadmaxima = 8;
	public float vidabasetut = 9;
    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;
	private bool bajart5 = false;
	public float tiempoascensor = 0;
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

		if(manager.datosserial.ascensoract == false)
		{
			tiempoascensor = 5;
		}
		else
		{
			tiempoascensor = 0;
		}

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
		
		

		
		if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}


		camarascript = (camara_al1)FindFirstObjectByType(typeof(camara_al1));
		
		rotspeed = 150;


		
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
		vidaobj = vida;
		staminaobj = stamina;



		camara.transform.eulerAngles = new Vector3(0,0,0);
		


		if((enemigo1boss_al1)FindFirstObjectByType(typeof(enemigo1boss_al1)) != null)
		{
			eneboss1 = (enemigo1boss_al1)FindFirstObjectByType(typeof(enemigo1boss_al1));
		}
		numpociones = manager.datosserial.pocionesmax;
		

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
		
			velocidad = 4;
			velocidadaux = 4;
			velocidadmaxima = 6;
			jumpforce = 200;
			camara.transform.rotation = Quaternion.Euler(0,180,0);
		
		this._rb = base.GetComponent<Rigidbody>();
		velocidadaux = velocidad;
		jumpforcebase = jumpforce;
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


		stamina = staminamax;
		
		
		
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
	public void Update()
	{

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

	staminaobj = Mathf.Lerp(staminaobj, stamina, Time.deltaTime * 4f);
	vidaobj = Mathf.Lerp(vidaobj, vida, Time.deltaTime * 2f);
	vidab.fillAmount = vidaobj/vidamax; 
	vidat.text = "VIT:"+(int)vida+"/"+(int)vidamax;
	niverlbarra.fillAmount = manager.datosserial.nivelexp/manager.datosserial.signivelexp; 
	niveluit.text = "LEVEL "+ manager.datosserial.niveljug;
	staminabarra.fillAmount = staminaobj/staminamax;

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
			}

		

		lateralc = controles.al1_3d.lateral.ReadValue<float>();
		UIXc = controles.al1_UI.UIX.ReadValue<float>();
		UIYc = controles.al1_UI.UIY.ReadValue<float>();	
		saltarc = controles.al1_3d.saltar.ReadValue<float>();
		dashc = controles.al1_3d.dash.ReadValue<float>();
		golpearc = controles.al1_3d.golpear.ReadValue<float>();
		golpearMc = controles.al1_3d.golpearM.ReadValue<float>();
		interactuarc = controles.al1_3d.interactuar.ReadValue<float>();		
		dispararc = controles.al1_3d.disparar.ReadValue<float>();
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
		
	}
	
	if(manager.datosserial.jefeV[0] == false && manager.datosserial.tengollave1 == true && manager.piso == 1 && tiempoascensor > 2f )
	{
		manager.portalg.SetActive(true);
	}
	if(manager.datosserial.jefeV[1] == false && manager.datosserial.tengollave2 == true && manager.piso == 2 && tiempoascensor > 2f)
	{
		manager.portalg.SetActive(true);
	}
	if(manager.datosserial.jefeV[2] == false&& manager.datosserial.tengollave3 == true && manager.piso == 3 && tiempoascensor > 2f )
	{
		manager.portalg.SetActive(true);
	}
	if(manager.datosserial.jefeV[3] == false && manager.datosserial.tengollave4 == true && manager.piso == 4 && tiempoascensor > 2f )
	{
		manager.portalg.SetActive(true);
	}


		if (this.ascensor && manager.piso == 1)
		{
			
			if (dispararc > 0f && manager.datosserial.jefeV[0] == true && bajar1 == false && bajar1esp == false && tiempoascensor > 2f)
			{
				subir1 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
				
			}
			else if (lateralc > 0f && manager.datosserial.tengollave0 == true && subir1 == false && tiempoascensor > 2f)
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
			
			
			
		}
		
		if (subir0 == true){ascensors.SetFloat("asc2",1);}
		if (this.ascensor && manager.piso == 2 && tiempoascensor > 2f)
		{
			if (dispararc > 0f && manager.datosserial.jefeV[1] == true && bajar2 == false)
			{
				subir2 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lateralc > 0f && subir2 == false)
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
		if (this.ascensor && manager.piso == 3 && tiempoascensor > 2f)
		{
			if (dispararc > 0f && manager.datosserial.jefeV[2] == true && bajar3 == false )
			{
				subir3 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
			}
			if (lateralc > 0f && subir3 == false )
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
		if (this.ascensor && manager.piso == 5 && lateralc > 0f && subir5 == false && tiempoascensor > 2f)
		{
				bajar5 = true;
				bajar = true;
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
		}
		

		if (bajar5 == true){ascensors.SetFloat("asc2",-1);}

		if (subir5 == true){ascensors.SetFloat("asc2",1);}
		if (this.ascensor && manager.piso == 4 && tiempoascensor > 2f)
		{
			if (dispararc > 0f && manager.datosserial.jefeV[3] == true && bajar4 == false)
			{
				subir4 = true;
				subir = true;
				tiempoascensor = 0;
				manager.datosserial.asc = 1;
				manager.guardar();
				
			}
			if (lateralc > 0f && subir4 == false ) 
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

	
		
		
			
		
			
			
		
	
		
		if(subir0 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1_al1");}
		
		

		//if(subir1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2_al1");}
		if(subir1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("fin_demo_al1");}


		if(subir2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3_al1");}



		if(subir3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4_al1");}



		if(subir4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso5_al1");}


		

		if(bajar1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("mundo_al1");}



		if(bajar2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1_al1");}



		if(bajar3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2_al1");}



		if(bajar4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3_al1");}



		if(bajar5 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4_al1");}






		if (subir == false && bajar == false )
		{
			anim.SetFloat("velx",movXc);
			anim.SetFloat("vely",movYc);
			if(anim.GetCurrentAnimatorStateInfo(1).IsName("dashtierra"))
			{
				movXc = 0;
				movYc = 0;
			}
			

			Vector3 movdirnow = new Vector3 (movXc,0, movYc).normalized;
			camarascript.maxdis = 10;
			if(tiempoascensor > 1.7f)
			{
				if(movXc != 0 || movYc != 0)
				{
					
					_rb.linearVelocity = transform.TransformDirection(new Vector3(movdirnow.x * velocidad, _rb.linearVelocity.y, movdirnow.z * velocidad));
					
					angulomod = Mathf.Atan2(movXc, movYc) * Mathf.Rad2Deg;
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
																Quaternion.Euler(mod.transform.localEulerAngles.x, angulomod, mod.transform.localEulerAngles.z),
																15 * Time.deltaTime);
					
				
					float camaraYRotation = camara.transform.eulerAngles.y;
					transform.rotation = Quaternion.Slerp(transform.rotation, 
														Quaternion.Euler(0, camaraYRotation, 0),
														1 * Time.deltaTime);
				}
					
				
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
				
				

				if(suelo == true && movYc < 0f || suelo == true && movYc > 0f || suelo == true && movXc < 0f|| suelo == true && movXc > 0f)
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
			

			camarascript.maxdis = 5;
			if(tiempoascensor > 1.7f)
			{

				if(camXc != 0)
				{rotationinput.x = camXc * rotspeed * Time.deltaTime;}
				else{rotationinput.x = 0;}
				

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
				


				camaux = camara.transform.eulerAngles.y;


				if (movXc != 0f && camXc != 0f|| movYc != 0 && camXc != 0f || movXc != 0f || movYc != 0)
				{
					transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
					camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,boxcam2.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
				}

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


				}


			
		
			if(manager.datosserial.tengolanzar == true )
			{

				if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 1 && temppalo > 3  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0  )
				{
					
				}
				if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 2 && temppalo > 40 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 )
				{
					
				}

				if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 3 && temppalo > 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && suelo == true && tiempodisp > 0.5f &&  dispararc > 0 )
				{
					
				}
				


				if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 4 && temppalo > 30 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 )
				{
					
				}
				if(manager.datosserial.armasel == 1 && manager.datosserial.palosel == 5 && temppalo >= 60 && inbuiract == false && tempinbuir  == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && tiempodisp > 0.5f &&  dispararc > 0 )
				{
					
				}
				
				if(xp > 0 && suelo == true && tiempodisp > 0.7f  && combo == 0 && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") &&  dispararc == 0 && stamina > 10 )
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
				else if(xp > 0 && suelo == true && tiempodisp > 0.2f && combo == 1 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk") &&  dispararc == 0 && stamina > 10 )
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
				else if(xp > 0 && suelo == true && tiempodisp > 0.3f && combo == 3 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk2") &&  dispararc == 0  && stamina > 10)
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


				else if(xp > 0 && suelo == true && combo == 5 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk3") &&  dispararc == 0 && stamina > 10 )
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
				else if(xp > 0 && suelo == true && tiempodisp > 0.2f && combo == 7 && anim.GetCurrentAnimatorStateInfo(1).IsName("atk4") &&  dispararc == 0 && stamina > 10)
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


				else if(xp > 0 && suelo == false &&  dispararc == 0  && stamina > 20)
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

						iconodisp.sprite = nopimg;
					
				}

			}
			if(manager.datosserial.armapapa == true && manager.datosserial.armasel == 2)
			{
				if(dispararc > 0  && temppaparec >= balapapamun[manager.datosserial.nivelarmapapa -1] && tiempodisp > balapadrecaden[manager.datosserial.nivelarmapapa-1] && papaagotada == false)
				{
					

				}


				iconodisp.sprite = nopimg;
				
			}
			if(manager.datosserial.armarelen == true  && manager.datosserial.armasel == 4)
			{
				if(dispararc > 0  && tiempodisp > 0.5f && temprelrec >= 40f)
				{
					

				}


				iconodisp.sprite = nopimg;
				
			}
			if(manager.datosserial.armadef == true  && manager.datosserial.armasel == 3)
			{
				if(dispararc > 0  && tiempodisp > 0.5f && tempdefrec >= 60f && manager.datosserial.armadefdesbloqueada == true || dispF == true)
				{

					
					

				}

				iconodisp.sprite = nopimg;
				
			}
			

				
			

				
				if(dashc > 0 && tempdash2 > dash2 && suelo == true && tiempodisp2 > 0.7f  && anim.GetCurrentAnimatorStateInfo(1).IsName("staticar") && stamina > 0 && temppause > 0.4f  && movdire != new Vector3(0,0,0))
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
					veldash = 40;
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


			
				
			

		
		


		this.tiemposalto -= Time.deltaTime;

		if (this.tiemposalto <= 0f && saltarc > 0f && dialogueact == false && temppause > 0.4f && tiempodialogue > 0.7f)
		{
				if(jumpforce == jumpforcebase)
				{tiempodisp = 0;}
				this._rb.AddRelativeForce(this.jumpforce * Vector3.up);
				this.tiemposalto = 0.9f;
				jumpforce = jumpforce / 1.8f;
				anim.SetBool("salto",true);
		}
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
		if(tiempodisp2 < 15)
        {tiempodisp2 += 1 * Time.deltaTime;}
		if(tiempodisp < 15)
        {tiempodisp += 1 * Time.deltaTime;}
		if(tempdash< 15)
        {tempdash += 1 * Time.deltaTime;}
		if(tempdash2< 15)
        {tempdash2 += 1 * Time.deltaTime;}	
		if(temppause < 20)
        {temppause  += 1 * Time.deltaTime;}
		else{temppause  = 20;}

		



			if(tempdash > dash)
			{anim.SetBool("dash",false);}

			if(tempdash2 > dash2)
			{anim.SetBool("rueda",false);}
		
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
		




		movXc = 0;
		movYc = 0;


		camXc = 0;
		camYc = 0;

		ruletaXc = 0;
		ruletaYc = 0;

		saltarc = 0;
		dashc = 0;
		golpearc = 0;
		interactuarc = 0;

		
		dispararc = 0;
		lateralc = 0;
		correrc = 0;
		ruletac = 0;
		
		UIreducidoc = 0;
		marcarc = 0;
		
	}


	// Token: 0x06000021 RID: 33 RVA: 0x0000318C File Offset: 0x0000138C
	public void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.tag == "suelo"   || col.gameObject.tag == "ascensor" )
		{
			jumpforce = jumpforcebase;
			anim.SetBool("salto",false);
			dashaeract = false;


		
		}
		if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}
		
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000031C0 File Offset: 0x000013C0
	private void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "ascensor" )
		{
			if(manager.datosserial.tengollave0 == true || manager.datosserial.jefeV[0] == true)
			{
			ascensorui.SetActive(true);
			this.ascensor = true;
			tempaerodash = 9;
			}	
			suelo = true;		
			
		}
		if (col.gameObject.tag == "suelo")
		{
			
			suelo = true;
			tempaerodash = 9;
		
		}
		if (col.gameObject.tag == "suelo"  || col.gameObject.tag == "ascensor"  )
		{
			anim.SetBool("salto",false);
			
		}

	}


	// Token: 0x06000023 RID: 35 RVA: 0x00003284 File Offset: 0x00001484
	private void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "ascensor" )
		{
			if (!this.dentrotienda)
			{
				ascensorui.SetActive(false);
			}
			this.ascensor = false;
			anim.SetBool("salto",true);
			suelo = false;
		}
		if (col.gameObject.tag == "suelo"  )
		{
			anim.SetBool("salto",true);
			suelo = false;
		}
	
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "suelo"  || col.gameObject.tag == "ascensor" )
		{
			jumpforce = jumpforcebase;
			anim.SetBool("salto",false);
			dashaeract = false;

		
		}

		if (col.gameObject.tag == "respawn")
		{
			muerte = true;
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

	}
	public void OnTriggerExit(Collider col)
	{



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
		
		if (col.gameObject.tag == "cambio")
        {
            menushow.SetBool("show",false);
        }
	}
	public void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "npc")
		{
			if (controles.al1_UI.interactuar.ReadValue<float>() > 0f && dialogueact == false && tiempodialogue > 0.7f)
			{
				
				menushow.SetBool("show",false);
				if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
				{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
				
				manager.misionS = col.gameObject.GetComponent<npc_al1>().mision;
				if(misionA.tiendaact == false)
				{
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
						if(eventosdialogueE != null)
						{
						Destroy(eventosdialogueE.gameObject);
						}
					}
				}
			}
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
	public void tiendaact()
	{
		Time.timeScale = 0;
		manager.pauseact = true;
		musicajuego.Stop();
		tiendaG.SetActive(true);
		tiendaMus.Play();
		controlact = false;
		combo = 0;
		temp10 = 0;
		if(manager.datosconfig.plat == 2)
		{
			tactil.SetActive(false);
		}
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	
	
	
}
