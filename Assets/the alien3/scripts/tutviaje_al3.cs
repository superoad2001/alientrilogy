using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutviaje_al3: MonoBehaviour
{
    public AudioSource tutesp;
	public AudioSource tutespes;
	public AudioSource tutespen;
	public AudioSource tutespcat;
    public bool espacio1;
    // Start is called before the first frame update
    void Start()
    {
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if(espacio1 == true)
		{
			if(manager.datosconfig.idioma == "es")
			{
				tutesp = tutespes;
			}
			if(manager.datosconfig.idioma == "en")
			{
				tutesp = tutespen;
			}
			if(manager.datosconfig.idioma == "cat")
			{
				tutesp = tutespcat;
			}
			tutesp.Play();
			espacio1 = false;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
