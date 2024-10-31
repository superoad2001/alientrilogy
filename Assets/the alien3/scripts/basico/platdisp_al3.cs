using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platdisp_al3: MonoBehaviour
{
	public manager_al3 manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.3f * Time.deltaTime,0 * Time.deltaTime,0.3f * Time.deltaTime);
    }
}
