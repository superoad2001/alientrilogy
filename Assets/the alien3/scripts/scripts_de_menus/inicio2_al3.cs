using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio2_al3: MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botont = false;
	public bool botonr = false;
	public void Start()
	{
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (this.botonn == true && temp >= 1)
		{
        	manager.datosconfig.plat = 1;
			manager.guardar();
			SceneManager.LoadScene("carga_al3");
		}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosconfig.plat = 2;
			manager.guardar();
			SceneManager.LoadScene("carga_al3");
		}
		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.idioma = "es";
			manager.guardar();
			SceneManager.LoadScene("carga_al3");
		}
		if (this.botont == true && temp >= 1)
		{
			manager.datosconfig.idioma = "en";
			manager.guardar();
			SceneManager.LoadScene("carga_al3");
		}
		if (this.botonr == true && temp >= 1)
		{
			manager.datosconfig.idioma = "cat";
			manager.guardar();
			SceneManager.LoadScene("carga_al3");
		}
	

	}
	public void boton_n()
    {
        botonn = true;
    }
	public void boton_m()
    {
        botonm = true;
    }
	public void boton_c()
    {
        botonc = true;
    }
	public void boton_t()
    {
        botont = true;
    }
	public void boton_r()
    {
        botonr = true;
    }



}
