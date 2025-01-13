using UnityEngine;

public class balarel : MonoBehaviour
{


    public float temp;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = base.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (temp < 2)
        {
            transform.localScale += new Vector3(25 * Time.deltaTime,25 * Time.deltaTime,25 * Time.deltaTime);
        }
        if(temp > 2)
        {
            rb.linearVelocity = new Vector3 (0,0,0);
        }
        temp += 1 * Time.deltaTime;
    }
}
