using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class presentacionbase : MonoBehaviour
{

    public float temp = 0;
    public Text pres;
    public Text pres2;
    public managerBASE manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
    }
    public void act()
    {
        temp = 300;
    }

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
        
        
        if(manager.datosconfig.idioma == "es")
        {
            pres.text = "presenta";
            pres2.text = "saltar";
        }
        if(manager.datosconfig.idioma == "en")
        {
            pres.text = "presents";
            pres2.text = "skip";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            pres.text = "presenta";
            pres2.text = "salta";
        }
        temp += 1 * Time.deltaTime;
        if(temp >= 14)
        {
            manager.datosconfig.carga = "menutrilogy";
            manager.guardar();
            SceneManager.LoadScene("carga");
        }
    }
}
