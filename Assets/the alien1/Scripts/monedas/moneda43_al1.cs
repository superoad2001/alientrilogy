using System;
using UnityEngine;

// Token: 0x0200004D RID: 77
public class moneda43_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600012A RID: 298 RVA: 0x00005B87 File Offset: 0x00003D87
	private void Start()
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00005B8C File Offset: 0x00003D8C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda43 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00005BCC File Offset: 0x00003DCC
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda43 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
