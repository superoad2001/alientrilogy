using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class presentacion_al1 : MonoBehaviour
{

    public float temp = 0;
    public Text pres;
    // Start is called before the first frame update
    public manager_al1 manager;
    public Animator cam_a;
    public Animator pres_a;
    public Animator menu_a;
    public AudioSource mus_pres;
    public AudioSource mus_menu;
    public bool inicio;
    public GameObject pres_ui;
    public GameObject pres_ui2;

    public GameObject menu_ui;
    public int gemas = 0;

    public GameObject slot1b;
    public GameObject slot2b;
    public GameObject slot3b;

    public GameObject borrarb;
    public GameObject cargarb;
    public GameObject nuevab;
    public GameObject eventslot;
    public GameObject eventbor;
    public GameObject eventsel;
    public GameObject selectmode;
    public GameObject botper;
    public int slotseln;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        gemas = manager.datosserial.gemas;
        
    }
    public void slot1p()
    {
        borrarb.transform.localPosition = new Vector3 (borrarb.transform.localPosition.x,slot1b.transform.localPosition.y,borrarb.transform.localPosition.z);
        nuevab.transform.localPosition = new Vector3 (nuevab.transform.localPosition.x,slot1b.transform.localPosition.y,nuevab.transform.localPosition.z);
        cargarb.transform.localPosition = new Vector3 (cargarb.transform.localPosition.x,slot1b.transform.localPosition.y,cargarb.transform.localPosition.z);
        botper.transform.localPosition = new Vector3 (botper.transform.localPosition.x,slot1b.transform.localPosition.y,botper.transform.localPosition.z);
        eventslot.SetActive(false);
        slot1b.SetActive(false);
        slot2b.SetActive(true);
        slot3b.SetActive(true);
        selectmode.SetActive(true);
        manager.datosslot.datos1slot = 1;
        manager.cargar();
    }
    public void slot2p()
    {
        borrarb.transform.localPosition = new Vector3 (borrarb.transform.localPosition.x,slot2b.transform.localPosition.y,borrarb.transform.localPosition.z);
        nuevab.transform.localPosition = new Vector3 (nuevab.transform.localPosition.x,slot2b.transform.localPosition.y,nuevab.transform.localPosition.z);
        cargarb.transform.localPosition = new Vector3 (cargarb.transform.localPosition.x,slot2b.transform.localPosition.y,cargarb.transform.localPosition.z);
        botper.transform.localPosition = new Vector3 (botper.transform.localPosition.x,slot2b.transform.localPosition.y,botper.transform.localPosition.z);
        eventslot.SetActive(false);
        slot1b.SetActive(true);
        slot2b.SetActive(false);
        slot3b.SetActive(true);
        selectmode.SetActive(true);
        manager.datosslot.datos1slot = 2;
        manager.cargar();
    }
    public void slot3p()
    {
        borrarb.transform.localPosition = new Vector3 (borrarb.transform.localPosition.x,slot3b.transform.localPosition.y,borrarb.transform.localPosition.z);
        nuevab.transform.localPosition = new Vector3 (nuevab.transform.localPosition.x,slot3b.transform.localPosition.y,nuevab.transform.localPosition.z);
        cargarb.transform.localPosition = new Vector3 (cargarb.transform.localPosition.x,slot3b.transform.localPosition.y,cargarb.transform.localPosition.z);
        botper.transform.localPosition = new Vector3 (botper.transform.localPosition.x,slot3b.transform.localPosition.y,botper.transform.localPosition.z);
        eventslot.SetActive(false);
        slot1b.SetActive(true);
        slot2b.SetActive(true);
        slot3b.SetActive(false);
        selectmode.SetActive(true);
        manager.datosslot.datos1slot = 3;
        manager.cargar();
    }
    public void slotatras()
    {
        selectmode.SetActive(false);
        eventslot.SetActive(true);
        slot1b.SetActive(true);
        slot2b.SetActive(true);
        slot3b.SetActive(true);
        
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
        if(controles.al1.pausa.ReadValue<float>() > 0 && inicio == false)
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
        temp += 1 * Time.deltaTime;
        if(temp > 8 && inicio == false)
        {
            act();
        }

    }
    public void continuar()
    {
        if (temp >= 1)
        {
            if (manager.datosserial.begin == true)
            {
                if(manager.datosserial.nivelu != "")
                {
                    SceneManager.LoadScene(manager.datosserial.nivelu);
                    temp = 0;
                }
                else
                {
                    SceneManager.LoadScene("piso1_al1");
                    temp = 0;
                }
                
            }
            else
            {
                SceneManager.LoadScene("lallegada_al1");
                temp = 0;
            }	
        }
    }
	public void borrar()
    {
        if (temp >= 1)
        {
            cam_a.SetInteger("modo",2);
            menu_a.SetInteger("modo",2);
            temp = -1;
        }
    }
	public void opciones()
    {
        if (temp >= 1)
        {
            manager.datosconfig.lastgame = 2;
            manager.guardarconfig();
            SceneManager.LoadScene("opcionesbase");
            temp = 0;
        }
    }
	public void volver()
    {
        if (temp >= 1)
        {
            SceneManager.LoadScene("menutrilogy");
            temp = 0;
        }
    }
    public void menuv()
    {
        if (temp >= 1)
        {
            cam_a.SetInteger("modo",1);
            menu_a.SetInteger("modo",1);
            temp = -1;
        }
    }
    public void borraract()
    {
        if (temp >= 1)
        {
            selectmode.SetActive(false);
            slot1b.SetActive(true);
            slot2b.SetActive(true);
            slot3b.SetActive(true);
            eventslot.SetActive(false);
            eventbor.SetActive(true);
            cam_a.SetInteger("modo",3);
            menu_a.SetInteger("modo",3);
            temp = -1;
            
        }
    }
    public void borraractvol()
    {
        if (temp >= 1)
        {
            eventbor.SetActive(false);
            eventslot.SetActive(true);
            cam_a.SetInteger("modo",2);
            menu_a.SetInteger("modo",2);
            temp = -1;
        }
    }
    public void borrardat()
    {
        if (temp >= 1)
        {
            manager.guardar();
            cam_a.SetInteger("modo",1);
            menu_a.SetInteger("modo",1);
            manager.borrar_data();
            temp = -1;
        }
    }
    public void nuevap()
    {
         //añadir que cuando le des te de opcion de borrar partida y que no se sobrescriba automaticamente
        if (temp >= 1)
        {
            manager.guardar();
            manager.borrar_data();
            manager.guardarslot();
            continuar();
        }
    }
    public void cargarp()
    {
        if (temp >= 1)
        {
            manager.guardar();
            manager.cargar();
            manager.guardarslot();
            continuar();
        }
    }
}
