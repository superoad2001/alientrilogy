using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class presentacion_al2 : MonoBehaviour
{

    public float temp = 0;
    public Text[] botones = new Text[2];

    public AudioSource st;
    public Text pres;
    public Text ad;
    public GameObject vistaestados;
    public Text[] nombres = new Text [9];
    public InputField input;
    public List<string> names;

    public GameObject iB1;
    public GameObject inputB;

    // Start is called before the first frame update
    public manager_al2 manager;
    public Animator cam_a;
    public Animator pres_a;
    public bool sobre_esc;
     public Text[] slotname = new Text[6];
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
    public Text slotinfo1;
    public Text slotinfo2;
    public GameObject crearobj;
    public GameObject menu;
    public bool actN;

    public int creacion = 0;

	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
        Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
        
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        gemas = manager.datosserial.economia[0];
        manager.cargarslot();
        if(manager.datosconfig .idioma == "es")
        {
            botones[0].text = "Estas seguro?";
            botones[1].text = "Borrar";
            botones[2].text = "Volver";
            botones[3].text = "nombre...";
        }
        
        

        


        
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
        mus_pres.Stop();
        mus_menu.Play();
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
        if(creacion == 1)
        {
            if(manager.datosconfig.idioma == "es")
            {
                nombres[0].text = "como te llamas";
                botones[4].text = "aceptar";
                botones[5].text = "salir";


                nombres[1].text = "";
                nombres[5].text = "";
                nombres[2].text = "";
                nombres[6].text = "";
                nombres[3].text = "";
                nombres[7].text = "";
                nombres[4].text = "";
                nombres[8].text = "";
            }
        }
        if(creacion == 2)
        {
            if(manager.datosconfig.idioma == "es")
            {
                nombres[0].text = "Como se llama tu hijo";
                nombres[1].text = "Tu nombre es";
                nombres[5].text = names[0];
                nombres[2].text = "";
                nombres[6].text = "";
                nombres[3].text = "";
                nombres[7].text = "";
                nombres[4].text = "";
                nombres[8].text = "";

            }
        }
        if(creacion == 3)
        {
            if(manager.datosconfig.idioma == "es")
            {
                nombres[0].text = "Como se llama tu pareja";
                nombres[1].text = "Tu nombre es";
                nombres[5].text = names[0];
                nombres[2].text = "Tu hijo se llama";
                nombres[6].text = names[1];
                nombres[3].text = "";
                nombres[7].text = "";
                nombres[4].text = "";
                nombres[8].text = "";

            }
        }
        if(creacion == 4)
        {
            if(manager.datosconfig.idioma == "es")
            {
                nombres[0].text = "Como se llama tu jefe";
                nombres[1].text = "Tu nombre es";
                nombres[5].text = names[0];

                nombres[2].text = "Tu hijo se llama";
                nombres[6].text = names[1];

                nombres[3].text = "Tu pareja se llama";
                nombres[7].text = names[2];
                nombres[4].text = "";
                nombres[8].text = "";

            }
        }
        if(creacion == 5)
        {
            if(manager.datosconfig.idioma == "es")
            {
                nombres[0].text = "Entonces esto es todo correcto?";
                nombres[1].text = "Tu nombre es";
                nombres[5].text = names[0];

                nombres[2].text = "Tu hijo se llama";
                nombres[6].text = names[1];

                nombres[3].text = "Tu pareja se llama";
                nombres[7].text = names[2];

                nombres[4].text = "Tu jefe se llama";
                nombres[8].text = names[3];

                botones[4].text = "Esta bien";
                botones[5].text = "Reinicar";

            }
            inputB.SetActive(false);
        }
        if(creacion == 6)
        {
            if(manager.datosconfig.idioma == "es")
            {
                nombres[0].text = "";
                nombres[1].text = "Ahora comienza tu aventura";
                nombres[5].text = names[0]+"...";

                nombres[2].text = "";
                nombres[6].text = "";
                nombres[3].text = "";
                nombres[7].text = "";
                nombres[4].text = "";
                nombres[8].text = "";
            }


            iB1.SetActive(false);


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

        

    }
    public void continuar_crear()
    {
        for(int i = 0; i < names.Count ; i++)
        {
            if(input.text == names[i] && creacion < 5)	
            {
                input.text = "se mas creativa/o";
                temp = 0;
            }
        }

        if(input.text.Length >= 3 && input.text != "se mas creativa/o" && temp >= 1 && creacion < 5)	
        {
            names.Add(input.text);
            input.text = "";
            creacion += 1;
            temp = 0;
        }
        else if(temp >= 1 && creacion == 5)	
        {
            manager.datosserial.nameCH = names;
            manager.guardar();
            creacion += 1;
            temp = 0;
        }
        else if(input.text.Length < 3 && creacion < 5)	
        {
            input.text = "se mas creativa/o";
            temp = 0;
        }
    }
    public void continuar_crear_no()
    {
        if(temp >= 1 && creacion == 5)	
        {
            names = new List<string>();
            input.text = "";
            creacion = 0;
            temp = 0;
            inputB.SetActive(true);
        }
        else if(temp >= 1)	
        {
            names = new List<string>();
            input.text = "";
            creacion = 0;
            temp = 0;
            inputB.SetActive(true);
            cam_a.SetInteger("modo",1);
            menu_a.SetInteger("modo",1);
            crearobj.SetActive(false);
            menu.SetActive(true);

            menuv();
        }

    }
    public void continuar()
    {
        if (temp >= 1)
        {
            if (manager.datosserial.datos_llenos == true)
            {   if(manager.datosserial.begin == true)
                {
                    if(manager.datosserial.nivelu != "")
                    {
                        manager.datosconfig.carga = manager.datosserial.nivelu;
                        manager.guardarconfig();
                        manager.guardar();
				        SceneManager.LoadScene("carga");
                        temp = 0;
                    }
                    else
                    {
                        manager.datosconfig.carga = "mundo_abierto_al2";
                        manager.guardarconfig();
                        manager.guardar();
				        SceneManager.LoadScene("carga");
                        temp = 0;
                    }
                }
                else
                {
                    mus_menu.Stop();
                    st.Play();
                    actN = true;
                    temp = 0;

                }
            }
            else
            {
                nuevap();
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
            eventslot.SetActive(true);
            temp = -1;


            slotname[0].text = "vacio";
            slotname[1].text = "vacio";
            slotname[2].text = "vacio";
            slotname[3].text = "vacio";
            slotname[4].text = "vacio";
            slotname[5].text = "vacio";
            manager.cargarallslots();
            if(manager.datosserialallslots[0].datos_llenos == true)
            {
                slotname[0].text = manager.datosserialallslots[0].nameCH[0];
            }
            if(manager.datosserialallslots[1].datos_llenos == true)
            {
                slotname[1].text = manager.datosserialallslots[1].nameCH[1];
            }
            if(manager.datosserialallslots[2].datos_llenos == true)
            {
                slotname[2].text = manager.datosserialallslots[2].nameCH[2];
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
    public void menuv()
    {
        if (temp >= 1)
        {
            cam_a.SetInteger("modo",1);
            menu_a.SetInteger("modo",1);
            temp = -1;
            manager.cargarslot();
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
            ad.text = "";
            temp = -1;
            sobre_esc = false;
            
        }
    }
    public void sobreborraract()
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
            if(manager.datosconfig.idioma == "es")
            {ad.text = "sobreescribiras una partida existente";}
            temp = -1;
            sobre_esc = true;
            
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
            manager.guardarslot();
            manager.guardar();
            
            manager.borrar_data();
            temp = -1;
            eventbor.SetActive(false);
            eventslot.SetActive(true);
            
            if(sobre_esc == true)
            {
                cam_a.SetInteger("modo",4);
                menu_a.SetInteger("modo",4);
                borraractvol();
                crear();
            }
            else
            {
                cam_a.SetInteger("modo",1);
                menu_a.SetInteger("modo",1);
                borraractvol();
                menuv();
            }
            
        }
    }
    public void nuevap()
    {
         //añadir que cuando le des te de opcion de borrar partida y que no se sobrescriba automaticamente
        if (temp >= 1)
        {
            manager.GetFilePath();
            manager.cargar();
            manager.guardar();

            if(manager.datosserial.datos_llenos == true)
            {   
                manager.guardarslot();
                sobreborraract();
            }
            else
            {
                manager.guardarslot();
                manager.guardar();
                manager.borrar_data();              
                crear();
            }
        }
    }
    public void crear()
    {
        eventbor.SetActive(false);
        eventslot.SetActive(true);
        cam_a.SetInteger("modo",4);
        menu_a.SetInteger("modo",4);
        creacion = 1;
        


    }

    public void cargarp()
    {
        manager.GetFilePath();
        if (temp >= 1 && File.Exists(manager.repath))
        {
            manager.guardarslot();
            menuv();
        }
        else
        {
            manager.guardarslot();
            manager.guardar();
            manager.borrar_data();              
            menuv();
        }
    }
}
