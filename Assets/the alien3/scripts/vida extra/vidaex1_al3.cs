using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaex1_al3: MonoBehaviour
{
    public AudioSource audio;
    public int mejorav;
    public int mejoravidan;
    public bool mejoravidaesp = false;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        mejorav = manager.datosserial.tmejoravidan[mejoravidan];
        if(mejorav == 1)
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
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        if (col.gameObject.tag == "Player" && mejorav == 0)
		{
            audio.Play();
            if(mejoravidaesp == false)
            {
                manager.datosserial.vidamaxima += 5;
            }
            if(mejoravidaesp == true)
            {
                manager.datosserial.vidamaxima += 10;
            }
            jugador.vida = manager.datosserial.vidamaxima;
            manager.datosserial.tmejoravidan[mejoravidan] = 1;
            manager.guardar();
            Destroy(this.gameObject);
		}

	}
}
