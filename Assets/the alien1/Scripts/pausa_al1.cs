using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Rewired;
using UnityEngine.SceneManagement;

public class pausa_al1 : MonoBehaviour
{
    public GameObject juego;
    public GameObject pausa1;
    public int plataforma;
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    public Text boton1;
    public Text boton2;
    public Text boton3;
    public Text boton4;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);

    }

    // Update is called once per frame
    void Update()
    {
        manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        if(manager.datosconfig.idioma == "es")
        {
            boton2.text = "salir";
            boton1.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "salir del nivel";}
            boton4.text = "pausa";
        }
        if(manager.datosconfig.idioma == "en")
        {
            boton2.text = "exit";
            boton1.text = "continue";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "exit of the level";}
            boton4.text = "pause";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            boton2.text = "sortir";
            boton1.text = "continuar";
            if(manager.nivel >= 1 && manager.nivel <= 15)
            {boton3.text = "sortir a la base";}
            boton4.text = "pausa";
        }
        if(player.GetAxis("pausa") > 0 && temp > 0.7f)
        {
            continuar();
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
    public void continuar(){
        manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        plataforma = manager.datosconfig.plat;
        temp = 0;
        juego.SetActive(true);
        pausa1.SetActive(false);
        if(plataforma == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
    }
    public void salir(){
        SceneManager.LoadScene("presentacion_al1");
    }

    public void salirnivel(){
        SceneManager.LoadScene("piso1_al1");
    }
}
