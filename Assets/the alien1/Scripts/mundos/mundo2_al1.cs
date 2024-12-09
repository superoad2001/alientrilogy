using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000016 RID: 22
public class mundo2_al1 : MonoBehaviour
{
	public manager_al1 manager;
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
	// Token: 0x0600004E RID: 78 RVA: 0x00003BE7 File Offset: 0x00001DE7
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003BE9 File Offset: 0x00001DE9
	private void Update()
	{
	}
	private void OnCollisionEnter(Collision col)
	{

	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003BEB File Offset: 0x00001DEB
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
			if (controles.al1.y.ReadValue<float>() > 0f)
			{
				SceneManager.LoadScene("mundo2_al1");
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
