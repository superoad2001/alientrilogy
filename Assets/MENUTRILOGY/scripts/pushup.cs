using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class pushup : MonoBehaviour
{

    [SerializeField]
	public datosconfig datosconfig;
    [SerializeField]
	public datosextra datostrof;
	public string repath;
    public string repathtro;
    public Animator anim;
    public Text mensaje;
    public Text trofeo;
    public AudioSource ping;

        public void GetFilePath()
    {
        string result;
 
        result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alienconfigdata.data");
 
        repath = result;
    }
    public void GetFilePathtro()
    {
        string result;
 
        result = Path.Combine(Application.persistentDataPath,"AlienData");
        result = Path.Combine(result, $"alientorfeodata.data");
 
        repathtro = result;
    }


	public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosconfig1 = File.ReadAllText(path);
            datosconfig = JsonUtility.FromJson<datosconfig>(datosconfig1);
            Debug.Log(datosconfig1);
        }
        
    }
    public void cargartro()
    {
        GetFilePathtro();
        string path = repathtro;
        if(File.Exists(path))
        {
            string datosconfig2 = File.ReadAllText(path);
            datostrof = JsonUtility.FromJson<datosextra>(datosconfig2);
            Debug.Log(datosconfig2);
        }
        
    }
    public void push(int trofeonum)
    {

        if(datosconfig.idioma == "es")
        {
            if(trofeonum == 1) 
            {
                mensaje.text = "trofeo obtenido     trofeo n"+trofeonum;
                trofeo.text = "";
                anim.SetBool("trof",true);

            }
            ping.Play();
 
        }
    }
    void Awake()
    {
        cargar();
        cargartro();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        push(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
