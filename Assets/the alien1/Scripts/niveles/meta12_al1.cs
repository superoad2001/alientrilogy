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
	public Animator nave;
	public float Temp;
	public bool fin;
	public Text conseguido;
	public Animator conseguidoa;
	public GameObject aparece;
	public int gema;
	public bool gran;
	public GameObject navem;
	public GameObject rotoe;
	public AudioSource fakes;
	public jugador_al1 jugador;
	public AudioSource fanfarria;
	public AudioSource musica;
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
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		this._rb = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003E7A File Offset: 0x0000207A
	private void Update()
	{

		if(Temp > 10 )
		{
			if(gema <= 3 && gema >= 1 && gran == false)
			{
				SceneManager.LoadScene("piso1_al1");
			}
			if(gema <= 6 && gema >= 4 && gran == false || gema == 1 && gran == true)
			{
				SceneManager.LoadScene("piso2_al1");
			}
			if(gema <= 9 && gema >= 7 && gran == false || gema == 2 && gran == true)
			{
				SceneManager.LoadScene("piso3_al1");
			}
			if(gema <= 12 && gema >= 10 && gran == false || gema == 3 && gran == true)
			{
				SceneManager.LoadScene("piso4_al1");
			}
		}
		if(Temp > 5 )
		{	
			conseguidoa.SetBool("act",true);
			aparece.SetActive(true);
			if(manager.datosconfig.idioma == "es")
			{
				conseguido.text = "lo conseguiste";
			}
			if(manager.datosconfig.idioma == "en")
			{
				conseguido.text = "you catch it";
			}
			if(manager.datosconfig.idioma == "cat")
			{
				conseguido.text = "o has aconseguit";
			}
		}
		if(fin == true)
		{			
			Temp += 1 * Time.deltaTime;
		}


		if(fin == false)
		{
			_rb2.linearVelocity = new Vector3 (0, 0, velocidad);
		}

		if(vida <= 0 && fin == false)
		{
				if (manager.datosserial.gemaN12 == 0)
				{
					manager.datosserial.gemas++;
					manager.datosserial.gemaN12 = 1;
					manager.guardar();
					fin = true;
				}
				else if (manager.datosserial.fragmentoN3 == 0 && gema == 3 && gran == true)
				{
					manager.datosserial.fragmento++;
					manager.datosserial.fragmentoN3 = 1;
					manager.guardar();
					fin = true;
				}
				musica.Stop();
				fanfarria.Play();
				jugador.controlact = false;
				jugador.velocidad = 0;
				navem.SetActive(false);
				GameObject roto = Instantiate(rotoe, transform.position,transform.rotation) as GameObject;
				fakes.Play();
				Destroy(roto, 5.0f);
				fin = true;
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
	public GameObject jugador1;

	// Token: 0x04000074 RID: 116
	public float velocidad = 0.005f;

	// Token: 0x04000075 RID: 117
	private Rigidbody rb;
}
