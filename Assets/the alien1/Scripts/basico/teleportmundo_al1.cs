using System;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class teleportmundo_al1 : MonoBehaviour
{
	// Token: 0x06000042 RID: 66 RVA: 0x00003B37 File Offset: 0x00001D37
	private void Start()
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00003B39 File Offset: 0x00001D39
	private void Update()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00003B3B File Offset: 0x00001D3B
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.transform.position = new Vector3(-0.45f, 501.61f, 450.05f);
		}
	}
}
