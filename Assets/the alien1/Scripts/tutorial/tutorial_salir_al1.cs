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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        if(evento != null)
        {
            if (controles.al1_3d.interactuar.ReadValue<float>() > 0f)
			{
                SceneManager.LoadScene(escena);
            }
        }
    }
}
