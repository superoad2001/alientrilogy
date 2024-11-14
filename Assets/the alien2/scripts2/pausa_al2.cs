using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class pausa_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public managerBASE manager2;
    public GameObject juego;
    public GameObject pausa1;
    public int plat;
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
    public float temp;
    public Text boton1;
    public Text boton2;
    public Text boton3;
    public Text boton4;
    public Text boton5;
    public GameObject normal;
    public GameObject opciones1;
    public AudioMixer audiomixer;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
    }

    // Update is called once per frame
    void Update()
    {

        
        manager.datosserial.pause = true;
        if(manager.datosconfig.idioma == "es")
        {
            boton1.text = "salir";
            boton2.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 20 || manager.nivel <= -1 && manager.nivel >= -20)
            {boton3.text = "salir del nivel";}
            boton4.text = "pausa";
            boton5.text = "opciones";
        }
        if(manager.datosconfig.idioma == "en")
        {
            boton1.text = "exit";
            boton2.text = "continue";
            if(manager.nivel >= 1 && manager.nivel <= 20 || manager.nivel <= -1 && manager.nivel >= -20)
            {boton3.text = "exit of the level";}
            boton4.text = "pause";
            boton5.text = "settings";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            boton1.text = "sortir";
            boton2.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 20 || manager.nivel <= -1 && manager.nivel >= -20)
            {boton3.text = "sortir a la base";}
            boton4.text = "pausa";
            boton5.text = "opcions";
        }
        if(controles.al2.pausa.ReadValue<float>() > 0 && temp > 0.5f)
        {
			if(opciones1.activeSelf)
            {aplicar2();}
            continuar();
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
    public void continuar(){
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        plat = manager.datosconfig.plat;
        temp = 0;
        juego.SetActive(true);
        pausa1.SetActive(false);
        if(plat == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
    }
    public void salir(){
        SceneManager.LoadScene("menu_de_carga_al2");
    }

    public void salirnivel(){
        SceneManager.LoadScene("mundo_abierto_al2");
    }

    public void salirnivel2(){
        SceneManager.LoadScene("torre_del_tiempo_al2");
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
