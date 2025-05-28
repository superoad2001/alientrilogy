using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigodet3_al1: MonoBehaviour
{
	public manager_al1 manager;
      public AudioSource visto1;
      public AudioSource visto1es;
      public AudioSource visto1en;
      public AudioSource visto1cat;

      public AudioSource visto2;
      public AudioSource visto2es;
      public AudioSource visto2en;
      public AudioSource visto2cat;

      public AudioSource visto3;
      public AudioSource visto3es;
      public AudioSource visto3en;
      public AudioSource visto3cat;
      public bool suelo;
      public float temp;
    // Start is called before the first frame update
    void Start()
    {
      manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(manager.datosconfig.idioma == "es")
        {
            visto1 = visto1es;
            visto2 = visto2es;
            visto3 = visto3es;
        }
        if(manager.datosconfig.idioma == "en")
        {
            visto1 = visto1en;
            visto2 = visto2en;
            visto3 = visto3en;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            visto1 = visto1cat;
            visto2 = visto2cat;
            visto3 = visto3cat;
        }
    }
    public enemigo3_al1 enemigo;
    // Update is called once per frame
    void Update()
    {
        if(temp < 15)
        {
            temp += 1 * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
            int dec = Random.Range(1,4);
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
            enemigo.gameObject.AddComponent<Rigidbody>();
            enemigo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                  if(temp > 8)
                  {
                        if(dec == 1)
                        {
                              visto1.Play();
                        }
                        else if(dec == 2)
                        {
                              visto2.Play();
                        }
                        else if(dec == 3)
                        {
                              visto3.Play();
                        }
                  }


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
		if (col.gameObject.tag == "Player")
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
