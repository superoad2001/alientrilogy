﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000070 RID: 112
public class puerta14_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x060001B6 RID: 438 RVA: 0x00006B0C File Offset: 0x00004D0C
	private void Start()
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00006B0E File Offset: 0x00004D0E
	private void Update()
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00006B10 File Offset: 0x00004D10
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel11_al1");
		}
	}
}
