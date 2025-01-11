using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo3_al1: MonoBehaviour
{
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
    public enemigodet3_al1 enemigodet;
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
    public float tempe3;
    public float vida;
    public float vidamax;
    public Image vidab;

    public AudioSource danoene;
    public AudioSource danoescudo;
    public GameObject vidamenu;

    public GameObject escudovis;
    public bool escudoact;
    public float tempescudo;
    public float danoj;
    public float vidaescudo;
    // Start is called before the first frame update
    void Start()
    {
        vida = vidamax;
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        jugador1.explosion = explosion;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();
        danoene = GameObject.Find("danoenemigosonido").GetComponent<AudioSource>();
        vidamenu = GameObject.Find("barravidaenemigobase");
        juego = GameObject.Find("juego").transform;
    }

    // Update is called once per frame
    void Update()
    {

        det.transform.position = this.transform.position;
        
        if (vida <= 0)
        {
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            muertes.Play();
            manager.datosserial.asesinatos++;
            manager.guardar();
            jugador1.vidaenebarra.SetActive(false);
            jugador1.vidaeneact = false;
            Destroy(transform.parent.gameObject);

        }
        if (vidaescudo <= 0)
        {
            escudovis.SetActive(false);
            escudoact = false;
            if(tempescudo >= 5)
            {
                escudovis.SetActive(true);
                tempescudo = 0;
                escudoact = true;
                vidaescudo = 10;
            }
            tempescudo += 1 * Time.deltaTime;

        }
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        if(detectar == true  && desactivar == false)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position+ new Vector3 (0,2f,0),transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj;

                        rb.AddForce(transform.forward * 110 * 5);

                        BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                        disp.Play();

                        temp = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,-5,-15),vel * Time.deltaTime);
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
            temp += 1 * Time.deltaTime;
        }
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh" && escudoact == false)
		{
            vida -= jugador1.danoarma;
            danoene.Play();
            jugador1.vidaeneact = true;
            
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaenebarra.SetActive(true);
            
		}
        if (col.gameObject.tag == "golpeh" && escudoact == true)
		{
            vidaescudo -= jugador1.danoarma;
            danoescudo.Play();
            jugador1.vidaeneact = true;
            
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaenebarra.SetActive(true);
            if (vidaescudo <= 0)
            {
            GameObject explosiont = Instantiate(explosion, transform.position + new Vector3 (0,5f,0),transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
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
			Destroy(transform.parent.gameObject);
		}
        
    }
}
