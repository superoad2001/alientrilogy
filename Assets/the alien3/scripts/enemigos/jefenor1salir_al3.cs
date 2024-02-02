using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jefenor1salir_al3: MonoBehaviour
{

    public enemigo1_al3 enemigo1;
    public enemigo1_al3 enemigo2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigo1.jefe1_act1 == true && enemigo2.jefe1_act2 == true)
        {
            SceneManager.LoadScene("escena3_al3");
        }
    }
}
