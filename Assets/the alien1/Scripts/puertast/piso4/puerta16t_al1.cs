﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000072 RID: 114
public class puerta16t_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x060001BE RID: 446 RVA: 0x00006BAC File Offset: 0x00004DAC
	private void Start()
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00006BAE File Offset: 0x00004DAE
	private void Update()
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00006BB0 File Offset: 0x00004DB0
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player" && manager.datosserial.economia[0] >= 15 )
		{
			SceneManager.LoadScene("nivel15t_al1");
		}
	}
}
