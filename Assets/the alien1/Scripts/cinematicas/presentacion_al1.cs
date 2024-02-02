using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class presentacion_al1 : MonoBehaviour
{

    public float temp = 0;
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
        if(temp >= 7)
        {
            SceneManager.LoadScene("intro_al1");
        }
    }
}
