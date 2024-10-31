using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jefecincarga_al2 : MonoBehaviour
{
	public manager_al2 manager;

    public float temp = 0;
    public float max = 94;

    private Controles controles;
    public AudioSource audio1;
    public AudioSource audioesp;
    public AudioSource audioen;
    public AudioSource audiocat;
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
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        if(manager.datosconfig.idioma == "es")
        {
            audio1 = audioesp;
        }
        if(manager.datosconfig.idioma == "en")
        {
            audio1 = audioen;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            audio1 = audiocat;
        }
        audio1.Play();
    }
    public void act()
    {
        temp = 300;
    }
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if(audio1.isPlaying == false || controles.menu.saltar.ReadValue<float>() > 0)
        {
            SceneManager.LoadScene("jefe6_al2");
        }
    }
}
