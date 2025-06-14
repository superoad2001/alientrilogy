using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x0200001B RID: 27
public class meta11_al1 : MonoBehaviour
{	public GameObject juego;
	public GameObject respawn;
	public int gema;
	public bool gran;
	public float Temp;
	public bool fin;
	public Text conseguido;
	public Animator conseguidoa;
	public GameObject aparece;
	// Token: 0x06000062 RID: 98 RVA: 0x00003D5A File Offset: 0x00001F5A
	public manager_al1 manager;
	public Animator cam;
	public jugador_al1 jugador;
	public AudioSource fanfarria;
	public AudioSource musica;
	public int LlaveID;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003D5C File Offset: 0x00001F5C
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
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003D60 File Offset: 0x00001F60
	private void OnTriggerEnter(Collider col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.LlaveT[LlaveID] == 0 )
			{
				manager.datosserial.economia[0]++;
				manager.datosserial.LlaveT[LlaveID] = 1;
				manager.guardar();
				fin = true;
			}
			musica.Stop();
			jugador.controlact = false;
			fanfarria.Play();
			cam.SetBool("act",true);
			fin = true;
		}
		if (col.gameObject.tag == "coche2")
		{
			if(fin == false)
			{
			respawn.SetActive(true);
			juego.SetActive(false);
			}
		}
	}
}
