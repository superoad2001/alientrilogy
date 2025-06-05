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
public class eventosdialogue : MonoBehaviour
{

    public string dialogueid;
    public DialogueContainerSO DialogueSO;
    public bool jug;
    public void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            jug = true;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            jug = false;
        }
    }




}
