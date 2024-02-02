using System;
using UnityEngine;

// Token: 0x02000031 RID: 49
public class moneda18_al1 : MonoBehaviour
{
	public AudioSource audio1;

	// Token: 0x060000BA RID: 186 RVA: 0x00004A07 File Offset: 0x00002C07
	private void Start()
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00004A0C File Offset: 0x00002C0C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda18 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00004A4C File Offset: 0x00002C4C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda18 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
