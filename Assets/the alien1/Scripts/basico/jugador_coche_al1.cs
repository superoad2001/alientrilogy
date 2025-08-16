using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;

// Token: 0x0200000A RID: 10
public class jugador_coche_al1 : jugador_al1
{
	[Header("Propio coche")]
	
	public controlcoche_al1 ControlCarrera;
	public float staminaobj;
	private int cocheturbo;
	private float derrape;

	private float movXc;
	private float movYc;
	private float UIXc;
	private float UIYc;	
	private float turboc;
	private float aceleracionc;
	private float habilidadc;
	private float aceleracion_atrasc;
	private float menu1c;
	private float menu2c;
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
		
		

		if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

		camarascript = (camara_al1)FindFirstObjectByType(typeof(camara_al1));
		



			velocidad = 30;
			stamina = 0;
			barravel.fillAmount = 0;
			staminabarra.fillAmount = 0;
			derrapebarra.fillAmount = 0;
			derrapeobj = derrape;
			velobj = velocidad;
			staminaobj = stamina;
			turboact = false;
			pasosnave.Pause();
			turboson.Pause();
			derrapeson.Pause(); 

		


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
		tiempovelint = 3;
		
		
	}
	public void fixedStart()
	{
		
	}



	public void Update()
	{
		pasosnave.Pause();
		turboson.Pause();
		derrapeson.Pause(); 


		anim.SetBool("act2",true);
	
	if(muerte == true)
	{

		ControlCarrera.muerte[0] = true;
		manager.datosserial.alien1muere = true;
		manager.datosserial.muertes++;
		manager.guardar();
		muerte = false;
		
	}


	if(controlact == true)
	{

		


		if(movact == 0)
		{
			movXc = controles.al1_coche.mov.ReadValue<Vector2>().x;
			movYc = controles.al1_coche.mov.ReadValue<Vector2>().y;		
		}

		

		UIXc = controles.al1_UI.UIX.ReadValue<float>();
		UIYc = controles.al1_UI.UIY.ReadValue<float>();	
		turboc = controles.al1_coche.turbo.ReadValue<float>();	
		aceleracionc = controles.al1_coche.aceleracion.ReadValue<float>();
		aceleracion_atrasc = controles.al1_coche.aceleracion_atras.ReadValue<float>();
		habilidadc = controles.al1_coche.habilidad.ReadValue<float>();	

		menu1c = controles.al1_coche.menu1.ReadValue<float>();
		menu2c = controles.al1_coche.menu2.ReadValue<float>();
		

		if (menu1c > 0 && temp10 > 0.7f)
		{
			Time.timeScale = 0;
			manager.pauseact = true;
			pausa1.SetActive(true);
			controlact = false;
			
				anim.SetBool("act2",true);
			

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
		
				anim.SetBool("act2",true);
			
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
		
		

			
			if(derrape >= 100 && cocheturbo < 2)
			{
				cocheturbo++;
				habson.Play();
				derrape = 0;
			}
		
			if(cocheturbo == 1)
			{
				hab1bloc.SetActive(true);
				hab2bloc.SetActive(false);

			}
			else if(cocheturbo == 2)
			{
				hab1bloc.SetActive(true);
				hab2bloc.SetActive(true);
			}
			else
			{
				hab1bloc.SetActive(false);
				hab2bloc.SetActive(false);
			}



			staminaobj = Mathf.Lerp(staminaobj, stamina, Time.deltaTime * 9f);
			velobj = Mathf.Lerp(velobj, velocidad, Time.deltaTime * 9f);
			derrapeobj = Mathf.Lerp(derrapeobj, derrape , Time.deltaTime * 9f);

			if(stamina == 100 && hab3act == false)
			{
				hab3act = true;
				hab3barra.fillAmount = staminaobj/100;
				hab3bloc.SetActive(true);
				hab3text.SetActive(true);
				habson.Play();
			}
			else if(stamina == 100 && hab3act == true)
			{
				hab3barra.fillAmount = staminaobj/100;
				hab3bloc.SetActive(true);
				hab3text.SetActive(true);
			}
			else if(hab3act == true && stamina > 0 && stamina < 100)
			{
				hab3barra.fillAmount = staminaobj/100;
				hab3bloc.SetActive(true);
				hab3text.SetActive(false);
			}
			else if(hab3act == true && stamina == 0)
			{
				hab3bloc.SetActive(false);
				hab3text.SetActive(false);
				hab3act = false;

			}
			else if(hab3act == false && stamina == 0)
			{
				hab3barra.fillAmount = 0;
				hab3bloc.SetActive(false);
				hab3text.SetActive(false);
			}

			
			barravel.fillAmount = (velobj-30f)/20;
			staminabarra.fillAmount = staminaobj/100;
			derrapebarra.fillAmount = derrapeobj/100;
			camarascript.maxdis = 16;
			if (turboc > 0 && turboact == false && cocheturbo > 0)
			{
				cocheturbo--;
				turboact = true;
				turbotemp = 0;
			}

			
			if(turboact == true)
			{
				velocidad = 75;
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,velocidad));
				turbotemp += 1 * Time.deltaTime;
				velrotacioncoche = 50;
				pasosnave.Pause();
				turboson.UnPause();
				derrapeson.Pause();

				derrapeaum = 10f; 
				derrapeact = false;
				derrapecorto.SetActive(false);
				derrapelargo.SetActive(true);
				derrapeazul.SetActive(false);
				derrape = 0;

				if(turbotemp > 3)
				{
					turboact = false;
					turbotemp = 0;
				}
			}
			else if (aceleracionc > 0f && aceleracion_atrasc > 0f)
			{
				if(derrapeact == false && movXc > 0.2f ||derrapeact == false && movXc < -0.7f)
				{
					derrapedir = movXc;
					derrapeact = true;
				}
				else if(derrapedir > 0 && movXc > 0.7f)
				{
					derrapedir += 0.005f * Time.deltaTime;
					if(derrapedir > 1.05f)
					{
						derrapedir = 1.05f;
					}

				}
				else if(derrapedir < 0 && movXc < -0.7f)
				{
					derrapedir -= 0.005f * Time.deltaTime;
					if(derrapedir > -1.05f)
					{
						derrapedir = -1.05f;
					}

				}


				_rb.linearVelocity = transform.TransformDirection(new Vector3 (aceleracion_atrasc * -derrapedir * derrapeaum,_rb.linearVelocity.y,aceleracionc * velocidad));
				pasosnave.Pause();
				turboson.Pause();
				derrapeson.UnPause();
				velocidad += 2 * Time.deltaTime; 
				velrotacioncoche += 3.5f * Time.deltaTime;
				derrapeaum += 5 * Time.deltaTime;
				if(derrapeaum > 55f)
				{
					derrapeaum = 55f;
				} 
				if(velrotacioncoche > 50)
				{
					velrotacioncoche = 50;
				}
				if(velocidad > 60)
				{
					velocidad = 60;

				}
				derrapecorto.SetActive(false); 
				derrapeazul.SetActive(true);
				derrapelargo.SetActive(false);
				derrape += 22.5f * Time.deltaTime;
				
			}
			else if (aceleracionc > 0f )
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,aceleracionc* velocidad));
				pasosnave.UnPause();
				turboson.Pause();
				derrapeson.Pause();
				velocidad += 2 * Time.deltaTime;
				velrotacioncoche = 50;
				derrapeaum = 10f;
				derrapeact = false; 
				if(velocidad > 50)
				{
					velocidad = 50;

				}
				derrapecorto.SetActive(true);
				float velmech = velocidad -20;
				derrapecorto.transform.localScale = new Vector3(derrapecorto.transform.localScale.x,0.8f + ((velmech/200)*29f),derrapecorto.transform.localScale.z);

				derrapeazul.SetActive(false);
				derrapelargo.SetActive(false);
				derrape = 0;
			}
			else
			{
				velocidad -= 6 * Time.deltaTime;
				pasosnave.Pause();
				turboson.Pause();
				derrapeson.Pause(); 
				if(velocidad < 30)
				{velocidad = 30;}
				velrotacioncoche = 50;
				derrapeaum = 10f; 
				derrapeact = false;
				derrapecorto.SetActive(false);
				derrapeazul.SetActive(false);
				derrapelargo.SetActive(false);
				derrape = 0;

			}

			


			if (aceleracion_atrasc > 0f  && aceleracionc == 0f )
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,-1 * 10));
				pasosnave.UnPause();
				velocidad = 20;
			}
			if(derrapeact == true)
			{
				transform.Rotate(transform.up, ((Time.deltaTime * velrotacioncoche * derrapedir ) + (Time.deltaTime * velrotacioncoche * (movXc/1.4f)) ));
			}
			else
			{
				transform.Rotate(transform.up, Time.deltaTime * velrotacioncoche * movXc);
			}

			

		




				if (stamina < 0)
				{stamina = 0;}
				if(stamina < 100)
				{stamina += 1.5f * Time.deltaTime;}
				else{stamina = 100;}
			

		
		if(temp10 < 15)
		{temp10 += 1 * Time.deltaTime;}



		movXc = 0;
		movYc = 0;


		UIYc = 0;
		UIXc = 0;

		turboc = 0;

		
		aceleracionc = 0;
		aceleracion_atrasc = 0;
		habilidadc = 0;
		
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003149 File Offset: 0x00001349
	public void velozidad()
	{
		this.tiempovel = 0f;
		this.tiempovelint = 0;
		
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003169 File Offset: 0x000013

	// Token: 0x06000021 RID: 33 RVA: 0x0000318C File Offset: 0x0000138C
	public void OnCollisionEnter(Collision col)
	{
		

		if (col.gameObject.tag == "respawn")
		{
			muerte = true;
			
		}


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
	
		if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}

	}
	public void OnTriggerExit(Collider col)
	{

		
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



	




	public RaycastHit hit;

	private bool derrapeact;
	private float derrapedir;



	public AudioSource pasosnave;




	public Image staminabarra;
	public camara_al1 camarascript; 

	
	public Image barravel;
	public Image derrapebarra;
	public GameObject derrapecorto;
	public GameObject derrapelargo;
	public GameObject derrapeazul;
	private float derrapeobj;
	private float velrotacioncoche = 50;
	private float velobj;
	private float derrapeaum;
	public GameObject hab1bloc;
	public GameObject hab2bloc;
	public GameObject hab3bloc;
	private float turbotemp;
	private bool turboact = false;
	public Image hab3barra;
	private bool hab3act;
	public GameObject hab3text;
	public AudioSource derrapeson;
	public AudioSource turboson;
	public AudioSource habson;
	
}
