using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000022 RID: 34
public class meta4_al1 : MonoBehaviour
{
	// Token: 0x0600007E RID: 126 RVA: 0x0000417D File Offset: 0x0000237D
	private void Start()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000417F File Offset: 0x0000237F
	private void Update()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004184 File Offset: 0x00002384
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN4 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN4 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso2_al1");
		}
	}
}
