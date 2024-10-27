using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200001D RID: 29
public class metaFAKE_al1 : MonoBehaviour
{
	// Token: 0x0600006A RID: 106 RVA: 0x00003EB3 File Offset: 0x000020B3
	private void Start()
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003EB5 File Offset: 0x000020B5
	private void Update()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003EB8 File Offset: 0x000020B8
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel13_al1");
		}
	}
}
