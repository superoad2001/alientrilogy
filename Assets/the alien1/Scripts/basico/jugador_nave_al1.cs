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
public class jugador_nave_al1 : jugador_al1
{
	
	[Header("Propio nave")]

	public jugador_al1 jugador;
	private float temp9;
	public GameObject tarboss;
	private float vidaescudoUI1;
	public int armanavesel = 1;
	public float vidaobj;
	private float tempparry = 8;
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
	private float vidamaxN;
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
	public float girodir = -90;
	private float temppalo = 60;
	private float tempatk;
	private int numpociones;
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
	private float interactuarc;
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
		
		

		jugador_al1 jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}
		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

		





			if(manager.datosserial.tengoarmanave4 == false)
			{
				pistolaimg.sprite = nopimg;
			}

			if(manager.datosserial.tengoarmanave2  == false)
			{
				relentizarimg.sprite = nopimg;
			}
			
			if(manager.datosserial.tengoarmanave3 == false)
			{
				armadefimg.sprite = nopimg;
			}

			
			paloimg.color = new Color(1,1,1,1f);
			pistolaimg.color = new Color(1,1,1,0.1f);
			relentizarimg.color = new Color(1,1,1,0.1f);
			armadefimg.color = new Color(1,1,1,0.1f);

			iconodisp.sprite = arma1;
			
		


		

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
		


			balaarmanave1dano[0]  = 1;
			balaarmanave1dano[1]  = 2;
			balaarmanave1dano[2]  = 3;

			balaarmanave2dano[0]  = 20;
			balaarmanave2dano[1]  = 40;
			balaarmanave2dano[2]  = 60;

			balaarmanave3dano[0]  = 5;
			balaarmanave3dano[1]  = 7.5f;
			balaarmanave3dano[2]  = 10;
			
			balaarmanave4dano[0]  = 10;
			balaarmanave4dano[1]  = 20;
			balaarmanave4dano[2]  = 30;

			minabalasmax[0] = 3;
			minabalasmax[1] = 5;
			minabalasmax[2] = 7;

			misilbalasmax[0] = 10;
			misilbalasmax[1] = 15;
			misilbalasmax[2] = 20;

			escopetabalasmax[0] = 8;
			escopetabalasmax[1] = 10;
			escopetabalasmax[2] = 12;


			
			
			minabalas = minabalasmax[manager.datosserial.nivelarmanave2 -1];
			misilbalas = misilbalasmax[manager.datosserial.nivelarmanave3 -1];
			escopetabalas = escopetabalasmax[manager.datosserial.nivelarmanave4 -1];

			vidanivelesnave.Add(999);
			vidanivelesnave.Add(1999);
			vidanivelesnave.Add(2999);
			vidanivelesnave.Add(3999);
			vidanivelesnave.Add(4999);

			vidanivelesnave.Add(5999);
			vidanivelesnave.Add(6999);
			vidanivelesnave.Add(7999);
			vidanivelesnave.Add(8999);
			vidanivelesnave.Add(9999);

			vidanivelesnave.Add(19999);
			vidanivelesnave.Add(29999);
			vidanivelesnave.Add(39999);
			vidanivelesnave.Add(49999);
			vidanivelesnave.Add(59999);

			vidanivelesnave.Add(69999);
			vidanivelesnave.Add(79999);
			vidanivelesnave.Add(89999);
			vidanivelesnave.Add(99999);
			vidanivelesnave.Add(200000);

			vidamaxN = vidanivelesnave[manager.datosserial.niveljugnave - 1];
			vida = vidamaxN;
			staminaobj = stamina;
			vidaobj = vida;

		
		
		
	}
	public void fixedStart()
	{
		
	}




	// Token: 0x0600001E RID: 30 RVA: 0x00002604 File Offset: 0x00000804
	public void Update()
	{


	if (minabalas > minabalasmax[manager.datosserial.nivelarmanave2 -1])
	{minabalas = minabalasmax[manager.datosserial.nivelarmanave2 -1];}
	if (misilbalas > misilbalasmax[manager.datosserial.nivelarmanave3 -1])
	{misilbalas = misilbalasmax[manager.datosserial.nivelarmanave3 -1];}
	if (escopetabalas > escopetabalasmax[manager.datosserial.nivelarmanave4 -1])
	{escopetabalas = escopetabalasmax[manager.datosserial.nivelarmanave4 -1];}


	if(escudoeneact)
	{
		if(escudosene >= 1)
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
	

	if(vida < 1)
	{
		vida = 0;
		muerte = true;
	}
	if(muerte == true)
	{

			
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
		staminaobj = Mathf.Lerp(staminaobj, stamina, Time.deltaTime * 4f);
		vidaobj = Mathf.Lerp(vidaobj, vida, Time.deltaTime * 2f);
		vidab.fillAmount = vidaobj/vidamax; 
		vidat.text = "VIT:"+(int)vida+"/"+(int)vidamaxN;
		niveluit.text = "LEVEL "+ manager.datosserial.nivelnavejug;
		staminabarra.fillAmount = staminaobj/staminamax;
		if(staminaobj < 1)
		{
			staminaobj = 0;
		}
		
		if(temprelectura > 8)
		{
			
			if(enemigosEnContactonave[0] != null)
			{
				target[0] = enemigosEnContactonave[0]; 
			}
			if(enemigosEnContactonave[1] != null)
			{
				target[1] = enemigosEnContactonave[1]; 
			}
			if(enemigosEnContactonave[2] != null)
			{
				target[2] = enemigosEnContactonave[2]; 
			}
			temprelectura = 0;
			Debug.Log("1");
		}
		else
		{
			Debug.Log("2");
			temprelectura += 1 * Time.deltaTime;
		}



	if(controlact == true)
	{










			

		ruletaXc = controles.al1_nave.ruletaX.ReadValue<float>();
		ruletaYc = controles.al1_nave.ruletaY.ReadValue<float>();


		camXc = controles.al1_nave.camX.ReadValue<float>();
		camYc = controles.al1_nave.camY.ReadValue<float>();
		


		if(movact == true)
		{
			movXc = controles.al1_nave.movX.ReadValue<float>();
			movYc = controles.al1_nave.movY.ReadValue<float>();	
		}

		
		acelerarc = controles.al1_nave.acelerar.ReadValue<float>();
		M_desplacamientoc = controles.al1_nave.M_desplacamiento.ReadValue<float>();
		UIXc = controles.al1_UI.UIX.ReadValue<float>();
		UIYc = controles.al1_UI.UIY.ReadValue<float>();	
		turboc = controles.al1_nave.turbo.ReadValue<float>();
		giro180c = controles.al1_nave.giro180.ReadValue<float>();
		interactuarc = controles.al1_nave.interactuar.ReadValue<float>();		
		dispararc = controles.al1_nave.disparar.ReadValue<float>();
		escudoc = controles.al1_nave.escudo.ReadValue<float>();	
		UIreducidoc = controles.al1_nave.UIreducido.ReadValue<float>();
		marcarc = controles.al1_nave.marcar.ReadValue<float>();
		dashc = controles.al1_nave.dash.ReadValue<float>();

		menu1c = controles.al1_nave.menu1.ReadValue<float>();
		menu2c = controles.al1_nave.menu2.ReadValue<float>();


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
		
		camXc = controles.al1_nave.camX.ReadValue<float>();
		camYc = controles.al1_nave.camY.ReadValue<float>();
		
	}
	

			


		if(armanavesel == 1)
		{
			//disparo
			balaarmat.text = "infinty";
			armanvt.text = "nv"+manager.datosserial.nivelarmanave1;
			

		}
		if(armanavesel == 2)
		{
			//mina
			balaarmat.text = (int)minabalas+"/"+minabalasmax[manager.datosserial.nivelarmanave2 -1];
			armanvt.text = "nv"+manager.datosserial.nivelarmanave2;


		}
		if(armanavesel == 3)
		{
			//misil
			balaarmat.text = (int)misilbalas+"/"+misilbalasmax[manager.datosserial.nivelarmanave3 -1];
			armanvt.text = "nv"+manager.datosserial.nivelarmanave3;
			
		}
		if(armanavesel == 4)
		{
			//escopeta
			balaarmat.text = (int)escopetabalas+"/"+escopetabalasmax[manager.datosserial.nivelarmanave4 -1];
			armanvt.text = "nv"+manager.datosserial.nivelarmanave4;

			
		}
		



		paloimg.fillAmount = 1;
		circulopaloimg.fillAmount = 1;
		paloimg.sprite = arma1;

		if(manager.datosserial.tengoarmanave2 == true)
		{
			
			circulorelentizarimg.fillAmount = minabalas/minabalasmax[manager.datosserial.nivelarmanave2 -1];
			relentizarimg.sprite = arma2;
		}
		if(manager.datosserial.tengoarmanave3 == true)
		{
			
			circuloarmadefimg.fillAmount = misilbalas/misilbalasmax[manager.datosserial.nivelarmanave3 -1];
			armadefimg.sprite = arma3;
		}
		if(manager.datosserial.tengoarmanave4 == true)
		{
			
			circulopistolaimg.fillAmount = escopetabalas/escopetabalasmax[manager.datosserial.nivelarmanave4 -1];
			pistolaimg.sprite = arma4;
		}

		if(ruletaYc > 0.5f)
		{
			if(tiempodisp > 0.2f)
			{
				paloimg.color = new Color(1,1,1,1f);
				pistolaimg.color = new Color(1,1,1,0.1f);
				relentizarimg.color = new Color(1,1,1,0.1f);
				armadefimg.color = new Color(1,1,1,0.1f);

				balaprefabpapa = prebalanave1[manager.datosserial.nivelarmanave1 -1];
				tiempodisp = 0;
				armanavesel = 1;
				iconodisp.sprite = arma1;
				
			}
		}
		if(ruletaYc < -0.5f )
		{

			if(manager.datosserial.tengoarmanave3 == true && tiempodisp > 0.2f)
			{
				paloimg.color = new Color(1,1,1,0.1f);
				pistolaimg.color = new Color(1,1,1,0.1f);
				relentizarimg.color = new Color(1,1,1,0.1f);
				armadefimg.color = new Color(1,1,1,1f);

				balaprefabpapa = prebalanave3[manager.datosserial.nivelarmanave3 -1];
				tiempodisp = 0;
				armanavesel = 3;
				iconodisp.sprite = arma3;
				
			}
			
		}
		if(ruletaXc > 0.5f )
		{
			if(manager.datosserial.tengoarmanave4 == true && tiempodisp > 0.2f)
			{
				paloimg.color = new Color(1,1,1,0.1f);
				pistolaimg.color = new Color(1,1,1,1f);
				relentizarimg.color = new Color(1,1,1,0.1f);
				armadefimg.color = new Color(1,1,1,0.1f);

				balaprefabpapa = prebalanave4[manager.datosserial.nivelarmanave4 -1];
				tiempodisp = 0;
				armanavesel = 4;
				iconodisp.sprite = arma4;
				
			}		
		}
		if(ruletaXc < -0.5f )
		{
			if(manager.datosserial.tengoarmanave2 == true && tiempodisp > 0.2f)
			{
				paloimg.color = new Color(1,1,1,0.1f);
				pistolaimg.color = new Color(1,1,1,0.1f);
				relentizarimg.color = new Color(1,1,1,1f);
				armadefimg.color = new Color(1,1,1,0.1f);

				balaprefabpapa = prebalanave2[manager.datosserial.nivelarmanave2 -1];
				tiempodisp = 0;
				armanavesel = 2;
				iconodisp.sprite = arma2;
				
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


			
			if(dashc > 0f && dialogueact == false && tempdash > 1f && tiempodisp > 1.2f && stamina >= 50 && movXc != 0 && temp9 > 1
			|| dashc > 0f && dialogueact == false && tempdash > 1f && tiempodisp > 1.2f && stamina >= 50 && movYc != 0 && temp9 > 1)
			{
				
				slash.SetActive(false);
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,0));
				Vector3 dashnavedir = new Vector3 (movXc,movYc,0);
				movdire = transform.TransformDirection(dashnavedir);
				tempdash = 0;
				dashaeract = true;
				tiempodisp = 0;
				stamina -= 50;
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
			transform.rotation = Quaternion.RotateTowards(transform.rotation, fij,180 * Time.deltaTime);
		}

		if (giro180c > 0f && tiempodisp > 1 && tempgir <= 0 && stamina >= 30)
		{
			tempgir = 1;
			tiempodisp = 0;
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

			if(objetivotarget != null)
			{
				if(camXc == 0)
				{
					camXc = camYc;
				}
				Vector3 directiontt = objetivotarget.transform.position - transform.position;
				Quaternion rotation = Quaternion.LookRotation(directiontt);
				transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(rotation.eulerAngles.x,rotation.eulerAngles.y,rotation.eulerAngles.z),0.5f * Time.deltaTime);
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
		

			


			

			

			

			

			
			

			
			

			
			


			
			
			
		

			if(armanavesel == 1)
			{

				//disparo
				if(dispararc > 0 && tiempodisp2 > 0.1f)
				{

					balaprefabpapa = prebalanave1[manager.datosserial.nivelarmanave1 -1];
					tiempodisp2 = 0;

					GameObject BalaTemporal = Instantiate(balaprefabpapa, pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();
					if(objetivotarget != null)
					{
						Vector3 dirTarget = (objetivotarget.transform.position - mod.transform.position).normalized;
    					rbb.AddForce(dirTarget * 110 * 200);
					}
					else
					{
						rbb.AddForce(mod.transform.forward * 110 * 200);
					}

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 5;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balaarmanave1dano[manager.datosserial.nivelarmanave1 -1] * nivelfuerza;
					

					disp.Play();

				}

			}
			if(armanavesel == 2)
			{

				//mina
				if(dispararc > 0 && tiempodisp2 > 1f && minabalas > 0)
				{

					balaprefabpapa = prebalanave2[manager.datosserial.nivelarmanave2 -1];
					tiempodisp2 = 0;

					minabalas--;

					GameObject BalaTemporal = Instantiate(balaprefabpapa, pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * 20);

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 60f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 100;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balaarmanave2dano[manager.datosserial.nivelarmanave2 -1] * nivelfuerza;
					

					disp.Play();

				}
			}
			if(armanavesel == 3)
			{
				//misil
				if(dispararc > 0 && tiempodisp2 > 1f && misilbalas > 0)
				{

					balaprefabpapa = prebalanave3[manager.datosserial.nivelarmanave3 -1];
					tiempodisp2 = 0;

					misilbalas--;

					GameObject BalaTemporal = Instantiate(balaprefabpapa, pistolap.transform.position,pistolap.transform.rotation) as GameObject;

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

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 4f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 30;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balaarmanave3dano[manager.datosserial.nivelarmanave3 -1] * nivelfuerza;
					

					disp.Play();

				}
			}
			if(armanavesel == 4)
			{

				//escopeta
				if(dispararc > 0 && tiempodisp2 > 1f && escopetabalas > 0)
				{

					balaprefabpapa = prebalanave4[manager.datosserial.nivelarmanave4 -1];
					tiempodisp2 = 0;

					escopetabalas--;

					GameObject BalaTemporal = Instantiate(balaprefabpapa, pistolap.transform.position,pistolap.transform.rotation) as GameObject;

					Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

					rbb.AddForce(mod.transform.forward * 110 * 40);
					

					BalaTemporal.GetComponent<romperbalajug_al1>().destb = 0.4f;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoesc = 30;
					BalaTemporal.GetComponent<romperbalajug_al1>().danoj = balaarmanave4dano[manager.datosserial.nivelarmanave4 -1] * nivelfuerza;
					

					disp.Play();

				}
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

		interactuarc = 0;

		
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
		if (col.gameObject.tag == "dañox10")
		{
			if(col.gameObject.GetComponent<romperbala_al1>() != null && escudoact == false)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.salir == true)
				{
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
	public void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "dañox10")
		{
			if(col.gameObject.GetComponent<romperbala_al1>() != null && escudoact == false)
			{
				romperbala_al1 enec = col.gameObject.GetComponent<romperbala_al1>();
				if(enec.salir == true)
				{

					muertesjug.Play();
					
					if(enec.danofijo == true)
					{
						vida -= (vidamax/100) * enec.porcentaje;
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
		
	}
	public void OnTriggerStay(Collider col)
	{
		
		
		
		
		

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

	public GameObject mod;
	public GameObject pistolap;
	public AudioSource pasos1;
	public AudioSource pasos2;

	public Image backpaloimg;
	public Sprite arma1;
	public Sprite arma2;
	public Sprite arma3;
	public Sprite arma4;



	public GameObject []prebalanave1;
	public GameObject []prebalanave2;
	public GameObject []prebalanave3;
	public GameObject []prebalanave4;
	public Text vidat;

	public Image staminabarra;


	public GameObject Gescudo_nave;
	public GameObject viento_nave;

	


	
}
