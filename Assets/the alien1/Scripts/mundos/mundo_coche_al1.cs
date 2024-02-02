using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000017 RID: 23
public class mundo_coche_al1 : MonoBehaviour
{
	// Token: 0x06000052 RID: 82 RVA: 0x00003C19 File Offset: 0x00001E19
	private void Start()
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003C1B File Offset: 0x00001E1B
	private void Update()
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00003C1D File Offset: 0x00001E1D
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("mundoc2_al1");
		}
	}
}
