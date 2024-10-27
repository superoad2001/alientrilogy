using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class postprocesdisabled : MonoBehaviour
{
    public Volume objeto;
    public managerBASE manager0;
    // Start is called before the first frame update
    void Start()
    {
        managerBASE manager0 = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
        manager_al1 manager1 = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        manager_al2 manager2 = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        manager_al3 manager3 = (manager_al3)FindFirstObjectByType(typeof(manager_al3));

        
        if(manager0 != null)
        {
            if(manager0.datosconfig.postpro == 1)
            {
                objeto.enabled = false;
            }
            if(manager0.datosconfig.postpro == 2)
            {
                objeto.enabled = true;
            }
        }
        if(manager1 != null)
        {
            if(manager1.datosconfig.postpro == 1)
            {
                objeto.enabled = false;
            }
            if(manager1.datosconfig.postpro == 2)
            {
                objeto.enabled = true;
            }
        }
        if(manager2 != null)
        {
            if(manager2.datosconfig.postpro == 1)
            {
                objeto.enabled = false;
            }
            if(manager2.datosconfig.postpro == 2)
            {
                objeto.enabled = true;
            }
        }
        if(manager3 != null)
        {
            if(manager3.datosconfig.postpro == 1)
            {
                objeto.enabled = false;
            }
            if(manager3.datosconfig.postpro == 2)
            {
                objeto.enabled = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(manager0 != null)
        {
            if(manager0.datosconfig.postpro == 1)
            {
                objeto.enabled = false;
            }
            if(manager0.datosconfig.postpro == 2)
            {
                objeto.enabled = true;
            }
        }
    }
}
