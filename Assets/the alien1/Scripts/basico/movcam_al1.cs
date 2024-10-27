using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcam_al1 : MonoBehaviour
{
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
       transform.position = Vector3.MoveTowards(transform.position,player.transform.position,2f * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "pared")
		{

		}
    }
}
