
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo3nave_al1: MonoBehaviour
{
	public manager_al1 manager;
    public GameObject objetivo;
    public GameObject objetivob;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public float temp;
    public GameObject explosion;
    public jugador_al1 jugador1;
    public AudioSource muertes;
    public AudioSource disp;

    public float vida;
    public float vidaUI;
    public float vidamax;
    public Image vidab;


    private  float frenetismo = 1;


    public AudioSource danoene;
    public AudioSource danoescudo;
    public GameObject vidamenu;
    public float temprb;

    public GameObject escudovis;
    public GameObject escudovis1;
    public GameObject escudovis2;
    public bool escudoact;
    public float tempescudo;
    public float tempesc;
    public float danoj = 8;
    public float vidaescudo1;
    public float vidaescudomax = 10;
    public GameObject target;
    
    public float nivelfuerza;
    public float nivelvida;
    public int nivelactual = 1;

    public float valorexp = 2f;
    public float vidabase = 99;
    public float vidabasemax = 999;
    public float vidaplusmax = 9999;

    public float fuebase = 30;
    public float fuebasemax = 300;
    public float fueplusmax = 4000;
    public GameObject moneda;

    public float escudovida_noplus = 30;
    public float escudovida_plus = 100;
    public float[] niveldefensa = new float[20];

    public bool new_game_plus;
    
    private Vector3[] objetivoa = new Vector3[4]; 
    private Vector3 objetivon;


    public float[] nivelfuerza_a = new float[20];
    public float[] nivelvida_a = new float[20];

    public GameObject balaprefab1;
    public GameObject balaprefabonda;
    public float defensabase = 5;
    public float defensabasemax = 50;
    public float defensaplusmax = 500;
    public int escudos = 1;
    public int escudosmax = 1;
    public bool disparomina;
    public bool disparodes;
    public bool spawn_ovni;
    public bool ondaact;
    public float Randomdec;
    public GameObject prefabene1;
    public GameObject prefabene2;
    public GameObject[] enelist = new GameObject[2];
    public void Awake()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
    }
    public manager_ordas_nave_al1 managerordas;
    // Start is called before the first frame update
    void Start()
    {

        if(nivelactual >= 5)
        {
            disparodes = true;
        }
        if(nivelactual >= 8)
        {
            spawn_ovni = true;
        }
        if(nivelactual >= 15)
        {
            ondaact = true;
        }
        vidabase = 999;
        vidabasemax = 9999;
        vidaplusmax = 99999;

        fuebase = 70;
        fuebasemax = 700;
        fueplusmax = 14000;
        if((manager_ordas_nave_al1)FindFirstObjectByType(typeof(manager_ordas_nave_al1))!= null)
        {
        	managerordas = (manager_ordas_nave_al1)FindFirstObjectByType(typeof(manager_ordas_nave_al1));
        }
        objetivoa[0] = transform.position + new Vector3(0,0,-5);
        objetivoa[1] = transform.position + new Vector3(0,0,5);
        objetivoa[2] = transform.position + new Vector3(-5,0,0);
        objetivoa[3] = transform.position + new Vector3(5,0,0);
        if(GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            rb_ = GetComponent<Rigidbody>();
        }
        
        vidaUI = vida;

        if(new_game_plus == true)
        {
            vidaescudomax = escudovida_plus;
        }  
        else
        {
            vidaescudomax = escudovida_noplus;
        }


        escudosmax = 1;
        
        

        escudos = escudosmax;
        escudoact = true;
        
        
        vidaescudo1 = vidaescudomax;


        
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
        vidamax = nivelvida;



        danoj = nivelfuerza;
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");


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
        if(jugador1.objetivotarget == transform.gameObject)
        {
            target.SetActive(true);
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = escudoact;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vidaUI;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudomaxene = vidaescudomax;
            temprb = 1;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else if(jugador1.objetivotarget2 == transform.gameObject && jugador1.objetivotarget == null)
        {
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudoeneact = escudoact;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vidaUI;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudomaxene = vidaescudomax;
            temprb = 1;
            jugador1.niveleneui.text = nivelactual.ToString();
        }
        else
        {
            target.SetActive(false);
        }
        
        if (vida < 1)
        {   
            
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
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

            if(jugador1.objetivotarget2 == this.gameObject)
            {
                jugador1.objetivotarget2 = null;
            }
            
            Destroy(transform.parent.gameObject);

        }
        if (escudos == 0)
        {
            escudovis.SetActive(false);
            escudoact = false;
            if(tempescudo >= 10)
            {
                escudovis1.SetActive(true);
                escudovis2.SetActive(false);
                escudovis.SetActive(true);
                tempescudo = 0;
                escudoact = true;
                escudos = escudosmax;
                if(escudosmax >= 1)
                {vidaescudo1 = vidaescudomax;}
            }
            tempescudo += 1 * frenetismo * Time.deltaTime;

        }
        if(escudos == 1 && tempesc > 1f)
        {
            escudovis1.SetActive(true);
            escudovis2.SetActive(false);
            tempesc = 0;
        }
        tempesc += 1 * frenetismo * Time.deltaTime;


        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
            
        }



        if(desactivar == false && manager.controlene == true )
        {


            if(nivelactual >= 15)
            {
                Randomdec = Random.Range(0,4);
            }
            else if(nivelactual >= 8)
            {
                Randomdec = Random.Range(0,3);
            }
            else if(nivelactual >= 5)
            {
                Randomdec = Random.Range(0,2);
            }


    	    int comprobarene = 0;


            if(enelist[0] != null)
            {
                comprobarene++;
            }
            if(enelist[1] != null)
            {
                comprobarene++;
            }

            if(temp > 10 && Randomdec == 0 && comprobarene < 2)
            {
                GameObject ene1 = Instantiate(prefabene1, transform.position,transform.rotation) as GameObject;
                enemigo1nave_al1 ene1tempS  = ene1.transform.Find("enemigo").gameObject.GetComponent<enemigo1nave_al1>();
                ene1tempS.nivelactual = nivelactual;
                for(int i = 0 ;i < 2;  i++ )
                {
                    if(enelist[i] == null)
                    {
                        enelist[i] = ene1;
                        i = 2;
                    }
                }

                temp = 0;
            }
            else if(temp > 10 && disparodes == true  && Randomdec == 1)
            {
                GameObject BalaTemporal = Instantiate(balaprefab1, transform.position,transform.rotation) as GameObject;

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                BalaTemporal.GetComponent<romperbala_al1>().danoj = nivelfuerza * 2;

                rb.AddForce(BalaTemporal.transform.forward * 110 * 20);

                BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                disp.Play();

                temp = 0;
            }
            else if(temp > 10 && spawn_ovni == true && Randomdec == 2 && comprobarene < 2)
            {
                GameObject ene2 = Instantiate(prefabene2, transform.position,transform.rotation) as GameObject;
                enemigo2nave_al1 ene1tempS  = ene2.transform.Find("enemigo").gameObject.GetComponent<enemigo2nave_al1>();
                ene1tempS.nivelactual = nivelactual;
                ene1tempS.programado = true;
                for(int i = 0 ;i < 2;  i++ )
                {
                    if(enelist[i] == null)
                    {
                        enelist[i] = ene2;
                        i = 2;
                    }
                }
                temp = 0;
            }
            else if(temp > 10 && ondaact == true  && Randomdec == 3)
            {


                GameObject BalaTemporal = Instantiate(balaprefabonda, transform.position,transform.rotation) as GameObject;

                Rigidbody rbb = BalaTemporal.GetComponent<Rigidbody>();

                rbb.AddForce(transform.forward * 110 * 40);
                

                BalaTemporal.GetComponent<romperbala_al1>().destb = 0.4f;
                BalaTemporal.GetComponent<romperbala_al1>().danoj = 2 * nivelfuerza;
                

                disp.Play();
            }
            if(temp < 15)
            {temp += 1 * Time.deltaTime;}
           
        

            
            
        }
        
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "danoarma8" && escudoact == true )
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            
            if(escudos == 1)
            {vidaescudo1 -= balajug.danoesc;}

            escudovis1.SetActive(false);
            escudovis2.SetActive(true);
            tempesc = 0;

            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo1 <= 0 && escudos == 1)
            {
                escudos--;
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            jugador1.escudoeneact = escudoact;
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
		}
        else if (col.gameObject.tag == "danoarma8" && escudoact == false )
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            danoene.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            jugador1.escudoeneact = escudoact;
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
		}
	}
    private void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "danoarma9" && escudoact == true )
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            if(escudos == 1)
            {vidaescudo1 -=  balajug.danoesc;}
            escudovis1.SetActive(false);
            escudovis2.SetActive(true);
            tempesc = 0;
            danoescudo.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            if (vidaescudo1 <= 0 && escudos == 1)
            {
                escudos--;
                GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
                Destroy(explosiont, 1f);
            }
            jugador1.escudoeneact = escudoact;
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
		}
        else if (col.gameObject.tag == "danoarma9" && escudoact == false )
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            danoene.Play();
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.escudosene = escudos;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaescudoene1 = vidaescudo1;
            jugador1.vidaescudomaxene = vidaescudomax;
            jugador1.niveleneui.text = nivelactual.ToString();
            jugador1.escudoeneact = escudoact;
            if(jugador1.tempretarget > 1)  
            {jugador1.objetivotarget2 = this.gameObject;}
		}
        

        
        
    }
}
