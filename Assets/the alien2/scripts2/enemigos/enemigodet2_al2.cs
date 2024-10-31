using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigodet2_al2: MonoBehaviour
{
	public manager_al2 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public enemigo2_al2 enemigo;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
            enemigo.gameObject.AddComponent<Rigidbody>();
            enemigo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
		}

	}
    public void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player")
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

                  enemigo.detectar = false;
                  Destroy (enemigo.GetComponent<Rigidbody>());
                  Destroy (this.GetComponent<Rigidbody>());
            
		}

	}
}
