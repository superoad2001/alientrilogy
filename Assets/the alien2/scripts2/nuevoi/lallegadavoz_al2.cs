using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lallegadavoz_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public AudioSource audio1;
    public AudioSource audioesp;
    public AudioSource audioen;
    public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        if(manager.datosconfig.idioma == "es")
        {
            audio1 = audioesp;
        }
        if(manager.datosconfig.idioma == "en")
        {
            audio1 = audioen;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            audio1 = audiocat;
        }
        audio1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
