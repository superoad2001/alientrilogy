using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEngine.UI;

// Token: 0x02000007 RID: 7
public class hiper_al1 : MonoBehaviour
{
	public bool botonm = false;
	[SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
	public GameObject objeto;
	public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		player = ReInput.players.GetPlayer(playerID);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000243D File Offset: 0x0000063D
	private void Update()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002440 File Offset: 0x00000640
	private void OnTriggerStay(Collider col)
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player" && manager.datosserial.tengomejora == 1)
		{
			objeto.SetActive(true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "pulsa (click derecho) o (B) para volver a casa";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "press (right click) or (B) To come back home";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "pren el (click dret) o la (B) per tornar a casa";}
			if (player.GetAxis("b") > 0f || botonm == true)
			{
				SceneManager.LoadScene("lasalida_al1");
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000024A7 File Offset: 0x000006A7
	private void OnTriggerExit(Collider col)
	{
		objeto.SetActive(false);
		if (col.gameObject.tag == "Player")
		{
			this.tutfinala.text = " ";
		}
	}

	// Token: 0x0400000B RID: 11
	public Text tutfinala;
}
