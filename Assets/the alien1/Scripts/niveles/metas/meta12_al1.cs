using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x0200001C RID: 28
public class meta12_al1 : MonoBehaviour
{
	public Image vidab;
	public Text vidat;
	public float vida = 10;
	public float vidamax = 10;
	public string esname;
	public string enname;
	public string catname;
	private Rigidbody _rb;
	public Rigidbody _rb2;
	// Token: 0x06000066 RID: 102 RVA: 0x00003DFC File Offset: 0x00001FFC
		private void OnTriggerEnter(Collider col)
		{
				if (col.gameObject.tag == "bala")
				{
					vida--;
					Destroy(col.gameObject);
				}
		}


	// Token: 0x06000067 RID: 103 RVA: 0x00003E78 File Offset: 0x00002078
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		this._rb = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003E7A File Offset: 0x0000207A
	private void Update()
	{
		_rb2.linearVelocity = new Vector3 (0, 0, velocidad);

		if(vida <= 0)
		{
				if (manager.datosserial.gemaN12 == 0)
				{
					manager.datosserial.gemas++;
					manager.datosserial.gemaN12 = 1;
					manager.guardar();
				}
				SceneManager.LoadScene("piso4_al1");
		}
		vidab.fillAmount = vida/vidamax;

		if(manager.datosconfig.idioma == "es")
		{
			vidat.text = esname+": "+vida;
		}
		if(manager.datosconfig.idioma == "en")
		{
			vidat.text = enname+": "+vida;
		}
		if(manager.datosconfig.idioma == "cat")
		{
			vidat.text = catname+": "+vida;
		}
	}
	// Token: 0x04000073 RID: 115
	public GameObject jugador;

	// Token: 0x04000074 RID: 116
	public float velocidad = 0.005f;

	// Token: 0x04000075 RID: 117
	private Rigidbody rb;
}
