using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class moneda1_al1 : MonoBehaviour
{
	public AudioSource audio1;
	public manager_al1 manager;
	// Token: 0x06000096 RID: 150 RVA: 0x00004465 File Offset: 0x00002665
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004468 File Offset: 0x00002668
	private void Update()
	{
		
		if (manager.datosserial.moneda1 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000044A8 File Offset: 0x000026A8
	private void OnTriggerEnter(Collider col)
	{
		
		manager.datosserial.monedas++;
		manager.datosserial.moneda1 = 1;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	
	}
}
