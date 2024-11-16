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
    public float temp;
    public int piso = 1;
    public GameObject normal;
    public GameObject opciones1;
    public AudioMixer audiomixer;
    public manager_al1 manager;
    public managerBASE manager2;
    public jugador_al1 jugador;
    // Start is called before the first frame update
    public AudioSource moveson;

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
        
        if(manager.datosconfig.idioma == "es")
        {
            boton2.text = "salir";
            boton1.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "salir del nivel";}
            boton4.text = "pausa";
            boton5.text = "opciones";
        }
        if(manager.datosconfig.idioma == "en")
        {
            boton2.text = "exit";
            boton1.text = "continue";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "exit of the level";}
            boton4.text = "pause";
            boton5.text = "settings";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            boton2.text = "sortir";
            boton1.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "sortir a la base";}
            boton4.text = "pausa";
            boton5.text = "opcions";
        }
        if(controles.al1.pausa.ReadValue<float>() > 0 && temp > 0.7f)
        {
            
            if(opciones1.activeSelf)
            {aplicar2();}
            continuar();
        }
        if(temp < 15)
        {temp += 1 * Time.unscaledDeltaTime;}
    }
    public void continuar(){
        Time.timeScale = 1;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        plataforma = manager.datosconfig.plat;
        temp = 0;
        jugador.controlact = true;
        jugador.tiemposalto = 0.9f;;
        pausa1.SetActive(false);
        if(plataforma == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
        if(plataforma == 2)
		{
			jugador.tactil.SetActive(true);
		}
        manager.pauseact = false;    
        }
    public void salir(){
        Time.timeScale = 1;
        SceneManager.LoadScene("menu_de_carga_al1");
    }

    public void salirnivel(){
        Time.timeScale = 1;
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
