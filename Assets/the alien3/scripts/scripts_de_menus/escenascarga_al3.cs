using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escenascarga_al3: MonoBehaviour
{
	public manager_al3 manager;

    public float temp = 0;
    public float max = 94;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void act()
    {
        temp = 300;
    }
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if(temp >= max)
        {
            SceneManager.LoadScene("mundo_abierto_al3");
        }
    }
}
