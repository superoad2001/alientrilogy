using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class romperbala_al1: MonoBehaviour
{
	
	public float danoj = 1;

	public AudioSource dest;
	public GameObject desto;

	public GameObject explosion;

    public float destb;
    // Start is called before the first frame update
    void Start()
    {
        desto = GameObject.Find("rompersonido");
        dest = desto.GetComponent<AudioSource>();
        Destroy(this.gameObject, destb);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
