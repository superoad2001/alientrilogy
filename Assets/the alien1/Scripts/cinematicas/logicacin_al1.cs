using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;
using System.Linq;
using UnityEngine.UI;


// Token: 0x02000010 RID: 16
public class logicacin_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool botonm = false;
	private Controles controles;
	public DialogueManager menuoff;
	public DialogueContainerSO DialogueSO;
	public string idcin = "0";
	public string sceneload;
	public int actevent;
	public float temp;
	public bool evact;


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
	// Token: 0x06000038 RID: 56 RVA: 0x00003A94 File Offset: 0x00001C94
	private void Start()
	{
		if(evact)
		{
			manager.datosserial.eventos[actevent] = true;
		}
		
		manager.guardar();
		menuoff.StartDialogue(DialogueSO,idcin);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A96 File Offset: 0x00001C96
	private void Update()
	{
		if(temp < 15)
		{temp += 1 * Time.deltaTime;}

		if (controles.menu.saltar.ReadValue<float>() > 0f && temp > 1)
		{
			manager.datosconfig.carga = sceneload;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
		}
		if(menuoff != null)
		{
			if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == false )
			{
				manager.datosconfig.carga = sceneload;
                manager.guardarconfig();
                manager.guardar();
				SceneManager.LoadScene("carga");
			}
		}
		
	}

}
