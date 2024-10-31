using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class nv11mov_al3: MonoBehaviour
{
	public manager_al3 manager;
    public GameObject lava;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			lava.transform.Translate (1  * Time.deltaTime * Vector3.back* 12);
		}
	}
}
