using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemaU1_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public int LlaveT;
	public int ubi;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (ubi == 1 && manager.datosserial.LlaveT[LlaveT] == 1)
		{
			base.transform.position = new Vector3(-6.53999996f,transform.position.y,451.910004f);
		}
		if (ubi == 2 && manager.datosserial.LlaveT[LlaveT] == 1)
		{
			base.transform.position = new Vector3(2.01999998f,transform.position.y,456.48999f);
		}
		if (ubi == 3 && manager.datosserial.LlaveT[LlaveT] == 1)
		{
			base.transform.position = new Vector3(6.28999996f,transform.position.y,447.980011f);
		}
		if (ubi == 4 && manager.datosserial.LlaveT[LlaveT] == 1)
		{
			base.transform.position = new Vector3(-2.0999999f,transform.position.y,443.399994f);
		}
	}

}
