using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recordback_al2 : MonoBehaviour
{
    // Start is called before the first frame updat
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

        
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();

    }
    public void A()
	{
		Ac = 1;
	}
    // Update is called once per frame
    void Update()
    {
        if (controles.al2.b.ReadValue<float>() > 0f || Ac == 1)
        {
            SceneManager.LoadScene("torre_del_tiempo_al2");

        }
    }
}
