﻿using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class moneda12_al1 : MonoBehaviour
{
	public AudioSource audio1;
	public manager_al1 manager;
	// Token: 0x060000A2 RID: 162 RVA: 0x0000464A File Offset: 0x0000284A
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000464C File Offset: 0x0000284C
	private void Update()
	{
		
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda12 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000468C File Offset: 0x0000288C
	private void OnTriggerEnter(Collider col)
	{
		
		manager.datosserial.moneda12 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
