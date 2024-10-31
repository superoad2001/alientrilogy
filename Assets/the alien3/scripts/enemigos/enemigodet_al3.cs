using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigodet_al3: MonoBehaviour
{
	public manager_al3 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public enemigo1_al3 enemigo;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "senuelo")
		{
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
		}
		else if (col.gameObject.tag == "Player")
		{
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
            if(enemigo.jefe == 0 && enemigo.plat == false)
            {
                  enemigo.gameObject.AddComponent<Rigidbody>();
                  enemigo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            }
            if(enemigo.jefe == 0 && enemigo.plat == true)
            {
                  enemigo.gameObject.AddComponent<Rigidbody>();
                  enemigo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                  enemigo.GetComponent<Rigidbody>().useGravity = false;
            }
		}

	}
    public void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag == "senuelo")
		{
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
		}
		else if (col.gameObject.tag == "Player")
		{
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
            enemigo.objetivob = col.gameObject;
            enemigo.objetivo1b = col.gameObject.transform;
		}

	}
      private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
                  if(enemigo.jefe == 0)
                  {
                        enemigo.detectar = false;
                        Destroy (enemigo.GetComponent<Rigidbody>());
                        Destroy (this.GetComponent<Rigidbody>());
                  }
		}
            if (col.gameObject.tag == "senuelo")
		{
                  if(enemigo.jefe == 0)
                  {
                        enemigo.detectar = false;
                  }
		}

	}
}
