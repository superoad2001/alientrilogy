using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiendaaud_al3: MonoBehaviour
{
    public AudioSource aud;
    public AudioSource audes;
    public AudioSource auden;
    public AudioSource audcat;



    public AudioSource audio1;
	public AudioSource audio1es;
	public AudioSource audio1en;
	public AudioSource audio1cat;
    public bool arma = true;

    public bool tut = false;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        if(manager.datosconfig.idioma == "es")
        {
            aud = audes;
        }
        if(manager.datosconfig.idioma == "en")
        {
            aud = auden;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            aud = audcat;
        }


        
        if (manager.datosconfig.idioma == "es")
		{
			audio1 = audio1es;
		}
		if (manager.datosconfig.idioma == "en")
		{
			audio1 = audio1en;
		}
		if (manager.datosconfig.idioma == "cat")
		{
			audio1 = audio1cat;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Player" && arma == true)
        {
        aud.Play();
        if(tut == true)
        {audio1.Stop();}
        }
    }
    private void OnTriggerExit(Collider col)
	{
        if(col.gameObject.tag == "Player" && arma == true)
        {
        aud.Stop();
        }
    }
}
