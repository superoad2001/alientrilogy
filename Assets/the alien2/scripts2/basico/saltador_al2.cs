using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class saltador_al2 : MonoBehaviour
{
	// Token: 0x06000034 RID: 52 RVA: 0x00003A23 File Offset: 0x00001C23
	private void Start()
	{
	
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003A25 File Offset: 0x00001C25
	private void Update()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003A28 File Offset: 0x00001C28
	private void OnTriggerStay(Collider col)
	{
		jugador1_al2 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al2>();
		if (col.gameObject.tag == "Player")
		{

				jugador.tiemposalto = 0.5f;
				jugador.saltador = true;
				pushup push = UnityEngine.Object.FindObjectOfType<pushup>();
				manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
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
		jugador1_al2 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al2>();
		if (col.gameObject.tag == "Player")
		{
				jugador.saltador = false;

		}
	}

}
