using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000012 RID: 18
public class subircoche_al1 : MonoBehaviour
{
	// Token: 0x0600003E RID: 62 RVA: 0x00003AE8 File Offset: 0x00001CE8
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

	// Token: 0x06000040 RID: 64 RVA: 0x00003AEC File Offset: 0x00001CEC
	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player" && manager.datosserial.tengocoche == 1)
		{
	    	anim.SetBool("show",true);
			if(manager.datosconfig.idioma == "es")
			{this.tutfinala.text = "para subir al coche pulsa";}
			if(manager.datosconfig.idioma == "en")
			{this.tutfinala.text = "To enter to the car press";}
			if(manager.datosconfig.idioma == "cat")
			{this.tutfinala.text = "per pujar al cotxe pren";}
			if (controles.al1_3d.interactuar.ReadValue<float>() > 0f )
			{
				manager.datosconfig.carga = "mundoc_al1";
            manager.guardarconfig();
            SceneManager.LoadScene("carga");
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

	// Token: 0x04000072 RID: 114
}
