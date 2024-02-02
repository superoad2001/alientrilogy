using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000008 RID: 8
public class nivel2_c_al1 : MonoBehaviour
{
	public bool botonm = false;
	public GameObject tactil;
	[SerializeField]private int playerID = 0;
	[SerializeField]private Player player;

	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB
	private void Start()
	{
		player = ReInput.players.GetPlayer(playerID);
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if(manager.datosconfig.plat == 1)
		{
			tactil.SetActive(false);
		}
		if(manager.datosconfig.plat == 2)
		{
			tactil.SetActive(true);
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	private void Update()
	{
		if (player.GetAxis("a") > 0f || botonm == true)
		{
			SceneManager.LoadScene("nivel2_al1");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void detenerm()
    {
        botonm = false;
    }
}
