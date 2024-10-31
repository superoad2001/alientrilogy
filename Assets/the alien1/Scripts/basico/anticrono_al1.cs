using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anticrono_al1 : MonoBehaviour
{
	public manager_al1 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "Player" )
        {
            manager2_al1 manager2 = (manager2_al1)FindFirstObjectByType(typeof(manager2_al1));
            manager2.contador -= 4;
            UnityEngine.Object.Destroy(base.gameObject);
        }

    }
}
