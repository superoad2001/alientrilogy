using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lallegadavoz_al1 : MonoBehaviour
{
	public manager_al1 manager;
    public AudioSource audio;
    public AudioSource audioesp;
    public AudioSource audioen;
    public AudioSource audiocat;
    // Start is called before the first frame update
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
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
        manager.datosserial.salasecreta = true;
		manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
