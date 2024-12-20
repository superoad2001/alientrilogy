﻿using System;
using UnityEngine;

// Token: 0x0200004B RID: 75
public class moneda41_al1 : MonoBehaviour
{
	public AudioSource audio1;
	public manager_al1 manager;
	// Token: 0x06000122 RID: 290 RVA: 0x00005A47 File Offset: 0x00003C47
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00005A4C File Offset: 0x00003C4C
	private void Update()
	{
		
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda41 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00005A8C File Offset: 0x00003C8C
	private void OnTriggerEnter(Collider col)
	{
		
		manager.datosserial.moneda41 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
