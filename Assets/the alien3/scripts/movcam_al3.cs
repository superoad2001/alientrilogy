using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movcam_al3: MonoBehaviour
{
	public manager_al3 manager;
    public float rotspeed = 3;
    public Vector3 rotationinput;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position,player.transform.position,30 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "pared")
		{

		}
    }
}
