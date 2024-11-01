using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class lasalida_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
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
        
        temp += 1 * Time.deltaTime;
        if(temp >= 8f || controles.menu.saltar.ReadValue<float>() > 0)
        {SceneManager.LoadScene("lallegada_al2");}
    }
}
