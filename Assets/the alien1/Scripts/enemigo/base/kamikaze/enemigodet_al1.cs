using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigodet_al1: MonoBehaviour
{
	public manager_al1 manager;
      public AudioSource visto;
      public bool nosonar;
      public bool suelo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public enemigo1_al1 enemigo;
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
            enemigo.rb_ = enemigo.GetComponent<Rigidbody>();
            if(nosonar == false)
            {visto.Play();}
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
            if (col.gameObject.tag != "Player" && suelo == true)
		{
                  enemigo.detectar = false;
                  Destroy (enemigo.GetComponent<Rigidbody>());
                  Destroy (this.GetComponent<Rigidbody>());
		}
            if (col.gameObject.tag == "Player")
		{
             suelo = true;
		}

	}
      private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player" && suelo == true)
		{
                  enemigo.detectar = false;
                  Destroy (enemigo.GetComponent<Rigidbody>());
                  Destroy (this.GetComponent<Rigidbody>());
		}
            if (col.gameObject.tag == "suelo")
		{
                  suelo = false;
		}


	}
}
