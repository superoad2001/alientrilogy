﻿using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv11_al1 : MonoBehaviour
{
	public manager_al1 manager;
	private int gemaN11 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        gemaN11 = manager.datosserial.gemaN11;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (gemaN11 == 1)
		{
			base.transform.position = new Vector3(2.01999998f,526.799988f,456.48999f);
		}
	}

}
