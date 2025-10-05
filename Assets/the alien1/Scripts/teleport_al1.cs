using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class teleport_al1 : MonoBehaviour
{
    public Text tutfinala;
	public Animator anim;
	private Controles controles;
	public manager_al1 manager;
    public int tipoTP;
    public int tipoTP2;
    public string ubi;
    public string lugar;
    public GameObject objetoTP;
    public int puertagir;
    public bool puertagiract;
    public Vector3 puertapos;
    public bool puertaposact;
    public bool noborrado;
    public int puertasdesbloqueable;
    public bool bloqueada;
    public bool obertura;
    public bool req_gemas;
    public int cantgemas;
    public AudioSource sonidoTP;
    public AudioSource nopson;
    public GameObject expTP;
    public jugador_al1 jugador;
    public bool bloqueadanave;
    public bool ascensor;

    


	private readonly Dictionary<string, string> languageTexts = new Dictionary<string, string>
    {
        {"es", "para teletransportarte"},
        {"en", "To teleport"},
        {"cat", "per teletransportarta"}
    };
    private readonly Dictionary<string, string> languageTexts2 = new Dictionary<string, string>
    {
        {"es", "para cruzar portal"},
        {"en", "To access portal"},
        {"cat", "per creuar el portal"}
    };
    private readonly Dictionary<string, string> languageTexts3= new Dictionary<string, string>
    {
        {"es", "Ir a "},
        {"en", "Go to "},
        {"cat", "Anar a "}
    };
	private void Start()
	{
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

        if(manager.datosserial.puertasdesbloqueadas[puertasdesbloqueable] == true && puertasdesbloqueable != 0 && obertura == false)
        {
            bloqueada = false;
            
        }
        else if(manager.datosserial.puertasdesbloqueadas[puertasdesbloqueable] == false && puertasdesbloqueable != 0 && obertura == false)
        {
            bloqueada = true;
            lugar = "???";
        }

        if(manager.datosserial.tengonave == true)
        {
            bloqueadanave = false;   
        }
	}
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
    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision col)
	{
        if (col.gameObject.tag == "Player" && ascensor == true)
		{

            if (manager.datosconfig.idioma == "es")
            {
                tutfinala.text = "Usar Llave";
            }
            
            if (manager.datosserial.tengollave1 == true && manager.piso == 1 && manager.datosserial.jefeV[0] == false && manager.datosserial.misiones[10] == 1)
			{
                anim.SetBool("show",true);
                
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = "cin_preboss1_al1";
                    manager.guardarconfig();
                    manager.guardar();
				SceneManager.LoadScene("carga");
                }
                
            }
            if (manager.datosserial.tengollave1 == true && manager.piso == 1 && manager.datosserial.jefeV[0] == false && manager.datosserial.misiones[10] == 2)
			{
                anim.SetBool("show",true);
                
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = "salapreboss1_al1";
                    manager.guardarconfig();
                    manager.guardar();
				SceneManager.LoadScene("carga");
                }
                
            }
            if (manager.datosserial.tengollave2 == true && manager.piso == 2 && manager.datosserial.jefeV[1] == false)
			{
                anim.SetBool("show",true);
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
            }
            if (manager.datosserial.tengollave3 == true && manager.piso == 3 && manager.datosserial.jefeV[2] == false)
			{
                anim.SetBool("show",true);
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
            }
            if (manager.datosserial.tengollave4 == true && manager.piso == 4 && manager.datosserial.jefeV[3] == false)
			{
                anim.SetBool("show",true);
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
            }
            
        }
		if (col.gameObject.tag == "Player" && ascensor == false)
		{

            anim.SetBool("show",true);
            if(req_gemas == true)
            {
                if(manager.datosserial.economia[0] >= cantgemas)
                {
                    if (languageTexts3.TryGetValue(manager.datosconfig.idioma, out string text2) )
                    {
                        tutfinala.text = text2+lugar;
                    }
                }
                else
                {
                    if (manager.datosconfig.idioma == "es")
                    {
                        tutfinala.text = string.Concat("Falta energia necesitas ", cantgemas.ToString(), " gemas");
                    }
                }
            }
            else if(bloqueada == true)
            {

                if (manager.datosconfig.idioma == "es")
                {
                    tutfinala.text = "puerta bloqueada desde el otro lado";
                }
            }
            else if(bloqueadanave == true)
            {

                if (manager.datosconfig.idioma == "es")
                {
                    tutfinala.text = "bloqueada: se requiere una nave";
                }
            }
            else
            {
                if (languageTexts.TryGetValue(manager.datosconfig.idioma, out string text) && tipoTP == 0)
                {
                    tutfinala.text = text;
                }
                else if (languageTexts2.TryGetValue(manager.datosconfig.idioma, out string text1) && tipoTP == 1)
                {
                    tutfinala.text = text1;
                }
                else if (languageTexts3.TryGetValue(manager.datosconfig.idioma, out string text2) && tipoTP == 2)
                {
                    tutfinala.text = string.Concat(text2, lugar);
                }
            }
	    	
			

			if (controles.al1_3d.interactuar.ReadValue<float>() > 0f && tipoTP2 == 0 )
			{
                if(puertagiract == true)
                {
                    if(puertagir == 1)
                    {
                        manager.datosserial.puertagir = 0;
                    }
                    if(puertagir == 2)
                    {
                        manager.datosserial.puertagir = 90;
                    }
                    if(puertagir == 3)
                    {
                        manager.datosserial.puertagir = 180;
                    }
                    if(puertagir == 4)
                    {
                        manager.datosserial.puertagir = 270;
                    }
                    manager.datosserial.puertagiract = true;
                }
                else if(noborrado == false)
                {
                    manager.datosserial.puertagir = 0;
                    manager.datosserial.puertagiract = false;
                }
                if(puertaposact == true)
                {
                    manager.datosserial.puertapos = puertapos;
                    manager.datosserial.puertaposact = true;
                }
                else if(noborrado == false)
                {
                    manager.datosserial.puertapos = new Vector3(0,0,0);
                    manager.datosserial.puertaposact = false;
                }
                if(manager.nivelact == false)
                {
                    manager.datosserial.salirnivelsala = SceneManager.GetActiveScene().name;
                    manager.datosserial.actual_checkpoint = 0;
                }
                manager.guardar();
               if(req_gemas == true && bloqueada == false )
                {
                    if(manager.datosserial.economia[0] >= cantgemas)
                    {
                        manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                        
                    }
                    else
                    {
                        nopson.Play();
                    }
                    
                }
                else if (bloqueada == false && bloqueadanave == false && manager.datosserial.economia[0] >= cantgemas)
                {     
                    if(manager.nivelact == true && manager.hierronivel == true)
                    {
                        manager.datosserial.LlaveT[manager.IDhierronivel] = true;
                        manager.datosserial.economia[2]++;
                    }      
                    manager.datosconfig.carga = ubi;
                    manager.guardarconfig();
                    manager.guardar();
				SceneManager.LoadScene("carga");
                }
                else
                {
                    nopson.Play();
                }
				
			}
            else if (controles.al1_3d.interactuar.ReadValue<float>() > 0f && tipoTP2 == 1 && bloqueada == false)
			{
				col.gameObject.transform.position = objetoTP.transform.position + new Vector3(0, 1.5f, 0);
                sonidoTP.Play();
                GameObject exptemp = Instantiate(expTP, jugador.transform.position,jugador.transform.rotation) as GameObject;
                Destroy(exptemp,5f);
			}
		}
	}
    private void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			anim.SetBool("show",false);
		}
	}
    private void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "Player" && ascensor == true)
		{

            if (manager.datosconfig.idioma == "es")
            {
                tutfinala.text = "Usar Llave";
            }
            
            if (manager.datosserial.tengollave1 == true && manager.piso == 1 && manager.datosserial.jefeV[0] == false)
			{
                anim.SetBool("show",true);
                
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
                
            }
            if (manager.datosserial.tengollave2 == true && manager.piso == 2 && manager.datosserial.jefeV[1] == false)
			{
                anim.SetBool("show",true);
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
            }
            if (manager.datosserial.tengollave3 == true && manager.piso == 3 && manager.datosserial.jefeV[2] == false)
			{
                anim.SetBool("show",true);
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
            }
            if (manager.datosserial.tengollave4 == true && manager.piso == 4 && manager.datosserial.jefeV[3] == false)
			{
                anim.SetBool("show",true);
                if(controles.al1_3d.interactuar.ReadValue<float>() > 0f )
                {
                    manager.datosconfig.carga = ubi;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
                }
            }
            
        }
		if (col.gameObject.tag == "Player" && ascensor == false)
		{
	    	anim.SetBool("show",true);
            if(bloqueadanave == true)
            {

                if (manager.datosconfig.idioma == "es")
                {
                    tutfinala.text = "bloqueada: se requiere una nave";
                }
            }
			else if(req_gemas == true)
            {
                if(manager.datosserial.economia[0] >= cantgemas)
                {
                    if (languageTexts3.TryGetValue(manager.datosconfig.idioma, out string text2) )
                    {
                        tutfinala.text = string.Concat(text2, lugar);
                    }
                }
                else
                {
                    if (manager.datosconfig.idioma == "es")
                    {
                        tutfinala.text = string.Concat("Falta energia necesitas ", cantgemas.ToString(), " gemas");
                    }
                }
            }
            else if(bloqueada == true)
            {

                if (manager.datosconfig.idioma == "es")
                {
                    tutfinala.text = "puerta bloqueada desde el otro lado";
                }
            }
            else
            {
                if (languageTexts.TryGetValue(manager.datosconfig.idioma, out string text) && tipoTP == 0)
                {
                    tutfinala.text = text;
                }
                else if (languageTexts2.TryGetValue(manager.datosconfig.idioma, out string text1) && tipoTP == 1)
                {
                    tutfinala.text = text1;
                }
                else if (languageTexts3.TryGetValue(manager.datosconfig.idioma, out string text2) && tipoTP == 2)
                {
                    tutfinala.text = string.Concat(text2, lugar);
                }
            }

			if (controles.al1_3d.interactuar.ReadValue<float>() > 0f && tipoTP2 == 0 )
			{
                if(puertagiract == true)
                {
                    if(puertagir == 1)
                    {
                        manager.datosserial.puertagir = 0;
                    }
                    if(puertagir == 2)
                    {
                        manager.datosserial.puertagir = 90;
                    }
                    if(puertagir == 3)
                    {
                        manager.datosserial.puertagir = 180;
                    }
                    if(puertagir == 4)
                    {
                        manager.datosserial.puertagir = 270;
                    }
                    manager.datosserial.puertagiract = true;
                }
                else if(noborrado == false)
                {
                    manager.datosserial.puertagir = 0;
                    manager.datosserial.puertagiract = false;
                }
                if(puertaposact == true)
                {
                    manager.datosserial.puertapos = puertapos;
                    manager.datosserial.puertaposact = true;
                }
                else if(noborrado == false)
                {
                    manager.datosserial.puertapos = new Vector3(0,0,0);
                    manager.datosserial.puertaposact = false;
                }
                if(obertura == true)
                {
                    manager.datosserial.puertasdesbloqueadas[puertasdesbloqueable] = true;
                }
                if(manager.nivelact == false)
                {
                    manager.datosserial.salirnivelsala = SceneManager.GetActiveScene().name;
                    manager.datosserial.actual_checkpoint = 0;
                }
                
                manager.guardar();
				if(req_gemas == true && bloqueada == false  )
                {
                    if(manager.datosserial.economia[0] >= cantgemas)
                    {
                        manager.datosconfig.carga = ubi;
                    manager.guardarconfig();
                    manager.guardar();
				SceneManager.LoadScene("carga");
                    }
                    else
                    {
                        nopson.Play();
                    }
                }
                else if (bloqueada == false && bloqueadanave == false && manager.datosserial.economia[0] >= cantgemas)
                {           
                    if(manager.nivelact == true && manager.hierronivel == true)
                    {
                        manager.datosserial.LlaveT[manager.IDhierronivel] = true;
                        manager.datosserial.economia[2]++;
                    }
                    manager.datosconfig.carga = ubi;
                    manager.guardarconfig();
                    manager.guardar();
				SceneManager.LoadScene("carga");
                }
                else
                {
                    nopson.Play();
                }
			}
            else if (controles.al1_3d.interactuar.ReadValue<float>() > 0f && tipoTP2 == 1)
			{
				col.gameObject.transform.position = objetoTP.transform.position + new Vector3(0, 1.5f, 0);
			}
            
		}

	}
    private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			anim.SetBool("show",false);
		}
	}
    //Vector3(41.0040855,429.047241,339.660156)
    //Vector3(-351.5,512.599976,739.900024)
    //Vector3(-22.5,454.799988,112.5)

}
