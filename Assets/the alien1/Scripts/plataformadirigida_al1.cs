using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class plataformadirigida_al1 : MonoBehaviour
{
    public Vector3[] posdest = new Vector3[20];
    public Vector3 posP;
    public float speed;
    public bool activa;
    public bool activador;
    public int i;
    public int imax;
    public plataformadirigida_al1 plat;

    public void Start()
    {

    }
    public void Update()
    {   
        if (posdest[i] == transform.position && i < imax)
        {
            i++;
        }
        if(activa == true && activador == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, posdest[i], speed * Time.deltaTime);
        }
        
        
        
        
    }
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player" && activador == true)
        {
            plat.activa = true;

        }
    }
}

