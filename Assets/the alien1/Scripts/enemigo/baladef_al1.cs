using UnityEngine;

public class baladef_al1 : MonoBehaviour
{


    public float temp;
    public Rigidbody rb;


	public AudioSource dest;
	public GameObject desto;

	public GameObject explosion;

    public float destb;
    public bool armadef;
    public bool armadefene;
    private bool act;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = base.GetComponent<Rigidbody>();
    }
    public float escala = 45;

    // Update is called once per frame
    void Update()
    {
        if (temp < 2)
        {
            transform.localScale += new Vector3(escala * Time.deltaTime,escala * Time.deltaTime,escala * Time.deltaTime);
        }
        if(temp > 2)
        {
            armadef = true;
        }
        temp += 1 * Time.deltaTime;
    }
        public void OnCollisionStay(Collision col)
        {
            if (armadef && armadefene )
            {
                    GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
                    explosiont.GetComponent<baladef_exp_al1>().danoj = this.gameObject.GetComponent<romperbala_al1>().danoj;
                    explosiont.transform.localScale = transform.localScale;
                    
                    Destroy(explosiont, 6f);
                    Destroy(this.gameObject);
                    act = true;
                    
            }
            else if(armadef && armadefene == false )
            {
                    GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
                    explosiont.GetComponent<baladef_exp_al1>().danoj = this.gameObject.GetComponent<romperbalajug_al1>().danoj;
                    explosiont.GetComponent<baladef_exp_al1>().danoesc = this.gameObject.GetComponent<romperbalajug_al1>().danoesc;
                    explosiont.transform.localScale = transform.localScale;
                    Destroy(explosiont, 13f);
                    Destroy(this.gameObject);
                    act = true;
                    
            }
        }
}
