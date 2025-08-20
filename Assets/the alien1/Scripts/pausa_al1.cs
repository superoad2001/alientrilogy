using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.InputSystem.UI;
using TMPro;

public class pausa_al1 : MonoBehaviour
{
    public AudioSource positive;
    public AudioSource negative;
    public GameObject juego;
    public GameObject pausa1;
    public int plataforma;
    public bool expmu;
    public GameObject controlobj;


    public GameObject mapa_b;
    public GameObject misiones_b;
    public GameObject notas_b;
    public GameObject estad_b;
    public GameObject objetos_b;

    public Text[] misT = new Text[7];
    public Text[] notT = new Text[7];
    public GameObject[] misB = new GameObject[7];
    public int contadormispag;
    List<string> misionesA = new List<string>();
    List<string>  misionesdesc = new List<string>();


    public Controles controles;

    public opcionespause oppau;

    [SerializeField]
	public misiones_al1 dmisiones;
    [SerializeField]
	public notas_al1 dnotas;

    public UnityEngine.InputSystem.UI.InputSystemUIInputModule inputModule;
    
    private UnityEngine.InputSystem.InputActionAsset originalControls;
    
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
        if (originalControls == null && inputModule != null)
        {
            originalControls = inputModule.actionsAsset;
        }
    }
    public void RestoreOriginalControls()
    {
        if (originalControls != null && inputModule != null)
        {
            inputModule.actionsAsset = originalControls;
        }
    }
    

    public int largomision;
    public Text boton1;
    public Text boton2;
    public Text boton3;
    public Text boton4;
    public Text boton5;
    public Text boton6;
    public Text boton7;

    public Text gemas;
    public Text monedam;
    public Text monedaa;
    public Text monedar;
    public Text llave;
    public Text llaver;
    public Text licencia;
    public Text mision1;
    public Text mision2;
    public Text inText;

    public Text Estadisitcas_panel1;
    public Text Objetos_panel1;
    public float temp;
    public int piso = 1;
    public GameObject normal;
    public GameObject opciones1;
    public AudioMixer audiomixer;
    public manager_al1 manager;
    public managerBASE manager2;
    public jugador_al1 jugador;
    public int modo;
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
    public int paginasM = 0;
    private int misionesindice;
    private int misionesindicemin;
    private int misionesmax;
    public Text misionT;
    public Text misiondescT;
    public GameObject botizqM;
    public GameObject botderM;
    public AudioSource nop;
    public Text notasT;
    public Text notasdescT;
    public bool controlact;
    




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
        controlact = true;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        if(modo == 1)
        {
            mapa_();
            misionT.text = manager.datosserial.misionS;
            misiondescT.text = manager.datosserial.misiondescS;
        }
        if(manager.datosconfig.idioma == "es")
        {
            if(modo == 0)
            {
            boton1.text = "Continuar";
            if(manager.nivelact)
            {boton2.text = "Salir del nivel";}
            else
            {
                boton2.text = "Salir del juego";
            }
            boton4.text = "Pausa";
            boton5.text = "Opciones";
            boton6.text = "Controles";
            boton7.text = "atras";
            }
        }
        
        

    }
    public void ubicar()
    {
        camaramapa.transform.position = new Vector3(jugador.transform.position.x,jugador.transform.position.y + 356f,jugador.transform.position.z);
    }
    public void notasC()
    {
        for(int i = 0; i < 7; i++)
        {
            if(manager.datosserial.notas[i] == true)
        	{
                notT[i].text = "nota"+(i+1);
            }
            else
        	{
                notT[i].text = "???";
            }
        }
        notasT.text = "???";
        notasdescT.text = "???";

    }
    public void misionesC()
    {
        misionesindice = 0;
        misionesindicemin = 0;
        misionesmax = 0;
        for(int i = misionesindicemin; i < largomision && i < misionesindicemin+7; i++)
        {
        	misT[misionesmax].text = misionesA[i];
            misionesmax++;
        }
        for(int i = 0; i < 7; i++)
        {
        	misB[i].SetActive(false);
        }
        for(int i = 0; i < misionesmax; i++)
        {
        	misB[i].SetActive(true);
        }
        misionT.text = "???";
        misiondescT.text = "???";

    }
    public void misionesCder()
    {
        nop.Stop();
        if(misionesindice  < paginasM)
        {
            misionesindice++;
            misionesindicemin += 7;
            misionesmax = 0;
            for(int i = misionesindicemin; i < largomision && i < misionesindicemin+7; i++)
            {
                misT[misionesmax].text = misionesA[i];
                misionesmax++;
            }
            for(int i = 0; i < 7; i++)
            {
                misB[i].SetActive(false);
            }
            for(int i = 0; i < misionesmax; i++)
            {
                misB[i].SetActive(true);
            }
        
        }
        else
        {   
            nop.Play();
        }

    }
    public void misionesCizq()
    {
        if(misionesindice  > 0)
        {
            misionesindice--;
            misionesindicemin -= 7;
            misionesmax = 0;
            for(int i = misionesindicemin; i < largomision && i < misionesindicemin+7; i++)
            {
                misT[misionesmax].text = misionesA[i];
                misionesmax++;
            }
            for(int i = 0; i < 7; i++)
            {
                misB[i].SetActive(false);
            }
            for(int i = 0; i < misionesmax; i++)
            {
                misB[i].SetActive(true);
            }
        }
        else
        {
            nop.Stop();
            nop.Play();
        }

    }
    public void botonmision(int boton1)
    {
        misionT.text = misionesA[boton1 + misionesindicemin];
        misiondescT.text = misionesdesc[boton1 + misionesindicemin];
        mision1.text = misionesdesc[boton1 + misionesindicemin];
        manager.datosserial.misionS = misionesA[boton1 + misionesindicemin];
        manager.datosserial.misiondescS = misionesdesc[boton1 + misionesindicemin];
        manager.guardar();

    }
    public void botonnotas(int boton1)
    {
        if(manager.datosserial.notas[boton1] == true)
        {
            notasT.text = dnotas.notas[boton1];
            notasdescT.text = dnotas.notasdesc[boton1];
        }
        else
        {
            notasT.text = "???";
            notasdescT.text = "???";
            nop.Play();
        }
        

    }

    // Update is called once per frame
    public void Update()
    {
        if(modo == 1)
        {

        Estadisitcas_panel1.text =
        "Enemigos asesinados : "+manager.datosserial.asesinatos+"\n"+
        "Muertes : "+manager.datosserial.muertes+"\n"+
        "Nivel Nave : "+manager.datosserial.niveljugnave+"\n"+

        "Nivel Alien : "+manager.datosserial.niveljug+"\n"+
        "Experienca : "+(int)manager.datosserial.nivelexp+"\n"+
        "Req.Sig NV : "+manager.datosserial.signivelexp+"\n"+
        "Logros : "+manager.datosserial.Logros+"\n"+
        "Jefes Ven : "+manager.datosserial.JefesVen+"\n"+
        "Kart Points : "+manager.datosserial.puntoskarting+"\n"+
        "Misiones Completadas : "+manager.MisionesCumplidas+"/12"+"\n"+
        "Tiempo de Juego : "+manager.datosserial.horas+":"+manager.datosserial.minutos.ToString("D2")+":"+manager.datosserial.segundos.ToString("00");
        Objetos_panel1.text =
        "Armas Alien : "+manager.datosserial.ArmasAlienObtenidas +"\n"+
        "Armas Nave : "+manager.datosserial.ArmasNaveObtenidas +"\n"+ 
        "Habilidades Obt. : "+manager.datosserial.HabilidadesObtenidas+"\n"+
        "Coches Obt. : "+manager.datosserial.CochesObtenidos+"\n"+
        "NV La ParteCraneos : "+manager.datosserial.nivelarmapalo+"\n"+
        "NV El Gatillazonador : "+manager.datosserial.nivelarmapapa+"\n"+
        "NV HARMONIZADORA: "+manager.datosserial.nivelarmarel+"\n"+
        "NV PX4000 : "+manager.datosserial.nivelarmadef+"\n"+
        "NV RataTaPUM V2 : "+manager.datosserial.nivelarmanave1+"\n"+
        "NV REYNOVES : "+manager.datosserial.nivelarmanave3+"\n"+
        "NV Mina Guardian : "+manager.datosserial.nivelarmanave2+"\n"+
        "NV InSitu: "+manager.datosserial.nivelarmanave4;
        }
        if(mapaact == true)
        {
            if(controles.al1_UI.ubi.ReadValue<float>() > 0)
            {
                ubicar();
            }

            xmapC = controles.al1_3d.UIX.ReadValue<float>();
            ymapC = controles.al1_3d.UIY.ReadValue<float>();

            



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
        if (inicio == false && modo == 1)
        {
            largomision = 0;
            inicio = true;
            ubicar();
            for(int i = 0; i < manager.datosserial.misiones.Length; i++)
            {
                if(manager.datosserial.misiones[i] == 1)
                {
                    misionesA.Add(dmisiones.misiones[i]);
                    misionesdesc.Add(dmisiones.misionesdesc[i]);
                    largomision++;
                }
            }

            for(int i = 0; i < largomision; i++)
            {
                if(contadormispag > 6)
                {
                    contadormispag = 0;
                    paginasM++;
                }
                contadormispag++;

            }
            
        }
        if(modo == 0 && controlact == true)
        {
            boton = controles.al1_UI.menu1.ReadValue<float>();
        }
        else if(modo == 1)
        {
            boton = controles.al1_UI.menu2.ReadValue<float>();
        }
        else if(modo == 2)
        {
            boton = controles.al1_UI.menu1.ReadValue<float>();
        }
        
    	if(controlact == true)
        {
        botonb = controles.al1_UI.atras.ReadValue<float>();
        }
        
        if(manager.datosconfig.idioma == "es")
        {
            if(modo == 0)
            {
            
            boton1.text = "Continuar";
            if(manager.nivelact)
            {boton2.text = "Salir del nivel";}
            else
            {
                boton2.text = "Salir del juego";
            }
            boton4.text = "Pausa";
            boton5.text = "Opciones";
            boton6.text = "Controles";
            boton7.text = "atras";
            }
            else if(modo == 1)
            {
                boton1.text = "Continuar";
                boton4.text = "Mapa";
                
                gemas.text = manager.datosserial.economia[0]+"";
                llave.text = manager.datosserial.economia[1]+"";
                llaver.text = manager.datosserial.economia[2]+"";           
                monedar.text = manager.datosserial.economia[3]+"";
                monedam.text = manager.manager.datosserial.economia[4]+"";
                monedaa.text = manager.datosserial.economia[5]+"";
                licencia.text = manager.datosserial.economia[6]+"";

                mision1.text = manager.datosserial.misionS;
                mision2.text = manager.datosserial.misiondescS;

                //economia[0] = gemas;
                //economia[1] = llaves;
                //economia[2] = fragllave;
                //economia[3] = monedasrojas;
                //economia[4] = monedasmoradas;
                //economia[5] = monedasamarillas;
            }
        }
        if(boton > 0 && temp > 0.7f )
        {
            if(modo == 0)
            {
                if(opciones1.activeSelf)
                {
                    no_aplicar();
                }
                controlobj.SetActive(false);
                normal.SetActive(true);
                continuar();
            }
            else if(modo == 1)
            {
                inicio = false;
                continuar_M();
                
            }
            else if(modo == 2)
            {
                continuar_A();
                
            }
        }
        if(botonb > 0 && temp > 0.7f)
        {
            if(modo == 0)
            {
                if(opciones1.activeSelf)
                {
                    no_aplicar();
                }
                else if(controlobj.activeSelf)
                {
                    controlobj.SetActive(false);
                    normal.SetActive(true);
                }
                else
                {
                    continuar();
                }
                
            }
            else if(modo == 1)
            {
                inicio = false;
                continuar_M();
                
            }
            else if(modo == 2)
            {
                continuar_A();
                
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
        if(jugador.modo == "Coche" )
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave" )
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
        if(jugador.modo == "Coche" )
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave" )
        {
            jugador.anim.SetBool("act",true);
        }
    
        Time.timeScale = 1;
        pausa1.SetActive(false);
    }
    public void continuar_A(){
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
        if(manager.datosserial.armadefdesbloqueada == true && manager.tutorialintro == false)
        {
            jugador.dispF = true;
            positive.Play();
            
        }
        else if(expmu == true && manager.tutorialintro  == true)
        {
            jugador.dispF = true;
            positive.Play();
            jugador.vida = 0;
            
        }
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        if(plataforma == 2)
		{
			jugador.tactil.SetActive(true);
		}
        manager.pauseact = false;    
        if(jugador.modo == "Coche" )
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave" )
        {
            jugador.anim.SetBool("act",true);
        }
        
        pausa1.SetActive(false);
    }
    public void desbloqueararma()
    {
        string textM = inText.text.ToUpper();

    	if(textM == "ARHODA201920??" && manager.tutorialintro == false)
        {
            manager.datosserial.armadefdesbloqueada = true;
            manager.guardar();
            continuar_A();

        }
        else if(textM == "ARHODA201920??" && manager.tutorialintro  == true)
        {
            expmu = true;
            continuar_A();

        }
        else
        {
            nop.Play();
        }
    }
    public void salir(){
        Time.timeScale = 1;
        manager.datosconfig.carga = "menu_de_carga_al1";
        manager.guardarconfig();
        manager.guardar();
				SceneManager.LoadScene("carga");
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
        misionesC();
        notas_b.SetActive(false);
        estad_b.SetActive(false);
        objetos_b.SetActive(false);
        mapa_b.SetActive(false);
        misiones_b.SetActive(true);

    }
    public void notas()
    {
        mapaact = false;
        notasC();
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
        Time.timeScale = 1;
        manager.datosserial.actual_checkpoint = 0;
        manager.guardar();
        manager.datosconfig.carga = manager.datosserial.nivelu;
        manager.guardarconfig();
        manager.guardar();
				SceneManager.LoadScene("carga");

    }
    public void opciones()
    {
        controlact = false;
        normal.SetActive(false);
        opciones1.SetActive(true);
    }
    public void guia()
    {
        normal.SetActive(false);
        controlobj.SetActive(true);
    }
    public void guia_atras()
    {
        controlobj.SetActive(false);
        normal.SetActive(true);
    }
    public void aplicar()
    {
		oppau.aplicartodo();
        opciones1.SetActive(false);
        normal.SetActive(true);
        
		
    }
    public void no_aplicar()
    {
        temp = 0;
        controlact = true;
        opciones1.SetActive(false);
        normal.SetActive(true);
        
		
    }
}
