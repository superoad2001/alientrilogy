using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class moneda11_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600009E RID: 158 RVA: 0x000045A3 File Offset: 0x000027A3
	private void Start()
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000045A8 File Offset: 0x000027A8
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda11 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x000045E8 File Offset: 0x000027E8
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda11 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
