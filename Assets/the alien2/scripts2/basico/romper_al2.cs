using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class romper_al2 : MonoBehaviour
{
    public AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "bala")
		{
            audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
			
		}
	}
}
