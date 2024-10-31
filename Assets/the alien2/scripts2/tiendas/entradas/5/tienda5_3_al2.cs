using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class tienda5_3_al2 : MonoBehaviour
{
	public manager_al2 manager;

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
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        if (col.gameObject.tag == "Player" && manager.datosserial.monedas >= 25)
        {
            manager.datosserial.monedas -= 25;
            manager.guardar();
            SceneManager.LoadScene("tienda5_3_al2");
        }
        if (col.gameObject.tag == "Player" && manager.datosserial.monedas < 25)
        {
            no.Play();
        }
        
    }
}
