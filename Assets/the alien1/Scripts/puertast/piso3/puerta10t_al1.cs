using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200006B RID: 107
public class puerta10t_al1 : MonoBehaviour
{
	// Token: 0x060001A2 RID: 418 RVA: 0x00006964 File Offset: 0x00004B64
	private void Start()
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00006966 File Offset: 0x00004B66
	private void Update()
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00006968 File Offset: 0x00004B68
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("nivel8t_al1");
		}
	}
}
