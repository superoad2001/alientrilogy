using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio1_al1 : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
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
			SceneManager.LoadScene("menu_de_carga_al1");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.borrar_data();
			SceneManager.LoadScene("presentacion_al1");
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
