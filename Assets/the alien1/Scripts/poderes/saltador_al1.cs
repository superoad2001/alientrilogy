using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class saltador_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public jugador_al1 jugador;
	// Token: 0x06000034 RID: 52 RVA: 0x00003A23 File Offset: 0x00001C23
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003A25 File Offset: 0x00001C25
	private void Update()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003A28 File Offset: 0x00001C28
	private void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.tag == "Player" && manager.datosserial.tengosalto == 1)
		{

				jugador.tiemposalto = 0.5f;
				jugador.saltoalto();

		}
	}

}
