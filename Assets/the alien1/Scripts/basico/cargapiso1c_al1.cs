using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cargapiso1c_al1 : MonoBehaviour
{
	public manager_al1 manager;
    // Start is called before the first frame update
    void Start()
    {
        manager.datosconfig.carga = "piso1_al1";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");
    }

    // Update is called once per frame
    void Update()
    {
        manager.datosconfig.carga = "piso1_al1";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");
    }
}
