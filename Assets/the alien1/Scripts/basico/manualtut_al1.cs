using UnityEngine;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;
using System.Linq;

public class manualtut_al1 : MonoBehaviour
{
    public GameObject[] eventos = new GameObject[10];
    public GameObject[] objetivo = new GameObject[10];
    public GameObject[] objetivo2 = new GameObject[10];
    public int index;
    public int indexmax;
    public GameObject player;
    public Vector3 pos;
    public Vector3 rot;
    public DialogueManager menuoff;
    public bool findi;
    public manager_al1 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        index = 0;
        pos = player.transform.position;
        rot = player.transform.eulerAngles;
        comenzar_evento();
  
    }
    public void terminar_evento()
    {
        manager.controlene = true;
        if(objetivo[index] != null)
        {objetivo[index].SetActive(false);}
        index++;
        if(indexmax > index)
        {  
            if(eventos[index] != null)
            {eventos[index].SetActive(true);}
            comenzar_evento();
        }
        
    }
    public void comenzar_evento()
    {
        player.transform.position = pos;
        player.transform.eulerAngles = rot;
        if(objetivo[index] != null)
        {objetivo[index].SetActive(true);}
        findi = true;
        if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
		{menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));}
        
    }
    public void fin_dialogue()
    {
        if(menuoff.dialogueUIManager.dialogueCanvas.activeSelf == false)
        {
            findi = false;
            manager.controlene = true;
            if(objetivo2[index] != null)
            {objetivo2[index].SetActive(true);}
        }
        
    }
    void FixedUpdate()
    {
        if(findi == true)
        {fin_dialogue();}
    }
}
