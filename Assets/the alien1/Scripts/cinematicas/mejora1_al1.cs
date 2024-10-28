using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mejora1_al1 : MonoBehaviour
{
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
    public AudioSource audio;
    public AudioSource audioesp;
    public AudioSource audioen;
    public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        manager_al1 manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(manager.datosconfig.idioma == "es")
        {
            audio = audioesp;
        }
        if(manager.datosconfig.idioma == "en")
        {
            audio = audioen;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            audio = audiocat;
        }
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audio.isPlaying || controles.menu.saltar.ReadValue<float>() > 0)
		{
			SceneManager.LoadScene("tienda_al1");
		}
    }
}
