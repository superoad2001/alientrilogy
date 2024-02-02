using System;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class moneda3_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000EE RID: 238 RVA: 0x00005227 File Offset: 0x00003427
	private void Start()
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000522C File Offset: 0x0000342C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000526C File Offset: 0x0000346C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda3 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
