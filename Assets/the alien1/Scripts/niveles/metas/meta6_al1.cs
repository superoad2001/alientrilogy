using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000024 RID: 36
public class meta6_al1 : MonoBehaviour
{
	// Token: 0x06000086 RID: 134 RVA: 0x0000425D File Offset: 0x0000245D
	private void Start()
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000425F File Offset: 0x0000245F
	private void Update()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004264 File Offset: 0x00002464
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN6 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN6 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso2_al1");
		}
	}
}
