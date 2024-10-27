using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inicio3base : MonoBehaviour
{
    private Controles controles;

    public Text logo1;
    public Text logo2;
    public Text logo3;
    public Text logo4;
    public RectTransform logoo1;
    public GameObject logoo2;
    public GameObject logoo3;
    public GameObject logoo4;
    public int juego = 1;
    public float temp;
    public managerBASE manager;
    
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

    public void izq()
    {
        if(juego > 1)
        {juego -= 1;}
    }
    public void der()
    {
        if(juego < 5)
        {juego += 1;}
    }
    public void salir()
    {
        Application.Quit();
    }
    public void comenzar()
    {
        if(juego == 1)
        {
            SceneManager.LoadScene("presentacion_al1");
        }
        if(juego == 2)
        {
            SceneManager.LoadScene("presentacion_al2");
        }
        if(juego == 3)
        {
            SceneManager.LoadScene("presentacion_al3");
        }
        if(juego == 4)
        {
            SceneManager.LoadScene("trofeos");
        }
        if(juego == 5)
        {
            manager.datosconfig.lastgame = 1;
            manager.guardar();
            SceneManager.LoadScene("opcionesbase");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
    }

    // Update is called once per frame
    void Update()
    {
        if(controles.al3.horizontalpad.ReadValue<float>() > 0 && temp > 0.5f)
        {
            der();
            temp = 0;
        }
        if(controles.al3.horizontalpad.ReadValue<float>() < 0 && temp > 0.5f)
        {
            izq();
            temp = 0;
        }
        
        if(juego == 1) 
        {
            logo1.color = new Color32(255,64,64,255);
            logo2.color = new Color32(229,213,74,255);
            logo3.color = new Color32(255,64,64,255);
            logo4.color = new Color32(229,213,74,255);
            logoo1.transform.localPosition = new Vector3(247.499939f,-30.0000076f,0f);
            logoo2.transform.localPosition = new Vector3(211.349915f,30.9999924f,0f);
            logoo3.transform.localPosition = new Vector3(214.5f,-112f,0f);
            logoo4.transform.localPosition = new Vector3(196.5f,-183f,0f);
            logo3.fontSize = 100;
            logo4.fontSize = 82;
            logo3.text = "ADVENTURE";
            logo4.text = "";
        }
        if(juego == 2) 
        {
            logo1.color = new Color32(255,64,64,255);
            logo2.color = new Color32(229,213,74,255);
            logo3.color = new Color32(255,64,64,255);
            logo4.color = new Color32(229,213,74,255);
            logoo1.transform.localPosition = new Vector3(247.499939f,-30.0000076f,0f);
            logoo2.transform.localPosition = new Vector3(211.349915f,30.9999924f,0f);
            logoo3.transform.localPosition = new Vector3(214.5f,-112f,0f);
            logoo4.transform.localPosition = new Vector3(196.5f,-229f,0f);
            logo3.fontSize = 100;
            logo4.fontSize = 82;
            logo3.text = "ADVENTURE";
            logo4.text = "2";
        }
        if(juego == 3) 
        {
            logo1.color = new Color32(255,0,239,255);
            logo2.color = new Color32(229,213,74,255);
            logo3.color = new Color32(66,255,68,255);
            logo4.color = new Color32(255,255,255,255);
            logoo1.transform.localPosition = new Vector3(247.499939f,-83f,0f);
            logoo2.transform.localPosition = new Vector3(211.349915f,82f,0f);
            logoo3.transform.localPosition = new Vector3(211.5f,-143f,0f);
            logoo4.transform.localPosition = new Vector3(453.5f,-23f,0f);
            logo3.fontSize = 73;
            logo4.fontSize = 289;
            logo3.text = "ADVENTURE";
            logo4.text = "3";
        }
        if(juego == 4) 
        {
            logo1.color = new Color32(255,64,64,255);
            logo2.color = new Color32(229,213,74,255);
            logo3.color = new Color32(0,229,255,255);
            logo4.color = new Color32(255,255,255,255);
            logoo1.transform.localPosition = new Vector3(247.499939f,-83f,0f);
            logoo2.transform.localPosition = new Vector3(211.349915f,82f,0f);
            logoo3.transform.localPosition = new Vector3(211.5f,-143f,0f);
            logoo4.transform.localPosition = new Vector3(453.5f,-23f,0f);
            logo3.fontSize = 73;
            logo4.fontSize = 289;
            if(manager.datosconfig.idioma == "es")
            {
            logo3.text = "trofeos";
            }
            if(manager.datosconfig.idioma == "en")
            {
            logo3.text = "trophys";
            }
            if(manager.datosconfig.idioma == "cat")
            {
            logo3.text = "trofeus";
            }
            logo4.text = "";
        }
        if(juego == 5) 
        {
            logo1.color = new Color32(255,64,64,255);
            logo2.color = new Color32(229,213,74,255);
            logo3.color = new Color32(236,150,6,255);
            logo4.color = new Color32(255,255,255,255);
            logoo1.transform.localPosition = new Vector3(247.499939f,-83f,0f);
            logoo2.transform.localPosition = new Vector3(211.349915f,82f,0f);
            logoo3.transform.localPosition = new Vector3(211.5f,-143f,0f);
            logoo4.transform.localPosition = new Vector3(453.5f,-23f,0f);
            logo3.fontSize = 73;
            logo4.fontSize = 289;
            if(manager.datosconfig.idioma == "es")
            {
            logo3.text = "opciones";
            }
            if(manager.datosconfig.idioma == "en")
            {
            logo3.text = "settings";
            }
            if(manager.datosconfig.idioma == "cat")
            {
            logo3.text = "opcions";
            }
            logo4.text = "";
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
}
