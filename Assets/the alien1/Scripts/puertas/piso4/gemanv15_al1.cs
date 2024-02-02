using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv15_al1 : MonoBehaviour
{
	private int fragmentoN3 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        fragmentoN3 = manager.datosserial.fragmentoN3;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (fragmentoN3 == 1)
		{
			base.transform.position = new Vector3(-2.0999999f,526.799988f,443.399994f);
		}
	}

}
