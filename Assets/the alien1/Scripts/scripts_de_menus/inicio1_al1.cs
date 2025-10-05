using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio1_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool botonm = false;
	public bool botonn = false;
	public float temp;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosconfig.carga = "menu_de_carga_al1";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.borrar_data();
			manager.datosconfig.carga = "presentacion_al1";
            manager.guardarconfig();
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

    public void Detenern()
    {
        botonn = false;
    }
	public void Detenerm()
    {
        botonm = false;
    }
}
