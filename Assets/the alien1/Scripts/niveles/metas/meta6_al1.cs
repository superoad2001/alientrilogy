﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000024 RID: 36
public class meta6_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x06000086 RID: 134 RVA: 0x0000425D File Offset: 0x0000245D
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000425F File Offset: 0x0000245F
	private void Update()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004264 File Offset: 0x00002464
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN6 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN6 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso2_al1");
		}
	}
}
