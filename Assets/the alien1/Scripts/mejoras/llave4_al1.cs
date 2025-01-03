﻿using System;
using UnityEngine;

// Token: 0x02000078 RID: 120
public class llave4_al1 : MonoBehaviour
{
	// Token: 0x060001D6 RID: 470 RVA: 0x00006F0B File Offset: 0x0000510B
	public manager_al1 manager;
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00006F10 File Offset: 0x00005110
	private void Update()
	{
		if (manager.datosserial.tengollave4 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.datosserial.gemas >= 15 && manager.datosserial.monedas >= 50 && manager.datosserial.fragmento >= 3)
		{
			base.transform.position = new Vector3(-0.32f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00006F80 File Offset: 0x00005180
	private void OnTriggerEnter(Collider col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengollave4 = 1;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
