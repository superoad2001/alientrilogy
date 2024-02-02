using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000014 RID: 20
public class volver_al1 : MonoBehaviour
{
	// Token: 0x06000046 RID: 70 RVA: 0x00003B83 File Offset: 0x00001D83
	private void Start()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00003B85 File Offset: 0x00001D85
	private void Update()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003B87 File Offset: 0x00001D87
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("mundo_al1");
		}
	}
}
