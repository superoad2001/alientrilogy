using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class jefe4fin_al2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "jefe")
        {
            SceneManager.LoadScene("mundo_abierto_al2");
			
        }
		if (col.gameObject.tag == "Player")
        {
            manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
            if (manager.datosserial.tengomental == 1)
            {
                SceneManager.LoadScene("mundo_abierto_al2");
            }
            if (manager.datosserial.tengomental == 0)
            {
                SceneManager.LoadScene("mejora4_al2");
            }
			
        }
	}
}
