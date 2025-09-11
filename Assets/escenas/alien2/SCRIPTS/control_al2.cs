using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class control_al2: MonoBehaviour
{
	public manager_al2 manager;
	public GameObject part;
	// Token: 0x06000028 RID: 40 RVA: 0x000038FA File Offset: 0x00001AFA
	private void Start()
	{
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if (manager.datosserial.artilugiosjug[7] == true)
		{
			part.SetActive(true);
		}
		else
		{
			part.SetActive(false);
		}
	}


}
