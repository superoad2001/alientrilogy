using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lallegada_nave_al1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.transform.Translate(-Vector3.forward * 10f * Time.deltaTime);
    }
}
