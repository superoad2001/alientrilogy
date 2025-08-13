using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio4_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool botonm = false;
	public bool botonn = false;
	public float temp;
	public int plataforma;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        plataforma = manager.datosconfig.plat;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosconfig.plat = 1;
			manager.guardar();
			manager.datosconfig.carga = "presentacion_al1_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.datosconfig.plat = 2;
			manager.guardar();
			manager.datosconfig.carga = "presentacion_al1_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
		}
		if(plataforma != 0)
		{
			manager.datosconfig.carga = "presentacion_al1_al1";
            manager.guardarconfig();
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

    public void Detenern()
    {
        botonn = false;
    }
	public void Detenerm()
    {
        botonm = false;
    }
}
