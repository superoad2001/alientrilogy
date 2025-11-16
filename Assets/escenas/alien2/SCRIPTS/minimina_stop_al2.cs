using UnityEngine;

public class minimina_stop_al2 : MonoBehaviour
{
    public float temp;
    public float tempstop = 1.5f;
    public Rigidbody rbb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(temp >= tempstop)
        {
            rbb.linearVelocity = Vector3.zero;
        }
        else
        {
            temp += Time.deltaTime;
        }
    }
}
