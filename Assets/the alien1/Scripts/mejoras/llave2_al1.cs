using System;
using UnityEngine;

// Token: 0x02000076 RID: 118
public class llave2_al1 : MonoBehaviour
{
	// Token: 0x060001CE RID: 462 RVA: 0x00006D8B File Offset: 0x00004F8B
	private void Start()
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00006D90 File Offset: 0x00004F90
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (manager.datosserial.tengollave2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.datosserial.gemas >= 14 && manager.datosserial.monedas >= 40)
		{
			base.transform.position = new Vector3(-0.12f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00006DF4 File Offset: 0x00004FF4
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengollave2 = 1;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
