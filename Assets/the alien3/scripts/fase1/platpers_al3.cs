using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platpers_al3: MonoBehaviour
{
	public manager_al3 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float vel;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * vel * Time.deltaTime;

    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "forward")
		{
            Destroy(this.gameObject);
        }
    }
}
