using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class tienda5_2_al2 : MonoBehaviour
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
        manager_al2 manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        if (col.gameObject.tag == "Player" && manager.datosserial.monedas >= 20)
        {
            manager.datosserial.monedas -= 20;
            manager.guardar();
            SceneManager.LoadScene("tienda5_2_al2");
        }
        if (col.gameObject.tag == "Player" && manager.datosserial.monedas < 20)
        {
            no.Play();
        }
        
    }
}
