using UnityEngine;

public class golpe_al2 : MonoBehaviour
{
    public float dano;
    public AudioSource dest;
    public int toquespalo;
    public bool paloene;
    public bool minmun;
    public bool ultimo;
    public bool paloact;
    public GameObject guia;
    public bool levantar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            Destroy(this.gameObject);
        }
    }
}
