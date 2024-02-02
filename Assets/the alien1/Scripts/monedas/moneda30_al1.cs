using System;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class moneda30_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000F2 RID: 242 RVA: 0x000052C7 File Offset: 0x000034C7
	private void Start()
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x000052CC File Offset: 0x000034CC
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda30 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0000530C File Offset: 0x0000350C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda30 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
