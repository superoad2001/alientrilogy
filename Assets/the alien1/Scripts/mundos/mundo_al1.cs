﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200005A RID: 90
public class mundo_al1 : MonoBehaviour
{
	// Token: 0x0600015E RID: 350 RVA: 0x000063A7 File Offset: 0x000045A7
	private void Start()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000063A9 File Offset: 0x000045A9
	private void Update()
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000063AB File Offset: 0x000045AB
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
			manager.datosserial.alien1muere = true;
			manager.guardar();
			SceneManager.LoadScene("mundo_al1");
		}
	}
}
