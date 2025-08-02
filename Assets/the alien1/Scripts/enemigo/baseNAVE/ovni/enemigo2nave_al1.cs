using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo2nave_al1: MonoBehaviour
{
	public manager_al1 manager;
    public bool muertetemp;
    public GameObject moneda;
    public float tempM;
    public float temprb;
    private Rigidbody rb_;
    public bool destobj;
    public GameObject objetivo;
    public GameObject objetivob;
    public Transform objetivo1;
    public Transform objetivo1b;
    public float vel = 1;
    public bool desactivar;
    public float temp;
    public GameObject explosion;
    public int nivel = 1;
    public jugador_al1 jugador1;
    public AudioSource muertes;
    public float balafrec = 1.5f;
    public GameObject balaprefab;
    public GameObject balaprefabonda;
    public AudioSource disp;
    public float vida;
    public float vidamax;
    public int nivelactual = 1;

    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;

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

    public float[] nivelfuerza_a = new float[20];
    public float[] nivelvida_a = new float[20];
    public float[] niveldefensa = new float[20];
    public manager_ordas_al1 managerordas;

    public string modo;

    public float defensabase = 5;
    public float defensabasemax = 50;
    public float defensaplusmax = 500;
    
    public float frenetismo;
    public GameObject prefabmina;
    public bool disparomina;
    public float frenetismoarmas;
    public float Randomdec;
    //tendra siempre la mitad de stats que el enemigo actual excepto si su vitalidad baja de 2 lo hara al bajar de 10%


    
    // Start is called before the first frame update
    void Start()
    {
         if(nivelactual >= 5)
        {
            vel = vel * 1.2f;
        }
        if(nivelactual >= 8)
        {
            frenetismoarmas = 1.2f;
        }
        if(nivelactual >= 15)
        {
            disparomina = true;
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
        
        vida = vidamax;
        vidaUI = vida;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
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
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();
            jugador1.escudoeneact = false;
        }
        else
        {
            target.SetActive(false);
        }



        if (muertetemp == true)
        {
            if(tempM > 45)
            {
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
            if(managerordas != null)
            {
                managerordas.contadorene--;
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
        


        if(desactivar == false && manager.controlene == true)
        {
            if(disparomina == true)
            {
                Randomdec = Random.Range(0,2);
            }

            if(temp > 3 && Randomdec == 0)
            {
                GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                BalaTemporal.GetComponent<romperbala_al1>().danoj = nivelfuerza;

                rb.AddForce(BalaTemporal.transform.forward * 110 * 20);

                BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                disp.Play();

                temp = 0;
            }
            if(temp > 3 && disparomina == true && Randomdec == 1)
            {

                GameObject BalaTemporal = Instantiate(balaprefabonda, transform.position,transform.rotation) as GameObject;

                Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

                rbb.AddForce(transform.forward * 110 * 20);

                BalaTemporal.GetComponent<romperbalajug_al1>().destb = 60f;
                BalaTemporal.GetComponent<romperbalajug_al1>().danoj = nivelfuerza * 2;
                

                disp.Play();
            }
            if(temp < 15)
            {temp += 1 * frenetismoarmas * Time.deltaTime;}

            

            
            
        }
    
        
        
    }
    private void OnTriggerEnter(Collider col)
	{

        if (col.gameObject.tag == "danoarma8")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            danoene.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();  
		}
	}
    private void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "danoarma9"  )
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            danoene.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.niveleneui.text = nivelactual.ToString();  
		}

        

        
        
    }
}
