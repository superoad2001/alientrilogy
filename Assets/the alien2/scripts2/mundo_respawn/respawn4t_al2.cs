using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using UnityEngine.SceneManagement;

public class respawn4t_al2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
	{
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player")
		{
            manager.datostrof.alien2muere = 1;
            manager.guardartro();
			manager.datosserial.respawntipo = 3;
			manager.datosserial.univel = 0;
			manager.guardar();
            SceneManager.LoadScene("mundo_abierto_al2");
		}
	}
}
