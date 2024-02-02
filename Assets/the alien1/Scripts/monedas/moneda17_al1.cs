using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class moneda17_al1 : MonoBehaviour
{
	public AudioSource audio1;

	// Token: 0x060000B6 RID: 182 RVA: 0x00004967 File Offset: 0x00002B67
	private void Start()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000496C File Offset: 0x00002B6C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda17 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000049AC File Offset: 0x00002BAC
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda17 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
