using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1_al1: MonoBehaviour
{
	public manager_al1 manager;
    public bool detectar;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public GameObject escudoin;
    public bool destobj;
    public GameObject destruible;
    public GameObject moneda;
    public int nivel = 1;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public float temprb;
    public enemigodet_al1 enemigodet;
    public Animator anim;
    public float gravityForce = 5f;
    public float raycastDistance = 1f;
    public LayerMask groundLayer;

    private bool isGrounded = false;

    public float vida;
    public float vidamax;
    public Image vidab;

    public float danoj = 3;
    public GameObject dano;
    public GameObject det;
    public GameObject explosion;
    public jugador_al1 jugador1;
    public AudioSource muertes;
    public AudioSource danoene;

    public GameObject vidamenu;
    public int tutorial;

    public GameObject target;
    public float valorexp = 1f;
    public float vidabasetut = 9;
    public float []vidabase = new float[4];
    public float []vidabasemax = new float[4];
    public float []vidaplusmax = new float[4];
    public int tamano;
    public int nivelactual = 1;

    public float fuebasetut = 1.5f;
    public float fuebase = 15;
    public float fuebasemax = 150;
    public float fueplusmax = 3000;
    public float nivelfuerza;
    public float nivelvida;
    public float []nivelfuerza_a = new float[100];
    public float []nivelvida_a = new float[100];
    public tutorialbase_al1 eventotut;

    public GameObject big;
    public GameObject med;
    public GameObject peque; 
    public float vidaUI;
    private Vector3 []objetivoa = new Vector3[4]; 
    private Vector3 objetivon;

    public bool vidapisar;  
    public float valorexppisado;
    // Start is called before the first frame update
    void Start()
    {
        objetivoa[0] = transform.position + new Vector3(0,0,-5);
        objetivoa[1] = transform.position + new Vector3(0,0,5);
        objetivoa[2] = transform.position + new Vector3(-5,0,0);
        objetivoa[3] = transform.position + new Vector3(5,0,0);
        objetivon = objetivoa[Random.Range(0,4)];
        if(GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            rb_ = GetComponent<Rigidbody>();
        }
        vidabase[0] = 9;
        vidabasemax[0] = 300;
        vidaplusmax[0] = 999;
        vidabase[1] = 99;
        vidabasemax[1] = 500;
        vidaplusmax[1] = 9999;
        vidabase[2] = 99;
        vidabasemax[2] = 700;
        vidaplusmax[2] = 9999;
        vidabase[3] = 99;
        vidabasemax[3] = 999;
        vidaplusmax[3] = 9999;



        nivelvida_a[0] = vidabasetut;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            nivelvida_a[i] = (vidabase[tamano]) + (((vidabasemax[tamano]-vidabase[tamano])/48) * (i -1 ));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            nivelvida_a[i] = (vidabasemax[tamano]) + (((vidaplusmax[tamano] - vidabasemax[tamano])/50) * (i - 49));
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

        danoj = nivelfuerza;

        vidamax = nivelvida;
        vida = vidamax;
        vidaUI = vida;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        vidamenu = GameObject.Find("barravidaenemigobase");
    }
    public void Awake()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
    }
    // Update is called once per frame
    void Update()
    {
        if(detectar == false)
        {
            escudoin.SetActive(true);
        }
        else
        {
        	escudoin.SetActive(false);
        }

        if (temprb > 0f)
        {
            temprb -= Time.deltaTime;
        }
        else{temprb = 0f;}

        if (temprb == 0f)
        {
            
        }
        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);
        if(jugador1.objetivotarget == transform.gameObject && detectar == true)
        {
            jugador1.escudoeneact = false;
            target.SetActive(true);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else
        {
            target.SetActive(false);
        }
        if (vida < 1 && tutorial == 0 && vidapisar == true && temprb == 0)
        {
            if(manager.juego == 3 || manager.juego == 4 )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = this.gameObject.transform.localScale;
            if(nivelactual == manager.datosserial.niveljug && tamano == 0)
            {
                manager.datosserial.nivelexp += valorexp;
            }
            else if(nivelactual < manager.datosserial.niveljug && nivelactual  >= (manager.datosserial.niveljug -10) && tamano == 0)
            {
                int diferencianivel = manager.datosserial.niveljug - nivelactual;
                manager.datosserial.nivelexp += (valorexp / (((diferencianivel) + 1)/2));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  <= (manager.datosserial.niveljug + 10) && tamano == 0)
            {
                int diferencianivel =  nivelactual - manager.datosserial.niveljug ;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  > (manager.datosserial.niveljug + 10) && tamano == 0)
            {
                int diferencianivel =  10;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            if(manager.datosserial.nivelexp >= manager.datosserial.signivelexp && manager.datosserial.niveljug < 50 && tamano == 0)
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

            GameObject monedae = Instantiate(moneda, transform.position , transform.rotation);
            if(destobj == true)
            {
                Destroy(destruible);
            }
			manager.datosserial.asesinatos++;
			muertes.Play();
			manager.guardar();
            Destroy(explosiont, 1f);
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            Destroy(transform.parent.gameObject);
        }
        else if (vida < 1 && tutorial == 0 && temprb == 0)
        {
            if(manager.juego == 3 || manager.juego == 4 )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            if(tamano == 3)
            {
                GameObject bigtemp = Instantiate(big, transform.position - new Vector3(10,0,0), transform.rotation);
                GameObject bigtemp2 = Instantiate(big, transform.position + new Vector3(10,0,0), transform.rotation);
                GameObject bigtemp3 = Instantiate(big, transform.position - new Vector3(0,0,10), transform.rotation);
                GameObject bigtemp4 = Instantiate(big, transform.position + new Vector3(0,0,10), transform.rotation);
                bigtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                bigtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                bigtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                bigtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                bigtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                bigtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                bigtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                bigtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
            }
            else if(tamano == 2)
            {
                GameObject medtemp = Instantiate(med, transform.position - new Vector3(7,0,0), transform.rotation);
                GameObject medtemp2 = Instantiate(med, transform.position + new Vector3(7,0,0), transform.rotation);
                medtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/2;
                medtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/2;
                medtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                medtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
            }
            else if(tamano == 1)
            {
                GameObject pequetemp = Instantiate(peque, transform.position - new Vector3(5,0,0), transform.rotation);
                GameObject pequetemp2 = Instantiate(peque, transform.position + new Vector3(5,0,0), transform.rotation);
                GameObject pequetemp3 = Instantiate(peque, transform.position - new Vector3(0,0,5), transform.rotation);
                GameObject pequetemp4 = Instantiate(peque, transform.position + new Vector3(0,0,5), transform.rotation);
                pequetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                pequetemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                pequetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                pequetemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
            }
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = transform.localScale;
            if(nivelactual == manager.datosserial.niveljug && tamano == 0)
            {
                manager.datosserial.nivelexp += valorexp;
            }
            else if(nivelactual < manager.datosserial.niveljug && nivelactual  >= (manager.datosserial.niveljug -10) && tamano == 0)
            {
                int diferencianivel = manager.datosserial.niveljug - nivelactual;
                manager.datosserial.nivelexp += (valorexp / (((diferencianivel) + 1)/2));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  <= (manager.datosserial.niveljug + 10) && tamano == 0)
            {
                int diferencianivel =  nivelactual - manager.datosserial.niveljug ;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  > (manager.datosserial.niveljug + 10) && tamano == 0)
            {
                int diferencianivel =  10;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            if(manager.datosserial.nivelexp >= manager.datosserial.signivelexp && manager.datosserial.niveljug < 50 && tamano == 0)
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

            GameObject monedae = Instantiate(moneda, transform.position , transform.rotation);
            if(destobj == true)
            {
                Destroy(destruible);
            }
			manager.datosserial.asesinatos++;
			muertes.Play();
			manager.guardar();
            Destroy(explosiont, 1f);
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            Destroy(transform.parent.gameObject);

        }
        else if (vida < 1 && tutorial == 1  && manager.datosserial.niveljug == 1 && temprb == 0)
        {
            if(manager.juego == 3 || manager.juego == 4 )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = transform.localScale;
            manager.datosserial.asesinatos++;
            GameObject monedae = Instantiate(moneda, transform.position , transform.rotation);
            if(destobj == true)
            {
                Destroy(destruible);
            }
            jugador1.nivel2();
			muertes.Play();
			manager.guardar();
            Destroy(explosiont, 1f);
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            eventotut.eventoene();
            Destroy(transform.parent.gameObject);
        }
        else if (vida < 1 && tutorial == 2 || vida < 1 && manager.datosserial.niveljug > 1 && tutorial == 1 && temprb == 0)
        {
            if(manager.juego == 3 || manager.juego == 4 )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = transform.localScale;
            if(nivelactual == manager.datosserial.niveljug && tamano == 0)
            {
                manager.datosserial.nivelexp += valorexppisado;
            }
            else if(nivelactual < manager.datosserial.niveljug && nivelactual  >= (manager.datosserial.niveljug -10) )
            {
                int diferencianivel = manager.datosserial.niveljug - nivelactual;
                manager.datosserial.nivelexp += (valorexppisado / (((diferencianivel) + 1)/2));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  <= (manager.datosserial.niveljug + 10) )
            {
                int diferencianivel =  nivelactual - manager.datosserial.niveljug ;
                manager.datosserial.nivelexp += (valorexppisado * (((diferencianivel) + 2) / 3 ));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  > (manager.datosserial.niveljug + 10) )
            {
                int diferencianivel =  10;
                manager.datosserial.nivelexp += (valorexppisado * (((diferencianivel) + 2) / 3 ));
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
			muertes.Play();
            GameObject monedae = Instantiate(moneda, transform.position , transform.rotation);
            if(destobj == true)
            {
                Destroy(destruible);
            }
			manager.guardar();
            Destroy(explosiont, 1f);
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            eventotut.eventoene();
            Destroy(transform.parent.gameObject);
        }
        det.transform.position = this.transform.position;
        dano.transform.position = this.transform.position;
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        else
        {
            anim.SetBool("salto",false);
        }
        
        if(detectar == true && desactivar == false && manager.controlene == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),25f * Time.deltaTime);
        }
        else if(detectar == false )
        {
            if(manager.juego != 3)
            {
                if(new Vector3(objetivon.x,transform.position.y,objetivon.z) == transform.position)
                {
                    objetivon = objetivoa[Random.Range(0,4)];
                }
                Vector3 direction2 = objetivon - transform.position;
                rotation = Quaternion.LookRotation(direction2);
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivon.x,transform.position.y,objetivon.z),vel * Time.deltaTime);
            }
            else if(manager.juego == 3)
            {
                anim.SetBool("salto",true);
            }
            
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),25f * Time.deltaTime);
            RaycastHit hit;
            if(Physics.Raycast(transform.position, -transform.up, out hit, Mathf.Infinity,0, QueryTriggerInteraction.Ignore))
            {
            	if (hit.distance < 0.1f)
                {
                    Destroy (GetComponent<Rigidbody>());
                }
            }

            // Aplicar gravedad solo si no está en el suelo
            
        }

        
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0 && detectar == true )
		{
            jugador1.toquespalo--;
            jugador1.muertesjug.Stop();
            vida -= col.gameObject.GetComponent<golpe_al1>().dano;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            danoene.Play();
            rb_.AddForce((jugador1.transform.forward * 110) + (transform.up  * 110 * 1.5f));
            danoene.Play();
            temprb = 1;
            vidapisar = false;
		}
        if (col.gameObject.tag == "danoarma8" && detectar == true)
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            danoene.Play();
            vidapisar = false;
		}
        if (col.gameObject.tag == "danoarma9" && detectar == true)
		{
            detectar = false;
		}

	}
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "danoarma10" && detectar == true)
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            danoene.Play();
            vidapisar = false;
		}
        if (col.gameObject.tag == "danoarma9" && detectar == true)
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            danoene.Play();
            vidapisar = false;
        }
    }
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "golpeh")
		{

            jugador1.muertesjug.Stop();
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
        if (col.gameObject.tag == "Player" && col.gameObject.tag != "golpeh" && temprb == 0 )
		{
            jugador1.eneempuj = this.gameObject;
            jugador1.enmovdirectaux = transform.TransformDirection((jugador1.eneempuj.transform.forward *70) + (jugador1.eneempuj.transform.up * -50));
            jugador1.enmovdirectaux = jugador1.enmovdirectaux.normalized;
            jugador1.tempempujon = 0;
            jugador1.empujon = true;

            jugador1.muertesjug.Play();
            jugador1.vida -= danoj;
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            muertes.Play();
            Destroy(explosiont, 1f);
            Destroy(transform.parent.gameObject);
        }
        
    }
}
