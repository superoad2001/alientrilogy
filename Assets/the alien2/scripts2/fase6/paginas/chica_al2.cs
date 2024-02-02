using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class chica_al2 : MonoBehaviour
{
    public AudioSource audioesp;
	public AudioSource audioen;
	public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if (manager.paginas != 20)
        {
            transform.position = new Vector3 (0,600,0);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if (col.gameObject.tag == "Player")
		{
			if(manager.datosconfig.idioma == "es")
            {audioesp.Play();}
            if(manager.datosconfig.idioma == "cat")
            {audiocat.Play();}
            if(manager.datosconfig.idioma == "en")
            {audioen.Play();}
            manager.datosserial.finalbueno = 1;
            manager.guardar();
		}
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
		{
			audioesp.Stop();
            audioen.Stop();
            audiocat.Stop();
		}
    }
}
