using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class huida2_al3: MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio1es;
	public AudioSource audio1en;
	public AudioSource audio1cat;
    // Start is called before the first frame update
    void Start()
    {
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
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
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();

        if (col.gameObject.tag == "Player")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        
	}
    private void OnCollisionEnter(Collision col)
	{
       
	}
}
