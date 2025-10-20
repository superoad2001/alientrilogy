using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class romperbalajug_al1: MonoBehaviour
{
	public int idarma;
	public float danoj = 1;

	public AudioSource dest;
	public GameObject desto;

	public GameObject explosion;

    public float destb;
    public bool armadef;
    public bool destenter;
    public bool tele;
    public GameObject objtele;
    public float danoesc;
    public bool noact;

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
        if(tele == true && objtele != null && noact == false)
        {
            transform.position = Vector3.MoveTowards(transform.position,objtele.transform.position,25 * Time.deltaTime);

        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if(tele == false  && noact == false)
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
        else if (tele == true && objtele == null  && noact == false)
        {
            if (col.gameObject.tag == "enemigo" && col.gameObject.GetComponent<romperbala_al1>() == null)
            {           
                objtele = col.gameObject;
            }
            
        }
    }
    public void OnCollisionEnter(Collision col)
    {
        if (tele == true  && noact == false)
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
    }
    public void OnDestroy()
    {
        if(armadef == false && noact == false)
        {
        GameObject exp = Instantiate(explosion, transform.position, transform.rotation);
        exp.transform.localScale = transform.localScale;
        Destroy(exp, 0.5f);
        }
    }
    

}
