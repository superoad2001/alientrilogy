using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class saltador_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public jugador_al2 jugador;
	public pushup push;
	// Token: 0x06000034 RID: 52 RVA: 0x00003A23 File Offset: 0x00001C23
	private void Start()
	{
		jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		push = (pushup)FindFirstObjectByType(typeof(pushup));
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003A25 File Offset: 0x00001C25
	private void Update()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003A28 File Offset: 0x00001C28
	private void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.tag == "Player")
		{

				jugador.tiemposalto = 0.5f;
				jugador.saltador = true;
				if(manager.datostrof.alien2usaelsaltador == 0)
				{
					manager.datostrof.alien2usaelsaltador = 1;
					manager.guardartro();
					push.push(38);
				}

		}
	}
	private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
				jugador.saltador = false;

		}
	}

}
