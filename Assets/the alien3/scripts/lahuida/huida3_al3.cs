using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class huida3_al3: MonoBehaviour
{
	public manager_al3 manager;
    public AudioSource audio1;
    public AudioSource audio1es;
	public AudioSource audio1en;
	public AudioSource audio1cat;

    // Start is called before the first frame update
    void Start()
    {
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
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
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));

        if (col.gameObject.tag == "Player")
		{
            SceneManager.LoadScene("escena1_al3");
		}
        
	}
    private void OnCollisionEnter(Collision col)
	{
       
	}
}
