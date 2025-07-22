using UnityEngine;

public class posicioncoche_al1 : MonoBehaviour
{
    public GameObject[] pos = new GameObject[4];

    public void Start()
    {
        for(int i = 0; i < 4;  i++ )
        {  
            pos[i].GetComponent<Renderer>().enabled = false;
        }
    }
}
