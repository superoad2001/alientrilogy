using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000015 RID: 21
public class mundo1_al1 : MonoBehaviour
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
	// Token: 0x0600004A RID: 74 RVA: 0x00003BB5 File Offset: 0x00001DB5
	public manager_al1 manager;
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00003BB7 File Offset: 0x00001DB7
	private void Update()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003BB9 File Offset: 0x00001DB9
	private void OnCollisionEnter(Collision col)
	{

	}
	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
	    	anim.SetBool("show",true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "para visitar este lugar pulsa";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "To visit this place press";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "per visitar aquest lloc pren";}
			if (controles.al1_general.y.ReadValue<float>() > 0f )
			{
				SceneManager.LoadScene("mundo1_al1");
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
