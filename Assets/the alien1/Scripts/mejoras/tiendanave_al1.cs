using System;
using UnityEngine;

// Token: 0x0200007A RID: 122
public class tiendanave_al1 : MonoBehaviour
{
	// Token: 0x060001DE RID: 478 RVA: 0x00007097 File Offset: 0x00005297
	private void Start()
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000709C File Offset: 0x0000529C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (manager.datosserial.tengonave == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.datosserial.gemas >= 12 && manager.datosserial.monedas >= 40)
		{
			base.transform.position = new Vector3(4.77f, 527.46f, 450.05f);
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00007100 File Offset: 0x00005300
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengonave = 1;
			manager.datosserial.cinematicaf = 1;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
