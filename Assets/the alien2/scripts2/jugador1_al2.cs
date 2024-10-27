using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jugador1_al2 : MonoBehaviour
{
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
    public bool controlact = true;
    public float pasotiempo;
    public float temppaso = 1;
    public int randompaso;
    public bool saltop = true;
    public bool suelo;
    public bool respawn = false;
    public float invulc = -1;
	public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio4;
    public AudioSource audio3;
    public AudioSource audio5;
    public AudioSource pasosnave;
	public AudioSource pasos1;
	public AudioSource pasos2;
    public AudioSource claxon;
    public bool saltador;
    public float vida = 2;
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
    public float tempboton;
    public float tempdano;
    private bool salto2;
    public AudioSource saltodo;
    public int blanco;
    private float cameraverticalangle2;
    public float tiempodisp;
    public GameObject balaprefab;
    public bool control = false;
    public Animator anim;
    public GameObject mod;

	public float balavel = 20;

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
    public GameObject tactil;

	
    // Start is called before the first frame update
    void Start()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        pushup push = UnityEngine.Object.FindObjectOfType<pushup>();
        Debug.Log("start");
        if(manager.datosconfig.plat == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            tactil.SetActive(false);

        }
        if(manager.datosconfig.plat == 2)
        {
            tactil.SetActive(true);

        }
        this._rb = base.GetComponent<Rigidbody>();
		this.velocidadaux = this.velocidad;
        vida = manager.datosserial.vidamaxima;
        vidaaux = vida;
        if(manager.datosserial.univel == 1 && manager.nivel == 0)
        {
            transform.position = new Vector3(-379.399994f,495.459991f,470.480011f);
            transform.eulerAngles = new Vector3 (0,90,0);

            camara.transform.position = new Vector3(-379.399994f,495.459991f,470.480011f);
            camara.transform.eulerAngles = new Vector3 (0,90,0);

        }
        if(manager.datosserial.univel == 2 && manager.nivel == 0)
        {
            transform.position = new Vector3(-355.329987f,496.25f,287.970001f);
            transform.eulerAngles = new Vector3 (0,180,0);

            camara.transform.position = new Vector3(-355.329987f,496.25f,287.970001f);
            camara.transform.eulerAngles = new Vector3 (0,180,0);

        }
        if(manager.datosserial.univel == 3 && manager.nivel == 0)
        {
            transform.position = new Vector3(-447.850006f,493.73999f,370.480011f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-447.850006f,493.73999f,370.480011f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }
        if(manager.datosserial.univel == 4 && manager.nivel == 0)
        {
            transform.position = new Vector3(-590.080017f,503.089996f,502.839996f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-590.080017f,503.089996f,502.839996f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }




        if(manager.datosserial.univel == 5 && manager.nivel == 0)
        {
            transform.position = new Vector3(-880.460022f,501.980011f,464f);
            transform.eulerAngles = new Vector3 (0,180,0);

            camara.transform.position = new Vector3(-880.460022f,501.980011f,464f);
            camara.transform.eulerAngles = new Vector3 (0,180,0);

        }
        if(manager.datosserial.univel == 6 && manager.nivel == 0)
        {
            transform.position = new Vector3(-945.01001f,501.619995f,605.030029f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-945.01001f,501.619995f,605.030029f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }
        if(manager.datosserial.univel == 7 && manager.nivel == 0)
        {
            transform.position = new Vector3(-928.030029f,501.619995f,669.880005f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-928.030029f,501.619995f,669.880005f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }
        if(manager.datosserial.univel == 8 && manager.nivel == 0)
        {
            transform.position = new Vector3(-739.789978f,504.910004f,645.02002f);
            transform.eulerAngles = new Vector3 (0,75,0);

            camara.transform.position = new Vector3(-739.789978f,504.910004f,645.02002f);
            camara.transform.eulerAngles = new Vector3 (0,75,0);

        }







        if(manager.datosserial.univel == 9 && manager.nivel == 0)
        {
            transform.position = new Vector3(-713.804688f,518f,299.919678f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-713.804688f,518f,299.919678f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }
        if(manager.datosserial.univel == 10 && manager.nivel == 0)
        {
            transform.position = new Vector3(-635.790283f,518f,300.428986f);
            transform.eulerAngles = new Vector3 (0,90,0);

            camara.transform.position = new Vector3(-635.790283f,518f,300.428986f);
            camara.transform.eulerAngles = new Vector3 (0,90,0);

        }
        if(manager.datosserial.univel == 11 && manager.nivel == 0)
        {
            transform.position = new Vector3(-582.103943f,571.099976f,447.768036f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-582.103943f,571.099976f,447.768036f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }
        if(manager.datosserial.univel == 12 && manager.nivel == 0)
        {
            transform.position = new Vector3(-280.254211f,573.345032f,583.172668f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(-280.254211f,573.345032f,583.172668f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }






        if(manager.datosserial.univel == 13 && manager.nivel == 0)
        {
            transform.position = new Vector3(106.098915f,549.845032f,506.726868f);
            transform.eulerAngles = new Vector3 (0,90,0);

            camara.transform.position = new Vector3(106.098915f,549.845032f,506.726868f);
            camara.transform.eulerAngles = new Vector3 (0,90,0);

        }
        if(manager.datosserial.univel == 14 && manager.nivel == 0)
        {
            transform.position = new Vector3(147.318573f,549.845032f,695.388428f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(147.318573f,549.845032f,695.388428f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }
        if(manager.datosserial.univel == 15 && manager.nivel == 0)
        {
            transform.position = new Vector3(-92.9425735f,553.345032f,697.5224f);
            transform.eulerAngles = new Vector3 (0,270,0);

            camara.transform.position = new Vector3(-92.9425735f,553.345032f,697.5224f);
            camara.transform.eulerAngles = new Vector3 (0,270,0);

        }
        if(manager.datosserial.univel == 16 && manager.nivel == 0)
        {
            transform.position = new Vector3(-8.14641953f,513.14502f,796.844849f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(-8.14641953f,513.14502f,796.844849f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }   






        if(manager.datosserial.univel == 17 && manager.nivel == 0)
        {
            transform.position = new Vector3(-629.144287f,501f,947.810486f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(-629.144287f,501f,947.810486f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }   

        if(manager.datosserial.univel == 18 && manager.nivel == 0)
        {
            transform.position = new Vector3(-438.866516f,501f,944.480408f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(-438.866516f,501f,944.480408f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }   

        if(manager.datosserial.univel == 19 && manager.nivel == 0)
        {
            transform.position = new Vector3(-438.279633f,501f,838.99646f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(-438.279633f,501f,838.99646f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }   

        if(manager.datosserial.univel == 20 && manager.nivel == 0)
        {
            transform.position = new Vector3(-628.883118f,501f,838.310181f);
            transform.eulerAngles = new Vector3 (0,0,0);

            camara.transform.position = new Vector3(-628.883118f,501f,838.310181f);
            camara.transform.eulerAngles = new Vector3 (0,0,0);

        }  
        if(manager.datosserial.respawntipo == 1 && manager.nivel == 0 && manager.datosserial.univel == 0)
        {
            transform.position = new Vector3(-467.200012f,505.200012f,455f);
        }
        else if(manager.datosserial.respawntipo == 2 && manager.nivel == 0 && manager.datosserial.univel == 0)
        {
            transform.position = new Vector3(-766.900024f,503.899994f,488.369995f);
        }
        else if(manager.datosserial.respawntipo == 3 && manager.nivel == 0 && manager.datosserial.univel == 0)
        {
            transform.position = new Vector3(-496.940002f,575.530029f,512.599976f);
        }
        else if(manager.datosserial.respawntipo == 4 && manager.nivel == 0 && manager.datosserial.univel == 0)
        {
            transform.position = new Vector3(66.6999969f,551.5f,512.599976f);
        }
        else if(manager.datosserial.respawntipo == 5 && manager.nivel == 0 && manager.datosserial.univel == 0)
        {
            transform.position = new Vector3(-586.400024f,503.899994f,891.73999f);
        } 

             
        
    }

    public float temp9;
    public float pausac;
    public GameObject juego;
    public GameObject pausa1;
    public void cpausa()
	{
		pausac = 1;
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
		rbc = 1;
	}
    public void clb()
	{
		lbc = 1;
	}
    public void detA()
	{
		jumpc = 0;
	}
    // Update is called once per frame
    void FixedUpdate()
    {
        pushup push = UnityEngine.Object.FindObjectOfType<pushup>();
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if(respawn == true)
        {
            manager.datosserial.alien2muere = 1;
            manager.guardar();
            if(manager.datosserial.respawntipo == 1 && manager.nivel == 0)
            {
                transform.position = new Vector3(-467.200012f,505.200012f,455f);
            }
            else if(manager.datosserial.respawntipo == 2 && manager.nivel == 0)
            {
                transform.position = new Vector3(-766.900024f,503.899994f,488.369995f);
            }
            else if(manager.datosserial.respawntipo == 3 && manager.nivel == 0)
            {
                transform.position = new Vector3(-496.940002f,575.530029f,512.599976f);
            }
            else if(manager.datosserial.respawntipo == 4 && manager.nivel == 0)
            {
                transform.position = new Vector3(66.6999969f,551.5f,512.599976f);
            }
            else if(manager.datosserial.respawntipo == 5 && manager.nivel == 0)
            {
                transform.position = new Vector3(-586.400024f,503.899994f,891.73999f);
            }
            respawn = false;
        }
        
        lhorizontalc = controles.al2.lhorizontal.ReadValue<float>();
        lverticalc = controles.al2.lvertical.ReadValue<float>();

        rhorizontalc = controles.al2.rhorizontal.ReadValue<float>();
        rverticalc = controles.al2.rvertical.ReadValue<float>();
        
        jumpc = controles.al2.a.ReadValue<float>();
        mc = controles.al2.b.ReadValue<float>();
        nc = controles.al2.x.ReadValue<float>();
        rbc = controles.al2.rb.ReadValue<float>();
        lbc = controles.al2.lb.ReadValue<float>();
        if(manager.personaje == 1 || manager.personaje == 0)
        {

        if (jumpc > 0f && saltador == true)
        {
		    this._rb.AddForce(this.jumpforce * 0.5f * Vector3.up);
            audio1.Play();
        }
        if(blanco == 0)
        {
            if(objeto > 0 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 5 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "DISPAROS: X"+manager.datosserial.disparos;
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "weapon: X"+manager.datosserial.disparos;
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "balas: X"+manager.datosserial.disparos;
                }
                
                if (nc > 0f && manager.datosserial.disparos >= 1 && tiempodisp > 1 && manager.datosserial.tengodisparo == 1)
                {
                    if(manager.juego == 1)
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

                        Destroy(BalaTemporal, 1f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    }
                    if(manager.juego == 2)
                    {
                        anim.SetFloat("velx",lhorizontalc);
                        anim.SetFloat("vely",lverticalc);
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

                        Destroy(BalaTemporal, 1f);

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

                        Destroy(BalaTemporal, 0.5f);

                        disp.Play();

                        tiempodisp = 0;
                    }
                    manager.datosserial.disparos--;
                    manager.guardar();
                    
                }
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "control mental";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "hypnotize";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "hipnotitzar";
                }
                if(nc > 0f && manager.datosserial.tengomental == 1 && control == true && tempboton > 0.5f)
                {
                    jugador2_al2 jugador2 = UnityEngine.Object.FindObjectOfType<jugador2_al2>();
                    jugador2.tempboton = 0;
                    manager.personaje = 2;
                    tempboton = 0;
                    audio5.Play();
                    if(manager.datostrof.alien2hipnotizaunpirata == 0)
                    {
                        manager.datostrof.alien2hipnotizaunpirata = 1;
                        manager.guardartro();
                        push.push(40);
                    }
                }
            }
            if(objeto == 2)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "pocion de vida: X"+manager.datosserial.pociones;
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "life potion: X"+manager.datosserial.pociones;
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "pocio de vida: X"+manager.datosserial.pociones;
                }
                if(nc > 0f && manager.datosserial.pociones >= 1 && tempboton > 0.5f)
                {
                    audio3.Play();
                    vida = manager.datosserial.vidamaxima;
                    manager.datosserial.pociones--;
                    manager.guardar();
                    tempboton = 0;
                }
            }
            if(objeto == 3)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "pocion de rapidez: X"+manager.datosserial.pocionvel;
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "speed potion: X"+manager.datosserial.pociones;
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "pocio de rapidesa: X"+manager.datosserial.pocionvel;
                }
                if(nc > 0f && manager.datosserial.pocionvel >= 1 && tempboton > 0.5f)
                {
                    audio3.Play();
                    velozidad();
                    velocidad = 20;
                    audio4.Play();
                    manager.datosserial.pocionvel--;
                    manager.guardar();
                    tempboton = 0;
                }
            }
            if(objeto == 4)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "pocion de salto: X"+manager.datosserial.pocionsalt;
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "jumping potion: X"+manager.datosserial.pocionsalt;
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "pocio de salt: X"+manager.datosserial.pocionsalt;
                }
                if(nc > 0f && manager.datosserial.pocionsalt >= 1 && tempboton > 0.5f && suelo == true) 
                {
                    this._rb.AddForce(this.jumpforce * 0.5f * Vector3.up * 5f );
                    audio1.Play();
                    audio3.Play();
                    manager.datosserial.pocionsalt--;
                    manager.guardar();
                    tempboton = 0;
                }
            }
            if(objeto == 5)
            {
                if(invulc <= 0)
                {
                    if(manager.datosconfig.idioma == "es")
                    {
                    objetotext.text = "pocion invul: X"+manager.datosserial.pocioninvul;
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                    objetotext.text = "potion invul: X"+manager.datosserial.pocioninvul;
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                    objetotext.text = "pocio invul: X"+manager.datosserial.pocioninvul;
                    }
                }
                if(invulc > 0)
                {
                    objetotext.text = "pocion invul: "+invulc;
                    if(manager.datosconfig.idioma == "es")
                    {
                    objetotext.text = "pocion invul: efecto "+invulc;
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                    objetotext.text = "potion invul: effect "+invulc;
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                    objetotext.text = "pocio invul: efecte "+invulc;
                    }
                }
                
                if(nc > 0f && manager.datosserial.pocioninvul >= 1 && tempboton > 0.5f)
                {
                    audio3.Play();
                    invulc = 15;
                    manager.datosserial.pocioninvul--;
                    manager.guardar();
                    tempboton = 0;
                }
            }
        }
        else if(blanco == 1)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivelc = 1;
                    manager.datosserial.univel = 1;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel1_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel1ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivelc = 2;
                    manager.datosserial.univel = 1;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel1_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel1ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivelc = 3;
                    manager.datosserial.univel = 1;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel1_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel1ch1 == 0)
                {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
                }
            if(objeto == 3 && manager.datosserial.nivel1ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 2)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel2c = 1;
                    manager.datosserial.univel = 2;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel2_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel2ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel2c = 2;
                    manager.datosserial.univel = 2;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel2_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel2ch2 == 1)
            {
                objetotext.text = "punto de control 3";
                if(nc > 0f)
                {
                    manager.datosserial.nivel2c = 3;
                    manager.datosserial.univel = 2;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel2_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel2ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel2ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 3)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel3c = 1;
                    manager.datosserial.univel = 3;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel3_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel3ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel3c = 2;

                    manager.datosserial.univel = 3;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel3_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel3ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel3c = 3;
                    manager.datosserial.univel = 3;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel3_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel3ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel3ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 4)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel4c = 1;
                    manager.datosserial.univel = 4;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel4_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel4ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel4c = 2;
                    manager.datosserial.univel = 4;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel4_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel4ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel4c = 3;
                    manager.datosserial.univel = 4;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel4_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel4ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel4ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 5)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel5c = 1;
                    manager.datosserial.univel = 5;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel5_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel5ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel5c = 2;
                    manager.datosserial.univel = 5;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel5_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel5ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel5c = 3;
                    manager.datosserial.univel = 5;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel5_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel5ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel5ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 6)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel6c = 1;
                    manager.datosserial.univel = 6;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel6_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel6ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel6c = 2;
                    manager.datosserial.univel = 6;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel6_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel6ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel6c = 3;
                    manager.datosserial.univel = 6;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel6_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel6ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel6ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 7)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel7c = 1;
                    manager.datosserial.univel = 7;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel7_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel7ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel7c = 2;
                    manager.datosserial.univel = 7;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel7_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel7ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel7c = 3;
                    manager.datosserial.univel = 7;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel7_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel7ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel7ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 8)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel8c = 1;
                    manager.datosserial.univel = 8;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel8_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel8ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel8c = 2;
                    manager.datosserial.univel = 8;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel8_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel8ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel8c = 3;
                    manager.datosserial.univel = 8;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel8_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel8ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel8ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 9)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel9c = 1;
                    manager.datosserial.univel = 9;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel9_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel9ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel9c = 2;
                    manager.datosserial.univel = 9;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel9_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel9ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel9c = 3;
                    manager.datosserial.univel = 9;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel9_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel9ch1 == 0)
                {
                    if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
                }
            if(objeto == 3 && manager.datosserial.nivel9ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }

            
        }
        else if(blanco == 10)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel10c = 1;
                    manager.datosserial.univel = 10;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel10_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel10ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel10c = 2;
                    manager.datosserial.univel = 10;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel10_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel10ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel10c = 3;
                    manager.datosserial.univel = 10;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel10_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel10ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel10ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 11)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel1c = 1;
                    manager.datosserial.univel = 11;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel11_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel1ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel1c = 2;
                    manager.datosserial.univel = 11;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel11_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel1ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel1c = 3;
                    manager.datosserial.univel = 11;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel11_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel1ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel1ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 12)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel2c = 1;
                    manager.datosserial.univel = 12;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel12_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel2ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel2c = 2;
                    manager.datosserial.univel = 12;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel12_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel2ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel2c = 3;
                    manager.datosserial.univel = 12;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel12_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel2ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel2ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 13)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel3c = 1;
                    manager.datosserial.univel = 13;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel13_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel3ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel3c = 2;
                    manager.datosserial.univel = 13;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel13_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel3ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel3c = 3;
                    manager.datosserial.univel = 13;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel13_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel3ch1 == 0)
                {
                    if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
                }
            if(objeto == 3 && manager.datosserial.nivel3ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 14)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel4c = 1;
                    manager.datosserial.univel = 14;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel14_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel4ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel4c = 2;
                    manager.datosserial.univel = 14;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel14_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel4ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel4c = 3;
                    manager.datosserial.univel = 14;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel14_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel4ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel4ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 15)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel5c = 1;
                    manager.datosserial.univel = 15;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel15_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel5ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel5c = 2;
                    manager.datosserial.univel = 15;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel15_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel5ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel5c = 3;
                    manager.datosserial.univel = 15;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel15_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel5ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel5ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 16)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel6c = 1;
                    manager.datosserial.univel = 16;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel16_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel6ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel6c = 2;
                    manager.datosserial.univel = 16;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel16_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel6ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel6c = 3;
                    manager.datosserial.univel = 16;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel16_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel6ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel6ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 17)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel7c = 1;
                    manager.datosserial.univel = 17;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel17_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel7ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel7c = 2;
                    manager.datosserial.univel = 17;
                    manager.guardar();   
                    SceneManager.LoadScene("nivel17_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel7ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel7c = 3;
                    manager.datosserial.univel = 17;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel17_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel7ch1 == 0)
                {
                    if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
                }
            if(objeto == 3 && manager.datosserial.nivel7ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 18)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel18c = 1;
                    manager.datosserial.univel = 18;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel18_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel18ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel18c = 2;
                    manager.datosserial.univel = 18;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel18_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel18ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel18c = 3;
                    manager.datosserial.univel = 18;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel18_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel18ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel18ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 19)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel19c = 1;
                    manager.datosserial.univel = 19;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel19_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel19ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel19c = 2;
                    manager.datosserial.univel = 19;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel19_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel19ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel19c = 3;
                    manager.datosserial.univel = 19;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel19_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel19ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel19ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        else if(blanco == 20)
        {
            if(objeto > 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto < 3 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 1";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 1";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 1";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel20c = 1;
                    manager.datosserial.univel = 20;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel20_al2");
                }
            }
            if(objeto == 2 && manager.datosserial.nivel20ch1 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel20c = 2;
                    manager.datosserial.univel = 20;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel20_al2");
                }
            }
            if(objeto == 3 && manager.datosserial.nivel20ch2 == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3";
                }
                if(nc > 0f)
                {
                    manager.datosserial.nivel20c = 3;
                    manager.datosserial.univel = 20;
                    manager.guardar(); 
                    SceneManager.LoadScene("nivel20_al2");

                }
            }
            if(objeto == 2 && manager.datosserial.nivel20ch1 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 2 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 2 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 2 bloq";
                }
            }
            if(objeto == 3 && manager.datosserial.nivel20ch2 == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "punto de control 3 bloq";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "checkpoint 3 lock";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "punt d' control 3 bloq";
                }
            }
            
        }
        if(blanco == 21)
        {
        if(objeto == 0)
        {
            if(manager.datosconfig.idioma == "es")
            {
            objetotext.text = "DISPAROS";
            }
            if(manager.datosconfig.idioma == "en")
            {
            objetotext.text = "WEAPON";
            }
            if(manager.datosconfig.idioma == "cat")
            {
            objetotext.text = "BALAS";
            }
        }
        }
        if(blanco == 22)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "CLAXON";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "HORN";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "CLAXON";
                }
                if(nc > 0f)
                {
                    claxon.Play();
                }
            }
        }
        if(blanco == 23)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "subir al coche";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "up in to the card";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "pujar al cotxe";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("mundo_abierto_coche_al2");
                }
            }
        }
        if(blanco == 24)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "subir a la nave";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "go to the ship";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "pujar a la nau";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("espacio_al2");
                }
            }
        }
        if(blanco == 25)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "ir a tiendas";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "go to the shops";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "anar a tendas";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("centro_de_tiendas_al2");
                }
            }
        }
        if(blanco == 26)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "ir a la torre";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "enter in the tower";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "anar a la torre";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("torre_del_tiempo_al2");
                }
            }
        }
        if(blanco == 27)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "ir a la isla";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "enter to the island";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "anar a l illa";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("isla_al2");
                }
            }
        }
        if(blanco == 28)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "volver a la ciudad";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "return to the city";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "tornar a la ciutat";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("mundo_abierto_al2");
                }
            }
        }
        if(blanco == 29)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "ir al enfrentamiento";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "go to the battle";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "anar al enforntament";
                }
                if(nc > 0f)
                {
                    SceneManager.LoadScene("jefe6_1_al2");
                }
            }
        }
        if(blanco == 30)
        {
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "no hay objetos";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "haven t items";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "no ja objectes";
                }
                if(nc > 0f)
                {
                }
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
                Vector3 movdire = _rb.linearVelocity;
                movdire.y = 0;
                float distance = movdire.magnitude * Time.fixedDeltaTime;
                movdire.Normalize();
                RaycastHit hit;
                if(lverticalc == 0f && lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
                {
                    _rb.linearVelocity = new Vector3 (0, _rb.linearVelocity.y, 0);
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
        if(manager.juego == 2)
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
            Vector3 movdire = _rb.linearVelocity;
            movdire.y = 0;
            float distance = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
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
        }
        if (manager.juego == 3 && this.dimensiion)
		{
			anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
            if (lhorizontalc > 0f )
            {
                dir = 1;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (-1 * velocidad, _rb.linearVelocity.y, 0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                dir = 2;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (1 * velocidad, _rb.linearVelocity.y, 0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            Vector3 movdire = _rb.linearVelocity;
            movdire.y = 0;
            float distance = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
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
                dir = 1;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (-1 * velocidad, _rb.linearVelocity.y,0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
            }
            if (lhorizontalc < 0f)
            {
                dir = 2;
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (1 * velocidad, _rb.linearVelocity.y, 0));
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
            }
            Vector3 movdire = _rb.linearVelocity;
            movdire.y = 0;
            float distance = movdire.magnitude * Time.fixedDeltaTime;
            movdire.Normalize();
            RaycastHit hit;
            if(lhorizontalc == 0f || _rb.SweepTest(movdire,out hit,distance,QueryTriggerInteraction.Ignore))
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
        if(manager.juego == 4)
        {
            if (lhorizontalc > 0f )
            {
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if (lhorizontalc < 0f)
            {
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if (lverticalc > 0f)
            {
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if (lverticalc < 0f )
            {
                _rb.linearVelocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if(lverticalc == 0f && lhorizontalc == 0f)
            {
                _rb.linearVelocity = new Vector3 (0, 0, 1 * velocidad);
            }
            if (nc > 0f && tiempodisp > 0.7f)
			{
				GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                rb.AddForce(transform.forward * 110 * balavel);

                Destroy(BalaTemporal, 9.0f);

                disp.Play();

                tiempodisp = 0;
			}

        }
        if(manager.juego == 5)
        {
			if (jumpc > 0f)
			{
                pasosnave.UnPause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,1 * velocidad));
			}
			else if (mc > 0f )
			{
                pasosnave.UnPause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,-1 * velocidad));
			}
            else
			{
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,_rb.linearVelocity.y,0));
                pasosnave.Pause();
			}

            rotationinput.x = lhorizontalc * rotspeed * Time.deltaTime / 2;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;

            cameraverticalangle +=  rotationinput.y;
            cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
            
            transform.Rotate(Vector3.up * rotationinput.x);
            camara.transform.localRotation = Quaternion.Euler(-cameraverticalangle,transform.eulerAngles.y,0);

            camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,30 * Time.deltaTime);
        }
        if(manager.juego == 6)
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
			if (jumpc > 0f)
			{
                pasosnave.UnPause();
				_rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,1 * velocidad));
			}
            else
            {
            _rb.linearVelocity = transform.TransformDirection(new Vector3 (0,0,0));
            pasosnave.Pause();
            }

			rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;
            
            transform.Rotate(Vector3.up * rotationinput.x);
			transform.Rotate(Vector3.left * rotationinput.y);

        }
        if (jumpc > 0f && saltop == true && tiemposalto > 1.4f && manager.juego != 5 && manager.juego != 4 && manager.juego != 6)
        {
                this._rb.AddForce(this.jumpforce * Vector3.up);
                saltop = false;
                salto2 = true;
                tiemposalto = 0;
                anim.SetBool("salto",true);

        }
        else if (jumpc > 0f && salto2 == true && tiemposalto > 0.3f && manager.datosserial.tengosaltod == 1 && manager.juego != 5 && manager.juego != 4 && manager.juego != 6)
        {
                this._rb.AddForce(this.jumpforce * Vector3.up);
                saltodo.Play();
                salto2 = false;
                tiemposalto = 0;
                anim.SetBool("salto",true);

        }
        if (this.tiempovel >= 2)
		{
		    this.velocidad = this.velocidadaux;
		}
        if(this.tiempovel >= 2 && suelo == true)
        {velocidad = velocidadmaxima;}
        }
        if(vida <= 0)
        {
            muerte = true;
            vida = 0;
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
        if(invulc >= -1)
        {invulc -= 1 * Time.deltaTime;}
        if (muerte == true)
        {
            manager.datosserial.alien2muere = 1;
            manager.guardar();
            if(manager.nivel == 26)
            {
                if(manager.datosserial.finalbueno == 1)
                {
                    SceneManager.LoadScene("final_bueno_al2");
                }
                if(manager.datosserial.finalbueno == 0)
                {
                    SceneManager.LoadScene("final_malo_al2");
                }
            }
            else if(manager.torretiemponivel == true)
            {SceneManager.LoadScene("torre_del_tiempo_al2");}
            else
            {SceneManager.LoadScene("mundo_abierto_al2");}
        }
        if (pausac > 0 && temp9 > 0.5f)
		{
			pausa1.SetActive(true);
			pausac = 0;
			temp9 = 0;
            manager.pause = true;
			juego.SetActive(false);
			Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
		}
        if(temp9 < 15)
        {temp9 += 1 * Time.deltaTime;}
        
        
    }

    
    public void velozidad()
	{
		tiempovel = 0f;
	}
    private void OnCollisionEnter(Collision col)
	{
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "suelo")
		{
			saltop = true;

            suelo = true;
            salto2 = false;
            if(manager.juego != 5 || manager.juego != 4 || manager.juego != 6)
            {anim.SetBool("salto",false);}
		}
        if (col.gameObject.tag == "lava")
		{
			saltop = true;
            salto2 = false;
            if(manager.juego != 5 || manager.juego != 4 || manager.juego != 6)
            {anim.SetBool("salto",false);}
		}
        if (col.gameObject.tag == "nivel1")
		{
			blanco = 1;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel2")
		{
			blanco = 2;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel3")
		{
			blanco = 3;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel4")
		{
			blanco = 4;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel5")
		{
			blanco = 5;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel6")
		{
			blanco = 6;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel7")
		{
			blanco = 7;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel8")
		{
			blanco = 8;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel9")
		{
			blanco = 9;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel10")
		{
			blanco = 10;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel11")
		{
			blanco = 11;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel12")
		{
			blanco = 12;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel13")
		{
			blanco = 13;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel14")
		{
			blanco = 14;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel15")
		{
			blanco = 15;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel16")
		{
			blanco = 16;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel17")
		{
			blanco = 17;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel18")
		{
			blanco = 18;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel19")
		{
			blanco = 19;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "nivel20")
		{
			blanco = 20;
            objeto = 1;
            anim.SetBool("salto",false);
		}
        if (col.gameObject.tag == "respawn" && manager.nivel != 0)
		{
			muerte = true;
		}
        if (col.gameObject.tag == "respawn" && manager.nivel == 0)
		{
			respawn = true;
		}
        if (col.gameObject.tag == "respawn2" && manager.nivel == 0)
		{
			muerte = true;
		}
        

	}
    private void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "lava" && tempdano > 3 && invulc <= 0)
		{
			vida--;
            tempdano = 0;
            audio2.Play();
		}
        if (col.gameObject.tag == "suelo")
		{

            suelo = true;
		}
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "control" || col.gameObject.tag == "nivel1" || col.gameObject.tag == "nivel2" || col.gameObject.tag == "nivel3" || col.gameObject.tag == "nivel4" || col.gameObject.tag == "nivel5" || col.gameObject.tag == "nivel6" || col.gameObject.tag == "nivel7" || col.gameObject.tag == "nivel8" || col.gameObject.tag == "nivel9" || col.gameObject.tag == "nivel10"
        || col.gameObject.tag == "nivel11" || col.gameObject.tag == "nivel12" || col.gameObject.tag == "nivel13" || col.gameObject.tag == "nivel14" || col.gameObject.tag == "nivel15" || col.gameObject.tag == "nivel16" || col.gameObject.tag == "nivel17" || col.gameObject.tag == "nivel18" || col.gameObject.tag == "nivel19" || col.gameObject.tag == "nivel20")
        {
			anim.SetBool("salto",false);
            suelo = true;
		}
	}
    private void OnCollisionExit(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();

		if (col.gameObject.tag == "suelo")
        {
            suelo = false;
        }
        if (col.gameObject.tag == "nivel1")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel2")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel3")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel4")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel5")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel6")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel7")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel8")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel9")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel10")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel11")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel12")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel13")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel14")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel15")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel16")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel17")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel18")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel19")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "nivel20")
		{
			blanco = 0;
            objeto = 0;
		}
        if (col.gameObject.tag == "control")
		{
			control = false;
		}
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "control" || col.gameObject.tag == "nivel1" || col.gameObject.tag == "nivel2" || col.gameObject.tag == "nivel3" || col.gameObject.tag == "nivel4" || col.gameObject.tag == "nivel5" || col.gameObject.tag == "nivel6" || col.gameObject.tag == "nivel7" || col.gameObject.tag == "nivel8" || col.gameObject.tag == "nivel9" || col.gameObject.tag == "nivel10"
        || col.gameObject.tag == "nivel11" || col.gameObject.tag == "nivel12" || col.gameObject.tag == "nivel13" || col.gameObject.tag == "nivel14" || col.gameObject.tag == "nivel15" || col.gameObject.tag == "nivel16" || col.gameObject.tag == "nivel17" || col.gameObject.tag == "nivel18" || col.gameObject.tag == "nivel19" || col.gameObject.tag == "nivel20")
		{
			suelo = false;
			anim.SetBool("salto",true);
		}
        

	}
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "balae")
		{
            audio2.Play();
			vida--;
            UnityEngine.Object.Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "control")
		{
			control = true;
		}

	}
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "control")
		{
			control = false;
		}
		

	}
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "lava" && tempdano > 3 && invulc > 15)
		{
			vida--;
            tempdano = 0;
            audio2.Play();
		}

	}
}
