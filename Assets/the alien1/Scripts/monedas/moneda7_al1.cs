using System;
using UnityEngine;

// Token: 0x02000057 RID: 87
public class moneda7_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000152 RID: 338 RVA: 0x000061C7 File Offset: 0x000043C7
	private void Start()
	{
	}

	// Token: 0x06000153 RID: 339 RVA: 0x000061CC File Offset: 0x000043CC
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
				base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.datosserial.moneda7 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0000620C File Offset: 0x0000440C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda7 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
