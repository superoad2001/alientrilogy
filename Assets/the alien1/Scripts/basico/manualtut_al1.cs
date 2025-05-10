using UnityEngine;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;
using System.Linq;
using UnityEngine.SceneManagement;

public class manualtut_al1 : MonoBehaviour
{
    public GameObject[] eventos = new GameObject[10];
    public GameObject[] objetivo = new GameObject[10];
    public GameObject[] tutev = new GameObject[10];
    public bool[] nostaticjugev = new bool[10];
    public bool[] nostaticeneev = new bool[10];
    public int index;
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
        index = 1;
        pos = player.transform.position;
        rot = player.transform.eulerAngles;
        comenzar_evento();
  
    }
    public void terminar_evento()
    {
        jugador.controlact = true;
        manager.controlene = true;
        index++;
          
        if(eventos[index-1] != null)
        {eventos[index-1].SetActive(true);}
        else
        {
            SceneManager.LoadScene("tienda_al1");
        }
        comenzar_evento();
        
        
        
    }
    public void comenzar_evento()
    {
        player.transform.position = pos;
        player.transform.eulerAngles = rot;
        jugador.static_ev = true;
        if(tutev[index-1]!= null)
        {jugador.eventotut = tutev[index-1].GetComponent<tutorialbase_al1>();}
        jugador.controlact = false;
        manager.controlene = false;
        if(objetivo[index-1] != null)
        {objetivo[index-1].SetActive(true);}
        if((DialogueManager)FindFirstObjectByType(typeof(DialogueManager)) != null)
		{
            menuoff = (DialogueManager)FindFirstObjectByType(typeof(DialogueManager));

        }
        
        
    }
    public void fin_dialogue()
    {
            if(tutev[index-1] != null)
            {tutev[index-1].SetActive(true);}
            else
            {
                SceneManager.LoadScene("tienda_al1");
            }
            jugador.controlact = nostaticjugev[index-1];
            manager.controlene = nostaticeneev[index-1];          
            
        
        
    }
    public void Update()
    {
        DialogueManager.Instance.EndDialogueEvent.AddListener(fin_dialogue);
    }
}
