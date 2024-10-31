using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma10_al3: MonoBehaviour
{
	public manager_al3 manager;
    public GameObject objet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(objet != null)
        {transform.position = Vector3.MoveTowards(transform.position,objet.transform.position,80 * Time.deltaTime);}
    }
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "enemigo")
		{
			objet = col.gameObject;
		}
    }
}
