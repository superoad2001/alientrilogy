using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inicio7base : MonoBehaviour
{


public float temp;
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
    public Text logo1;
    public Text logo2;
    public Text logo3;
    public Text logo4;
    public RectTransform logoo1;
    public GameObject logoo2;
    public GameObject logoo3;
    public GameObject logoo4;
    public int trofeo = 1;

    public int maxtrofeos = 28;
    public Text contador;
    public Text trofeost;
    public Text trofeostn;

    public int trofeos;

    public int iniciojuego = 1;
    public int finjuego = 21;

    public int alter = 1;


    public Text logo1t;
    public Text logo2t;
    public Text logo3t;
    public Text logo4t;
    public RectTransform logoo1t;
    public GameObject logoo2t;
    public GameObject logoo3t;
    public GameObject logoo4t;
    public void izq()
    {
        if(trofeo > iniciojuego)
        {trofeo -= 1;}
    }
    public void der()
    {
        if(trofeo < finjuego)
        {trofeo += 1;}
    }
    public void salir()
    {
        SceneManager.LoadScene("menutrilogy");
    }
    public void alt()
    {
        if(alter == 3)
        {
            alter = 1;
            iniciojuego = 1;
            finjuego = 21;
            trofeo = 1;
            logo1t.color = new Color32(255,64,64,255);
            logo2t.color = new Color32(229,213,74,255);
            logo3t.color = new Color32(255,64,64,255);
            logo4t.color = new Color32(229,213,74,255);
            logoo1t.transform.localPosition = new Vector3(347.5f,154f,0f);
            logoo2t.transform.localPosition = new Vector3(311.349976f,214.999985f,0f);
            logoo3t.transform.localPosition = new Vector3(314.500122f,72f,0f);
            logoo4t.transform.localPosition = new Vector3(296.500122f,0.999998093f,0f);
            logo3t.fontSize = 100;
            logo4t.fontSize = 82;
            logo3t.text = "ADVENTURE";
            logo4t.text = "";
        }
        else if(alter == 1)
        {
            alter = 2;
            iniciojuego = 22;
            finjuego = 51;
            trofeo = 22;
            logo1t.color = new Color32(255,64,64,255);
            logo2t.color = new Color32(229,213,74,255);
            logo3t.color = new Color32(255,64,64,255);
            logo4t.color = new Color32(229,213,74,255);
            logoo1t.transform.localPosition = new Vector3(328.5f,155f,0f);
            logoo2t.transform.localPosition = new Vector3(292.350037f,215.999985f,0f);
            logoo3t.transform.localPosition = new Vector3(295.500122f,73f,0f);
            logoo4t.transform.localPosition = new Vector3(277.500122f,-43.9999962f,0f);
            logo3t.fontSize = 100;
            logo4t.fontSize = 82;
            logo3t.text = "ADVENTURE";
            logo4t.text = "2";
        }
        else if(alter == 2)
        {
            alter = 3;
            iniciojuego = 52;
            finjuego = 103;
            trofeo = 52;
            logo1t.color = new Color32(255,0,239,255);
            logo2t.color = new Color32(229,213,74,255);
            logo3t.color = new Color32(66,255,68,255);
            logo4t.color = new Color32(255,255,255,255);
            logoo1t.transform.localPosition = new Vector3(247.499939f,113f,0f);
            logoo2t.transform.localPosition = new Vector3(211.349915f,278f,0f);
            logoo3t.transform.localPosition = new Vector3(211.5f,53f,0f);
            logoo4t.transform.localPosition = new Vector3(453.5f,173f,0f);
            logo3t.fontSize = 73;
            logo4t.fontSize = 289;
            logo3t.text = "ADVENTURE";
            logo4t.text = "3";
        }
    }
    // Start is called before the first frame update
    void Start()
    {


        logo1t.color = new Color32(255,64,64,255);
            logo2t.color = new Color32(229,213,74,255);
            logo3t.color = new Color32(255,64,64,255);
            logo4t.color = new Color32(229,213,74,255);
            logoo1t.transform.localPosition = new Vector3(347.5f,154f,0f);
            logoo2t.transform.localPosition = new Vector3(311.349976f,214.999985f,0f);
            logoo3t.transform.localPosition = new Vector3(314.500122f,72f,0f);
            logoo4t.transform.localPosition = new Vector3(296.500122f,0.999998093f,0f);
            logo3t.fontSize = 100;
            logo4t.fontSize = 82;
            logo3t.text = "ADVENTURE";
            logo4t.text = "";


        managerBASE manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));

    if(manager.datostrof.completaalien1v == 1)
    {trofeos++;}
    if(manager.datostrof.completaalien1m== 1)
    {trofeos++;}
    if(manager.datostrof.alien1huevooculto == 1)
    {trofeos++;}
    if(manager.datostrof.alien1muere == 1)
    {trofeos++;}
    if(manager.datostrof.alien1secretobajoelasteroide == 1)
    {trofeos++;}
    if(manager.datostrof.alien1saladelrey == 1)
    {trofeos++;}
    if(manager.datostrof.alien1salasecreta == 1)
    {trofeos++;}
    if(manager.datostrof.alien1mejora1 == 1)
    {trofeos++;}
    if(manager.datostrof.alien1mejora2 == 1)
    {trofeos++;}
    if(manager.datostrof.alien1mejora3 == 1)
    {trofeos++;}
    if(manager.datostrof.alien1mejora4 == 1)
    {trofeos++;}
    if(manager.datostrof.alien1mejora5 == 1)
    {trofeos++;}
    if(manager.datostrof.alien1consigue1gema == 1)
    {trofeos++;}
    if(manager.datostrof.alien1consigue10monedas == 1)
    {trofeos++;}
    if(manager.datostrof.alien1consigue50monedas == 1)
    {trofeos++;}
    if(manager.datostrof.alien1consiguelagrangema == 1)
    {trofeos++;}
    if(manager.datostrof.alien1consigue15gemas == 1)
    {trofeos++;}
    if(manager.datostrof.alien1usaelcochedelmundo == 1)
    {trofeos++;}
    if(manager.datostrof.alien1usalanaveenelespacio == 1)
    {trofeos++;}
    if(manager.datostrof.alien1visitaotroasteroide == 1)
    {trofeos++;}
    if(manager.datostrof.alien1primeracinematica == 1)
    {trofeos++;}
    if(manager.datostrof.completaalien2v == 1)
    {trofeos++;}
    if(manager.datostrof.completaalien3v == 1)
    {trofeos++;}
    if(manager.datostrof.alien2huevooculto == 1)
    {trofeos++;}
    if(manager.datostrof.alien2muere == 1)
    {trofeos++;}
    if(manager.datostrof.alien2ahorra1000monedas == 1)
    {trofeos++;}
    if(manager.datostrof.alien2obtentodaslasmejorasvida == 1)
    {trofeos++;}
    if(manager.datostrof.alien2saladelrey == 1)
    {trofeos++;}
    if(manager.datostrof.alien2compraentodaslastiendas1vez == 1)
    {trofeos++;}
    if(manager.datostrof.alien2sacaelfinalalternativo == 1)
    {trofeos++;}
    if(manager.datostrof.alien2mejora1 == 1)
    {trofeos++;}
    if(manager.datostrof.alien2mejora2 == 1)
    {trofeos++;}
    if(manager.datostrof.alien2mejora3 == 1)
    {trofeos++;}
    if(manager.datostrof.alien2mejora4 == 1)
    {trofeos++;}
    if(manager.datostrof.alien2mejora5 == 1)
    {trofeos++;}
    if(manager.datostrof.alien2hablarcontumujer == 1)
    {trofeos++;}
    if(manager.datostrof.alien2primeracinematica == 1)
    {trofeos++;}
    if(manager.datostrof.alien2unapaginadeldiario == 1)
    {trofeos++;}
    if(manager.datostrof.alien2consigue4llaves == 1)
    {trofeos++;}
    if(manager.datostrof.alien2consiguetodaslaspaginas == 1)
    {trofeos++;}
    if(manager.datostrof.alien2escuchaunapaginadeldiario == 1)
    {trofeos++;}
    if(manager.datostrof.alien2usaelcochedelmundo == 1)
    {trofeos++;}
    if(manager.datostrof.alien2hipnotizaunpirata == 1)
    {trofeos++;}
    if(manager.datostrof.alien2abrelatiendabloqueadadelaprimerazona == 1)
    {trofeos++;}
    if(manager.datostrof.alien2encuentralatiendaocultadelasegundazona == 1)
    {trofeos++;}
    if(manager.datostrof.alien2usalanavegumi == 1)
    {trofeos++;}
    if(manager.datostrof.alien2desbloqueatodosloscheckpoits == 1)
    {trofeos++;}
    if(manager.datostrof.alien2desbloqueaelcheckpoint1delnivel1 == 1)
    {trofeos++;}
    if(manager.datostrof.alien2usaelsaltador == 1)
    {trofeos++;}
    if(manager.datostrof.alien2usaelacelerador == 1)
    {trofeos++;}
    if(manager.datostrof.alien2usalanaveenelespacio == 1)
    {trofeos++;}
    if(manager.datostrof.completaalien2m == 1)
    {trofeos++;}
    if(manager.datostrof.completaalien3m == 1)
    {trofeos++;}
    if(manager.datostrof.alien3huevooculto == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consiguetodaslasarmas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3ahorra5000monedas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consiguetodaslasarmaduras == 1)
    {trofeos++;}
    if(manager.datostrof.alien3acabaeltutorial == 1)
    {trofeos++;}
    if(manager.datostrof.alien3vence100enemigos == 1)
    {trofeos++;}
    if(manager.datostrof.alien3vence200enemigos == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consiguetodadlasmejorasvida == 1)
    {trofeos++;}
    if(manager.datostrof.alien3gastatodalamuniciondetodaslasarmas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3muere == 1)
    {trofeos++;}
    if(manager.datostrof.alien3aceptalaherencia == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe1 == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe2 == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe3 == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe4 == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe5 == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe6 == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe1nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3jefe5nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3primeramejoradevida == 1)
    {trofeos++;}
    if(manager.datostrof.alien3primeraarma == 1)
    {trofeos++;}
    if(manager.datostrof.alien3primeraarmadura == 1)
    {trofeos++;}
    if(manager.datostrof.alien3entraalmenuextras == 1)
    {trofeos++;}
    if(manager.datostrof.alien3entraalaguiadelpause == 1)
    {trofeos++;}
    if(manager.datostrof.alien3entraaseleccionrapidaenelpause == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consiguetodaslaspaginas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3escuchaunapagina == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consigue10gemas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consigue20gemas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consigue40gemas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consigue70gemas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3consigue100gemas == 1)
    {trofeos++;}
    if(manager.datostrof.alien3compraladestructora == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta1nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta2nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta3nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta4nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta5nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta6nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta7nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta8nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta9nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta10nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta11nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta12nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta13nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta14nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta15nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta16nave == 1)
    {trofeos++;}
    if(manager.datostrof.alien3planeta17nave == 1)
    {trofeos++;}
        
    }

    // Update is called once per frame
    void Update()
    {
        managerBASE manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
        if(controles.al3.horizontalpad.ReadValue<float>() > 0 && temp > 0.3f)
        {
            der();
            temp = 0;
        }
        if(controles.al3.horizontalpad.ReadValue<float>() < 0 && temp > 0.3f)
        {
            izq();
            temp = 0;
        }
        if(manager.datosconfig.idioma == "es")
        {
            trofeost.text = "trofeos";
            trofeostn.text = "trofeo n"+trofeo;
            contador.text = "tienes "+trofeos+"/"+maxtrofeos;
            if(trofeo == 1) 
            {
                
                logo1.text = "comienza la aventura";
                logo2.text = "ve la primera cinematica de alien 1";
                if(manager.datostrof.alien1primeracinematica == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 2) 
            {
                
                logo1.text = "rapido como el viento";
                logo2.text = "consigue el acelerador";
                if(manager.datostrof.alien1mejora1 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 3) 
            {
                
                logo1.text = "licencia de conducir";
                logo2.text = "consigue el coche";
                if(manager.datostrof.alien1mejora2 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 4) 
            {
                
                logo1.text = "salto estratosferico";
                logo2.text = "consigue el saltador";
                if(manager.datostrof.alien1mejora3 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 5) 
            {
                
                logo1.text = "preparado";
                logo2.text = "consigue la nave";
                if(manager.datostrof.alien1mejora4 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 6) 
            {
                
                logo1.text = "con ganas de volver";
                logo2.text = "consigue el hyperpropulsor";
                if(manager.datostrof.alien1mejora5 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 7) 
            {
                
                logo1.text = "rico una vez";
                logo2.text = "consigue una gema";
                if(manager.datostrof.alien1consigue1gema == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 8) 
            {
                
                logo1.text = "ahorrador primerizo";
                logo2.text = "consigue 10 monedas";
                if(manager.datostrof.alien1consigue10monedas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 9) 
            {
                
                logo1.text = "coleccionista";
                logo2.text = "consigue 15 gemas";
                if(manager.datostrof.alien1consigue15gemas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 10) 
            {
                
                logo1.text = "adicto al dinero";
                logo2.text = "consigue 50 monedas";
                if(manager.datostrof.alien1consigue50monedas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 11) 
            {
                
                logo1.text = "piedra precisoa";
                logo2.text = "consigue la gran gema";
                if(manager.datostrof.alien1consiguelagrangema == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 12) 
            {
                
                logo1.text = "conductor novato";
                logo2.text = "usa el coche en el asteroide";
                if(manager.datostrof.alien1usaelcochedelmundo == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 13) 
            {
                
                logo1.text = "piloto novato";
                logo2.text = "usa la nave en el espacio";
                if(manager.datostrof.alien1usalanaveenelespacio == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 14) 
            {
                
                logo1.text = "explorador espacial";
                logo2.text = "visita otro asteroide";
                if(manager.datostrof.alien1visitaotroasteroide == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 15) 
            {
                
                logo1.text = "me conformo pero y si...";
                logo2.text = "consigue el final basico de alien 1";
                if(manager.datostrof.completaalien1m == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 16) 
            {
                
                logo1.text = "me gustan los finales felices";
                logo2.text = "consigue el final verdadero de alien 1";
                if(manager.datostrof.completaalien1v == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 17) 
            {
                
                logo1.text = "el placer de morir una vez";
                logo2.text = "muere una vez en alien 1";
                if(manager.datostrof.alien1muere == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 18) 
            {
                
                logo1.text = "rey goloso";
                logo2.text = "encuentra el huevo de pascua en alien 1";
                if(manager.datostrof.alien1huevooculto == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 19) 
            {
                
                logo1.text = "el rey espera";
                logo2.text = "visita la sala del rey en alien 1";
                if(manager.datostrof.alien1saladelrey == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 20) 
            {
                
                logo1.text = "secretos en el universo";
                logo2.text = "entra a la sala secreta tal vez deberias batir los records del rey el te espera en alien 1";
                if(manager.datostrof.alien1salasecreta == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 21) 
            {
                
                logo1.text = "explorador nato";
                logo2.text = "hecha un vistazo en la villa de asteroides en alien 1";
                if(manager.datostrof.alien1secretobajoelasteroide == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }



            if(trofeo == 22) 
            {
                
                logo1.text = "no me e rendido";
                logo2.text = "ve la primera cinematica en alien2";
                if(manager.datostrof.alien2primeracinematica == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 23) 
            {
                
                logo1.text = "la muerte me odia";
                logo2.text = "desbloquea un checkpoint";
                if(manager.datostrof.alien2desbloqueaelcheckpoint1delnivel1 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 24) 
            {
                
                logo1.text = "conserje";
                logo2.text = "consigue 4 llaves";
                if(manager.datostrof.alien2consigue4llaves == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 25) 
            {
                
                logo1.text = "recopilador accidentado";
                logo2.text = "consigue una pagina del diario";
                if(manager.datostrof.alien2unapaginadeldiario == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 26) 
            {
                
                logo1.text = "escucha una historia";
                logo2.text = "escucha una pagina del diario";
                if(manager.datostrof.alien2escuchaunapaginadeldiario == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 27) 
            {
                
                logo1.text = "recopilador de informacion";
                logo2.text = "consigue todas las paginas del diario";
                if(manager.datostrof.alien2consiguetodaslaspaginas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 28) 
            {
                
                logo1.text = "discusiones de pareja";
                logo2.text = "habla con tu esposa en la isla";
                if(manager.datostrof.alien2hablarcontumujer == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 29) 
            {
                
                logo1.text = "amigo de la muerte";
                logo2.text = "desbloquea todos los checkpoints";
                if(manager.datostrof.alien2desbloqueatodosloscheckpoits == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 30) 
            {
                
                logo1.text = "explorador pensante";
                logo2.text = "abre la tienda de la primera zona";
                if(manager.datostrof.alien2abrelatiendabloqueadadelaprimerazona == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 31) 
            {
                
                logo1.text = "explorador curioso";
                logo2.text = "encuentra la tienda oculta de la segunda zona";
                if(manager.datostrof.alien2encuentralatiendaocultadelasegundazona == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 32) 
            {
                
                logo1.text = "botas especiales";
                logo2.text = "consigue el salto doble";
                if(manager.datostrof.alien2mejora1 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 33) 
            {
                
                logo1.text = "permiso para matar";
                logo2.text = "consigue la pistola";
                if(manager.datostrof.alien2mejora2 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 34) 
            {
                
                logo1.text = "licecia descaducada";
                logo2.text = "conisgue el coche";
                if(manager.datostrof.alien2mejora3 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 35) 
            {
                
                logo1.text = "artilugio extraño";
                logo2.text = "consigue el hipnotizador";
                if(manager.datostrof.alien2mejora4 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 36) 
            {
                
                logo1.text = "recuperando lo mio";
                logo2.text = "consigue la nave";
                if(manager.datostrof.alien2mejora5 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 37) 
            {
                
                logo1.text = "corredor experto";
                logo2.text = "usa el aclerador";
                if(manager.datostrof.alien2usaelacelerador == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 38) 
            {
                
                logo1.text = "saltador experto";
                logo2.text = "usa el saltador";
                if(manager.datostrof.alien2usaelsaltador == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 39) 
            {
                
                logo1.text = "conductor experimentado";
                logo2.text = "usa el coche en el mundo abierto";
                if(manager.datostrof.alien2usaelcochedelmundo == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 40) 
            {
                
                logo1.text = "manipulador";
                logo2.text = "hipnotiza un pirata";
                if(manager.datostrof.alien2hipnotizaunpirata == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 41) 
            {
                
                logo1.text = "piloto experiementado";
                logo2.text = "sobrevuela el mundo con la nave";
                if(manager.datostrof.alien2usalanaveenelespacio == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 42) 
            {
                
                logo1.text = "esta nave la e visto antes";
                logo2.text = "usa una nave que es una referencia";
                if(manager.datostrof.alien2usalanavegumi == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 43) 
            {
                
                logo1.text = "morir no es lo que queria";
                logo2.text = "consigue el final malo de alien 2";
                if(manager.datostrof.completaalien2m == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 44) 
            {
                
                logo1.text = "vivieron felices y comieron perdices";
                logo2.text = "consigue el final bueno de alien 2";
                if(manager.datostrof.completaalien2v == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 45) 
            {
                
                logo1.text = "padre ahorrador";
                logo2.text = "ahorra 1000 monedas en alien 2";
                if(manager.datostrof.alien2ahorra1000monedas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 46) 
            {
                
                logo1.text = "derrochador";
                logo2.text = "compra almenos un articulo en cada caseta en alien 2";
                if(manager.datostrof.alien2compraentodaslastiendas1vez == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 47) 
            {
                
                logo1.text = "reyes caprichosos";
                logo2.text = "encuentra el huevo de pascua de alien 2";
                if(manager.datostrof.alien2huevooculto == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 48) 
            {
                
                logo1.text = "morir es vivir";
                logo2.text = "muere una vez en alien2";
                if(manager.datostrof.alien2muere == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 49) 
            {
                
                logo1.text = "buena salud";
                logo2.text = "alanza el limite de vida en alien2";
                if(manager.datostrof.alien2obtentodaslasmejorasvida == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 50) 
            {
                
                logo1.text = "creo que olvido algo";
                logo2.text = "saca el final alternativo en el combate contra el rey pirata en alien 2";
                if(manager.datostrof.alien2sacaelfinalalternativo == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 51) 
            {
                
                logo1.text = "se puede ver al rey una segunda vez";
                logo2.text = "entra en la sala del rey en alien 2";
                if(manager.datostrof.alien2saladelrey == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }




            if(trofeo == 52) 
            {
                
                logo1.text = "esto no tiene gracia";
                logo2.text = "vence a los robots clonicos";
                if(manager.datostrof.alien3jefe1 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 53) 
            {
                
                logo1.text = "pequeño pero maton";
                logo2.text = "vence al guardian de oro";
                if(manager.datostrof.alien3jefe2 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 54) 
            {
                
                logo1.text = "prometo la revancha";
                logo2.text = "vence al encorbado una vez";
                if(manager.datostrof.alien3jefe3 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 55) 
            {
                
                logo1.text = "por encima de un dios";
                logo2.text = "vence a la deidad";
                if(manager.datostrof.alien3jefe4 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 56) 
            {
                
                logo1.text = "mi venganza";
                logo2.text = "vence al encorbado por segunda vez";
                if(manager.datostrof.alien3jefe5 == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 57) 
            {
                
                logo1.text = "el fin de una historia";
                logo2.text = "vence a la deidad espejo";
                if(manager.datostrof.alien3jefe6== 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 58) 
            {
                
                logo1.text = "aviador novato";
                logo2.text = "gana un combate con la nave";
                if(manager.datostrof.alien3jefe1nave== 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 59) 
            {
                
                logo1.text = "experto aviador";
                logo2.text = "vence al encorbado con la nave";
                if(manager.datostrof.alien3jefe5nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 60) 
            {
                
                logo1.text = "me congelo";
                logo2.text = "visita hielilandia";
                if(manager.datostrof.alien3planeta1nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 61) 
            {
                
                logo1.text = "campos y montañas";
                logo2.text = "visita villa soleada";
                if(manager.datostrof.alien3planeta2nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 62) 
            {
                
                logo1.text = "guarida oculta";
                logo2.text = "visita cometa2274";
                if(manager.datostrof.alien3planeta3nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 63) 
            {
                
                logo1.text = "cerca de un volcan";
                logo2.text = "visita magmacity";
                if(manager.datostrof.alien3planeta4nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 64) 
            {
                
                logo1.text = "hundido en el foso";
                logo2.text = "visita prision planet";
                if(manager.datostrof.alien3planeta5nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 65) 
            {
                
                logo1.text = "minas de oro";
                logo2.text = "visita orotopia";
                if(manager.datostrof.alien3planeta6nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 66) 
            {
                
                logo1.text = "luna morada";
                logo2.text = "visita luna morada";
                if(manager.datostrof.alien3planeta7nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 67) 
            {
                
                logo1.text = "fortaleza enemiga";
                logo2.text = "visita fortaleza ardiente";
                if(manager.datostrof.alien3planeta8nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 68) 
            {
                
                logo1.text = "lugar varado";
                logo2.text = "visita asteroide 7248";
                if(manager.datostrof.alien3planeta9nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 69) 
            {
                
                logo1.text = "de vacaciones";
                logo2.text = "visita pokitaplaya";
                if(manager.datostrof.alien3planeta10nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 70) 
            {
                
                logo1.text = "ciudad salvaje";
                logo2.text = "visita tropicaltown";
                if(manager.datostrof.alien3planeta11nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 71) 
            {
                
                logo1.text = "cerca del final";
                logo2.text = "visita planeta X";
                if(manager.datostrof.alien3planeta12nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 72) 
            {
                
                logo1.text = "guarida abandonada";
                logo2.text = "visita fortaleza abandonada";
                if(manager.datostrof.alien3planeta13nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 73) 
            {
                
                logo1.text = "futuro hogar";
                logo2.text = "visita nuevo hogar";
                if(manager.datostrof.alien3planeta14nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 74) 
            {
                
                logo1.text = "el hijo regresa a casa";
                logo2.text = "visita viejo hogar";
                if(manager.datostrof.alien3planeta15nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 75) 
            {
                
                logo1.text = "recurdos de otro";
                logo2.text = "asteroide oculto";
                if(manager.datostrof.alien3planeta16nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 76) 
            {
                
                logo1.text = "al filo del final";
                logo2.text = "mundo final";
                if(manager.datostrof.alien3planeta17nave == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 77) 
            {
                
                logo1.text = "aprendiendo";
                logo2.text = "entra al menu guia";
                if(manager.datostrof.alien3entraalaguiadelpause == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 78) 
            {
                
                logo1.text = "por curiosidad";
                logo2.text = "entra al menu de extras";
                if(manager.datostrof.alien3entraalmenuextras == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 79) 
            {
                
                logo1.text = "dinamismo";
                logo2.text = "hecha un vistazo a la seleccion rapida";
                if(manager.datostrof.alien3entraaseleccionrapidaenelpause == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 80) 
            {
                
                logo1.text = "mi padre tenia 15 queda poco";
                logo2.text = "consigue 10 gemas";
                if(manager.datostrof.alien3consigue10gemas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 81) 
            {
                
                logo1.text = "energia pa mi jetpack";
                logo2.text = "consigue 20 gemas";
                if(manager.datostrof.alien3consigue20gemas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 82) 
            {
                
                logo1.text = "necesito mas energia";
                logo2.text = "consigue 40 gemas";
                if(manager.datostrof.alien3consigue40gemas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 83) 
            {
                
                logo1.text = "energia nuclear";
                logo2.text = "consigue 70 gemas";
                if(manager.datostrof.alien3consigue70gemas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 84) 
            {
                
                logo1.text = "monpolio energetico";
                logo2.text = "consigue 100 gemas";
                if(manager.datostrof.alien3consigue100gemas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
             if(trofeo == 85) 
            {
                
                logo1.text = "necesito la ubicacion";
                logo2.text = "consigue todas las paginas del diario";
                if(manager.datostrof.alien3consiguetodaslaspaginas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            


            if(trofeo == 86) 
            {
                
                logo1.text = "cotilla";
                logo2.text = "escucha una pagina del diario";
                if(manager.datostrof.alien3escuchaunapagina == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }          
            if(trofeo == 87) 
            {
                
                logo1.text = "se avecina un tormenta";
                logo2.text = "consigue el final basico de alien 3";
                if(manager.datostrof.completaalien3m == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 88) 
            {
                
                logo1.text = "futuro misterioso";
                logo2.text = "consigue el final verdadero de alien 3";
                if(manager.datostrof.completaalien3v == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 89) 
            {
                
                logo1.text = "promesa de venganza";
                logo2.text = "huye de la aldea abandonada en alien 3";
                if(manager.datostrof.alien3acabaeltutorial == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 90) 
            {
                
                logo1.text = "herencia";
                logo2.text = "recuperala herencia del cadaver de tu padre en la aldea abandonada en alien 3";
                if(manager.datostrof.alien3aceptalaherencia == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 91) 
            {
                
                logo1.text = "hijo ahorrador";
                logo2.text = "ahorra 5000 monedas en total en alien 3";
                if(manager.datostrof.alien3ahorra5000monedas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 92) 
            {
                
                logo1.text = "armado y preparado";
                logo2.text = "consigue un arma";
                if(manager.datostrof.alien3primeraarma == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 93) 
            {
                
                logo1.text = "primera defensa";
                logo2.text = "consigue una armadura";
                if(manager.datostrof.alien3primeraarmadura == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 94) 
            {
                
                logo1.text = "primer paso";
                logo2.text = "consigue una mejora de vida";
                if(manager.datostrof.alien3primeramejoradevida == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 95) 
            {
                
                logo1.text = "salud de hierro";
                logo2.text = "recoje todas las mejoras de vida 3n alien 3";
                if(manager.datostrof.alien3consiguetodadlasmejorasvida == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 96) 
            {
                
                logo1.text = "estan todos muertos";
                logo2.text = "compra la destructora";
                if(manager.datostrof.alien3compraladestructora == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
            }
            if(trofeo == 97) 
            {
                
                logo1.text = "caballero";
                logo2.text = "obten todas las armaduras en alien 3";
                if(manager.datostrof.alien3consiguetodaslasarmaduras == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            
            if(trofeo == 98) 
            {
                
                logo1.text = "guerrero";
                logo2.text = "obten todas las armas en alien 3";
                if(manager.datostrof.alien3consiguetodaslasarmas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 99) 
            {
                
                logo1.text = "hasta que no quede ni una";
                logo2.text = "obten todas las armas y vacia todos los cargadores en alien 3";
                if(manager.datostrof.alien3gastatodalamuniciondetodaslasarmas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 100) 
            {
                
                logo1.text = "la trotilla del rey";
                logo2.text = "consigue el juevo de pascua oculto en alien 3";
                if(manager.datostrof.alien3huevooculto == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 101) 
            {
                
                logo1.text = "tal palo tal astilla";
                logo2.text = "muere una vez en alien 3";
                if(manager.datostrof.alien3muere == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 102) 
            {
                
                logo1.text = "asesino en serie";
                logo2.text = "mata 100 enemigos en alien 3";
                if(manager.datostrof.alien3vence100enemigos == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }
            if(trofeo == 103) 
            {
                
                logo1.text = "asesino en masa";
                logo2.text = "mata 200 enemigos en alien 3";
                if(manager.datostrof.alien3vence200enemigos == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "conseguido";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no conseguido";
                }
                
            }

        }
        if(manager.datosconfig.idioma == "en")
        {
        trofeost.text = "trophies";
        trofeostn.text = "n-trofeo"+trofeo;
        contador.text = "you have "+trofeos+"/"+maxtrofeos;
        if(trofeo == 1)
        {

        logo1.text = "the adventure begins";
        logo2.text = "watch the first Alien 1 movie";
        if(manager.datostrof.alien1primeracinematica == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 2)
        {

        logo1.text = "fast as the wind";
        logo2.text = "get the throttle";
        if(manager.datostrof.alien1mejora1 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 3)
        {

        logo1.text = "driver's license";
        logo2.text = "get the car";
        if(manager.datostrof.alien1mejora2 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 4)
        {

        logo1.text = "stratospheric jump";
        logo2.text = "get the jumper";
        if(manager.datostrof.alien1mejora3 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 5)
        {

        logo1.text = "ready";
        logo2.text = "get the ship";
        if(manager.datostrof.alien1mejora4 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 6)
        {

        logo1.text = "looking forward to coming back";
        logo2.text = "get the hyperdrive";
        if(manager.datostrof.alien1mejora5 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 7)
        {

        logo1.text = "rich once";
        logo2.text = "get a gem";
        if(manager.datostrof.alien1consigue1gema == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 8)
        {

        logo1.text = "first-time saver";
        logo2.text = "get 10 coins";
        if(manager.datostrof.alien1consigue10monedas == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 9)
        {

        logo1.text = "collector";
        logo2.text = "get 15 gems";
        if(manager.datostrof.alien1consigue15gemas == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 10)
        {

        logo1.text = "addicted to money";
        logo2.text = "get 50 coins";
        if(manager.datostrof.alien1consigue50monedas == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 11)
        {

        logo1.text = "precise stone";
        logo2.text = "get the big gem";
        if(manager.datostrof.alien1consiguelagrangema == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 12)
        {

        logo1.text = "novice driver";
        logo2.text = "use the car on the asteroid";
        if(manager.datostrof.alien1usaelcochedelmundo== 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 13)
        {

        logo1.text = "rookie pilot";
        logo2.text = "use the ship in space";
        if(manager.datostrof.alien1usalanaveenelespacio == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 14)
        {

        logo1.text = "space explorer";
        logo2.text = "visit another asteroid";
        if(manager.datostrof.alien1visitaotroasteroide == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 15)
        {

        logo1.text = "I agree but what if...";
        logo2.text = "get the basic ending of Alien 1";
        if(manager.datostrof.completaalien1m == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 16)
        {

        logo1.text = "I like happy endings";
        logo2.text = "get the true ending of Alien 1";
        if(manager.datostrof.completaalien1v == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 17)
        {

        logo1.text = "the pleasure of dying once";
        logo2.text = "die once in Alien 1";
        if(manager.datostrof.alien1muere == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 18)
        {

        logo1.text = "sweet tooth king";
        logo2.text = "find the Easter egg in alien 1";
        if(manager.datostrof.alien1huevooculto == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 19)
        {

        logo1.text = "the king is waiting";
        logo2.text = "visit the King's room in alien 1";
        if(manager.datostrof.alien1saladelrey == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 20)
        {

        logo1.text = "secrets in the universe";
        logo2.text = "enter the secret room maybe you should break the king's records he's waiting for you in alien 1";
        if(manager.datostrof.alien1salasecreta == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 21)
        {

        logo1.text = "born explorer";
        logo2.text = "take a look at the asteroid village in alien 1";
        if(manager.datostrof.alien1secretobajoelasteroide == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }



        if(trofeo == 22)
        {

        logo1.text = "I have not given up";
        logo2.text = "watch the first cinematic on alien2";
        if(manager.datostrof.alien2primeracinematica == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 23)
        {

        logo1.text = "death hates me";
        logo2.text = "unblock a checkpoint";
        if(manager.datostrof.alien2desbloqueaelcheckpoint1delnivel1 ==1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 24)
        {

        logo1.text = "concierge";
        logo2.text = "get 4 keys";
        if(manager.datostrof.alien2consigue4llaves == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 25)
        {

        logo1.text = "crashed collector";
        logo2.text = "get a page from the diary";
        if(manager.datostrof.alien2unapaginadeldiario == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 26)
        {

        logo1.text = "listen to a story";
        logo2.text = "listen to a page of the diary";
        if(manager.datostrof.alien2escuchaunapaginadeldiario == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 27)
        {

        logo1.text = "information collector";
        logo2.text = "get all the pages of the diary";
        if(manager.datostrof.alien2consiguetodaslaspaginas == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 28)
        {

        logo1.text = "couple discussions";
        logo2.text = "talk to your wife on the island";
        if(manager.datostrof.alien2hablarcontumujer == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 29)
        {

        logo1.text = "friend of death";
        logo2.text = "unlock all the checkpoints";
        if(manager.datostrof.alien2desbloqueatodosloscheckpoits == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 30)
        {

        logo1.text = "thinking explorer";
        logo2.text = "open the store in the first area";
        if(manager.datostrof.alien2abrelatiendabloqueadadelaprimerazona == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 31)
        {

        logo1.text = "curious explorer";
        logo2.text = "find the hidden store in the second zone";
        if(manager.datostrof.alien2encuentralatiendaocultadelasegundazona == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 32)
        {

        logo1.text = "special boots";
        logo2.text = "get the double jump";
        if(manager.datostrof.alien2mejora1 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 33)
        {

        logo1.text = "permission to kill";
        logo2.text = "get the gun";
        if(manager.datostrof.alien2mejora2 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 34)
        {

        logo1.text = "licecia descaducada";
        logo2.text = "take the car";
        if(manager.datostrof.alien2mejora3 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 35)
        {

        logo1.text = "strange gadget";
        logo2.text = "get the hypnotist";
        if(manager.datostrof.alien2mejora4 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 36)
        {

        logo1.text = "recuperando lo mio";
        logo2.text = "get the ship";
        if(manager.datostrof.alien2mejora5 == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 37)
        {

        logo1.text = "expert broker";
        logo2.text = "use the aclerator";
        if(manager.datostrof.alien2usaelacelerador == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 38)
        {

        logo1.text = "expert jumper";
        logo2.text = "use the jumper";
        if(manager.datostrof.alien2usaelsaltador == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 39)
        {

        logo1.text = "experienced driver";
        logo2.text = "use the car in the open world";
        if(manager.datostrof.alien2usaelcochedelmundo == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 40)
        {

        logo1.text = "manipulative";
        logo2.text = "hypnotize a pirate";
        if(manager.datostrof.alien2hipnotizaunpirata == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 41)
        {

        logo1.text = "experienced pilot";
        logo2.text = "fly over the world with the ship";
        if(manager.datostrof.alien2usalanaveenelespacio == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 42)
        {

        logo1.text = "I've seen this ship before";
        logo2.text = "use a ship that is a reference";
        if(manager.datostrof.alien2usalanavegumi == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }
        }
        if(trofeo == 43)
        {

        logo1.text = "dying is not what I wanted";
        logo2.text = "get the bad ending of Alien 2";
        if(manager.datostrof.completaalien2m == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 44)
        {

        logo1.text = "they lived happily and ate partridges";
        logo2.text = "get the good ending of Alien 2";
        if(manager.datostrof.completaalien2v == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 45)
        {

        logo1.text = "thrifty dad";
        logo2.text = "save 1000 coins in alien 2";
        if(manager.datostrof.alien2ahorra1000monedas == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 46)
        {

        logo1.text = "wasteful";
        logo2.text = "buy at least one item at each booth in alien 2";
        if(manager.datostrof.alien2compraentodaslastiendas1vez == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 47)
        {

        logo1.text = "capricious kings";
        logo2.text = "find the Easter egg from alien 2";
        if(manager.datostrof.alien2huevooculto == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 48)
        {

        logo1.text = "to die is to live";
        logo2.text = "die once in alien2";
        if(manager.datostrof.alien2muere == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 49)
        {

        logo1.text = "good health";
        logo2.text = "raise the life limit in alien2";
        if(manager.datostrof.alien2obtentodaslasmejorasvida == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

        }
        if(trofeo == 50)
        {

        logo1.text = "I think I'm forgetting something";
        logo2.text = "bring out the alternate ending in the fight against the pirate king in alien 2";
        if(manager.datostrof.alien2sacaelfinalalternativo == 1)
        {
        logo3.color = new Color32(24,255,0,255);
        logo3.text = "achieved";
        }
        else
        {
        logo3.color = new Color32(255,28,0,255);
        logo3.text = "not achieved";
        }

                
            }
            if(trofeo == 51)
            {

            logo1.text = "you can see the king a second time";
            logo2.text = "enter the King's room in alien 2";
            if(manager.datostrof.alien2saladelrey == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }




            if(trofeo == 52)
            {

            logo1.text = "this is not funny";
            logo2.text = "beat the clonic robots";
            if(manager.datostrof.alien3jefe1 == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 53)
            {

            logo1.text = "small but bully";
            logo2.text = "beat the golden guardian";
            if(manager.datostrof.alien3jefe2 == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 54)
            {

            logo1.text = "I promise the rematch";
            logo2.text = "beat the slouch once";
            if(manager.datostrof.alien3jefe3 == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 55)
            {

            logo1.text = "above a god";
            logo2.text = "defeat the deity";
            if(manager.datostrof.alien3jefe4 == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 56)
            {

            logo1.text = "my revenge";
            logo2.text = "beat the slouch for the second time";
            if(manager.datostrof.alien3jefe5 == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 57)
            {

            logo1.text = "the end of a story";
            logo2.text = "defeat the mirror deity";
            if(manager.datostrof.alien3jefe6== 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 58)
            {

            logo1.text = "rookie aviator";
            logo2.text = "win a battle with the ship";
            if(manager.datostrof.alien3jefe1nave== 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 59)
            {

            logo1.text = "expert aviator";
            logo2.text = "beat the slouch with the ship";
            if(manager.datostrof.alien3jefe5nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 60)
            {

            logo1.text = "I'm freezing";
            logo2.text = "visit hieliland";
            if(manager.datostrof.alien3planeta1nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 61)
            {

            logo1.text = "fields and mountains";
            logo2.text = "visit sunny villa";
            if(manager.datostrof.alien3planeta2nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 62)
            {

            logo1.text = "hidden lair";
            logo2.text = "visit cometa2274";
            if(manager.datostrof.alien3planeta3nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 63)
            {

            logo1.text = "near a volcano";
            logo2.text = "visit magmacity";
            if(manager.datostrof.alien3planeta4nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 64)
            {

            logo1.text = "sunk in the pit";
            logo2.text = "visit prison planet";
            if(manager.datostrof.alien3planeta5nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 65)
            {

            logo1.text = "gold mines";
            logo2.text = "visit Orotopia";
            if(manager.datostrof.alien3planeta6nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 66)
            {

            logo1.text = "purple moon";
            logo2.text = "visit purple moon";
            if(manager.datostrof.alien3planeta7nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 67)
            {

            logo1.text = "enemy fortress";
            logo2.text = "visit burning fortress";
            if(manager.datostrof.alien3planeta8nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
                        if(trofeo == 68)
            {

            logo1.text = "stranded place";
            logo2.text = "visit asteroid 7248";
            if(manager.datostrof.alien3planeta9nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 69)
            {

            logo1.text = "on vacation";
            logo2.text = "visit pokitaplaya";
            if(manager.datostrof.alien3planeta10nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 70)
            {

            logo1.text = "wild city";
            logo2.text = "visit tropicaltown";
            if(manager.datostrof.alien3planeta11nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 71)
            {

            logo1.text = "near the end";
            logo2.text = "visit Planet X";
            if(manager.datostrof.alien3planeta12nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 72)
            {

            logo1.text = "abandoned lair";
            logo2.text = "visit abandoned fortress";
            if(manager.datostrof.alien3planeta13nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 73)
            {

            logo1.text = "future home";
            logo2.text = "visit new home";
            if(manager.datostrof.alien3planeta14nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 74)
            {

            logo1.text = "the son is coming home";
            logo2.text = "visit old home";
            if(manager.datostrof.alien3planeta15nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 75)
            {

            logo1.text = "recurred from another";
            logo2.text = "hidden asteroid";
            if(manager.datostrof.alien3planeta16nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 76)
            {

            logo1.text = "on the edge of the end";
            logo2.text = "final world";
            if(manager.datostrof.alien3planeta17nave == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 77)
            {

            logo1.text = "learning";
            logo2.text = "enter the guide menu";
            if(manager.datostrof.alien3entraalaguiadelpause == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 78)
            {

            logo1.text = "out of curiosity";
            logo2.text = "enter the extras menu";
            if(manager.datostrof.alien3entraalmenuextras == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 79)
            {

            logo1.text = "dynamism";
            logo2.text = "take a look at the quick selection";
            if(manager.datostrof.alien3entraaseleccionrapidaenelpause == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 80)
            {

            logo1.text = "my father was 15 there is little left";
            logo2.text = "get 10 gems";
            if(manager.datostrof.alien3consigue10gemas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 81)
            {

            logo1.text = "energia pa mi jetpack";
            logo2.text = "get 20 gems";
            if(manager.datostrof.alien3consigue20gemas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 82)
            {

            logo1.text = "I need more energy";
            logo2.text = "get 40 gems";
            if(manager.datostrof.alien3consigue40gemas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 83)
            {

            logo1.text = "nuclear energy";
            logo2.text = "get 70 gems";
            if(manager.datostrof.alien3consigue70gemas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 84)
            {

            logo1.text = "monpolio energetico";
            logo2.text = "get 100 gems";
            if(manager.datostrof.alien3consigue100gemas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 85)
            {

            logo1.text = "I need the location";
            logo2.text = "get all the pages of the diary";
            if(manager.datostrof.alien3consiguetodaslaspaginas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }



            if(trofeo == 86)
            {

            logo1.text = "gossip";
            logo2.text = "listen to a page of the diary";
            if(manager.datostrof.alien3escuchaunapagina == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 87)
            {

            logo1.text = "a storm is coming";
            logo2.text = "get the basic ending of Alien 3";
            if(manager.datostrof.completaalien3m == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 88)
            {

            logo1.text = "mysterious future";
            logo2.text = "get the true ending of Alien 3";
            if(manager.datostrof.completaalien3v == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 89)
            {

            logo1.text = "promise of revenge";
            logo2.text = "run away from the abandoned village in alien 3";
            if(manager.datostrof.alien3acabaeltutorial == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 90)
            {

            logo1.text = "inheritance";
            logo2.text = "retrieve the inheritance from your father's corpse in the abandoned village in alien 3";
            if(manager.datostrof.alien3aceptalaherencia == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 91)
            {

            logo1.text = "thrifty son";
            logo2.text = "save 5000 coins in total on alien 3";
            if(manager.datostrof.alien3ahorra5000monedas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 92)
            {

            logo1.text = "armed and ready";
            logo2.text = "get a gun";
            if(manager.datostrof.alien3primeraarma == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 93)
            {

            logo1.text = "first defense";
            logo2.text = "get a suit of armor";
            if(manager.datostrof.alien3primeraarmadura == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 94)
            {

            logo1.text = "first step";
            logo2.text = "get a better life";
            if(manager.datostrof.alien3primeramejoradevida == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 95)
            {

            logo1.text = "iron health";
            logo2.text = "collect all 3n alien 3 life upgrades";
            if(manager.datostrof.alien3consiguetodadlasmejorasvida == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 96)
            {

            logo1.text = "they're all dead";
            logo2.text = "buy the shredder";
            if(manager.datostrof.alien3compraladestructora == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }
            }
            if(trofeo == 97)
            {

            logo1.text = "gentleman";
            logo2.text = "get all the armor in Alien 3";
            if(manager.datostrof.alien3consiguetodaslasarmaduras == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }

            if(trofeo == 98)
            {

            logo1.text = "warrior";
            logo2.text = "get all the weapons in Alien 3";
            if(manager.datostrof.alien3consiguetodaslasarmas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 99)
            {

            logo1.text = "until there is not one left";
            logo2.text = "get all the weapons and empty all the magazines in alien 3";
            if(manager.datostrof.alien3gastatodalamuniciondetodaslasarmas == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 100)
            {

            logo1.text = "the King's trotter";
            logo2.text = "get the hidden Easter egg in Alien 3";
            if(manager.datostrof.alien3huevooculto == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
                        if(trofeo == 101)
            {

            logo1.text = "like father like son";
            logo2.text = "die once in Alien 3";
            if(manager.datostrof.alien3muere == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 102)
            {

            logo1.text = "serial killer";
            logo2.text = "kill 100 enemies in Alien 3";
            if(manager.datostrof.alien3vence100enemigos == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }
            if(trofeo == 103)
            {

            logo1.text = "mass murderer";
            logo2.text = "kill 200 enemies in Alien 3";
            if(manager.datostrof.alien3vence200enemigos == 1)
            {
            logo3.color = new Color32(24,255,0,255);
            logo3.text = "achieved";
            }
            else
            {
            logo3.color = new Color32(255,28,0,255);
            logo3.text = "not achieved";
            }

            }

        }
        if(manager.datosconfig.idioma == "cat")
        {
            trofeost.text = "trofeus";
            trofeostn.text = "trofeu n"+trofeo;
            contador.text = "tens "+trofeos+"/"+maxtrofeos;
            if(trofeo == 1)
            {

            logo1.text = "comença l'aventura";
            logo2.text = "mira la Primera Pel * lícula D'Alien 1";
            if (manager.datostrof.alien1primeracinematica == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 2)
            {

            logo1.text = "ràpid com el vent";
            logo2.text = "aconsegueix l'accelerador";
            if (manager.datostrof.alien1mejora1 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 3)
            {

            logo1.text = "llicència de conduir";
            logo2.text = "agafa el cotxe";
            if (manager.datostrof.alien1mejora2 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 4)
            {

            logo1.text = "salt estratosfèric";
            logo2.text = "aconsegueix el pont";
            if (manager.datostrof.alien1mejora3 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 5)
            {

            logo1.text = "llest";
            logo2.text = "aconsegueix el vaixell";
            if (manager.datostrof.alien1mejora4 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 6)
            {

            logo1.text = "amb ganes de tornar";
            logo2.text = "obteniu l'hiperdrive";
            if (manager.datostrof.alien1mejora5 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 7)
            {

            logo1.text = "ric una vegada";
            logo2.text = "aconsegueix una joia";
            if (manager.datostrof.alien1consigue1gema == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 8)
            {

            logo1.text = "primer estalvi de temps";
            logo2.text = "obtenir 10 monedes";
            if (manager.datostrof.alien1consigue10monedas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if(trofeo == 9)
            {

            logo1.text = "coleccionista";
            logo2.text = "aconsegueix 15 gemmes";
            if (manager.datostrof.alien1consigue15gemas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 10)
            {

            logo1.text = "addicte als diners";
            logo2.text = "obtenir 50 monedes";
            if (manager.datostrof.alien1consigue50monedas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 11)
            {

            logo1.text = "pedra precisa";
            logo2.text = "aconsegueix la gran joia";
            if (manager.datostrof.alien1consiguelagrangema == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 12)
            {

            logo1.text = "controlador novell";
            logo2.text = "utilitza el cotxe a l'asteroide";
            if (manager.datostrof.alien1usaelcochedelmundo == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 13)
            {

            logo1.text = "pilot novell";
            logo2.text = "utilitza la nau a l'espai";
            if (manager.datostrof.alien1usalanaveenelespacio == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 14)
            {

            logo1.text = "explorador espacial";
            logo2.text = "visiteu un altre asteroide";
            if (manager.datostrof.alien1visitaotroasteroide == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 15)
            {

            logo1.text = " estic d'acord, però i si...";
            logo2.text = "obteniu el final bàsic d'Alien 1";
            if (manager.datostrof.completaalien1m == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 16)
            {

            logo1.text = "m'agraden els finals feliços";
            logo2.text = "obteniu el veritable final D'Alien 1";
            if (manager.datostrof.completaalien1v == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 17)
            {

            logo1.text = "el plaer de morir una vegada";
            logo2.text = "morir una vegada a Alien 1";
            if (manager.datostrof.alien1muere == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
                        if (trofeo == 18)
            {

            logo1.text = "rei dels dolços";
            logo2.text = "troba l'ou De Pasqua a alien 1";
            if (manager.datostrof.alien1huevooculto== 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 19)
            {

            logo1.text = "el rei està esperant";
            logo2.text = "visiteu l'habitació Del Rei a alien 1";
            if (manager.datostrof.alien1saladelrey == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 20)
            {

            logo1.text = "secrets a l'univers";
            logo2.text = "entra a la sala secreta potser hauries de batre els rècords del rei t'està esperant a alien 1";
            if (manager.datostrof.alien1salasecreta == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 21)
            {

            logo1.text = "explorador nascut";
            logo2.text = "fes una ullada al poble d'asteroides a alien 1";
            if (manager.datostrof.alien1secretobajoelasteroide == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }



            if (trofeo == 22)
            {

            logo1.text = "no m'he rendit";
            logo2.text = "mira el primer cinematogràfic a alien2";
            if (manager.datostrof.alien2primeracinematica == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 23)
            {

            logo1.text = "la mort m'odia";
            logo2.text = "desbloqueja un punt de control";
            if (manager.datostrof.alien2desbloqueaelcheckpoint1delnivel1 ==1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 24)
            {

            logo1.text = "consergeria";
            logo2.text = "obtenir 4 claus";
            if (manager.datostrof.alien2consigue4llaves == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 25)
            {

            logo1.text = "collector principiant";
            logo2.text = "obteniu una pàgina del diari";
            if (manager.datostrof.alien2unapaginadeldiario == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 26)
            {

            logo1.text = "escolta una història";
            logo2.text = "escolta una pàgina del diari";
            if (manager.datostrof.alien2escuchaunapaginadeldiario == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 27)
            {

            logo1.text = "recopilador d'informació";
            logo2.text = "obteniu totes les pàgines del diari";
            if (manager.datostrof.alien2consiguetodaslaspaginas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 28)
            {

            logo1.text = "discussions de parella";
            logo2.text = "parla amb la teva dona a l'illa";
            if (manager.datostrof.alien2hablarcontumujer == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 29)
            {

            logo1.text = "amic de la mort";
            logo2.text = "desbloqueja tots els punts de control";
            if (manager.datostrof.alien2desbloqueatodosloscheckpoits == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 30)
            {

            logo1.text = "explorador de pensament";
            logo2.text = "obre la botiga a la primera àrea";
            if (manager.datostrof.alien2abrelatiendabloqueadadelaprimerazona == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 31)
            {

            logo1.text = "explorador curiós";
            logo2.text = "troba la botiga oculta a la segona zona";
            if (manager.datostrof.alien2encuentralatiendaocultadelasegundazona == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 32)
            {

            logo1.text = "botes especials";
            logo2.text = "aconsegueix el doble salt";
            if (manager.datostrof.alien2mejora1 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 33)
            {

            logo1.text = "permís per matar";
            logo2.text = "agafa la pistola";
            if (manager.datostrof.alien2mejora2 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
                        if (trofeo == 34)
            {

            logo1.text = "licècia descaducada";
            logo2.text = "agafa el cotxe";
            if (manager.datostrof.alien2mejora3 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 35)
            {

            logo1.text = "gadget estrany";
            logo2.text = "aconsegueix l'hipnotitzador";
            if (manager.datostrof.alien2mejora4 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 36)
            {

            logo1.text = "recuperant el meu";
            logo2.text = "aconsegueix el vaixell";
            if (manager.datostrof.alien2mejora5 == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 37)
            {

            logo1.text = "corredor expert";
            logo2.text = "utilitza l'aclerador";
            if (manager.datostrof.alien2usaelacelerador == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 38)
            {

            logo1.text = "pont expert";
            logo2.text = "utilitza el pont";
            if (manager.datostrof.alien2usaelsaltador == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 39)
            {

            logo1.text = "conductor experimentat";
            logo2.text = "utilitza el cotxe al món obert";
            if (manager.datostrof.alien2usaelcochedelmundo == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 40)
            {

            logo1.text = "manipulació";
            logo2.text = "hipnotitzar un pirata";
            if (manager.datostrof.alien2hipnotizaunpirata == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 41)
            {

            logo1.text = "pilot experimentat";
            logo2.text = "vola sobre el món amb el vaixell";
            if (manager.datostrof.alien2usalanaveenelespacio == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 42)
            {

            logo1.text = "he vist aquest vaixell abans";
            logo2.text = "utilitzeu un vaixell que sigui una referència";
            if (manager.datostrof.alien2usalanavegumi == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 43)
            {

            logo1.text = "morir no és el que jo volia";
            logo2.text = "obteniu el mal final d'Alien 2";
            if (manager.datostrof.completaalien2m == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 44)
            {

            logo1.text = "vivien feliços i menjaven perdius";
            logo2.text = "obteniu el bon final d'Alien 2";
            if (manager.datostrof.completaalien2v == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 45)
            {

            logo1.text = "pare estalviador";
            logo2.text = "desa 1000 monedes a alien 2";
            if (manager.datostrof.alien2ahorra1000monedas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 46)
            {

            logo1.text = "malbaratament";
            logo2.text = "compreu almenys un article a cada estand d'alien 2";
            if (manager.datostrof.alien2compraentodaslastiendas1vez == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 47)
            {

            logo1.text = "reis capritxosos";
            logo2.text = "troba l'ou De Pasqua d'alien 2";
            if (manager.datostrof.alien2huevooculto == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 48)
            {

            logo1.text = "morir és viure";
            logo2.text = "morir una vegada a alien2";
            if (manager.datostrof.alien2muere == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 49)
            {

            logo1.text = "bona salut";
            logo2.text = "elevar el límit de vida a alien2";
            if (manager.datostrof.alien2obtentodaslasmejorasvida== 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 50)
            {

            logo1.text = "crec que m'estic oblidant d'alguna cosa";
            logo2.text = "treu el final alternatiu en la lluita contra el rei dels pirates a alien 2";
            if (manager.datostrof.alien2sacaelfinalalternativo == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 51) 
            {
                
                logo1.text = "pots veure el rei per segona vegada";
                logo2.text = "entra a l'habitació Del Rei a alien 2";
                if (manager.datostrof.alien2saladelrey == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }




            if (trofeo == 52) 
            {
                
                logo1.text = "això no és divertit";
                logo2.text = "vèncer els robots clònics";
                if (manager.datostrof.alien3jefe1 == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 53) 
            {
                
                logo1.text = "petit però assetjador";
                logo2.text = "vèncer el guardià d'or";
                if (manager.datostrof.alien3jefe2 == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 54) 
            {
                
                logo1.text = "prometo la revenja";
                logo2.text = "batre el slouch una vegada";
                if (manager.datostrof.alien3jefe3 == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 55) 
            {
                
                logo1.text = "per sobre d'un déu";
                logo2.text = "derrota la deïtat";
                if (manager.datostrof.alien3jefe4 == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 56) 
            {
                
                logo1.text = "la meva venjança";
                logo2.text = "batre la caiguda per segona vegada";
                if (manager.datostrof.alien3jefe5 == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 57) 
            {
                
                logo1.text = "el final d'una història";
                logo2.text = "derrota la deïtat mirall";
                if (manager.datostrof.alien3jefe6== 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 58) 
            {
                
                logo1.text = "aviador novell";
                logo2.text = "guanyar una batalla amb el vaixell";
                if (manager.datostrof.alien3jefe1nave== 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 59) 
            {
                
                logo1.text = "aviador expert";
                logo2.text = "batre la caiguda amb el vaixell";
                if (manager.datostrof.alien3jefe5nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 60) 
            {
                
                logo1.text = "estic congelant";
                logo2.text = "visita hieliland";
                if (manager.datostrof.alien3planeta1nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 61) 
            {
                
                logo1.text = "camps i muntanyes";
                logo2.text = "visita sunny villa";
                if (manager.datostrof.alien3planeta2nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 62) 
            {
                
                logo1.text = "cau ocult";
                logo2.text = "visita cometa 2274";
                if (manager.datostrof.alien3planeta3nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 63) 
            {
                
                logo1.text = "a prop d'un volcà";
                logo2.text = "visita magmacity";
                if (manager.datostrof.alien3planeta4nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 64) 
            {
                
                logo1.text = "enfonsat a la fossa";
                logo2.text = "visiteu el planeta presó";
                if (manager.datostrof.alien3planeta5nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 65) 
            {
                
                logo1.text = "mines d'or";
                logo2.text = "visita Orotopia";
                if (manager.datostrof.alien3planeta6nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 66) 
            {
                
                logo1.text = "lluna porpra";
                logo2.text = "visita la lluna porpra";
                if (manager.datostrof.alien3planeta7nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 67) 
            {
                
                logo1.text = "fortalesa enemiga";
                logo2.text = "visita fortalesa ardent";
                if (manager.datostrof.alien3planeta8nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 68) 
            {
                
                logo1.text = "lloc encallat";
                logo2.text = "visiteu l'asteroide 7248";
                if (manager.datostrof.alien3planeta9nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 69) 
            {
                
                logo1.text = "de vacances";
                logo2.text = "visita guiada";
                if (manager.datostrof.alien3planeta10nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 70) 
            {
                
                logo1.text = "ciutat salvatge";
                logo2.text = "visita ciutat tropical";
                if (manager.datostrof.alien3planeta11nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 71) 
            {
                
                logo1.text = "a prop del final";
                logo2.text = "visita El Planeta X";
                if (manager.datostrof.alien3planeta12nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 72) 
            {
                
                logo1.text = "cau abandonat";
                logo2.text = "visita fortalesa abandonada";
                if (manager.datostrof.alien3planeta13nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 73) 
            {
                
                logo1.text = "llar futur";
                logo2.text = "visita nova llar";
                if (manager.datostrof.alien3planeta14nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 74) 
            {
                
                logo1.text = "el fill torna a casa";
                logo2.text = "visita casa vella";
                if (manager.datostrof.alien3planeta15nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 75) 
            {
                
                logo1.text = "recurrència d'un altre";
                logo2.text = "asteroide ocult";
                if (manager.datostrof.alien3planeta16nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 76) 
            {
                
                logo1.text = "a la vora del final";
                logo2.text = "món final";
                if (manager.datostrof.alien3planeta17nave == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 77) 
            {
                
                logo1.text = "aprenentatge";
                logo2.text = "entra al menú guia";
                if (manager.datostrof.alien3entraalaguiadelpause == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 78) 
            {
                
                logo1.text = "per curiositat";
                logo2.text = "entra al menú extres";
                if (manager.datostrof.alien3entraalmenuextras == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 79) 
            {
                
                logo1.text = "dinamisme";
                logo2.text = "fes una ullada a la selecció ràpida";
                if (manager.datostrof.alien3entraaseleccionrapidaenelpause == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 80) 
            {
                
                logo1.text = "el meu pare tenia 15 anys ja queda poc";
                logo2.text = "obtenir 10 gemmes";
                if (manager.datostrof.alien3consigue10gemas == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 81) 
            {
                
                logo1.text = "energia pa meu motxilla";
                logo2.text = "aconsegueix 20 gemmes";
                if (manager.datostrof.alien3consigue20gemas == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 82) 
            {
                
                logo1.text = "necessito més energia";
                logo2.text = "aconsegueix 40 gemmes";
                if (manager.datostrof.alien3consigue40gemas == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 83) 
            {
                
                logo1.text = "energia nuclear";
                logo2.text = "aconsegueix 70 gemmes";
                if (manager.datostrof.alien3consigue70gemas == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if (trofeo == 84)
            {

            logo1.text = "monpolio energètic";
            logo2.text = "aconsegueix 100 gemmes";
            if (manager.datostrof.alien3consigue100gemas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 85)
            {

            logo1.text = "necessito la ubicació";
            logo2.text = "obteniu totes les pàgines del diari";
            if (manager.datostrof.alien3consiguetodaslaspaginas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }



            if (trofeo == 86)
            {

            logo1.text = "xafarderies";
            logo2.text = "escolta una pàgina del diari";
            if (manager.datostrof.alien3escuchaunapagina == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 87)
            {

            logo1.text = "s'acosta una tempesta";
            logo2.text = "obteniu el final bàsic d'Alien 3";
            if (manager.datostrof.completaalien3m == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 88)
            {

            logo1.text = "futur misteriós";
            logo2.text = "obteniu el veritable final D'Alien 3";
            if (manager.datostrof.completaalien3v == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 89)
            {

            logo1.text = "promesa de venjança";
            logo2.text = "fugir del poble abandonat a alien 3";
            if (manager.datostrof.alien3acabaeltutorial == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 90)
            {

            logo1.text = "herència";
            logo2.text = "recupera l'herència del cadàver del teu pare al poble abandonat d'alien 3";
            if (manager.datostrof.alien3aceptalaherencia == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 91)
            {

            logo1.text = "fill estalviador";
            logo2.text = "desa 5000 monedes en total a alien 3";
            if (manager.datostrof.alien3ahorra5000monedas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if(trofeo == 92)
            {

            logo1.text = "armat i llest";
            logo2.text = "aconsegueix una pistola";
            if (manager.datostrof.alien3primeraarma == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 93)
            {

            logo1.text = "primera defensa";
            logo2.text = "aconsegueix una armadura";
            if (manager.datostrof.alien3primeraarmadura == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 94)
            {

            logo1.text = "primer pas";
            logo2.text = "aconseguir una vida millor";
            if (manager.datostrof.alien3primeramejoradevida == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 95)
            {

            logo1.text = "salut de ferro";
            logo2.text = "recull totes les actualitzacions de vida en alien 3";
            if (manager.datostrof.alien3consiguetodadlasmejorasvida == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 96)
            {

            logo1.text = "tots són morts";
            logo2.text = "compra la trituradora";
            if (manager.datostrof.alien3compraladestructora == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }
            }
            if (trofeo == 97)
            {

            logo1.text = "cavaller";
            logo2.text = "aconsegueix tota l'armadura a Alien 3";
            if (manager.datostrof.alien3consiguetodaslasarmaduras == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }

            if (trofeo == 98)
            {

            logo1.text = "guerrer";
            logo2.text = "aconsegueix totes les armes a Alien 3";
            if (manager.datostrof.alien3consiguetodaslasarmas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if (trofeo == 99)
            {

            logo1.text = "fins que no en quedi cap";
            logo2.text = "aconsegueix totes les armes i buida totes les revistes a alien 3";
            if (manager.datostrof.alien3gastatodalamuniciondetodaslasarmas == 1)
            {
            logo3.color = new Color32 (24,255,0,255);
            logo3.text = "aconseguit";
            }
            else
            {
            logo3.color = new Color32 (255,28,0,255);
            logo3.text = "no aconseguit";
            }

            }
            if(trofeo == 100) 
            {
                
                logo1.text = "el trot Del Rei";
                logo2.text = "aconsegueix l'ou de Pasqua amagat a Alien 3";
                if (manager.datostrof.alien3huevooculto == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if (trofeo == 101) 
            {
                
                logo1.text = "com el pare com el fill";
                logo2.text = "morir una vegada a Alien 3";
                if (manager.datostrof.alien3muere == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if (trofeo == 102) 
            {
                
                logo1.text = "assassí en sèrie";
                logo2.text = "mata 100 enemics a Alien 3";
                if (manager.datostrof.alien3vence100enemigos == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if (trofeo == 103) 
            {
                
                logo1.text = "assassí en massa";
                logo2.text = "mata 200 enemics a Alien 3";
                if (manager.datostrof.alien3vence200enemigos == 1)
                {
                    logo3.color = new Color32 (24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32 (255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }        

        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
            
            
    }
        
}
