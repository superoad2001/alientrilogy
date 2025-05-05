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
    public GameObject[] tutev = new GameObject[10];
    public bool[] staticev = new bool[10];
    public bool[] staticjugev = new bool[10];
    public bool[] staticeneev = new bool[10];
    public int index;
    public int indexmax;
    public GameObject player;
    public Vector3 pos;
    public Vector3 rot;
    public DialogueManager menuoff;
    public bool findi;
    public manager_al1 manager;
    public jugador_al1 jugador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        index = 0;
        pos = player.transform.position;
        rot = player.transform.eulerAngles;
        comenzar_evento();
  
    }
    public void terminar_evento()
    {
        jugador.controlact = true;
        manager.controlene = true;
        index++;
        if(index <= indexmax)
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
        jugador.static_ev = staticev[index];
        jugador.eventotut = tutev[index].GetComponent<tutorialbase_al1>();
        if(objetivo[index] != null)
        {objetivo[index].SetActive(true);}
        if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
		{
            menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));

        }
        
        
    }
    public void fin_dialogue()
    {
            if(tutev[index] != null)
            {tutev[index].SetActive(true);}
            jugador.controlact = staticjugev[index];
            manager.controlene = staticeneev[index];
        
        
    }
    public void Update()
    {
        DialogueManager.Instance.EndDialogueEvent.AddListener(fin_dialogue);
    }
}
