using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acttroobj_al2 : MonoBehaviour
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
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "Player")
		{
            if(trofeo == 1)
            {
                
                manager.datostrof.alien2huevooculto = 1;
                manager.guardartro();
            }
            aviso.Play();
        }
    }
}
