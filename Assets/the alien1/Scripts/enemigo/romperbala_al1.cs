using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class romperbala_al1: MonoBehaviour
{
	public bool empujar;
	public float danoj = 1;
    public bool salir;

	public AudioSource dest;
	public GameObject desto;

	public GameObject explosion;
    public bool balaene;
    public jugador_al1 jugador1;
    public bool destenter;

    public float destb;
    public bool armadef;
    public float porcentaje;
    public bool danofijo;
    public bool tele;
    public GameObject objtele;
    public float tempdest;
    // Start is called before the first frame update
    void Start()
    {
        jugador1 = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        desto = GameObject.Find("rompersonido");
        dest = desto.GetComponent<AudioSource>();
        Destroy(this.gameObject, destb);
    }

    // Update is called once per frame
    void Update()
    {

        if(objtele != null)
        {
            tempdest += 1 * Time.deltaTime;
            if (tempdest >= 12)
            {
                Destroy(this.gameObject);
            }
        }
        if(tele == true && objtele != null)
        {
            transform.position = Vector3.MoveTowards(transform.position,objtele.transform.position,25 * Time.deltaTime);

        }
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,transform.forward.y,transform.rotation.eulerAngles.z),5000f * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider col)
    {
    	if(col.gameObject.tag == "golpeh")
        {
            Destroy(this.gameObject);
        }
        if(tele == false)
        {
            if (col.gameObject.tag == "Player" && destenter == true && col.gameObject.GetComponent<romperbala_al1>() == null && balaene)
            {           
                Destroy(this.gameObject);
            }
            else if (col.gameObject.tag == "Player" && destenter == true && col.gameObject.GetComponent<romperbala_al1>() != null && balaene)
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
            }
            else if (col.gameObject.tag == "Player" && balaene)
            {
            
                if(col.gameObject.GetComponent<jugador_al1>() != null)
                {
                    jugador1.muertesjug.Play();
                    if(empujar)
                    {
                    jugador1.enmovdirectaux = transform.TransformDirection((transform.forward *70) + (transform.up * -50));
                    jugador1.enmovdirectaux = jugador1.enmovdirectaux.normalized;
                    jugador1.tempempujon = 0;
                    jugador1.empujon = true;
                    }
                    
                    jugador1.vida -= danoj;
                    GameObject explosiont = Instantiate(explosion,transform.position,transform.rotation) as GameObject;
                    Destroy(explosiont, 1f);
                    dest.Play();
                    Destroy(this.gameObject);
                }

                
            }
        }
        else if (tele == true && objtele == null && balaene)
        {
            if (col.gameObject.tag == "Player" && col.gameObject.GetComponent<romperbala_al1>() == null)
            {           
                objtele = col.gameObject;
            }
            
        }
    }
    public void OnCollisionEnter(Collision col)
    {
        if (tele == true )
        {
      
            if (col.gameObject.tag == "Player" && destenter == true && col.gameObject.GetComponent<romperbala_al1>() == null)
            {           
                Destroy(this.gameObject);
            }
            else if (col.gameObject.tag == "Player" && destenter == true && col.gameObject.GetComponent<romperbala_al1>() != null)
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
            }
            
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
