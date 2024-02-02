using System;
using UnityEngine;

// Token: 0x02000077 RID: 119
public class llave3_al1 : MonoBehaviour
{
	// Token: 0x060001D2 RID: 466 RVA: 0x00006E4B File Offset: 0x0000504B
	private void Start()
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00006E50 File Offset: 0x00005050
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (manager.datosserial.tengollave3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.datosserial.gemas >= 15 && manager.datosserial.monedas >= 40)
		{
			base.transform.position = new Vector3(-0.52f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00006EB4 File Offset: 0x000050B4
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengollave3 = 1;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
