using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000074 RID: 116
public class puerta0_al1 : MonoBehaviour
{
	// Token: 0x060001C6 RID: 454 RVA: 0x00006C9B File Offset: 0x00004E9B
	private void Start()
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00006C9D File Offset: 0x00004E9D
	private void Update()
	{
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00006C9F File Offset: 0x00004E9F
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("piso1_al1");
		}
	}
}
