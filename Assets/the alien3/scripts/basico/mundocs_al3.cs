using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class mundocs_al3: MonoBehaviour
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
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (col.gameObject.tag == "Player")
		{
            manager.datosserial.univel = 0;
			SceneManager.LoadScene("mundo_abierto_al3");
            
		}
	}
}
