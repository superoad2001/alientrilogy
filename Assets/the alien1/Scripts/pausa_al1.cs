using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class pausa_al1 : MonoBehaviour
{
    public GameObject juego;
    public GameObject pausa1;
    public int plataforma;
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
    public Text boton1;
    public Text boton2;
    public Text boton3;
    public Text boton4;
    public Text boton5;

    public Text gemas;
    public Text monedam;
    
    public Text monedar;
    public Text llave;
    public Text llaver;
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

	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C

	public void move()
	{
		moveson.Play();
	}
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));

    }

    // Update is called once per frame
    public void Update()
    {
        if(mapa == false)
        {boton = controles.al1.pausa.ReadValue<float>();}
        else
        {boton = controles.al1.select.ReadValue<float>();}
        
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
                gemas.text = manager.datosserial.gemas+"/15";
                monedam.text = manager.datosserial.monedas+" : "+manager.datosserial.monedasmax+"/50";
                monedar.text = manager.datosserial.monedasr+""+" : "+manager.datosserial.monedasrmax+"/50";
                llave.text = manager.datosserial.llaves+"/4";
                llaver.text = manager.datosserial.fragmento+"/3";
                mision1.text = manager.mision;
                mision2.text = manager.mision2;
            }
        }
        if(manager.datosconfig.idioma == "en")
        {
            if(mapa == false)
            {
            boton2.text = "exit";
            boton1.text = "continue";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "exit of the level";}
            boton4.text = "pause";
            boton5.text = "settings";
            }
            else
            {
                boton1.text = "continue";
                boton4.text = "map";
                gemas.text = manager.datosserial.gemas+"/15";
                monedam.text = manager.datosserial.monedas+" : "+manager.datosserial.monedasmax+"/50";
                monedar.text = manager.datosserial.monedasr+""+" : "+manager.datosserial.monedasrmax+"/50";
                llave.text = manager.datosserial.llaves+"/4";
                llaver.text = manager.datosserial.fragmento+"/3";
                mision1.text = manager.mision;
                mision2.text = manager.mision2;
            }
        }
        if(manager.datosconfig.idioma == "cat")
        {
            if(mapa == false)
            {
            boton2.text = "sortir";
            boton1.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "sortir a la base";}
            boton4.text = "pausa";
            boton5.text = "opcions";
            }
            else
            {
                boton4.text = "mapa";
                boton1.text = "continuar";
                gemas.text = manager.datosserial.gemas+"/15";
                monedam.text = manager.datosserial.monedas+" : "+manager.datosserial.monedasmax+"/50";
                monedar.text = manager.datosserial.monedasr+""+" : "+manager.datosserial.monedasrmax+"/50";
                llave.text = manager.datosserial.llaves+"/4";
                llaver.text = manager.datosserial.fragmento+"/3";
                mision1.text = manager.mision;
                mision2.text = manager.mision2;
            }
        }
        if(boton > 0 && temp > 0.7f)
        {
            if(mapa == false)
            {
                if(opciones1.activeSelf)
                {aplicar2();}
                continuar();
            }
            else
            {
                continuar();
            }
        }
        if(temp < 15)
        {temp += 1 * Time.unscaledDeltaTime;}
    }
    public void continuar(){
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        plataforma = manager.datosconfig.plat;
        temp = 0;
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
    public void salir(){

        SceneManager.LoadScene("menu_de_carga_al1");
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
    public void aplicar2()
    {
		manager2 = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
		controlmusicabase controlslider = (controlmusicabase)FindFirstObjectByType(typeof(controlmusicabase));


		audiomixer.GetFloat ("MusicVolume",out manager.datosconfig.musica);
		manager2.datosconfig.musicaslider = controlslider.slidermusica.value;

		audiomixer.GetFloat ("EnvironmentVolume",out manager.datosconfig.voz);
		manager2.datosconfig.vozslider = controlslider.slidervoz.value;

		audiomixer.GetFloat ("SFXVolume",out manager.datosconfig.sfx);
		manager2.datosconfig.sfxslider = controlslider.slidersfx.value;

		audiomixer.GetFloat ("UIVolume",out manager.datosconfig.ui);
		manager2.datosconfig.uislider = controlslider.sliderui.value;

		manager2.guardar();

        normal.SetActive(true);
        opciones1.SetActive(false);
		
    }
}
