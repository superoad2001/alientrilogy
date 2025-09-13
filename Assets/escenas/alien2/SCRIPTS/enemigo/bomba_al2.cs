using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba_al2: MonoBehaviour
{
	public manager_al2 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(15 * Time.deltaTime,15 * Time.deltaTime,15 * Time.deltaTime);
    }
}
