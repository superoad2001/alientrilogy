using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000019 RID: 25
public class meta1_al1 : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D
	public manager_al1 manager;
	public int gema;
	public bool gran;

	public bool fake;
	public AudioSource fakes;

	public Animator cam;

	public float Temp;
	public bool fin;
	public Text conseguido;
	public GameObject aparece;
	public jugador_al1 jugador;
	public Animator conseguidoa;
	public AudioSource fanfarria;
	public GameObject rotoe;

	public AudioSource musica;

	public int LlaveID;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if (manager.datosserial.LlaveT[LlaveID] == 1)
		{
			Destroy(this.gameObject);
		}
		else if (manager.datosserial.LlaveT[LlaveID] == 1 )
		{
			Destroy(this.gameObject);
		}
		else if (manager.datosserial.LlaveT[LlaveID] == 1)
		{
			Destroy(this.gameObject);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003C7F File Offset: 0x00001E7F
	private void Update()
	{
		
		if(Temp >= 10 )
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
		if(Temp > 7 && fake == true)
		{
			if(manager.datosconfig.idioma == "es")
			{
				conseguido.text = "o no?";
			}
			if(manager.datosconfig.idioma == "en")
			{
				conseguido.text = "or not?";
			}
			if(manager.datosconfig.idioma == "cat")
			{
				conseguido.text = "o no?";
			}
			GameObject roto = Instantiate(rotoe, transform.position,transform.rotation) as GameObject;
			fakes.Play();
			Destroy(roto, 1.0f);
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
		if(Temp > 10 )
		{
			musica.Play();
			fanfarria.Stop();
			aparece.SetActive(false);
			conseguido.text = "";
			conseguidoa.SetBool("act",false);
			cam.SetBool("act",false);
			jugador.controlact = true;
			Destroy(this.gameObject);
			fin = false;
			Temp = 0;
		}
		if(fin == true)
		{
			Temp += 1 * Time.deltaTime;
		}

	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003C84 File Offset: 0x00001E84
	private void OnTriggerEnter(Collider col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{

			if (manager.datosserial.LlaveT[LlaveID] == 0 && gema == 1 && gran == false)
			{
				manager.datosserial.economia[0]++;
				manager.datosserial.LlaveT[LlaveID] = 1;
				manager.guardar();
				
			}
			else if(fake == true)
			{
				musica.Stop();
				fanfarria.Play();
				fin = true;
				cam.SetBool("act",true);
				jugador.controlact = false;
			}
			


			
			
		}
	}
}
