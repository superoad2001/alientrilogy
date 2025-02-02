using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class llave1_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public int llave;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}
	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		if (manager.datosserial.llave[llave-1] == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00006D34 File Offset: 0x00004F34
	private void OnTriggerEnter(Collider col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.llave[llave-1] = 1;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
