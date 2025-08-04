using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitanave_al1 : MonoBehaviour
{
    public GameObject[] navespunto = new GameObject[20];
    public GameObject[] navesene = new GameObject[20];
    public Vector3[] objetivopos = new Vector3[20];
    public jugador_al1 jug;
    public int navesmax;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jug = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        for(int i = 0 ;i < navesmax;  i++ )
        { 
            navesene[i].transform.SetParent(navespunto[i].transform);
            navesene[i].transform.localPosition = new Vector3(Random.Range(1.5f,8),0,0);
            navesene[i].transform.localEulerAngles  = new Vector3(0,0,0);
            objetivopos[i] = new Vector3(Random.Range(1.5f,8),0,0);

        }


        for(int i = 0 ;i < navesmax;  i++ )
        { 
            navespunto[i].transform.eulerAngles = new Vector3(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360));
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0 ;i < navesmax;  i++ )
        { 
            navespunto[i].transform.Rotate(transform.up, Time.deltaTime * 10f);
        }

        for(int i = 0 ;i < navesmax;  i++ )
        { 
            if(navesene[i] != null)
            {
                if(navesene[i].transform.localPosition == objetivopos[i])
                {
                    objetivopos[i] = new Vector3(Random.Range(1.5f,8),0,0);
                }
                navesene[i].transform.localPosition = Vector3.MoveTowards(navesene[i].transform.localPosition,objetivopos[i],0.5f * Time.deltaTime);
                Vector3 direction = jug.transform.position - navesene[i].transform.position;
                navesene[i].transform.rotation = Quaternion.LookRotation(direction);
            }
        }
        
    }
}
