using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class romperbala_al1: MonoBehaviour
{
	public bool empujar;
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
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,transform.forward.y,transform.rotation.eulerAngles.z),5000f * Time.deltaTime);
    }
}
