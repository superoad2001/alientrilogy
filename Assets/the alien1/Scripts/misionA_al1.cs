using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class misionA_al1 : MonoBehaviour
{
    public Text mision;
    public Text misiondesc;
    public GameObject misionG;
    [SerializeField]
	public misiones_al1 misionesDB;
    public manager_al1 manager;
    public jugador_al1 jugador;
    public int plataforma;
    public float temp;
    public void aceptar()
    {
        manager.datosserial.misiones[manager.misionS] = 1;
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
        if(manager.juego == 1)
        {
            jugador.anim.SetBool("act2",true);
        }
        if(manager.juego == 2)
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
        if(manager.juego == 1)
        {
            jugador.anim.SetBool("act2",true);
        }
        if(manager.juego == 2)
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
        mision.text = misionesDB.misiones[manager.misionS];
        misiondesc.text = misionesDB.misionesdesc[manager.misionS];
    }

    // Update is called once per frame
    void Update()
    {
        if(temp < 15)
        {temp += 1 * Time.unscaledDeltaTime;}
    }
}
