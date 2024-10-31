using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x0200006C RID: 108
public class puerta11t_al1 : MonoBehaviour
{
	public manager_al1 manager;
	// Token: 0x060001A6 RID: 422 RVA: 0x000069B3 File Offset: 0x00004BB3
	private void Start()
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x000069B5 File Offset: 0x00004BB5
	private void Update()
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000069B8 File Offset: 0x00004BB8
	private void OnCollisionEnter(Collision col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("nivel9t_al1");
		}
	}
}
