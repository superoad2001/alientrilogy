using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000066 RID: 102
public class puerta4t_al1 : MonoBehaviour
{
	// Token: 0x0600018E RID: 398 RVA: 0x000067D7 File Offset: 0x000049D7
	private void Start()
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x000067D9 File Offset: 0x000049D9
	private void Update()
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x000067DB File Offset: 0x000049DB
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("sala_del_rey_al1");
		}
	}
}
