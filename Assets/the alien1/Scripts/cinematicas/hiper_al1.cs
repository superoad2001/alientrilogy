using System;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

// Token: 0x02000007 RID: 7
public class hiper_al1 : MonoBehaviour
{
	public bool botonm = false;
	private Controles controles;
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
	public GameObject objeto;
	public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
	public manager_al1 manager;
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000243D File Offset: 0x0000063D
	private void Update()
	{
	}
	public Animator anim;
	// Token: 0x06000014 RID: 20 RVA: 0x00002440 File Offset: 0x00000640
	private void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.tag == "Player" && manager.datosserial.tengomejora == 1)
		{
	    	anim.SetBool("show",true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "para volver a casa pulsa";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "To come back home press";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "per tornar a casa pren";}
			if (controles.al1.x.ReadValue<float>() > 0f || botonm == true)
			{
				SceneManager.LoadScene("lasalida_al1");
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000024A7 File Offset: 0x000006A7
	private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			anim.SetBool("show",false);
		}
	}

	// Token: 0x0400000B RID: 11
	public Text tutfinala;
}
