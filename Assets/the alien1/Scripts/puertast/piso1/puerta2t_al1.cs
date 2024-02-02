using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000064 RID: 100
public class puerta2t_al1 : MonoBehaviour
{
	// Token: 0x06000186 RID: 390 RVA: 0x00006735 File Offset: 0x00004935
	private void Start()
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00006737 File Offset: 0x00004937
	private void Update()
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000673C File Offset: 0x0000493C
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel2t_al1");
		}
	}
}
