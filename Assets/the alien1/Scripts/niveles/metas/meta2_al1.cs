using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000020 RID: 32
public class meta2_al1 : MonoBehaviour
{
	// Token: 0x06000076 RID: 118 RVA: 0x0000409F File Offset: 0x0000229F
	private void Start()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000040A1 File Offset: 0x000022A1
	private void Update()
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000040A4 File Offset: 0x000022A4
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN2 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN2 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso1_al1");
		}
	}
}
