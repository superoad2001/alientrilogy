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
	public GameObject objeto;
	public manager_al1 manager;
    public string ubi;

	private readonly Dictionary<string, string> languageTexts = new Dictionary<string, string>
    {
        {"es", "para teletransportarte"},
        {"en", "To teleport"},
        {"cat", "per teletransportarta"}
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
			if (languageTexts.TryGetValue(manager.datosconfig.idioma, out string text))
            {
                tutfinala.text = text;
            }
			if (controles.al1.y.ReadValue<float>() > 0f )
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
