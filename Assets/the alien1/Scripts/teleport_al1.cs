using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class teleport_al1 : MonoBehaviour
{
    public Text tutfinala;
	public Animator anim;
	private Controles controles;
	public GameObject objeto;
	public manager_al1 manager;
    public string ubi;
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player" && manager.datosserial.tengonave == 1)
		{
	    	anim.SetBool("show",true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "para teletransportarte";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "To teleport";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "per teletransportarta";}
			if (controles.al1.y.ReadValue<float>() > 0f )
			{
				SceneManager.LoadScene("ubi");
			}
		}
	}
    private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			anim.SetBool("show",false);
		}
	}
}
