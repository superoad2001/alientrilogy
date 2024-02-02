using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200001B RID: 27
public class meta11_al1 : MonoBehaviour
{
	// Token: 0x06000062 RID: 98 RVA: 0x00003D5A File Offset: 0x00001F5A
	private void Start()
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003D5C File Offset: 0x00001F5C
	private void Update()
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003D60 File Offset: 0x00001F60
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN11 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN11 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso4_al1");
		}
		if (col.gameObject.tag == "coche2")
		{
			SceneManager.LoadScene("piso4_al1");
		}
	}
}
