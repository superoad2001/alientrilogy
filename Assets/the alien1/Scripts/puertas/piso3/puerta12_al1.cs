using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200006D RID: 109
public class puerta12_al1 : MonoBehaviour
{
	// Token: 0x060001AA RID: 426 RVA: 0x00006A03 File Offset: 0x00004C03
	private void Start()
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00006A05 File Offset: 0x00004C05
	private void Update()
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00006A08 File Offset: 0x00004C08
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player" && manager.datosserial.gemas >= 14 && manager.datosserial.tengollave2 == 1)
		{
			SceneManager.LoadScene("nivel14_c_al1");
		}
	}
}
