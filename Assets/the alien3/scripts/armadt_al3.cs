using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadt_al3: MonoBehaviour
{
	public manager_al3 manager;
    public int armad;
    public int tengo;
    public AudioSource audio0;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        
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
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        manager.datosserial.armadura = armad;
        manager.datosserial.tarmad[armad] = 1;
        manager.datosserial.armadurastotal++;
        if(manager.datosserial.armadurass1 == 0)
        {
            manager.datosserial.armadurass1 = manager.datosserial.armadura;
        }
        else if(manager.datosserial.armadurass2 == 0)
        {
            manager.datosserial.armadurass2 = manager.datosserial.armadura;
        }
        
        manager.guardar();
        audio0.Play();
        Destroy(this.gameObject);

    }
}
