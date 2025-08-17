using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class tienda_al1 : MonoBehaviour
{
    public int productoid;
    public int plataforma;
    public GameObject rew;
    public GameObject comp;
    public GameObject tienda;
    public int tiendanum;
    public Text[] prod;
    public int stock;
    private int frase;
    public jugador_al1 jugador;
    [SerializeField]
	public lore_al1 loreB;
    public Text prodname;
    public Text proddesc;
    public Text[] prodprecio = new Text[7];
    public Text[] prodmonedero = new Text[7];
    public Image[] prodimg = new Image[7];
    public Image[] prodimg2 = new Image[7];
    public int[] precio = new int[7];
    public int[] tipomoneda = new int[7];

    public manager_al1 manager;
    public Color[] colores;

    public Sprite[] monedas;
    public AudioSource nopson;
    public AudioSource compson;
    public AudioSource musicajuego;
    public AudioSource musicatienda;
    private int variedad;
    public GameObject[] botones = new GameObject[10];
    public GameObject tiendaM;
    public GameObject tiendaIn;
    private Controles controles;
    public float boton;
    public float botonb;
    public float temp;
    public Text loreN;
    public Text loredesc;
    public AudioSource Voz;


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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        loreN.text = "Tienda";
        loredesc.text = "Bienvenido a la tienda, aqui podras comprar cosas para mejorar tu experiencia";
        if(tiendanum == 0)
        {
            prod[0].text = "Hab. dash";
            prod[1].text = "Llave P2";
            prod[2].text = "Pocion+1";
            prod[3].text = "Llave P.zero";
            prod[4].text = "PX4000";
            prod[5].text = "Nave";

            stock = 6;
            if(manager.datosserial.tengodash == true)
            {
                prod[0].text = "No disponible";
            }
            if(manager.datosserial.tengollave1 == true)
            {
                prod[1].text = "No disponible";
            }
            if(manager.datosserial.pociones[0] == true)
            {
                prod[2].text = "No disponible";
            }
            if(manager.datosserial.tengollave0 == true)
            {
                prod[3].text = "No disponible";
            }
            if(manager.datosserial.armadef == true)
            {
                prod[4].text = "No disponible";
            }
            if(manager.datosserial.tengonave == true)
            {
                prod[4].text = "No disponible";
            }



        }
        for(int i = 0; i < 10; i++)
        {
            botones[i].SetActive(false);
        }
        for(int i = 0; i < stock; i++)
        {
            botones[i].SetActive(true);
        }

        //monedas tipo
        //economia[0] = gemas;
		//economia[1] = llaves;
		//economia[2] = hierro;
		//economia[3] = monedasrojas;
		//economia[4] = monedasmoradas;
		//economia[5] = monedasamarillas;
        //economia[6] = licencias;

        //tienda1
        //dash : 20 monedas y 4 moradas
        //llave piso 1 : 4 hierro y 100 monedas
        //pocion + 1 : 100 monedas y 6 moradas
        //llave 0: 6 moradas
    }

    // Update is called once per frame
    void Update()
    {
        boton = controles.al1_UI.menu1.ReadValue<float>();
        botonb = controles.al1_UI.atras.ReadValue<float>();
        if(boton > 0 && temp > 0.7f )
        {
                if(tiendaM.activeSelf)
                {
                    Atrastienda();
                }
                salir();
        }
        if(botonb > 0 && temp > 0.7f)
        {
                if(tiendaM.activeSelf)
                {
                    Atrastienda();
                }
                else
                {
                    salir();
                }
                
        }
        if(temp < 15)
        {temp += 1 * Time.unscaledDeltaTime;}
    }
    public void tiendaINI()
    {
        tiendaIn.SetActive(false);
        tiendaM.SetActive(true);
    }
    public void Atrastienda()
    {
        comp.SetActive(false);
        tiendaM.SetActive(false);
        tiendaIn.SetActive(true);
    }



    public void Hablar()
    {
        Voz.Stop();
        Voz.Play();
        frase = Random.Range(0, loreB.frases);
        loreN.text = loreB.loreN[frase];
        loredesc.text = loreB.loredesc[frase];
    }
    public void comprar()
    {
        int CHcomp = 0;

            for(int i = 0; i < variedad; i++)
            {
                
            
                if(manager.datosserial.economia[tipomoneda[i]] >= precio[i])
                {
                    CHcomp++;
                }

            }
            if(CHcomp == variedad)
            {
                for(int i = 0; i < variedad; i++)
                {
                  
                  manager.datosserial.economia[tipomoneda[i]] -= precio[i];

                }
                compson.Play();
                if(productoid == 1)
                {
                    manager.datosserial.tengodash = true;
                    manager.datosserial.HabilidadesObtenidas++;
                    manager.datosserial.eventos[3] = true;
                    manager.guardar();
                    Atrastienda();
                    salir();
                }
                else if(productoid == 2)
                {
                    manager.datosserial.tengollave1 = true;
                    manager.datosserial.economia[1]++;
                    manager.datosserial.eventos[5] = true;
                    manager.guardar();
                    Atrastienda();
                    salir();

                }
                else if(productoid == 3)
                {
                    manager.datosserial.pociones[0] = true;
                    manager.datosserial.pocionesmax++;
                    manager.datosserial.misiones[5] = 2;
                    manager.guardar();
                }
                else if(productoid == 4)
                {
                    manager.datosserial.tengollave0 = true;
                    manager.datosserial.economia[1]++;
                    manager.guardar();
                }
                else if(productoid == 5)
                {
                    manager.datosserial.armadef = true;
                    manager.datosserial.ArmasAlienObtenidas++;
                    manager.guardar();
                }
                 else if(productoid == 6)
                {
                    manager.datosserial.tengonave = true;
                    manager.datosserial.ArmasNaveObtenidas++;                 
                    manager.datosserial.eventos[4] = true;
                    manager.guardar();
                    Atrastienda();
                    salir();
                }
                
                
                
            }
            else
            {
                nopson.Play();
            }

    }
    public void prodcutoboton(int IDboton)
    {   if(IDboton == 1 && tiendanum == 0 && manager.datosserial.tengodash == false)
        
        {
            variedad = 2;
            int[] _precio = new int[variedad];
            int[] _tipomoneda = new int[variedad];
            _precio[0] = 20;
            _tipomoneda[0] = 5;
            
            _precio[1] = 4;
            _tipomoneda[1] = 4;
            prodcutoCL(1,_precio,_tipomoneda,variedad,"Hab. dash","te enseñare un habilidad con la usar las corrientes gravitacionales para dar una embestidda en el aire");
        }
        else if(IDboton == 2 && tiendanum == 0 && manager.datosserial.tengollave1 == false)
        {
            variedad = 2;
            int[] _precio = new int[variedad];
            int[] _tipomoneda = new int[variedad];

            _precio[0] = 4;
            _tipomoneda[0] = 2;

            _precio[1] = 100;
            _tipomoneda[1] = 5;

            prodcutoCL(2,_precio,_tipomoneda,variedad,"Llave P2","esta llave permite abirir el panel del ascensor para permitirte llegar a la segunda planta");
        }
        else if(IDboton == 3 && tiendanum == 0 && manager.datosserial.pociones[0] == false)
        {
            variedad = 3;
            int[] _precio = new int[variedad];
            int[] _tipomoneda = new int[variedad];

            _precio[0] = 100;
            _tipomoneda[0] = 5;

            _precio[1] = 6;
            _tipomoneda[1] = 4;

            _precio[2] = 1;
            _tipomoneda[2] = 6;

            prodcutoCL(3,_precio,_tipomoneda,variedad,"Pocion+1","es un frasco de pocion que en su interior contiene un gramo de polvo que estuvo en contacto con la energia ancestral");
        }
        else if(IDboton == 4 && tiendanum == 0 && manager.datosserial.tengollave0 == false)        
        {
            variedad = 1;
            int[] _precio = new int[variedad];
            int[] _tipomoneda = new int[variedad];

            _precio[0] = 2;
            _tipomoneda[0] = 6;

            prodcutoCL(4,_precio,_tipomoneda,variedad,"Llave P.zero","esta llave te permitira acceder a al exterior del edifcio");
        }
        else if(IDboton == 5 && tiendanum == 0 && manager.datosserial.armadef == false)            
        {
            variedad = 2;
            int[] _precio = new int[variedad];
            int[] _tipomoneda = new int[variedad];



            _precio[0] = 1000000;
            _tipomoneda[0] = 5;

            _precio[1] = 2;
            _tipomoneda[1] = 6;

            prodcutoCL(5,_precio,_tipomoneda,variedad,"PX4000","es el arma que encontre junto a ti es lo minimo que podia recibir por salvarte la vida pero es inutil esta bloqueada");
        }
        else if(IDboton == 6 && tiendanum == 0 && manager.datosserial.tengonave == false)            
        {
            variedad = 1;
            int[] _precio = new int[variedad];
            int[] _tipomoneda = new int[variedad];



            _precio[0] = 120;
            _tipomoneda[0] = 5;

            prodcutoCL(5,_precio,_tipomoneda,variedad,"Nave","esta era mi nave te la vendere pues si me alejo mucho de aqui nos la jugamos una par de gemas serian suficiente para usarla en minimos");
        }
        else
        {
            nopson.Play();
        }
    }
    public void prodcutoCL(int productoid_ ,int[] precio_,int[] tipomoneda_,int variedad, string nombre_, string descripcion_)
    {
        productoid = 1;
        rew.SetActive(false);
        comp.SetActive(true);
        prodname.text = nombre_;
        proddesc.text = descripcion_;
        if(variedad >= 1)
        {
            //1
            precio[0] = precio_[0];
            tipomoneda[0] = tipomoneda_[0];
            prodprecio[0].text = "cuesta "+ precio[0];
            prodmonedero[0].text = "tienes " + manager.datosserial.economia[tipomoneda[0]];
            prodimg[0].sprite = monedas[tipomoneda[0]];
            prodimg2[0].sprite = monedas[tipomoneda[0]];
            prodimg[0].color = colores[tipomoneda[0]];
            prodimg2[0].color = colores[tipomoneda[0]];
        }



        if(variedad >= 2)
        {
            //2
            precio[1] = precio_[1];
            tipomoneda[1] = tipomoneda_[1];
            prodprecio[1].text = "cuesta "+ precio[1];
            prodmonedero[1].text = "tienes " + manager.datosserial.economia[tipomoneda[1]];
            prodimg[1].sprite = monedas[tipomoneda[1]];
            prodimg2[1].sprite = monedas[tipomoneda[1]];
            prodimg[1].color = colores[tipomoneda[1]];
            prodimg2[1].color = colores[tipomoneda[1]];
        }
        else
        {
            prodprecio[1].text = "";
            prodmonedero[1].text = "";
            prodimg[1].color = colores[9];
            prodimg2[1].color = colores[9];
        }







        if(variedad >= 3)
        {
            //3
            precio[2] = precio_[2];
            tipomoneda[2] = tipomoneda_[2];
            prodprecio[2].text = "cuesta "+ precio[2];
            prodmonedero[2].text = "tienes " + manager.datosserial.economia[tipomoneda[2]];
            prodimg[2].sprite = monedas[tipomoneda[2]];
            prodimg2[2].sprite = monedas[tipomoneda[2]];
            prodimg[2].color = colores[tipomoneda[2]];
            prodimg2[2].color = colores[tipomoneda[2]];
        }
        else
        {
            prodprecio[2].text = "";
            prodmonedero[2].text = "";
            prodimg[2].color = colores[9];
            prodimg2[2].color = colores[9];
        }



        if(variedad >= 4)
        {
            //4
            precio[3] = precio_[3];
            tipomoneda[3] = tipomoneda_[3];
            prodprecio[3].text = "cuesta "+ precio[3];
            prodmonedero[3].text = "tienes " + manager.datosserial.economia[tipomoneda[3]];
            prodimg[3].sprite = monedas[tipomoneda[3]];
            prodimg2[3].sprite = monedas[tipomoneda[3]];
            prodimg[3].color = colores[tipomoneda[3]];
            prodimg2[3].color = colores[tipomoneda[3]];
        }
        else
        {
            prodprecio[3].text = "";
            prodmonedero[3].text = "";
            prodimg[3].color = colores[9];
            prodimg2[3].color = colores[9];
        }



        if(variedad >= 5)
        {
            //5
            precio[4] = precio_[4];
            tipomoneda[4] = tipomoneda_[4];
            prodprecio[4].text = "cuesta "+ precio[4];
            prodmonedero[4].text = "tienes " + manager.datosserial.economia[tipomoneda[4]];
            prodimg[4].sprite = monedas[tipomoneda[4]];
            prodimg2[4].sprite = monedas[tipomoneda[4]];
            prodimg[4].color = colores[tipomoneda[4]];
            prodimg2[4].color = colores[tipomoneda[4]];
        }
        else
        {
            prodprecio[4].text = "";
            prodmonedero[4].text = "";
            prodimg[4].color = colores[9];
            prodimg2[4].color = colores[9];
        }


        if(variedad >= 6)
        {
            //1
            precio[5] = precio_[5];
            tipomoneda[5] = tipomoneda_[5];
            prodprecio[5].text = "cuesta "+ precio[5];
            prodmonedero[5].text = "tienes " + manager.datosserial.economia[tipomoneda[5]];
            prodimg[5].sprite = monedas[tipomoneda[5]];
            prodimg2[5].sprite = monedas[tipomoneda[5]];
            prodimg[5].color = colores[tipomoneda[5]];
            prodimg2[5].color = colores[tipomoneda[5]];
        }
        else
        {
            prodprecio[5].text = "";
            prodmonedero[5].text = "";
            prodimg[5].color = colores[9];
            prodimg2[5].color = colores[9];
        }
        
    }


        //prodname.text = "Llave P2";
        //proddesc.text = "La llave abrira el panel del ascensor para poder ir a la segunda planta";
    
    public void salir()
    {
        musicatienda.Stop();
        musicajuego.Play();
        productoid = 0;        
        comp.SetActive(false);
        rew.SetActive(true);
        
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        plataforma = manager.datosconfig.plat;
        temp = 0;
        jugador.temppause = 0;
        jugador.controlact = true;
        if(plataforma == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
        Time.timeScale = 1;
        
        if(plataforma == 2)
		{
			jugador.tactil.SetActive(true);
		}
        manager.pauseact = false;    
        if(jugador.modo == "Coche")
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave")
        {
            jugador.anim.SetBool("act",true);
        }
        tienda.SetActive(false);
    }
    public void volver()
    {
        productoid = 0;        
        comp.SetActive(false);
        rew.SetActive(true);
    }
}
