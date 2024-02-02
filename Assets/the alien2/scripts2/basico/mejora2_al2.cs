using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class mejora2_al2 : MonoBehaviour
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
		if (col.gameObject.tag == "Player" && manager.datosserial.mejoravida2 == 0)
		{
			manager.datosserial.vidamaxima++;
            manager.datosserial.mejoravida2 = 1;
            manager.guardar();
			audio1.Play();
            UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
