using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acttroobj_al3 : MonoBehaviour
{
    public int trofeo;
    public AudioSource aviso;
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
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
		if (col.gameObject.tag == "Player")
		{
            if(trofeo == 1 && manager.datostrof.alien3huevooculto == 0)
            {
                
                manager.datostrof.alien3huevooculto = 1;
                manager.guardartro();
                push.push(100);
                
            }
            aviso.Play();
        }
    }
}
