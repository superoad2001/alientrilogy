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
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;

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
    // Start is called before the first frame update
    void Start()
    {
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
    }

    // Update is called once per frame
    void Update()
    {
        vidab.fillAmount = vida/vidamax; 
		vidat.text = vida+"/"+vidamax;

        det.transform.position = this.transform.position;
        dano.transform.position = this.transform.position;
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        
        if(detectar == true && desactivar == false)
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

                            BalaTemporal.GetComponent<bala_tele_al1>().objetivo = objetivo;

                            Destroy(BalaTemporal, 20f);

                            disp.Play();

                            temp = 0;
            }
            temp += 1 * Time.deltaTime;   
        }
            if (vida <= 0)
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
    private void OnTriggerEnter(Collider col)
	{
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
            detectar = false;
		}
    }
}
