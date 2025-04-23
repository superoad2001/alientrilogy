using UnityEngine;

public class manualtut_al1 : MonoBehaviour
{
    public GameObject[] eventos;
    public int index;
    public int indexmax;
    public GameObject player;
    public Vector3 pos;
    public Vector3 rot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        index = 0;
        pos = player.transform.position;
        rot = player.transform.eulerAngles;
  
    }
    public void terminar_evento()
    {
        player.transform.position = pos;
        player.transform.eulerAngles = rot;
        index++;
        if(eventos.Length <= index)
        {
            eventos[index].SetActive(true);
        }
        
    }
}
