using System;
using UnityEngine;

// Token: 0x02000060 RID: 96
public class gema2_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x06000176 RID: 374 RVA: 0x00006552 File Offset: 0x00004752
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00006554 File Offset: 0x00004754
	private void Update()
	{
		if (manager.datosserial.gema2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00006580 File Offset: 0x00004780
	private void OnTriggerEnter(Collider col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemas >= 12)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gema2 = 1;
				manager.guardar();
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
