using System;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000010 RID: 16
public class subircin1_al1 : MonoBehaviour
{
	public bool botonm = false;
	public GameObject tactil;
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
	// Token: 0x06000038 RID: 56 RVA: 0x00003A94 File Offset: 0x00001C94
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if(manager.datosconfig.plat == 1)
		{
			tactil.SetActive(false);
		}
		if(manager.datosconfig.plat == 2)
		{
			tactil.SetActive(true);
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A96 File Offset: 0x00001C96
	private void Update()
	{
		if (controles.al1_UI.interactuar.ReadValue<float>() > 0f)
		{
			manager.datosserial.begin = true;
			manager.guardar();
			manager.datosconfig.carga = "piso1_al1";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
}
