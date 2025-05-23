using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo3_al1: MonoBehaviour
{
	public manager_al1 manager;
    public bool detectar;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    private Controles controles;
    public float vel = 2;
    public bool desactivar;
    public enemigodet3_al1 enemigodet;
    public GameObject dano;
    public GameObject det;
    public float temp;
    public Animator anim;
    public GameObject explosion;
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
    public float vidaUI;
    public float vidamax;
    public Image vidab;

    public int nivel = 1;

    public AudioSource danoene;
    public AudioSource danoescudo;
    public GameObject vidamenu;

    public GameObject escudovis;
    public bool escudoact;
    public float tempescudo;
    public float danoj = 8;
    public float vidaescudo;
    public float vidaescudomax = 10;
    public float vidaescudoUI;
    public GameObject target;
    
    public float nivelfuerza;
    public float nivelvida;
    public int nivelactual = 1;

    public float valorexp = 2f;
    public float vidabasetut = 9;
    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;

    public float fuebasetut = 3;
    public float fuebase = 30;
    public float fuebasemax = 300;
    public float fueplusmax = 4000;

    public float escudovida_noplus = 30;
    public float escudovida_plus = 100;

    public bool new_game_plus;


    public float []nivelfuerza_a = new float[100];
    public float []nivelvida_a = new float[100];

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
        vidaescudoUI = vidaescudo;
        vidaUI = vida;
        if(new_game_plus == true)
        {
            vidaescudomax = escudovida_plus;
        }  
        else
        {
            vidaescudomax = escudovida_noplus;
        }
        nivelvida_a[0] = vidabasetut;
        vidaescudo = vidaescudomax;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelvida_a[i] = (vidabase) + (((vidabasemax-vidabase)/48) * (i -1 ));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            nivelvida_a[i] = (vidabasemax) + (((vidaplusmax - vidabasemax)/50) * (i -49));
        }

        nivelfuerza_a[0] = fuebasetut;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelfuerza_a[i] = (fuebase) + (((fuebasemax-fuebase)/48) * (i - 2));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            nivelfuerza_a[i] = (fuebasemax+0.5f) + (((fueplusmax -fuebasemax+0.5f)/50) * (i - 49));
        }

        nivelfuerza = nivelfuerza_a[nivelactual-1];
        nivelvida = nivelvida_a[nivelactual-1];
        vidamax = nivelvida;



        danoj = nivelfuerza;
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
        vidaescudoUI = Mathf.Lerp(vidaescudoUI, vidaescudo, Time.deltaTime * 2f);
        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);
        if(jugador1.objetivotarget == transform.gameObject)
        {
            target.SetActive(true);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = true;
            jugador1.vidaeneui = vidaUI;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene = vidaescudoUI;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else
        {
            target.SetActive(false);
        }

        det.transform.position = this.transform.position;
        
        if (vida < 1)
        {
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
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
            manager.datosserial.asesinatos++;
            manager.guardar();
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            Destroy(transform.parent.gameObject);

        }
        if (vidaescudo <= 0)
        {
            escudovis.SetActive(false);
            escudoact = false;
            if(tempescudo >= 5)
            {
                escudovis.SetActive(true);
                tempescudo = 0;
                escudoact = true;
                vidaescudo = vidaescudomax;
            }
            tempescudo += 1 * Time.deltaTime;

        }
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        if(detectar == true  && desactivar == false && manager.controlene == true)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj;

                        rb.AddForce(transform.forward * 110 * 5);

                        BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                        disp.Play();

                        temp = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,-5,-15),vel * Time.deltaTime);
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
        
        
    }
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "danoarma9")
		{
            detectar = false;
		}
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0 && escudoact == false)
		{
            jugador1.toquespalo--;
            vida -= col.gameObject.GetComponent<golpe_al1>().dano;
            jugador1.escudoeneact = true;
            danoene.Play();
            jugador1.vidaeneact = true;
            
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene = vidaescudo;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.niveleneui.text = nivelactual.ToString();
            
		}
        if (col.gameObject.tag == "danoarma8" && escudoact == true)
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            
            vidaescudo -= 10;
            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene = vidaescudo;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo <= 0)
            {
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            }
		}
        if (col.gameObject.tag == "danoarma9" )
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
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "danoarma10" && escudoact == true)
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vidaescudo -= 300;
            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene = vidaescudo;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo <= 0)
            {
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            }
		}
        if (col.gameObject.tag == "danoarma9" && escudoact == true)
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vidaescudo -= 150;
            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene = vidaescudo;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo <= 0)
            {
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            }
        }
        
        
    }
}
