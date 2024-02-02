using System;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class moneda20_al1 : MonoBehaviour
{
	public AudioSource audio1;

	// Token: 0x060000C6 RID: 198 RVA: 0x00004BE7 File Offset: 0x00002DE7
	private void Start()
	{
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00004BEC File Offset: 0x00002DEC
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda20 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00004C2C File Offset: 0x00002E2C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda20 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
