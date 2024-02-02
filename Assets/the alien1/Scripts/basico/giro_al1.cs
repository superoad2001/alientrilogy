using System;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class giro_al1 : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x000023CC File Offset: 0x000005CC
	private void Start()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000023D0 File Offset: 0x000005D0
	private void Update()
	{
		this.distancia = Quaternion.AngleAxis(Input.GetAxis("Vertical") * 2f, Vector3.up) * this.distancia;
		this.distancia = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 2f, Vector3.up) * this.distancia;
	}

	// Token: 0x04000009 RID: 9
	public float velocidadr = 300f;

	// Token: 0x0400000A RID: 10
	public Vector3 distancia;
}
