using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transferir_al3 : MonoBehaviour
{
    public int ver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rec()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        manager_al2 manager2 = UnityEngine.Object.FindObjectOfType<manager_al2>();
        manager.datosserial.monedas += manager2.datosserial.monedas;
        manager.datosserial.herencia = 1;
        manager.guardar();
        if(ver == 1)
        {SceneManager.LoadScene("espacio_al3");}
        if(ver == 2)
        {SceneManager.LoadScene("mundo15_al3");}
    }

    public void dej()
    {
        if(ver == 1)
        {SceneManager.LoadScene("espacio_al3");}
        if(ver == 2)
        {SceneManager.LoadScene("mundo15_al3");}
    }
}