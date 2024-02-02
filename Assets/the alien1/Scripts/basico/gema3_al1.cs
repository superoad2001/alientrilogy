using System;
using UnityEngine;

// Token: 0x02000061 RID: 97
public class gema3_al1 : MonoBehaviour
{
	// Token: 0x0600017A RID: 378 RVA: 0x00006602 File Offset: 0x00004802
	private void Start()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00006604 File Offset: 0x00004804
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (manager.datosserial.gema3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00006630 File Offset: 0x00004830
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemas >= 12)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gema3 = 1;
				manager.guardar();
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
