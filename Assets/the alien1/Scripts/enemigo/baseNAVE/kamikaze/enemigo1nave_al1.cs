using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1nave_al1: MonoBehaviour
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
    public GameObject verdepeque;
    public enemigo1_al1 curaobj;

    private bool isGrounded = false;
    public AudioSource disp;
    public GameObject balaprefab1;

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
    public float vidabase = 999;
    public float vidabasemax = 9999;
    public float vidaplusmax = 99999;

    public float defensabase = 300;
    public float defensabasemax = 3000;
    public float defensaplusmax = 30000;
    public int nivelactual = 1;

    public float fuebase = 150;
    public float fuebasemax = 1500;
    public float fueplusmax = 30000;
    public float nivelfuerza;
    public float nivelvida;
    public float[] nivelfuerza_a = new float[20];
    public float[] nivelvida_a = new float[20];
    public tutorialbase_al1 eventotut;
    public float temp;

    public bool voladoract;

    public GameObject big;
    public GameObject med;
    public GameObject peque; 
    public float vidaUI;
    private Vector3 []objetivoa = new Vector3[4]; 
    private Vector3 objetivon;
    public float[] niveldefensa = new float[20];

    public bool vidapisar;  
    public float valorexppisado;
    public manager_ordas_al1 managerordas;

    public string modo;
    private float disparos;
    public bool programado;
    public float frenetismo = 1;
    public GameObject balaprefab2;
    public bool fuera;
    // Start is called before the first frame update
    void Start()
    {
        if( modo == "")
        {modo = "base";}
        
        

        if(programado == false)
        {
            if(nivel >= 20)
            {
                int randomini = Random.Range(0,2);

                if(randomini == 1)
                {
                    modo = "disparo";
                    disparos = 10;
                }
            }
            if(nivel >= 60)
            {
                modo = "disparo";
                disparos = 10;
            }
        }
        if(nivel >= 90)
        {
            frenetismo = 1.2f;
        }

        if((manager_ordas_al1)FindFirstObjectByType(typeof(manager_ordas_al1))!= null)
        {
        	managerordas = (manager_ordas_al1)FindFirstObjectByType(typeof(manager_ordas_al1));
        }
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



        

        for(int i = 0 ;i <= 9;  i++ )
        {   
            nivelvida_a[i] = (vidabase) + (((vidabasemax-vidabase)/10) * i);
        }
        for(int i = 11 ; i <= 19; i++)
        {   
            nivelvida_a[i] = (vidabasemax) + (((vidaplusmax - vidabasemax)/10) * (i - 10));
        }

        for(int i = 0 ;i <= 9;  i++ )
        {   
            nivelfuerza_a[i] = (fuebase) + (((fuebasemax-fuebase)/10) * i);
        }
        for(int i = 11 ; i <= 19; i++)
        {   
            nivelfuerza_a[i] = (fuebasemax) + (((fueplusmax -fuebasemax)/10) * (i - 10));
        }

        for(int i = 0 ;i <= 9;  i++ )
        {   
            niveldefensa[i] = (fuebase) + (((defensabasemax-defensabase)/10) * i);
        }
        for(int i = 11 ; i <= 19; i++)
        {   
            niveldefensa[i] = (fuebasemax) + (((defensaplusmax -defensabasemax)/10) * (i - 10));
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


        if(modo == "cura")
        {
            vidamax = vidamax * 3;
            if(vidamax > 9999)
            {vidamax = 9999;}
            vida = vidamax;
            vidaUI = vida;
        }
        if(voladoract)
        {
            vidamax = vidamax * 1.5f;
            if(vidamax > 9999)
            {vidamax = 9999;}
            vida = vidamax;
            vidaUI = vida;

            rb_.useGravity = false;
        }
    }
    public void Awake()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
    }
    // Update is called once per frame
    void Update()
    {
        if(fuera == false)
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
            if(nivelactual == manager.datosserial.niveljug )
            {
                manager.datosserial.nivelexp += valorexp;
            }
            else if(nivelactual < manager.datosserial.niveljug && nivelactual  >= (manager.datosserial.niveljug -10) )
            {
                int diferencianivel = manager.datosserial.niveljug - nivelactual;
                manager.datosserial.nivelexp += (valorexp / (((diferencianivel) + 1)/2));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  <= (manager.datosserial.niveljug + 10) )
            {
                int diferencianivel =  nivelactual - manager.datosserial.niveljug ;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  > (manager.datosserial.niveljug + 10) )
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
            if(managerordas != null)
            {
                managerordas.contadorene--;
            }
            if(manager.juego == 3 || manager.juego == 4 )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = transform.localScale;
            if(nivelactual == manager.datosserial.niveljug )
            {
                manager.datosserial.nivelexp += valorexp;
            }
            else if(nivelactual < manager.datosserial.niveljug && nivelactual  >= (manager.datosserial.niveljug -10) )
            {
                int diferencianivel = manager.datosserial.niveljug - nivelactual;
                manager.datosserial.nivelexp += (valorexp / (((diferencianivel) + 1)/2));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  <= (manager.datosserial.niveljug + 10) )
            {
                int diferencianivel =  nivelactual - manager.datosserial.niveljug ;
                manager.datosserial.nivelexp += (valorexp * (((diferencianivel) + 2) / 3 ));
            }
            else if(nivelactual > manager.datosserial.niveljug && nivelactual  > (manager.datosserial.niveljug + 10) )
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
            if(nivelactual == manager.datosserial.niveljug)
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

            if(modo == "base")
            {
                if(voladoract)
                {
                    rb_.useGravity = false;
                }

                if(nivel >= 30)
                {
                    float disjugene = Vector3.Distance(transform.position, jugador1.transform.position);
                    if(disjugene < 30)
                    {
                        
                        transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * 1.5f * frenetismo * Time.deltaTime);
                    }
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * frenetismo * Time.deltaTime);
                    }
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * frenetismo * Time.deltaTime);
                }
                
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),25f * Time.deltaTime);

                
            }
            else if (modo == "disparo")
            {
                if(voladoract)
                {
                    rb_.useGravity = false;
                }

                if(temp > (1 / frenetismo))
                {
                    int randomdisp = Random.Range(0,3);
                    if(nivel >= 80 && randomdisp == 1)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab2, transform.position,transform.rotation) as GameObject;
                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        BalaTemporal.GetComponent<bala_tele_al1>().objetivo = objetivo.gameObject;

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj/2;

                        BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                        disp.Play();

                        temp = 0;

                        disparos--;



                         


                    }
                    else
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab1, transform.position,transform.rotation) as GameObject;
                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj/2;

                        rb.AddForce(BalaTemporal.transform.forward * 140 * 20);

                        BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                        disp.Play();

                        temp = 0;
                        disparos--;
                    }

                    
                }
                if(disparos <= 0)
                {
                    modo = "base";
                }
                if(nivel >= 60)
                {
                    if(nivel >= 30)
                    {
                        float disjugene = Vector3.Distance(transform.position, jugador1.transform.position);
                        if(disjugene < 30)
                        {
                            
                            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * 1.5f * frenetismo * Time.deltaTime);
                        }
                        else
                        {
                            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * frenetismo * Time.deltaTime);
                        }
                    }
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * frenetismo * Time.deltaTime);
                    }
                    
                    Vector3 direction = objetivo1.position - transform.position;
                    rotation = Quaternion.LookRotation(direction);
                    transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),25f * Time.deltaTime);
                }
            }
            else if (modo == "cura")
            {   
                if(curaobj != null)
                {
                    if(curaobj.vida < curaobj.vidamax)
                    {curaobj.vida +=  (vidamax/100) *  0.5f * Time.deltaTime;}
                }
                else
                {
                    modo = "base";
                }
                
            }        


            // te vio
        }
        else if(fuera == false )
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

            if(managerordas != null)
            {
                managerordas.contadorene -= 1;
            }
			Destroy(transform.parent.gameObject);
            
		}
        if (col.gameObject.tag == "Player" && col.gameObject.tag != "golpeh" && temprb == 0 )
		{
            if(tutorial == 1)
            {
                jugador1.muerte = true;
            }
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
            int RandomM = Random.Range(0,2);
            if(nivel >= 70 && RandomM == 1)
            {
                vida = vidamax;
            }
            else if(nivel >= 40 && nivel < 70 && RandomM == 1 && vida > 1)
            {
                vida = 1;
            }
            else
            {

                if(managerordas != null)
                {
                    managerordas.contadorene -= 1;
                }
                
                jugador1.enemigosEnContacto.Remove(enemigodet.gameObject);
                if (jugador1.enemigosEnContacto.Count == 0)
                {
                    jugador1.peligro = false;
                }           
                Destroy(transform.parent.gameObject);
                }
            
        }
        
    }
}
