using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introcarga_al1 : MonoBehaviour
{
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

    public float temp = 0;
    public manager_al1 manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
    }
    public void act()
    {
        temp = 300;
    }
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if(GetComponent<AudioSource>().isPlaying == false || controles.menu.saltar.ReadValue<float>() > 0)
        {
            manager.datosconfig.carga = "menu_de_carga_al1";
            manager.guardarconfig();
            manager.guardar();
			SceneManager.LoadScene("carga");
        }
    }
}
