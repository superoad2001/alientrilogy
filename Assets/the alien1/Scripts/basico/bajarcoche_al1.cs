using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000002 RID: 2
public class bajarcoche_al1 : MonoBehaviour
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	private void Start()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000205A File Offset: 0x0000025A
	private void Update()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000205C File Offset: 0x0000025C
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("mundoc2_al1");
		}
	}
}
