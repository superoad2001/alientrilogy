using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class plat_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public int plat;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        manager.datosconfig.plat = plat;
        manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
