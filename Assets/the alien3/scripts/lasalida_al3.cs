using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class lasalida_al3: MonoBehaviour
{
	public manager_al3 manager;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        temp += 1 * Time.deltaTime;
        if(temp >= 8f)
        {SceneManager.LoadScene("lallegada_al3");}
    }
}
