using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000016 RID: 22
public class mundo2_al1 : MonoBehaviour
{
	// Token: 0x0600004E RID: 78 RVA: 0x00003BE7 File Offset: 0x00001DE7
	private void Start()
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003BE9 File Offset: 0x00001DE9
	private void Update()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003BEB File Offset: 0x00001DEB
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("mundo2_al1");
		}
	}
}
