using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class moneda1_al1 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000096 RID: 150 RVA: 0x00004465 File Offset: 0x00002665
	private void Start()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004468 File Offset: 0x00002668
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (manager.datosserial.moneda1 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000044A8 File Offset: 0x000026A8
	private void OnTriggerEnter(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		manager.datosserial.monedas++;
		manager.datosserial.moneda1 = 1;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	
	}
}
