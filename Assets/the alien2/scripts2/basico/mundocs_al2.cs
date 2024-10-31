using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class mundocs_al2 : MonoBehaviour
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
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player")
		{
            manager.datosserial.univel = 0;
            manager.guardar();
			SceneManager.LoadScene("mundo_abierto_al2");
        
		}
	}
}
