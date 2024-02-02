using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
public class moneda23_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000D2 RID: 210 RVA: 0x00004DC7 File Offset: 0x00002FC7
	private void Start()
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00004DCC File Offset: 0x00002FCC
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda23 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00004E0C File Offset: 0x0000300C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda23 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
