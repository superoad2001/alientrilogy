using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x0200000A RID: 10
public class jugador_al1 : MonoBehaviour
{
	public AudioSource audio1;
	public float temppaso = 1;
	public float rotspeed = 3;

	public Quaternion fij;
	public GameObject camara;
	private float cameraverticalangle;
	public Vector3 rotationinput;
	public float speed = 3;
	public bool suelo;
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
	public float jumpc;
	public float mc;
	public float nc;
	public GameObject tactil;
	public Animator anim;
	public AudioSource pasosnave;
	public AudioSource pasos1;
	public AudioSource pasos2;
	public int randompaso;
	public float pausac;
	public float pasotiempo;
	public float tempgir = 0;
	
	private Controles controles;
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
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
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
		this.velocidadaux = this.velocidad;
		girovalor = base.transform.eulerAngles.y;
		jumpforcebase = jumpforce;
		
		
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
	// Token: 0x0600001E RID: 30 RVA: 0x00002604 File Offset: 0x00000804
	public void A()
	{
		jumpc = 1;
	}
	public void pausacact()
	{
		pausac = 1;
	}
	public void B()
	{
		mc = 1;
	}
	public void X()
	{
		nc = 1;
	}
	public void detA()
	{
		jumpc = 0;
	}
	public void detB()
	{
		mc = 0;
	}
	public void detpausac()
	{
		pausac = 0;
	}
	public void detX()
	{
		nc = 0;
	}
	
	private void Update()
	{
	tiempoascensor += Time.deltaTime;
	manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();

	lhorizontalc = controles.al1.lhorizontal.ReadValue<float>();
    lverticalc = controles.al1.lvertical.ReadValue<float>();

	rhorizontalc = controles.al1.rhorizontal.ReadValue<float>();
	rverticalc = controles.al1.rvertical.ReadValue<float>();
	jumpc = controles.al1.a.ReadValue<float>();
	mc = controles.al1.b.ReadValue<float>();
	nc = controles.al1.x.ReadValue<float>();
	pausac = controles.al1.pausa.ReadValue<float>();




		if (this.ascensor && manager.juego == 0 && manager.piso == 1)
		{
			if (mc > 0f && manager.datosserial.tengovel == 1 && bajar1 == false && bajar1esp == false )
			{
				subir1 = true;
				subir = true;
				tiempoascensor = 0;
				
				
			}
			if (nc > 0f && manager.datosserial.tengonave == 1 && manager.datosserial.cinematicaf == 1 && subir1 == false)
			{
				bajar1esp = true;
				bajar = true;
				tiempoascensor = 0;
			}
			else if (nc > 0f && manager.datosserial.gemas >= 1 && subir1 == false )
			{
				bajar1 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajar1 == true){this.tiempoascensor += Time.deltaTime; subir1 = false; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subir1 == true){this.tiempoascensor += Time.deltaTime; bajar1 = false; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}
			if (bajar1esp == true){this.tiempoascensor += Time.deltaTime; subir1 = false; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			
			
			
		}
		if (this.ascensor && manager.juego == 4 && manager.piso == 10 && mc > 0f)
		{
			subir0 = true;
			subir = true;
			tiempoascensor = 0;
		}
		
		if (subir0 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}
		if (this.ascensor && manager.juego == 0 && manager.piso == 2)
		{
			if (mc > 0f && manager.datosserial.tengocoche == 1 && bajar2 == false)
			{
				subir2 = true;
				subir = true;
				tiempoascensor = 0;
				
			}
			if (nc > 0f && subir2 == false)
			{
				bajar2 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajar2 == true){this.tiempoascensor += Time.deltaTime; subir2 = false; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subir2 == true){this.tiempoascensor += Time.deltaTime; bajar2 = false; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}
			
		}
		if (this.ascensor && manager.juego == 0 && manager.piso == 3)
		{
			if (mc > 0f && manager.datosserial.tengosalto == 1 && bajar3 == false )
			{
				subir3 = true;
				subir = true;
				tiempoascensor = 0;
			}
			if (nc > 0f && subir3 == false )
			{
				bajar3 = true;
				bajar = true;
				tiempoascensor = 0;
			}
			if (bajar3 == true){this.tiempoascensor += Time.deltaTime; subir3 = false; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subir3 == true){this.tiempoascensor += Time.deltaTime; bajar3 = false; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}
			
		}
		if (this.ascensor && manager.juego == 0 && manager.piso == 5 && nc > 0f && subir5 == false)
		{
				bajar5 = true;
				bajar = true;
				tiempoascensor = 0;
		}
				if (this.ascensor && manager.juego == 0 && manager.piso == 5 && mc > 0f && bajar5 == false)
		{
				subir5 = true;
				subir = true;
				tiempoascensor = 0;
		}

		if (bajar5 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}

		if (subir5 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * 5f * Time.deltaTime);}
		if (this.ascensor && manager.juego == 0 && manager.piso == 4)
		{
			if (mc > 0f && manager.datosserial.fragmento == 3 && manager.datosserial.tengollave4 == 1 && bajar4 == false)
			{
				subir4 = true;
				subir = true;
				tiempoascensor = 0;
				
			}
			if (nc > 0f && subir4 == false ) 
			{
				bajar4 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajar4 == true){this.tiempoascensor += Time.deltaTime; subir4 = false; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subir4 == true){this.tiempoascensor += Time.deltaTime; bajar4 = false; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}
			
		}
			if (this.ascensor && manager.juego == 0 && manager.piso == -1)
		{
			if (mc > 0f && bajart1 == false )
			{
				subirt1 = true;
				subir = true;
				tiempoascensor = 0;
				
			}
			if (nc > 0f && subirt1 == false) 
			{
				bajart1 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajart1 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subirt1 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}
			
		}
			if (this.ascensor && manager.juego == 0 && manager.piso == -2)
		{
			if (mc > 0f && bajart2 == false)
			{
				subirt2= true;
				subir = true;
				tiempoascensor = 0;
				
			}
			if (nc > 0f && subirt2 == false) 
			{
				bajart2 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajart2 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subirt2 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}

		}
			if (this.ascensor && manager.juego == 0 && manager.piso == -3)
		{
			if (mc > 0f && bajart3 == false)
			{
				subirt3 = true;
				subir = true;
				tiempoascensor = 0;
				
			}
			if (nc > 0f && subirt3 == false ) 
			{
				bajart3 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajart3 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subirt3 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}

		}
		if (this.ascensor && manager.juego == 0 && manager.piso == -4)
		{
			anim.SetFloat("velx",lhorizontalc);
        anim.SetFloat("vely",lverticalc);
			if (mc > 0f && bajart4 == false )
			{
				subirt4 = true;
				subir = true;
				tiempoascensor = 0;
				
			}
			if (nc > 0f && subirt4 == false ) 
			{
				bajart4 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajart4 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
			if (subirt4 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * 4f * Time.deltaTime);}

		}
			if (this.ascensor && manager.juego == -1 && manager.piso == -5)
		{
			if (nc > 0f ) 
			{
				bajart5 = true;
				bajar = true;
				tiempoascensor = 0;
				
			}
			if (bajart5 == true){this.tiempoascensor += Time.deltaTime; base.transform.Translate(Vector3.up * -4f * Time.deltaTime);}
		}
		if (manager.juego == 1)
		{
			base.transform.rotation = this.rotacion1;
		}
		if (this.tiempovelint > 1 && suelo == false)
		{
			velocidad = velocidadaux;
		}
		if (this.tiempovelint > 2 && suelo == true)
		{
			velocidad = 7;
		}
		this.tiempovel += Time.deltaTime;
		this.tiempovelint = (int)this.tiempovel;
			if(subir1 == true && tiempoascensor > 3){SceneManager.LoadScene("piso2_al1");}
			if(bajar1esp == true && tiempoascensor > 3)
			{
				manager.datosserial.cinematicaf = 0;
				manager.guardar();
				SceneManager.LoadScene("cinematicafinal_al1");
			}
		if(bajar1 == true && tiempoascensor > 3){SceneManager.LoadScene("mundo_al1");}
		if(subir0 == true && tiempoascensor > 3){SceneManager.LoadScene("piso1_al1");}
		if(subir2 == true && tiempoascensor > 3){SceneManager.LoadScene("piso3_al1");}
		if(bajar2 == true && tiempoascensor > 3){SceneManager.LoadScene("piso1_al1");}
		if(subir3 == true && tiempoascensor > 3){SceneManager.LoadScene("piso4_al1");}
		if(bajar3 == true && tiempoascensor > 3){SceneManager.LoadScene("piso2_al1");}
		if(bajar5 == true && tiempoascensor > 3){SceneManager.LoadScene("piso4_al1");}
		if(subir5 == true && tiempoascensor > 7){SceneManager.LoadScene("piso1t_al1");}
		if(subir4 == true && tiempoascensor > 3){SceneManager.LoadScene("piso5_al1");}
		if(bajar4 == true && tiempoascensor > 3){SceneManager.LoadScene("piso3_al1");}
		if(subirt1 == true && tiempoascensor > 3){SceneManager.LoadScene("piso2t_al1");}
		if(bajart1 == true && tiempoascensor > 3){SceneManager.LoadScene("piso5_al1");}
		if(subirt2 == true && tiempoascensor > 3){SceneManager.LoadScene("piso3t_al1");}
		if(bajart2 == true && tiempoascensor > 3){SceneManager.LoadScene("piso1t_al1");}
		if(subirt3 == true && tiempoascensor > 3){SceneManager.LoadScene("piso4t_al1");}
		if(bajart3 == true && tiempoascensor > 3){SceneManager.LoadScene("piso2t_al1");}
		if(subirt4 == true && tiempoascensor > 3){SceneManager.LoadScene("piso5t_al1");}
		if(bajart4 == true && tiempoascensor > 3){SceneManager.LoadScene("piso3t_al1");}
		if(bajart5 == true && tiempoascensor > 3){SceneManager.LoadScene("piso4t_al1");}


		if (pausac > 0 && temp9 > 0.7f)
		{
			manager.pauseact = true;
			pausa1.SetActive(true);
			pausac = 0;
			temp9 = 0;
			juego.SetActive(false);
			Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
		}





		if (manager.juego == 2)
		{
			if (lhorizontalc > 0f )
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidadjet, lverticalc * velocidadjet,1 * velocidad));
            }
            if (lhorizontalc < 0f)
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidadjet, lverticalc * velocidadjet,1 * velocidad));
            }
            if (lverticalc > 0f)
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidadjet, lverticalc * velocidadjet,1 * velocidad));
            }
            if (lverticalc < 0f )
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidadjet, lverticalc * velocidadjet,1 * velocidad));
            }
			if(lverticalc == 0f && lhorizontalc == 0f)
            {
                _rb.velocity = new Vector3 (0, 0, 1 * velocidad);
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
				base.transform.Rotate(Vector3.right, Time.deltaTime * 50f);
			}
			if (lverticalc < 0f )
			{
				base.transform.Rotate(Vector3.left, Time.deltaTime * 50f);
			}
			if (jumpc > 0f )
			{
				pasosnave.UnPause();
				_rb.velocity = transform.TransformDirection(new Vector3 (0,0,1 * velocidad));
			}
			else
			{
				pasosnave.Pause();
				_rb.velocity = transform.TransformDirection(new Vector3 (0,0,0));
			}

			rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;
            
            transform.Rotate(Vector3.up * rotationinput.x);
			transform.Rotate(Vector3.left * rotationinput.y);
		}
		if (manager.juego == 1)
		{
			if (jumpc > 0f )
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (0,_rb.velocity.y,1 * velocidad));
				pasosnave.UnPause();
			}
			else if (mc > 0f )
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (0,_rb.velocity.y,-1 * velocidad));
				pasosnave.UnPause();
			}
			else{pasosnave.Pause();}
			if (lhorizontalc > 0f )
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (1 * velocidad,_rb.velocity.y,_rb.velocity.z));
			}
			if (lhorizontalc < 0f)
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (-1 * velocidad,_rb.velocity.y,_rb.velocity.z));
			}
		}
		if (manager.juego == 3 && mc > 0f )
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
                _rb.velocity = transform.TransformDirection(new Vector3 (-1 * velocidad, _rb.velocity.y, 0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (1 * velocidad, _rb.velocity.y, 0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            Vector3 movdire = _rb.velocity;
            movdire.y = 0;
            float distance = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
            {
                _rb.velocity = new Vector3 (0, _rb.velocity.y, 0);
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
                _rb.velocity = transform.TransformDirection(new Vector3 (-1 * velocidad, _rb.velocity.y,0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (1 * velocidad, _rb.velocity.y, 0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            Vector3 movdire = _rb.velocity;
            movdire.y = 0;
            float distance = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
            {
                _rb.velocity = new Vector3 (0, _rb.velocity.y, 0);
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
			
			if(subir == false && bajar == false)
			{
				anim.SetFloat("velx",lhorizontalc);
        		anim.SetFloat("vely",lverticalc);
				if (lhorizontalc > 0f )
				{
					_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
				}
				if (lhorizontalc < 0f)
				{
					_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
				}
				if (lverticalc > 0f)
				{
					_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
				}
				if (lverticalc < 0f )
				{
					_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
					mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
				}
				Vector3 movdire = _rb.velocity;
                movdire.y = 0;
                float distance = movdire.magnitude * Time.fixedDeltaTime;
                movdire.Normalize();
                RaycastHit hit;
                if(lverticalc == 0f && lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
                {
                    _rb.velocity = new Vector3 (0, _rb.velocity.y, 0);
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

			rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;

            cameraverticalangle +=  rotationinput.y;
            cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
            
            transform.Rotate(Vector3.up * rotationinput.x);
            camara.transform.localRotation = Quaternion.Euler(-cameraverticalangle,transform.eulerAngles.y,0);

            camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,7 * Time.deltaTime);
		}
		if (manager.juego == 0 && subir == false && bajar == false )
		{
			anim.SetFloat("velx",lhorizontalc);
        	anim.SetFloat("vely",lverticalc);
			if (lhorizontalc > 0f )
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
				mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			if (lhorizontalc < 0f)
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
				mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			if (lverticalc > 0f)
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
				mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
			}
			if (lverticalc < 0f )
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
				mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
			}
			if(lverticalc == 0f && lhorizontalc == 0f )
			{
				_rb.velocity = new Vector3 (0, _rb.velocity.y, 0);
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
		if (manager.juego == 0 )
		{
			rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;

            cameraverticalangle +=  rotationinput.y;
            cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
            
            transform.Rotate(Vector3.up * rotationinput.x);
            camara.transform.localRotation = Quaternion.Euler(-cameraverticalangle,transform.eulerAngles.y,0);
            camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,7 * Time.deltaTime);
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
			if (this.tiemposalto <= 0f && jumpc > 0f )
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
			if (this.tiemposalto <= 0f && jumpc > 0f )
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
			if (this.tiemposalto <= 0f && jumpc > 0f )
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0.9f;
					jumpforce = jumpforce / 1.8f;
					anim.SetBool("salto",true);
			}
		}
		if(temp9 < 15)
        {temp9 += 1 * Time.deltaTime;}
		if(tempgir > 0)
        {tempgir -= 1 * Time.deltaTime;}
		if(tempgir > 0 && manager.juego == 6)
		{
			this.transform.rotation = Quaternion.RotateTowards(transform.rotation, fij,  90 * Time.deltaTime);
		}
		
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
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (jumpc > 0f ){
		this._rb.AddForce(this.jumpforce * 0.2f * Vector3.up);}
		audio1 = manager.GetComponent<AudioSource>();
		audio1.Play();
	}
    public void saltoalto2()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (jumpc > 0f){
		this._rb.AddForce(this.jumpforce * 1f * Vector3.up);}
		audio1.Play();
	}
	public void saltoalto3()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (jumpc > 0f){
		this._rb.AddForce(this.jumpforce * 3f * Vector3.up);}
		audio1.Play();
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000318C File Offset: 0x0000138C
	public void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (manager.juego == 6)
		{
			tempgir = 3;
			fij = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y + 180f,transform.rotation.eulerAngles.z);
			
		}
		if (col.gameObject.tag == "suelo" || col.gameObject.tag == "ascensor")
		{
			jumpforce = jumpforcebase;
			if(tiempovelint > 2)
			{suelo = true;}
			anim.SetBool("salto",false);

		
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000031C0 File Offset: 0x000013C0
	private void OnCollisionStay(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "ascensor" && manager.juego == 0)
		{
			/*if(manager.datosconfig.idioma == "es")
			{
				if (!this.dentrotienda)
				{
					this.ascensortut.text = "(click derecho) o (b) para subir de planta  (click izquierdo) o (x) para bajar de planta";
				}
					if (manager.piso == 5)
				{
					this.ascensortut.text = "(click derecho) o (b) para ir a la torre del tiempo (click izquierdo) o (x) para bajar de planta";
				}
			}
			if(manager.datosconfig.idioma == "en")
			{
				if (!this.dentrotienda)
				{
					this.ascensortut.text = "(right click) or (b) to go up the floor  (left click) or (x) to go downstairs";
				}
					if (manager.piso == 5)
				{
					this.ascensortut.text = "(right click) or (b) to go to the tower of time (left click) or (x) to go downstairs";
				}
			}
			if(manager.datosconfig.idioma == "cat")
			{
				if (!this.dentrotienda)
				{
					this.ascensortut.text = "(click dret) o (b) per pujar de planta  (click esquerre) o (x) para baixar de planta";
				}
					if (manager.piso == 5)
				{
					this.ascensortut.text = "(click dret) o (b) per anar a la torre del temps  (click esquerre) o (x) para baixar de planta";
				}
			}*/
			this.ascensor = true;
			
			
		}
		if (col.gameObject.tag == "ascensor" && manager.juego == 4)
		{
			if(manager.datosconfig.idioma == "es")
			{this.ascensortut.text = "(click derecho) o (b) para subir de planta  ";}
			if(manager.datosconfig.idioma == "en")
			{this.ascensortut.text = "(right click) o (b) to go up the floor ";}
			if(manager.datosconfig.idioma == "cat")
			{this.ascensortut.text = "(click dret) o (b) per pujar de planta  ";}
			this.ascensor = true;
		}
		if (col.gameObject.tag == "suelo")
		{
			if(tiempovelint > 2)
			{suelo = true;}
		
		}
		if (col.gameObject.tag == "suelo" || col.gameObject.tag == "ascensor")
			{
				anim.SetBool("salto",false);
			}
	}


	// Token: 0x06000023 RID: 35 RVA: 0x00003284 File Offset: 0x00001484
	private void OnCollisionExit(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "ascensor" && manager.juego == 4)
		{
			if (!this.dentrotienda)
			{
				this.ascensortut.text = " ";
			}
			this.ascensor = false;
			anim.SetBool("salto",true);

		}
		if (col.gameObject.tag == "ascensor" && manager.juego == 0)
		{
			if (!this.dentrotienda)
			{
				this.ascensortut.text = " ";
			}
			this.ascensor = false;
			anim.SetBool("salto",true);
		}
		if (col.gameObject.tag == "suelo")
		{
			suelo = false;
			anim.SetBool("salto",true);
		}
	
	}

	// Token: 0x0400000C RID: 12
	public int velocidad = 4;

	// Token: 0x0400000D RID: 13
	public int velocidadjet = 2;

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
	public int velocidadmaxima = 20;

	// Token: 0x04000016 RID: 22
	public int velocidadaux;

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
