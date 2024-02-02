using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Rewired;
using UnityEngine.SceneManagement;

public class pausa_al2 : MonoBehaviour
{
    public GameObject juego;
    public GameObject pausa1;
    public int plat;
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    public float temp;
    public Text boton1;
    public Text boton2;
    public Text boton3;
    public Text boton4;
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
    }

    // Update is called once per frame
    void Update()
    {

        
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        manager.datosserial.pause = true;
        if(manager.datosconfig.idioma == "es")
        {
            boton1.text = "salir";
            boton2.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15 || manager.nivel <= -1 && manager.nivel >= -15)
            {boton3.text = "salir del nivel";}
            boton4.text = "pausa";
        }
        if(manager.datosconfig.idioma == "en")
        {
            boton1.text = "exit";
            boton2.text = "continue";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "exit of the level";}
            boton4.text = "pause";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            boton1.text = "sortir";
            boton2.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "sortir a la base";}
            boton4.text = "pausa";
        }
        if(player.GetAxis("pausa") > 0 && temp > 0.5f)
        {
            continuar();
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
    public void continuar(){
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        plat = manager.datosconfig.plat;
        temp = 0;
        juego.SetActive(true);
        pausa1.SetActive(false);
        if(plat == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
    }
    public void salir(){
        SceneManager.LoadScene("presentacion_al2");
    }

    public void salirnivel(){
        SceneManager.LoadScene("mundo_abierto_al2");
    }

    public void salirnivel2(){
        SceneManager.LoadScene("torre_del_tiempo_al2");
    }
}
