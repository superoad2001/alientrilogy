using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo2_al1: MonoBehaviour
{
    public int nivelactual = 1;
    public GameObject slash;
    public GameObject escudoin;
	public manager_al1 manager;
    public AudioSource divson;
    public AudioSource curason;
    public AudioSource cargason;
    public bool muertetemp;
    public float tempM;
    public bool detectar;
    public bool detect;
    public float temprb;
    public float tempdanodef;
    public bool destobj;
    public GameObject destruible;
    public GameObject moneda;
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
    public jugador_al1 jugador1;
    public AudioSource muertes;
    public int enemigo = 1;
    public float balafrec = 1.5f;
    public int enemigo3;
    public GameObject balaprefab;
    public AudioSource disp;
    public Transform juego;
    public GameObject pistola;
    public AudioSource golpeson;
    public float tempe3;
    public float vida;
    public float vidamax;
    public Image vidab;

    private float extraD;

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
    public float vidaUI;

    public float danoj = 5;
    public GameObject target;
    public GameObject palo;


    public float nivelfuerza;
    public float nivelvida;

    public bool enemigostut;
    private Vector3[] objetivoa = new Vector3[4]; 
    private Vector3 objetivon;

    public float[] nivelfuerza_a = new float[100];
    public float[] nivelvida_a = new float[100];
    public float[] niveldefensa = new float[100];
    public manager_ordas_al1 managerordas;

    public string modo;
    public string mododisparos;
    public string modocarga;
    public bool mixto;
    public bool programable;
    public bool programable2;
    public float Randomdec6;

    public float defensabase = 5;
    public float defensabasemax = 50;
    public float defensaplusmax = 500;

    public GameObject ondasprefab;
    public GameObject bombaprefab;
    public GameObject teleprefab;
    public GameObject zigzagprefab;

    public bool division;
    public bool division2;
    public AudioSource lanzarson;
    
    public int cura;
    public golpe_al1 paloS;
    public float frenetismo;
    public float cancelatk;
    public GameObject eneprefab1;
    public GameObject eneprefab2;
    public float tempcarga;
    public float tempcargaef;
    public int randomdec5;
    public bool fuera;
    public bool gigante;
    //tendra siempre la mitad de stats que el enemigo actual excepto si su vitalidad baja de 2 lo hara al bajar de 10%


    
    // Start is called before the first frame update
    void Start()
    {

        tempcarga = Random.Range(0,8);
        frenetismo = 1;
        extraD = 1f;
        if(nivelactual >= 70)
        {
            frenetismo = 1.2f;
        }
        paloS = palo.GetComponent<golpe_al1>();
        if(nivelactual >= 70)
        {
            cura = 3;
        }
        else if(nivelactual >= 50)
        {
            cura = 2;
        }
        else if(nivelactual >= 20)
        {
            cura = 1;
        }
        if(nivelactual >= 90 && programable2 == false)
        {
            int Randomdec3 = Random.Range(0,2);
            if(Randomdec3 == 1)
            {
                division2 = true;
            }
            else
            {
                int Randomdec4 = Random.Range(0,2);
                if(Randomdec4 == 1)
                {
                    division = true;
                }
            }
        }
        else if(nivelactual >= 60)
        {
            int Randomdec4 = Random.Range(0,1);
            if(Randomdec4 == 1)
            {
                division = true;
            }
            
        }
        if(nivelactual >= 40)
        {
            int Randomdisp = Random.Range(0,4);
            if(Randomdisp == 0)
            {
                mododisparos = "disparo";
            }
            else if(Randomdisp == 1)
            {
                mododisparos = "ondas";
            }
            else if(Randomdisp == 2)
            {
                mododisparos = "bomba";
            }
            else if(Randomdisp == 3)
            {
                mododisparos = "zigzag";
            }
            
        }
        else if(nivelactual >= 30)
        {
            int Randomdisp = Random.Range(0,3);
            if(Randomdisp == 0)
            {
                mododisparos = "disparo";
            }
            else if(Randomdisp == 1)
            {
                mododisparos = "ondas";
            }
            else if(Randomdisp == 2)
            {
                mododisparos = "bomba";
            }
        }
        else if(nivelactual >= 10)
        {
            int Randomdisp = Random.Range(0,2);
            if(Randomdisp == 0)
            {
                mododisparos = "disparo";
            }
            else if(Randomdisp == 1)
            {
                mododisparos = "ondas";
            }

        }
        else
        {
            mododisparos = "disparo";
        }
        if(programable == false)
        {

            
            enemigo3 = Random.Range(1,3);
            if(enemigo3 == 1)
            {
                modo = "fisico";
            }
            if(enemigo3 == 2)
            {
                modo = mododisparos;
            }
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

        niveldefensa[0] = 0.5f;
        for(int i = 1 ;i <= 49;  i++ )
        {   
            niveldefensa[i] = (fuebase) + (((defensabasemax-defensabase)/48) * (i - 2));
        }
        for(int i = 50 ; i <= 99; i++)
        {   
            niveldefensa[i] = (fuebasemax) + (((defensaplusmax -defensabasemax)/50) * (i - 49));
        }

        nivelfuerza = nivelfuerza_a[nivelactual-1];
        nivelvida = nivelvida_a[nivelactual-1];
        if(programable2 == false)
        {
            vidamax = nivelvida;
        }
        

        danoj = nivelfuerza;
        
        vida = vidamax;
        vidaUI = vida;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");
        juego = GameObject.Find("juego").transform;
    }
    public void Awake()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
    }

    // Update is called once per frame
    void Update()
    {
        if(cancelatk < 0)
        {
            cancelatk = 0;
        }
        if (temprb > 0f)
        {
            temprb -= Time.deltaTime;
        }
        else{temprb = 0f;}

        if(modo == "fisico")
        {
            palo.SetActive(true);
            pistola.SetActive(false);
        }
        else if(modo == "disparo")
        {
            palo.SetActive(false);
            pistola.SetActive(true);
        }

        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);

        if(jugador1.objetivotarget == transform.gameObject )
        {
            target.SetActive(false);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = false;
            jugador1.escudosene = 0;

            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = 0;
            jugador1.vidaescudoene2 = 0;
            jugador1.vidaescudoene3 = 0;
            jugador1.vidaescudomaxene = 0;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else if(jugador1.objetivotarget2 == transform.gameObject && jugador1.objetivotarget == null )
        {
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = false;
            jugador1.escudosene = 0;

            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = 0;
            jugador1.vidaescudoene2 = 0;
            jugador1.vidaescudoene3 = 0;
            jugador1.vidaescudomaxene = 0;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else
        {
            target.SetActive(false);
        }



        det.transform.position = this.transform.position;
        dano.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y + 4.14f,this.transform.position.z);
        if (muertetemp == true)
        {
            if(tempM > 45)
            {
                if(jugador1.objetivotarget2 == this.gameObject)
                {
                    jugador1.objetivotarget2 = null;
                    jugador1.vidaenebarra.SetActive(false);
                }
                GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
                muertes.Play();
                jugador1.vidaenebarra.SetActive(false);
                jugador1.vidaeneact = false;
                Destroy(transform.parent.gameObject);
            }
            tempM += 1 * Time.deltaTime;
        }
        if (vida < 1)
        {
            GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            muertes.Play();
            if(enemigostut == false)
            {
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
            }
            if(managerordas != null)
            {
                managerordas.contadorene--;
            }
            if(manager.juego == 3 || manager.juego == 4 )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            if(destobj == true)
            {
                Destroy(destruible);
            }
            if(jugador1.objetivotarget2 == this.gameObject)
            {
                jugador1.objetivotarget2 = null;
                jugador1.vidaenebarra.SetActive(false);
            }

            GameObject monedae = Instantiate(moneda, transform.position , transform.rotation);
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
        else
        {
        }
        


        if(detectar == true && desactivar == false && modo == "fisico" && manager.controlene == true && cancelatk == 0)
        {
                if(nivelactual >= 80)
                {
                    randomdec5 = Random.Range(0,4);
                }
                else if(nivelactual >= 40)
                {
                    randomdec5 = Random.Range(0,3);
                }
                else if(nivelactual >= 30)
                {
                    randomdec5 = Random.Range(0,2);
                }
                

                if(temp > 3f && randomdec5 == 0)
                {
                    Vector3 direction = objetivo1.position - transform.position;
                    rotation = Quaternion.LookRotation(direction);
                    transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);

                    paloS.toquespalo = 2;
                    GameObject slasht = Instantiate(slash, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;
                    slasht.transform.SetParent(transform);
                    Destroy(slasht,1f);
                    anim.SetBool("atk",true);
                    temp = 0;
                    paloS.dano = danoj * 2;
                    golpeson.Play();
                }
                else if(temp > 3f && randomdec5 == 1)
                {
                    Vector3 direction = objetivo1.position - transform.position;
                    rotation = Quaternion.LookRotation(direction);
                    transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);

                    anim.SetBool("eneatk1",true);
                    temp = -5;
                    paloS.toquespalo = 5;
                    paloS.GetComponent<golpe_al1>().dano = danoj/5;


                    GameObject BalaTemporal = Instantiate(teleprefab, pistola.transform.position,transform.rotation) as GameObject;

                    Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                    BalaTemporal.GetComponent<bala_tele_al1>().objetivo = objetivo.gameObject;

                    BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj/2;

                    BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                    disp.Play();

                    temp = 0;
                    disp.Play();
                }
                else if(temp > 3f && randomdec5 == 2)
                {
                    Vector3 direction = objetivo1.position - transform.position;
                    rotation = Quaternion.LookRotation(direction);
                    transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                    temp = -2;
                    paloS.toquespalo = 2;
                    paloS.dano = danoj;
                    anim.Play("arma3");
                    anim.SetBool("arma4",true);
                    lanzarson.Play();
                }
                else if(temp > 3f && randomdec5 == 3)
                {
                    rb_ = this.GetComponent<Rigidbody>();
                    anim.SetBool("encatk1",true);
                    this.rb_.AddForce(1000 * transform.TransformDirection(new Vector3 (0,0,1)));
                    temp = 0;
                    temp = -6;
                    paloS.toquespalo = 1;
                    paloS.dano = danoj*2.2f;
                    lanzarson.Play();
                }
                else
                {
                    Vector3 direction = objetivo1.position - transform.position;
                    rotation = Quaternion.LookRotation(direction);
                    transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                    anim.SetBool("atk",false);
                    anim.SetBool("arma3",false);
                    anim.SetBool("encatk1",false);
                }
            
            
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
            temp += 1 * frenetismo * Time.deltaTime;

            

            
            
        }
        if(detectar == true && modo == "disparo" && desactivar == false && manager.controlene == true && cancelatk == 0)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj * 1;

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
            temp += 1 * frenetismo * Time.deltaTime;
        }
        if(detectar == true && modo == "ondas" && desactivar == false && manager.controlene == true && cancelatk == 0)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(ondasprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj ;

                        rb.AddForce(BalaTemporal.transform.forward * 110 * 5);

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
            temp += 1 * frenetismo * Time.deltaTime;
        }
        if(detectar == true && modo == "bomba" && desactivar == false && manager.controlene == true && cancelatk == 0)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(bombaprefab, pistola.transform.position + (transform.forward * 5),transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj ;

                        rb.AddForce(new Vector3(0,BalaTemporal.transform.up.y,BalaTemporal.transform.forward.z) * 110 * 5);

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
            temp += 1 * frenetismo * Time.deltaTime;
        }
        if(detectar == true && modo == "zigzag" && desactivar == false && manager.controlene == true && cancelatk == 0)
        {
            if(temp > 1)
            {
                        GameObject BalaTemporal = Instantiate(zigzagprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        BalaTemporal.transform.GetChild(0).GetComponent<romperbala_al1>().danoj = danoj /2;
                        BalaTemporal.transform.GetChild(1).GetComponent<romperbala_al1>().danoj = danoj /2;

                        rb.AddForce(BalaTemporal.transform.forward * 110 * 5);


                        BalaTemporal.transform.GetChild(0).GetComponent<romperbala_al1>().destb = 4f;
                        BalaTemporal.transform.GetChild(1).GetComponent<romperbala_al1>().destb = 4f;

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
            temp += 1 * frenetismo * Time.deltaTime;
        }
        if(detectar == true && desactivar == false && manager.controlene == true && gigante == false )
        {
            if(cancelatk > 0)
            {
                if(tempcargaef > 7)
                {
                    if(modocarga == "vida100")
                    {
                        vida = vidamax;
                        cancelatk = 0;
                        tempcarga = 0;
                        tempcargaef = 0;
                        modocarga = "";
                        anim.SetBool("Playercarga",false);
                        curason.Play();
                    }
                    if(modocarga == "vida+50")
                    {
                        vida += (vidamax/2);
                        if(vida > vidamax)
                        {
                            vida = vidamax;
                        }
                        cancelatk = 0;
                        tempcarga = 0;
                        tempcargaef = 0;
                        modocarga = "";
                        anim.SetBool("Playercarga",false);
                        curason.Play();
                    }
                    if(modocarga == "trivision")
                    {
                        modocarga = "";
                        if(managerordas != null)
                        {
                            managerordas.contadorene += 2;
                        }
                        GameObject enetemp = Instantiate(eneprefab1, transform.position - new Vector3(7,0,0), transform.rotation);
                        GameObject enetemp2 = Instantiate(eneprefab2, transform.position + new Vector3(7,0,0), transform.rotation);
                        enemigo2_al1 ene1tempS  = enetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo2_al1>();
                        enemigo2_al1 ene2tempS = enetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo2_al1>();
                        ene1tempS.valorexp = valorexp/2;
                        ene2tempS.valorexp = valorexp/2;
                        ene1tempS.nivelactual = nivelactual;
                        ene2tempS.nivelactual = nivelactual;
                        ene1tempS.programable = true;
                        ene2tempS.programable = true;
                        ene1tempS.detectar = true;
                        ene2tempS.detectar = true;
                        ene1tempS.programable2 = true;
                        ene2tempS.programable2 = true;
                        ene1tempS.vidamax = vidamax/2;
                        ene2tempS.vidamax = vidamax/2;
                        cancelatk = 0;
                        tempcarga = 0;
                        tempcargaef = 0;
                        divson.Play();
                        
                        anim.SetBool("Playercarga",false);
                    }
                    if(modocarga == "division")
                    {
                        modocarga = "";
                        if(managerordas != null)
                        {
                            managerordas.contadorene += 1;
                        }
                        GameObject enetemp = Instantiate(eneprefab1, transform.position - new Vector3(7,0,0), transform.rotation);
                        enemigo2_al1 ene1tempS = enetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo2_al1>();
                        ene1tempS.valorexp = valorexp/1.5f;
                        ene1tempS.nivelactual = nivelactual;
                        ene1tempS.programable = true;
                        ene1tempS.programable2 = true;
                        ene1tempS.detectar = true;
                        ene1tempS.modo = modo;
                        ene1tempS.vidamax = vida;
                        cancelatk = 0;
                        tempcarga = 0;
                        tempcargaef = 0;
                        modocarga = "";
                        anim.SetBool("Playercarga",false);
                        divson.Play();
                    }
                }
            }
            else
            {
                anim.SetBool("Playercarga",false);
                modocarga = "";
                cargason.Stop();
            }


            if(nivelactual >= 90)
            {
                Randomdec6 = Random.Range(0,5);
            }
            else if(nivelactual >= 70)
            {
                Randomdec6 = Random.Range(0,4);     
            }          
            else if(nivelactual >= 60)
            {
                Randomdec6 = Random.Range(0,3);
            }
            else if(nivelactual >= 20)
            {
                Randomdec6 = Random.Range(0,2);          
            }


            if((vidamax/100) * 50 <= vida && tempcarga > 12 && Randomdec6 == 1 && cura > 0)
            {
                int randomdec = Random.Range(0,2);
                if(randomdec == 1)
                {
                    cancelatk = 10;
                    anim.SetBool("Playercarga",true);
                    anim.Play("cargahabene");
                    tempcarga = 0;
                    tempcargaef = 0;
                    modocarga = "vida+50";
                    cargason.Play();
                }
                cura--;
                
            }
            if((vidamax/100) * 20 <= vida && division == true && tempcarga > 12 && Randomdec6 == 2)
            {
                cancelatk = 10;
                anim.SetBool("Playercarga",true);
                anim.Play("cargahabene");
                tempcarga = 0;
                tempcargaef = 0;
                modocarga = "trivision";
                division = false;
                cargason.Play();
            }
            if((vidamax/100) * 30 <= vida && tempcarga > 12 && cura == 1 && Randomdec6 == 3)
            {
                int randomdec = Random.Range(0,2);
                if(randomdec == 1)
                {
                    cancelatk = 15;
                    anim.SetBool("Playercarga",true);
                    anim.Play("cargahabene");
                    tempcarga = 0;
                    tempcargaef = 0;
                    modocarga = "vida100";
                    cargason.Play();
                }
                cura--;
                
            }
            if((vidamax/100) * 50 <= vida && division2 == true && tempcarga > 12 && Randomdec6 == 4)
            {
                cancelatk = 20;
                anim.SetBool("Playercarga",true);
                anim.Play("cargahabene");
                tempcarga = 0;
                tempcargaef = 0;
                modocarga = "division";
                division2 = false;
                cargason.Play();
            }
            

            if(tempcarga < 15 && cancelatk == 0)
            {tempcarga += 1 * Time.deltaTime;}
            if(tempcargaef < 15)
            {tempcargaef += 1 * Time.deltaTime;}
        }
        if(detectar == true && mixto == true && desactivar == false && manager.controlene == true && programable == false)
        {

            if (tempe3 > 10f)
            {
                enemigo3 = Random.Range(1,3);
                if(enemigo3 == 1)
                {
                    modo = "fisico";
                }
                if(enemigo3 == 2)
                {
                    modo = mododisparos;
                }
                tempe3 = 0;
            }
            
        }
        if(fuera == false )
        {
            if(detect == false)
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
                    anim.SetFloat("vely",1);
                }
                else if(manager.juego == 3)
                {
                    anim.SetBool("Playeract",true);
                }
                    // Lanzar rayo hacia abajo
                RaycastHit hit;
                if(Physics.Raycast(transform.position, -transform.up, out hit, Mathf.Infinity,0, QueryTriggerInteraction.Ignore))
                {
                    if (hit.distance < 0.1f)
                    {
                        Destroy (GetComponent<Rigidbody>());
                    }
                }
            }
            else if(detect == true)
            {
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador1.transform.position.x,transform.position.y,jugador1.transform.position.z),vel * Time.deltaTime);
            }

            // Aplicar gravedad solo si no está en el suelo
            
        }
        else
        {
            anim.SetBool("Playeract",false);
        }
        if(tempdanodef < 15)
        {tempdanodef += 1 * Time.deltaTime;}
        
        
    }
    private void OnTriggerExit(Collider col)
	{
        
        if (col.gameObject.tag == "danoarma9" )
		{
            romperbala_al1 balajug = col.gameObject.GetComponent<romperbala_al1>();
            jugador1.muertesjug.Stop();
            vida -= (balajug.danoj * extraD);
            cancelatk -= 0.2f * Time.deltaTime;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            danoene.Play();
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            detect = true;
        }
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0 )
		{
            cancelatk--;
            jugador1.toquespalo--;
            vida -= (col.gameObject.GetComponent<golpe_al1>().dano * extraD);
            danoene.Play();
            jugador1.vidaeneact = true;
            temprb = 1;
            //temp = 0;
            rb_.AddForce((jugador1.transform.forward * 110) + (transform.up  * 110 * 1.2f));
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.niveleneui.text = nivelactual.ToString();
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            detect = true;
            
		}
        if (col.gameObject.tag == "danoarma10" && tempdanodef > 15f)
		{
            baladef_exp_al1 balajug = col.gameObject.GetComponent<baladef_exp_al1>();
            jugador1.muertesjug.Stop();
            vida -= (balajug.danoj * extraD);
            cancelatk--;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            danoene.Play();
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            detect = true;
            tempdanodef = 0;
            
		}
        if (col.gameObject.tag == "danoarma8" )
		{
            cancelatk--;
            romperbala_al1 balajug = col.gameObject.GetComponent<romperbala_al1>();
            jugador1.muertesjug.Stop();
            vida -= (balajug.danoj* extraD);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            danoene.Play();
            jugador1.niveleneui.text = nivelactual.ToString();
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            detect = true;
		}
        if (col.gameObject.tag == "danoarma9")
		{
            detectar = false;
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            detect = true;
		}
	}
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "danoarma9")
		{
            romperbala_al1 balajug = col.gameObject.GetComponent<romperbala_al1>();
            vida -= (balajug.danoj * extraD * Time.deltaTime);
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
                managerordas.contadorene--;
            }
            if(jugador1.objetivotarget2 == this.gameObject)
            {
                jugador1.objetivotarget2 = null;
                jugador1.vidaenebarra.SetActive(false);
            }
			Destroy(transform.parent.gameObject);
		}
        
    }
}
