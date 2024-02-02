using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class jefe6_1g_al2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        jefe6_1_al2 jefe6_1 = UnityEngine.Object.FindObjectOfType<jefe6_1_al2>();

        
    }
    private void OnTriggerEnter(Collider col)
	{
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        jefe6_1_al2 jefe6_1 = UnityEngine.Object.FindObjectOfType<jefe6_1_al2>();
		if (col.gameObject.tag == "bala")
        {
         	jefe6_1.vida -= 20000;
			UnityEngine.Object.Destroy(col.gameObject);
			
        }
	}
}
