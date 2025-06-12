using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class tienda_al1 : MonoBehaviour
{
    public int productoid;
    public GameObject rew;
    public GameObject comp;
    public GameObject tienda;
    public int tiendanum;
    public Text pro1;
    public Text pro2;
    public Text pro3;
    public Text pro4;
    public Text pro5;

    public Text prodname;
    public Text proddesc;
    public Text prodprecio;
    public Text prodmonedero;
    public Image prodimg;
    public Image prodimg2;
    public int precio;
    public int tipomoneda;

    public manager_al1 manager;
    public Color[] colores;

    public Sprite[] monedas;
    public AudioSource nopson;
    public AudioSource compson;
    public AudioSource musicajuego;
    public AudioSource musicatienda;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.Find("manager").GetComponent<manager_al1>();
        if(tiendanum == 0)
        {
            pro1.text = "pro1";
            pro2.text = "pro2";

        }

        //monedas tipo
        //economia[0] = gemas;
		//economia[1] = llaves;
		//economia[2] = fragllave;
		//economia[3] = monedasrojas;
		//economia[4] = monedasmoradas;
		//economia[5] = monedasamarillas;
        //economia[6] = licencias;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void comprar()
    {
        if(productoid == 1)
        {
            if(manager.datosserial.economia[tipomoneda] >= precio)
            {
                manager.datosserial.economia[tipomoneda] -= precio;
                compson.Play();

            }
            else
            {
                nopson.Play();
            }
        }
    }
    public void prodcuto()
    {
        productoid = 1;
        rew.SetActive(false);
        comp.SetActive(true);
        prodname.text = "pro1";
        proddesc.text = "pro1 aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        precio = 10;
        tipomoneda = 0;
        prodprecio.text = "cuesta "+ precio;
        prodmonedero.text = "tienes " + manager.datosserial.economia[tipomoneda];
        prodimg.sprite = monedas[tipomoneda];
        prodimg2.sprite = monedas[tipomoneda];
        prodimg.color = colores[tipomoneda];
        prodimg2.color = colores[tipomoneda];
    }
    public void prodcuto2()
    {
        productoid = 2;
        rew.SetActive(false);
        comp.SetActive(true);
        prodname.text = "pro2";
        proddesc.text = "pro2 aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        tipomoneda = 0;
        precio = 20;
        prodprecio.text = "cuesta "+ precio;
        prodmonedero.text = "tienes " + manager.datosserial.economia[tipomoneda];
        prodimg.sprite = monedas[tipomoneda];
        prodimg2.sprite = monedas[tipomoneda];
        prodimg.color = colores[tipomoneda];
        prodimg2.color = colores[tipomoneda];
    }
    public void salir()
    {
        musicatienda.Stop();
        musicajuego.Play();
        productoid = 0;        
        comp.SetActive(false);
        rew.SetActive(true);
        tienda.SetActive(false);
    }
    public void volver()
    {
        productoid = 0;        
        comp.SetActive(false);
        rew.SetActive(true);
    }
}
