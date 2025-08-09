using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000019 RID: 25
public class hierroAP_al1 : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D


	public int LlaveID;
	public manager_al1 manager;
	public GameObject hierro;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (manager.datosserial.LlaveT[LlaveID] == true)
		{
			hierro.SetActive(true);			
		}

	}

	
}
