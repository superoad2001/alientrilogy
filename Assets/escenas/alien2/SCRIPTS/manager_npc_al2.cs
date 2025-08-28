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

public class manager_npc_al2 : MonoBehaviour
{

    public npc_al2 npc;
    public int npcID;
    public manager_al2 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        npc.npcF = manager.datosserial.npcF[npcID];
    }

    // Update is called once per frame
    void Update()
    {
        npc.dialogueid = manager.datosserial.npcF[npcID].ToString();
    }
}
