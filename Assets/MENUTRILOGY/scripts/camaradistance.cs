using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class camaradistance : MonoBehaviour
{
    public Camera cam;
    public bool distancia;
    
    // Start is called before the first frame update
    void Start()
    {
        managerBASE manager0 = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
        manager_al1 manager1 = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        manager_al2 manager2 = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        manager_al3 manager3 = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        
        

        cam = this.gameObject.GetComponent<Camera>();
        
        if(manager0 != null)
        {
            QualitySettings.renderPipeline = manager0.datosconfig.calidad;
            if(distancia != true)
            {
                if(manager0.datosconfig.distancia == 200 || manager0.datosconfig.distancia == 500 || manager0.datosconfig.distancia == 1000 || manager0.datosconfig.distancia == 2000 || manager0.datosconfig.distancia == 3000)
                {
                cam.farClipPlane = manager0.datosconfig.distancia;
                }
            }
            if(manager0.datosconfig.resoluciones == 1)
            {
                
            }
        }
        if(manager1 != null)
        {
            QualitySettings.renderPipeline = manager1.datosconfig.calidad;
            if(distancia != true)
            {
            if(manager1.datosconfig.distancia == 200 || manager1.datosconfig.distancia == 500 || manager1.datosconfig.distancia == 1000 || manager1.datosconfig.distancia == 2000 || manager1.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager1.datosconfig.distancia;
            }
            }
        }
        if(manager2 != null)
        {
            QualitySettings.renderPipeline = manager2.datosconfig.calidad;
            if(distancia != true)
            {
            if(manager2.datosconfig.distancia == 200 || manager2.datosconfig.distancia == 500 || manager2.datosconfig.distancia == 1000 || manager2.datosconfig.distancia == 2000 || manager2.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager2.datosconfig.distancia;
            }
            }
        }
        if(manager3 != null)
        {
            QualitySettings.renderPipeline = manager3.datosconfig.calidad;
            if(distancia != true)
            {
            if(manager3.datosconfig.distancia == 200 || manager3.datosconfig.distancia == 500 || manager3.datosconfig.distancia == 1000 || manager3.datosconfig.distancia == 2000 || manager3.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager3.datosconfig.distancia;
            }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        managerBASE manager0 = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
        if(manager0 != null)
        {
            if(manager0.datosconfig.distancia == 200 || manager0.datosconfig.distancia == 500 || manager0.datosconfig.distancia == 1000 || manager0.datosconfig.distancia == 2000 || manager0.datosconfig.distancia == 3000)
            {
            cam.farClipPlane = manager0.datosconfig.distancia;
            }
        }
    }
}
