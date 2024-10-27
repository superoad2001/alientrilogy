using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000009 RID: 9
public class inicio5_al2 : MonoBehaviour
{
	public string idioma;
	public int plat;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		idioma = manager.datosconfig.idioma;
		plat = manager.datosconfig.plat;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if(idioma == "")
		{
			SceneManager.LoadScene("idioma_al2");
		}
		else if(plat == 0)
		{
			SceneManager.LoadScene("controles_al2");
		}
		else
		{
			SceneManager.LoadScene("presentacion_al2");
		}
	}
}
