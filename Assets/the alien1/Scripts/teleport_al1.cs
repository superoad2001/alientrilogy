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
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

        if(manager.datosserial.puertasdesbloqueadas[puertasdesbloqueable] == true && puertasdesbloqueable != 0)
        {
            bloqueada = false;
            
        }
        else if(manager.datosserial.puertasdesbloqueadas[puertasdesbloqueable] == false && puertasdesbloqueable != 0)
        {
            bloqueada = true;
            lugar = "???";
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
		if (col.gameObject.tag == "Player")
		{
	    	anim.SetBool("show",true);
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
                tutfinala.text = text2+lugar;
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
				SceneManager.LoadScene(ubi);
			}
            else if (controles.al1_3d.interactuar.ReadValue<float>() > 0f && tipoTP2 == 1 && bloqueada == false)
			{
				col.gameObject.transform.position = objetoTP.transform.position + new Vector3(0, 1.5f, 0);
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
		if (col.gameObject.tag == "Player")
		{
	    	anim.SetBool("show",true);
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
                tutfinala.text = text2+lugar;
            }

			if (controles.al1_3d.interactuar.ReadValue<float>() > 0f && tipoTP2 == 0 && bloqueada == false )
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
				SceneManager.LoadScene(ubi);
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
