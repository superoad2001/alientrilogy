using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palonave_al3: MonoBehaviour
{
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador.transform.position.x,jugador.transform.position.y,transform.position.z) ,10 * Time.deltaTime);
    }
}
