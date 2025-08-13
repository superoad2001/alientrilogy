using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio5base : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botont = false;
	public bool botony = false;
	public float temp;
	public int distancia;
	public managerBASE manager;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosconfig.distancia = 200;
			manager.guardar();
			manager.datosconfig.carga = "mejorabase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.datosconfig.distancia = 500;
			manager.guardar();
            manager.datosconfig.carga = "mejoraesbase";
			manager.guardar();
            SceneManager.LoadScene("carga");
        }
		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.distancia = 1000;
			manager.guardar();
			manager.datosconfig.carga = "mejorabase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if (this.botont == true && temp >= 1)
		{
			manager.datosconfig.distancia = 2000;
			manager.guardar();
			manager.datosconfig.carga = "mejorabase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if (this.botony == true && temp >= 1)
		{
			manager.datosconfig.distancia = 3000;
			manager.guardar();
			manager.datosconfig.carga = "mejorabase";
			manager.guardar();
            SceneManager.LoadScene("carga");
		}
		if(manager.datosconfig.distancia == 200 || manager.datosconfig.distancia == 500 || manager.datosconfig.distancia == 1000 || manager.datosconfig.distancia == 2000 || manager.datosconfig.distancia == 3000)
		{
			manager.datosconfig.carga = "mejorabase";
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
	public void boton_t()
    {
        botont = true;
    }
	public void boton_y()
    {
        botony = true;
    }

}
