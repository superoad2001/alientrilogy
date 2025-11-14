using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo4_al2: MonoBehaviour
{
    public int nivelactual = 1;
    public GameObject escudoin;
	public manager_al2 manager;
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
    public bool staticene;
    public bool staticene2;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public enemigodet4_al2 enemigodet;
    public GameObject det;
    public float temp;
    public Animator anim;
    public GameObject explosion;
    public jugador_al2 jugador1;
    public AudioSource muertes;
    public int enemigo = 1;
    public float balafrec = 1.5f;
    public int enemigo3;
    public GameObject balaprefab;
    public AudioSource disp;
    public Transform juego;
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


    public float nivelfuerza;
    public float nivelvida;

    private Vector3[] objetivoa = new Vector3[4]; 
    private Vector3 objetivon;

    public float[] nivelfuerza_a = new float[100];
    public float[] nivelvida_a = new float[100];
    public float[] niveldefensa = new float[100];
    public manager_ordas_al2 managerordas;

    public string modo;

    public float defensabase = 5;
    public float defensabasemax = 50;
    public float defensaplusmax = 500;

    public float frenetismo;
    public float cancelatk;
    public bool fuera;
    public bool gigante;
    public float tempdisp;
    public float temphab;
    public float tempesp;
    public bool fly;
    public float fly_Y;
    public float tempflyact;
    public bool flyact;
    public bool programado;
    private float danoazar;
    private float minimodisp = 3;
    private int contadordisp;
    private bool actrafaga;
    private int randomdisp = 0;
    public GameObject pistola;
    public golpe_al2 paloSC;
    public GameObject ondasprefab;
    public GameObject peque;
    public GameObject grande;
    public GameObject marcado;
    private int randomdano;
    //tendra siempre la mitad de stats que el enemigo actual excepto si su vitalidad baja de 2 lo hara al bajar de 10%


    
    // Start is called before the first frame update
    void Start()
    {

        if((manager_ordas_al2)FindFirstObjectByType(typeof(manager_ordas_al2))!= null)
        {
        	managerordas = (manager_ordas_al2)FindFirstObjectByType(typeof(manager_ordas_al2));
        }
        objetivoa[0] = transform.position + new Vector3(0,0,-5);
        objetivoa[1] = transform.position + new Vector3(0,0,5);
        objetivoa[2] = transform.position + new Vector3(-5,0,0);
        objetivoa[3] = transform.position + new Vector3(5,0,0);
        objetivon = objetivoa[Random.Range(0,4)];
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
        if(programado == false)
        {
            vidamax = nivelvida;
            vida = vidamax;
        }
        
        

        danoj = nivelfuerza;
        
        
        vidaUI = vida;
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
        jugador1.explosion = explosion;
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");
        juego = GameObject.Find("juego").transform;

        if(gigante == false && programado == false)
        {
            vidamax = vidamax * 2;
            vida = vidamax;
        }
        if(nivelactual >= 10)
        {
            flyact = true;
        }
        if(nivelactual >= 70)
        {
            frenetismo = 1.2f;
        }
        if(gigante == false)
        {
            vel = 8;
        }
        else
        {
            vel = 6;
        }
        if(gigante == false && nivelactual >= 90)
        {
            vel = 10;
        }

    }
    public void Awake()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
    }

    // Update is called once per frame
    void Update()
    {
        if(gigante == true)
        {
            vel = 6;
        }
        int randomdano = 0;
        if(nivelactual >= 50)
        {
            randomdano = Random.Range(0,2);
        }
        
        if(randomdano == 0)
        {
            danoazar = 1;
        }
        else if(randomdano == 1)
        {
            danoazar = 1.5f;
        }
        
        if(cancelatk < 0)
        {
            cancelatk = 0;
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

        if(fly)
        {
            fly_Y = jugador1.mod.transform.position.y + 5;
            rb_.linearVelocity = new Vector3(rb_.linearVelocity.x,0,rb_.linearVelocity.z);
        }



        det.transform.position = this.transform.position;
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
            manager.datosserial.enemigosderrotados[3]++;
			manager.datosserial.aliensderrotados++;
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
        


        if(detectar == true && desactivar == false && manager.controlene == true && cancelatk == 0)
        {

            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
            
            if(fly == false)
            {
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),2 * Time.deltaTime);
                temp += 1 * frenetismo * Time.deltaTime;
                anim.SetInteger("modo",4);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z),vel * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(transform.position.x,fly_Y,transform.position.z),2 * Time.deltaTime);
                temp += 1 * frenetismo * Time.deltaTime;
                anim.SetInteger("modo",3);
            }
            if(nivelactual >= 60 && tempdisp >= minimodisp)
            {
                if(contadordisp <= 0 && actrafaga == true)
                {
                    contadordisp = 3;
                    minimodisp = 1;
                    actrafaga = false;
                }
            }
            else if(nivelactual < 60 && tempdisp >= minimodisp)
            {
                minimodisp = 3;
            }
            if(tempdisp >= minimodisp)
            {

                //disparos en random

                if(nivelactual >= 20)
                {
                    randomdisp = Random.Range(0,2);
                }
                else
                {
                    randomdisp = 0;
                }
                

                if(randomdisp == 0)
                {
                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al2>().danoj = danoj * danoazar;

                        rb.AddForce(BalaTemporal.transform.forward * 110 * 20);

                        BalaTemporal.GetComponent<romperbala_al2>().destb = 4f;

                        disp.Play();

                        temp = 0;
                }
                else if(randomdisp == 1)
                {
                    GameObject BalaTemporal = Instantiate(ondasprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al2>().danoj = danoj * danoazar;

                        rb.AddForce(BalaTemporal.transform.forward * 110 * 5);

                        BalaTemporal.GetComponent<romperbala_al2>().destb = 4f;

                        disp.Play();

                        temp = 0;
                }
                tempdisp = 0;

                if(minimodisp >= 3)
                {
                    actrafaga = true;
                }

                if(contadordisp > 0)
                {
                    contadordisp -= 1;
                }
                else
                {
                    minimodisp = 3;
                }
                
            }



            if(temphab > 10 && nivelactual >= 40)
            {
                int Randomhab = 0;
                if(gigante && nivelactual >= 50)
                {
                    Randomhab = Random.Range(0,2);
                }
                

                if(Randomhab == 0)
                {
                    paloSC.toquespalo = 1;
                    paloSC.dano =  danoj * danoazar;
                    anim.Play("embestida");
                    rb_.AddForce(3000 * transform.TransformDirection(new Vector3 (0,0,1)));
                    temp = 0;
                }
                if(Randomhab == 1)
                {
                    paloSC.toquespalo = 1;
                    paloSC.dano =  danoj * danoazar;
                    anim.Play("panzazo");
                    rb_.AddForce(1000 * transform.TransformDirection(new Vector3 (0,-1,0)));
                    temp = 0;
                }
            }



            if(gigante == false && tempesp >= 120 && marcado == null && nivelactual >= 80)
            {
                GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
                Destroy(explosiont, 1f);

                GameObject enetemp2 = Instantiate(grande, transform.position , transform.rotation);
                enemigo4_al2 ene2tempS = enetemp2.transform.Find("enemigo").gameObject.GetComponent<enemigo4_al2>();
                ene2tempS.vidamax = vidamax * 2;
                ene2tempS.vida = vida * 2;
                ene2tempS.programado = true;
                ene2tempS.nivelactual = nivelactual;
                ene2tempS.detectar = true;
                ene2tempS.gigante = true;
                Destroy(transform.parent.gameObject);
                tempesp = 0;
            }
            
            if(gigante == true && tempesp >= 180 && marcado == null && nivelactual >= 30)
            {
                if(managerordas != null)
                {
                    managerordas.contadorene += 1;
                }
                GameObject enetemp = Instantiate(peque, transform.position + new Vector3(0,0,4), transform.rotation);
                enemigo4_al2 ene1tempS = enetemp.transform.Find("enemigo").gameObject.GetComponent<enemigo4_al2>();
                ene1tempS.nivelactual = nivelactual;
                ene1tempS.detectar = true;
                ene1tempS.marcado = this.gameObject;
                tempesp = 0;
                marcado = ene1tempS.gameObject;
            }
            if (marcado != null)
            {
                tempesp = 0;
            }


            if(temphab < 15)
            {temphab += 1 * Time.deltaTime;}
            
            if(tempesp < 500)
            {tempesp += 1 * Time.deltaTime;}


            if(tempdisp< 15)
            {tempdisp += 1 * Time.deltaTime;}

            if(flyact == true && tempflyact >= 30)
            {
                tempflyact = 0;
                fly = true;
            }
            else
            {
                tempflyact += 1 * Time.deltaTime;
            }

            

            
            
        }
        if(detectar == true && desactivar == false && manager.controlene == true )
        {
            
        }
        if(fuera == false )
        {
            if(detect == false)
            {
                if(jugador1.modo == "3D"  && staticene == false)
                {
                    if(new Vector3(objetivon.x,transform.position.y,objetivon.z) == transform.position)
                    {
                        objetivon = objetivoa[Random.Range(0,4)];
                    }
                    Vector3 direction2 = objetivon - transform.position;
                    rotation = Quaternion.LookRotation(direction2);
                    transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                    transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivon.x,transform.position.y,objetivon.z),2 * Time.deltaTime);
                    if(fly == false)
                    {
                        anim.SetInteger("modo",4);
                    }
                    else
                    {
                        anim.SetInteger("modo",3);
                    }
                }
                else if(jugador1.modo == "2D"   || staticene == true)
                {
                    if(fly == false)
                    {
                        anim.SetInteger("modo",2);  
                    }
                    else
                    {
                        anim.SetInteger("modo",1);
                    }
                }
                    // Lanzar rayo hacia abajo
                RaycastHit hit;
                if(Physics.Raycast(transform.position, -transform.up, out hit, Mathf.Infinity,0, QueryTriggerInteraction.Ignore))
                {
                    if (hit.distance < 0.1f)
                    {
                        
                    }
                }
            }
            else if(detect == true && staticene2 == false)
            {
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador1.transform.position.x,transform.position.y,jugador1.transform.position.z),2 * Time.deltaTime);
            }

            
        }
        else
        {

        }
        if(tempdanodef < 15)
        {tempdanodef += 1 * Time.deltaTime;}
        
        
    }
    private void OnTriggerExit(Collider col)
	{
        
        if (col.gameObject.tag == "armajug" )
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 2)
                {
                    romperbala_al2 balajug = col.gameObject.GetComponent<romperbala_al2>();
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
            
            
        }
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0 )
		{
            cancelatk--;
            jugador1.toquespalo--;
            vida -= (col.gameObject.GetComponent<golpe_al2>().dano * extraD);
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
        if (col.gameObject.tag == "armajug" && tempdanodef > 15f)
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 3)
                {
                    baladef_exp_al2 balajug = col.gameObject.GetComponent<baladef_exp_al2>();
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
            }
            
            
		}
        if (col.gameObject.tag == "danoarma" )
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 1)
                {
                    cancelatk--;
                    romperbala_al2 balajug = col.gameObject.GetComponent<romperbala_al2>();
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
            }
            
		}
        if (col.gameObject.tag == "armajug")
		{
            if(col.gameObject.GetComponent<romperbalajug_al2>() != null)
            {
                if(col.gameObject.GetComponent<romperbalajug_al2>().idarma == 2)
                {
                    detectar = false;
                    if(jugador1.tempretarget > 1)  
                    {jugador1.objetivotarget2 = this.gameObject;}
                    detect = true;
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
                    romperbala_al2 balajug = col.gameObject.GetComponent<romperbala_al2>();
                    vida -= (balajug.danoj * extraD * Time.deltaTime);
                    detectar = false;
                }
            }
            
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
            if(destobj == true)
            {
                Destroy(destruible);
            }
			Destroy(transform.parent.gameObject);
		}
        
    }
}
