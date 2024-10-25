using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tinicio_al3: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tactil;
    public int Ac = 0;
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
    void Start()
    {
        
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if(manager.datosconfig.plat == 1)
        {
            tactil.SetActive(false);

        }
        if(manager.datosconfig.plat == 2)
        {
            tactil.SetActive(true);

        }
    }
    public void A()
	{
		Ac = 1;
	}

    // Update is called once per frame
    void Update()
    {
        if (controles.al3.a.ReadValue<float>() > 0 || Ac == 1 )
        {
            SceneManager.LoadScene("mundo_abierto_al3");

        }
    }
}
