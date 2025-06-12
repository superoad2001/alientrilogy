using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigodet2_al1: MonoBehaviour
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
      public float temp;
      public bool suelo;
      public jugador_al1 jugador;
    // Start is called before the first frame update
    void Start()
    {
      jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
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
    public enemigo2_al1 enemigo;
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
            jugador.peligro = true;
            int dec = Random.Range(1,4);
            enemigo.detectar = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
            if(enemigo.GetComponent<Rigidbody>() == null)
            {
            enemigo.gameObject.AddComponent<Rigidbody>();
            enemigo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            enemigo.rb_ = enemigo.GetComponent<Rigidbody>();
            }
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
            jugador.peligro = true;
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
            
		}
            


	}
}
