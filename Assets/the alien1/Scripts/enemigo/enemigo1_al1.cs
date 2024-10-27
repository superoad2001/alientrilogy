using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1_al1: MonoBehaviour
{
    public bool detectar;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public enemigodet_al1 enemigodet;
    public GameObject dano;
    public GameObject det;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        det.transform.position = this.transform.position;
        dano.transform.position = this.transform.position;
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        
        if(detectar == true && desactivar == false)
        {
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
        }
        
        
    }
    private void OnTriggerEnter(Collider col)
	{


	}
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "respawn")
		{
			Destroy(transform.parent.gameObject);
		}
        
    }
}
