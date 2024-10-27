using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lallegadavoz_al1 : MonoBehaviour
{
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
        
    }
}
