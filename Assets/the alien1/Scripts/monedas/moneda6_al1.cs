using System;
using UnityEngine;

// Token: 0x02000056 RID: 86
public class moneda6_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600014E RID: 334 RVA: 0x00006127 File Offset: 0x00004327
	private void Start()
	{
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0000612C File Offset: 0x0000432C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
				base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.datosserial.moneda6 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000616C File Offset: 0x0000436C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda6 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
