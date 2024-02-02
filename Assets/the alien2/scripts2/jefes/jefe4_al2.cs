using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class jefe4_al2 : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
	private void Start()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020A0 File Offset: 0x000002A0
	private void Update()
	{
		this.puestoj.text = "puesto : " + this.puesto;
		if (base.gameObject.transform.position.z > this.jugador.gameObject.transform.position.z && tiempo > 2)
		{
			this.puesto = 2;
			tiempo = 0;
		}
		if (base.gameObject.transform.position.z <= this.jugador.gameObject.transform.position.z && tiempo > 2)
		{
			this.puesto = 1;
			tiempo = 0;
		}
		if (this.jugador.transform.position.z - base.gameObject.transform.position.z > 5f)
		{
			base.gameObject.transform.position = new Vector3(this.jugador.transform.position.x, base.gameObject.transform.position.y, base.gameObject.transform.position.z);
		}
		if(puesto == 2 && tiempo > 2)
		{
			velocidad = 28;
			base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
		}
		if(puesto == 1 && tiempo > 2)
		{
			velocidad = 22;
			base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
		}
		if(puesto == 2 && tiempo <= 2)
		{
			velocidad = 22;
			base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
		}
		if(puesto == 1 && tiempo <= 2)
		{
			velocidad = 28;
			base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
		}
		if(tiempo < 15)
		{tiempo += 1 * Time.deltaTime;}
	}

	// Token: 0x04000001 RID: 1
	public GameObject jugador;

	// Token: 0x04000002 RID: 2
	public float velocidad = 0.005f;

	public float velocidad2 = 0.005f;

	// Token: 0x04000003 RID: 3
	public int puesto = 1;
	public float tiempo;
	// Token: 0x04000004 RID: 4
	public Text puestoj;
}
