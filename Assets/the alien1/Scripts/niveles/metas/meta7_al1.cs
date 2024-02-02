using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000025 RID: 37
public class meta7_al1 : MonoBehaviour
{
	// Token: 0x0600008A RID: 138 RVA: 0x000042CD File Offset: 0x000024CD
	private void Start()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000042CF File Offset: 0x000024CF
	private void Update()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000042D4 File Offset: 0x000024D4
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN7 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN7 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso3_al1");
		}
	}
}
