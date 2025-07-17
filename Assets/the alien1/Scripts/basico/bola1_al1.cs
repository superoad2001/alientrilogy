using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class bola1_al1 : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020A0 File Offset: 0x000002A0
	private void Update()
	{
		if(manager.datosconfig.idioma == "es")
		{
		//this.puestoj.text = puesto;
		}
		if(manager.datosconfig.idioma == "en")
		{
		//this.puestoj.text = puesto;
		}
		if(manager.datosconfig.idioma == "cat")
		{
		//this.puestoj.text = puesto;
		}
		base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
		if (base.gameObject.transform.position.z > this.jugador.gameObject.transform.position.z)
		{
			this.puesto = 2;
		}
		if (base.gameObject.transform.position.z <= this.jugador.gameObject.transform.position.z)
		{
			this.puesto = 1;
		}
		if (this.jugador.transform.position.z - base.gameObject.transform.position.z > 5f)
		{
			transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z),5f * Time.deltaTime);
		}
	}

	// Token: 0x04000001 RID: 1
	public GameObject jugador;

	// Token: 0x04000002 RID: 2
	public float velocidad = 0.005f;

	// Token: 0x04000003 RID: 3
	public int puesto = 1;

	// Token: 0x04000004 RID: 4
	public Text puestoj;
}
