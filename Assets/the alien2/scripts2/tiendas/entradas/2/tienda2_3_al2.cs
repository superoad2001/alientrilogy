using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using UnityEngine.SceneManagement;

public class tienda2_3_al2 : MonoBehaviour
{

    public AudioSource no;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col) 
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if (col.gameObject.tag == "Player" && manager.datosserial.monedas >= 200 && manager.datosserial.mejoravida2 == 0)
        {
            manager.datosserial.monedas -= 200;
            manager.guardar();
            SceneManager.LoadScene("tienda2_3_al2");
        }
        if (col.gameObject.tag == "Player" && manager.datosserial.monedas < 200)
        {
            no.Play();
        }
        
    }
}
