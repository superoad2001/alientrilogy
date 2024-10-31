using System;
using UnityEngine;

// Token: 0x02000079 RID: 121
public class tiendacoche_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x060001DA RID: 474 RVA: 0x00006FD7 File Offset: 0x000051D7
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00006FDC File Offset: 0x000051DC
	private void Update()
	{

		if (manager.datosserial.tengocoche == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.datosserial.gemas >= 6 && manager.datosserial.monedas >= 20)
		{
			base.transform.position = new Vector3(-5.56f, 527.46f, 450.05f);
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00007040 File Offset: 0x00005240
	private void OnTriggerEnter(Collider col)
	{
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengocoche = 1;
			manager.guardar();
			manager.datostrof.alien1mejora2 = 1;
			manager.guardartro();
			push.push(3);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
