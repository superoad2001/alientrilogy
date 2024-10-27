using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class presentacion_al3: MonoBehaviour
{

    public float temp = 0;
    public Text pres;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        manager.datosserial.com = 0;
        manager.guardar();
        
    }
    public void act()
    {
        temp = 300;
    }
    // Update is called once per frame
    private Controles controles;
    public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if(controles.al3.pausa.ReadValue<float>() > 0)
        {
            temp = 300;
        }
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));

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
        if(temp >= 9)
        {
            SceneManager.LoadScene("intro_al3");
        }
    }
}
