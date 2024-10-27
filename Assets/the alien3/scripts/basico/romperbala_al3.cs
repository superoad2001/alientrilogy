using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class romperbala_al3: MonoBehaviour
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
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (col.gameObject.tag == "suelo")
		{
			UnityEngine.Object.Destroy(base.gameObject);
			
		}
	}
    private void OnCollisionEnter(Collision col)
	{
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (col.gameObject.tag == "suelo")
		{
			UnityEngine.Object.Destroy(base.gameObject);
			
		}
	}
}
