using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pocionmas_al3: MonoBehaviour
{
	public manager_al3 manager;
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
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.pociones++;
			manager.guardar();
			audio1.Play();
            UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
