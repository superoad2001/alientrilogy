using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200000E RID: 14
public class portalt_al1 : MonoBehaviour
{
	// Token: 0x06000030 RID: 48 RVA: 0x000039F1 File Offset: 0x00001BF1
	private void Start()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000039F3 File Offset: 0x00001BF3
	private void Update()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000039F5 File Offset: 0x00001BF5
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "jefe")
		{
			SceneManager.LoadScene("piso4t_al1");
		}
	}

	// Token: 0x04000070 RID: 112
	public GameObject jefe;

	// Token: 0x04000071 RID: 113
	public GameObject jugador;
}
