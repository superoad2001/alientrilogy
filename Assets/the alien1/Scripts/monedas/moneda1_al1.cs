using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class moneda1_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public AudioSource audio1;
	public GameObject explosion;
	public string monedatipo;
	public hidemenu_al1 menu;
	public int valormonedaA;

	public int moneda;
	// Token: 0x06000096 RID: 150 RVA: 0x00004465 File Offset: 0x00002665
	private void Start()
	{
		menu = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
		audio1 = GameObject.Find("monsonPL").GetComponent<AudioSource>();
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));

		if (monedatipo == "morada")
		{
			if (manager.datosserial.monedaM[moneda] == 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (monedatipo == "roja")
		{
			if (manager.datosserial.monedaR[moneda] == 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (monedatipo == "amarilla")
		{

		}
		
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004468 File Offset: 0x00002668
	private void Update()
	{	
		valormonedaA = manager.datosserial.niveljug;	
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000044A8 File Offset: 0x000026A8
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			if (monedatipo == "morada")
			{

				if (manager.datosserial.monedaM[moneda] != 1)
				{
					manager.datosserial.economia[4]++;
					manager.datosserial.monedaM[moneda] = 1;
					menu.act2 = true;
					manager.guardar();
					audio1.Play();
					GameObject roto = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
					Destroy(roto, 0.7f);
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			if (monedatipo == "roja")
			{
				if (manager.datosserial.monedaR[moneda] != 1)
				{
					manager.datosserial.economia[3]++;
					manager.datosserial.monedaR[moneda] = 1;
					menu.act2 = true;
					manager.guardar();
					audio1.Play();
					GameObject roto = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
					Destroy(roto, 0.7f);
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			if (monedatipo == "amarilla")
			{
				manager.datosserial.economia[5] += valormonedaA;
				manager.guardar();
				audio1.Play();
				menu.act2 = true;
				GameObject roto = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
				Destroy(roto, 0.7f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	
	}
}
