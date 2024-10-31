using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jugador2_al2 : MonoBehaviour
{
    public bool saltop = true;
    public GameObject respawnm;
    public GameObject juego;
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

	public AudioSource audio1;
    private float cameraverticalangle2;
    public AudioSource audio2;
    public float vida = 3;
    public bool muerte;
    public Text vidas;
    public float vidaaux;
    public bool dimensiion;
    public float rotspeed = 180;
	public GameObject camara;
	private float cameraverticalangle;
	public Vector3 rotationinput;
    public float tiempogiro2;
    public float girovalor;
	private bool girotd_der = false;
	private bool girotd_izq = false;
    public int objeto;
    public float tempdano;
    public bool salto2;
    public AudioSource saltodo;
    public int blanco;
    public float tiempodisp;
    public GameObject balaprefab;
    public float tempboton;
	public float balavel = 20;
    public Animator anim;
    public GameObject mod;

	public AudioSource disp;

    public int velocidad = 4;

	// Token: 0x0400000F RID: 15
	private Rigidbody _rb;

	public float jumpforce = 300f;
    public Text objetotext;


	public float tiemposalto;
	public float tiempovel;

	public int velocidadmaxima = 9;

	public int velocidadaux;

    public int dir = 1;
	public float lhorizontalc;
	public float lverticalc;
	public float rhorizontalc;
	public float rverticalc;
	public float jumpc;
	public float mc;
	public float nc;
    public float rbc;
    public float lbc;
    public manager_al2 manager;
    public jugador1_al2 jugador1;
    public jugador1_al2 jugador;
    public GameObject muertesaudio;
    public AudioSource muertes;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1 = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
        muertesaudio = GameObject.Find("muerteaudio");
        if(muertesaudio != null)
        {muertes = muertesaudio.GetComponent<AudioSource>();}


        


        if(manager.datosconfig.plat == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
        if(manager.datosconfig.plat == 2)
        {

        }
        this._rb = base.GetComponent<Rigidbody>();
        vidaaux = vida;
    }
    public void cA()
	{
		jumpc = 1;
	}
	public void cB()
	{
		mc = 1;
	}
	public void cX()
	{
		nc = 1;
	}
    public void crb()
	{
		lbc = 1;
	}
    public void clb()
	{
		rbc = 1;
	}
    public void detA()
	{
		jumpc = 0;
	}
    // Update is called once per frame
    void Update()
    {
        
        lhorizontalc = controles.al2.lhorizontal.ReadValue<float>();
        lverticalc = controles.al2.lvertical.ReadValue<float>();
        rhorizontalc = controles.al2.rhorizontal.ReadValue<float>();
        rverticalc = controles.al2.rvertical.ReadValue<float>();
        jumpc = controles.al2.a.ReadValue<float>();
        mc = controles.al2.b.ReadValue<float>();
        nc = controles.al2.x.ReadValue<float>();
        rbc = controles.al2.rb.ReadValue<float>();
        lbc = controles.al2.lb.ReadValue<float>();
        if(manager.personaje == 2)
        {
        if (jumpc > 0f && saltop == true && tiemposalto > 1.4f)
        {
                this._rb.AddForce(this.jumpforce * Vector3.up);
                saltop = false;
                tiemposalto = 0;
                anim.SetBool("salto",true);

        }
        else{anim.SetBool("salto",false);}
        if(blanco == 0)
        {
            if(manager.datosconfig.idioma == "es")
            {
            objetotext.text = "DISPAROS";
            }
            if(manager.datosconfig.idioma == "en")
            {
            objetotext.text = "weapon";
            }
            if(manager.datosconfig.idioma == "cat")
            {
            objetotext.text = "balas";
            }
            if (nc > 0f &&  tiempodisp > 1 )
            {
                    if(manager.juego == 1)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(transform.forward * 110 * balavel);

                        Destroy(BalaTemporal, 1.0f);

                        disp.Play();

                        tiempodisp = 0;
                    }
                    if(manager.juego == 2)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        
                        if (dir == 1)
                        {rb.AddForce(transform.forward * 110 * balavel);}
                        if (dir == 2)
                        {rb.AddForce(transform.forward * -110 * balavel);}
                        if (dir == 3)
                        {rb.AddForce(transform.right * 110 * balavel);}
                        if (dir == 4)
                        {rb.AddForce(transform.right * -110 * balavel);}

                        Destroy(BalaTemporal, 1.0f);

                        disp.Play();

                        tiempodisp = 0;
                    }
                    if(manager.juego == 3)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        
                        if (dir == 1)
                        {rb.AddForce(transform.right * -110 * balavel);}
                        if (dir == 2)
                        {rb.AddForce(transform.right * 110 * balavel);}

                        Destroy(BalaTemporal, 1.0f);

                        disp.Play();

                        tiempodisp = 0;
                    }
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "VOLVER";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "RETURN";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "TORNAR";
                }
                if(nc > 0f && tempboton > 0.5f)
                {
                    jugador1.tempboton = 0;
                    tempboton = 0;
                    manager.personaje = 1;
                }
            }
            if(objeto == 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto == 0 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }

        }
        if(manager.juego == 1)
        {
            anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
            if (lhorizontalc > 0f )
            {
                dir = 3;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                dir = 4;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lverticalc > 0f)
            {
                dir = 1;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
            }
            if (lverticalc < 0f )
            {
                dir = 2;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.linearVelocity.y, lverticalc * velocidad));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
            }

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
        if(manager.juego == 2)
        {
           anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
           if (lhorizontalc > 0f )
			{
                dir = 3;
				base.transform.Translate (-1 * Time.deltaTime * Vector3.left* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			if (lhorizontalc < 0f)
			{
                dir = 4;
				base.transform.Translate (1 * Time.deltaTime * Vector3.left* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			if (lverticalc > 0f)
			{
                dir = 1;
				base.transform.Translate  (-1 * Time.deltaTime * Vector3.back * velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
			}
			if (lverticalc < 0f )
			{
                dir = 2;
				base.transform.Translate (1  * Time.deltaTime * Vector3.back* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
			}
        }
        if (manager.juego == 3 && this.dimensiion)
		{
            anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
			
			if (lhorizontalc > 0f)
			{
                dir = 1;
				base.transform.position -= +1 * (float)this.velocidad * Time.deltaTime * Vector3.back;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			if (lhorizontalc < 0f )
			{
                dir = 2;
				base.transform.position -= -1 * (float)this.velocidad * Time.deltaTime * Vector3.back;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			this.tiempogiro2 += Time.deltaTime;
		
			
			
			
			
		}
		if (manager.juego == 3 && !this.dimensiion)
		{
            anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
			if (lhorizontalc < 0f )
			{
                dir = 2;
				base.transform.position -= -1 * (float)this.velocidad * Time.deltaTime * Vector3.right;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			if (lhorizontalc > 0f)
			{
                dir = 1;
				base.transform.position -= +1 * (float)this.velocidad * Time.deltaTime * Vector3.right;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			this.tiempogiro2 += Time.deltaTime;
		}
        if (manager.juego == 3 && mc > 0f)
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
    
        }
        if(vida <= 0 && muerte == false)
        {
            muerte = true;
            vida = 0;
            manager.datosserial.muertes++;
            manager.guardar();
        }
        if(tempboton < 15)
        {tempboton += 1 * Time.deltaTime;}
        if(tiemposalto < 15)
        {tiemposalto += 1 * Time.deltaTime;}
        if(tempdano < 15)
        {tempdano += 1 * Time.deltaTime;}
        if(tiempodisp < 15)
        {tiempodisp += 1 * Time.deltaTime;}
        if(tiempovel < 15)
        {tiempovel += 1 * Time.deltaTime;}
        if (muerte == true)
        {
            manager.datosserial.alien2muere = 1;
            manager.guardar();
            respawnm.SetActive(true);
            juego.SetActive(false);

        }
        mc = 0;
        nc = 0;
        lbc = 0;
        rbc = 0;
        
    }
    private void OnTriggerEnter(Collider col)
	{

        if (col.gameObject.tag == "pisar")
		{
            GameObject explosiont = Instantiate(jugador1.explosion, col.transform.position,col.transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            Destroy(col.transform.parent.gameObject);
            manager.datosserial.enemigos_muertos++;
            manager.guardar();
            muertes.Play();
		}
        if (col.gameObject.tag == "pisar2")
		{
            GameObject explosiont = Instantiate(jugador1.explosion, col.transform.position,col.transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            Destroy(transform.parent.gameObject);
            manager.datosserial.enemigos_muertos++;
            manager.guardar();
            muertes.Play();
		}
        if (col.gameObject.tag == "enemigo")
		{
            GameObject explosiont = Instantiate(jugador1.explosion, col.transform.position,col.transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            audio2.Play();
            Destroy(col.gameObject);
			vida--;
            muertes.Play();
        }
        if (col.gameObject.tag == "dañox2" && tempdano > 3)
		{
            tempdano = 0;
            audio2.Play();
			vida--;
        }

	}


    private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "suelo")
		{
			saltop = true;

		}
        if (col.gameObject.tag == "lava")
		{
			saltop = true;
            salto2 = false;
		}
        if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}
        if (col.gameObject.tag == "enemigo")
		{
            GameObject explosiont = Instantiate(jugador1.explosion, col.transform.position,col.transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            audio2.Play();
            Destroy(col.gameObject);
			vida--;
        }
        if (col.gameObject.tag == "dañox2")
		{
            audio2.Play();
			vida--;
            
        }

	}
    private void OnCollisionStay(Collision col)
	{
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "control" || col.gameObject.tag == "nivel1" || col.gameObject.tag == "nivel2" || col.gameObject.tag == "nivel3" || col.gameObject.tag == "nivel4" || col.gameObject.tag == "nivel5" || col.gameObject.tag == "nivel6" || col.gameObject.tag == "nivel7" || col.gameObject.tag == "nivel8" || col.gameObject.tag == "nivel9" || col.gameObject.tag == "nivel10"
        || col.gameObject.tag == "nivel11" || col.gameObject.tag == "nivel12" || col.gameObject.tag == "nivel13" || col.gameObject.tag == "nivel14" || col.gameObject.tag == "nivel15" || col.gameObject.tag == "nivel16" || col.gameObject.tag == "nivel17" || col.gameObject.tag == "nivel18" || col.gameObject.tag == "nivel19" || col.gameObject.tag == "nivel20")
        {
			anim.SetBool("salto",false);
            saltop = true;
		}
	}
    private void OnCollisionExit(Collision col)
	{

		if (col.gameObject.tag == "suelo")
        {

        }
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "control" || col.gameObject.tag == "nivel1" || col.gameObject.tag == "nivel2" || col.gameObject.tag == "nivel3" || col.gameObject.tag == "nivel4" || col.gameObject.tag == "nivel5" || col.gameObject.tag == "nivel6" || col.gameObject.tag == "nivel7" || col.gameObject.tag == "nivel8" || col.gameObject.tag == "nivel9" || col.gameObject.tag == "nivel10"
        || col.gameObject.tag == "nivel11" || col.gameObject.tag == "nivel12" || col.gameObject.tag == "nivel13" || col.gameObject.tag == "nivel14" || col.gameObject.tag == "nivel15" || col.gameObject.tag == "nivel16" || col.gameObject.tag == "nivel17" || col.gameObject.tag == "nivel18" || col.gameObject.tag == "nivel19" || col.gameObject.tag == "nivel20")
		{
			saltop = false;
			anim.SetBool("salto",true);
		}
        

	}
    private void OnTriggerStay(Collider col)
	{
    

	}
}
