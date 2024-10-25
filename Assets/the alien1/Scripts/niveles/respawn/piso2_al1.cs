using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200005C RID: 92
public class piso2_al1 : MonoBehaviour
{
	// Token: 0x06000166 RID: 358 RVA: 0x0000640B File Offset: 0x0000460B
	private void Start()
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000640D File Offset: 0x0000460D
	private void Update()
	{
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000640F File Offset: 0x0000460F
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
			manager.datosserial.alien1muere = true;
			manager.guardar();
			SceneManager.LoadScene("piso2_al1");
		}
	}
}
