using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class carga_al3: MonoBehaviour
{
	public manager_al3 manager;
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB
	public void Start()
	{

	}
	public void Awake()
	{
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	public float temp;
	public void Update()
	{
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (manager.datosserial.menu == -6)
		{
			SceneManager.LoadScene("espacio0_al3");
		}
		if (manager.datosserial.menu == -5)
		{
			SceneManager.LoadScene("espacio5_al3");
		}
		if (manager.datosserial.menu == -4)
		{
			SceneManager.LoadScene("espacio4_al3");
		}
		if (manager.datosserial.menu == -3)
		{
			SceneManager.LoadScene("espacio3_al3");
		}
		if (manager.datosserial.menu == -2)
		{
			SceneManager.LoadScene("espacio2_al3");
		}
		if (manager.datosserial.menu == -1)
		{
			SceneManager.LoadScene("espacio_al3");
		}
		if (manager.datosserial.menu == 0)
		{
			SceneManager.LoadScene("tutorial_al3");
		}
		if (manager.datosserial.menu == 1)
		{
			SceneManager.LoadScene("mundo1_al3");
		}
		if (manager.datosserial.menu == 2)
		{
			SceneManager.LoadScene("mundo2_al3");
		}
		if (manager.datosserial.menu == 3)
		{
			SceneManager.LoadScene("mundo3_al3");
		}
		if (manager.datosserial.menu == 4)
		{
			SceneManager.LoadScene("mundo4_al3");
		}
		if (manager.datosserial.menu == 5)
		{
			SceneManager.LoadScene("mundo5_al3");
		}
		if (manager.datosserial.menu == 6)
		{
			SceneManager.LoadScene("mundo6_al3");
		}
		if (manager.datosserial.menu == 7)
		{
			SceneManager.LoadScene("mundo7_al3");
		}
		if (manager.datosserial.menu == 8)
		{
			SceneManager.LoadScene("mundo8_al3");
		}
		if (manager.datosserial.menu == 9)
		{
			SceneManager.LoadScene("mundo9_al3");
		}
		if (manager.datosserial.menu == 10)
		{
			SceneManager.LoadScene("mundo10_al3");
		}
		if (manager.datosserial.menu == 11)
		{
			SceneManager.LoadScene("mundo11_al3");
		}
		if (manager.datosserial.menu == 12)
		{
			SceneManager.LoadScene("mundo12_al3");
		}
		if (manager.datosserial.menu == 13)
		{
			SceneManager.LoadScene("mundo13_al3");
		}
		if (manager.datosserial.menu == 14)
		{
			SceneManager.LoadScene("mundo14_al3");
		}
		if (manager.datosserial.menu == 15)
		{
			SceneManager.LoadScene("mundo15_al3");
		}
		if (manager.datosserial.menu == 16)
		{
			SceneManager.LoadScene("mundo16_al3");
		}
		if (manager.datosserial.menu == 17)
		{
			SceneManager.LoadScene("mundo15_2_al3");
		}
		if (manager.datosserial.menu == 18)
		{
			SceneManager.LoadScene("mundo17_al3");
		}

	}


}
