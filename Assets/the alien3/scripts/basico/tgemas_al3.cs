using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tgemas_al3: MonoBehaviour
{
    public int zona = 1;
    public int tp = 1;
    public bool destructora;
    public AudioSource no;
    public AudioSource necesitogemas;
    public AudioSource necesitofinal;
    public AudioSource necesitofinales;
    public AudioSource necesitofinalen;
    public AudioSource necesitofinalcat;
    public AudioSource necesitogemases;
    public AudioSource necesitogemasen;
    public AudioSource necesitogemascat;
    private Controles controles;
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
    public jugador1_al3 jugador;
    public manager_al3 manager;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        
        if(manager.datosconfig.idioma == "es")
        {
            necesitogemas = necesitogemases;
            if(zona == 6)
            {necesitofinal = necesitofinales;}
        }
        if(manager.datosconfig.idioma == "en")
        {
            necesitogemas = necesitogemasen;
            if(zona == 6)
            {necesitofinal = necesitofinalen;}
        }
        if(manager.datosconfig.idioma == "cat")
        {
            necesitogemas = necesitogemascat;
            if(zona == 6)
            {necesitofinal = necesitofinalcat;}
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
    public void OnTriggerStay(Collider col) 
    {
        
        if (col.gameObject.tag == "Player" && controles.al3.y.ReadValue<float>() > 0 && jugador.tempboton > 0.5f)
		{
            if(tp == 1 && zona == 1 && manager.datosserial.gemas >= 5)
            {
                col.transform.position = new Vector3(23.6000004f,-9.22886467f + 3f,154.399994f);
            }
            else if(tp == 1 && zona == 1 && manager.datosserial.gemas < 5)
            {
                no.Play();
                necesitogemas.Play();
            }
            if(tp == 2 && zona == 1) 
            {
                col.transform.position = new Vector3(23.6000004f,-9.22886467f + 3f,102.300003f);
            }

            if(tp == 1 && zona == 2 && manager.datosserial.gemas >= 12)
            {
                col.transform.position = new Vector3(510.700012f,-9.80000019f +5f,-237.899994f);
            }
            else if(tp == 1 && zona == 2 && manager.datosserial.gemas < 12)
            {
                no.Play();
                necesitogemas.Play();
            }
            if(tp == 2 && zona == 2)
            {
                col.transform.position = new Vector3(23.6000004f,-9.22886467f + 3f,102.300003f);
            }


             if(tp == 1 && zona == 3 && manager.datosserial.gemas >= 21)
            {
                col.transform.position = new Vector3(539.476318f,89.0290833f + 3f,-21.1664886f);
            }
            else if(tp == 1 && zona == 3 && manager.datosserial.gemas < 21)
            {
                no.Play();
                necesitogemas.Play();
            }
            if(tp == 2 && zona == 3)
            {
                col.transform.position = new Vector3(556.298889f,-10.1348286f + 3f,-42.9965706f);
            }

            if(tp == 1 && zona == 4 && manager.datosserial.gemas >= 39)
            {
                col.transform.position = new Vector3(628.202271f,-9.22464657f +3f,593.874146f);
            }
            else if(tp == 1 && zona == 4 && manager.datosserial.gemas < 39)
            {
                no.Play();
                necesitogemas.Play();
            }

            if(tp == 2 && zona == 4)
            {
                col.transform.position = new Vector3(270.489502f,-9.22689915f + 3f,576.981384f);
            }

            if(tp == 1 && zona == 5 && manager.datosserial.gemas >= 70)
            {
                SceneManager.LoadScene("mundo15_2_al3");
            }
            else if(tp == 1 && zona == 5 && manager.datosserial.gemas < 70)
            {
                no.Play();
                necesitogemas.Play();
            }

            if(tp == 1 && zona == 6 && manager.datosserial.gemas >= 100 && manager.datosserial.final1 == 1)
            {
                SceneManager.LoadScene("escena13_al3");
            }
            else if(tp == 1 && zona == 6 && manager.datosserial.gemas < 100 && manager.datosserial.final1 == 0 )
            {
                no.Play();
                necesitogemas.Play();
            }
            else if(tp == 1 && zona == 6 && manager.datosserial.gemas >= 100 && manager.datosserial.final1 == 0 )
            {
                no.Play();
                necesitofinal.Play();
            }
            else if(tp == 1 && zona == 6 && manager.datosserial.gemas < 100 && manager.datosserial.final1 == 1 )
            {
                no.Play();
                necesitogemas.Play();
            }






            if(destructora == true && manager.datosserial.diariostotal >= 15)
            {
                col.gameObject.transform.localPosition = new Vector3(-0.5f,869.599976f + 3f,401.399994f);
                jugador.tempboton = 0;
            }
            else if(destructora == true && manager.datosserial.diariostotal < 15)
            {
                no.Play();
                necesitogemas.Play();
            }
            jugador.tempboton = 0;
            
		}
    }
}
