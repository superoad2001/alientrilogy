using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plat_al1 : MonoBehaviour
{
    public int plataforma;
    // Start is called before the first frame update
    void Start()
    {
        manager_al1 manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        manager.datosconfig.plat = plataforma;
        manager.guardar();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
