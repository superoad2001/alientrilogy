using UnityEngine;

public class platform_al1 : MonoBehaviour
{
    private Vector3 pos;
    public void Start()
    {
        pos = transform.position;
    }
    
    public void OnTriggerStay(Collider col)
	{
        col.transform.position -=  (pos - transform.position);
		pos = transform.position;
    }
}

