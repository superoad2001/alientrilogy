using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio_al1 : MonoBehaviour
{
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
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        gemas = manager.datosserial.gemas;
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD

	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();

		if(!audio.isPlaying)
		{
			SceneManager.LoadScene("intro_al1");
		}
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}

		if (this.botonm == true && temp >= 1)
		{
			if (gemas >= 1)
			{
				SceneManager.LoadScene("piso1_al1");
			}
			else
			{
				SceneManager.LoadScene("lallegada_al1");
			}	
		}
		if (this.botonn == true && temp >= 1)
		{
			SceneManager.LoadScene("borrar_partida_al1");
		}
		if (this.botonc == true && temp >= 1)
		{
			manager.datosconfig.lastgame = 2;
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

    public void Detenern()
    {
        botonn = false;
    }
	public void Detenerm()
    {
        botonm = false;
    }

}
