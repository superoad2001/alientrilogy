using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class camara_al1 : MonoBehaviour
{
	// Token: 0x06000009 RID: 9 RVA: 0x0000227D File Offset: 0x0000047D
	private void Start()
	{
		
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002280 File Offset: 0x00000480
	private void Update()
	{
		jugador_al1 jugador = UnityEngine.Object.FindObjectOfType<jugador_al1>();
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();

		if (manager.juego == 1 || manager.juego == 2)
		{
			base.transform.position = this.jugador.transform.position + this.posicion;
		}
		if (manager.juego == 4)
		{
		}

	}

	// Token: 0x04000005 RID: 5
	public GameObject jugador;

	// Token: 0x04000006 RID: 6
	public Vector3 posicion = new Vector3(0f, 0f, 0f);

	// Token: 0x04000007 RID: 7
	public Vector3 posiciond = new Vector3(0f, 0f, 0f);

	// Token: 0x04000008 RID: 8
	public Vector3 posicionmun = new Vector3(0f, 0f, 0f);
}
