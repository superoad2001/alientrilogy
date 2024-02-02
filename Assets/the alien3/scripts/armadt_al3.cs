using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadt_al3: MonoBehaviour
{
    public int armad;
    public int tengo;
    public AudioSource audio0;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        
        tengo = manager.datosserial.tarmad[armad];
        if(tengo == 1)
        {Destroy(this.gameObject);}
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider col)
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        manager.datosserial.armadura = armad;
        manager.datosserial.tarmad[armad] = 1;
        
        manager.guardar();
        audio0.Play();
        Destroy(this.gameObject);

    }
}
