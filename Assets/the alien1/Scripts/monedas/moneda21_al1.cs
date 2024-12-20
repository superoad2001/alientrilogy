﻿using System;
using UnityEngine;

// Token: 0x02000035 RID: 53
public class moneda21_al1 : MonoBehaviour
{
	public AudioSource audio1;
	public manager_al1 manager;
	// Token: 0x060000CA RID: 202 RVA: 0x00004C87 File Offset: 0x00002E87
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00004C8C File Offset: 0x00002E8C
	private void Update()
	{
		
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda21 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00004CCC File Offset: 0x00002ECC
	private void OnTriggerEnter(Collider col)
	{
		
		manager.datosserial.moneda21 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
