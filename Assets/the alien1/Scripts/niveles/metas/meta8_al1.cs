using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000026 RID: 38
public class meta8_al1 : MonoBehaviour
{
	public GameObject juego;
	public GameObject respawn;
	// Token: 0x0600008E RID: 142 RVA: 0x0000433D File Offset: 0x0000253D
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000433F File Offset: 0x0000253F
	private void Update()
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004344 File Offset: 0x00002544
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			if (manager.datosserial.gemaN8 == 0)
			{
				manager.datosserial.gemas++;
				manager.datosserial.gemaN8 = 1;
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
