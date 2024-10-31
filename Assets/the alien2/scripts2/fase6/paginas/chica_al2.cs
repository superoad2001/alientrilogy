using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class chica_al2 : MonoBehaviour
{
    public AudioSource audioesp;
	public AudioSource audioen;
	public AudioSource audiocat;
    public manager_al2 manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
    }

    // Update is called once per frame
    void Update()
    {
        
        if (manager.paginas != 20)
        {
            transform.position = new Vector3 (0,600,0);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
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

            if(manager.datostrof.alien2hablarcontumujer == 0)
            {
                manager.datostrof.alien2hablarcontumujer = 1;
                manager.guardartro();
                push.push(28);
            }
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
