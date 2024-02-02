using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
public class moneda15_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000AE RID: 174 RVA: 0x00004827 File Offset: 0x00002A27
	private void Start()
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0000482C File Offset: 0x00002A2C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda15 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0000486C File Offset: 0x00002A6C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda15 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
