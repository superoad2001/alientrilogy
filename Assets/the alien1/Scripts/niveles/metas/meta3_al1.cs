using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000021 RID: 33
public class meta3_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x0600007A RID: 122 RVA: 0x0000410D File Offset: 0x0000230D
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0000410F File Offset: 0x0000230F
	private void Update()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00004114 File Offset: 0x00002314
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN3 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN3 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso1_al1");
		}
	}
}
