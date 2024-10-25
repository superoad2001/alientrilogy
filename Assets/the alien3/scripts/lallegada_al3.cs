using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class lallegada_al3: MonoBehaviour
{
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        manager.datosserial.inicio = 1;
        manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
        temp += 1 * Time.deltaTime;
        if(temp >= 25f)
        {SceneManager.LoadScene("inicio_al3");}
    }
}
