using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawntutorial_al3: MonoBehaviour
{
	public manager_al3 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player")
		{
            manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
            manager.datosserial.alien3muere = 1;
            manager.guardar();
			SceneManager.LoadScene("carga_al3");
		}
    }*/
}
