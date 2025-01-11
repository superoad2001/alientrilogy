using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo2_al1: MonoBehaviour
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
    public enemigodet2_al1 enemigodet;
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
    public GameObject vidamenu;

    public float danoj;
    
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
        dano.transform.position = this.transform.position;
        
        if (vida <= 0)
        {
            GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            muertes.Play();
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
        if(detectar == true && desactivar == false && enemigo == 1)
        {
            if(temp > 3f)
            {
                anim.SetBool("atk",true);
                temp = 0;
            }
            else
            {
                anim.SetBool("atk",false);
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
            temp += 1 * Time.deltaTime;
        }
        if(detectar == true && enemigo == 2 && desactivar == false)
        {
            if(temp > balafrec)
            {
                        GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        BalaTemporal.transform.SetParent(juego);

                        BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj;

                        rb.AddForce(transform.forward * 110 * 20);

                        BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                        disp.Play();

                        temp = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-15),vel * Time.deltaTime);
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
        if(detectar == true && enemigo == 3 && desactivar == false)
        {
            if(enemigo3 == 1)
            {
            if(temp > 3f)
            {
                anim.SetBool("atk",true);
                temp = 0;
            }
            else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
                if (anim.GetCurrentAnimatorStateInfo(1).IsName("atk"))
            {
                
            }
            else if(transform.position.z != objetivo.transform.position.z+ -3)
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
            if(enemigo3 == 2)
            {
                if(temp > balafrec)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab, pistola.transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                            BalaTemporal.transform.SetParent(juego);

                            BalaTemporal.GetComponent<romperbala_al1>().danoj = danoj;

                            rb.AddForce(transform.forward * 110 * 20);

                            BalaTemporal.GetComponent<romperbala_al1>().destb = 4f;

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-4),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
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
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
            }
            if (tempe3 > 10f)
            {
                enemigo3 = Random.Range(1,3);
                tempe3 = 0;
            }
            tempe3 += 1 * Time.deltaTime;
        }
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "golpeh")
		{
            vida -= jugador1.danoarma;
            danoene.Play();
            jugador1.vidaeneact = true;
            
            jugador1.vidaeneui = vida;
            jugador1.vidaeneuimax = vidamax;
            jugador1.vidaenebarra.SetActive(true);
            
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
