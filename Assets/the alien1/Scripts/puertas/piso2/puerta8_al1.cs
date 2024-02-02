using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200006A RID: 106
public class puerta8_al1 : MonoBehaviour
{
	// Token: 0x0600019E RID: 414 RVA: 0x000068FB File Offset: 0x00004AFB
	private void Start()
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000068FD File Offset: 0x00004AFD
	private void Update()
	{
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00006900 File Offset: 0x00004B00
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player" && manager.datosserial.gemas >= 13 && manager.datosserial.tengollave1 == 1)
		{
			SceneManager.LoadScene("nivel13_c_al1");
		}
	}
}
