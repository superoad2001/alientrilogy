using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1boss_al1: MonoBehaviour
{
    public float vida;
    public float vidamax;
    public manager_al1 manager;
    public bool detectar;
    public int nivel = 1;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public float vidaUI;

    public float danoj;
    public GameObject dano;
    public GameObject det;
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
    public float vidabasetut = 4;
    public float vidabase = 4;
    public float vidabasemax = 9999;
    public float vidaplusmax = 99999;

    public float fuebasetut = 1;
    public float fuebase = 10;
    public float fuebasemax = 100;
    public float fueplusmax = 2000;
    public int nivelactual = 1;
    public Text niveltxt;
    public float []nivelfuerza_a = new float[100];
    public float []nivelvida_a = new float[100];

    // Start is called before the first frame update
    void Start()
    {

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
        vidaUI = Mathf.Lerp(vidaUI, vida, Time.deltaTime * 2f);
        niveltxt.text = nivelactual.ToString();
        vidab.fillAmount = vidaUI/vidamax; 
		vidat.text = (int)vida+"/"+(int)vidamax;

        det.transform.position = this.transform.position;
        dano.transform.position = this.transform.position;
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        
        if(detectar == true && desactivar == false && manager.controlene == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z),vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
        


            if(temp > balafrec)
            {
                            GameObject BalaTemporal = Instantiate(balaprefab,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                            BalaTemporal.transform.SetParent(juego);

                            BalaTemporal.GetComponent<romperbala_al1>().danoj = ((nivelfuerza / 2) * 2) + nivelfuerza;

                            BalaTemporal.GetComponent<bala_tele_al1>().objetivo = objetivo;

                            Destroy(BalaTemporal, 20f);

                            disp.Play();

                            temp = 0;
            }
            temp += 1 * Time.deltaTime;   
        }
        detectar = true;
            if (vida < 1)
            {
                if(fin == false)
                {
                musica.Stop();
                fanfarria.Play();
                fin = true;
                cam.SetBool("act",true);
                jugador1.controlact = false;
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
                    manager.datosserial.jefe1 = true;
                    manager.guardar();
                    SceneManager.LoadScene("piso2_al1");

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
            else if(vida <= 1)
            {
                balafrec = 2;
            }   
            else if(vida <= 2)
            {
                balafrec = 4;
            } 
            else if(vida <= 3)
            {
                balafrec = 7;
            }  
            else
            {
                temp = 0;
            }    
        
        
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
}
