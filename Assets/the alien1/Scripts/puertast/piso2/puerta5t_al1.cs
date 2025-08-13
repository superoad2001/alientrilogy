using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000067 RID: 103
public class puerta5t_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x06000192 RID: 402 RVA: 0x00006809 File Offset: 0x00004A09
	private void Start()
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000680B File Offset: 0x00004A0B
	private void Update()
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00006810 File Offset: 0x00004A10
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
			manager.datosconfig.carga = "nivel4t_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
		}
	}
}
