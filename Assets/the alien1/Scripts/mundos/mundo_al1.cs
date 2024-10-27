using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x0200005A RID: 90
public class mundo_al1 : MonoBehaviour
{
	public Text tutfinala;
	public Animator anim;
	private Controles controles;
	public GameObject objeto;
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
	// Token: 0x0600015E RID: 350 RVA: 0x000063A7 File Offset: 0x000045A7
	private void Start()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000063A9 File Offset: 0x000045A9
	private void Update()
	{
	}
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager_al1 manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
			manager.datosserial.alien1muere = true;
			manager.guardar();
			SceneManager.LoadScene("mundo_al1");
		}
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000063AB File Offset: 0x000045AB
	private void OnTriggerStay(Collider col)
	{
		manager_al1 manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		if (col.gameObject.tag == "Player")
		{
	    	anim.SetBool("show",true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "para visitar este lugar pulsa";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "To visit this place press";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "per visitar aquest lloc pren";}
			if (controles.al1.b.ReadValue<float>() > 0f)
			{
				SceneManager.LoadScene("mundo_al1");
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
