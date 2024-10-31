using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tienda2trof_al2 : MonoBehaviour
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
    public void OnTriggerEnter(Collider col) 
    {
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        if (col.gameObject.tag == "Player")
		{
            if(manager.datostrof.alien2encuentralatiendaocultadelasegundazona == 0)
            {
                manager.datostrof.alien2encuentralatiendaocultadelasegundazona = 1;
                manager.guardartro();
                push.push(31);
            }
        }
    }
}
