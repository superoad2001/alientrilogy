using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio2_al1 : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botont = false;
	public bool botonr = false;
	public float temp;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosconfig.plat = 1;
			manager.guardar();
			SceneManager.LoadScene("menu_de_carga_al1");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.datosconfig.plat = 2;
			manager.guardar();
			SceneManager.LoadScene("menu_de_carga_al1");
		}


		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.idioma = "es";
			manager.guardar();
			SceneManager.LoadScene("menu_de_carga_al1");
		}
		if (this.botont == true && temp >= 1)
		{
			manager.datosconfig.idioma = "en";
			manager.guardar();
			SceneManager.LoadScene("menu_de_carga_al1");
		}
		if (this.botonr == true && temp >= 1)
		{
			manager.datosconfig.idioma = "cat";
			manager.guardar();
			SceneManager.LoadScene("menu_de_carga_al1");
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
	public void boton_t()
    {
        botont = true;
    }
	public void boton_r()
    {
        botonr = true;
    }


}
