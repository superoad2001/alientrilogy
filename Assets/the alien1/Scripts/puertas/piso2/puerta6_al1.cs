using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000068 RID: 104
public class puerta6_al1 : MonoBehaviour
{
	// Token: 0x06000196 RID: 406 RVA: 0x0000685B File Offset: 0x00004A5B
	private void Start()
	{
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000685D File Offset: 0x00004A5D
	private void Update()
	{
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00006860 File Offset: 0x00004A60
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel5_c_al1");
		}
	}
}
