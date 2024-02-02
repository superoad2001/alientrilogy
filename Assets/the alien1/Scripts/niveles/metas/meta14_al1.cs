using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200001E RID: 30
public class meta14_al1 : MonoBehaviour
{
	// Token: 0x0600006E RID: 110 RVA: 0x00003F2D File Offset: 0x0000212D
	private void Start()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003F2F File Offset: 0x0000212F
	private void Update()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003F34 File Offset: 0x00002134
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemas >= 13 && manager.datosserial.fragmentoN2 == 0)
			{
				manager.datosserial.fragmento++;
				manager.datosserial.fragmentoN2 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso3_al1");
		}
		if (col.gameObject.tag == "coche2")
		{
			SceneManager.LoadScene("piso3_al1");
		}
	}
}
