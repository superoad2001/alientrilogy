using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tienda_al2: MonoBehaviour
{
    public AudioSource moves;
    public void move()
	{
		moves.Play();
	}
	public manager_al2 manager;

    public int ntienda = 1;

    public AudioSource no;
    public GameObject tiendag;

    public int objetosel;


    public int req1;
    public int req2;
    public Text valor1;
    public Text valor2;
    public Text tienes1;
    public Text tienes2;
    public Text descripcion;
    public int tipomon;
    public bool tipomon1act;
    public bool tipomon2act;
    public int tipomon2;
    public GameObject moneda1obj;
    public GameObject moneda2obj;

    public Text[] botontext = new Text[5];
    public GameObject botones;
    public Text seltext;
    public Image[] tipoimg = new Image[4];
    public Sprite[] tipomonimg = new Sprite[7];
    [SerializeField] private EventSystemAccess selector;
    [SerializeField] private GameObject botoncompra;
    [SerializeField] private GameObject botonatrascompra;
    




    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        selector = (EventSystemAccess)FindFirstObjectByType(typeof(EventSystemAccess));



        
    }
    public void Update()
    {
        if(tipomon1act)
        {
            moneda1obj.SetActive(true);
        }
        else  
        {
            moneda1obj.SetActive(false);
        }
        if(tipomon2act)
        {
            moneda2obj.SetActive(true);
        }
        else  
        {
            moneda2obj.SetActive(false);
        }
    }
    
    public void boton(int objetoS)
    {

        if(objetoS == 1)
        {
            tipomon = 5;
            tipomon1act = true;
            tipomon2act = false;
            tipomon2 = 0;
            req1 = 5;
            req2 = 0;
            valor1.text = "5";
            valor2.text = "";
            tienes1.text = manager.datosserial.economia[5].ToString();
            tienes2.text = "";
            descripcion.text = "recargara toda la municion";
            objetosel = objetoS;
            seltext.text = "recarga municion";

            tipoimg[0].sprite = tipomonimg[tipomon];
            tipoimg[1].sprite = tipomonimg[tipomon];
            tipoimg[2].sprite = tipomonimg[tipomon2];
            tipoimg[3].sprite = tipomonimg[tipomon2];
        }
        selector.Seleccionar(botoncompra);
        botones.SetActive(true);
        
        

    }
    public void comprar_()
    {
		

        if(objetosel == 1)
        {
            if(manager.datosserial.economia[tipomon] >= req1)
            {
                if(tipomon2act == true & manager.datosserial.economia[tipomon2] >= req2)
                {
                    
                    manager.datosserial.economia[tipomon] -= req1;
                    manager.datosserial.economia[tipomon2] -= req2;
                    manager.guardar();
                    
                }
                else if(tipomon2act == false)
                {
                    manager.datosserial.economia[tipomon] -= req1;
                    manager.guardar();
                }
                else
                {
                    no.Play();
                }
                
            }
            else
            {
                no.Play();
            }
        }
        
    }
    public void atras_()
    {
		
        selector.Seleccionar(botonatrascompra);
        botones.SetActive(false);
        
    }
    public void salir_()
    {
        botones.SetActive(false);
        tiendag.SetActive(false);
        
    }
    
}
