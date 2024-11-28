using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x0200001F RID: 31
public class meta15_al1 : MonoBehaviour
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
	// Token: 0x06000072 RID: 114 RVA: 0x00003FDC File Offset: 0x000021DC
	private void OnTriggerEnter(Collider col)
	{
			if (col.gameObject.tag == "bala")
			{
				vida--;
				Destroy(col.gameObject);
			}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00004064 File Offset: 0x00002264
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		this._rb = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00004066 File Offset: 0x00002266
	private void Update()
	{
		_rb2.linearVelocity = new Vector3 (0, 0, velocidad);


		if (vida <= 0)
		{
			if (manager.datosserial.gemas >= 13 && manager.datosserial.fragmentoN3 == 0)
			{
				manager.datosserial.fragmento++;
				manager.datosserial.fragmentoN3 = 1;
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

	// Token: 0x04000076 RID: 118
	public GameObject jugador;

	// Token: 0x04000077 RID: 119
	public float velocidad = 0.005f;

	// Token: 0x04000078 RID: 120
	private Rigidbody rb;
}
