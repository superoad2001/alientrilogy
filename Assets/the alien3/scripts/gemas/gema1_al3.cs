using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gema1_al3: MonoBehaviour
{
    public int gema;
    public int tgema;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        tgema = manager.datosserial.tgema[gema];
        if(tgema == 1)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnTriggerEnter(Collider col) 
    {
        jugador1_al3 jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
        if(tgema == 0 && col.gameObject.tag == "Player")
        {
            manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
            audio.Play();
            manager.datosserial.gemas++;
            manager.datosserial.tgema[gema] = 1;
            manager.guardar();
            Destroy(this.gameObject);
        }
    }
}
