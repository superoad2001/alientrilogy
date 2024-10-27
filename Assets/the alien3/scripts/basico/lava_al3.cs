using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lava_al3: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnTriggerStay(Collider col)
	{
        jugador1_al3 jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
        if (col.gameObject.tag == "Player" && jugador.tempdano > 3)
		{
			jugador.vida--;
            jugador.tempdano = 0;
            jugador.audio2.Play();
		}

	}
}
