using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class menures_al1 : MonoBehaviour
{
    public int plataforma;
    private Controles controles;
	public void Awake()
    {
        controles = new Controles();
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
    public float temp;
    public int piso = 1;
    public GameObject normal;
    public GameObject salirnivelo;
    public bool salirnivelb;
    public bool perder;
    public AudioMixer audiomixer;
    public manager_al1 manager;
    public Scene escena;
    public AudioSource moveson;
    public jugador_al1 jugador;
    public AudioSource musica_muerte; 
    public AudioSource ambiente_muerte; 
    public AudioSource musica;

	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C

	public void move()
	{
		moveson.Play();
	}



    // Start is called before the first frame update
    void Start()
    {
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if (manager.nivel != 0)
        {salirnivelb = true;}
        escena = SceneManager.GetActiveScene();
        if(salirnivelb)
        {
            salirnivelo.SetActive(true);
        }
        else
        {
            salirnivelo.SetActive(false);
        }
        musica.Stop();
        musica_muerte.Play();
        ambiente_muerte.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(manager.datosconfig.idioma == "es")
        {
            boton2.text = "Salir del juego";
            boton1.text = "Reaparecer";
            if(salirnivelo)
            {boton3.text = "Salir del nivel";}
            if(perder == true)
            {
                boton4.text = "Perdiste";
            }
            else
            {
                boton4.text = "Has muerto";
            }
            
        }
        if(manager.datosconfig.idioma == "en")
        {
            boton2.text = "exit of the game";
            boton1.text = "continue";
            if(salirnivelo)
            {boton3.text = "exit of the level";}
            if(perder == true)
            {
                boton4.text = "you,r lost";
            }
            else
            {
                boton4.text = "you,r died";
            }
        }
        if(manager.datosconfig.idioma == "cat")
        {
            boton2.text = "sortir del joc";
            boton1.text = "reintentar";
            if(salirnivelo)
            {boton3.text = "sortir del nivell";}
            if(perder == true)
            {
                boton4.text = "has perdut";
            }
            else
            {
                boton4.text = "has mort";
            }
        }
    }
    public void continuar()
    {
        manager.datosconfig.carga = escena.name;
        manager.guardarconfig();
        SceneManager.LoadScene("carga");

    }


    public void salir()
    {
        manager.datosconfig.carga = "menu_de_carga_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
    }

    public void salirnivel(){
        if(manager.piso_carga == 1)
        {manager.datosconfig.carga = "piso1_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == 2)
        {manager.datosconfig.carga = "piso2_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == 3)
        {manager.datosconfig.carga = "piso3_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == 4)
        {manager.datosconfig.carga = "piso4_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == -1)
        {manager.datosconfig.carga = "piso1t_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == -2)
        {manager.datosconfig.carga = "piso2t_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == -3)
        {manager.datosconfig.carga = "piso3t_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
        if(manager.piso_carga == -4)
        {manager.datosconfig.carga = "piso4t_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");}
    }
}
