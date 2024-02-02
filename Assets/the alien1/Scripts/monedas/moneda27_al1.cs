using System;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class moneda27_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000E2 RID: 226 RVA: 0x00005047 File Offset: 0x00003247
	private void Start()
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000504C File Offset: 0x0000324C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda27 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000508C File Offset: 0x0000328C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda27 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
