using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mejora3_al2 : MonoBehaviour
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
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player" && manager.datosserial.mejoravida3 == 0)
		{
			manager.datosserial.vidamaxima++;
            manager.datosserial.mejoravida3 = 1;
			manager.guardar();
			audio1.Play();
            UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
