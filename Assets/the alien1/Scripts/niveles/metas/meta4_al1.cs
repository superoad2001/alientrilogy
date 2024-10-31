using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000022 RID: 34
public class meta4_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x0600007E RID: 126 RVA: 0x0000417D File Offset: 0x0000237D
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000417F File Offset: 0x0000237F
	private void Update()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004184 File Offset: 0x00002384
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
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
