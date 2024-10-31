using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jefe6_1g_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public jefe6_1_al2 jefe6_1;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jefe6_1 = (jefe6_1_al2)FindFirstObjectByType(typeof(jefe6_1_al2));
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    private void OnTriggerEnter(Collider col)
	{
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jefe6_1_al2 jefe6_1 = (jefe6_1_al2)FindFirstObjectByType(typeof(jefe6_1_al2));
		if (col.gameObject.tag == "bala")
        {
         	jefe6_1.vida -= 20000;
			UnityEngine.Object.Destroy(col.gameObject);
			
        }
	}
}
