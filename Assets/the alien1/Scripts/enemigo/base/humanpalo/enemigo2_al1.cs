using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo2_al1: MonoBehaviour
{
    public GameObject slash;
	public manager_al1 manager;
    public bool detectar;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public enemigodet2_al1 enemigodet;
    public GameObject dano;
    public GameObject det;
    public float temp;
    public Animator anim;
    public GameObject explosion;
    public int nivel = 1;
    public jugador_al1 jugador1;
    public AudioSource muertes;
    public int enemigo = 1;
    public float balafrec = 1.5f;
    public int enemigo3;
    public GameObject balaprefab;
    public AudioSource disp;
    public Transform juego;
    public GameObject pistola;
    public float tempe3;
    public float vida;
    public float vidamax;
    public Image vidab;
    public int nivelactual = 1;

    public float valorexp = 1.2f;
    public float vidabasetut = 9;
    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;

    public float fuebasetut = 1;
    public float fuebase = 10;
    public float fuebasemax = 100;
    public float fueplusmax = 2000;


    public AudioSource danoene;
    public GameObject vidamenu;

    public float danoj = 5;
    public float danoj2 = 5;
    public GameObject target;
    public GameObject palo;
    private Controles controles;

    public float nivelfuerza;
    public float nivelvida;

    public float []nivelfuerza_a = new float[99];
    public float []nivelvida_a = new float[99];
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

        nivelvida_a[0] = vidabasetut;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelvida_a[i] = (vidabase) + (((vidabasemax-vidabase)/48) * (i -1 ));
        }
        for(int i = 50 ; i <= 98; i++)
        {   
            nivelvida_a[i] = (vidabasemax+51) + (((vidaplusmax - vidabasemax+51)/49) * (i - 49));
        }

        nivelfuerza_a[0] = fuebasetut;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelfuerza_a[i] = (fuebase) + (((fuebasemax-fuebase)/48) * (i - 2));
        }
        for(int i = 50 ; i <= 98; i++)
        {   
            nivelfuerza_a[i] = (fuebasemax+0.5f) + (((fueplusmax -fuebasemax+0.5f)/49) * (i - 49));
        }

        nivelfuerza = nivelfuerza_a[nivelactual-1];
        nivelvida = nivelvida_a[nivelactual-1];
        vidamax = nivelvida;

        danoj = nivelfuerza/2;
        danoj2 = nivelfuerza;
        
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");
        juego = GameObject.Find("juego").transform;
    }

    // Update is called once per frame
    void Update()
    {


        if(jugador1.objetivotarget == transform.parent.gameObject)
        {
            target.SetActive(true);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
        }
        else
        {
            target.SetActive(false);
        }
        det.transform.position = this.transform.position;
        dano.transform.position = this.transform.position;
        target.transform.position = new Vector3(transform.position.x,transform.position.y + -0.37f,transform.position.z);
        
        if (vida < 1)
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
            if(manager.datosserial.nivelexp >= manager.datosserial.signivelexp)
            {
                manager.datosserial.nivelexp = 0;
                manager.datosserial.niveljug++;
                manager.datosserial.signivelexp += 7;
                jugador1.subirnivel();
            }
            manager.datosserial.asesinatos++;
            manager.guardar();
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            Destroy(transform.parent.gameObject);

        }
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        if(detectar == true && desactivar == false && enemigo == 1 && manager.controlene == true)
        {
            if(temp > 3f)
            {
                GameObject slasht = Instantiate(slash, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;
                slasht.transform.SetParent(transform);
				Destroy(slasht,1f);
                anim.SetBool("atk",true);
                temp = 0;
                palo.GetComponent<golpe_al1>().dano = danoj2;
            }
            else
            {
                anim.SetBool("atk",false);
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
            temp += 1 * Time.deltaTime;
        }
        if(detectar == true && enemigo == 2 && desactivar == false && manager.controlene == true)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj;

                        rb.AddForce(BalaTemporal.transform.forward * 110 * 20);

                        BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                        disp.Play();

                        temp = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-15),vel * Time.deltaTime);
            if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
            {
                
            }
            else if(transform.position.z != objetivo.transform.position.z+ -15)
            {
                anim.SetFloat("vely",1);
            }
            else
            {
                anim.SetFloat("vely",0);
            }
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
            temp += 1 * Time.deltaTime;
        }
        if(detectar == true && enemigo == 3 && desactivar == false && manager.controlene == true)
        {
            if(enemigo3 == 1)
            {
            if(temp > 3f)
            {
                GameObject slasht = Instantiate(slash, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;
                slasht.transform.SetParent(transform);
				Destroy(slasht,1f);
                anim.SetBool("atk",true);
                temp = 0;
                palo.GetComponent<golpe_al1>().dano = danoj2;
            }
            else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
            {
                
            }
            else if(transform.position.z != objetivo.transform.position.z+ -3)
                {
                    anim.SetFloat("vely",1);
                }
                else
                {
                    anim.SetFloat("vely",0);
                }
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
            }
            if(enemigo3 == 2)
            {
                if(temp > balafrec)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                            BalaTemporal.transform.SetParent(juego);

                            BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj;

                            rb.AddForce(BalaTemporal.transform.forward * 110 * 20);

                            BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-15),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
            {
                
            }
            else if(transform.position.z != objetivo.transform.position.z+ -15)
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
            }
            if (tempe3 > 10f)
            {
                enemigo3 = Random.Range(1,3);
                tempe3 = 0;
            }
            tempe3 += 1 * Time.deltaTime;
        }
        
        
    }
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "danoarma10")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            danoene.Play();
		}
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh")
		{
            vida -= jugador1.danoarma;
            danoene.Play();
            jugador1.vidaeneact = true;
            
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaenebarra.SetActive(true);
            
		}
        if (col.gameObject.tag == "danoarma8")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
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
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "respawn")
		{
            muertes.Play();
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
			Destroy(transform.parent.gameObject);
		}
        
    }
}
