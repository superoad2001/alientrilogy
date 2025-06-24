using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using Unity.VisualScripting;


namespace MeetAndTalk
{
public class npc_al1 : MonoBehaviour
{

    public manager_npc_al1 managernpc;
    public string es_frase;
	public string en_frase;
	public string cat_frase;

    public int npcF = 0;

    public int npc_precio;

    public int mision;

    public string dialogueid;
    public DialogueContainerSO DialogueSO;

}
}
