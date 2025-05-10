using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class romperbalajug_al1: MonoBehaviour
{
	
	public float danoj = 1;

	public AudioSource dest;
	public GameObject desto;

	public GameObject explosion;

    public float destb;
    public bool armadef;
    public bool destenter;

    public GameObject balajug;
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
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "enemigo" && destenter == true && col.gameObject.GetComponent<romperbala_al1>() == null)
        {           
        	Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "enemigo" && destenter == true && col.gameObject.GetComponent<romperbala_al1>() != null)
        {
            Destroy(col.gameObject);
        	Destroy(this.gameObject);
        }
    }
    public void OnDestroy()
    {
        if(armadef == false)
        {
        GameObject exp = Instantiate(explosion, transform.position, transform.rotation);
        exp.transform.localScale = transform.localScale;
        Destroy(exp, 0.5f);
        }
    }
    

}
