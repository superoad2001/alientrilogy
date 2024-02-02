using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200005D RID: 93
public class piso3_al1 : MonoBehaviour
{
	// Token: 0x0600016A RID: 362 RVA: 0x0000643D File Offset: 0x0000463D
	private void Start()
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0000643F File Offset: 0x0000463F
	private void Update()
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00006441 File Offset: 0x00004641
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("piso3_al1");
		}
	}
}
