using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000005 RID: 5
public class finalmalo_al3: MonoBehaviour
{
	public manager_al3 manager;
	// Token: 0x0600000C RID: 12 RVA: 0x00002397 File Offset: 0x00000597
	private void Start()
	{
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		manager.datosserial.finalmalo = 1;
		manager.guardar();
	}
	public float temp;
	// Token: 0x0600000D RID: 13 RVA: 0x00002399 File Offset: 0x00000599
	private void Update()
	{
		
	}

}
