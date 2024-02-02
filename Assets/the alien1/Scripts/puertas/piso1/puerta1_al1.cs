using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000063 RID: 99
public class puerta1_al1 : MonoBehaviour
{
	// Token: 0x06000182 RID: 386 RVA: 0x00006703 File Offset: 0x00004903
	private void Start()
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00006705 File Offset: 0x00004905
	private void Update()
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00006707 File Offset: 0x00004907
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel1_c_al1");
		}
	}
}
