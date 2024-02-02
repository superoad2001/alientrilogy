using System;
using UnityEngine;

// Token: 0x02000038 RID: 56
public class moneda24_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000D6 RID: 214 RVA: 0x00004E67 File Offset: 0x00003067
	private void Start()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00004E6C File Offset: 0x0000306C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda24 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00004EAC File Offset: 0x000030AC
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda24 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
