using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000019 RID: 25
public class meta13t_al1 : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D
	private void Start()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003C7F File Offset: 0x00001E7F
	private void Update()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003C84 File Offset: 0x00001E84
	private void OnCollisionEnter(Collision col)
	{
		manager2_al1 manager2 = UnityEngine.Object.FindObjectOfType<manager2_al1>();
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player")
		{
			if (manager2.datosserial.recordnv13 > manager2.contador)
			{
				manager2.datosserial.recordnv13 = manager2.contador;
				manager.guardar();
			}
			
			SceneManager.LoadScene("piso2t_al1");
		}
	}
}
