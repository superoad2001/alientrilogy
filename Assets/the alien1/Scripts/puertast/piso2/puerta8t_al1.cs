﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200006A RID: 106
public class puerta8t_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x0600019E RID: 414 RVA: 0x000068FB File Offset: 0x00004AFB
	private void Start()
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000068FD File Offset: 0x00004AFD
	private void Update()
	{
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00006900 File Offset: 0x00004B00
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player" && manager.datosserial.economia[0] >= 13)
		{
			SceneManager.LoadScene("nivel13t_al1");
		}
	}
}
