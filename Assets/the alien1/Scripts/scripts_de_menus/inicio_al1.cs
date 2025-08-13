using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botond = false;
	public int gemas = 0;
	public float temp;
	public AudioSource audio;

	public void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        gemas = manager.datosserial.economia[0];
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD

	private void Update()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

		if (temp < 15)
		{temp += 1 * Time.deltaTime;}

		if (this.botonm == true && temp >= 1)
		{
			if (manager.datosserial.begin == true)
			{
				if(manager.datosserial.nivelu != "")
				{
					SceneManager.LoadScene(manager.datosserial.nivelu);
				}
				else
				{
					manager.datosconfig.carga = "piso1_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
				}
				
			}
			else
			{
				manager.datosconfig.carga = "lallegada_al1";
				manager.guardarconfig();
				SceneManager.LoadScene("carga");
			}	
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
	public void boton_d()
    {
        botond = true;
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
