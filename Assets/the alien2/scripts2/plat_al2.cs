using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class plat_al2 : MonoBehaviour
{
    public int plat;
    // Start is called before the first frame update
    void Start()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        manager.datosconfig.plat = plat;
        manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
