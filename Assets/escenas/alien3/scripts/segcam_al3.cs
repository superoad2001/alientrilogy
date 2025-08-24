using UnityEngine;

public class segcam_al3 : MonoBehaviour
{

    public GameObject objetivo;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(objetivo.transform);
        transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,10000 * Time.deltaTime);
    }
}
