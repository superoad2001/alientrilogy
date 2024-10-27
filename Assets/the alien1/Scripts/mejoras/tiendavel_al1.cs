using System;
using UnityEngine;

// Token: 0x0200007C RID: 124
public class tiendavel_al1 : MonoBehaviour
{
	// Token: 0x060001E6 RID: 486 RVA: 0x0000722B File Offset: 0x0000542B
	public manager_al1 manager;
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00007230 File Offset: 0x00005430
	private void Update()
	{
		if (manager.datosserial.tengovel == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.datosserial.gemas >= 3 && manager.datosserial.monedas >= 10)
		{
			base.transform.position = new Vector3(4.77f, 527.46f, 450.05f);
		}
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00007294 File Offset: 0x00005494
	private void OnTriggerEnter(Collider col)
	{
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
		manager_al1 manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.tengovel = 1;
			manager.guardar();
			manager.datostrof.alien1mejora1 = 1;
			manager.guardartro();
			push.push(2);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
