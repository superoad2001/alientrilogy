using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class planetas_al3: MonoBehaviour
{
    public int planeta;
    private Controles controles;
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
    public Text objetotext;
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
        jugador1_al3 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al3>();
        if (col.gameObject.tag == "Player")
		{
            if(controles.al3.y.ReadValue<float>() > 0)
            {
                SceneManager.LoadScene("mundo"+planeta+"_al3");
            }
            if(planeta == 1)
            {
                objetotext.text = "aterriizar en hielilandia";
            }
            if(planeta == 2)
            {
                objetotext.text = "aterriizar en villa soleada";
            }
            if(planeta == 3)
            {
                objetotext.text = "aterriizar en cometa2274";
            }
            if(planeta == 4)
            {
                objetotext.text = "aterriizar en magmacity";
            }
            if(planeta == 5)
            {
                objetotext.text = "aterriizar en prision planet";
            }
            if(planeta == 6)
            {
                objetotext.text = "aterriizar en orotopia";
            }
            if(planeta == 7)
            {
                objetotext.text = "aterriizar en luna morada";
            }
            if(planeta == 8)
            {
                objetotext.text = "aterriizar en fortaleza ardiente";
            }
            if(planeta == 9)
            {
                objetotext.text = "aterriizar en asteroide 7248";
            }
            if(planeta == 10)
            {
                objetotext.text = "aterriizar en pokitaplaya";
            }
            if(planeta == 11)
            {
                objetotext.text = "aterriizar en tropicaltown";
            }
            if(planeta == 12)
            {
                objetotext.text = "aterriizar en planeta X";
            }
            if(planeta == 13)
            {
                objetotext.text = "aterriizar en fortaleza abandonada";
            }
            if(planeta == 14)
            {
                objetotext.text = "aterriizar en nuevo hogar";
            }
            if(planeta == 15)
            {
                objetotext.text = "aterriizar en viejo hogar";
            }
            if(planeta == 16)
            {
                objetotext.text = "aterriizar en asteroide oculto";
            }
            if(planeta == 17)
            {
                objetotext.text = "aterriizar en el mundo final";
            }
		}
    }
}
