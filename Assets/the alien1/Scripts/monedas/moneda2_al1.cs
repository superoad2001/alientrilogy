using System;
using UnityEngine;

// Token: 0x02000033 RID: 51
public class moneda2_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000C2 RID: 194 RVA: 0x00004B47 File Offset: 0x00002D47
	private void Start()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00004B4C File Offset: 0x00002D4C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00004B8C File Offset: 0x00002D8C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.monedas++;
		manager.datosserial.moneda2 = 1;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
