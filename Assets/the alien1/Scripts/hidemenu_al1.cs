using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class hidemenu_al1 : MonoBehaviour
{

    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();
        if(player.GetAxis("lt") > 0)
	    {anim.SetBool("show",true);}
        else if(player.GetAxis("lt") == 0)
	    {anim.SetBool("show",false);}

    }
}
