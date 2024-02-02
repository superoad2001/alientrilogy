using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000065 RID: 101
public class puerta3t_al1 : MonoBehaviour
{
	// Token: 0x0600018A RID: 394 RVA: 0x00006787 File Offset: 0x00004987
	private void Start()
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00006789 File Offset: 0x00004989
	private void Update()
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000678C File Offset: 0x0000498C
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel3t_al1");
		}
	}
}
