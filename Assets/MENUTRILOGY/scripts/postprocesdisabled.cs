using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class postprocesdisabled : MonoBehaviour
{
    public PostProcessVolume objeto;
    // Start is called before the first frame update
    void Start()
    {
        managerBASE manager0 = UnityEngine.Object.FindObjectOfType<managerBASE>();
        manager_al1 manager1 = UnityEngine.Object.FindObjectOfType<manager_al1>();
        manager_al2 manager2 = UnityEngine.Object.FindObjectOfType<manager_al2>();
        manager_al3 manager3 = UnityEngine.Object.FindObjectOfType<manager_al3>();

        
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
        managerBASE manager0 = UnityEngine.Object.FindObjectOfType<managerBASE>();
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
