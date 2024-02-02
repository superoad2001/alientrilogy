using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiendaaud_al3: MonoBehaviour
{
    public AudioSource aud;
    public AudioSource audes;
    public AudioSource auden;
    public AudioSource audcat;
    public bool arma = true;
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
