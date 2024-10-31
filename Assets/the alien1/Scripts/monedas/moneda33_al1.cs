using System;
using UnityEngine;

// Token: 0x02000042 RID: 66
public class moneda33_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public AudioSource audio1;
	// Token: 0x060000FE RID: 254 RVA: 0x000054A7 File Offset: 0x000036A7
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000054AC File Offset: 0x000036AC
	private void Update()
	{
		
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.datosserial.moneda33 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000054EC File Offset: 0x000036EC
	private void OnTriggerEnter(Collider col)
	{
		
		manager.datosserial.moneda33 = 1;
		manager.datosserial.monedas++;
		manager.guardar();
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
