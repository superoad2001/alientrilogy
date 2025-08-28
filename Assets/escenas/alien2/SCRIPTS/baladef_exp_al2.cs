using UnityEngine;

public class baladef_exp_al2 : MonoBehaviour
{

    public float explosion = 13;
    public float danoj = 1;
    public float danoesc;
    public bool paloact;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "golpeh")
        {
            paloact = false;
        }
    }
    public void OnTriggerEnter(Collider col)
    {
    	if(col.gameObject.tag == "golpeh")
        {
            paloact = true;
        }
    }
}
