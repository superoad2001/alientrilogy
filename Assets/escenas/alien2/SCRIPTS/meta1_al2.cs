using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000019 RID: 25
public class meta1_al2 : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D
	public manager_al2 manager;

	public bool fake;
	public AudioSource fakes;
	public AudioSource rotoson;
	public int pasos;

	public Animator cam;

	public float Temp;
	public bool fin;
	public Text conseguido;
	public GameObject aparece;
	public jugador_al2 jugador;
	public Animator conseguidoa;
	public AudioSource fanfarria;
	public GameObject exp;
	public GameObject rotoobj;

	public AudioSource musica;
	public AudioSource coger;

	public int LlaveID;
	public bool muerte;
	public GameObject respawn;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
		if (manager.datosserial.LlaveT[LlaveID] == true)
		{
			
			Destroy(this.gameObject);
		}

	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003C7F File Offset: 0x00001E7F
	private void Update()
	{
		if(respawn != null)
		{
			if(respawn.activeSelf)
			{
				coger.Stop();
				fanfarria.Stop();
			}
		}
		
		
		if(Temp >= 5 && Temp < 6)
		{	
			aparece.SetActive(true);
		}
		if(Temp >= 5 && Temp < 6 && pasos < 1)
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
		if(Temp >= 6 && Temp < 10 && fake == true  && pasos < 2)
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
			GameObject expT = Instantiate(exp, transform.position,transform.rotation) as GameObject;
			Destroy(expT,1f);
			fakes.Play();
			
		}
		if(Temp >= 7  && Temp < 10 && fake == true  && pasos < 3)
		{
			pasos++;
			GameObject roto = Instantiate(exp, transform.position,transform.rotation) as GameObject;
			Destroy(roto, 1.0f);
			rotoson.Play();

			if(rotoobj != null)
			{
				Destroy(rotoobj);
			}	
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
		if(Temp >= 10 && fake == true)
		{
			jugador.musicajuego.Play();
			fanfarria.Stop();
			aparece.SetActive(false);
			conseguido.text = "";

			conseguidoa.SetBool("act",false);
			cam.SetBool("act",false);
			jugador.controlact = true;
			fin = false;
			Destroy(this.gameObject, 1.0f);

		}
		if(Temp >= 10)
		{
			jugador.musicajuego.Play();
			fanfarria.Stop();
			aparece.SetActive(false);
			conseguido.text = "";

			conseguidoa.SetBool("act",false);
			cam.SetBool("act",false);

			jugador.controlact = true;
			Destroy(rotoobj, 1.0f);
			fin = false;
			Temp = 0;
			coger.Play();
			

			GameObject expT = Instantiate(exp, transform.position,transform.rotation) as GameObject;
			Destroy(expT,1f);			
		}
		if(fin == true)
		{
			Temp += 1 * Time.deltaTime;
		}

	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003C84 File Offset: 0x00001E84
	private void OnTriggerEnter(Collider col)
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (col.gameObject.tag == "Player")
		{
			if(fake == true)
			{
				jugador.musicajuego.Stop();
				fanfarria.Play();
				fin = true;

				cam.SetBool("act",true);
				jugador.controlact = false;
				jugador._rb.linearVelocity = Vector3.zero;
			}
			else if (manager.datosserial.LlaveT[LlaveID] == false)
			{
				if(jugador.modo == "nave")
				{
					cam.enabled = true;
				}
				manager.hierronivel = true;
				manager.IDhierronivel = LlaveID;
				jugador.musicajuego.Stop();
				
				fanfarria.Play();
				fin = true;
				cam.SetBool("act",true);
				jugador.controlact = false;
				jugador._rb.linearVelocity = Vector3.zero;
				
				
			}
			


			
			
		}
	}
}
