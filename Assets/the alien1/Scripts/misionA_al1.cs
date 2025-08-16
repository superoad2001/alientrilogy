using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class misionA_al1 : MonoBehaviour
{
    public Text[] botonestrad = new Text[10];
    public Text mision;
    public Text misiondesc;
    public GameObject misionG;
    [SerializeField]
	public misiones_al1 misionesDB;
    public manager_al1 manager;
    public jugador_al1 jugador;
    public int plataforma;
    public float temp;
    public int npcid;
    public int misionID;
    public int misionS;
    public int modo;
    public GameObject finM;
    public GameObject aceptarM;
    public Sprite[] tipoI = new Sprite[7];
    public Image premio;
    public Text menpremio;
    public Text titulopremio;
    public int premiocant;
    public int tipoC;
    public Color[] colores = new Color[7];
    public bool tiendaact;
    public void obtener()
    {
        manager.datosserial.misiones[manager.misionS] = 2;
        manager.datosserial.npcF[npcid]++;
        manager.datosserial.economia[6] += premiocant;
        manager.guardar();

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
        if(jugador.modo == "Coche" )
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave" )
        {
            jugador.anim.SetBool("act",true);
        }
        misionG.SetActive(false);
    }
    public void aceptar()
    {
        manager.datosserial.misiones[manager.misionS] = 1;
        manager.datosserial.npcF[npcid]++;
        manager.guardar();

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
        if(jugador.modo == "Coche" )
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave" )
        {
            jugador.anim.SetBool("act",true);
        }
        misionG.SetActive(false);
    }
    public void denegar()
    {
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
        if(jugador.modo == "Coche" )
        {
            jugador.anim.SetBool("act2",true);
        }
        if(jugador.modo == "Nave" )
        {
            jugador.anim.SetBool("act",true);
        }
        misionG.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(manager.datosconfig.idioma == "es" )
        {
            botonestrad[0].text = "Aceptar";
            botonestrad[1].text = "Declinar";
            botonestrad[2].text = "Obtener";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (modo == 1)
        {
            finM.SetActive(false);
            aceptarM.SetActive(true);
            mision.text = misionesDB.misiones[manager.misionS];
            misiondesc.text = misionesDB.misionesdesc[manager.misionS];
        }
        if (modo == 2)
        {
            aceptarM.SetActive(false);
            finM.SetActive(true);
            premio.sprite = tipoI[6];
            premio.color = colores[6];
            titulopremio.text = "completada";
            menpremio.text = "obtuviste"+premiocant+"de estos";

        }
        if(temp < 15)
        {temp += 1 * Time.unscaledDeltaTime;}
    }
}
