using UnityEngine;

public class gravitybody_al1 : MonoBehaviour
{
    public planetgrav_al1 atractor;
    public Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }
    public GameObject camara1;
    // Update is called once per frame
    void Update()
    {
        if(atractor != null)
        {
            atractor.Attract(transform);
        }
        else
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation,Quaternion.Euler(0,transform.eulerAngles.y,0),2.5f* Time.deltaTime);
        }
        
    }
    public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "planetagrav")
		{
            _rb.useGravity = false;
            atractor = col.GetComponent<planetgrav_al1>();
            //camara1.transform.localRotation  = Quaternion.Euler(0,0,0);

        }
    }
    public void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "planetagrav")
		{
            _rb.useGravity = true;
            atractor = null;
        }
    }
}
