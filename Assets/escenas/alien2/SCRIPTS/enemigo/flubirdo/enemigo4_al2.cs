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
    public enemigodet2_al2 enemigodet;
    public GameObject dano;
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
    public bool fly;
    public float fly_Y;
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

        vidamax = nivelvida;
        
        

        danoj = nivelfuerza;
        
        vida = vidamax;
        vidaUI = vida;
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
        jugador1.explosion = explosion;
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");
        juego = GameObject.Find("juego").transform;
    }
    public void Awake()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
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

        if(fly)
        {
            fly_Y = jugador1.mod.transform.position.y + 5;
            rb_.linearVelocity = new Vector3(rb_.linearVelocity.x,0,rb_.linearVelocity.z);
        }



        det.transform.position = this.transform.position;
        dano.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y + 4.14f,this.transform.position.z);
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
        


        if(detectar == true && desactivar == false && manager.controlene == true && cancelatk == 0)
        {


            
            if(fly == false)
            {
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
                temp += 1 * frenetismo * Time.deltaTime;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z),3 * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(transform.position.x,fly_Y,transform.position.z),vel * Time.deltaTime);
                temp += 1 * frenetismo * Time.deltaTime;
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
                    transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivon.x,transform.position.y,objetivon.z),vel * Time.deltaTime);
                    anim.SetFloat("vely",1);
                }
                else if(jugador1.modo == "2D"   || staticene == true)
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
            else if(detect == true && staticene2 == false)
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
