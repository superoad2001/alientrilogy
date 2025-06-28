using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class platform_al1 : MonoBehaviour
{
    private Vector3 pos;
    public Vector3 posini;
    public Vector3 posdest;
    private Vector3 posP;
    public float speed;
    public bool InvDir;
    public float speedP;
    public float speedx;
    public float speedy;
    public float speedz;
    public bool x;
    public bool y;
    public bool z;
    public void OnTriggerStay(Collider col)
	{
        
        col.transform.position = new Vector3(col.transform.position.x + speedx * Time.deltaTime ,col.transform.position.y + speedy * Time.deltaTime,col.transform.position.z + speedz * Time.deltaTime);
        
        

    }
    public void Start()
    {
        pos = transform.position;
        posini = transform.position;
        InvDir = false;
        speedP = speed;
    }
    public void Update()
    {   
        if(InvDir)
        {
            posP = posini;
        }
        else
        {
            posP = posdest;
        }
        transform.position = Vector3.MoveTowards(transform.position, posP, speed * Time.deltaTime);
        if(transform.position == posP)
        {
            InvDir = !InvDir;
            speedP = -1 * speedP;
            if(x == true)
            {speedx = speedP;}
            if(y == true)
            {speedy = speedP;}
            if(z == true)
            {speedz = speedP;}

        }
        
        
    }
}

