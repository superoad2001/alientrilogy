using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acttroobj_al1 : MonoBehaviour
{
	public manager_al1 manager;
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
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
            if(trofeo == 1 && manager.datostrof.alien1huevooculto == 0)
            {
                
                manager.datostrof.alien1huevooculto = 1;
                manager.guardartro();
                push.push(18);
            }
            if(trofeo == 2 && manager.datostrof.alien1secretobajoelasteroide == 0)
            {
                
                manager.datostrof.alien1secretobajoelasteroide = 1;
                manager.guardartro();
                push.push(21);
            }
            aviso.Play();
        }
    }
}
