using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using MeetAndTalk;

public class manager_npc_al1 : MonoBehaviour
{

    public npc_al1 npc;
    public int npcID;
    public manager_al1 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        npc.npcF = manager.datosserial.npcF[npcID];
    }

    // Update is called once per frame
    void Update()
    {
        npc.dialogueid = manager.datosserial.npcF[npcID].ToString();
    }
}
