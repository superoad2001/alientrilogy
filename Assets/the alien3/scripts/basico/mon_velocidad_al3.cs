using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mon_velocidad_al3: MonoBehaviour
{
	public manager_al3 manager;
    public AudioSource audio;
	public jugador1_al3 jugador;
	// Token: 0x06000028 RID: 40 RVA: 0x000038FA File Offset: 0x00001AFA
	private void Start()
	{
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000038FC File Offset: 0x00001AFC
	private void Update()
	{
	}
	public int velocidadmaxima = 20;
	// Token: 0x0600002A RID: 42 RVA: 0x00003900 File Offset: 0x00001B00
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			jugador.velocidad = jugador.velocidadaux;
			jugador.velact = true;
			jugador.velozidad();
			jugador.velocidad = this.velocidadmaxima;
			audio.Play();
		}
	}
}
