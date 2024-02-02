using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000005 RID: 5
public class final_al3: MonoBehaviour
{
	public GameObject tactil;
	[SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
	// Token: 0x0600000C RID: 12 RVA: 0x00002397 File Offset: 0x00000597
	private void Start()
	{
		player = ReInput.players.GetPlayer(playerID);
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if(manager.datosconfig.plat == 1)
        {
            tactil.SetActive(false);

        }
        if(manager.datosconfig.plat == 2)
        {
            tactil.SetActive(true);

        }
	}
	public float temp;
	public int Ac = 0;
	public void A()
	{
		Ac = 1;
	}
	// Token: 0x0600000D RID: 13 RVA: 0x00002399 File Offset: 0x00000599
	private void Update()
	{
		manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (player.GetAxis("a") > 0f && temp >= 1 || Ac == 1 && temp >= 1)
		{
			manager.datosserial.com = 0;
			manager.guardar();
			SceneManager.LoadScene("espacio0_al3");
		}
	}

}
