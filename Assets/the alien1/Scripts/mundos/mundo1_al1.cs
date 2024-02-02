using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000015 RID: 21
public class mundo1_al1 : MonoBehaviour
{
	// Token: 0x0600004A RID: 74 RVA: 0x00003BB5 File Offset: 0x00001DB5
	private void Start()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00003BB7 File Offset: 0x00001DB7
	private void Update()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003BB9 File Offset: 0x00001DB9
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("mundo1_al1");
		}
	}
}
