using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escenacarga_al3: MonoBehaviour
{
    public float temp;
    public float tiempo;
    public int escena;
    public AudioSource audio0;
    public AudioSource audioes;
    public AudioSource audioen;
    public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        if(manager.datosconfig.idioma == "es")
        {
            audio0 = audioes;
        }
        if(manager.datosconfig.idioma == "en")
        {
            audio0 = audioen;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            audio0 = audiocat;
        }
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
       temp += 1 * Time.deltaTime;
       if(temp > tiempo)
       {
            if(escena == 2)
            {
                SceneManager.LoadScene("jefenormal1_al3");
            }
            if(escena == 3)
            {
                SceneManager.LoadScene("espacio_al3");
            }
            if(escena == 4)
            {
                SceneManager.LoadScene("jefenormal2_al3");
            }
            if(escena == 5)
            {
                SceneManager.LoadScene("espacio2_al3");
            }
            if(escena == 6)
            {
                SceneManager.LoadScene("jefenormal3_al3");
            }
            if(escena == 7)
            {
                SceneManager.LoadScene("espacio3_al3");
            }
            if(escena == 8)
            {
                SceneManager.LoadScene("jefenormal4_al3");
            }
            if(escena == 9)
            {
                SceneManager.LoadScene("espacio4_al3");
            }
            if(escena == 10)
            {
                SceneManager.LoadScene("jefenormal5_al3");
            }
            if(escena == 11)
            {
                SceneManager.LoadScene("jefe5_al3");
            }
            if(escena == 12)
            {
                SceneManager.LoadScene("final_al3");
            }
            if(escena == 13)
            {
                SceneManager.LoadScene("jefenormal6_al3");
            }
            if(escena == 14)
            {
                SceneManager.LoadScene("final2_al3");
            }
            if(escena == 15)
            {
                manager.datosserial.com = 0;
                manager.guardar();
                SceneManager.LoadScene("carga_al3");
            }
       } 
    }
}
