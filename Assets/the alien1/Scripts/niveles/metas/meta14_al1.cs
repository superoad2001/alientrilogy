using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200001E RID: 30
public class meta14_al1 : MonoBehaviour
{
	public GameObject juego;
	public GameObject respawn;
	// Token: 0x0600006E RID: 110 RVA: 0x00003F2D File Offset: 0x0000212D
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003F2F File Offset: 0x0000212F
	private void Update()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003F34 File Offset: 0x00002134
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemas >= 13 && manager.datosserial.fragmentoN2 == 0)
			{
				manager.datosserial.fragmento++;
				manager.datosserial.fragmentoN2 = 1;
				manager.guardar();
			}
			SceneManager.LoadScene("piso3_al1");
		}
		if (col.gameObject.tag == "coche2")
		{
			respawn.SetActive(true);
			juego.SetActive(false);
		}
	}
}
