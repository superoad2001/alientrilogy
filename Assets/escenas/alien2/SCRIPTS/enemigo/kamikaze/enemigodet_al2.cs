using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigodet_al2: MonoBehaviour
{
	public manager_al2 manager;
      public AudioSource visto;
      public bool nosonar;
      public jugador_al2 jugador;
    // Start is called before the first frame update
    void Start()
    {
      jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
    }
    public enemigo1_al2 enemigo;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
                  jugador.peligro = true;
                  enemigo.detectar = true;
                  enemigo.fuera = true;
                  enemigo.detect = false;
                  enemigo.objetivo = col.gameObject;
                  enemigo.objetivo1 = col.gameObject.transform;
                  if(enemigo.GetComponent<Rigidbody>() == null)
                  {
                  enemigo.gameObject.AddComponent<Rigidbody>();
                  enemigo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                  enemigo.rb_ = enemigo.GetComponent<Rigidbody>();
                  }
                  if(nosonar == false)
                  {visto.Play();}
		}

	}
      
    public void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
            jugador.peligro = true;
            enemigo.detectar = true;
            enemigo.fuera = true;
            enemigo.objetivo = col.gameObject;
            enemigo.objetivo1 = col.gameObject.transform;
            enemigo.objetivob = col.gameObject;
            enemigo.objetivo1b = col.gameObject.transform;
		}
            
           

	}
      private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player" && enemigo.voladoract == false)
		{
                  enemigo.detectar = false;
                  enemigo.fuera = false;
                  enemigo.detect = false;
		}
            
            


	}
}
