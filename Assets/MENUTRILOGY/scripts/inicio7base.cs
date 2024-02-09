using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Rewired;

public class inicio7base : MonoBehaviour
{

    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
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
    public void izq()
    {
        if(trofeo > 1)
        {trofeo -= 1;}
    }
    public void der()
    {
        if(trofeo < maxtrofeos)
        {trofeo += 1;}
    }
    public void salir()
    {
        SceneManager.LoadScene("menutrilogy");
    }
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
        managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
        if(manager.datostrof.completaalien1m == 1)
        {trofeos++;}
        if(manager.datostrof.completaalien2m == 1)
        {trofeos++;}
        if(manager.datostrof.completaalien3m == 1)
        {trofeos++;}
        if(manager.datostrof.completaalien1v == 1)
        {trofeos++;}
        if(manager.datostrof.completaalien2v == 1)
        {trofeos++;}
        if(manager.datostrof.completaalien3v == 1)

        {trofeos++;}
        if(manager.datostrof.alien1huevooculto == 1)
        {trofeos++;}
        if(manager.datostrof.alien1saladelrey == 1)
        {trofeos++;}
        if(manager.datostrof.alien1muere == 1)
        {trofeos++;}
        if(manager.datostrof.alien1salasecreta == 1)
        {trofeos++;}
        if(manager.datostrof.alien1secretobajoelasteroide == 1)
        {trofeos++;}

        if(manager.datostrof.alien2ahorra1000monedas == 1)
        {trofeos++;}
        if(manager.datostrof.alien2compraentodaslastiendas1vez == 1)
        {trofeos++;}
        if(manager.datostrof.alien2huevooculto == 1)
        {trofeos++;}
        if(manager.datostrof.alien2muere == 1)
        {trofeos++;}
        if(manager.datostrof.alien2obtentodaslasmejorasvida == 1)
        {trofeos++;}
        if(manager.datostrof.alien2sacaelfinalalternativo == 1)
        {trofeos++;}
        if(manager.datostrof.alien2saladelrey == 1)
        {trofeos++;}

        if(manager.datostrof.alien3acabaeltutorial == 1)
        {trofeos++;}
        if(manager.datostrof.alien3aceptalaherencia == 1)
        {trofeos++;}
        if(manager.datostrof.alien3ahorra5000monedas == 1)
        {trofeos++;}
        if(manager.datostrof.alien3consiguetodadlasmejorasvida == 1)
        {trofeos++;}
        if(manager.datostrof.alien3consiguetodaslasarmaduras == 1)
        {trofeos++;}
        if(manager.datostrof.alien3consiguetodaslasarmas == 1)
        {trofeos++;}
        if(manager.datostrof.alien3gastatodalamuniciondetodaslasarmas == 1)
        {trofeos++;}
        if(manager.datostrof.alien3huevooculto == 1)
        {trofeos++;}
        if(manager.datostrof.alien3muere == 1)
        {trofeos++;}
        if(manager.datostrof.alien3vence100enemigos == 1)
        {trofeos++;}
        if(manager.datostrof.alien3vence200enemigos == 1)
        {trofeos++;}
        
    }

    // Update is called once per frame
    void Update()
    {
        managerBASE manager = UnityEngine.Object.FindObjectOfType<managerBASE>();
        if(player.GetAxis("b") > 0)
        {
            salir();
        }
        if(player.GetAxis("horizontalpad") > 0)
        {
            der();
        }
        if(player.GetAxis("horizontalpad") < 0)
        {
            izq();
        }
        if(manager.datosconfig.idioma == "es")
        {
            trofeost.text = "trofeos";
            trofeostn.text = "trofeo n"+trofeo;
            contador.text = "tienes "+trofeos+"/"+maxtrofeos;
            if(trofeo == 7) 
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
            if(trofeo == 8) 
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
            if(trofeo == 9) 
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
            if(trofeo == 10) 
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
            if(trofeo == 11) 
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
            if(trofeo == 12) 
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
            if(trofeo == 13) 
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
            if(trofeo == 14) 
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
            if(trofeo == 15) 
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
            if(trofeo == 16) 
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
            if(trofeo == 17) 
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
            if(trofeo == 18) 
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
            if(trofeo == 19) 
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
            if(trofeo == 20) 
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
            if(trofeo == 21) 
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
            if(trofeo == 22) 
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
            if(trofeo == 23) 
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
            if(trofeo == 24) 
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
            if(trofeo == 25) 
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
            if(trofeo == 26) 
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
            if(trofeo == 27) 
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
            if(trofeo == 28) 
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
            if(trofeo == 1) 
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
            if(trofeo == 2) 
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
            if(trofeo == 3) 
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
            if(trofeo == 4) 
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
            if(trofeo == 5) 
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
            if(trofeo == 6) 
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
        }
        if(manager.datosconfig.idioma == "en")
        {
            contador.text = "obtained "+trofeos+"/"+maxtrofeos;
            trofeost.text = "trophy";
            trofeostn.text = "trofeo n"+trofeo;
            if(trofeo == 7) 
            {
                
                logo1.text = "the pleasure of dying once";
                logo2.text = "die once in alien 1";
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
            if(trofeo == 8) 
            {
                
                logo1.text = "the king waits";
                logo2.text = "visit the king's room in alien 1";
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
            if(trofeo == 9) 
            {
                
                logo1.text = "secrets in the universe";
                logo2.text = "enter the secret room maybe you should beat the king's records he is waiting for you in alien 1";
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
            if(trofeo == 10) 
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
            if(trofeo == 11) 
            {
                
                logo1.text = "hoarder father";
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
            if(trofeo == 12) 
            {
                
                logo1.text = "spendthrift";
                logo2.text = "Buy at least one item at each booth in alien 2";
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
            if(trofeo == 13) 
            {
                
                logo1.text = "capricious kings";
                logo2.text = "find the alien 2 easter egg";
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
            if(trofeo == 14) 
            {
                
                logo1.text = "dying is living";
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
            if(trofeo == 15) 
            {
                
                logo1.text = "good health";
                logo2.text = "reaches the life limit in alien2";
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
            if(trofeo == 16) 
            {
                
                logo1.text = "I think I forgot something";
                logo2.text = "Take out the alternative ending in the fight against the pirate king in Alien 2";
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
            if(trofeo == 17) 
            {
                
                logo1.text = "you can see the king a second time";
                logo2.text = "enter the king's room in alien 2";
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
            if(trofeo == 18) 
            {
                
                logo1.text = "promise of revenge";
                logo2.text = "flee from the abandoned village in alien 3";
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
            if(trofeo == 19) 
            {
                
                logo1.text = "heritage";
                logo2.text = "Recover the heritage from your father's corpse in the abandoned village in Alien 3";
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
            if(trofeo == 20) 
            {
                
                logo1.text = "hoarder son";
                logo2.text = "save 5000 coins in total in alien 3";
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
            if(trofeo == 21) 
            {
                
                logo1.text = "iron health";
                logo2.text = "collect all life upgrades in alien 3";
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
            if(trofeo == 22) 
            {
                
                logo1.text = "gentleman";
                logo2.text = "get all the armor in alien 3";
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
            if(trofeo == 23) 
            {
                
                logo1.text = "warrior";
                logo2.text = "get all the weapons in alien 3";
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
            if(trofeo == 24) 
            {
                
                logo1.text = "until there is not one left";
                logo2.text = "Get all the weapons and empty all the magazines in Alien 3";
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
            if(trofeo == 25) 
            {
                
                logo1.text = "the king's omelette";
                logo2.text = "get the hidden easter egg in alien 3";
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
            if(trofeo == 26) 
            {
                
                logo1.text = "like stick like splinter";
                logo2.text = "die once in alien 3";
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
            if(trofeo == 27) 
            {
                
                logo1.text = "serial killer";
                logo2.text = "kill 100 enemies in alien 3";
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
            if(trofeo == 28) 
            {
                
                logo1.text = "mass murderer";
                logo2.text = "kill 200 enemies in alien 3";
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
            if(trofeo == 1) 
            {
                
                logo1.text = "I agree but what if";
                logo2.text = "get the basic ending of alien 1";
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
            if(trofeo == 2) 
            {
                
                logo1.text = "I like happy endings";
                logo2.text = "get the true ending of alien 1";
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
            if(trofeo == 3) 
            {
                
                logo1.text = "dying is not what I wanted";
                logo2.text = "get the bad ending of alien 2";
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
            if(trofeo == 4) 
            {
                
                logo1.text = "They lived happily and ate partridges";
                logo2.text = "get the good ending of alien 2";
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
            if(trofeo == 5) 
            {
                
                logo1.text = "a storm is coming";
                logo2.text = "get the basic ending of alien 3";
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
            if(trofeo == 6) 
            {
                
                logo1.text = "mysterious future";
                logo2.text = "get the true ending of alien 3";
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
        }
        if(manager.datosconfig.idioma == "cat")
        {
            contador.text = "tens "+trofeos+"/"+maxtrofeos;
            trofeost.text = "trofeu";
            trofeostn.text = "trofeo n"+trofeo;
            if(trofeo == 7) 
            {
                
                logo1.text = "el plaer de morir un cop";
                logo2.text = "mor una vegada en alien 1";
                if(manager.datostrof.alien1muere == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 8) 
            {
                
                logo1.text = "el rei espera";
                logo2.text = "visita la sala del rey en alien 1";
                if(manager.datostrof.alien1saladelrey == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 9) 
            {
                
                logo1.text = "secrets en el univers";
                logo2.text = "entra a la sala secreta al igual deurias batir els records del rey ell te en espera en alien 1";
                if(manager.datostrof.alien1salasecreta == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 10) 
            {
                
                logo1.text = "explorador";
                logo2.text = "fes un cop d ull a la villa de asteroids en alien 1";
                if(manager.datostrof.alien1secretobajoelasteroide == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 11) 
            {
                
                logo1.text = "pare estalviador";
                logo2.text = "estalvia 1000 monedas en alien 2";
                if(manager.datostrof.alien2ahorra1000monedas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 12) 
            {
                
                logo1.text = "malgador";
                logo2.text = "compra almenys un article en cada caseta en alien 2";
                if(manager.datostrof.alien2compraentodaslastiendas1vez == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 13) 
            {
                
                logo1.text = "reis caprichosos";
                logo2.text = "troba el ou de pascua de alien 2";
                if(manager.datostrof.alien2huevooculto == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 14) 
            {
                
                logo1.text = "morir es vivir";
                logo2.text = "mor una vegada en alien2";
                if(manager.datostrof.alien2muere == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 15) 
            {
                
                logo1.text = "bona salut";
                logo2.text = "alanca el limit de vida en alien2";
                if(manager.datostrof.alien2obtentodaslasmejorasvida == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 16) 
            {
                
                logo1.text = "crec que e olvidat una cosa";
                logo2.text = "treu el final alternatiu en la lluita contra el rei pirata en alien 2";
                if(manager.datostrof.alien2sacaelfinalalternativo == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 17) 
            {
                
                logo1.text = "es pot veure al rei una segona vegada";
                logo2.text = "entra al la sala del rei en alien 2";
                if(manager.datostrof.alien2saladelrey == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 18) 
            {
                
                logo1.text = "promesa de venjanca";
                logo2.text = "escapa del poble abandonat en alien 3";
                if(manager.datostrof.alien3acabaeltutorial == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 19) 
            {
                
                logo1.text = "herencia";
                logo2.text = "recupera la herencia del cos del teu pare en la poble abandonat en alien 3";
                if(manager.datostrof.alien3aceptalaherencia == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 20) 
            {
                
                logo1.text = "fiil estalviador";
                logo2.text = "estalvia 5000 monedas en total en alien 3";
                if(manager.datostrof.alien3ahorra5000monedas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 21) 
            {
                
                logo1.text = "salut de ferro";
                logo2.text = "recull todes les milloras de vida 3n alien 3";
                if(manager.datostrof.alien3consiguetodadlasmejorasvida == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 22) 
            {
                
                logo1.text = "caballer";
                logo2.text = "consegueix totes les armadures en alien 3";
                if(manager.datostrof.alien3consiguetodaslasarmaduras == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 23) 
            {
                
                logo1.text = "guerrer";
                logo2.text = "consegueix totes les armas en alien 3";
                if(manager.datostrof.alien3consiguetodaslasarmas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 24) 
            {
                
                logo1.text = "hfins que no quedi ni una";
                logo2.text = "consegueix totes les armas y vuida tots los carregadors en alien 3";
                if(manager.datostrof.alien3gastatodalamuniciondetodaslasarmas == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 25) 
            {
                
                logo1.text = "la truita del rey";
                logo2.text = "consigueix el ou de pascua en alien 3";
                if(manager.datostrof.alien3huevooculto == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 26) 
            {
                
                logo1.text = "tal pal tal astilla";
                logo2.text = "mor una vegada en alien 3";
                if(manager.datostrof.alien3muere == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 27) 
            {
                
                logo1.text = "assesin en serie";
                logo2.text = "mata 100 enemics en alien 3";
                if(manager.datostrof.alien3vence100enemigos == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 28) 
            {
                
                logo1.text = "assesi en massa";
                logo2.text = "mata 200 enemics en alien 3";
                if(manager.datostrof.alien3vence200enemigos == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 1) 
            {
                
                logo1.text = "em conformo pero i si";
                logo2.text = "consigueix el final basic de alien 1";
                if(manager.datostrof.completaalien1m == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
            }
            if(trofeo == 2) 
            {
                
                logo1.text = "m agradan els finals felicos";
                logo2.text = "consigueix el final de veritat de alien 1";
                if(manager.datostrof.completaalien1v == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 3) 
            {
                
                logo1.text = "morir no es lo que volia";
                logo2.text = "consigueix el final dolent de alien 2";
                if(manager.datostrof.completaalien2m == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 4) 
            {
                
                logo1.text = "van ser felicos i van mejar tots anissos";
                logo2.text = "consigueix el final bo de alien 2";
                if(manager.datostrof.completaalien2v == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 5) 
            {
                
                logo1.text = "s aporpa un vendaval";
                logo2.text = "consigueix el final basic de alien 3";
                if(manager.datostrof.completaalien3m == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
            if(trofeo == 6) 
            {
                
                logo1.text = "futur misterios";
                logo2.text = "consigueix el final de veritat de alien 3";
                if(manager.datostrof.completaalien3v == 1)
                {
                    logo3.color = new Color32(24,255,0,255);
                    logo3.text = "aconseguit";
                }
                else
                {
                    logo3.color = new Color32(255,28,0,255);
                    logo3.text = "no aconseguit";
                }
                
            }
        }
            
            
    }
        
}
