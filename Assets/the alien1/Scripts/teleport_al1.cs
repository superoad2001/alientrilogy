using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class teleport_al1 : MonoBehaviour
{
    public Text tutfinala;
	public Animator anim;
	private Controles controles;
	public manager_al1 manager;
    public int tipoTP;
    public string ubi;
    public string lugar;

	private readonly Dictionary<string, string> languageTexts = new Dictionary<string, string>
    {
        {"es", "para teletransportarte"},
        {"en", "To teleport"},
        {"cat", "per teletransportarta"}
    };
    private readonly Dictionary<string, string> languageTexts2 = new Dictionary<string, string>
    {
        {"es", "para cruzar portal"},
        {"en", "To access portal"},
        {"cat", "per creuar el portal"}
    };
    private readonly Dictionary<string, string> languageTexts3= new Dictionary<string, string>
    {
        {"es", "Ir a "},
        {"en", "Go to "},
        {"cat", "Anar a "}
    };
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
	}
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
    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
	    	anim.SetBool("show",true);
			if (languageTexts.TryGetValue(manager.datosconfig.idioma, out string text) && tipoTP == 0)
            {
                tutfinala.text = text;
            }
            else if (languageTexts2.TryGetValue(manager.datosconfig.idioma, out string text1) && tipoTP == 1)
            {
                tutfinala.text = text1;
            }
            else if (languageTexts3.TryGetValue(manager.datosconfig.idioma, out string text2) && tipoTP == 2)
            {
                tutfinala.text = text2+lugar;
            }
			if (controles.al1_general.y.ReadValue<float>() > 0f )
			{
				SceneManager.LoadScene(ubi);
			}
		}
	}
    private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			anim.SetBool("show",false);
		}
	}
}
