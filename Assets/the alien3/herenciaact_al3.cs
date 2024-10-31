using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class herenciaact_al3 : MonoBehaviour
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
    public void OnTriggerEnter(Collider col) 
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        if(col.gameObject.tag == "Player")
        {
            if(manager.datosserial.herencia != 1)
            {
                SceneManager.LoadScene("trasnferir2_al3");
            }
        }
    }
}
