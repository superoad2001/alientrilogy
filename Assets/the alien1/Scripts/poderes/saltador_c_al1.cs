using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class saltador_c_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool saltoc;
	public GameObject part;
	private Controles controles;
	// Token: 0x06000034 RID: 52 RVA: 0x00003A23 File Offset: 0x00001C23
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

	// Token: 0x06000036 RID: 54 RVA: 0x00003A28 File Offset: 0x00001C28
	private void OnTriggerStay(Collider col)
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador_al1 jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		if (col.gameObject.tag == "Player" && manager.datosserial.tengosalto == 1 && saltoc == false)
		{
			if (controles.al1_general.a.ReadValue<float>() > 0f && jugador.dialogueact == false)
			{
				jugador.tiemposalto = 0.5f;
				jugador.saltoalto2();
				GameObject parti = Instantiate(part,transform.position,transform.rotation) as GameObject;
				Destroy(parti,1f);
			}

		}
		if (col.gameObject.tag == "Player" && manager.datosserial.tengosalto == 1 && saltoc == true)
		{
			if (controles.al1_general.a.ReadValue<float>() > 0f && jugador.dialogueact == false)
			{
				jugador.tiemposalto = 0.5f;
				jugador.saltoalto3();
				GameObject parti = Instantiate(part,transform.position,transform.rotation) as GameObject;
				Destroy(parti,1f);
			}

		}
	}
}
