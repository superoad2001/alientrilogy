using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000023 RID: 35
public class meta5_al1 : MonoBehaviour
{
	// Token: 0x06000082 RID: 130 RVA: 0x000041ED File Offset: 0x000023ED
	private void Start()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000041EF File Offset: 0x000023EF
	private void Update()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000041F4 File Offset: 0x000023F4
	private void OnCollisionEnter(Collision col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN5 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN5 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso2_al1");
		}
	}
}
