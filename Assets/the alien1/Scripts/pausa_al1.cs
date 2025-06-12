using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class pausa_al1 : MonoBehaviour
{
    public AudioSource positive;
    public AudioSource negative;
    public GameObject juego;
    public GameObject pausa1;
    public int plataforma;

    public GameObject mapa_b;
    public GameObject misiones_b;
    public GameObject notas_b;
    public GameObject estad_b;
    public GameObject objetos_b;


    private Controles controles;

    public opcionespause oppau;

    [SerializeField]
	public misiones_al1 dmisiones;
    
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
    public Text boton1;
    public Text boton2;
    public Text boton3;
    public Text boton4;
    public Text boton5;

    public Text gemas;
    public Text monedam;
    public Text monedaa;
    public Text monedar;
    public Text llave;
    public Text llaver;
    public Text licencia;
    public Text mision1;
    public Text mision2;
    public float temp;
    public int piso = 1;
    public GameObject normal;
    public GameObject opciones1;
    public AudioMixer audiomixer;
    public manager_al1 manager;
    public managerBASE manager2;
    public jugador_al1 jugador;
    public bool mapa;
    // Start is called before the first frame update
    public AudioSource moveson;
    public Transform hip;
    public float boton;
    public float botonb;
    public bool mapaact;

    public float xmapC;
    public float ymapC;
    public float xmapme;
    public float ymapme;
    public float xmapma;
    public float ymapma;

    public bool inicio;
    public GameObject camaramapa;



	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C

	public void move()
	{
		moveson.Play();
	}
    public void positivea()
	{
		positive.Play();
	}
    public void negativea()
	{
		negative.Play();
	}
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        if(mapa == true)
        {mapa_();}

    }
    public void ubicar()
    {
        camaramapa.transform.position = new Vector3(jugador.transform.position.x,jugador.transform.position.y + 356f,jugador.transform.position.z);
    }

    // Update is called once per frame
    public void Update()
    {
        if(mapaact == true)
        {
            if(controles.al1_general.l3.ReadValue<float>() > 0)
            {
                ubicar();
            }

            xmapC = controles.al1_general.lhorizontal.ReadValue<float>();
            ymapC = controles.al1_general.lvertical.ReadValue<float>();



            if(ymapC > 0)
            {
                ymapma = 1;
                ymapme = 0;
            }
            else if(ymapC < 0)
            {
                ymapme = 1;
                ymapma = 0;
            }
            else
            {
                ymapma = 0;
                ymapme = 0;
            }
            if(xmapC > 0)
            {
                xmapma = 1;
                xmapme = 0;
            }
            else if(xmapC < 0)
            {
                xmapme = 1;
                xmapma = 0;
            }
            else
            {
                xmapma = 0;
                xmapme = 0;
            }

            if(camaramapa.transform.position.x < 3000 && xmapma > 0)
            {
                camaramapa.transform.Translate(Vector3.right * xmapma * 200 * Time.unscaledDeltaTime);
            }
            if(camaramapa.transform.position.x > -3000  && xmapme > 0)
            {
                camaramapa.transform.Translate(-Vector3.right * xmapme * 200 * Time.unscaledDeltaTime);
            }
            if(camaramapa.transform.position.y < 3000  && ymapma > 0)
            {
                camaramapa.transform.Translate(Vector3.up * ymapma * 200 * Time.unscaledDeltaTime);
            }
            if(camaramapa.transform.position.y > -3000  && ymapme > 0)
            {
                camaramapa.transform.Translate(-Vector3.up * ymapme * 200 * Time.unscaledDeltaTime);
            }


        }
        if (inicio == false && mapa == true)
        {
            inicio = true;
            ubicar();
            
        }
        if(mapa == false)
        {
            boton = controles.al1_general.pausa.ReadValue<float>();
        }
        else
        {
            boton = controles.al1_general.select.ReadValue<float>();
        }

        botonb = controles.al1_general.b.ReadValue<float>();
        
        if(manager.datosconfig.idioma == "es")
        {
            if(mapa == false)
            {
            boton2.text = "salir";
            boton1.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "salir del nivel";}
            boton4.text = "pausa";
            boton5.text = "opciones";
            }
            else
            {
                boton1.text = "continuar";
                boton4.text = "mapa";
                
                gemas.text = manager.datosserial.economia[0]+"";
                llave.text = manager.datosserial.economia[1]+"";
                llaver.text = manager.datosserial.economia[2]+"";           
                monedar.text = manager.datosserial.economia[3]+"";
                monedam.text = manager.manager.datosserial.economia[4]+"";
                monedaa.text = manager.datosserial.economia[5]+"";
                licencia.text = manager.datosserial.economia[6]+"";

                mision1.text = manager.mision;
                mision2.text = manager.mision2;

                //economia[0] = gemas;
                //economia[1] = llaves;
                //economia[2] = fragllave;
                //economia[3] = monedasrojas;
                //economia[4] = monedasmoradas;
                //economia[5] = monedasamarillas;
            }
        }
        if(boton > 0 && temp > 0.7f || botonb > 0 && temp > 0.7f)
        {
            if(mapa == false)
            {
                if(opciones1.activeSelf)
                {
                    no_aplicar();
                }
                continuar();
            }
            else
            {
                inicio = false;
                continuar_M();
                
            }
        }
        if(temp < 15)
        {temp += 1 * Time.unscaledDeltaTime;}
    }
    public void continuar(){
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        plataforma = manager.datosconfig.plat;
        temp = 0;
        jugador.temppause = 0;
        jugador.controlact = true;
        if(plataforma == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
        Time.timeScale = 1;
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        if(plataforma == 2)
		{
			jugador.tactil.SetActive(true);
		}
        manager.pauseact = false;    
        if(manager.juego == 1)
        {
            jugador.anim.SetBool("act2",true);
        }
        if(manager.juego == 2)
        {
            jugador.anim.SetBool("act",true);
        }
        pausa1.SetActive(false);
    }
    public void continuar_M(){
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        plataforma = manager.datosconfig.plat;
        temp = 0;
        jugador.temppause = 0;
        jugador.controlact = true;
        if(plataforma == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
        Time.timeScale = 1;
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        if(plataforma == 2)
		{
			jugador.tactil.SetActive(true);
		}
        manager.pauseact = false;    
        if(manager.juego == 1)
        {
            jugador.anim.SetBool("act2",true);
        }
        if(manager.juego == 2)
        {
            jugador.anim.SetBool("act",true);
        }
        mapa_();
        pausa1.SetActive(false);
    }
    public void salir(){

        SceneManager.LoadScene("menu_de_carga_al1");
    }
    public void mapa_()
    {
        mapaact = true;
        notas_b.SetActive(false);
        estad_b.SetActive(false);
        objetos_b.SetActive(false);
        misiones_b.SetActive(false);
        mapa_b.SetActive(true);

    }
    public void misiones_()
    {
        mapaact = false;
        notas_b.SetActive(false);
        estad_b.SetActive(false);
        objetos_b.SetActive(false);
        mapa_b.SetActive(false);
        misiones_b.SetActive(true);

    }
    public void notas()
    {
        mapaact = false;
        mapa_b.SetActive(false);
        estad_b.SetActive(false);
        misiones_b.SetActive(false);
        objetos_b.SetActive(false);
        notas_b.SetActive(true);
    }
    public void estadisticas()
    {
        mapaact = false;
        mapa_b.SetActive(false);
        notas_b.SetActive(false);
        misiones_b.SetActive(false);
        objetos_b.SetActive(false);
        estad_b.SetActive(true);
    }
    public void objetos()
    {
        mapaact = false;
        mapa_b.SetActive(false);
        notas_b.SetActive(false);
        estad_b.SetActive(false);
        misiones_b.SetActive(false);
        objetos_b.SetActive(true);
    }

    public void salirnivel(){
        if(piso == 1)
        {SceneManager.LoadScene("piso1_al1");}
        if(piso == 2)
        {SceneManager.LoadScene("piso2_al1");}
        if(piso == 3)
        {SceneManager.LoadScene("piso3_al1");}
        if(piso == 4)
        {SceneManager.LoadScene("piso4_al1");}
        if(piso == -1)
        {SceneManager.LoadScene("piso1t_al1");}
        if(piso == -2)
        {SceneManager.LoadScene("piso2t_al1");}
        if(piso == -3)
        {SceneManager.LoadScene("piso3t_al1");}
        if(piso == -4)
        {SceneManager.LoadScene("piso4t_al1");}
    }
    public void opciones()
    {
        normal.SetActive(false);
        opciones1.SetActive(true);
    }
    public void aplicar()
    {
		oppau.aplicartodo();
        opciones1.SetActive(false);
        normal.SetActive(true);
        
		
    }
    public void no_aplicar()
    {
        opciones1.SetActive(false);
        normal.SetActive(true);
        
		
    }
}
