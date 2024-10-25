using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jugador1_al3: MonoBehaviour
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
    public AudioSource pasosnave;
	public AudioSource pasos1;
	public AudioSource pasos2;
    public AudioSource claxon;
    public float temppaso = 1;
    public float pasotiempo;
    public int randompaso;
    public bool saltop = true;
    public bool lavaaux;
    public bool suelo;
    public float r3;
    public int proteccion = 1;
    public bool atksb;
    public float temp10;
    public float temppocion1;
    public float temppocion2;
    public bool subirnave;
    public GameObject tiendag;
    public float barravuelo;
    public bool volador;
    public Text armat;
    public float invulc = -1;
    public Collider palo;
	public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio4;
    public AudioSource audio3;
    public AudioSource audio5;
    public float tempatk ;
    public float tempatk2;
    public bool atkact = true;
    public bool atkact2 = true;
    public bool saltador;
    public float vida = 5;
    public bool muerte;
    public float vidaaux;
    public bool dimensiion;
    public float rotspeed = 180;
	public GameObject camara;
	private float cameraverticalangle;
	public Vector3 rotationinput;
    public float tiempogiro2;
    public float girovalor;
    private float tempsaltom;
    private bool saltomuerte;
    public bool tiendat;
	private bool girotder = false;
	private bool girotizq = false;
	private bool girotd_der = false;
	private bool girotd_izq = false;
    public int objeto;
    public float tempboton;
    public float tempdano;
    private bool salto2;
    public AudioSource saltodo;
    public int blanco;
    public float tiempodisp;
    public GameObject balaprefab;
    public GameObject balaprefab2;
    public GameObject balaprefab3;
    public GameObject balaprefab4;
    public GameObject balaprefab5;
    public GameObject balaprefab6;
    public GameObject balaprefab7;
    public GameObject balaprefab8;
    public GameObject balaprefab9;
    public GameObject balaprefab10;
    public GameObject arma7prefab;
    public bool control = false;
    public Animator anim;
    public GameObject mod;
    public GameObject objet;
    public bool actsel1;
    public long fuerzanave = 1;
    public platx_al3 platx;
    public platz_al3 platz;
    public platy_al3 platy;
    public float tempselec;
    public bool navemode;
    public float tempdanor;
    public int armaduramode = 1;















	public float balavel = 20;

	public AudioSource disp;

    public int velocidad = 4;

	// Token: 0x0400000F RID: 15
	private Rigidbody _rb;

	public float jumpforce = 300f;
    public Text objetotext;
    public Text armadt;
    public Text gemast;


	public float tiemposalto;
	public float tiempovel;

	public int velocidadmaxima = 9;

	public int velocidadaux;
    public float jumpforcebase = 0f;

    public float lhorizontalc;
	public float lverticalc;
	public float rhorizontalc;
	public float rverticalc;
    public float horizontalpadc;
	public float verticalpadc;
	public float jumpc;
	public float mc;
	public float nc;
    public float yc;
    public float rbc;
    public float rtc;
    public float ltc;

    public float lbc;
    public bool velact = false;
    public bool gas = false;
    public bool antigas = false;
    public int mundosalto = 2;
    public bool selcarga;
    public GameObject selecionrap;

    public Animator seleccionanim;

	
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        manager.cargar();
        if(manager.juego == 1 || manager.juego == 2 ||  manager.juego == 3)
        {seleccionanim = selecionrap.GetComponent<Animator>();}
        if(manager.datosconfig.plat == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
        if(manager.datosconfig.plat == 2)
        {

        }
        juegot = juego.transform;
        this._rb = base.GetComponent<Rigidbody>();
		this.velocidadaux = this.velocidad;
        if(navemode == false)
        {
            vidaaux = manager.datosserial.vidamaxima;
        }
        else if(navemode == true)
        {
            vidaaux = vida;
        }
        if(manager.juego == 6)
        {
            pasosnave.Play();
        }
        if(manager.juego != 4)
        {vida = manager.datosserial.vidamaxima;}
         
        
    }

    public bool jumpfcarga;
    public float temp9;
    public float pausac;
    public Transform juegot;
    public GameObject juego;
    public GameObject pausa1;
    public float tiempogas;
    public Text cuentavidas;
    public Text cuentamonedas;
    public Image vidab;
    public Image auxb;
    public int dano = 1;
    public bool escalar;
    public GameObject model;
    public GameObject pistola;
    public float velf;
        // Update is called once per frame
    void FixedUpdate()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();

        if(suelo == false || volador == false)
        {
            if(manager.juego == 1 || manager.juego == 2 ||  manager.juego == 3)
            {
            anim.SetBool("salto",true);
            }
        }
        if(suelo == true || volador == true)
        {
            if(manager.juego == 1 || manager.juego == 2 ||  manager.juego == 3)
            {
            anim.SetBool("salto",false);
            }
        }
        velf = velocidad * Time.deltaTime;
        if(jumpfcarga == false)
        {
        if(manager.datosserial.armadura == 6 && mundosalto == 1 || mundosalto == 2 && manager.datosserial.armadura != 5)
        {
            jumpforce = 400;
            GetComponent<Rigidbody>().mass = 1f;
        }
        if(manager.datosserial.armadura == 5 && mundosalto == 2|| mundosalto == 1 && manager.datosserial.armadura != 6)
        {
            jumpforce = 30;
            GetComponent<Rigidbody>().mass = 0.05f;
            tiemposalto = -2;
        }
        if(manager.datosserial.armadura == 5 && mundosalto == 1)
        {
            jumpforce = 30;
            GetComponent<Rigidbody>().mass = 0.05f;
        }
        if(manager.datosserial.armadura == 6 && mundosalto == 2)
        {
            jumpforce = 600;
            GetComponent<Rigidbody>().mass = 4f;
        }
        jumpforcebase = jumpforce;
        jumpfcarga = true;
        }
        if(selcarga == false)
        {
            selcarga = true;
        }

        lhorizontalc = controles.al3.lhorizontal.ReadValue<float>();
        lverticalc = controles.al3.lvertical.ReadValue<float>();
        rhorizontalc = controles.al3.rhorizontal.ReadValue<float>();
        rverticalc = controles.al3.rvertical.ReadValue<float>();
        jumpc = controles.al3.a.ReadValue<float>();
        mc = controles.al3.b.ReadValue<float>();
        yc = controles.al3.y.ReadValue<float>();
        nc = controles.al3.x.ReadValue<float>();
        rbc = controles.al3.rb.ReadValue<float>();
        lbc = controles.al3.lb.ReadValue<float>();
        ltc = controles.al3.lt.ReadValue<float>();
        rtc = controles.al3.rt.ReadValue<float>();
        pausac = controles.al3.pausa.ReadValue<float>();
        r3 = controles.al3.r3.ReadValue<float>();


        horizontalpadc = controles.al3.horizontalpad.ReadValue<float>();
        
        verticalpadc = controles.al3.verticalpad.ReadValue<float>();
        
        if(manager.datosconfig.idioma == "es")
        {
            cuentavidas.text = "VIT: "+ (int)vida;
        }
        if(manager.datosconfig.idioma == "en")
        {
            cuentavidas.text = "VIT: "+ (int)vida;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            cuentavidas.text = "VIT: "+ (int)vida;
        }
        vidab.fillAmount = vida/vidaaux;

        if(manager.juego != 4)
        {
            if(manager.datosconfig.idioma == "es")
            {
            cuentamonedas.text = "monedas : "+manager.datosserial.monedas;
            gemast.text = "gemas : "+manager.datosserial.gemas;
            }
            if(manager.datosconfig.idioma == "en")
            {
            cuentamonedas.text = "coins : "+manager.datosserial.monedas;
            gemast.text = "gems : "+manager.datosserial.gemas;
            }
            if(manager.datosconfig.idioma == "cat")
            {
            cuentamonedas.text = "monedas : "+manager.datosserial.monedas;
            gemast.text = "gemmes : "+manager.datosserial.gemas;
            }
        }


        if(nc> 0f && atkact == true && saltop == true && manager.juego != 4 && manager.juego != 6 && escalar == false)
        {
            anim.SetBool("atk",true);
            atkact = false;
            tempatk = 0;
        }
        else if(manager.juego != 4 && manager.juego != 6)
        {
                anim.SetBool("atk",false);
        }
        if(manager.datosserial.armadura == 1)
        {
            gas = false;
        }
        if(manager.datosserial.armadura == 2)
        {
            lavaaux = false;
        }
        if(manager.datosserial.armadura != 3 && manager.datosserial.armadura != 4 && temppocion2 <= 0)
        {
            proteccion = 1;
        }
        else if(manager.datosserial.armadura == 3  && temppocion2 <= 0)
        {
            proteccion = 2;
        }
        else if(manager.datosserial.armadura == 4  && temppocion2 <= 0)
        {
            proteccion = 3;
        }
        if(manager.datosserial.armadura == 6 && mundosalto == 1 && saltomuerte == false || mundosalto == 2 && manager.datosserial.armadura != 5 && manager.datosserial.armadura != 6 && saltomuerte == false || mundosalto == 2 && manager.datosserial.armadura == 6 && saltomuerte == false)
        {
            if (jumpc > 0f && saltop == true && tiemposalto > 1.4f && manager.juego != 5 && manager.juego != 4 && manager.juego != 6 && tiendat == false)
            {
                this._rb.AddForce(this.jumpforce * Vector3.up);
                saltop = false;
                salto2 = true;
                tiemposalto = 0;
                

            }
            else if (jumpc > 0f && salto2 == true && tiemposalto > 0.3f && manager.juego != 5 && manager.juego != 4 && manager.juego != 6 && tiendat == false)
            {
                    this._rb.AddForce(this.jumpforce *1.5f* Vector3.up);
                    saltodo.Play();
                    salto2 = false;
                    tiemposalto = 0;


            }

            if(tiemposalto < 15)
            {tiemposalto += 1 * Time.deltaTime;}

            if (jumpc > 0f && saltador == true)
            {
                this._rb.AddForce(this.jumpforce * 1.0f * Vector3.up);
                audio1.Play();
            }
        }
        if(manager.datosserial.armadura == 5 && mundosalto == 2 && saltomuerte == false|| mundosalto == 1 && manager.datosserial.armadura != 6 && manager.datosserial.armadura != 5 && saltomuerte == false)
        {
            if(tiemposalto < 15)
            {tiemposalto += 1 * Time.deltaTime;}
			if (this.tiemposalto >= 0.7f && jumpc > 0f && volador == false && tiendat == false)
			{
					this._rb.AddForce(this.jumpforce * Vector3.up);
					this.tiemposalto = 0;
                    if(jumpforce == 30)
					{jumpforce = 8;}
                    else if(jumpforce == 8)
					{jumpforce = 15;}
                    else if(jumpforce == 15)
					{jumpforce = 10;}
                    else if(jumpforce == 10)
					{jumpforce = 15;}
					
			}
			else{}

            if (jumpc > 0f && saltador == true)
            {
                this._rb.AddForce(this.jumpforce * 0.5f * Vector3.up);
                audio1.Play();
            }
        }
        if(manager.datosserial.armadura == 5 && mundosalto == 1)
        {
            if(tiemposalto < 15)
            {tiemposalto += 1 * Time.deltaTime;}
			if (this.tiemposalto >= 0.7f && jumpc > 0f && volador == false && tiendat == false)
			{
                anim.SetBool("saltom",true);
                pausac = 0;
                saltomuerte = true;
			}
            else{anim.SetBool("saltom",false);}
        }
        if(saltomuerte == true)
        {
            tempsaltom += 1 * Time.deltaTime;
            if(tempsaltom > 3.5f)
            {
                manager.datosserial.alien3muere = 1;
                manager.guardar();
                SceneManager.LoadScene("carga_al3");
            }
        }
        if(manager.datosserial.armadura == 7)
        {

            if (jumpc > 0f && volador == true)
            {
                anim.SetBool("jetpack1",true);
                if(mundosalto == 1)
                {this._rb.AddForce(this.jumpforce * 0.1f * Vector3.up);}
                if(mundosalto == 2)
                {this._rb.AddForce(this.jumpforce * 0.03f * Vector3.up);}
                barravuelo -= 7 * Time.deltaTime;
            } 
        }
        if(barravuelo <= 0 && manager.juego != 4 && manager.juego != 6)
        {
            
            volador = false;
            anim.SetBool("jetpack1",false);
        }
        if(manager.datosserial.armadura != 8 && manager.datosserial.armadura != 9  && temppocion1 <= 0)
        {
            dano = 1;
        }
        else if(manager.datosserial.armadura == 8  && temppocion1 <= 0)
        {
            dano = 2;
        }
        else if(manager.datosserial.armadura == 9  && temppocion1 <= 0)
        {
            dano = 3;
        }

        if(manager.datosserial.armadura == 10)
        {
           if(lverticalc != 0f && escalar == true || lhorizontalc != 0f && escalar == true)
            {
                anim.SetBool("escalar",true);
                transform.Translate (10 * Time.deltaTime * Vector3.up);
                _rb.useGravity = false;
                _rb.velocity = new Vector3(_rb.velocity.x,0,_rb.velocity.z);
            }
            else
            {
                anim.SetBool("escalar",false);
                _rb.useGravity = true;
            }
           
        }

        if(lavaaux == true && tempdano > 3)
        {
            vida = vida - 10 / proteccion;
            tempdano = 0;
        }
        if(gas == true && antigas == false && tiempogas > 5)
        {
            vida = vida - 10 / proteccion;
            tiempogas = 0;
        }
        else if(tiempogas < 15f && gas == true && antigas == false)
        {tiempogas += 1 * Time.deltaTime;}

        if(gas == true && antigas == false)
        {
            auxb.color = new Color32(106,202,107,255);
            auxb.fillAmount = tiempogas/5;
        }
        if(lavaaux == true)
        {
            auxb.color = new Color32(255,0,0,255);
            auxb.fillAmount = tempdano/3;
        }
        else if(volador == true)
        {
            auxb.fillAmount = barravuelo/100;
            auxb.color = new Color32(219,69,185,255);
        
        }
        else if(manager.juego != 6 && manager.juego != 4 && manager.juego != 5 && gas == false && lavaaux == false )
        {
            auxb.color = new Color32(255,255,255,255);
            auxb.fillAmount = 100/100;
            tiempogas = 0;
            tempdano = 0;
        }
        else if(antigas == true)
        {
            auxb.color = new Color32(255,255,255,255);
            auxb.fillAmount = 100/100;
            tiempogas = 0;
        }


        
        if(tempatk > 1.1f && manager.juego != 6 && manager.juego != 4 && manager.juego != 5 && escalar == false)
        {
            atkact = true;
            atkact2 = true;
        }
        if(tempatk < 15)
        {
            tempatk += 1 * Time.deltaTime;
        }




        if(verticalpadc > 0 && horizontalpadc <= 0.5f && horizontalpadc >= -0.5f && tiendat == false)
        {
            manager.datosserial.arma = manager.datosserial.armass2;
            manager.guardar();
        }
        else if(r3 > 0 && suelo == true && tiendat == false && armaduramode == 2 && temp9 > 0.5f)
        {
            anim.SetBool("jetpack1",false);
            manager.datosserial.armadura = manager.datosserial.armadurass2;
            manager.guardar();
            jumpfcarga = false;
            armaduramode = 1;
            temp9 = 0;
        }
        else if(r3 > 0 && suelo == true && tiendat == false && armaduramode == 1 && temp9 > 0.5f)
        {
            anim.SetBool("jetpack1",false);
            manager.datosserial.armadura = manager.datosserial.armadurass1;
            manager.guardar();
            jumpfcarga = false;
            armaduramode = 2;
            temp9 = 0;
        }
        else if(verticalpadc == 0 && horizontalpadc > 0 && tiendat == false)
        {
            manager.datosserial.arma = manager.datosserial.armass3;
            manager.guardar();
        }
        else if(verticalpadc >= -0.5f && verticalpadc <= 0.5f && horizontalpadc < 0&& tiendat == false)
        {
            manager.datosserial.arma = manager.datosserial.armass1;
            manager.guardar();
        }
        else if(verticalpadc < 0 && horizontalpadc <= 0.5f && horizontalpadc >= -0.5f&& tiendat == false)
        {
            manager.datosserial.arma = manager.datosserial.armass4;
            manager.guardar();
        }
        if(ltc> 0f && manager.juego != 6 && manager.juego != 4&& manager.juego != 5 && actsel1 == false)
        {
            actsel1 = true;
            tempselec = 0;
            anim.SetBool("caminar",true);
            if(tempselec <= 5)
            {seleccionanim.SetBool("show",true);}
            if(tempselec < 15)
            {tempselec += 1 * Time.deltaTime;}
            
        }
        else if(ltc> 0f && manager.juego != 6 && manager.juego != 4&& manager.juego != 5 && actsel1 == true)
        {
            anim.SetBool("caminar",true);
            if(tempselec > 5)
            {}
            if(tempselec < 15)
            {tempselec += 1 * Time.deltaTime;}
            
        }
        if(ltc == 0f && manager.juego != 6 && manager.juego != 4 && manager.juego != 5)
        {
            actsel1 = false;
            anim.SetBool("caminar",false);
            seleccionanim.SetBool("show",false);
        }

        if(nc> 0f && atkact2 == true && suelo == false && manager.juego != 6 && manager.juego != 4 && manager.juego != 5 && escalar == false)
        {
            this._rb.AddForce(this.jumpforce * 5f * -Vector3.up);
            anim.SetBool("atks",true);
            atkact2 = false;
            tempatk = 0;
            if(temp10 > 15f)
            {atksb = true;temp10 = 0;}
            tempdano = 0;
        }
        else if (suelo == true || volador == true)
            {
                anim.SetBool("atks",false);
            }




        if(blanco == 0)
        {
            if(objeto == 0 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 2 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto = 0;
                tempboton = 0;
            }
            if(objeto == 0)
            {
                if(manager.datosconfig.idioma == "es")
                {
                    objetotext.text = "pocion de vida: "+manager.datosserial.pociones;
                }
                if(manager.datosconfig.idioma == "en")
                {
                    objetotext.text = "life potion: "+manager.datosserial.pociones;
                }
                if(manager.datosconfig.idioma == "cat")
                {
                    objetotext.text = "pocio de vida: "+manager.datosserial.pociones;
                }
                if(yc> 0f && manager.datosserial.pociones >= 1 && tempboton > 2f && vida < manager.datosserial.vidamaxima)
                {
                    audio3.Play();
                    vida += 30;
                    if(vida > manager.datosserial.vidamaxima)
                    {vida = manager.datosserial.vidamaxima;}
                    manager.datosserial.pociones--;
                    manager.guardar();
                    tempboton = 0;
                }
                
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                    if(temppocion1 <= 0)
                    {objetotext.text = "pocion de fuerza: " +manager.datosserial.pocionfue;}
                    else if(temppocion1 > 0)
                    {objetotext.text = "pocion de fuerza: " +manager.datosserial.pocionfue+" efecto "+temppocion1;}
                }
                if(manager.datosconfig.idioma == "en")
                {
                    if(temppocion1 <= 0)
                    {objetotext.text = "strength potion: " +manager.datosserial.pocionfue;}
                    else if(temppocion1 > 0)
                    {objetotext.text = "strength potion: " +manager.datosserial.pocionfue+" effect "+temppocion1;}
                }
                if(manager.datosconfig.idioma == "cat")
                {
                    if(temppocion1 <= 0)
                    {objetotext.text = "pocio de forca: " +manager.datosserial.pocionfue;}
                    else if(temppocion1 > 0)
                    {objetotext.text = "pocio de forca: " +manager.datosserial.pocionfue+" efecte "+temppocion1;}
                }
                if(yc> 0f && manager.datosserial.pocionfue >= 1 && tempboton > 2f)
                {
                    audio3.Play();
                    manager.datosserial.pocionfue--;
                    manager.guardar();
                    dano = 3;
                    temppocion1 = 21; 
                    tempboton = 0;
                }
                if(objetotext.text.Length > 27)
                {
                 objetotext.text = objetotext.text.Substring(0,27);
                }
            }
            if(objeto == 2)
            {
                if(manager.datosconfig.idioma == "es")
                {
                    if(temppocion2 <= 0)
                    {objetotext.text = "pocion de resistencia: "+manager.datosserial.pocionres;}
                    else if(temppocion2 > 0)
                    {objetotext.text = "pocion de resistencia: "+manager.datosserial.pocionres +" efecto "+temppocion2;}
                }
                if(manager.datosconfig.idioma == "en")
                {
                    if(temppocion2 <= 0)
                    {objetotext.text = "stamina potion: "+manager.datosserial.pocionres;}
                    else if(temppocion2 > 0)
                    {objetotext.text = "stamina potion: "+manager.datosserial.pocionres +" effect "+temppocion2;}
                }
                if(manager.datosconfig.idioma == "cat")
                {
                    if(temppocion2 <= 0)
                    {objetotext.text = "pocio de resistencia: "+manager.datosserial.pocionres;}
                    else if(temppocion2 > 0)
                    {objetotext.text = "pocio de resistencia: "+manager.datosserial.pocionres +" efecte "+temppocion2;}
                }
                if(yc> 0f && manager.datosserial.pocionres >= 1 && tempboton > 2f)
                {
                    audio3.Play();
                    manager.datosserial.pocionres--;
                    manager.guardar();
                    proteccion = 3;
                    temppocion2 = 21; 
                    tempboton = 0;
                }
                if(objetotext.text.Length > 32)
                {
                 objetotext.text = objetotext.text.Substring(0,32);
                }
            }
        }
        else if (blanco == 1)
        {
            inicio_al3 inicio = UnityEngine.Object.FindObjectOfType<inicio_al3>();
            if(manager.datosconfig.idioma == "es")
            {
                objetotext.text = "subir a la nave";
            }
            if(manager.datosconfig.idioma == "en")
            {
                objetotext.text = "get on the ship";
            }
            if(manager.datosconfig.idioma == "cat")
            {
                objetotext.text = "pujar a la nau";
            }
            if(yc> 0f && tempboton > 0.5f && manager.datosserial.espacio == -1)
            {
                SceneManager.LoadScene("espacio_al3");
                tempboton = 0;
            }
            if(yc> 0f && tempboton > 0.5f && manager.datosserial.espacio == -2)
            {
                SceneManager.LoadScene("espacio2_al3");
                tempboton = 0;
            }
            if(yc> 0f && tempboton > 0.5f && manager.datosserial.espacio == -3)
            {
                SceneManager.LoadScene("espacio3_al3");
                tempboton = 0;
            }
            if(yc> 0f && tempboton > 0.5f && manager.datosserial.espacio == -4)
            {
                SceneManager.LoadScene("espacio4_al3");
                tempboton = 0;
            }
            if(yc> 0f && tempboton > 0.5f && manager.datosserial.espacio == -5)
            {
                SceneManager.LoadScene("espacio5_al3");
                tempboton = 0;
            }
            if(yc> 0f && tempboton > 0.5f && manager.datosserial.espacio == -6)
            {
                SceneManager.LoadScene("espacio0_al3");
                tempboton = 0;
            }
        }
        else if (blanco == 2)
        {
            if(manager.datosconfig.idioma == "es")
            {
                objetotext.text = "entrar al portal";
            }
            if(manager.datosconfig.idioma == "en")
            {
                objetotext.text = "enter the portal";
            }
            if(manager.datosconfig.idioma == "cat")
            {
                objetotext.text = "entrar al portal";
            }
        }
        if(blanco == 3)
        {
            if(objeto == 0 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 1 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 2 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 3 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 4 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }
            if(objeto == 5 && lbc > 0f && tempboton > 0.5f) 
            {
                objeto = 0;
                tempboton = 0;
            }
            if(objeto == 0)
            {
                objetotext.text = "galaxia 01333 ";
                if(yc> 0f && tempboton > 0.5f)
                {
                    SceneManager.LoadScene("espacio_al3");
                }
                
            }
            if(objeto == 1)
            {
                if(manager.datosserial.espacio2act == 0)
                {
                    objetotext.text = "galaxia 24039 blok";
                }
                if(manager.datosserial.espacio2act == 1)
                {
                    if(manager.datosconfig.idioma == "es")
                    {
                        objetotext.text = "iniciar travesia a galaxia 24039";
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                        objetotext.text = "start journey to galaxia 24039";
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                        objetotext.text = "iniciar viatge a galaxia 24039";
                    }
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("jefe1_al3");
                    }
                }
                else if(manager.datosserial.espacio2act == 2)
                {
                    objetotext.text = "galaxia 24039 ";
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("espacio2_al3");
                    }
                }
                
            }
            if(objeto == 2)
            {

                if(manager.datosserial.espacio3act == 0)
                {
                    objetotext.text = "galaxia 30099 blok";
                }
                if(manager.datosserial.espacio3act == 1)
                {
                    if(manager.datosconfig.idioma == "es")
                    {
                        objetotext.text = "iniciar travesia a galaxia 30099";
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                        objetotext.text = "start journey to galaxia 30099";
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                        objetotext.text = "iniciar viatge a galaxia 30099";
                    }
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("jefe2_al3");
                    }
                }
                else if(manager.datosserial.espacio3act == 2)
                {
                    objetotext.text = "galaxia 30099 ";
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("espacio3_al3");
                    }
                }
                
            }
            if(objeto == 3)
            {
                if(manager.datosserial.espacio4act == 0)
                {
                    objetotext.text = "galaxia 45638 blok";
                }
                if(manager.datosserial.espacio4act == 1)
                {
                    if(manager.datosconfig.idioma == "es")
                    {
                        objetotext.text = "iniciar travesia a galaxia 45638";
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                        objetotext.text = "start journey to galaxia 45638";
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                        objetotext.text = "iniciar viatge a galaxia 45638";
                    }
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("jefe3_al3");
                    }
                }
                else if(manager.datosserial.espacio4act == 2)
                {
                    objetotext.text = "galaxia 45638";
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("espacio4_al3");
                    }
                }
                
            }
            if(objeto == 4)
            {

                if(manager.datosserial.espacio5act == 0)
                {
                    objetotext.text = "galaxia X??59 blok";
                }
                if(manager.datosserial.espacio5act == 1)
                {
                    if(manager.datosconfig.idioma == "es")
                    {
                        objetotext.text = "iniciar travesia a galaxia X??59";
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                        objetotext.text = "start journey to galaxia X??59";
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                        objetotext.text = "iniciar viatge a galaxia X??59";
                    }
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("jefe4_al3");
                    }
                }
                else if(manager.datosserial.espacio5act == 2)
                {
                    objetotext.text = "galaxia X??59";
                    if(yc> 0f && tempboton > 0.5f)
                    {
                        SceneManager.LoadScene("espacio5_al3");
                    }
                }
                
            }
            if(objeto == 5)
            {

                if(manager.datosconfig.idioma == "es")
                {
                    objetotext.text = "final del universo";
                }
                if(manager.datosconfig.idioma == "en")
                {
                    objetotext.text = "end of the universe";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                    objetotext.text = "final del univers";
                }
                if(yc> 0f && tempboton > 0.5f)
                {
                    SceneManager.LoadScene("espacio0_al3");
                }
                
            }
            
            
        }
        if (blanco == 5)
        {
            objetotext.text = "pulsar boton";
            if(manager.datosconfig.idioma == "es")
            {
                objetotext.text = "pulsar boton";
            }
            if(manager.datosconfig.idioma == "en")
            {
                objetotext.text = "press button";
            }
            if(manager.datosconfig.idioma == "cat")
            {
                objetotext.text = "prem boto";
            }
            if(yc> 0f && tempboton > 0.5f)
            {
            if(platx != null)
            {platx.tp = true;}
            if(platz != null)
            {platz.tp = true;}
            if(platy != null)
            {platy.tp = true;}
            }
        }
        if (blanco == 9)
        {
            if(manager.datosconfig.idioma == "es")
            {
                objetotext.text = "claxon";
            }
            if(manager.datosconfig.idioma == "en")
            {
                objetotext.text = "horn";
            }
            if(manager.datosconfig.idioma == "cat")
            {
                objetotext.text = "claxon";
            }
            if(yc> 0f && tempboton > 0.5f)
            {
                claxon.Play();
            }
        }
        if(rbc > 0 && velact == false)
        {
            velocidad = 12;
            anim.speed = 2;
        }
        else if(velact == false && manager.juego != 4 && manager.juego != 6)
        {
            velocidad = velocidadaux;
            anim.speed = 1;
        }
        if(manager.juego != 6 && manager.juego != 4 && manager.juego != 5)
        {
        if(manager.datosconfig.idioma == "es")
        {
            if(manager.datosserial.arma == 0)
            {
                armat.text ="";
            }
            if(manager.datosserial.arma == 1)
            {
                armat.text ="arma de papa "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 2)
            {
                armat.text ="arma de mama "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 3)
            {
                armat.text ="dispara palos 1/1";
            }
            if(manager.datosserial.arma == 4)
            {
                armat.text ="arma del legado "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 5)
            {
                armat.text ="señuelo "+manager.datosserial.marma5+"/3";
            }
            if(manager.datosserial.arma == 6)
            {
                armat.text ="disparo atomico "+manager.datosserial.marma6+"/10";
            }
            if(manager.datosserial.arma == 7)
            {
                armat.text ="metralla cuerpos "+manager.datosserial.marma7+"/300";
            }
            if(manager.datosserial.arma == 8)
            {
                armat.text ="bomba bam "+manager.datosserial.marma8+"/25";
            }
            if(manager.datosserial.arma == 9)
            {
                armat.text ="zig zag bang "+manager.datosserial.marma9+"/50";
            }
            if(manager.datosserial.arma == 10)
            {
                armat.text ="mataobjetivos "+manager.datosserial.marma10+"/28";
            }
            if(manager.datosserial.arma == 11)
            {
                armat.text ="dispara plataformas "+manager.datosserial.marma11+"/3";
            }
            if(manager.datosserial.arma == 12)
            {
                armat.text ="gancho";
            }
            if(manager.datosserial.arma == 13)
            {
                armat.text ="dispara saltadores "+manager.datosserial.marma13+"/2";
            }
            if(manager.datosserial.arma == 14)
            {
                armat.text ="dispara aceleradores "+manager.datosserial.marma14+"/2";
            }
            if(manager.datosserial.arma == 15)
            {
                armat.text ="destructora_1.0 "+manager.datosserial.marma15+"/40";
            }
            if(manager.datosserial.armadura ==  0)
            {
                armadt.text = "";
            }
            if(manager.datosserial.armadura ==  1)
            {
                armadt.text = "casco de oxigeno";
            }
            if(manager.datosserial.armadura ==  2)
            {
                armadt.text = "proteccion al magma";
            }
            if(manager.datosserial.armadura ==  3)
            {
                armadt.text = "armadura de proteccion x2";
            }
            if(manager.datosserial.armadura ==  4)
            {
                armadt.text = "armadura de proteccion x3";
            }
            if(manager.datosserial.armadura ==  5)
            {
                armadt.text = "armadura antigravedad";
            }
            if(manager.datosserial.armadura ==  6)
            {
                armadt.text = "armadura de gravedad";
            }
            if(manager.datosserial.armadura ==  7)
            {
                armadt.text = "armadura jetpack";
            }
            if(manager.datosserial.armadura ==  8)
            {
                armadt.text = "guantes de fuerza x2";
            }
            if(manager.datosserial.armadura ==  9)
            {
                armadt.text = "guantes de fuerza x3";
            }
            if(manager.datosserial.armadura ==  10)
            {
                armadt.text = "guantes de escalada";
            }
        }
        if(manager.datosconfig.idioma == "en")
        {
            if(manager.datosserial.arma == 0)
            {
                armat.text ="";
            }
            if(manager.datosserial.arma == 1)
            {
                armat.text ="dad's gun "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 2)
            {
                armat.text ="mom gun "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 3)
            {
                armat.text ="shoot sticks 1/1";
            }
            if(manager.datosserial.arma == 4)
            {
                armat.text ="legacy weapon "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 5)
            {
                armat.text ="lure gun "+manager.datosserial.marma5+"/3";
            }
            if(manager.datosserial.arma == 6)
            {
                armat.text ="atomic shot "+manager.datosserial.marma6+"/10";
            }
            if(manager.datosserial.arma == 7)
            {
                armat.text ="machine gun "+manager.datosserial.marma7+"/300";
            }
            if(manager.datosserial.arma == 8)
            {
                armat.text ="bomb bam "+manager.datosserial.marma8+"/25";
            }
            if(manager.datosserial.arma == 9)
            {
                armat.text ="zig zag bang "+manager.datosserial.marma9+"/50";
            }
            if(manager.datosserial.arma == 10)
            {
                armat.text ="kill targets "+manager.datosserial.marma10+"/28";
            }
            if(manager.datosserial.arma == 11)
            {
                armat.text ="shoot floors "+manager.datosserial.marma11+"/3";
            }
            if(manager.datosserial.arma == 12)
            {
                armat.text ="hook";
            }
            if(manager.datosserial.arma == 13)
            {
                armat.text ="shoot jumpers "+manager.datosserial.marma13+"/2";
            }
            if(manager.datosserial.arma == 14)
            {
                armat.text ="shoot accelerators "+manager.datosserial.marma14+"/2";
            }
            if(manager.datosserial.arma == 15)
            {
                armat.text ="destroyer_1.0 "+manager.datosserial.marma15+"/40";
            }
            if(manager.datosserial.armadura ==  0)
            {
                armadt.text = "";
            }
            if(manager.datosserial.armadura ==  1)
            {
                armadt.text = "oxygen helmet";
            }
            if(manager.datosserial.armadura ==  2)
            {
                armadt.text = "magma protection";
            }
            if(manager.datosserial.armadura ==  3)
            {
                armadt.text = "protective armor x2";
            }
            if(manager.datosserial.armadura ==  4)
            {
                armadt.text = "protective armor x3";
            }
            if(manager.datosserial.armadura ==  5)
            {
                armadt.text = "antigravity armor";
            }
            if(manager.datosserial.armadura ==  6)
            {
                armadt.text = "gravity armor";
            }
            if(manager.datosserial.armadura ==  7)
            {
                armadt.text = "jetpack armor";
            }
            if(manager.datosserial.armadura ==  8)
            {
                armadt.text = "strength gloves x2";
            }
            if(manager.datosserial.armadura ==  9)
            {
                armadt.text = "strength gloves x3";
            }
            if(manager.datosserial.armadura ==  10)
            {
                armadt.text = "climbing gloves";
            }
        }
        if(manager.datosconfig.idioma == "cat")
        {
            if(manager.datosserial.arma == 0)
            {
                armat.text ="";
            }
            if(manager.datosserial.arma == 1)
            {
                armat.text ="arma d en pare "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 2)
            {
                armat.text ="arma d la mare "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 3)
            {
                armat.text ="dispara pals 1/1";
            }
            if(manager.datosserial.arma == 4)
            {
                armat.text ="arma del llegat "+manager.datosserial.marma1+"/200";
            }
            if(manager.datosserial.arma == 5)
            {
                armat.text ="arma distraccio "+manager.datosserial.marma5+"/3";
            }
            if(manager.datosserial.arma == 6)
            {
                armat.text ="dispar atomic "+manager.datosserial.marma6+"/10";
            }
            if(manager.datosserial.arma == 7)
            {
                armat.text ="metralla cosos "+manager.datosserial.marma7+"/300";
            }
            if(manager.datosserial.arma == 8)
            {
                armat.text ="bomba bam "+manager.datosserial.marma8+"/25";
            }
            if(manager.datosserial.arma == 9)
            {
                armat.text ="zig zag bang "+manager.datosserial.marma9+"/50";
            }
            if(manager.datosserial.arma == 10)
            {
                armat.text ="mataobjetius "+manager.datosserial.marma10+"/28";
            }
            if(manager.datosserial.arma == 11)
            {
                armat.text ="dispara plataformas "+manager.datosserial.marma11+"/3";
            }
            if(manager.datosserial.arma == 12)
            {
                armat.text ="ganxo";
            }
            if(manager.datosserial.arma == 13)
            {
                armat.text ="dispara saltadors "+manager.datosserial.marma13+"/2";
            }
            if(manager.datosserial.arma == 14)
            {
                armat.text ="dispara atceleradors "+manager.datosserial.marma14+"/2";
            }
            if(manager.datosserial.arma == 15)
            {
                armat.text ="destructora_1.0 "+manager.datosserial.marma15+"/40";
            }
            if(manager.datosserial.armadura ==  0)
            {
                armadt.text = "";
            }
            if(manager.datosserial.armadura ==  1)
            {
                armadt.text = "casc de oxigen";
            }
            if(manager.datosserial.armadura ==  2)
            {
                armadt.text = "proteccio al magma";
            }
            if(manager.datosserial.armadura ==  3)
            {
                armadt.text = "armadura de proteccio x2";
            }
            if(manager.datosserial.armadura ==  4)
            {
                armadt.text = "armadura de proteccio x3";
            }
            if(manager.datosserial.armadura ==  5)
            {
                armadt.text = "armadura antigravetat";
            }
            if(manager.datosserial.armadura ==  6)
            {
                armadt.text = "armadura de gravetat";
            }
            if(manager.datosserial.armadura ==  7)
            {
                armadt.text = "armadura jetpack";
            }
            if(manager.datosserial.armadura ==  8)
            {
                armadt.text = "guants de forca x2";
            }
            if(manager.datosserial.armadura ==  9)
            {
                armadt.text = "guants de forca x3";
            }
            if(manager.datosserial.armadura ==  10)
            {
                armadt.text = "guants de escalada";
            }
        }
        if (rtc> 0f && tiempodisp > 1 && manager.datosserial.arma == 1 && manager.datosserial.marma1 > 0 && tiendat == false)
                {

                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal, 4f);

                        disp.Play();

                        tiempodisp = 0;

                    manager.datosserial.marma1 -= 1;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 1 && manager.datosserial.arma == 2 && manager.datosserial.marma1 >= 2 && tiendat == false)
                {
                    
                        GameObject BalaTemporal1 = Instantiate(balaprefab2, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb1 = BalaTemporal1.GetComponent<Rigidbody>();

   
                        rb1.AddForce(Quaternion.AngleAxis(10,transform.up) * model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal1, 4f);

                        GameObject BalaTemporal2 = Instantiate(balaprefab2, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb2 = BalaTemporal2.GetComponent<Rigidbody>();

                        rb2.AddForce(Quaternion.AngleAxis(-10,transform.up) * model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal1, 4f);

                        disp.Play();

                        tiempodisp = 0;

                
                    manager.datosserial.marma1 -= 2;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 1 && manager.datosserial.arma == 3 && tiendat == false)
                {
                   
                        anim.SetBool("arma4",true);
                    
                    
                    
                }
                else{anim.SetBool("arma4",false);}
                if (rtc> 0f && tiempodisp > 1 && manager.datosserial.arma == 4 && manager.datosserial.marma1 >= 3 && tiendat == false)
                {
                    
                        GameObject BalaTemporal1 = Instantiate(balaprefab2, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb1 = BalaTemporal1.GetComponent<Rigidbody>();

   
                        rb1.AddForce(Quaternion.AngleAxis(10,transform.up) * model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal1, 4f);

                        GameObject BalaTemporal2 = Instantiate(balaprefab2, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb2 = BalaTemporal2.GetComponent<Rigidbody>();

                        rb2.AddForce(Quaternion.AngleAxis(-10,transform.up) * model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal1, 4f);

                        GameObject BalaTemporal3 = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal3.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal1, 4f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma1 -= 3;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 1 && manager.datosserial.arma == 5 && manager.datosserial.marma5 >= 1 && tiendat == false)
                {
                    
                        GameObject BalaTemporal1 = Instantiate(balaprefab3, pistola.transform.position - new Vector3(0,0.71f,0),transform.rotation) as GameObject;

                        Destroy(BalaTemporal1, 20f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma5 -= 1;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 2 && manager.datosserial.arma == 6 && manager.datosserial.marma6 >= 1 && tiendat == false)
                {
                    
                        GameObject BalaTemporal = Instantiate(balaprefab4, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 150 * balavel);

                        Destroy(BalaTemporal, 4f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma6 -= 1;
                    manager.guardar();
                    
                }
                 if (rtc> 0f && tiempodisp > 0.2 && manager.datosserial.arma == 7 && manager.datosserial.marma7 >= 1 && tiendat == false)
                {
                    
                        GameObject BalaTemporal = Instantiate(arma7prefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal, 4f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma7 -= 1;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 2 && manager.datosserial.arma == 8 && manager.datosserial.marma8 >= 1 && tiendat == false)
                {
                    
                        GameObject BalaTemporal = Instantiate(balaprefab5, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 50 * balavel);

                        Destroy(BalaTemporal, 3f);

                        disp.Play();

                        tiempodisp = 0;

                        
                
                    manager.datosserial.marma8 -= 1;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 0.3f && manager.datosserial.arma == 9 && manager.datosserial.marma9 >= 2 && tiendat == false)
                {
                    
                        GameObject BalaTemporal = Instantiate(balaprefab6, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 100 * balavel);

                        Destroy(BalaTemporal, 3f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma9 -= 2;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 0.3f && manager.datosserial.arma == 10&& manager.datosserial.marma10 >= 1 && tiendat == false)
                {
                    
                        GameObject BalaTemporal = Instantiate(balaprefab7, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(model.transform.forward * 50 * balavel);

                        Destroy(BalaTemporal, 5f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma10 -= 1;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 3f && manager.datosserial.arma == 11 && manager.datosserial.marma11 >= 1 && tiendat == false)
                {
                    GameObject BalaTemporal = Instantiate(balaprefab8, transform.position + new Vector3(0,-1,0),transform.rotation) as GameObject;

                    BalaTemporal.transform.SetParent(juegot);

                    Destroy(BalaTemporal, 7f);

                    disp.Play();

                    tiempodisp = 0;

                    
                    manager.datosserial.marma11 -= 1;
                    
                }
                if (rtc> 0f && manager.datosserial.arma == 12 && tiendat == false)
                {
                    
                        
                        if(objet != null)
                        
                        {
                            transform.position = Vector3.MoveTowards(transform.position,objet.transform.position,150 * Time.deltaTime);
                            camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,150 * Time.deltaTime);
                        }

                        disp.Play();

                        tiempodisp = 0;

                   
                    
                }
                if (rtc> 0f && tiempodisp > 3f && manager.datosserial.arma == 13 && manager.datosserial.marma13 >= 1 && tiendat == false)
                {
                   

                        GameObject BalaTemporal = Instantiate(balaprefab9, model.transform.position,transform.rotation) as GameObject;

                        Destroy(BalaTemporal, 7f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma13 -= 1;
                    manager.guardar();
                    
                }
                if (rtc> 0f && tiempodisp > 3f && manager.datosserial.arma == 14 && manager.datosserial.marma14 >= 1 && tiendat == false)
                {
                    
                        GameObject BalaTemporal = Instantiate(balaprefab10, model.transform.position ,transform.rotation) as GameObject;

                        Destroy(BalaTemporal, 10f);

                        disp.Play();

                        tiempodisp = 0;

                        
                
                    
                    manager.datosserial.marma14 -= 1;
                    manager.guardar();
                    
                }

                if (rtc> 0f && tiempodisp > 0.3f && manager.datosserial.arma == 15 && manager.datosserial.marma15 >= 1 && tiendat == false)
                {
                    

                        GameObject BalaTemporal1 = Instantiate(balaprefab4, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb1 = BalaTemporal1.GetComponent<Rigidbody>();

                        rb1.AddForce(model.transform.forward * 150 * balavel);

                        Destroy(BalaTemporal1, 4f);







                        GameObject BalaTemporal3 = Instantiate(balaprefab6, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb3 = BalaTemporal3.GetComponent<Rigidbody>();

                        rb3.AddForce(model.transform.forward * 100 * balavel);

                        Destroy(BalaTemporal3, 3f);



                        GameObject BalaTemporal4 = Instantiate(balaprefab7, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb4 = BalaTemporal4.GetComponent<Rigidbody>();

                        rb4.AddForce(model.transform.forward * 50 * balavel);

                        Destroy(BalaTemporal4, 5f);



                       GameObject BalaTemporal5 = Instantiate(balaprefab2, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb5 = BalaTemporal5.GetComponent<Rigidbody>();

   
                        rb5.AddForce(Quaternion.AngleAxis(10,transform.up) * model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal5, 4f);

                        GameObject BalaTemporal6 = Instantiate(balaprefab2, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb6 = BalaTemporal6.GetComponent<Rigidbody>();

                        rb6.AddForce(Quaternion.AngleAxis(-10,transform.up) * model.transform.forward * 110 * balavel);

                        Destroy(BalaTemporal6, 4f);

                        disp.Play();

                        tiempodisp = 0;

                        
                    
                    manager.datosserial.marma15 -= 1;
                    manager.guardar();
                    
                }
        }
        if(manager.juego == 1 && saltomuerte == false)
        {
            if(ltc == 0)
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

                
                
                if(tiendat == false)
                {
                rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
                rotationinput.y = rverticalc * rotspeed * Time.deltaTime;
                

                cameraverticalangle +=  rotationinput.y;
                cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
                
                transform.Rotate(Vector3.up * rotationinput.x);
                camara.transform.localRotation = Quaternion.RotateTowards(camara.transform.localRotation,Quaternion.Euler(-cameraverticalangle,transform.eulerAngles.y,0),180 * Time.deltaTime);

                camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,1 * Time.deltaTime);
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
            else if(ltc > 0)
            {
                if (lhorizontalc > 0f )
                {
                    _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
                    mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
                }
                if (lhorizontalc < 0f)
                {
                    _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
                    mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
                }
                if (lverticalc > 0f)
                {
                    _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
                    mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
                }
                if (lverticalc < 0f )
                {
                    _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * velocidad, _rb.velocity.y, lverticalc * velocidad));
                    mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
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
                anim.SetFloat("vely",lverticalc);

                rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
                rotationinput.y = rverticalc * rotspeed * Time.deltaTime;

                cameraverticalangle +=  rotationinput.y;
                cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
                
                transform.Rotate(Vector3.up * rotationinput.x);
                camara.transform.localRotation = Quaternion.RotateTowards(camara.transform.localRotation,Quaternion.Euler(-cameraverticalangle,transform.eulerAngles.y,0),180 * Time.deltaTime);

                camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,1 * Time.deltaTime);
            }
        }
        if(manager.juego == 2 && saltomuerte == false)
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
        if (manager.juego == 3 && this.dimensiion && saltomuerte == false)
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
		if (manager.juego == 3 && !this.dimensiion && saltomuerte == false)
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
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if (lhorizontalc < 0f)
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if (lverticalc > 0f)
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if (lverticalc < 0f )
            {
                _rb.velocity = transform.TransformDirection(new Vector3 (lhorizontalc * 100, lverticalc * 100,1 * velocidad));
            }
            if(lverticalc == 0f && lhorizontalc == 0f)
            {
                _rb.velocity = new Vector3 (0, 0, 1 * velocidad);
            }
            if(rtc> 0f && tiempodisp > 0.3f)
            {
                GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                rb.AddForce(transform.forward * 110 * balavel);

                Destroy(BalaTemporal, 4f);

                disp.Play();

                tiempodisp = 0;

                
            }

        }
        if(manager.juego == 5)
        {
			if (rtc > 0f)
			{
                pasosnave.UnPause();
				_rb.velocity = transform.TransformDirection(new Vector3 (0,_rb.velocity.y,1 * velocidad));
			}
			else if (ltc > 0f )
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (0,_rb.velocity.y,-1 * velocidad));
                pasosnave.UnPause();
			}
            else
			{
				_rb.velocity = transform.TransformDirection(new Vector3 (0,_rb.velocity.y,0));
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
				_rb.velocity = transform.TransformDirection(new Vector3 (0,0,1 * velocidad));
			}
            else
            {
            _rb.velocity = transform.TransformDirection(new Vector3 (0,0,0));
            pasosnave.Pause();
            }

			rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;
            
            transform.Rotate(Vector3.up * rotationinput.x);
			transform.Rotate(Vector3.left * rotationinput.y);
            
            if(rtc> 0f && tiempodisp > 1)
            {
                GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                rb.AddForce(transform.forward * 110 * balavel);

                Destroy(BalaTemporal, 4f);

                disp.Play();

                tiempodisp = 0;

                
            }
            camara.transform.localPosition = Vector3.MoveTowards(camara.transform.localPosition,new Vector3(0f,1.07000005f,-1.69700003f),1 * Time.deltaTime);
        }
        if (this.tiempovel >= 2)
		{
		    this.velocidad = this.velocidadaux;
            velact = false;
		}
        if(this.tiempovel >= 2 && suelo == true)
        {velocidad = velocidadmaxima;}
        if(vida <= 0)
        {
            muerte = true;
            vida = 0;
        }
        if(tempboton < 15)
        {tempboton += 1 * Time.deltaTime;}
        if(tempdano < 15)
        {tempdano += 1 * Time.deltaTime;}
        if(tiempodisp < 15)
        {tiempodisp += 1 * Time.deltaTime;}
        if(tiempovel < 15)
        {tiempovel += 1 * Time.deltaTime;}
        if(tempdanor < 15)
        {tempdanor += 1 * Time.deltaTime;}
        if(invulc >= -1)
        {invulc -= 1 * Time.deltaTime;}
        if (muerte == true)
        {

            manager.datosserial.alien3muere = 1;
            manager.guardar();
            SceneManager.LoadScene("carga_al3");
        }

        if (pausac > 0 && temp9 > 0.5f && tiendat == false )
		{
			pausa1.SetActive(true);
			pausac = 0;
			temp9 = 0;
			juego.SetActive(false);
			Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
            if(manager.juego != 4 && manager.juego != 6)
            {
            anim.SetBool("jetpack1",false);
            }
		}
        if(temp9 < 15)
        {temp9 += 1 * Time.deltaTime;}
        if(temp10 < 30)
        {temp10 += 1 * Time.deltaTime;}
        if(temp10 > 4f)
        {atksb = false;}
        if(temppocion1 > 0)
        {
            temppocion1 -= 1 * Time.deltaTime;
        }
        if(temppocion2 > 0)
        {
            temppocion2 -= 1 * Time.deltaTime;
        }
        
        
    }

    
    public void velozidad()
	{
		tiempovel = 0f;
	}
    private void OnCollisionEnter(Collision col)
	{
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if (col.gameObject.tag == "suelo" || col.gameObject.tag == "nave")
		{
            anim.SetBool("jetpack1",false);
			saltop = true;
            jumpforce = jumpforcebase;
            suelo = true;
            salto2 = false;
            barravuelo = 0;
            volador = false;
		}
        if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}
        if (col.gameObject.tag == "lava")
		{
            anim.SetBool("jetpack1",false);
			saltop = true;
            jumpforce = jumpforcebase;
            suelo = true;
            salto2 = false;
            barravuelo = 0;
            volador = false;
            if(atksb == false)
            {tempdano = 4;lavaaux = true;}
            else{tempdano = 0;atksb = false;}
		}
        if (col.gameObject.tag == "boton")
		{
            
            blanco = 5;
            platx = col.gameObject.GetComponent<boton_al3>().platx;
            platy = col.gameObject.GetComponent<boton_al3>().platy;
            platz = col.gameObject.GetComponent<boton_al3>().platz;
            saltop = true;
            jumpforce = jumpforcebase;
            suelo = true;
            salto2 = false;
            barravuelo = 0;
            volador = false;
		}
        if (col.gameObject.tag == "boton" || col.gameObject.tag == "control")
        {
			saltop = true;
            jumpforce = jumpforcebase;
            suelo = true;
        }
        

	}
    private void OnCollisionStay(Collision col)
	{
        if (col.gameObject.tag == "suelo")
		{
            suelo = true;
            barravuelo = 0;
            volador = false;
		}
        if (col.gameObject.tag == "lava")
		{
            lavaaux = true;
		}
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "boton" || col.gameObject.tag == "escalar" || col.gameObject.tag == "control")
        {
            anim.SetBool("salto",false);
        }
	}
    private void OnCollisionExit(Collision col)
	{
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();

		if (col.gameObject.tag == "suelo")
        {
            suelo = false;
        }
        if (col.gameObject.tag == "control")
		{
			control = false;
		}
        if (col.gameObject.tag == "escalar")
		{
			escalar = false;
		}
        if (col.gameObject.tag == "lava")
		{
            
            lavaaux = false;
		}
        if (col.gameObject.tag == "boton")
		{
            
            blanco = 0;
		}
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "boton" || col.gameObject.tag == "escalar" || col.gameObject.tag == "control")
		{
			suelo = false;
			anim.SetBool("salto",true);
		}
        if (col.gameObject.tag == "boton" || col.gameObject.tag == "control")
        {
            suelo = false;
        }
        

	}
    private void OnTriggerEnter(Collider col)
	{
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        if (col.gameObject.tag == "escalar")
		{
			escalar = true;
		}
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
        if (col.gameObject.tag == "gas")
		{
			gas = true;
		}
        if (col.gameObject.tag == "antigas")
		{
			antigas = true;
		}
        if (col.gameObject.tag == "tiendat")
		{
			tiendat = true;
            tiendag.SetActive(true);
            Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
		}
        if (col.gameObject.tag == "gancho")
		{
			objet = col.gameObject;
		}
        if (col.gameObject.tag == "dañox2" && tempdanor > 0.8f)
		{
            audio2.Play();
            if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 2f / proteccion;}
            else{vida = vida - 2f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox5"  && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 5f / proteccion;}
            else{vida = vida - 5f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox10"  && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 10f / proteccion;}
            else{vida = vida - 10f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox20"  && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 20f / proteccion;}
            else{vida = vida - 20f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox30"  && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 30f / proteccion;}
            else{vida = vida - 30f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox40"  && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 40f / proteccion;}
            else{vida = vida - 40f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox50"  && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 50f / proteccion;}
            else{vida = vida - 50f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "dañox100" && tempdanor > 0.8f)
		{
            audio2.Play();
			if(manager.juego == 1 || manager.juego == 2 || manager.juego == 3)
			{vida = vida - 100f / proteccion;}
            else{vida = vida - 100f;}
            tempdanor = 0;
		}
        if (col.gameObject.tag == "lava")
		{
            
            
		}
        if (col.gameObject.tag == "nave")
		{
            blanco = 1;
		}
        if (col.gameObject.tag == "teleport")
		{
            blanco = 2;
		}
        if (col.gameObject.tag == "tpgemas")
		{
            blanco = 2;
		}
        if (col.gameObject.tag == "enemigodet")
		{
            col.gameObject.AddComponent<Rigidbody>();
            col.GetComponent<Rigidbody>().useGravity = false;
		}
        if (col.gameObject.tag == "planetas")
		{
            
            blanco = 4;
		}

	}
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "escalar")
		{
			escalar = false;
		}
        if (col.gameObject.tag == "control")
		{
			control = false;
		}
        if (col.gameObject.tag == "gas")
		{
			gas = false;
		}
        if (col.gameObject.tag == "antigas")
		{
			antigas = false;
		}
        if (col.gameObject.tag == "tiendat")
		{
            tienda_al3 tienda = UnityEngine.Object.FindObjectOfType<tienda_al3>();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
			tiendat = false;
            tienda.salir_();
		}
        if (col.gameObject.tag == "gancho")
		{
			objet = null;
		}
        if (col.gameObject.tag == "lava")
		{
            
            lavaaux = false;
		}
        if (col.gameObject.tag == "nave")
		{
            blanco = 0;
		}
        if (col.gameObject.tag == "teleport")
		{
            blanco = 0;
		}
        if (col.gameObject.tag == "tpgemas")
		{
            blanco = 0;
		}
        if (col.gameObject.tag == "planetas")
		{
            
            blanco = 3;
		}
        if (col.gameObject.tag == "boton")
		{
            
            blanco = 0;
		}

	}
    private void OnTriggerStay(Collider col)
	{
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();

        if (col.gameObject.tag == "gas")
		{
			gas = true;
		}
        if (col.gameObject.tag == "antigas")
		{
			antigas = true;
		}
        if (col.gameObject.tag == "vidarec")
		{
			vida = manager.datosserial.vidamaxima;
		}
	}
}
