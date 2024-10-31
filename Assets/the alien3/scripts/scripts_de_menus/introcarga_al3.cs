using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introcarga_al3: MonoBehaviour
{
	public manager_al3 manager;

    public float temp = 0;
    public AudioSource audio;
    public AudioSource audioes;
    public AudioSource audioen;
    public AudioSource audiocat;
    public bool actaud;
    public float max = 94;
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
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        if(manager.datosconfig.idioma == "es")
        {
            audio = audioes;
        }
        if(manager.datosconfig.idioma == "en")
        {
            audio = audioen;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            audio = audiocat;
        }
        if(actaud == true)
        {
            audio.Play();
        }
    }
    public void act()
    {
        temp = 300;
    }
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if(audio.isPlaying == false || controles.menu.saltar.ReadValue<float>() > 0)
        {
            SceneManager.LoadScene("carga_al3");
        }
    }
}
