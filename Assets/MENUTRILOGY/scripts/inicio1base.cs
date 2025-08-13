using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000009 RID: 9
public class inicio1base : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public float temp;
	public string idioma;
	public managerBASE manager;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
		idioma = manager.datosconfig.idioma;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosconfig.idioma = "es";
			manager.datosconfig.carga = "controlesbase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.datosconfig.idioma = "en";
			manager.datosconfig.carga = "controlesbase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.idioma = "cat";
			manager.datosconfig.carga = "controlesbase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if (manager.datosconfig.idioma == "es" || manager.datosconfig.idioma == "en" || manager.datosconfig.idioma == "cat")
		{
			manager.datosconfig.carga = "controlesbase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void boton_n()
    {
        botonn = true;
    }
	public void boton_c()
    {
        botonc = true;
    }

}
