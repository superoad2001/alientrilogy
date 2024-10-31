using UnityEngine;

public class aguach_al2 : MonoBehaviour
{
    public GameObject azul;
    public bool retorno = true;
    public int sel = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "Player")
		{
            if (retorno == true)
            {
                azul.SetActive(true);
            }
            if (retorno == false)
            {
                azul.SetActive(false);
            }
        }
    }
}
