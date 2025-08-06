using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inicio3base : MonoBehaviour
{
    private Controles controles;
    public Text exp1;
    public Text exp2;
    public Text exp3;

    public Text al1;
    public Text log2;
    public Text adv3;
    public Text num4;
    public int juego = 1;
    public float temp;
    public managerBASE manager;
    public Animator menu;
    public Animator pres;
    public Animator nave1;
    public Animator camaraanim;
    public bool presskip;
    public float temp2;
    public GameObject event1;
    public GameObject event2;

    public int lastgame = 0;
    public AudioSource musica1;
    public AudioSource musica2;
    
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
    public void skip()
    {
        if(presskip == false)
        {
            menu.SetBool("skip",true);
            pres.SetBool("skip",true);
            nave1.SetBool("skip",true);
            camaraanim.SetBool("skip",true);
            event1.SetActive(false);
            event2.SetActive(true);
            musica1.Stop();
            musica2.Play();
            presskip = true;
        }
    }
    public void izq()
    {
        if(presskip == true)
        {

            // para alien 1
            if(juego == 5)
            {
                juego = 1;
                manager.move();
            }
            //para alien 2
            /*if(juego == 4)
            {
                juego = 2;
                manager.move();
            }
            else if(juego > 1)
            {
                juego -= 1;
                manager.move();
            }*/

            //para alien 3

            /*if(juego > 1)
            {
                juego -= 1;
                manager.move();
            }*/
        }
    }
    public void der()
    {
        if(presskip == true)
        {
            // para alien 1
            if(juego == 1)
            {
                juego = 5;
                manager.move();
            }

            //para alien 2
            /*if(juego == 2)
            {
                juego = 4;
                manager.move();
            }
            else if(juego < 5)
            {
                juego += 1;
                manager.move();
            }*/

            //para alien 3
            /*if(juego < 5)
            {
                juego += 1;
                manager.move();
            }*/
        }
    }
    public void salir()
    {
        Application.Quit();
    }
    public void comenzar()
    {
        if(presskip == true)
        {
            if(juego == 1)
            {
                SceneManager.LoadScene("menu_de_carga_al1");
            }
            if(juego == 2)
            {
                SceneManager.LoadScene("menu_de_carga_al2");
            }
            if(juego == 3)
            {
                SceneManager.LoadScene("menu_de_carga_al3");
            }
            if(juego == 4)
            {
                SceneManager.LoadScene("trofeos");
            }
            if(juego == 5)
            {
                SceneManager.LoadScene("opcionesbase");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));

        
        manager.datosconfig.lastgame = lastgame;
        manager.guardar();
        if(manager.datosconfig.idioma == "es")
        {
        exp1.text = "Izquierda";
        exp2.text = "Entrar";
        exp3.text = "Derecha";
        }

    }

    // Update is called once per frame
    void Update()
    {
            if(controles.menu.sel.ReadValue<Vector2>().x  > 0 && temp > 0.5f && presskip)
            {
                der();
                temp = 0;
            }
            if(controles.menu.sel.ReadValue<Vector2>().x < 0 && temp > 0.5f && presskip)
            {
                izq();
                temp = 0;
                
            }
            if(controles.menu.saltar.ReadValue<float>() > 0 && temp > 0.5f && presskip == false)
            {
                skip();
            }
            if(controles.menu.enter.ReadValue<float>() > 0 && temp > 0.5f && presskip == false)
            {
                comenzar();
            }
            if(controles.menu.atras.ReadValue<float>() > 0 && temp > 0.5f && presskip == false)
            {
                salir();
            }

            
            if(juego == 1) 
            {
                al1.color = new Color32(255,64,64,255);
                log2.color = new Color32(229,213,74,255);
                adv3.color = new Color32(255,64,64,255);
                num4.color = new Color32(229,213,74,255);
                adv3.text = "ADVENTURE";
                num4.text = "";
                menu.SetInteger("juego",1);
                camaraanim.SetInteger("juego",1);
            }
            if(juego == 2) 
            {
                al1.color = new Color32(255,64,64,255);
                log2.color = new Color32(229,213,74,255);
                adv3.color = new Color32(255,64,64,255);
                num4.color = new Color32(229,213,74,255);
                adv3.text = "ADVENTURE";
                num4.text = "2";
                menu.SetInteger("juego",2);
                camaraanim.SetInteger("juego",2);
            }
            if(juego == 3) 
            {
                al1.color = new Color32(255,0,239,255);
                log2.color = new Color32(229,213,74,255);
                adv3.color = new Color32(66,255,68,255);
                num4.color = new Color32(255,255,255,255);
                adv3.text = "ADVENTURE";
                num4.text = "3";
                menu.SetInteger("juego",3);
                camaraanim.SetInteger("juego",3);
            }
            if(juego == 4) 
            {
                al1.color = new Color32(255,64,64,255);
                log2.color = new Color32(229,213,74,255);
                adv3.color = new Color32(0,229,255,255);
                num4.color = new Color32(255,255,255,255);
                if(manager.datosconfig.idioma == "es")
                {
                adv3.text = "TROFEOS";
                }
                if(manager.datosconfig.idioma == "en")
                {
                adv3.text = "trophys";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                adv3.text = "trofeus";
                }
                num4.text = "";
                menu.SetInteger("juego",4);
                camaraanim.SetInteger("juego",4);
            }
            if(juego == 5) 
            {
                al1.color = new Color32(255,64,64,255);
                log2.color = new Color32(229,213,74,255);
                adv3.color = new Color32(236,150,6,255);
                num4.color = new Color32(255,255,255,255);
                if(manager.datosconfig.idioma == "es")
                {
                adv3.text = "OPCIONES";
                }
                if(manager.datosconfig.idioma == "en")
                {
                adv3.text = "settings";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                adv3.text = "opcions";
                }
                num4.text = "";
                menu.SetInteger("juego",5);
                camaraanim.SetInteger("juego",5);
            }
            if(temp < 15)
            {temp += 1 * Time.deltaTime;}
            if (temp2 <= 12)
            {
                temp2 += 1 * Time.deltaTime;
            }
            if(presskip == false && temp2 > 10)
            {
                skip();
            }
    }
}
