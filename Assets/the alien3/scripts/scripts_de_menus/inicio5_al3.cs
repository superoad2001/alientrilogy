using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio5_al3: MonoBehaviour
{
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{

	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if(manager.datosconfig.idioma == "")
		{
			SceneManager.LoadScene("idioma_al3");
		}
		else if(manager.datosconfig.plat == 0)
		{
			SceneManager.LoadScene("controles_al3");
		}
		else
		{
			SceneManager.LoadScene("presentacion_al3");
		}
	}
}
