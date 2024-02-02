using System;
using UnityEngine;

// Token: 0x02000051 RID: 81
public class moneda47_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600013A RID: 314 RVA: 0x00005E07 File Offset: 0x00004007
	private void Start()
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00005E0C File Offset: 0x0000400C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda47 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00005E4C File Offset: 0x0000404C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda47 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
