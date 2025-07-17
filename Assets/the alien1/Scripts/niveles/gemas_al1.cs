using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000019 RID: 25
public class gemas_al1 : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D
	public manager_al1 manager;

	public bool fake;
	public AudioSource fakes;
	public AudioSource rotoson;
	public int pasos;

	public Animator cam;

	public float Temp;
	public bool fin;
	public Text conseguido;
	public GameObject aparece;
	public jugador_al1 jugador;
	public Animator conseguidoa;
	public AudioSource fanfarria;
	public GameObject rotoe;
	public GameObject rotoobj;

	public AudioSource musica;

	public int GemaID;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if(fake == false)
		{
			if (manager.datosserial.gemaT[GemaID] == 1)
			{
				Destroy(this.gameObject);
				
				
			}
		}
		

	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003C7F File Offset: 0x00001E7F
	private void Update()
	{
		
		if(Temp >= 10 )
		{

			jugador.controlact = true;
			
		}
		if(Temp > 5 )
		{	
			aparece.SetActive(true);
		}
		if(Temp > 5 && pasos < 1)
		{	pasos++;
			conseguidoa.SetBool("act",true);
			
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
		if(Temp > 6 && fake == true && pasos < 2)
		{
			pasos++;
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
			fakes.Play();
		}
		if(Temp > 7 && fake == true && pasos < 3)
		{
			pasos++;
			GameObject roto = Instantiate(rotoe, transform.position,transform.rotation) as GameObject;
			rotoson.Play();
			Destroy(roto, 1.0f);
			
			if(rotoobj != null)
			{
				Destroy(rotoobj);
			}	
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
		if(Temp > 10 )
		{
			jugador.musicajuego.Play();
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
			if(fake == true)
			{
				jugador.musicajuego.Stop();
				fanfarria.Play();
				fin = true;
				cam.SetBool("act",true);
				jugador.controlact = false;
			}
			else
			{
				if (manager.datosserial.gemaT[GemaID] == 0)
				{
				manager.datosserial.economia[0]++;
				manager.datosserial.gemaT[GemaID] = 1;
				manager.guardar();
				jugador.musicajuego.Stop();
				fanfarria.Play();
				fin = true;
				cam.SetBool("act",true);
				jugador.controlact = false;
				
				
				}
			}
			


			
			
		}
	}
}
