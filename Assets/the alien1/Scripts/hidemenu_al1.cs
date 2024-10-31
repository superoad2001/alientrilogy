using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidemenu_al1 : MonoBehaviour
{
	public manager_al1 manager;

    private Controles controles;
    public Animator anim;
    public bool act = true;
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
            anim = GetComponent<Animator>();
            if(controles.al1.lt.ReadValue<float>() > 0)
            {anim.SetBool("show",true);}
            else if(controles.al1.lt.ReadValue<float>() == 0)
            {anim.SetBool("show",false);}

    }
}
