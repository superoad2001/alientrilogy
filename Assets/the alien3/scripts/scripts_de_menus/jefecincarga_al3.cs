using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jefecincarga_al3: MonoBehaviour
{
	public manager_al3 manager;

    public float temp = 0;
    public float max = 94;

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
        
    }
    public void act()
    {
        temp = 300;
    }
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if(temp >= max || controles.menu.saltar.ReadValue<float>() > 0)
        {
            SceneManager.LoadScene("jefe6_al3");
        }
    }
}
