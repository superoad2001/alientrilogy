using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo3_al2: MonoBehaviour
{
	public manager_al2 manager;
    public bool staticene;
    public float distancia;
    public float temp2;
    public float tempdanodef;
    public bool detectar;
    public GameObject explotar1prefab;
    public GameObject explotar2prefab;
    public GameObject objetivo;
    public GameObject objetivob;
    public GameObject escudoin;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public GameObject escudoV;
    public Rigidbody rb_;
    public bool destobj;
    public GameObject destruible;
    public GameObject moneda;
    public float vel = 2;
    public bool detect;
    public bool desactivar;
    public enemigodet3_al2 enemigodet;
    public GameObject dano;
    public GameObject det;
    public float temp;
    public Animator anim;
    public GameObject explosion;
    public jugador_al2 jugador1;
    public AudioSource muertes;
    public float balafrec = 1.5f;
    public GameObject balaprefab;
    public AudioSource disp;
    public Transform juego;
    public GameObject pistola;
    public float vida;
    public float vidaUI;
    public float vidamax;
    public Image vidab;
    public float temprecargafin;
    private  float frenetismo = 1;
    public GameObject explosionP;
    public golpe_al2 paloS;
    public bool cerca;
    public string modoatk;

    public AudioSource expson;
    public AudioSource golpeson;
    public AudioSource habcargason;

    private float frenetismoarmas = 1;


    public AudioSource danoene;
    public AudioSource danoescudo;
    public GameObject vidamenu;
    public float temprb;

    public GameObject escudovis;
    public GameObject escudovis1_1;
    public GameObject escudovis1_2;
    public GameObject escudovis1_3;
    public GameObject escudovis2;
    public bool escudoact;
    public float tempescudo;
    public float tempesc;
    public float danoj = 8;
    public float vidaescudo1;
    public float vidaescudo2;
    public float vidaescudo3;
    public float vidaescudomax = 10;
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

    public float[] niveldefensa = new float[100];

    public bool new_game_plus;
    
    private Vector3[] objetivoa = new Vector3[4]; 
    private Vector3 objetivon;


    public float[] nivelfuerza_a = new float[100];
    public float[] nivelvida_a = new float[100];


    public float defensabase = 5;
    public float defensabasemax = 50;
    public float defensaplusmax = 500;
    public bool fuera;
    public GameObject bombaprefab;
    private int randomdec;
    public int randomdec2;
    private int randomdec3;
    public int escudos = 1;
    public int escudosmax = 1;
    private float fre2 = 1;
    public void Awake()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
    }
    public manager_ordas_al2 managerordas;
    // Start is called before the first frame update
    void Start()
    {
        temp2 = Random.Range(0,18);
        if((manager_ordas_al2)FindFirstObjectByType(typeof(manager_ordas_al2))!= null)
        {
        	managerordas = (manager_ordas_al2)FindFirstObjectByType(typeof(manager_ordas_al2));
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
        escudoact = true;
        vidaUI = vida;

        if(nivelactual > 50)
        {
            vidaescudomax = 100;
        }  
        else
        {
            vidaescudomax = 30;
        }

        if(nivelactual >= 70)
        {
            escudosmax = 3;
        }
        else if(nivelactual >= 40)
        {
            escudosmax = 2;
        }
        else 
        {
            escudosmax = 1;
        }
        

        escudos = escudosmax;
        
        
        
        
        if(escudosmax >= 1)
        {
            vidaescudo1 = vidaescudomax;
        }
        if(escudosmax >= 2)
        {
            vidaescudo2 = vidaescudomax;
        }
        if(escudosmax >= 3)
        {
            vidaescudo3 = vidaescudomax;
        }

        
        nivelvida_a[0] = vidabasetut;
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
        vidamax = nivelvida;



        danoj = nivelfuerza;
        vida = vidamax;
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
        jugador1.explosion = explosion;
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");
        juego = GameObject.Find("juego").transform;

        if(nivelactual >= 70)
        {
            frenetismoarmas = 1.2f;
        }
        else if(nivelactual >= 10)
        {
            frenetismoarmas = 1.1f;
        }
        if(nivelactual >= 90)
        {
            frenetismo = 1.2f;
        }
    }
  

    // Update is called once per frame
    void Update()
    {

        distancia = Vector3.Distance(jugador1.transform.position, transform.position);
        if(distancia < 45 && temp2 > 15)
        {
            escudoV.SetActive(true);
            cerca = true;
        }
        else
        {
            escudoV.SetActive(false);
            cerca = false;
        }

        if(temp2 > 12)
        {
            fre2 = 1.3f;
        }
        else
        {
            fre2 = 1;
        }
        if (temprb > 0f)
        {
            temprb -= Time.deltaTime;
        }
        else{temprb = 0f;}
        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);
        if(jugador1.objetivotarget == transform.gameObject )
        {
            target.SetActive(true);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = escudoact;
            jugador1.escudosene = escudos;


            jugador1.vidaeneui = vidaUI;
            jugador1.vidaeneuimax = vidamax;

            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;

            jugador1.vidaescudomaxene = vidaescudomax;
            temprb = 1;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else if(jugador1.objetivotarget2 == transform.gameObject && jugador1.objetivotarget == null )
        {
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = escudoact;
            jugador1.escudosene = escudos;

            jugador1.vidaeneui = vidaUI;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo2;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;

            jugador1.vidaescudomaxene = vidaescudomax;
            temprb = 1;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else
        {
            target.SetActive(false);
        }

        det.transform.position = this.transform.position;
        
        if (vida < 1)
        {   
            if(modoatk == "encerrar")
            {
                modoatk = "";
                escudovis.transform.position = transform.position;
                jugador1.movact--;
                temprecargafin = 0;
            }
            
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
            if(managerordas != null)
            {
                managerordas.contadorene--;
            }
            if(jugador1.modo == "2D" || jugador1.modo == "3D" )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            GameObject monedae = Instantiate(moneda, transform.position , transform.rotation);
            if(destobj == true)
            {
                Destroy(destruible);
            }
            if(jugador1.objetivotarget2 == this.gameObject)
            {
                jugador1.objetivotarget2 = null;
                jugador1.vidaenebarra.SetActive(false);
            }
            manager.datosserial.asesinatos++;
            manager.guardar();
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            Destroy(transform.parent.gameObject);

        }
        if (escudos == 0)
        {
            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(false);
            escudovis.SetActive(false);
            
            escudoact = false;
            if(tempescudo >= 30)
            {
                escudovis.SetActive(true);
                tempescudo = 0;
                escudoact = true;
                escudos = escudosmax;

                if(escudos == 1 )
                {
                    escudovis.SetActive(true);
                    escudovis1_1.SetActive(true);
                    escudovis1_2.SetActive(false);
                    escudovis1_3.SetActive(false);
                    escudovis2.SetActive(false);
                    
                }
                else if(escudos == 2)
                {
                    escudovis.SetActive(true);
                    escudovis1_1.SetActive(false);
                    escudovis1_2.SetActive(true);
                    escudovis1_3.SetActive(false);
                    escudovis2.SetActive(false);
                }
                else if(escudos == 3)
                {
                    escudovis.SetActive(true);
                    escudovis1_1.SetActive(false);
                    escudovis1_2.SetActive(false);
                    escudovis1_3.SetActive(true);
                    escudovis2.SetActive(false);
                }
                



                if(escudosmax >= 1)
                {vidaescudo1 = vidaescudomax;}
                if(escudosmax >= 2)
                {vidaescudo2 = vidaescudomax;}
                if(escudosmax == 3)
                {vidaescudo3 = vidaescudomax;}
            }
            tempescudo += 1 * frenetismo * Time.deltaTime;

        }
        if(escudos == 1 && tempesc > 0.3f)
        {
            escudovis.SetActive(true);
            escudovis1_1.SetActive(true);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(false);
            
        }
        else if(escudos == 2 && tempesc > 0.3f)
        {
            escudovis.SetActive(true);
            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(true);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(false);
        }
        else if(escudos == 3 && tempesc > 0.3f)
        {
            escudovis.SetActive(true);
            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(true);
            escudovis2.SetActive(false);
        }

        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
            
        }
        else
        {
            anim.SetBool("salto",false);
        }
        if( temprecargafin <= 0)
        {
            temprecargafin = 0;
        }
        else
        {
            temprecargafin -= 1 * Time.deltaTime;
        }
        if(modoatk == "encerrar" && escudos == 0)
        {
            
            modoatk = "";
            escudovis.transform.position = transform.position;
            jugador1.movact--;
            temprecargafin = 0;
        } 
        if(modoatk == "encerrar" && escudos > 0)
        {
            
            escudovis.transform.position = jugador1.transform.position;
            
        } 
        if(modoatk == "explotar1" && escudos == 0 || modoatk == "explotar2" && escudos <= 1)
        {
            modoatk = "";
            temprecargafin = 0;
            anim.SetBool("habcarga",false);
            habcargason.Stop();
        }

        if(modoatk == "explotar1" && escudos > 0 && temprecargafin <= 0)
        {
            GameObject BalaTemporal = Instantiate(explotar1prefab, transform.position,transform.rotation) as GameObject;

            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            BalaTemporal.GetComponent<romperbala_al2>().danofijo = true;
            BalaTemporal.GetComponent<romperbala_al2>().salir = true;
            BalaTemporal.GetComponent<romperbala_al2>().porcentaje = 60;

            BalaTemporal.GetComponent<romperbala_al2>().destb = 4f;

            escudos--;
            modoatk = "";
            temprecargafin = 0;
            anim.SetBool("habcarga",false);
            expson.Play();
            habcargason.Stop();
        }
        if(modoatk == "explotar2" && escudos > 0 && temprecargafin <= 0)
        {
            GameObject BalaTemporal = Instantiate(explotar2prefab, transform.position,transform.rotation) as GameObject;

            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            BalaTemporal.GetComponent<romperbala_al2>().salir = true;
            BalaTemporal.GetComponent<romperbala_al2>().danofijo = true;
            BalaTemporal.GetComponent<romperbala_al2>().porcentaje = 80;

            BalaTemporal.GetComponent<romperbala_al2>().destb = 4f;

            escudos = 0;
            modoatk = "";
            temprecargafin = 0;
            anim.SetBool("habcarga",false);
            expson.Play();
            habcargason.Stop();
        }

        if(detectar == true  && desactivar == false && manager.controlene == true && temprecargafin <= 0)
        {

            if(nivelactual >= 40)
            {randomdec = Random.Range(0,3);}
            else if(nivelactual >= 20)
            {randomdec = Random.Range(0,2);}
            
            if(temp > balafrec && randomdec == 0)
            {
                    GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

                    Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                    BalaTemporal.transform.SetParent(juego);

                    BalaTemporal.GetComponent<romperbala_al2>().danoj = danoj;

                    rb.AddForce(transform.forward * 110 * 5);

                    BalaTemporal.GetComponent<romperbala_al2>().destb = 4f;

                    disp.Play();

                    temp = 0;
            } 
            else if(temp > balafrec && randomdec == 1)
            {
                paloS.toquespalo = 1;
                GameObject slasht = Instantiate(explosionP, transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;
                Destroy(slasht,1f);
                anim.Play("atkpunobig");
                temp = -3;
                paloS.minmun = false;
                paloS.ultimo = false;
                paloS.dano = danoj/2;
                golpeson.Play();
            }
            else if(temp > balafrec && randomdec == 2)
            {
                GameObject BalaTemporal = Instantiate(bombaprefab, pistola.transform.position + (transform.forward * 5),transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                BalaTemporal.transform.SetParent(juego);

                BalaTemporal.GetComponent<romperbala_al2>().danoj = danoj * 1.2f;

                rb.AddForce(new Vector3(0,BalaTemporal.transform.up.y,BalaTemporal.transform.forward.z) * 110 * 5);

                BalaTemporal.GetComponent<romperbala_al2>().destb = 4f;

                disp.Play();

                temp = 0;
            }
            //distancia


            if(nivelactual >= 60)
            {randomdec2 = Random.Range(1,4);}
            else if(nivelactual >= 50)
            {randomdec2 = Random.Range(1,3);}
            else if(nivelactual >= 30)
            {randomdec2 = Random.Range(1,2);}

            if(cerca == true && temp2 > 20 && randomdec2 == 1 && escudos >= 1 && modoatk == "")
            {
                
                modoatk = "encerrar";
                jugador1.movact++;
                temprecargafin = 20;
                randomdec2 = 0;
                temp2 = 0;
                danoescudo.Play();
            }
            else if(cerca == true && temp2 > 20 && randomdec == 2 && modoatk == "")
            {

                if(nivelactual >= 80)
                {randomdec3 = Random.Range(0,2);}

                if(randomdec3 == 0 && escudos >= 2)
                {
                    modoatk = "explotar1";
                    anim.Play("cargahabbig");
                    anim.SetBool("habcarga",true);
                    temprecargafin = 5;
                    temp2 = 0;
                    habcargason.Play();
                    //explotar 60%
                }
                else if(randomdec3 == 1 && escudos >= 3)
                {
                    modoatk = "explotar2";
                    anim.Play("cargahabbig");
                    anim.SetBool("habcarga",true);
                    temprecargafin = 10;
                    temp2 = 0;
                    //explotar 2 80%
                    habcargason.Play();
                }
                //explotar
                randomdec2 = 0;
            }
            else if(cerca == true && temp2 > 20 && randomdec2 == 3 && modoatk == "")
            {
                if(nivelactual >= 90)
                {randomdec3 = Random.Range(0,2);}

                if(randomdec3 == 0 )
                {
                    modoatk = "agarrar1";
                    paloS.toquespalo = 1;
                    paloS.dano = 0;
                    paloS.minmun = true;
                    paloS.ultimo = false;
                    anim.Play("atkgiroene");
                    temp2 = 0;
                    temp = 0;
                    golpeson.Play();
                }
                else if(randomdec3 == 1 )
                {
                    paloS.toquespalo = 1;
                    paloS.dano = 0;
                    paloS.minmun = false;
                    paloS.ultimo = true;
                    modoatk = "agarrar2";
                    anim.Play("atkgiroene");
                    temp2 = 0;
                    temp = 0;
                    golpeson.Play();
                }
                
                randomdec2 = 0;
            }


            

            

            


             
            
            //cerca




            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,-5,-15),vel * frenetismo * fre2 * Time.deltaTime);
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
            
            
            if(temp2 < 25)
            {temp2 += 1 * frenetismoarmas * Time.deltaTime;}
            
        }
        if(tempesc < 15)
        {tempesc += 1 * frenetismoarmas * Time.deltaTime;}


        if(fuera == false )
        {
            if(detect == false)
            {
                escudoV.SetActive(false);
                if(jugador1.modo == "3D"  && staticene == false)
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
                else if(jugador1.modo == "2D"  || staticene == true)
                {
                    anim.SetBool("salto",true);
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
        if(modoatk == "agarrar1" && temp > 1 || modoatk == "agarrar2" && temp > 1  )
        {
            modoatk = "";
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
        if(tempdanodef < 15)
        {tempdanodef += 1 * Time.deltaTime;}
        
        
    }
    private void OnTriggerStay(Collider col)
	{
         if (col.gameObject.tag == "danoarma9" && escudoact == true )
		{
            romperbalajug_al2 balajug = col.gameObject.GetComponent<romperbalajug_al2>();
            jugador1.muertesjug.Stop();

            if(escudos == 3)
            {vidaescudo3 -= (balajug.danoj * Time.deltaTime);}
            else if(escudos == 2)
            {vidaescudo2 -= (balajug.danoj * Time.deltaTime);}
            else if(escudos == 1)
            {vidaescudo1 -= (balajug.danoj * Time.deltaTime);}
            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(true);
            tempesc = 0;

            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo1 <= 0 && escudos == 1)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }    
            else if (vidaescudo2 <= 0 && escudos == 2)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            else if (vidaescudo3 <= 0 && escudos == 3)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            balajug.danoesc = 0;
            detect = true;
        }
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0 && escudoact == false )
		{
            jugador1.toquespalo--;
            vida -= col.gameObject.GetComponent<golpe_al2>().dano * 1.5f;
            danoene.Play();
            //temp = 0;
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.niveleneui.text = nivelactual.ToString();
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            detect = true;
            
		}
        if (col.gameObject.tag == "danoarma10" && escudoact == true && tempdanodef > 15f)
		{
            baladef_exp_al2 balajug = col.gameObject.GetComponent<baladef_exp_al2>();
            jugador1.muertesjug.Stop();
            if(escudos == 3)
            {vidaescudo3 -= balajug.danoesc;}
            else if(escudos == 2)
            {vidaescudo2 -= balajug.danoesc;}
            else if(escudos == 1)
            {vidaescudo1 -= balajug.danoesc;}
            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(true);
            tempesc = 0;

            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo1 <= 0 && escudos == 1)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }    
            else if (vidaescudo2 <= 0 && escudos == 2)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            else if (vidaescudo3 <= 0 && escudos == 3)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            balajug.danoesc = 0;
            detect = true;
            tempdanodef = 0;
		}
        if (col.gameObject.tag == "danoarma8" )
		{
            romperbalajug_al2 balajug = col.gameObject.GetComponent<romperbalajug_al2>();
            jugador1.muertesjug.Stop();
            
            if(escudos == 3)
            {vidaescudo3 -= balajug.danoesc;}
            else if(escudos == 2)
            {vidaescudo2 -= balajug.danoesc;}
            else if(escudos == 1)
            {vidaescudo1 -= balajug.danoesc;}

            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(true);
            tempesc = 0;

            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo1 <= 0 && escudos == 1)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }    
            else if (vidaescudo2 <= 0 && escudos == 2)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            else if (vidaescudo3 <= 0 && escudos == 3)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            balajug.danoesc = 0;
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
            if(modoatk == "encerrar")
            {
                modoatk = "";
                escudovis.transform.position = transform.position;
                jugador1.movact--;
                temprecargafin = 0;
            }
            if(destobj == true)
            {
                Destroy(destruible);
            }
			Destroy(transform.parent.gameObject);
		}
        
    }
    private void OnTriggerExit(Collider col)
	{
        
       
        

        if (col.gameObject.tag == "danoarma8" && escudoact == true && modoatk == "encerrar")
		{
            romperbalajug_al2 balajug = col.gameObject.GetComponent<romperbalajug_al2>();
            jugador1.muertesjug.Stop();
            
            if(escudos == 3)
            {vidaescudo3 -= balajug.danoesc;}
            else if(escudos == 2)
            {vidaescudo2 -= balajug.danoesc;}
            else if(escudos == 1)
            {vidaescudo1 -= balajug.danoesc;}
            escudovis1_1.SetActive(false);
            escudovis1_2.SetActive(false);
            escudovis1_3.SetActive(false);
            escudovis2.SetActive(true);
            tempesc = 0;

            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudoene2 = vidaescudo2;
            jugador1.vidaescudoene3 = vidaescudo3;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo1 <= 0 && escudos == 1)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }    
            else if (vidaescudo2 <= 0 && escudos == 2)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            else if (vidaescudo3 <= 0 && escudos == 3)
            {
                escudos--;
                expson.Play();
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
            balajug.danoesc = 0;
            detect = true;
		}
        
        
    }
}
