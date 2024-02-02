using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class presentacion_al1 : MonoBehaviour
{

    public float temp = 0;
    public Text pres;
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
        manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        if(manager.datosconfig.idioma == "es")
        {
            pres.text = "presenta";
        }
        if(manager.datosconfig.idioma == "en")
        {
            pres.text = "presents";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            pres.text = "presenta";
        }
        temp += 1 * Time.deltaTime;
        if(temp >= 7)
        {
            SceneManager.LoadScene("intro_al1");
        }
    }
}
