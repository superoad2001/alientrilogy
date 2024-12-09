using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x02000017 RID: 23
public class mundo3_al1 : MonoBehaviour
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
	// Token: 0x06000052 RID: 82 RVA: 0x00003C19 File Offset: 0x00001E19
	public manager_al1 manager;
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003C1B File Offset: 0x00001E1B
	private void Update()
	{
	}
	private void OnCollisionEnter(Collision col)
	{

	}

	// Token: 0x06000054 RID: 84 RVA: 0x00003C1D File Offset: 0x00001E1D
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
				SceneManager.LoadScene("mundo3_al1");
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
