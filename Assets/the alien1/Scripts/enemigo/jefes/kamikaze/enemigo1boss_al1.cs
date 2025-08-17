using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1boss_al1: MonoBehaviour
{
    public float vida;
    public GameObject plataformas;
    public float vidamax;
    public manager_al1 manager;
    public Text vidat2;
    public GameObject objetivo;
    public GameObject objetivoa;
    public GameObject objetivob;
    public Quaternion rotation;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public float vidaUI;

    public float danoj;
    public GameObject dano;
    public GameObject explosion;
    public jugador_al1 jugador1;
    public AudioSource muertes;
    public float temp;

    public GameObject balaprefab;

    public Transform juego;

    public float balafrec;

    public AudioSource disp;
    public Text vidat;

    public Text conseguido;
	public GameObject aparece;
    public Image vidab;

    public bool fin;
    public Animator cam;

	public float Temp;

    public Animator conseguidoa;
	public AudioSource fanfarria;
    public AudioSource musica;
    public AudioSource danoene;
    public float nivelexp;
    public float nivelfuerza;
    public float nivelvida;
    public float niveldefensa;

    public float valorexp = 10f;
    public float vidabasetut = 99;
    public float vidabase = 999;
    public float vidabasemax = 9999;
    public float vidaplusmax = 99999;
    public bool detectar;
    public float fuebasetut = 1;
    public float fuebase = 10;
    public float fuebasemax = 100;
    public float fueplusmax = 2000;
    public int nivelactual = 1;
    public Text niveltxt;
    public float []nivelfuerza_a = new float[100];
    public float []nivelvida_a = new float[100];
    public float vidacabezamax = 4;
    private int vidacabeza;
    public Vector3 tamano;
    public GameObject plat1;
    public GameObject plat2;
    public GameObject plat3;
    public float recdano;
    public float tempmov;

    // Start is called before the first frame update
    void Start()
    {
        objetivo = objetivoa;
        fuebase = 10;
        fuebasemax = 100;
        fueplusmax = 2000;

        tempmov = 5;

        if(manager.datosserial.newgameplus1 == false)
        {valorexp = 30;}
        else
        {valorexp = 100;}
        
        vidaUI = vida;
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

        nivelfuerza = nivelfuerza_a[nivelactual-1];
        nivelvida = nivelvida_a[nivelactual-1];
        vidamax = nivelvida;
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
    }

    // Update is called once per frame
    void Update()
    {
        if(vida > (vidamax/4) * 3)
        {
            tamano = new Vector3(4.14f,4.14f,4.14f);
        }
        else if(vida > (vidamax/4) * 2)
        {
            tamano = new Vector3(6,6,6);
            if(manager.datosserial.newgameplus1 == false)
            {plat1.SetActive(true);}
        }
        else if(vida > (vidamax/4) * 1)
        {
            tamano = new Vector3(10,10,10);
            if(manager.datosserial.newgameplus1 == false)
            {plat2.SetActive(true);}
            
        }
        else if(vida > (vidamax/4) * 0)
        {
            tamano = new Vector3(12,12,12);
            if(manager.datosserial.newgameplus1 == false)
            {plat3.SetActive(true);}
        }
        if(recdano <= 0 && tempmov >= 2)
        {
            objetivo = objetivoa;
        }
        else if(recdano <= 0 && tempmov < 2)
        {
            vel = 5;
            objetivo = objetivob;
        }
        else
        {
            vel = 30;
            objetivo = objetivob;
        }
        float veltam = 0.02f;
        transform.localScale = new Vector3(Mathf.Lerp(transform.localScale.x, tamano.x, veltam * Time.deltaTime), Mathf.Lerp(transform.localScale.y, tamano.y, veltam * Time.deltaTime), Mathf.Lerp(transform.localScale.z, tamano.z, veltam * Time.deltaTime));
        dano.transform.localScale = transform.localScale;
        
        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);
        niveltxt.text = nivelactual.ToString();
        vidab.fillAmount = vidaUI/vidamax;
        float compvida = vida;
        vidacabeza = 0;
        for(int i = 0 ;i < vidacabezamax ; i++)
        {
            compvida -= vidamax/vidacabezamax;
            vidacabeza++;
            if(compvida <= 0)
            {
                break;
            }
        }
        if(vida == 0)
        {
           vidacabeza = 0;
        }
		vidat.text = (int)vida+"/"+(int)vidamax;
        vidat2.text = (int)(vidacabeza)+"/"+(int)vidacabezamax;

        dano.transform.position = this.transform.position;
        
        if(detectar == true && desactivar == false && manager.controlene == true && vida >= 1)
        {
            
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z),vel * Time.deltaTime);
            Vector3 direction = objetivo.transform.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
        


            if(temp > balafrec)
            {
                            GameObject BalaTemporal = Instantiate(balaprefab,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                            BalaTemporal.GetComponent<romperbala_al1>().danoj = nivelfuerza;

                            BalaTemporal.GetComponent<romperbala_al1>().objtele = objetivo;

                            disp.Play();

                            temp = 0;
            }
            if(temp < 15)
            {temp += 1 * Time.deltaTime;}
        }
            if (vida < 1)
            {
                plataformas.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(false);
                transform.GetChild(2).gameObject.SetActive(false);
                GetComponent<Collider>().enabled = false;
                jugador1.vida = vidamax;
                
                vida = 0;
                if(fin == false)
                {
                musica.Stop();
                fanfarria.Play();
                fin = true;
                cam.SetBool("act",true);
                jugador1.controlact = false;
                GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
                muertes.Play();
                Destroy(explosiont, 1f);
                }
                if(Temp >= 10 )
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
                    manager.datosserial.asesinatos++;
                    manager.datosserial.jefeV[0] = true;
                    manager.guardar();
                    manager.datosconfig.carga = "cin_postboss1_al1";
                    manager.guardarconfig();
                    SceneManager.LoadScene("carga");

                }
                if(Temp > 5 )
                {	
                    conseguidoa.SetBool("act",true);
                    aparece.SetActive(true);
                    if(manager.datosconfig.idioma == "es")
                    {
                        conseguido.text = "lo conseguiste";
                    }
                    if(manager.datosconfig.idioma == "en")
                    {
                        conseguido.text = "you catch it";
                    }
                    if(manager.datosconfig.idioma == "cat")
                    {
                        conseguido.text = "o has aconseguit";
                    }
                }
                if(fin == true)
                {
                    Temp += 1 * Time.deltaTime;
                }

            }
            else if(vidacabeza <= 1)
            {
                balafrec = 2;
                vel = 18;
            }   
            else if(vidacabeza <= 2)
            {
                balafrec = 4;
                vel = 14;
            } 
            else if(vidacabeza <= 3)
            {
                balafrec = 7;
                vel = 10;
            }  
            else
            {
                temp = 0;
            } 
            if(recdano > 0)
            {recdano -= 1 * Time.deltaTime;}   
            if(tempmov < 15)
            {tempmov += 1 * Time.deltaTime;}   
        
        
    }
    private void OnTriggerExit(Collider col)
	{
        
        if (col.gameObject.tag == "danoarma10")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            danoene.Play();
		}
        if (col.gameObject.tag == "danoarma9")
		{
            detectar = true;
		}
    }
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "back" )
		{
            tempmov = 0;
		}
        if (col.gameObject.tag == "danoarma9")
		{
            detectar = false;
		}
	}
    private void OnTriggerEnter(Collider col)
	{
        
        if (col.gameObject.tag == "golpeh" && jugador1.toquespalo > 0)
		{
            jugador1.toquespalo--;
            jugador1.muertesjug.Stop();
            vida -= col.gameObject.GetComponent<golpe_al1>().dano;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            danoene.Play();
		}
        if (col.gameObject.tag == "danoarma8")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            danoene.Play();
		}
        if (col.gameObject.tag == "danoarma9")
		{
            romperbalajug_al1 balajug = col.gameObject.GetComponent<romperbalajug_al1>();
            jugador1.muertesjug.Stop();
            vida -= balajug.danoj;
            jugador1.vidaenebarra.SetActive(true);
            jugador1.vidaeneact = true;
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            danoene.Play();
            detectar = false;
        }

    }
    private void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "Player")
		{
            jugador1.muerte = true;
		}

    }
}
