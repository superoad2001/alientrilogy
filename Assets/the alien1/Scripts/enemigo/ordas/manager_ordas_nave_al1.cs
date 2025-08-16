using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;
using System.Linq;

public class manager_ordas_nave_al1 : MonoBehaviour
{

    public jugador_al1 jugador;
    public manager_al1 manager;
    public Text rondaText;
    public Animator rondaAnim;
    public int contadorene;
    public bool actinironda;
    public float temp;
    private bool ganar;
    public GameObject TP;
    public GameObject hierro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        rondaC();
        
        
    }
    // Update is called once per frame
    void Update()
    {
        if(contadorene <= 0 && ganar == false)
        {
            rondaC();
            ganar = true; 
        }


        if(actinironda == true)
        {
            if(temp < 3)
            {
                temp += Time.deltaTime;
            }
            else if(temp >= 3)
            {
                if(ganar == true)
                {
                    hierro.SetActive(true);
                    TP.SetActive(true);
                }      
                temp = 0;
                actinironda = false;
            }
        }
        
    }
    


    public void rondaC()
    {
        if(ganar == true)
        {
            rondaText.text = "consegido";
            rondaAnim.Play("ordasanim1");
            
        }
        else
        {
            rondaText.text = "Carga OVNI";
            rondaAnim.Play("ordasanim1");
        }
        actinironda = true;
        temp = 0;
        
        
    }

    
}
