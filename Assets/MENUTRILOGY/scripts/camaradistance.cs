using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaradistance : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        managerBASE manager0 = UnityEngine.Object.FindObjectOfType<managerBASE>();
        manager_al1 manager1 = UnityEngine.Object.FindObjectOfType<manager_al1>();
        manager_al2 manager2 = UnityEngine.Object.FindObjectOfType<manager_al2>();
        manager_al3 manager3 = UnityEngine.Object.FindObjectOfType<manager_al3>();

        cam = this.gameObject.GetComponent<Camera>();
        
        if(manager0 != null)
        {
            if(manager0.datosconfig.distancia == 200 || manager0.datosconfig.distancia == 500 || manager0.datosconfig.distancia == 1000 || manager0.datosconfig.distancia == 2000 || manager0.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager0.datosconfig.distancia;
            }
            if(manager0.datosconfig.resoluciones == 1)
            {
                
            }
        }
        if(manager1 != null)
        {
            if(manager1.datosconfig.distancia == 200 || manager1.datosconfig.distancia == 500 || manager1.datosconfig.distancia == 1000 || manager1.datosconfig.distancia == 2000 || manager1.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager1.datosconfig.distancia;
            }
        }
        if(manager2 != null)
        {
            if(manager2.datosconfig.distancia == 200 || manager2.datosconfig.distancia == 500 || manager2.datosconfig.distancia == 1000 || manager2.datosconfig.distancia == 2000 || manager2.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager2.datosconfig.distancia;
            }
        }
        if(manager3 != null)
        {
            if(manager3.datosconfig.distancia == 200 || manager3.datosconfig.distancia == 500 || manager3.datosconfig.distancia == 1000 || manager3.datosconfig.distancia == 2000 || manager3.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager3.datosconfig.distancia;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        managerBASE manager0 = UnityEngine.Object.FindObjectOfType<managerBASE>();
        if(manager0 != null)
        {
            if(manager0.datosconfig.distancia == 200 || manager0.datosconfig.distancia == 500 || manager0.datosconfig.distancia == 1000 || manager0.datosconfig.distancia == 2000 || manager0.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager0.datosconfig.distancia;
            }
        }
    }
}
