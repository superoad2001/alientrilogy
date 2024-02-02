using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio_al2 : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botond = false;

	public AudioSource audio1;
	public void Start()
	{
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	private void Update()
	{

		if(!audio1.isPlaying)
		{
			SceneManager.LoadScene("intro_al2");
		}
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();

		if (this.botonm == true && temp >= 1)
		{
			if (manager.datosserial.inicio == 1)
			{
				SceneManager.LoadScene("inicio_c_al2");
			}
			else
			{
				SceneManager.LoadScene("lasalida_al2");
			}	
		}
		if (this.botonn == true && temp >= 1)
		{
			SceneManager.LoadScene("borrar_partida_al2");
		}
		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.lastgame = 3;
            manager.guardarconfig();
			SceneManager.LoadScene("opcionesbase");
		}
		if (this.botond == true && temp >= 1)
		{
			SceneManager.LoadScene("menutrilogy");
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


}
