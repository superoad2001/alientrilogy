using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introcarga_al3: MonoBehaviour
{

    public float temp = 0;
    public AudioSource audio;
    public AudioSource audioes;
    public AudioSource audioen;
    public AudioSource audiocat;
    public bool actaud;
    public float max = 94;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
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
        if(temp >= max)
        {
            SceneManager.LoadScene("carga_al3");
        }
    }
}
