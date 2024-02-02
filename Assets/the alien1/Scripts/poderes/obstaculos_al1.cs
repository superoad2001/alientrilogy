using System;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class obstaculos_al1 : MonoBehaviour
{
	// Token: 0x0600002C RID: 44 RVA: 0x0000396C File Offset: 0x00001B6C
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			this.jugador.gameObject.transform.position = new Vector3(-150f, 648f, 50f);
			this.jefe.gameObject.transform.position = new Vector3(-150f, 681.5613f, -10.45581f);
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000039E5 File Offset: 0x00001BE5
	private void Start()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000039E7 File Offset: 0x00001BE7
	private void Update()
	{
	}

	// Token: 0x0400006E RID: 110
	public GameObject jugador;

	// Token: 0x0400006F RID: 111
	public GameObject jefe;
}
