using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200006E RID: 110
public class puerta9t_al1 : MonoBehaviour
{
	// Token: 0x060001AE RID: 430 RVA: 0x00006A6C File Offset: 0x00004C6C
	private void Start()
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00006A6E File Offset: 0x00004C6E
	private void Update()
	{
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00006A70 File Offset: 0x00004C70
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("nivel7t_al1");
		}
	}
}
