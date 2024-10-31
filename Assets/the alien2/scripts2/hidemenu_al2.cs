using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidemenu_al2 : MonoBehaviour
{
	public manager_al2 manager;

    private Controles controles;
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();
        if(controles.al2.lt.ReadValue<float>() > 0)
	    {anim.SetBool("show",true);}
        else if(controles.al2.lt.ReadValue<float>() == 0)
	    {anim.SetBool("show",false);}

    }
}
