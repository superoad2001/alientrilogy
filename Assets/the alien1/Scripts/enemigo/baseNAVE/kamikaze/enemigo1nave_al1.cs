using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1nave_al1: MonoBehaviour
{
	public manager_al1 manager;
    public GameObject objetivo;
    public GameObject objetivob;
    public bool destobj;
    public GameObject destruible;
    public GameObject moneda;
    public Rigidbody rb_;
    public float vel = 2;
    public float raycastDistance = 1f;
    public bool desactivar;
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

    public GameObject target;
    public float valorexp = 1f;
    public float vidabase = 999;
    public float vidabasemax = 9999;
    public float vidaplusmax = 99999;

    public float defensabase = 300;
    public float defensabasemax = 3000;
    public float defensaplusmax = 30000;
    public int nivelactual = 1;

    public float fuebase = 300;
    public float fuebasemax = 3000;
    public float fueplusmax = 50000;
    public float nivelfuerza;
    public float nivelvida;
    public float[] nivelfuerza_a = new float[20];
    public float[] nivelvida_a = new float[20];
    public tutorialbase_al1 eventotut;
    public float temp;
    public float vidaUI;
    private Vector3 []objetivoa = new Vector3[4]; 
    private Vector3 objetivon;
    public float[] niveldefensa = new float[20];
    private float temprb;
    public string modo;
    private float disparos;
    public bool programado;
    public float frenetismo = 1;
    public GameObject balaprefab2;
    private GameObject objetivo1;
    private GameObject objetivo1b;
    public bool disparodes;
    // Start is called before the first frame update
    void Start()
    {
        if(nivelactual >= 15)
        {
            frenetismo = 1.2f;
        }
        else if(nivelactual >= 5)
        {
            frenetismo = 1.1f;
        }


        if(nivelactual >= 8)
        {
            disparodes = true;
        }
        vidabase = 999;
        vidabasemax = 9999;
        vidaplusmax = 99999;

        fuebase = 300;
        fuebasemax = 3000;
        fueplusmax = 50000;


        vel = 30;

        if(programado == false)
        {
            if(nivelactual >= 20)
            {
                int randomini = Random.Range(0,2);

                if(randomini == 1)
                {
                    modo = "disparo";
                    disparos = 10;
                }
            }
            if(nivelactual >= 60)
            {
                modo = "disparo";
                disparos = 10;
            }
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

        if (temprb == 0f)
        {
            
        }
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
            jugador1.vidaescudomaxene = 0;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else if(jugador1.objetivotarget2 == transform.gameObject && jugador1.objetivotarget == null)
        {
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = false;
            jugador1.escudosene = 0;
            jugador1.vidaeneui = vidaUI;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = 0;
            jugador1.vidaescudomaxene = 0;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else
        {
            target.SetActive(false);
        }
        if (vida < 1 && temprb == 0)
        {
            if(jugador1.modo == "2D" || jugador1.modo == "3D" )
            {
                jugador1.enemigosEnContacto.Remove(det.gameObject);
            }
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = transform.localScale;

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
            if(jugador1.objetivotarget2 == this.gameObject)
            {
                jugador1.objetivotarget2 = null;
            }
            Destroy(transform.parent.gameObject);

        }
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        
        if( desactivar == false && manager.controlene == true)
        {

            if(temp > 1 && disparodes == true  )
            {
                GameObject BalaTemporal = Instantiate(balaprefab1, transform.position,transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                BalaTemporal.GetComponent<romperbala_al1>().danoj = nivelfuerza/2;

                rb.AddForce(BalaTemporal.transform.forward * 110 * 20);

                BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                disp.Play();

                temp = 0;
            }
            if(temp < 15)
            {temp += 1 * frenetismo *Time.deltaTime;}

            transform.position = Vector3.MoveTowards(transform.position,jugador1.transform.position,vel * frenetismo * Time.deltaTime);



            // te vio
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
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
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
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
		}
        if (col.gameObject.tag == "Player" && temprb == 0 )
		{
            jugador1.muertesjug.Play();
            jugador1.vida -= danoj;
            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            muertes.Play();
            Destroy(explosiont, 1f);
            int RandomM = Random.Range(0,2);
            if(jugador1.objetivotarget2 == this.gameObject)
            {
                jugador1.objetivotarget2 = null;
            }
            Destroy(transform.parent.gameObject);
            
        }
        

        
        
    }
}
