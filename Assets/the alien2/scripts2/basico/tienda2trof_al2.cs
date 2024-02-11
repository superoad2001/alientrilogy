using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tienda2trof_al2 : MonoBehaviour
{
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
        pushup push = UnityEngine.Object.FindObjectOfType<pushup>();
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
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
