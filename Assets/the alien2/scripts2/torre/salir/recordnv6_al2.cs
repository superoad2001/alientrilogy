using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class recordnv6_al2 : MonoBehaviour
{
	public manager_al2 manager;
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
        manager2_al2 manager = (manager2_al2)FindFirstObjectByType(typeof(manager2_al2));
		if (col.gameObject.tag == "Player")
		{
            if(manager.contador < manager.datosserial.recordnv6)
            {
                manager.datosserial.recordnv6 = manager.contador;
                manager.manager.guardar();
            }
			SceneManager.LoadScene("torre_del_tiempo_al2");
		}
	}
}
