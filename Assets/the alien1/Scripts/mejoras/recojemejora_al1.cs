﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000073 RID: 115
public class recojemejora_al1 : MonoBehaviour
{
	// Token: 0x060001C2 RID: 450 RVA: 0x00006C14 File Offset: 0x00004E14
	public manager_al1 manager;
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00006C18 File Offset: 0x00004E18
	private void Update()
	{
		if (manager.datosserial.tengomejora == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00006C44 File Offset: 0x00004E44
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengomejora = 1;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
			SceneManager.LoadScene("espacio_al1");

		}
	}
}
