using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
public class moneda9_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600015A RID: 346 RVA: 0x00006307 File Offset: 0x00004507
	private void Start()
	{
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000630C File Offset: 0x0000450C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.datosserial.moneda9 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0000634C File Offset: 0x0000454C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda9 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
