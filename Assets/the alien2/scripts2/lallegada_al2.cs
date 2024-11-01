using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class lallegada_al2 : MonoBehaviour
{
	public manager_al2 manager;
    public float temp;
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
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        manager.datosserial.inicio = 1;
        manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
        temp += 1 * Time.deltaTime;
        if(temp >= 25f || controles.menu.saltar.ReadValue<float>() > 0)
        {SceneManager.LoadScene("mundo_abierto_al2");}
    }
}
