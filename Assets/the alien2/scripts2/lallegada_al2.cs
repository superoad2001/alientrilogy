using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class lallegada_al2 : MonoBehaviour
{
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        manager.datosserial.inicio = 1;
        manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
        temp += 1 * Time.deltaTime;
        if(temp >= 25f)
        {SceneManager.LoadScene("mundo_abierto_al2");}
    }
}
