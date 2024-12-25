using UnityEngine;

public class bala_tele_al1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject objetivo;
    public float vel;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,new Vector3(objetivo.transform.position.x,objetivo.transform.position.y,objetivo.transform.position.z),vel * Time.deltaTime);
    }
}
