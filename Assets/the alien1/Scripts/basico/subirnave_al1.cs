using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000062 RID: 98
public class subirnave_al1 : MonoBehaviour
{
	// Token: 0x0600017E RID: 382 RVA: 0x000066B2 File Offset: 0x000048B2public Text tutfinala;
	public Text tutfinala;
	public Animator anim;
	private Controles controles;
	public GameObject objeto;
	public manager_al1 manager;
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

	// Token: 0x06000180 RID: 384 RVA: 0x000066B8 File Offset: 0x000048B8

	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player" && manager.datosserial.tengonave == 1)
		{
	    	anim.SetBool("show",true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "para subir a la nave pulsa";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "To enter to the ship press";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "per pujar a la nau pren";}
			if (controles.al1.b.ReadValue<float>() > 0f )
			{
				SceneManager.LoadScene("espacio_al1");
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
