using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1_al3: MonoBehaviour
{
    public bool detectar;
    public int lado = 1;
    public float temptp;
    public int tprandom;
    public float templado;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Animator anim;
    public float temp;
    public bool plat;
    public float vida = 4;
    public int enemigo = 1;
    public int enemigo3;
    public AudioSource disp;
    public GameObject balaprefab;
    public GameObject balaprefab2;
    public GameObject balaprefab3;
    public GameObject balaprefab4;
    public GameObject pistola;
    public float tempe3;
    public float tempgolpe;
    public float balafrec = 1.5f;
    public Rigidbody rb_;
    public int jefe = 0;
    public int jefe1_p = 1;
    public bool jefe1_act1 = false;
    public bool jefe1_act2 = false;
    public bool gigante;
    public Text cuentavidas;
    public Image vidab;
    public Image vidab2;
    public float vidaux;
    public float vel = 2;
    public bool desactivar;
    public enemigodet_al3 enemigodet;
    public GameObject moneda;
    public Transform juego;
    // Start is called before the first frame update
    void Start()
    {
        enemigo3 = Random.Range(1,3);
        vidaux = vida;
    }

    // Update is called once per frame
    void Update()
    {
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        if(tempgolpe < 15)
        {tempgolpe += 1 * Time.deltaTime;}
        if(jefe > 0 && jefe < 5)
        {
            vidab.fillAmount = vida/vidaux;
        }
        if(jefe == 5)
        {
            vidab.fillAmount = ((vida -(vidaux / 2))/(vidaux- (vidaux / 2)));
            vidab2.fillAmount = vida/(vidaux/2);
        }
        if(vida <= 0)
        {
            manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
            if(jefe == 1)
            {
                if(jefe1_p == 1)
                {
                    manager.jefe1_act1 = true;
                }
                if(jefe1_p == 2)
                {
                    manager.jefe1_act2 = true;
                }
                desactivar = true;
                Destroy(gameObject);
            }
            else if(jefe == 2)
            {
                if(manager.datosserial.espacio3act == 0)
                {manager.datosserial.espacio3act = 1;
                manager.guardar();}
                desactivar = true;
                SceneManager.LoadScene("escena5_al3");
            }
            else if(jefe == 3)
            {
                if(manager.datosserial.espacio4act == 0)
                {manager.datosserial.espacio4act = 1;
                manager.guardar();}
                desactivar = true;
                SceneManager.LoadScene("escena7_al3");
            }
            else if(jefe  == 4)
            {
                if(manager.datosserial.espacio5act == 0)
                {manager.datosserial.espacio5act = 1;
                manager.guardar();}
                desactivar = true;
                SceneManager.LoadScene("escena9_al3");
            }
            else if(jefe  == 5)
            {
                desactivar = true;
                SceneManager.LoadScene("escena11_al3");
            }
            else if(jefe  == 6)
            {
                desactivar = true;
                SceneManager.LoadScene("escena14_al3");
            }
            else if(jefe == 0)
            {
                GameObject Temporal = Instantiate(moneda, transform.position,transform.rotation) as GameObject;
                Destroy(gameObject);
            }

            if(manager.jefe1_act1 == true && manager.jefe1_act2 == true)
            {
                if(manager.datosserial.espacio2act == 0)
                {manager.datosserial.espacio2act = 1;
                manager.guardar();}
                SceneManager.LoadScene("escena3_al3");
            }
            
        }
        if(detectar == true && enemigo == 1 && desactivar == false)
        {
            if(temp > 3f)
            {
                if(gigante == false)
                {anim.SetBool("atk",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
            }
            else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
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

                        rb.AddForce(transform.forward * 110 * 20);

                        Destroy(BalaTemporal, 4f);

                        disp.Play();

                        temp = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-15),vel * Time.deltaTime);
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
                if(gigante == false)
                {anim.SetBool("atk",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
            }
            else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
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

                            rb.AddForce(transform.forward * 110 * 20);

                            Destroy(BalaTemporal, 4f);

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-15),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
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
        if(detectar == true && enemigo == 4 && desactivar == false)
        {
            anim.SetBool("atk",false);
            anim.SetBool("arma4",false);
            anim.SetBool("encatk1",false);
            if(enemigo3 == 1)
            {
                if(temp > 3f)
            {
                if(gigante == false)
                {anim.SetBool("atk",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
            }
            else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 10f)
                {
                    enemigo3 = Random.Range(1,4);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 2)
            {
                if(temp > 3f)
            {
                if(gigante == false)
                {anim.SetBool("arma4",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
            }
            else{
                anim.SetBool("arma4",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 6f)
                {
                    enemigo3 = Random.Range(1,4);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 3 || enemigo3 == 4)
            {
                if(temp > 5f)
            {
                rb_ = this.GetComponent<Rigidbody>();
                anim.SetBool("encatk1",true);
                this.rb_.AddForce(1000 * transform.TransformDirection(new Vector3 (0,0,1)));
                temp = 0;
            }
            else{
                anim.SetBool("encatk1",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;

                if (tempe3 > 10f)
                {
                    enemigo3 = Random.Range(1,5);
                    tempe3 = 0;
                }
            }
            
            tempe3 += 1 * Time.deltaTime;
        }
        if(detectar == true && enemigo == 5 && desactivar == false)
        {
            if(enemigo3 == 1 || enemigo3 == 2)
            {
                if(temp > balafrec)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                            BalaTemporal.transform.SetParent(juego);

                            rb.AddForce(transform.forward * 110 * 20);

                            Destroy(BalaTemporal, 4f);

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z) + new Vector3(0,0,-15),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 5f)
                {
                    enemigo3 = Random.Range(1,6);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 3)
            {
                if(temp > 6)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab2,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                            BalaTemporal.transform.SetParent(juego);


                            Destroy(BalaTemporal, 6f);

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z) + new Vector3(0,0,-5),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 7f)
                {
                    enemigo3 = Random.Range(1,6);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 4 || enemigo3 == 5)
            {
                if(temp > 2)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab3,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                            BalaTemporal.transform.SetParent(juego);

                            rb.AddForce(transform.forward * 30 * 20);

                            Destroy(BalaTemporal, 15f);

                            GameObject BalaTemporal2 = Instantiate(balaprefab3,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb2 = BalaTemporal2.GetComponent<Rigidbody>();
                            BalaTemporal2.transform.SetParent(juego);

                            rb2.AddForce(transform.forward * -30 * 20);

                            Destroy(BalaTemporal2, 15f);

                            GameObject BalaTemporal3 = Instantiate(balaprefab3,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb3 = BalaTemporal3.GetComponent<Rigidbody>();
                            BalaTemporal3.transform.SetParent(juego);

                            rb3.AddForce(transform.right * 30 * 20);

                            Destroy(BalaTemporal3, 15f);
                            
                            GameObject BalaTemporal4 = Instantiate(balaprefab3,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb4 = BalaTemporal4.GetComponent<Rigidbody>();
                            BalaTemporal4.transform.SetParent(juego);

                            rb4.AddForce(transform.right * -30 * 20);

                            Destroy(BalaTemporal4, 15f);
                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z) + new Vector3(0,0,-5),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 7f)
                {
                    enemigo3 = Random.Range(1,6);
                    tempe3 = 0;
                }
            }
            if(lado == 1)
            {
                transform.localPosition += new Vector3(0,1,0)* 4 * Time.deltaTime;
            }
            if(lado == -1)
            {
                transform.localPosition += new Vector3(0,1,0) * -4 * Time.deltaTime;
            }
            templado += 1 * Time.deltaTime;
            if(templado >= 2)
            {
                templado = 0;
                if(lado == 1)
                {
                    lado = -1;
                }
                else if(lado == -1)
                {
                    lado = 1;
                }
            }
            templado += 1 * Time.deltaTime;
            if (temptp > 10f)
            {
                tprandom = Random.Range(1,6);
                if(tprandom == 1)
                {
                    transform.localPosition = new Vector3(-37.0999985f,-8.86999989f,55.2999992f);
                }
                if(tprandom == 2)
                {
                    transform.localPosition = new Vector3(66.9000015f,-8.86999989f,55.2999992f);
                }
                if(tprandom == 3)
                {
                    transform.localPosition = new Vector3(66.9000015f,-8.86999989f,-58.5999985f);
                }
                if(tprandom == 4)
                {
                    transform.localPosition = new Vector3(-31.2000008f,-8.86999989f,-58.5999985f);
                }
                if(tprandom == 5)
                {
                    transform.localPosition = new Vector3(15.1999998f,-8.86999989f,-0.5f);
                }
                temptp = 0;
            }
            temptp += 1 * Time.deltaTime;
            tempe3 += 1 * Time.deltaTime;
        }
        if(detectar == true && enemigo == 6 && desactivar == false)
        {
            anim.SetBool("atk",false);
            anim.SetBool("arma4",false);
            anim.SetBool("encatk1",false);
            if(enemigo3 == 1)
            {
                if(temp > 3f)
            {
                if(gigante == false)
                {anim.SetBool("atk",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
            }
            else{
                anim.SetBool("atk",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 10f)
                {
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 2)
            {
                if(temp > 3f)
            {
                if(gigante == false)
                {anim.SetBool("arma4",true);}
                if(gigante == true)
                {anim.SetBool("atkg",true);}
                temp = 0;
            }
            else{
                anim.SetBool("arma4",false);
                anim.SetBool("atkg",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 6f)
                {
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 3 || enemigo3 == 4)
            {
                if(temp > 5f)
            {
                rb_ = this.GetComponent<Rigidbody>();
                anim.SetBool("encatk1",true);
                this.rb_.AddForce(1000 * transform.TransformDirection(new Vector3 (0,0,1)));
                temp = 0;
            }
            else{
                anim.SetBool("encatk1",false);
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;

                if (tempe3 > 10f)
                {
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 5)
            {
                if(temp > 5f)
                {
                    GameObject enemigotemp = Instantiate(balaprefab,transform.position + new Vector3(5,0,0),transform.rotation) as GameObject;
                    enemigotemp.transform.SetParent(juego);
                    Destroy(enemigotemp, 45f);
                    GameObject enemigotemp2 = Instantiate(balaprefab2,transform.position + new Vector3(-5,0,0),transform.rotation) as GameObject;
                    enemigotemp2.transform.SetParent(juego);
                    Destroy(enemigotemp2, 45f);
                    GameObject enemigotemp3 = Instantiate(balaprefab3,transform.position + new Vector3(0,0,5),transform.rotation) as GameObject;
                    enemigotemp3.transform.SetParent(juego);
                    Destroy(enemigotemp3, 45f);
                    temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;

                if (tempe3 > 6f)
                {
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            if(enemigo3 == 6)
            {
                if(temp > 6)
                {
                            GameObject BalaTemporal = Instantiate(balaprefab4,transform.position,transform.rotation) as GameObject;

                            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                            BalaTemporal.transform.SetParent(juego);

                            Destroy(BalaTemporal, 3f);

                            disp.Play();

                            temp = 0;
                }
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,transform.position.y,objetivo.transform.position.z) + new Vector3(0,0,-5),vel * Time.deltaTime);
                Vector3 direction = objetivo1.position - transform.position;
                rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
                temp += 1 * Time.deltaTime;
                if (tempe3 > 7f)
                {
                    enemigo3 = Random.Range(1,7);
                    tempe3 = 0;
                }
            }
            tempe3 += 1 * Time.deltaTime;
        }
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        jugador1_al3 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al3>();
        if (col.gameObject.tag == "golpeh" && tempgolpe > 0.3f)
		{
            vida = vida - 1f * jugador.dano;
            tempgolpe = 0;
		}
        if (col.gameObject.tag == "danoarma1")
		{
            vida = vida - 2f * jugador.dano;
            UnityEngine.Object.Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "danoarma6")
		{
            vida = vida - 20f * jugador.dano;
           UnityEngine.Object.Destroy(col.gameObject); 
		}   
        if (col.gameObject.tag == "danoarma7")
		{
            vida = vida - 1.5f * jugador.dano;
            UnityEngine.Object.Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "danoarma8")
		{
            vida = vida - 6f * jugador.dano;
            UnityEngine.Object.Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "danoarma9")
		{
            vida = vida - 3f * jugador.dano;
            UnityEngine.Object.Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "danoarma10")
		{
            vida = vida - 8f * jugador.dano;
            UnityEngine.Object.Destroy(col.gameObject);
		}

	}
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "respawn")
		{
			Destroy(gameObject);
		}
        
    }
}
