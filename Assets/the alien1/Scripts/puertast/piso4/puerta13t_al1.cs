﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200006F RID: 111
public class puerta13t_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x060001B2 RID: 434 RVA: 0x00006ABB File Offset: 0x00004CBB
	private void Start()
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00006ABD File Offset: 0x00004CBD
	private void Update()
	{
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00006AC0 File Offset: 0x00004CC0
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel10t_al1");
		}
	}
}
