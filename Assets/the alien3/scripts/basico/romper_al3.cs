using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class romper_al3: MonoBehaviour
{
    public AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();

        if (col.gameObject.tag == "golpeh")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma1")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma6")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}   
        if (col.gameObject.tag == "danoarma7")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma8")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma9")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma10")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
    private void OnCollisionEnter(Collision col)
	{
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if (col.gameObject.tag == "golpeh")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma1")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma6")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}   
        if (col.gameObject.tag == "danoarma7")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma8")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma9")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
        if (col.gameObject.tag == "danoarma10")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
