using System;
using UnityEngine;

// Token: 0x02000041 RID: 65
public class moneda32_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000FA RID: 250 RVA: 0x00005407 File Offset: 0x00003607
	private void Start()
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000540C File Offset: 0x0000360C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda32 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0000544C File Offset: 0x0000364C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda32 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
