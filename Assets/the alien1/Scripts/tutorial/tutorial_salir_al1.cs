using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class tutorial_salir : MonoBehaviour
{
    public GameObject evento;
    public Controles controles;
    public string escena;
    public manager_al1 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
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
        if(evento == null)
        {
            
            if (controles.al1_UI.interactuar.ReadValue<float>() > 0f )
			{
                manager.datosconfig.carga = escena;
                manager.guardarconfig();
                SceneManager.LoadScene("carga");
            }
        }
    }
}
