using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class dia1_al2 : MonoBehaviour
{
    public int pagina;
    public AudioSource audioesp;
	public AudioSource audioen;
	public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if (pagina == 1 && manager.datosserial.trozosnv1 < 3 ||pagina == 2 && manager.datosserial.trozosnv2 < 3 ||pagina == 3 && manager.datosserial.trozosnv3 < 3 ||
            pagina == 4 && manager.datosserial.trozosnv4 < 3 ||pagina == 5 && manager.datosserial.trozosnv5 < 3 || pagina == 6 && manager.datosserial.trozosnv6 < 3 ||
            pagina == 7 && manager.datosserial.trozosnv7 < 3 ||pagina == 8 && manager.datosserial.trozosnv8 < 3 ||pagina == 9 && manager.datosserial.trozosnv9 < 3 ||
            pagina == 10 && manager.datosserial.trozosnv10 < 3 ||pagina == 11 && manager.datosserial.trozosnv11 < 3 ||pagina == 12 && manager.datosserial.trozosnv12 < 3 ||
            pagina == 13 && manager.datosserial.trozosnv13 < 3 ||pagina == 14 && manager.datosserial.trozosnv14 < 3 ||pagina == 15 && manager.datosserial.trozosnv15 < 3 ||
            pagina == 16 && manager.datosserial.trozosnv16 < 3 ||pagina == 17 && manager.datosserial.trozosnv17 < 3 ||pagina == 18 && manager.datosserial.trozosnv18 < 3 ||
            pagina == 19 && manager.datosserial.trozosnv19 < 3 ||pagina == 20 && manager.datosserial.trozosnv20 < 3 )
        {
            transform.position = new Vector3 (0,600,0);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if (col.gameObject.tag == "Player")
		{
			if(manager.datosconfig.idioma == "es")
            {audioesp.Play();}
            if(manager.datosconfig.idioma == "cat")
            {audiocat.Play();}
            if(manager.datosconfig.idioma == "en")
            {audioen.Play();}
		}
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
		{
			audioesp.Stop();
            audioen.Stop();
            audiocat.Stop();
		}
    }
}
