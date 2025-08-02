using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class municion_nave_al1 : MonoBehaviour
{
    public float temp;
    public float tempR;
    public string munT;
    public jugador_al1 jug;
    public GameObject[] munmod = new GameObject[4];
    public string[] names = new string[4];
    private bool _R;
    void Start()
    {

        jugador_al1 jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        names[0] = "mina";
        names[1] = "misil";
        names[2] = "escopeta";
        names[3] = "cura";
        
        munT = names[Random.Range(0,4)];

        if(munT == "mina")
        {
            munmod[0].SetActive(true);
            munmod[1].SetActive(false);
            munmod[2].SetActive(false);
            munmod[3].SetActive(false); 
        }
        if(munT == "misil")
        {
            munmod[1].SetActive(true);
            munmod[0].SetActive(false);
            munmod[2].SetActive(false);
            munmod[3].SetActive(false); 
        }           
        if(munT == "escopeta")
        {
            munmod[2].SetActive(true); 
            munmod[0].SetActive(false);
            munmod[1].SetActive(false);
            munmod[3].SetActive(false); 
        }
        if(munT == "cura")
        {
            munmod[3].SetActive(true); 
            munmod[0].SetActive(false);
            munmod[1].SetActive(false);
            munmod[2].SetActive(false);
        }
        _R = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(temp <= 0)
        {
            Destroy(this.gameObject);
        }
        if (temp < 10)
        {
            if(tempR > 0.5f)
            {
                if(munT == "mina")
                {
                    munmod[0].SetActive(!_R);
                }
                if(munT == "misil")
                {
                    munmod[1].SetActive(!_R);
                }           
                if(munT == "escopeta")
                {
                    munmod[2].SetActive(!_R);
                }
                if(munT == "cura")
                {
                    munmod[3].SetActive(!_R);
                }
                tempR = 0;
                _R = !_R;
            }
        }
        temp -= 1 * Time.deltaTime;
        tempR += 1 * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
            if(munT == "mina")
            {
                jug.minabalas++;
                Destroy(this.gameObject);
            }
            if(munT == "misil")
            {
                jug.misilbalas += 5;
                Destroy(this.gameObject);
            }
            if(munT == "escopeta")
            {
                jug.escopetabalas += 3;
                Destroy(this.gameObject);
            }
            if(munT == "cura")
            {
                jug.vida += (jug.vidamax/100) * 30;
                if(jug.vida > jug.vidamax)
                {jug.vida = jug.vidamax;}
                Destroy(this.gameObject);
            }
        }
    }
}
