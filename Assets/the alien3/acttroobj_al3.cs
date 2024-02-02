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
    private void OnCollisionEnter(Collision col)
	{
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if (col.gameObject.tag == "Player")
		{
            if(trofeo == 1)
            {
                
                manager.datostrof.alien3huevooculto = 1;
                manager.guardartro();
            }
            aviso.Play();
        }
    }
}
