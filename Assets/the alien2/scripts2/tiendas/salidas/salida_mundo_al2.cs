using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class salida_mundo_al2 : MonoBehaviour
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
    public void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("mundo_abierto_al2");
        }
    }
}
