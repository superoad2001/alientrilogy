using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bossencorbado_al1: MonoBehaviour
{
    public bool detectar;
    public bool tutorial;
    public AudioSource muertes;
    public GameObject explosion;
    public GameObject niebla; 
    public int lado = 1;
    public float temp3;
    public RigidbodyConstraints originalConstraints;
    public float temptp;
    public int tprandom;
    public int nivel = 1;
    public float templado;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Animator anim;
    public float temp;
    public float temp2;
    public bool plat;
    public float vida = 4;
    public int enemigo = 1;
    public int enemigo3;
    public AudioSource disp;
    public GameObject balaprefab;
    public GameObject balaprefab2;
    public GameObject balaprefab3;
    public GameObject balaprefab4;
    public GameObject pistola;
    public float tempe3;
    public float tempgolpe;
    public float balafrec = 1.5f;
    public Rigidbody rb_;
    public int jefe = 0;
    public int jefe1_p = 1;
    public bool jefe1_act1 = false;
    public bool jefe1_act2 = false;
    public bool gigante;
    public Text cuentavidas;
    public Image vidab;
    public Image vidab2;
    public float vidaux;
    public float vel = 2;
    public bool desactivar;
    public GameObject moneda;
    public Transform juego;
    public manager_al1 manager;
    public jugador_al1 jugador1;
    public GameObject muertesaudio;
    public AudioSource danoene;
    public float vidamax;
    public Text vidat;
    public GameObject slash;
    public GameObject palo;
    private Controles controles;
    public int nivelactual = 1;
    public float valorexp = 10f;
    public float vidabasetut = 99;
    public float vidabase = 999;
    public float vidabasemax = 9999;
    public float vidaplusmax = 99999;

    public float fuebasetut = 1;
    public float fuebase = 10;
    public float fuebasemax = 100;
    public float fueplusmax = 2000;
    public float vidaUI;
    
    public float nivelfuerza;
    public float nivelvida;
    public float []nivelfuerza_a = new float[100];
    public float []nivelvida_a = new float[100];
    public Text niveltxt;
    private golpe_al1 paloSC;
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
    // Start is called before the first frame update
    void Start()
    {
        vidaUI = vida;
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

        nivelfuerza = nivelfuerza_a[nivelactual-1];
        nivelvida = nivelvida_a[nivelactual-1];
        vidamax = nivelvida;
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        juego = GameObject.Find("juego").transform;
        paloSC = palo.GetComponent<golpe_al1>();
    }
    public void rbf()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        niveltxt.text = nivelactual.ToString();
        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        if(tempgolpe < 15)
        {tempgolpe += 1 * Time.deltaTime;}
        
        vidab.fillAmount = vidaUI/vidamax;
        vidat.text = string.Concat((int)vida,"/",(int)vidamax);
        if(vida < 1)
        {
            GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            muertes.Play();

            if(nivelactual == manager.datosserial.niveljug)
            {
                manager.datosserial.nivelexp += valorexp;
            }
            else if(nivelactual < manager.datosserial.niveljug && nivelactual  >= (manager.datosserial.niveljug -10))
            {
                int diferencianivel = manager.datosserial.niveljug - nivelactual;
                manager.datosserial.nivelexp += (valorexp / (((diferencianivel) + 1)/2));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  <= (manager.datosserial.niveljug + 10))
            {
                int diferencianivel =  nivelactual - manager.datosserial.niveljug ;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  > (manager.datosserial.niveljug + 10))
            {
                int diferencianivel =  10;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
             if(manager.datosserial.nivelexp >= manager.datosserial.signivelexp && manager.datosserial.niveljug < 50 )
            {
                manager.datosserial.nivelexp = 0;
                manager.datosserial.niveljug++;
                manager.datosserial.signivelexp += 7;
                jugador1.subirnivel();
            }
            else if(manager.datosserial.nivelexp >= manager.datosserial.signivelexp && manager.datosserial.niveljug < 100 && manager.datosserial.niveljug >= 2 && manager.datosserial.newgameplus1 == true)
            {
                manager.datosserial.nivelexp = 0;
                manager.datosserial.niveljug++;
                manager.datosserial.signivelexp += 7;
                jugador1.subirnivel();
            }

            manager.datosserial.aliensderrotados++;
            manager.guardar();
            Destroy(transform.parent.gameObject);
            
        }
        if(detectar == false && manager.controlene == true)
        {
            detectar = true;
        }
        if(detectar == true && desactivar == false && manager.controlene == true)
        {
            anim.SetBool("atk",false);
            anim.SetBool("arma4",false);
            anim.SetBool("encatk1",false);
            if(enemigo3 == 1)
            {
                if(temp > 1f)
                {
                if(gigante == false)
                {anim.SetBool("atk",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
                paloSC.dano =  ((nivelfuerza / 2) * 1) + nivelfuerza;
                paloSC.toquespalo = 5;
                GameObject slasht = Instantiate(slash, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;
                slasht.transform.SetParent(transform);
				Destroy(slasht,1f);
                }
                else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position+ new Vector3(0,0,-4),vel * 1.1f * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
                {
                    
                }
                else if(transform.position.z != objetivo.transform.position.z + -3)
                {
                    anim.SetFloat("vely",1);
                }
                else
                {
                    anim.SetFloat("vely",0);
                }
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 10f)
                {
                    enemigo3 = Random.Range(1,8);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 2 || enemigo3 == 3)
            {
                if(temp > 1f)
            {
                paloSC.toquespalo = 1;
                anim.SetBool("arma4",true);
                temp = 0;
                paloSC.dano =  ((nivelfuerza / 2) * 1) + nivelfuerza;
            }
            else{
                anim.SetBool("arma4",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position+ new Vector3(0,0,-4),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
                {
                    
                }
                else if(transform.position.z != objetivo.transform.position.z)
                {
                    anim.SetFloat("vely",1);
                }
                else
                {
                    anim.SetFloat("vely",0);
                }
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 6f)
                {
                    enemigo3 = Random.Range(1,8);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 4 || enemigo3 == 5)
            {
                if(temp > 3f)
            {
                paloSC.toquespalo = 2;
                rb_ = this.GetComponent<Rigidbody>();
                anim.SetBool("encatk1",true);
                paloSC.dano =  ((nivelfuerza / 2) * 2) + nivelfuerza;
                this.rb_.AddForce(3000 * transform.TransformDirection(new Vector3 (0,0,1)));
                temp = 0;
            }
            else{
                anim.SetBool("encatk1",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position+ new Vector3(0,0,-4),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
                {
                    
                }
                else if(transform.position.z != objetivo.transform.position.z)
                {
                    anim.SetFloat("vely",1);
                }
                else
                {
                    anim.SetFloat("vely",0);
                }
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;

                if (tempe3 > 10f)
                {
                    enemigo3 = Random.Range(1,8);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 6)
            {
                if(temp > 5f)
                {
                    GameObject enemigotemp = Instantiate(balaprefab,transform.position + new Vector3(5,0,0),transform.rotation) as GameObject;
                    enemigotemp.transform.SetParent(juego);
                    enemigotemp.transform.Find("enemigo").GetComponent<enemigo2_al1>().muertetemp = true;

                    GameObject enemigotemp2 = Instantiate(balaprefab2,transform.position + new Vector3(-5,0,0),transform.rotation) as GameObject;
                    enemigotemp2.transform.SetParent(juego);
                    enemigotemp2.transform.Find("enemigo").GetComponent<enemigo2_al1>().muertetemp = true;

                    GameObject enemigotemp3 = Instantiate(balaprefab3,transform.position + new Vector3(0,0,5),transform.rotation) as GameObject;
                    enemigotemp3.transform.SetParent(juego);
                    enemigotemp3.transform.Find("enemigo").GetComponent<enemigo2_al1>().muertetemp = true;

                    if(tutorial)
                    {
                        enemigotemp.transform.Find("enemigo").GetComponent<enemigo2_al1>().enemigostut = true;
                        enemigotemp2.transform.Find("enemigo").GetComponent<enemigo2_al1>().enemigostut = true;
                        enemigotemp3.transform.Find("enemigo").GetComponent<enemigo2_al1>().enemigostut = true;
                    }

                    temp = 0;
                    temp2 = 0;
                    niebla.SetActive(true);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position+ new Vector3(0,0,-4f),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;

                if (tempe3 > 6f)
                {
                    enemigo3 = Random.Range(1,8);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 7)
            {
                if(temp > 1.5f)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab4,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                            BalaTemporal.transform.SetParent(juego);
                            
                            BalaTemporal.GetComponent<romperbala_al1>().danoj =  ((nivelfuerza / 2) * 2) + nivelfuerza;

                            rb.AddForce(transform.forward * 110 * 7);

                            BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                            Destroy(BalaTemporal, 3f);

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z - 4f) ,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
                {
                    
                }
                else if(transform.position.z != objetivo.transform.position.z)
                {
                    anim.SetFloat("vely",1);
                }
                else
                {
                    anim.SetFloat("vely",0);
                }
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 7f)
                {
                    enemigo3 = Random.Range(1,8);
                    tempe3 = 0;
                }
            }
            tempe3 += 1 * Time.deltaTime;
            temp2 += 1 * Time.deltaTime;
            
            if(temp3 > 5) 
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                temp3 += 1 * Time.deltaTime;
            }
            if(temp2 > 1.4f)
            {
                niebla.SetActive(false);
            } 
        
        
    }
}

     private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0)
		{
            jugador1.toquespalo--;
            vida -= col.gameObject.GetComponent<golpe_al1>().dano;
            danoene.Play();    
		}
        if (col.gameObject.tag == "armajug")
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 1)
                {
                    romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
                    jugador1.muertesjug.Stop();
                    vida -= balajug.danoj;
                    danoene.Play();
                }
            }
            
		}
        if (col.gameObject.tag == "armajug")
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 2)
                {
                    detectar = false;
                }
            }
            
		}
	}
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "armajug")
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 2)
                {
                    detectar = false;
                }
            }
            
		}
	}
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "armajug")
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 3)
                {
                    romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
                    jugador1.muertesjug.Stop();
                    vida -= balajug.danoj;
                    danoene.Play();
                }
            }
            
		}
        if (col.gameObject.tag == "armajug")
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 2)
                {
                    romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
                    jugador1.muertesjug.Stop();
                    vida -= balajug.danoj;
                    danoene.Play();
                    detectar = false;
                }
            }
            
        }
    }
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "respawn")
		{
			vida = 0;
            muertes.Play();
		}
        
    }
}
