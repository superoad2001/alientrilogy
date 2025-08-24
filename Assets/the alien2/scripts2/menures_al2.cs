using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class menures_al2 : MonoBehaviour
{
    public AudioSource moves;
    public void move()
	{
		moves.Play();
	}
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
    public manager_al2 manager;
    public Scene escena;
    public bool torre;
    public GameObject respawnp;
    public GameObject interfaz;
    public jugador_al2 jugador;
    public AudioSource musica_muerte; 
    public AudioSource ambiente_muerte; 
    public AudioSource musica; 
    // Start is called before the first frame update
    void Start()
    {
        jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        manager.pause = true;
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
    }

    // Update is called once per frame
    void Update()
    {
        
        if(manager.datosconfig.idioma == "es")
        {
            boton2.text = "salir del juego";
            boton1.text = "reaparecer";
            if(salirnivelo)
            {boton3.text = "salir del nivel";}
            if(perder == true)
            {
                boton4.text = "perdiste";
            }
            else
            {
                boton4.text = "has muerto";
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
        SceneManager.LoadScene(escena.name);

    }


    public void salir()
    {
        SceneManager.LoadScene("menu_de_carga_al2");
    }

    public void salirnivel()
    {
        if(torre == false)
        {
            SceneManager.LoadScene("mundo_abierto_al2");
        }
        else
        {
            SceneManager.LoadScene("torre_del_tiempo_al2");
        }
    }

}
