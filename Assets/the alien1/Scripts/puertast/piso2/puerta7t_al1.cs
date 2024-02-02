using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000069 RID: 105
public class puerta7t_al1 : MonoBehaviour
{
	// Token: 0x0600019A RID: 410 RVA: 0x000068AB File Offset: 0x00004AAB
	private void Start()
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x000068AD File Offset: 0x00004AAD
	private void Update()
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x000068B0 File Offset: 0x00004AB0
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel6t_al1");
		}
	}
}
