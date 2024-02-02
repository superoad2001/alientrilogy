using System;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class moneda34_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000102 RID: 258 RVA: 0x00005547 File Offset: 0x00003747
	private void Start()
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0000554C File Offset: 0x0000374C
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda34 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000558C File Offset: 0x0000378C
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.moneda34 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
