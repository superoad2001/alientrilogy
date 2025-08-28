using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class Monedav_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public AudioSource audio;
	public jugador_al2 jugador;
	public GameObject part;
	// Token: 0x06000028 RID: 40 RVA: 0x000038FA File Offset: 0x00001AFA
	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));


	}

	// Token: 0x06000029 RID: 41 RVA: 0x000038FC File Offset: 0x00001AFC
	private void Update()
	{
	}
	public int velocidadmaxima = 20;
	// Token: 0x0600002A RID: 42 RVA: 0x00003900 File Offset: 0x00001B00
	private void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.tag == "Player" )
		{
			
			jugador.tiempovel = 0f;
			jugador.tiempovelint = 0;
			jugador.velocidad = jugador.velocidadaux;
			jugador.velozidad();
			jugador.velocidad = this.velocidadmaxima;
			jugador.velact = true;
			audio.Play();
		}
	}
	private void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.tag == "Player" )
		{
			GameObject parti = Instantiate(part,transform.position,transform.rotation) as GameObject;
			parti.transform.SetParent(jugador.transform);
			Destroy(parti,1f);
		}
	}
}
