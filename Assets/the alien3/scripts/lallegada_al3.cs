using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class lallegada_al3: MonoBehaviour
{
	public manager_al3 manager;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
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
