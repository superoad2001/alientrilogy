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
    public GameObject verdepeque;
    public enemigo1_al1 curaobj;
    private int RandomM = 0;

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
    public float vidabasetut = 9;
    public float []vidabase = new float[4];
    public float []vidabasemax = new float[4];
    public float []vidaplusmax = new float[4];

    public float []defensabase = new float[4];
    public float []defensabasemax = new float[4];
    public float []defensaplusmax = new float[4];
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
    public float temp;

    public bool voladoract;

    public GameObject big;
    public GameObject med;
    public GameObject peque; 
    public float vidaUI;
    private Vector3 []objetivoa = new Vector3[4]; 
    private Vector3 objetivon;
    public float[] niveldefensa = new float[100];

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

        defensabase[0] = 5f;
        defensabasemax[0] = 50;
        defensaplusmax[0] = 500;

        

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

        niveldefensa[0] = 0.5f;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            niveldefensa[i] = (fuebase) + (((defensabasemax[0]-defensabase[0])/48) * (i - 2));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            niveldefensa[i] = (fuebasemax) + (((defensaplusmax[0] -defensabasemax[0])/50) * (i - 49));
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
            if(tamano == 3)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 45;
                }
            }
            else if(tamano == 2)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 11;
                }
            }
            else if(tamano == 1)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 5;
                }
            }
            else if(tamano == 0)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 1;
                }
            }
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
            if(managerordas != null)
            {
                managerordas.contadorene--;
            }
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
                

                int randomDec2 = 0;

                if(nivel >= 20)
                {
                    randomDec2 = Random.Range(0,2);
                }


                if(randomDec2 == 1)
                {
                    if(managerordas != null)
                    {
                        managerordas.contadorene += 44;
                    }

                    GameObject bigtemp5 = Instantiate(big, transform.position - new Vector3(20,0,0), transform.rotation);
                    GameObject bigtemp6 = Instantiate(big, transform.position + new Vector3(20,0,0), transform.rotation);
                    GameObject bigtemp7 = Instantiate(big, transform.position - new Vector3(0,0,20), transform.rotation);
                    GameObject bigtemp8 = Instantiate(big, transform.position + new Vector3(0,0,20), transform.rotation);

                    bigtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    bigtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    bigtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    bigtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;

                    bigtemp5.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    bigtemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    bigtemp7.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    bigtemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    
                    bigtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;

                    bigtemp5.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp7.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;

                    

                    
                }
                else
                {
                    bigtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    bigtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    bigtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    bigtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    
                    bigtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    bigtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                }
            }
            else if(tamano == 2)
            {
                GameObject medtemp = Instantiate(med, transform.position - new Vector3(7,0,0), transform.rotation);
                GameObject medtemp2 = Instantiate(med, transform.position + new Vector3(7,0,0), transform.rotation);
                
                int randomDec2 = 0;
                if(nivel >= 20)
                {
                    randomDec2 = Random.Range(0,2);
                }


                if(randomDec2 == 1)
                {
                    if(managerordas != null)
                    {
                        managerordas.contadorene += 10;
                    }

                    GameObject medtemp3 = Instantiate(med, transform.position - new Vector3(0,0,7), transform.rotation);
                    GameObject medtemp4 = Instantiate(med, transform.position + new Vector3(0,0,7), transform.rotation);

                    medtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    medtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;

                    medtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    medtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;

                    medtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    medtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;

                    medtemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    medtemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;

                    
                }
                else
                {
                    medtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/2;
                    medtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/2;
                    medtemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    medtemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                }

                

                
            }
            else if(tamano == 1)
            {
                

                int randomDec2 = 0;
                if(nivel >= 20)
                {
                    randomDec2 = Random.Range(0,2);
                }

                if(randomDec2 == 1)
                {
                    GameObject[] lista1peque = new GameObject[3];
                    GameObject[] lista2peque = new GameObject[3];

                    GameObject pequetemp = Instantiate(peque, transform.position - new Vector3(5,0,0), transform.rotation);
                    GameObject pequetemp3 = Instantiate(peque, transform.position - new Vector3(0,0,5), transform.rotation);
                    lista1peque[0] = pequetemp;
                    lista1peque[1] = pequetemp3;
                    int randomDec = 0;
                    if(nivel >= 10)
                    {
                        randomDec = Random.Range(0,2);
                    }

                    if(randomDec == 0)
                    {
                        GameObject pequetemp4 = Instantiate(peque, transform.position + new Vector3(0,0,5), transform.rotation);
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        lista1peque[2] = pequetemp4;
                    }
                    else if(randomDec == 1)
                    {
                        GameObject pequetemp4 = Instantiate(peque, transform.position + new Vector3(0,7,5), transform.rotation);
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().voladoract = true;
                        lista1peque[2] = pequetemp4;
                    }

                    GameObject pequetemp5 = Instantiate(peque, transform.position - new Vector3(10,0,0), transform.rotation);
                    GameObject pequetemp7 = Instantiate(peque, transform.position - new Vector3(0,0,10), transform.rotation);
                    lista2peque[0] = pequetemp5;
                    lista2peque[1] = pequetemp7;
                    int randomDec3 = 0;
                    if(nivel >= 10)
                    {
                        randomDec3 = Random.Range(0,2);
                    }

                    if(randomDec3 == 0)
                    {
                        GameObject pequetemp8 = Instantiate(peque, transform.position + new Vector3(0,0,10), transform.rotation);
                        pequetemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        lista2peque[2] = pequetemp8;
                    }
                    else if(randomDec3 == 1)
                    {
                        GameObject pequetemp8 = Instantiate(peque, transform.position + new Vector3(0,7,10), transform.rotation);
                        pequetemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        pequetemp8.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().voladoract = true;
                        lista2peque[2] = pequetemp8;
                    }

                    if(managerordas != null)
                    {
                        managerordas.contadorene += 4;
                    }

                    int randomDec4 = 0;
                    if(nivel >= 50)
                    {
                        randomDec4 = Random.Range(0,2);
                    }

                    if(randomDec4 == 0)
                    {
                        GameObject pequetemp2 = Instantiate(peque, transform.position + new Vector3(5,0,0), transform.rotation);
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    }
                    else if(randomDec4 == 1)
                    {
                        int randomDec7 = Random.Range(0,3);
                        GameObject pequetemp2 = Instantiate(verdepeque, transform.position + new Vector3(5,0,0), transform.rotation);
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().curaobj = lista1peque[randomDec7].transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>();
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().modo = "cura";
                    }

                    int randomDec5 = 0;
                    if(nivel >= 50)
                    {
                        randomDec4 = Random.Range(0,2);
                    }

                    if(randomDec5 == 0)
                    {
                        int randomDec8 = Random.Range(0,3);
                        GameObject pequetemp6 = Instantiate(peque, transform.position + new Vector3(10,0,0), transform.rotation);
                        pequetemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        pequetemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().curaobj = lista1peque[randomDec8].transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>();
                        pequetemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().modo = "cura";

                    }
                    else if(randomDec5 == 1)
                    {
                        GameObject pequetemp6 = Instantiate(verdepeque, transform.position + new Vector3(10,0,0), transform.rotation);
                        pequetemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                        pequetemp6.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    }

                    pequetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    pequetemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;

                    pequetemp5.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    pequetemp7.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/8;
                    


                    pequetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    pequetemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;

                    pequetemp5.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    pequetemp7.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    
                }
                else
                {
                    GameObject[] lista1peque = new GameObject[3];
                    GameObject pequetemp = Instantiate(peque, transform.position - new Vector3(5,0,0), transform.rotation);
                    GameObject pequetemp3 = Instantiate(peque, transform.position - new Vector3(0,0,5), transform.rotation);
                    lista1peque[0] = pequetemp;
                    lista1peque[1] = pequetemp3;
                    int randomDec = 0;
                    if(nivel >= 10)
                    {
                        randomDec = Random.Range(0,2);
                    }

                    if(randomDec == 0)
                    {
                        GameObject pequetemp4 = Instantiate(peque, transform.position + new Vector3(0,0,5), transform.rotation);
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        lista1peque[2] = pequetemp4;
                    }
                    else if(randomDec == 1)
                    {
                        GameObject pequetemp4 = Instantiate(peque, transform.position + new Vector3(0,7,5), transform.rotation);
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        pequetemp4.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().voladoract = true;
                        lista1peque[2] = pequetemp4;
                    }

                    int randomDec4 = 0;
                    if(nivel >= 50)
                    {
                        randomDec4 = Random.Range(0,2);
                    }

                    if(randomDec4 == 0)
                    {
                        GameObject pequetemp2 = Instantiate(peque, transform.position + new Vector3(5,0,0), transform.rotation);
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    }
                    else if(randomDec4 == 1)
                    {
                        int randomDec7 = Random.Range(0,3);
                        GameObject pequetemp2 = Instantiate(verdepeque, transform.position + new Vector3(5,0,0), transform.rotation);
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().curaobj = lista1peque[randomDec7].transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>();
                        pequetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().modo = "cura";
                    }

                    pequetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    pequetemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().valorexp = valorexp/4;
                    


                    pequetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    pequetemp3.transform.Find("enemigo").gameObject.GetComponent<enemigo1_al1>().nivelactual = nivelactual;
                    
                }

                
                
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
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0 && fuera == true)
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
        if (col.gameObject.tag == "danoarma8" && fuera == true)
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
        if (col.gameObject.tag == "danoarma9" && fuera == true)
		{
            detectar = false;
		}

	}
    private void OnTriggerExit(Collider col)
	{
        if (col.gameObject.tag == "danoarma10" && fuera == true)
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
        if (col.gameObject.tag == "danoarma9" && fuera == true)
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
            if(tamano == 3)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 45;
                }
            }
            else if(tamano == 2)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 11;
                }
            }
            else if(tamano == 1)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 5;
                }
            }
            else if(tamano == 0)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene -= 1;
                }
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
            
            if(nivel >= 70 )
            {
                RandomM = Random.Range(0,2);
            }
            else
            {
                RandomM = 0;
            }

            if(nivel >= 70 && RandomM == 1)
            {
                vida = vidamax;
            }
            else if(nivel >= 40 && RandomM == 0 && vida > 1)
            {
                vida = 1;
            }
            else
            {
                if(tamano == 3)
                {
                    if(managerordas != null)
                    {
                        managerordas.contadorene -= 45;
                    }
                }
                else if(tamano == 2)
                {
                    if(managerordas != null)
                    {
                        managerordas.contadorene -= 11;
                    }
                }
                else if(tamano == 1)
                {
                    if(managerordas != null)
                    {
                        managerordas.contadorene -= 5;
                    }
                }
                else if(tamano == 0)
                {
                    if(managerordas != null)
                    {
                        managerordas.contadorene -= 1;
                    }
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
