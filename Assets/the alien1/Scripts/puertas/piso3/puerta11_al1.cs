using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200006C RID: 108
public class puerta11_al1 : MonoBehaviour
{
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
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (col.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("nivel9_c_al1");
		}
	}
}
