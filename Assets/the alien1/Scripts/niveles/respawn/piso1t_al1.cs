using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200005B RID: 91
public class piso1t_al1 : MonoBehaviour
{
	// Token: 0x06000162 RID: 354 RVA: 0x000063D9 File Offset: 0x000045D9
	private void Start()
	{
	}

	// Token: 0x06000163 RID: 355 RVA: 0x000063DB File Offset: 0x000045DB
	private void Update()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x000063DD File Offset: 0x000045DD
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("piso1t_al1");
		}
	}
}
