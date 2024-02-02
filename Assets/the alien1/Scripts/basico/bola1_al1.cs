using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class bola1_al1 : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
	private void Start()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020A0 File Offset: 0x000002A0
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if(manager.datosconfig.idioma == "es")
		{
		this.puestoj.text = "puesto : " + this.puesto;
		}
		if(manager.datosconfig.idioma == "en")
		{
		this.puestoj.text = "place : " + this.puesto;
		}
		if(manager.datosconfig.idioma == "cat")
		{
		this.puestoj.text = "lloc : " + this.puesto;
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
			base.gameObject.transform.position = new Vector3(this.jugador.transform.position.x, base.gameObject.transform.position.y, base.gameObject.transform.position.z);
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
