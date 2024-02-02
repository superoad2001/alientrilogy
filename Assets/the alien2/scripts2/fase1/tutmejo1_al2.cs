using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using UnityEngine.SceneManagement;

public class tutmejo1_al2 : MonoBehaviour
{
    public GameObject tactil;
    public int Ac = 0;
	[SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if(manager.datosconfig.plat == 1)
        {
            tactil.SetActive(false);

        }
        if(manager.datosconfig.plat == 2)
        {
            tactil.SetActive(true);

        }
    }
    public void A()
	{
		Ac = 1;
	}
    

    // Update is called once per frame
    void Update()
    {
        if (player.GetAxis("a") > 0f || Ac == 1 )
        {
            SceneManager.LoadScene("mundo_abierto_al2");

        }
    }
}
