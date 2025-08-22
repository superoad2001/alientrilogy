using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class menu_de_carga_al3 : MonoBehaviour
{

    public float temp = 0;

    public AudioSource st;
    public Text pres;
    public GameObject vistaestados;

    // Start is called before the first frame update
    public manager_al3 manager;
    public Animator cam_a;
    public Animator pres_a;

    public Animator menu_a;
    public AudioSource mus_pres;
    public AudioSource mus_menu;
    public bool inicio;
    public GameObject pres_ui;
    public GameObject pres_ui2;

    public GameObject menu_ui;
    public Text slotinfo1;
    public Text slotinfo2;
    public bool actN;

    public int com = 0;
    public GameObject player;
    public GameObject cam;
	public GameObject tactil;
    public AudioSource menum;
	public AudioSource juegom;
    public GameObject obj;
    public GameObject canvas;
    public int mundo = 0;

	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
        Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
        
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        manager.cargarslot();
        
        

        


        
    }
    public void act()
    {
        cam_a.SetBool("skip",true);
        pres_a.SetBool("skip",true);
        inicio = true;
        pres_ui.SetActive(false);
        pres_ui2.SetActive(false);
        menu_ui.SetActive(true);
        temp = 0;

    }
    // Update is called once per frame
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
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;

        if(actN == true && temp > 3)
        {
            manager.datosconfig.carga = "cinematicaprologo1_al1";
            manager.guardarconfig();
            manager.guardar();
			SceneManager.LoadScene("carga");
        }
        if(controles.al1_UI.menu1.ReadValue<float>() > 0 && inicio == false)
        {
            act();
        }
        if(manager.datosconfig.idioma == "es")
        {
            pres.text = "presenta";
        }
        if(manager.datosconfig.idioma == "en")
        {
            pres.text = "presents";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            pres.text = "presenta";
        }
        
        if(temp > 8 && inicio == false)
        {
            act();
        }

        if(manager.datosserial.datos_llenos == true)
        {
            vistaestados.SetActive(true);

            slotinfo1.text = manager.datosserial.nameCH[0].ToString();
            if (manager.datosconfig.idioma == "es")
            {
                string resp;
                if (manager.datosserial.demoFIN == true)
                {
                    resp = "si";
                }
                else
                {
                    resp = "no";
                }
                slotinfo2.text = "Tiempo de Juego : " + manager.datosserial.horas + ":" + manager.datosserial.minutos.ToString("D2")+ ":"+ manager.datosserial.segundos.ToString("00") + "\n" +
                "Nivel Alien : "+manager.datosserial.niveljug+"\n"+
                "Misiones Completadas : "+manager.MisionesCumplidas +"/12"+"\n"+
                "Demo terminada : "+resp;
            }

        }
        else
        {
            vistaestados.SetActive(false);
        }


        if(temp > 3f)
        {
            
            manager.datosserial.datos_llenos = true;        
            manager.guardar();
            mus_menu.Stop();
            st.Play();
            actN = true;
            temp = 0;
            

        }
    }

        
    public void continuar()
    {
        if (temp >= 1)
        {
            if (manager.datosserial.datos_llenos == true)
            {   
                manager.datosserial.com = 1;
                manager.guardar();
                com = 1;
                player.GetComponent<jugador1_al3>().enabled = true;
                if(manager.juego == 1)
                {
                cam.GetComponent<movcam_al3>().enabled = true;
                }
                menum.Stop();
                juegom.Play();
                obj.SetActive(true);
                canvas.SetActive(false);
                if(manager.datosconfig.plat == 2)
                {
                    
                    tactil.SetActive(true);
                }

            }
            else
            {
                manager.datosconfig.carga = "nueva_al3";
                manager.guardarconfig();
                manager.guardar();
                SceneManager.LoadScene("carga");
            }	
        }
    }
	public void opciones()
    {
        if (temp >= 1)
        {
            manager.datosconfig.lastgame = 1;
            manager.datosconfig.carga = "opcionesbase";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
            
            temp = 0;
        }
    }
	public void volver()
    {
        if (temp >= 1)
        {
            manager.datosconfig.carga = "menutrilogy";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
            temp = 0;
        }
    }
}
