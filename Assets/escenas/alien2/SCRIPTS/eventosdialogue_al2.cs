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
public class eventosdialogue_al2 : MonoBehaviour
{

    public string dialogueid;
    public DialogueContainerSO DialogueSO;
    public bool jug;
    public jugador_al2 jugador;
    public void Start()
    {
        jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            jugador._rb.linearVelocity = Vector3.zero;
            jugador.controlact = false;
            jug = true;
        }
    }
    public void LateOnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            jugador.controlact = false;
            jug = true;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            jugador.controlact = true;
            jug = false;
        }
    }




}
