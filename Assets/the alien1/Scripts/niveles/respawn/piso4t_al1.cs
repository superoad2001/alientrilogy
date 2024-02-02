using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200005E RID: 94
public class piso4t_al1 : MonoBehaviour
{
	// Token: 0x0600016E RID: 366 RVA: 0x0000646F File Offset: 0x0000466F
	private void Start()
	{
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00006471 File Offset: 0x00004671
	private void Update()
	{
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00006473 File Offset: 0x00004673
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("piso4t_al1");
		}
	}
}
