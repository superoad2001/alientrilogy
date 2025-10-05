using UnityEngine;

public class armadef2_al2 : MonoBehaviour
{
    public GameObject prefabbala;
    public GameObject explosion;
    private bool act;
    public bool armadef;
    public int cont = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionStay(Collision col)
    {
        if(armadef)
        {
                GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
                explosiont.GetComponent<baladef_exp_al2>().danoj = this.gameObject.GetComponent<romperbalajug_al2>().danoj;
                explosiont.GetComponent<baladef_exp_al2>().danoesc = this.gameObject.GetComponent<romperbalajug_al2>().danoesc;

                if(cont > 0)
                {
                GameObject bala1t = Instantiate(prefabbala, transform.position + Vector3.up * 1f + Vector3.right * 2,Quaternion.Euler(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360))) as GameObject;
                GameObject bala2t = Instantiate(prefabbala, transform.position + Vector3.up * 1f + Vector3.left * 2,Quaternion.Euler(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360))) as GameObject;
                bala1t.GetComponent<romperbalajug_al2>().danoj = this.gameObject.GetComponent<romperbalajug_al2>().danoj;
                bala2t.GetComponent<romperbalajug_al2>().danoj = this.gameObject.GetComponent<romperbalajug_al2>().danoj;
                bala1t.GetComponent<romperbalajug_al2>().danoesc = this.gameObject.GetComponent<romperbalajug_al2>().danoesc;
                bala2t.GetComponent<romperbalajug_al2>().danoesc = this.gameObject.GetComponent<romperbalajug_al2>().danoesc;
                bala1t.GetComponent<Rigidbody>().AddForce(transform.right * 2 + Vector3.up * 10, ForceMode.Impulse);
                bala2t.GetComponent<Rigidbody>().AddForce(transform.right * -2 + Vector3.up * 10, ForceMode.Impulse);
                bala1t.GetComponent<armadef2_al2>().cont = cont-1;
                bala2t.GetComponent<armadef2_al2>().cont = cont-1;
                }


                Destroy(explosiont, 0.7f);
                Destroy(this.gameObject);
                act = true;
                
        }
    }
}
