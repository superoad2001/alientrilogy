using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class moneda22_al1 : MonoBehaviour
{
	public AudioSource audio1;
	public manager_al1 manager;
	// Token: 0x060000CE RID: 206 RVA: 0x00004D27 File Offset: 0x00002F27
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00004D2C File Offset: 0x00002F2C
	private void Update()
	{
		
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda22 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00004D6C File Offset: 0x00002F6C
	private void OnTriggerEnter(Collider col)
	{
		
		manager.datosserial.moneda22 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
