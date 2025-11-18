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
public class jugador_nave_al2 : jugador_al2
{

    [Header("Propio nave")]

	private float ruletac;
	private int ruletainterior;
	public Text comandoarma;
	public Image[] backarmaimg = new Image[4];
	public Image[] armaimg = new Image[4];
	public Image[] circuloarmaimg = new Image[4];
	public Sprite[] armasspriterueda = new Sprite[12];
	public Sprite[] armasspriteequipada = new Sprite[12];

    public AudioSource munson;
    public eventosdialogue_al1 eventosdialogueE;
	public AudioSource critico;
	public Image Critobj;
	public Text armaname;
    public float colorC;
	public int target1 = 0;
	public int target2 = 1;
	public int target3 = 2;
	public int targetmax = 10;
	public bool eventoini;
	public AudioSource vozMeet;
	public jugador_al1 jugador;
	private float temp9;
	public GameObject tarboss;
	private float vidaescudoUI1;
	public int armasel = 1;
	public prefabbala_al2 armasbalas;
	public float vidaobj;
	private float tempparry = 8;
	private float interactuarc;
	private float[] minabalasmax = new float[3];
	private float[] misilbalasmax = new float[3];
	private float[] escopetabalasmax = new float[3];
	private float[] balaarmanave1dano = new float[3];
	private float[] balaarmanave2dano = new float[3];
	private float[] balaarmanave3dano = new float[3];
	private float[] balaarmanave4dano = new float[3];
	public GameObject[] enemigosEnContactonave = new GameObject[20];
	private float temprelectura = 8;
	private float staminaobj;
	private float speednave;
	public List<float> vidanivelesnave = new List<float>();
	private bool movnave2;
	private Vector3 dashnavepos;
	private bool alternarnave;
	private bool cargainicial;
	private float tempaerodash = 9;
	private int cambioruedaact;
	private Vector3 direccion;
	public float staminaact = 50;
	private bool berserkfin;
	private bool inbuiract;
	private float tempinbuir;
	private bool velrecfin;
	private bool escudo_nave;
	private float danoextra = 1;
	private float tempberserk;
	private float tempvelrec;
	private float vidaberserk;
	public bool actzonaespecial;
	public int indicetarget = -1;
	private float angulomod;
	private float camaux = 0;
	private float modaux = 0;
	private int palosel;
	private bool papaagotada;
	private bool actTarget;
	private float temppalo = 60;
	private float tempatk;
	public bool camnomov;
	private float tiempodialogue = 2;
	public float balavel = 20;
	private float velcorr = 12;
	
	private float temppaso = 1;
	public float rotspeed = 3;
	public Quaternion fij = Quaternion.identity;
	private bool movnave;
	
	private float cameraverticalangle;
	private float cameraverticalangle2;

	public Vector3 rotationinput;

	private int randompaso;
	private float pasotiempo;
	
	public float tempgir = 0;
	private float tempdash = 12;
	private float tempdash2 = 12;


	public float tempdefrec = 60f; 
	public float temprelrec = 40f; 
	public float temppaparec = 20f; 

	private float ruletaXc;
	private float ruletaYc;
	private float camXc;
	private float camYc;
	private float movXc;
	private float movYc;
	private float UIXc;
	private float UIYc;	
	private float turboc;
	private float giro180c;
	private float dispararc;
	private float escudoc;
	private float UIreducidoc;
	private float dashc;
	private float menu1c;
	private float menu2c;	
	public float acelerarc;
	public float M_desplacamientoc;
	public bool escudoact;





	public void Awake()
    {
        controles = new Controles();
		
    }
    public void OnEnable() 
    {
        controles.Enable();
    }
    public void OnDisable() 
    {
        controles.Disable();
    }
	// Token: 0x0600001D RID: 29 RVA: 0x000025E8 File Offset: 0x000007E8
	public void Start()
	{
		critico.Pause();
		modo = "nave";

		jugador_al1 jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}
		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));


		


			
			
			


			
		


		

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
		
		this._rb = base.GetComponent<Rigidbody>();
		velocidadaux = velocidad;
		if(anim != null)
		{
			anim.updateMode = AnimatorUpdateMode.Fixed;
		}


		stamina = staminamax;
		
		tiempovelint = 3;
				
		vidamaxN = vidanivelesnave[manager.datosserial.niveljugnave - 1];
		vida = vidamaxN;
		staminaobj = stamina;
		vidaobj = vida;
		vidaenebarra.SetActive(false);

		ruletainterior = 0;
		armaname.text = "RataTaPUM V2";
		armasel = 1;
		iconodisp.sprite = armasspriteequipada[0];
		

		



		
		
		
	}
	public void fixedStart()
	{
		
	}




	// Token: 0x0600001E RID: 30 RVA: 0x00002604 File Offset: 0x00000804
	public void Update()
	{

		if(vida < ((vidamaxN/100)* 25))
		{

			critico.UnPause();
				
		}
		else
		{
			critico.Pause();
		}

		if(vida < ((vidamaxN/100)* 30))
		{
            colorC = ((((vidamaxN/100)* 30) - (((vida/vidamaxN))) * 100))/300*4;
        }
        else
        {
            colorC = 0;
        }
		Critobj.color = new Color(Critobj.color.r,Critobj.color.g,Critobj.color.b,Mathf.Lerp(Critobj.color.a,colorC, Time.deltaTime * 2f));

		


	if (minabalas > minabalasmax[manager.datosserial.nivelarmasnave[1]  -1])
	{minabalas = minabalasmax[manager.datosserial.nivelarmasnave[1]  -1];}
	if (misilbalas > misilbalasmax[manager.datosserial.nivelarmasnave[2]  -1])
	{misilbalas = misilbalasmax[manager.datosserial.nivelarmasnave[2]  -1];}
	if (escopetabalas > escopetabalasmax[manager.datosserial.nivelarmasnave[3]  -1])
	{escopetabalas = escopetabalasmax[manager.datosserial.nivelarmasnave[3]  -1];}


	if(escudoeneact)
	{
		if(escudosene == 1)
		{
			vidaescudoUI1 = Mathf.Lerp(vidaescudoUI1,  vidaescudoene1, Time.deltaTime * 2f);
		}

		if(escudosene == 1)
		{
			escudoeneimg1.fillAmount = vidaescudoUI1/vidaescudomaxene;
		}
		
		
		
	}
	else
	{

		escudoeneimg1.fillAmount = 0;
		
		
	}
	
	if(vidaeneact)
	{vidaeneimg.fillAmount = vidaeneui/vidaeneuimax;}
	if(vida < 1)
	{
		critico.Pause();
		vida = 0;
		muerte = true;
	}
	if(muerte == true)
	{

			
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
		staminaobj = Mathf.Lerp(staminaobj, stamina, Time.deltaTime * 4f);
		vidaobj = Mathf.Lerp(vidaobj, vida, Time.deltaTime * 2f);
		vidab.fillAmount = vidaobj/vidamaxN; 
		vidat.text = string.Concat("VIT:",(int)vida,"/",(int)vidamaxN);
		niveluit.text = string.Concat("LEVEL ", manager.datosserial.niveljugnave);
		staminabarra.fillAmount = staminaobj/staminamax;
		if(staminaobj < 1)
		{
			staminaobj = 0;
		}
		if(noene == false)
		{
		if(target[0] == null && target1 < targetmax)
		{
			if(objetivotarget == target[0])
			{objetivotarget = null;}
			if(objetivotarget2 == target[0])
			{objetivotarget2 = null;}
			
			target1++;
			for(int i = 0;i >= targetmax ;i++)
			{
				if(enemigosEnContactonave[i] != null)
				{
					target1 = i;
					i = 99;
				}
				
			}

			if(target1 >= targetmax)
			{
				target[0] = null;
				target1 = targetmax;
			}
			else
			{
				target[0] = enemigosEnContactonave[target1];
			}

			target2 = target1 + 1 ;
			target3 = target1 + 2;

			if(target2 >= targetmax)
			{
				target[1] = null;
				target2 = targetmax;
			}
			else
			{
				target[1] = enemigosEnContactonave[target2];
			}
			if(target3 >= targetmax)
			{
				target[2] = null;
				target3 = targetmax;
			}
			else
			{
				target[2] = enemigosEnContactonave[target3];
			}

			
		}
		if(target[1]  == null && target2 < targetmax)
		{
			if(objetivotarget == target[1])
			{objetivotarget = null;}
			if(objetivotarget2 == target[1])
			{objetivotarget2 = null;}


			target2++;
			for(int i = target2; i >= targetmax ;i++)
			{
                    if (enemigosEnContactonave.Length > i)
                    {
                        if (enemigosEnContactonave[i] != null && enemigosEnContactonave[i] != target[0])
                        {
                            target2 = i;
                            i = 99;
                        }
                    }

            }

			if(target2 >= targetmax)
			{
				target[1] = null;
				target2 = targetmax;
			}
			else
			{
				target[1] = enemigosEnContactonave[target2];
			}
			target3 = target2 + 1;

			if(target3 >= targetmax)
			{
				target[2] = null;
				target3 = targetmax;
			}
			else
			{
				target[2] = enemigosEnContactonave[target3];
			}

			
		}
		if(target[2] == null && target3 < targetmax)
		{
			if(objetivotarget == target[2])
			{objetivotarget = null;}
			if(objetivotarget2 == target[2])
			{objetivotarget2 = null;}

			target3++;
			for(int i = target3; i >= targetmax ;i++)
			{
                    if (enemigosEnContactonave.Length > i)
                    {
                        if (enemigosEnContactonave[i] != null && enemigosEnContactonave[i] != target[0] && enemigosEnContactonave[i] != target[1])
                        {
                            target3 = i;
                            i = 99;
                        }
                    }
                }

			if(target3 >= targetmax)
			{
				target[2] = null;
				target3 = targetmax;
			}
			else
			{
				target[2] = enemigosEnContactonave[target3];  
			}

			
		}
		}
		



	interactuarc = 0;
	if(controlact == true)
	{










			

		ruletaXc = controles.al2_nave.ruletaPAD.ReadValue<Vector2>().x;
		ruletaYc = controles.al2_nave.ruletaPAD.ReadValue<Vector2>().y;


		camXc = controles.al2_nave.camX.ReadValue<float>();
		camYc = controles.al2_nave.camY.ReadValue<float>();
		


		if(movact == 0)
		{
			movXc = controles.al2_nave.mov.ReadValue<Vector2>().x;
			movYc = controles.al2_nave.mov.ReadValue<Vector2>().y;	
		}

		
		acelerarc = controles.al2_nave.acelerar.ReadValue<float>();
		M_desplacamientoc = controles.al2_nave.M_desplacamiento.ReadValue<float>();
		UIXc = controles.al1_UI.UIX.ReadValue<float>();
		UIYc = controles.al1_UI.UIY.ReadValue<float>();	
		turboc = controles.al2_nave.turbo.ReadValue<float>();
		giro180c = controles.al2_nave.giro180.ReadValue<float>();
		interactuarc = controles.al2_nave.interactuar.ReadValue<float>();		
		dispararc = controles.al2_nave.disparar.ReadValue<float>();
		escudoc = controles.al2_nave.escudo.ReadValue<float>();	
		UIreducidoc = controles.al2_nave.UIreducido.ReadValue<float>();
		marcarc = controles.al2_nave.marcar.ReadValue<float>();
		dashc = controles.al2_nave.dash.ReadValue<float>();

		menu1c = controles.al2_nave.menu1.ReadValue<float>();
		menu2c = controles.al2_nave.menu2.ReadValue<float>();


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
		
		camXc = controles.al2_nave.camX.ReadValue<float>();
		camYc = controles.al2_nave.camY.ReadValue<float>();
		
	}
	

			


		if(armasel == 1)
		{
			//disparo
			balaarmat.text = "infinty";
			armanvt.text = string.Concat("nv",manager.datosserial.nivelarmasnave[0] );
			

		}
		if(armasel == 2)
		{
			//mina
			balaarmat.text = string.Concat((int)minabalas,"/",minabalasmax[manager.datosserial.nivelarmasnave[1]  -1]);
			armanvt.text = string.Concat("nv",manager.datosserial.nivelarmasnave[1] );


		}
		if(armasel == 3)
		{
			//misil
			balaarmat.text = string.Concat((int)misilbalas,"/",misilbalasmax[manager.datosserial.nivelarmasnave[2]  -1]);
			armanvt.text = string.Concat("nv",manager.datosserial.nivelarmasnave[2] );
			
		}
		if(armasel == 4)
		{
			//escopeta
			balaarmat.text = string.Concat((int)escopetabalas,"/",escopetabalasmax[manager.datosserial.nivelarmasnave[3]  -1]);
			armanvt.text = string.Concat("nv",manager.datosserial.nivelarmasnave[3] );

			
		}
		



		paloimg.fillAmount = 1;
		circulopaloimg.fillAmount = 1;
		paloimg.sprite = arma1;

		if(manager.datosserial.armasnave[1] == true)
		{
			
			circulorelentizarimg.fillAmount = minabalas/minabalasmax[manager.datosserial.nivelarmasnave[1]  -1];
			relentizarimg.sprite = arma2;
		}
		else
		{
			relentizarimg.sprite = nopimg;
		}
		if(manager.datosserial.armasnave[2] == true)
		{
			
			circuloarmadefimg.fillAmount = misilbalas/misilbalasmax[manager.datosserial.nivelarmasnave[2]  -1];
			armadefimg.sprite = arma3;
		}
		else
		{
			armadefimg.sprite = nopimg;
		}
		if(manager.datosserial.armasnave[3] == true)
		{
			
			circulopistolaimg.fillAmount = escopetabalas/escopetabalasmax[manager.datosserial.nivelarmasnave[3]  -1];
			pistolaimg.sprite = arma4;
		}
		else
		{
			pistolaimg.sprite  = nopimg;
		}
		if(ruletac > 0 && tiempodisp > 0.2f)
		{

			ruletainterior++;
			if(ruletainterior >= 1)
			{ruletainterior = 0;}
			cambioruedaact = 0;
			tiempodisp = 0;
			
		}
		if(ruletainterior == 0)
		{
				comandoarma.text = "Armas 1";
				if(manager.datosserial.armasjug[0] == true)
				{

					armaimg[0].fillAmount = 1;
					circuloarmaimg[0].fillAmount = 1;

					

					
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
					

					if(manager.datosserial.armasjug[0] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else
					{
						if(armasel == 1)
						{
							armaimg[0].sprite = armasspriterueda[0];
							armaimg[0].color = new Color(1,1,1,1);
							backarmaimg[0].sprite = armasspriterueda[0];

						}
						else
						{
							armaimg[0].sprite = armasspriterueda[0];
							armaimg[0].color = new Color(1,1,1,0.1f);
							backarmaimg[0].sprite = armasspriterueda[0];

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
						if(armasel == 2)
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
						if(armasel == 4)
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
						if(armasel == 3)
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
						armaname.text = "RataTaPUM V2";
						armaimg[0].color = new Color(1,1,1,1f);

						if(manager.datosserial.armasjug[2])
						{armaimg[2].color = new Color(1,1,1,0.1f);}
						if(manager.datosserial.armasjug[2])
						{armaimg[3].color = new Color(1,1,1,0.1f);}
						if(manager.datosserial.armasjug[1])
						{armaimg[1].color = new Color(1,1,1,0.1f);}

						armaimg[1].color = new Color(1,1,1,1);
						backarmaimg[1].color = new Color(1,1,1,0.3f);


						tiempodisp = 0;
						armasel = 1;
						manager.datosserial.ruletainterior_armas = 0;
						iconodisp.sprite = armasspriteequipada[0];
						manager.guardar();

						
						
						
						
					}
				}
			
				if(ruletaXc > 0f )
				{
					if(manager.datosserial.armasjug[1] == true && tiempodisp > 0.2f)
					{
						armaname.text = "REYNOVES";
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
						armasel = 2;
						manager.datosserial.ruletainterior_armas = 0;
						iconodisp.sprite = armasspriteequipada[1];
						manager.guardar();
						

					}
				}
				if(ruletaYc < 0f )
				{
					armaname.text = "InSitu";
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
						armasel = 3;
						manager.datosserial.ruletainterior_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[2];
						
					}
				}
				if(ruletaXc < 0f )
				{
					armaname.text = "PX4000 Quebrada";
					if(manager.datosserial.armasjug[3] == true && tiempodisp > 0.2f)
					{
						armaname.text = "Mina Guardian V2";
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
						armasel = 4;
						manager.datosserial.ruletainterior_armas = 0;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[3];
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
					
					if(manager.datosserial.armasjug[4] == false)
					{
						armaimg[0].sprite = nopimg;
						armaimg[0].color = new Color(1,1,1,1);
						backarmaimg[0].sprite = nopimg;
					}
					else 
					{
						if(armasel == 5)
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
						if(armasel == 6)
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
						if(armasel == 7)
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
						if(armasel == 8)
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
						armaname.text = "null";
						if(manager.datosserial.armasjug[6])
						{armaimg[2].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[7])
						{armaimg[3].color = new Color(1,1,1,0.1f);}

						if(manager.datosserial.armasjug[5])
						{armaimg[1].color = new Color(1,1,1,0.1f);}


						
						
						
						armaimg[0].color = new Color(1,1,1,1f);
						backarmaimg[0].color = new Color(1,1,1,0.3f);
						
						tiempodisp = 0;
						armasel = 5;
						manager.datosserial.ruletainterior_armas = 1;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[4];

						
					}
				}	
				if(ruletaXc > 0f )
				{
					armaname.text = "null";
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
						armasel = 6;
						manager.datosserial.ruletainterior_armas = 1;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[5];
					}
				}
				if(ruletaYc < 0f )
				{
					armaname.text = "null";
					
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
						armasel = 7;
						manager.datosserial.ruletainterior_armas = 1;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[6];
						
					}
				}
				if(ruletaXc < -0f )
				{
					armaname.text = " null";
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
						armasel = 8;
						manager.datosserial.ruletainterior_armas = 1;
						manager.guardar();
						iconodisp.sprite = armasspriteequipada[7];
					}
				}
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
			


		Vector3 movdirnow = new Vector3(0,0,0);
		
		
	if(controlact == true)
	{


				

				
				
		if (escudoc > 0f && dialogueact == false && stamina >= 30)
		{
			escudoact = true;
			Gescudo_nave.SetActive(true);
			stamina -= 40 * Time.deltaTime;
			staminaact = 0;
			if(stamina < 30)
			{
				stamina = 0;
			}
		}
		else
		{
			escudoact = false;
			Gescudo_nave.SetActive(false);
		}

		if(M_desplacamientoc == 0)
		{

			
			if (movXc > 0f )  
			{
				base.transform.Rotate(Vector3.up, Time.deltaTime * 50f);
			}
			if (movXc < 0f )
			{
				base.transform.Rotate(Vector3.down, Time.deltaTime * 50f);
			}
			if (movYc > 0f )
			{
				base.transform.Rotate(Vector3.right, Time.deltaTime * -50f);
			}
			if (movYc < 0f )
			{
				base.transform.Rotate(Vector3.left, Time.deltaTime * -50f);
			}


			if(turboc > 0f && dialogueact == false && tempdash > 1f && tiempodisp > 1.2f && stamina > 1)
			{
				slash.SetActive(true);
				pasos1.UnPause();
				pasos2.Pause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,1 * 100));
				movnave = true;
				stamina -= 10* Time.deltaTime;
				staminaact = 0;
				viento_nave.SetActive(true);
			}
			else if (acelerarc > 0f && dialogueact == false )
			{
				slash.SetActive(true);
				pasos2.UnPause();
				pasos1.Pause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,1 * 70));
				movnave = true;
				viento_nave.SetActive(false);
				temp9 = 0;
			}
			else
			{
				slash.SetActive(false);
				pasos1.Pause();
				pasos2.Pause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,0));
				movnave = false;
				movnave2 = false;
				viento_nave.SetActive(false);
			}
		}
		else if(M_desplacamientoc > 0)
		{
		
			
			if(movXc != 0 || movYc != 0 || tempdash <= 1f)
			{
				pasos2.UnPause();
				slash.SetActive(true);
			}
			else
			{
				pasos2.Pause();
				slash.SetActive(false);
			}

			if(turboc > 0f && dialogueact == false && tempdash > 1f && tiempodisp > 1.2f && stamina > 1)
			{
				slash.SetActive(true);
				pasos1.UnPause();
				pasos2.Pause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (movXc * 70, movYc *70,1 * 100));
				movnave = true;
				stamina -= 10* Time.deltaTime;
				staminaact = 0;
				viento_nave.SetActive(true);
			}
			else
			{
				slash.SetActive(false);
				pasos1.Pause();
				pasos2.Pause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (movXc * 70, movYc *70,0));
				movnave = false;
				movnave2 = false;
				viento_nave.SetActive(false);
			}


			
			if(dashc > 0f && dialogueact == false && tempdash > 1f && tiempodisp > 1.2f && stamina >= 15 && movXc != 0 && temp9 > 1
			|| dashc > 0f && dialogueact == false && tempdash > 1f && tiempodisp > 1.2f && stamina >= 15 && movYc != 0 && temp9 > 1)
			{
				
				slash.SetActive(false);
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,0));
				Vector3 dashnavedir = new Vector3 (movXc,movYc,0);
				movdire = transform.TransformDirection(dashnavedir);
				tempdash = 0;
				dashaeract = true;
				tiempodisp = 0;
				stamina -= 25;
				speednave = 25;
				staminaact = -2;
				anim.Play("mov");
				anim.SetFloat("x",dashnavedir.x);
				anim.SetFloat("y",dashnavedir.y);
				dashson.Play();
				
							

					
					
			}


		}
		
			


			

		

		


			
		if(Physics.Raycast(transform.position,movdire * 250,out hit,Mathf.Infinity))
		{
			if(hit.distance < (25f))
			{
				dashaeract = false;
			}
			Debug.DrawRay(transform.position,movdire * 250, Color.red);
		}
		if(tempgir > 0)
		{	
			transform.rotation = Quaternion.RotateTowards(transform.rotation, fij,360 * Time.deltaTime);
		}

		if (giro180c > 0f && tiempodisp > 0.5f && tempgir <= 0 && stamina >= 30)
		{
			tempgir = 0.5f;
			fij.SetLookRotation(-transform.forward,transform.up);
			stamina -= 30;
			staminaact = 0;
			
		}
		
		if(tempdash < 1f && dashaeract == true)
		{
			transform.position = Vector3.MoveTowards(transform.position,transform.position + movdire * speednave,500 * Time.deltaTime);
			tempdash += Time.deltaTime;
		}
		else
		{
			dashaeract = false;
		}
			

			

			





			if(camXc != 0 && objetivotarget == null)
            {rotationinput.x = camXc * 100 * Time.deltaTime;}
            else{rotationinput.x = 0;}
			

			if(camYc != 0 && objetivotarget == null)

            {rotationinput.y = camYc * 100 * Time.deltaTime;}
            else{rotationinput.y = 0;}

			if(objetivotarget != null && controlact == true)
			{
				if(camXc == 0)
				{
					camXc = camYc;
				}
				Vector3 directiontt = objetivotarget.transform.position - transform.position;
				Quaternion rotation = Quaternion.LookRotation(directiontt);
				transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(rotation.eulerAngles.x,rotation.eulerAngles.y,rotation.eulerAngles.z),2f * Time.deltaTime);
			}
            
            transform.Rotate(Vector3.up * rotationinput.x);
			transform.Rotate(Vector3.left * rotationinput.y);
		
			
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
		

			


			

			

			

			

			
			

			
			

			
			


			
			
			
		

			if(armasel == 1)
			{

				//disparo
				if(dispararc > 0 && tiempodisp2 > 0.1f)
				{

					tiempodisp2 = 0;

					GameObject BalaTemporal = Instantiate(armasbalas.disparoBalanave[manager.datosserial.nivelarmasjug[6]-1], pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * 200);
					
					romperbalajug_al1 bala_temp = BalaTemporal.GetComponent<romperbalajug_al1>();
					bala_temp.destb = 4f;
					bala_temp.danoesc = 5;
					bala_temp.danoj = manager.datosserial.armanavedano[0];
					

					disp.Play();

				}

			}
			if(armasel == 2)
			{

				//mina
				if(dispararc > 0 && tiempodisp2 > 1f && minabalas > 0)
				{

					tiempodisp2 = 0;

					minabalas--;

					GameObject BalaTemporal = Instantiate(armasbalas.minaBalanave[manager.datosserial.nivelarmasjug[6]-1], pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * 20);
					
					romperbalajug_al1 bala_temp = BalaTemporal.GetComponent<romperbalajug_al1>();
					bala_temp.destb = 60f;
					bala_temp.danoesc = 100;
					bala_temp.danoj = manager.datosserial.armanavedano[1];
					

					disp.Play();

				}
			}
			if(armasel == 3)
			{
				//misil
				if(dispararc > 0 && tiempodisp2 > 1f && misilbalas > 0)
				{

					tiempodisp2 = 0;

					misilbalas--;

					GameObject BalaTemporal = Instantiate(armasbalas.misilBalanave[manager.datosserial.nivelarmasjug[6]-1], pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * 200);
						BalaTemporal.GetComponent<romperbalajug_al1>().objtele = objetivotarget;

					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * 200);
					}
					
					romperbalajug_al1 bala_temp = BalaTemporal.GetComponent<romperbalajug_al1>();
					bala_temp.destb = 4f;
					bala_temp.danoesc = 30;
					bala_temp.danoj = manager.datosserial.armanavedano[2];
					

					disp.Play();

				}
			}
			if(armasel == 4)
			{

				//escopeta
				if(dispararc > 0 && tiempodisp2 > 1f && escopetabalas > 0)
				{

					tiempodisp2 = 0;

					escopetabalas--;

					GameObject BalaTemporal = Instantiate(armasbalas.rataBalajug[manager.datosserial.nivelarmasjug[6]-1], pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * 40);
					
					romperbalajug_al1 bala_temp = BalaTemporal.GetComponent<romperbalajug_al1>();
					bala_temp.destb = 0.4f;
					bala_temp.danoesc = 30;
					bala_temp.danoj = manager.datosserial.armanavedano[3];
					

					disp.Play();

				}
			}
	}
	else
	{
		slash.SetActive(false);
		pasos1.Pause();
		pasos2.Pause();
		_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,0));
		movnave = false;
		movnave2 = false;
		viento_nave.SetActive(false);
		escudoact = false;
		Gescudo_nave.SetActive(false);

	}

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

		if(tempretarget < 15)
		{tempretarget += 1 * Time.deltaTime;}

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

		if(tiempodialogue < 15)
        {tiempodialogue += 1 * Time.deltaTime;}

		if(tempatk < 15)
        {tempatk += 1 * Time.deltaTime;}


			if(staminaact > 0.7f)
			{
				if (stamina < 0)
				{stamina = 0;}
				if(stamina < 100)
				{stamina += 40 * Time.deltaTime;}
				else{stamina = 100;}
			}
			else
			{
				staminaact += 1 * Time.deltaTime;
			}

			if(tempparry < 15)
			{tempparry += 1 * Time.deltaTime;}
		





		turboc = 0;
		giro180c = 0;

		dispararc = 0;
		M_desplacamientoc = 0;
		dashc = 0;
		escudoc  = 0;


		movXc = 0;
		movYc = 0;


		camXc = 0;
		camYc = 0;

		ruletaXc = 0;
		ruletaYc = 0;

		

		
		dispararc = 0;
		escudoc = 0;
		
		UIreducidoc = 0;
		marcarc = 0;
		
	}

	

	// Token: 0x06000021 RID: 33 RVA: 0x0000318C File Offset: 0x0000138C
	public void OnCollisionEnter(Collision col)
	{
		
		

	}

	// Token: 0x06000022 RID: 34 RVA: 0x000031C0 File Offset: 0x000013C0
	public void OnCollisionStay(Collision col)
	{
		
		

	}


	// Token: 0x06000023 RID: 35 RVA: 0x00003284 File Offset: 0x00001484
	public void OnCollisionExit(Collision col)
	{
		
	
	}
	public void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "vidarec")
        {
           munson.Play();
        }
        if (col.gameObject.tag == "armaene")
		{
			if(col.gameObject.GetComponent<romperbala_al1>() != null && escudoact == false)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.salir == true)
				{
					muertesjug.Play();
					
					if(enec.danofijo == true)
					{
						vida -= (vidamaxN/100) * enec.porcentaje;
					}
					else
					{vida -= enec.danoj;}
				}
			}
			if(col.gameObject.GetComponent<romperbala_al1>() != null && escudoact == true  && tempparry > 8)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.salir == true)
				{
					int Randomun = Random.Range(0,3);

					if(Randomun == 0)
					{minabalas++;}
					if(Randomun == 1)
					{misilbalas += 5;}
					if(Randomun == 2)
					{escopetabalas += 3;}
					tempparry = 0;

				}
			}
		}
		if (col.gameObject.tag == "evento")
		{
			eventosdialogueE = col.GetComponent<eventosdialogue_al1>();
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
		if (col.gameObject.tag == "armaene")
		{
			if(col.gameObject.GetComponent<romperbala_al1>() != null && escudoact == false)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.salir == true)
				{

					muertesjug.Play();
					
					if(enec.danofijo == true)
					{
						vida -= (vidamaxN/100) * enec.porcentaje;
					}
					else
					{vida -= enec.danoj;}
				}
			}
			if(col.gameObject.GetComponent<romperbala_al1>() != null && escudoact == true && tempparry > 8)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.salir == true)
				{
					int Randomun = Random.Range(0,3);

					if(Randomun == 0)
					{minabalas++;}
					if(Randomun == 1)
					{misilbalas += 5;}
					if(Randomun == 2)
					{escopetabalas += 3;}
					tempparry = 0;

				}
			}
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
		
	}
	public void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.tag == "evento" && eventoini == true)
		{
			eventosdialogueE = col.GetComponent<eventosdialogue_al1>();
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






	





	public GameObject []target = new GameObject[3];

	public Text balaarmat;



	public GameObject slash;
	public AudioSource dashson;
	public GameObject balaprefabpapa;
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



	public Text textnpc;
	public AudioSource disp;
	public AudioSource disprel;
	public AudioSource dispdef;

	public GameObject pistolap;
	public AudioSource pasos1;
	public AudioSource pasos2;

	public Image backpaloimg;
	public Sprite arma1;
	public Sprite arma2;
	public Sprite arma3;
	public Sprite arma4;



	public Text vidat;

	public Image staminabarra;


	public GameObject Gescudo_nave;
	public GameObject viento_nave;

	


	
}
