using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv9_al1 : MonoBehaviour
{
	private int gemaN9 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        gemaN9 = manager.datosserial.gemaN9;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (gemaN9 == 1)
		{
			base.transform.position = new Vector3(6.28999996f,526.799988f,447.980011f);
		}
	}

}
