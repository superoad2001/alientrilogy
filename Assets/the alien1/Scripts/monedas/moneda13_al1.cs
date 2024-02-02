using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
public class moneda13_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000A6 RID: 166 RVA: 0x000046E7 File Offset: 0x000028E7
	private void Start()
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000046EC File Offset: 0x000028EC
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda13 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000472C File Offset: 0x0000292C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda13 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
