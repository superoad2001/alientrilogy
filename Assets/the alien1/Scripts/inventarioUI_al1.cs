using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class inventarioUI_al1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
    }
    public manager_al1 manager;
    public Text gemas;
    public Text monedam;
    public Text monedaa;
    public Text monedar;
    public Text llave;
    public Text llaver;
    public Text misionN;
    public Text mision;
    // Update is called once per frame
    void Update()
    {   
                misionN.text = manager.datosserial.misionS;
                mision.text = manager.datosserial.misiondescS;
                gemas.text = manager.datosserial.economia[0]+"";
                llave.text = manager.datosserial.economia[1]+"";
                llaver.text = manager.datosserial.economia[2]+"";           
                monedar.text = manager.datosserial.economia[3]+"";
                monedam.text = manager.datosserial.economia[4]+"";
                monedaa.text = manager.datosserial.economia[5]+"";
    }
}
