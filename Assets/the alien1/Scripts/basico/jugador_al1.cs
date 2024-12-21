using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;

// Token: 0x0200000A RID: 10
public class jugador_al1 : MonoBehaviour
{

	public bool camnomov;
	public float vida = 5;
	public npc_tienda1_al1 npcbase;
	public float tiempodialogue;
	public GameObject respawn;
	public GameObject balaprefab;
	public bool dialogueact;
	public float balavel = 20;
	public Text textnpc;
	public AudioSource audio1;
	public float velcorr = 12;
	public bool controlact = true;
	public AudioSource disp;
	public float temppaso = 1;
	public float rotspeed = 3;
	public GameObject explosion;
	public Quaternion fij;
	public GameObject camara;
	private float cameraverticalangle;
	private float cameraverticalangle2;
	public Vector3 rotationinput;
	public float speed = 3;
	public bool suelo;
	public bool velact;
	public float tiempodisp;
	public GameObject tut10;
	public float girovalor;
	private bool girotder = false;
	private bool girotizq = false;
	private bool girotd_der = false;
	private bool girotd_izq = false;
	public GameObject mod;
	public float lhorizontalc;
	public float lverticalc;
	public float rhorizontalc;
	public float rverticalc;
	public float a;
	public float b;
	public float x;
	public float y;
	public float rb;
	public float rt;
	public float lt;
	public float l3;
	public GameObject tactil;
	public Animator anim;
	public AudioSource pasosnave;
	public AudioSource pasos1;
	public AudioSource pasos2;
	public int randompaso;
	public float pausac;
	public float pasotiempo;
	public float tempgir = 0;
	private float tempdash = 12;
	private float tempdash2 = 12;
	public AudioSource muertes;
	public AudioSource muertesjug;
	public Animator menushow;
	private Controles controles;
	public DialogueManager menuoff;
	private float velocidadalien = 10;

	public float vidamax;
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
	public manager_al1 manager;
	public Animator ascensors;
	public Text vidat;
	// Token: 0x0600001D RID: 29 RVA: 0x000025E8 File Offset: 0x000007E8
	private void Start()
	{
		tiempovelint = 3;
		if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}
		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
		if(GameObject.Find("muerteaudiojug") == true)
		{muertesjug = GameObject.Find("muerteaudiojug").GetComponent<AudioSource>();}
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
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
			velocidad = velocidadalien;
			jumpforce = 700;
		}
		this._rb = base.GetComponent<Rigidbody>();
		this.velocidadaux = this.velocidad;
		girovalor = base.transform.eulerAngles.y;
		jumpforcebase = jumpforce;
		if(anim != null)
		{
			anim.updateMode = AnimatorUpdateMode.Fixed;
		}
		if(manager.juego == 4 || manager.juego == 3 || manager.juego == 0)
		{
			mod = this.gameObject.transform.GetChild(0).gameObject;
		}
		vidamax = manager.datosserial.vidamax;
		vida = vidamax;
		
		
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
	public GameObject juego;
    public GameObject pausa1;
	public float temp9;
	public bool dashaeract;

	private float dash = 0.3f;
	private float dash2 = 0.3f;
	public bool ascact;
	public Image vidab;
	public bool cronoact;
	// Token: 0x0600001E RID: 30 RVA: 0x00002604 File Offset: 0x00000804
	
	private void Update()
	{
	if(manager.juego != 6 && cronoact == false || manager.juego != 0 && cronoact == false || manager.juego != 1  && cronoact == false|| manager.juego != 2 && cronoact == false)
	{vidab.fillAmount = vida/vidamax;
	vidat.text = vida+"/"+vidamax;}
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
	lhorizontalc = controles.al1.lhorizontal.ReadValue<float>();
    lverticalc = controles.al1.lvertical.ReadValue<float>();


	rhorizontalc = controles.al1.rhorizontal.ReadValue<float>();
    rverticalc = controles.al1.rvertical.ReadValue<float>();

	a = controles.al1.a.ReadValue<float>();
	b = controles.al1.b.ReadValue<float>();
	x = controles.al1.x.ReadValue<float>();
	y = controles.al1.y.ReadValue<float>();

	rb = controles.al1.rb.ReadValue<float>();
	rt = controles.al1.rt.ReadValue<float>();
	lt = controles.al1.lt.ReadValue<float>();
	l3 = controles.al1.l3.ReadValue<float>();

	pausac = controles.al1.pausa.ReadValue<float>();

		if (pausac > 0 && temp9 > 0.7f && anim != null)
		{
			manager.pauseact = true;
			pausa1.SetActive(true);
			pausac = 0;
			controlact = false;
			temp9 = 0;
			Time.timeScale = 0;
			anim.Play("tpose");
			if(manager.datosconfig.plat == 2)
			{
				tactil.SetActive(false);
			}
			Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
		}
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
				tiempoascensor = 0;
				manager.datosserial.asc = -1;
				manager.guardar();
			}
			else if (lt> 0f && manager.datosserial.gemas >= 1 && subir1 == false && tiempoascensor > 2f)
			{
				bajar1 = true;
				bajar = true;
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
			if (rt > 0f && manager.datosserial.fragmento == 3 && manager.datosserial.tengollave4 == 1 && bajar4 == false)
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


		if(subir1 == true && tiempoascensor > 0f && manager.datosserial.jefe1 == false && manager.datosserial.tengovel == 1){SceneManager.LoadScene("jefe1_al1");}
		else if(subir1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2_al1");}


		if(subir2 == true && tiempoascensor > 0f && manager.datosserial.jefe2 == false && manager.datosserial.tengocoche == 1){SceneManager.LoadScene("jefe2_al1");}
		else if(subir2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3_al1");}

		if(subir3 == true && tiempoascensor > 0f && manager.datosserial.jefe3 == false && manager.datosserial.tengosalto == 1){SceneManager.LoadScene("jefe3_al1");}
		else if(subir3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso4_al1");}

		if(subir4 == true && tiempoascensor > 0f && manager.datosserial.jefe4 == false && manager.datosserial.tengollave4 == 1){SceneManager.LoadScene("jefe4_al1");}
		else if(subir4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso5_al1");}

		if(bajar1 == true && tiempoascensor > 0f && manager.datosserial.jefe1 == false && manager.datosserial.tengovel == 1){SceneManager.LoadScene("jefe1_al1");}
		else if(bajar1 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("mundo_al1");}

		if(bajar2 == true && tiempoascensor > 0f && manager.datosserial.jefe2 == false && manager.datosserial.tengocoche == 1){SceneManager.LoadScene("jefe2_al1");}
		else if(bajar2 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso1_al1");}

		if(bajar3 == true && tiempoascensor > 0f && manager.datosserial.jefe3 == false && manager.datosserial.tengosalto == 1){SceneManager.LoadScene("jefe3_al1");}
		else if(bajar3 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso2_al1");}

		if(bajar4 == true && tiempoascensor > 0f && manager.datosserial.jefe4 == false && manager.datosserial.tengollave4 == 1){SceneManager.LoadScene("jefe4_al1");}
		else if(bajar4 == true && tiempoascensor > 0.9f){SceneManager.LoadScene("piso3_al1");}







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

				disp.Play();

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
				pasosnave.UnPause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,1 * velocidad));
			}
			else
			{
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
		if (manager.juego == 3 && l3 > 0f )
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
			this.tiempogiro2 += Time.deltaTime;

		if (manager.juego == 3 && this.dimensiion)
		{
			anim.SetFloat("velx",lhorizontalc);
        anim.SetFloat("vely",lverticalc);
			
			if (lhorizontalc > 0f )
            {
                var movdirect = transform.TransformDirection(new Vector3 (-lhorizontalc,0, 0));
				_rb.MovePosition(transform.position + movdirect * velocidad * Time.deltaTime);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                var movdirect = transform.TransformDirection(new Vector3 (-lhorizontalc,0, 0));
				_rb.MovePosition(transform.position + movdirect * velocidad * Time.deltaTime);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            Vector3 movdire = _rb.linearVelocity;
            movdire.y = 0;
            float distaxe = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distaxe,QueryTriggerInteraction.Ignore))
            {
                _rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
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
			this.tiempogiro2 += Time.deltaTime;
		
			
			
			
			
		}
		if (manager.juego == 3 && !this.dimensiion)
		{
			anim.SetFloat("velx",lhorizontalc);
        	anim.SetFloat("vely",lverticalc);
			if (lhorizontalc > 0f )
            {
				var movdirect = transform.TransformDirection(new Vector3 (-lhorizontalc,0, 0));
				_rb.MovePosition(transform.position + movdirect * velocidad * Time.deltaTime);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                var movdirect = transform.TransformDirection(new Vector3 (-lhorizontalc,0, 0));
				_rb.MovePosition(transform.position + movdirect * velocidad * Time.deltaTime);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            Vector3 movdire = _rb.linearVelocity;
            movdire.y = 0;
            float distaxe = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distaxe,QueryTriggerInteraction.Ignore))
            {
                _rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
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
			this.tiempogiro2 += Time.deltaTime;
		}
		if (manager.juego == 4)
		{


			if(lt == 0 || ascensor == true)
            {

				anim.SetBool("movlat",false);
				anim.SetBool("latizq",false);
                anim.SetBool("latder",false);
                anim.SetBool("saltoatras",false);
				if(subir == false && bajar == false)
				{
					anim.SetFloat("velx",lhorizontalc);
					anim.SetFloat("vely",lverticalc);
					if(lhorizontalc != 0 || lverticalc != 0)
					{
						var movdirect = transform.TransformDirection(new Vector3 (lhorizontalc,0, lverticalc));
						_rb.MovePosition(transform.position + movdirect * velocidad * Time.deltaTime);
						float angulomod =  Mathf.Atan2(lhorizontalc,lverticalc)* Mathf.Rad2Deg;
						mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,angulomod,0),5* Time.deltaTime);
					}

					Vector3 movdire = _rb.linearVelocity;
					movdire.y = 0;
					float distaxe = movdire.magnitude * Time.fixedDeltaTime;
					movdire.Normalize();
					RaycastHit hit;

					if(lverticalc == 0f && lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distaxe,QueryTriggerInteraction.Ignore))
					{
						_rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
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

				if(rhorizontalc != 0)
				{rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;}
				else{rotationinput.x = 0;}

				if(rverticalc != 0)
				{rotationinput.y = rverticalc * rotspeed * Time.deltaTime;}
				else{rotationinput.y = 0;}

				camara.transform.Rotate(Vector3.up * rotationinput.x);

				if(camara.transform.eulerAngles.x <= 30 || camara.transform.eulerAngles.x >= 340)
				{
					camara.transform.Rotate(Vector3.right * -rotationinput.y);
				}
				if(camara.transform.eulerAngles.x > 30 && camara.transform.eulerAngles.x < 100)
				{
					camara.transform.eulerAngles = new Vector3(30,camara.transform.eulerAngles.y,camara.transform.eulerAngles.z);
				}
				if(camara.transform.eulerAngles.x < 340 && camara.transform.eulerAngles.x > 100)
				{
					camara.transform.eulerAngles = new Vector3(340,camara.transform.eulerAngles.y,camara.transform.eulerAngles.z);
				}

				camara.transform.localRotation = Quaternion.RotateTowards(camara.transform.localRotation,Quaternion.Euler(camara.transform.eulerAngles.x,camara.transform.eulerAngles.y,0),180 * Time.deltaTime);
				//camara.transform.localRotation = Quaternion.Lerp(camara.transform.localRotation,Quaternion.Euler(-cameraverticalangle,,0),2.5f* Time.deltaTime);
				//camara.transform.localRotation = Quaternion.RotateTowards(camara.transform.localRotation,Quaternion.Euler(-cameraverticalangle,cameraverticalangle2,0),180 * Time.deltaTime);



				if (lhorizontalc != 0f && rhorizontalc != 0f|| lverticalc != 0 && rhorizontalc != 0f)
				{
					transform.localRotation = Quaternion.Slerp(transform.localRotation,Quaternion.Euler(0,camara.transform.eulerAngles.y,0),2.5f* Time.deltaTime);
				}
				else if (lhorizontalc != 0f || lverticalc != 0)
				{
					transform.localRotation = Quaternion.Slerp(transform.localRotation,Quaternion.Euler(0,camara.transform.eulerAngles.y,0),2.5f* Time.deltaTime);
				}

				camara.transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
				

			}
			else if(lt > 0 && ascensor == false)
            {

				anim.SetBool("movlat",true);
                camnomov = false;
				anim.SetFloat("velx",lhorizontalc);
				anim.SetFloat("vely",lverticalc);
				if(subir == false && bajar == false)
				{

					if(lhorizontalc != 0 && tempdash < dash|| lhorizontalc != 0 && tempdash2 < dash2 || lverticalc != 0 && tempdash < dash || lverticalc != 0 && tempdash2 < dash2)
					{
						_rb.MovePosition(transform.position + transform.TransformDirection(new Vector3 (lhorizontalc,0, lverticalc)) * velocidad * Time.deltaTime);
						float angulomod =  Mathf.Atan2(lhorizontalc,lverticalc)* Mathf.Rad2Deg;
						mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,angulomod,0),25* Time.deltaTime);
					}
					else if(lhorizontalc != 0|| lverticalc != 0)
					{
						_rb.MovePosition(transform.position + transform.TransformDirection(new Vector3 (lhorizontalc,0, lverticalc)) * velocidad * Time.deltaTime);
						mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
					}
					


					transform.localRotation = Quaternion.Lerp(transform.localRotation,Quaternion.Euler(0,camara.transform.eulerAngles.y,0),30f* Time.deltaTime);


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
                Vector3 movdire = _rb.linearVelocity;
                movdire.y = 0;
                float distance = movdire.magnitude * Time.fixedDeltaTime;
                movdire.Normalize();
                RaycastHit hit;
                camara.transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
                if(lverticalc == 0f && lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
                {
                    _rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
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

                if(rhorizontalc != 0)
                {rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;}
                else{rotationinput.x = 0;}

                if(rverticalc != 0)
                {rotationinput.y = rverticalc * rotspeed * Time.deltaTime;}
                else{rotationinput.y = 0;}

                cameraverticalangle =  rotationinput.y;
                cameraverticalangle = Mathf.Clamp(cameraverticalangle, -20 , 20);
                
                camara.transform.Rotate(Vector3.up * rotationinput.x);
                //camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(-cameraverticalangle,camara.transform.eulerAngles.y,0),2.5f* Time.deltaTime);

                camara.transform.localRotation = Quaternion.RotateTowards(camara.transform.localRotation,Quaternion.Euler(cameraverticalangle,camara.transform.eulerAngles.y,0),180 * Time.deltaTime);
                //transform.localRotation = Quaternion.RotateTowards(transform.localRotation,Quaternion.Euler(transform.eulerAngles.x,camara.transform.eulerAngles.y,0),180 * Time.deltaTime);
                //transform.localRotation = camara.transform.localRotation;
                cameraverticalangle2 =  0;

                
                camara.transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
				
                
            }
            
		}
		if (manager.juego == 0 && subir == false && bajar == false )
		{
			anim.SetFloat("velx",lhorizontalc);
        	anim.SetFloat("vely",lverticalc);
			if(tiempoascensor > 1.7f)
			{
				
				if (lhorizontalc > 0f )
				{
					_rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
				}
				if (lhorizontalc < 0f)
				{
					_rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
				}
				if (lverticalc > 0f)
				{
					_rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
				}
				if (lverticalc < 0f )
				{
					_rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
				}
				if(lverticalc == 0f && lhorizontalc == 0f )
				{
					_rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
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
			if(tiempoascensor > 1.7f)
			{
			rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;

            cameraverticalangle +=  rotationinput.y/3;
            cameraverticalangle = Mathf.Clamp(cameraverticalangle, -20 , 20);

			cameraverticalangle2 +=  rotationinput.x;

            camara.transform.localRotation = Quaternion.Euler(-cameraverticalangle,cameraverticalangle2,0);
			if (lhorizontalc != 0f && rhorizontalc != 0f|| lverticalc != 0 && rhorizontalc != 0f)
			{
				transform.localRotation = Quaternion.Slerp(transform.localRotation,Quaternion.Euler(0,camara.transform.eulerAngles.y,0),2.5f* Time.deltaTime);
			}
			else if (lhorizontalc != 0f || lverticalc != 0)
			{
				transform.localRotation = Quaternion.Slerp(transform.localRotation,Quaternion.Euler(0,camara.transform.eulerAngles.y,0),90f* Time.deltaTime);
			}
				
			camara.transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
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
			if (this.tiemposalto <= 0f && a > 0f && dialogueact == false)
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
		}
		if (manager.juego == 0)
		{
			this.tiemposalto -= Time.deltaTime;
			if (this.tiemposalto <= 0f && a > 0f && dialogueact == false )
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
		}
		if (manager.juego == 4)
		{
			this.tiemposalto -= Time.deltaTime;
			if (this.tiemposalto <= 0f && a > 0f && dialogueact == false )
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
		}
		if(manager.juego == 3 || manager.juego == 4)
		{
			if(rt > 0)
			{
				anim.SetBool("arma3",true);
			}
			else
			{
				anim.SetBool("arma3",false);
			}

			if(x > 0 && suelo == true)
			{
				anim.SetBool("atk",true);
			}
			else
			{
				anim.SetBool("atk",false);
			}

			if(x > 0 && suelo == false)
			{
				anim.SetBool("atks",true);
				this._rb.AddForce(this.jumpforce * 5f * -Vector3.up);
			}
			else
			{
				anim.SetBool("atks",false);
			}
			if(manager.juego == 4)
			{
				if(b > 0 && tempdash > dash && suelo == false && dashaeract == false)
				{
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("dash",true);
					anim.SetBool("salto",false);

					this._rb.AddRelativeForce(2000f * new Vector3 (lhorizontalc,0,lverticalc) ,ForceMode.Force ) ;
					tempdash = 0;
					dashaeract = true;
				}
				else if(b > 0 && tempdash2 > dash2 && suelo == true)
				{
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("rueda",true);
					anim.SetBool("salto",false);
					this._rb.AddRelativeForce(1500f * new Vector3 (lhorizontalc,0,lverticalc),ForceMode.Force   );
					tempdash2 = 0;
				}
				if(tempdash > dash && tempdash2 > dash2)
				{
					_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
				}
			}
			if(manager.juego == 3)
			{
				if(b > 0 && tempdash > dash && suelo == false && dashaeract == false)
				{
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("dash",true);
					anim.SetBool("salto",false);

					this._rb.AddRelativeForce(2000f * new Vector3 (-lhorizontalc,0,0) ,ForceMode.Force ) ;
					tempdash = 0;
					dashaeract = true;
				}
				else if(b > 0 && tempdash2 > dash2 && suelo == true)
				{
					anim.SetBool("saltoatras",false);
					anim.SetBool("latder",false);
					anim.SetBool("latizq",false);
					anim.SetBool("rueda",true);
					anim.SetBool("salto",false);
					this._rb.AddRelativeForce(1500f * new Vector3 (-lhorizontalc,0,0),ForceMode.Force   );
					tempdash2 = 0;
				}
				if(tempdash > dash && tempdash2 > dash2)
				{
					_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
				}
			}
		}
		if(manager.juego == 0|| manager.juego == 3 || manager.juego == 4)
		{
			if(controles.al1.rb.ReadValue<float>() > 0 && velact != true)
			{
				velocidad = 20;
			}
			else if (velact != true){velocidad = velocidadaux;}
		}
		if(temp9 < 15)
        {temp9 += 1 * Time.deltaTime;}
		if(tempgir > 0)
        {tempgir -= 1 * Time.deltaTime;}
		if(tiempodisp < 15)
        {tiempodisp += 1 * Time.deltaTime;}
		if(tempdash< 15)
        {tempdash += 1 * Time.deltaTime;}
		if(tempdash2< 15)
        {tempdash2 += 1 * Time.deltaTime;}

		if(manager.juego == 0 || manager.juego == 3 || manager.juego == 4 )
		{
			if(tempdash > dash)
			{anim.SetBool("dash",false);}

			if(tempdash2 > 0.1f)
			{anim.SetBool("rueda",false);}
		}
		if(tempgir > 0 && manager.juego == 6)
		{
			this.transform.rotation = Quaternion.RotateTowards(transform.rotation, fij,  90 * Time.deltaTime);
		}
		if(tiempodialogue < 15)
        {tiempodialogue += 1 * Time.deltaTime;}
		
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
		if (a > 0f && dialogueact == false){
		this._rb.AddForce(this.jumpforce * 0.2f * Vector3.up);}
		audio1 = manager.GetComponent<AudioSource>();
		audio1.Play();
	}
    public void saltoalto2()
	{
		if (a > 0f && dialogueact == false){
		this._rb.AddForce(this.jumpforce * 1f * Vector3.up);}
		audio1.Play();
	}
	public void saltoalto3()
	{
		if (a > 0f && dialogueact == false){
		this._rb.AddForce(this.jumpforce * 3f * Vector3.up);}
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
			if(tiempovelint > 2)
			{suelo = true;}
			anim.SetBool("salto",false);
			dashaeract = false;

		
		}
		if (col.gameObject.tag == "enemigo" || col.gameObject.tag == "respawn")
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
			juego.SetActive(false);
		}
		if (col.gameObject.tag == "enemigo")
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
			
			
		}
		if (col.gameObject.tag == "ascensor" && manager.juego == 4)
		{
			tut10.SetActive(true);
			this.ascensor = true;
		}
		if (col.gameObject.tag == "suelo")
		{
			if(tiempovelint > 2)
			{suelo = true;}
		
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
			suelo = false;
			anim.SetBool("salto",true);
		}
		if (col.gameObject.tag == "suelo"  && velact != true || col.gameObject.tag == "ascensor" && velact != true)
		{
			velocidad = velocidadaux;
		}
	
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "pisar")
		{
			GameObject explosiont = Instantiate(explosion, col.transform.position,col.transform.rotation) as GameObject;
			manager.datosserial.asesinatos++;
			muertes.Play();
			manager.guardar();
            Destroy(explosiont, 1f);
            Destroy(col.transform.parent.gameObject);
		}
		if (col.gameObject.tag == "npc")
		{
			npcbase = col.GetComponent<npc_tienda1_al1>();
	    	menushow.SetBool("show",true);
			dialogueact = false;
			if(manager.datosconfig.idioma == "es")
			{
				this.textnpc.text = npcbase.es_frase;
				LocalizationManager.Instance.selectedLang =  SystemLanguage.Spanish;
			}
			if(manager.datosconfig.idioma == "en")
			{
				this.textnpc.text = npcbase.en_frase;
				LocalizationManager.Instance.selectedLang =  SystemLanguage.English;
			}
			if(manager.datosconfig.idioma == "cat")
			{
				this.textnpc.text = npcbase.cat_frase;
				LocalizationManager.Instance.selectedLang =  SystemLanguage.Catalan;
			}
		}

	}
	private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "npc")
		{
			menushow.SetBool("show",false);
			if(menuoff != null)
			{
			menuoff.MainUI.gameObject.SetActive(false);
			}
			dialogueact = false;
		}
	}
	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "npc")
		{
			if (controles.al1.y.ReadValue<float>() > 0f && dialogueact == false && tiempodialogue > 0.7f)
			{
				menushow.SetBool("show",false);
				if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
				{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
				menuoff.StartDialogue(npcbase.DialogueSO,npcbase.dialogueid);
				dialogueact = true;
				tiempodialogue = 0;
				
			}
			else if (controles.al1.a.ReadValue<float>() > 0f && tiempodialogue > 0.3f && menuoff != null)
			{
				if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == true)
				{
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
	}
	

	// Token: 0x0400000C RID: 12
	public float velocidad = 4;

	// Token: 0x0400000D RID: 13
	public float velocidadjet = 2;

	// Token: 0x0400000E RID: 14
	public float velocidadr = 20f;

	// Token: 0x0400000F RID: 15
	private Rigidbody _rb;

	// Token: 0x04000010 RID: 16
	public float jumpforce = 300f;

	// Token: 0x04000011 RID: 17
	public float jumpforce2 = 150f;

	public float jumpforcebase = 0f;

	// Token: 0x04000012 RID: 18
	public float tiemposalto;

	// Token: 0x04000013 RID: 19
	public float tiempovel;

	// Token: 0x04000014 RID: 20
	public int tiempovelint;

	// Token: 0x04000015 RID: 21
	public float velocidadmaxima = 20;

	// Token: 0x04000016 RID: 22
	public float velocidadaux;

	// Token: 0x04000017 RID: 23
	public Quaternion rotacion1 = Quaternion.Euler(new Vector3(0f, 0f, 0f));

	// Token: 0x04000018 RID: 24
	public Vector3 punto;

	// Token: 0x04000019 RID: 25
	public GameObject giro;

	// Token: 0x0400001A RID: 26
	public bool dimensiion;

	// Token: 0x0400001B RID: 27
	public float tiempogiro;

	// Token: 0x0400001C RID: 28
	public float tiempogiro2;

	// Token: 0x0400001D RID: 29
	public bool ascensor = true;

	// Token: 0x0400001E RID: 30
	public Text ascensortut;

	// Token: 0x0400001F RID: 31
	public Text ascensortut2;


	// Token: 0x04000020 RID: 32
	public bool dentrotienda;
}
