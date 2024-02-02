using System;
using UnityEngine;

// Token: 0x02000052 RID: 82
public class moneda48_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600013E RID: 318 RVA: 0x00005EA7 File Offset: 0x000040A7
	private void Start()
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00005EAC File Offset: 0x000040AC
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda48 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00005EEC File Offset: 0x000040EC
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda48 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
