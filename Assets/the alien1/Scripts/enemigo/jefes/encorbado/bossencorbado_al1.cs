using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bossencorbado_al1: MonoBehaviour
{
    public bool detectar;
    public AudioSource muertes;
    public GameObject explosion;
    public int lado = 1;
    public float temptp;
    public int tprandom;
    public float templado;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Animator anim;
    public float temp;
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
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        juego = GameObject.Find("juego").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        if(tempgolpe < 15)
        {tempgolpe += 1 * Time.deltaTime;}
        
        vidab.fillAmount = vida/vidaux;
        vidat.text = vida+"/"+vidamax;
        if(vida <= 0)
        {
            GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            muertes.Play();
            manager.datosserial.asesinatos++;
            manager.guardar();
            Destroy(transform.parent.gameObject);
            
        }
        if(detectar == true && desactivar == false)
        {
            anim.SetBool("atk",false);
            anim.SetBool("arma4",false);
            anim.SetBool("encatk1",false);
            if(enemigo3 == 1)
            {
                if(temp > 3f)
                {
                if(gigante == false)
                {anim.SetBool("atk",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
                palo.GetComponent<golpe_al1>().dano = 5;
                GameObject slasht = Instantiate(slash, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;
                slasht.transform.SetParent(transform);
				Destroy(slasht,1f);
                }
                else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position+ new Vector3(0,0,-4),vel * Time.deltaTime);
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
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 2)
            {
                if(temp > 3f)
            {
                if(gigante == false)
                {anim.SetBool("arma4",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
                palo.GetComponent<golpe_al1>().dano = 5;
            }
            else{
                anim.SetBool("arma4",false);
                anim.SetBool("atkg",false);
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
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 3 || enemigo3 == 4)
            {
                if(temp > 5f)
            {
                rb_ = this.GetComponent<Rigidbody>();
                anim.SetBool("encatk1",true);
                palo.GetComponent<golpe_al1>().dano = 5;
                this.rb_.AddForce(1000 * transform.TransformDirection(new Vector3 (0,0,1)));
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
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 5)
            {
                if(temp > 5f)
                {
                    GameObject enemigotemp = Instantiate(balaprefab,transform.position + new Vector3(5,0,0),transform.rotation) as GameObject;
                    enemigotemp.transform.SetParent(juego);
                    Destroy(enemigotemp, 45f);
                    GameObject enemigotemp2 = Instantiate(balaprefab2,transform.position + new Vector3(-5,0,0),transform.rotation) as GameObject;
                    enemigotemp2.transform.SetParent(juego);
                    Destroy(enemigotemp2, 45f);
                    GameObject enemigotemp3 = Instantiate(balaprefab3,transform.position + new Vector3(0,0,5),transform.rotation) as GameObject;
                    enemigotemp3.transform.SetParent(juego);
                    Destroy(enemigotemp3, 45f);
                    temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position+ new Vector3(0,0,-4f),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;

                if (tempe3 > 6f)
                {
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 6)
            {
                if(temp > 6)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab4,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                            BalaTemporal.transform.SetParent(juego);
                            
                            BalaTemporal.GetComponent<romperbala_al1>().danoj = 12f;

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
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            tempe3 += 1 * Time.deltaTime;
        
        
    }
    detectar = true;
}

     private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh")
		{
            vida -= col.gameObject.GetComponent<golpe_al1>().dano;
            danoene.Play();    
		}
        if (col.gameObject.tag == "danoarma8")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            danoene.Play();
		}
        if (col.gameObject.tag == "danoarma9")
		{
            detectar = false;
		}
	}
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "danoarma9")
		{
            detectar = false;
		}
	}
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "danoarma10")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            danoene.Play();
		}
         if (col.gameObject.tag == "danoarma9")
		{
            detectar = true;
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
