using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MeetAndTalk.GlobalValue;
using MeetAndTalk.Localization;
using MeetAndTalk;
using UnityEngine.Events;
using System.Linq;

public class manager_ordas_torneo_al1 : MonoBehaviour
{

    public int ronda;
    public int maxronda;
    public int maxposiciones;
    public int[] maxenemigo1rondas;
    public int[] maxenemigo2rondas;
    public int[] maxenemigo3rondas;
    public int[] maxenemigo4rondas;
    public int[] maxenemigo5rondas;
    public int[] maxenemigo6rondas;
    public int[] maxenemigo7rondas;
    public int[] maxenemigo8rondas;
    public int[] maxenemigo9rondas;
    public int[] maxenemigo10rondas;
    public int[] maxenemigosrondas;
    public GameObject[] posiciones;
    public GameObject[] enemigos = new GameObject[5];
    public jugador_al1 jugador;
    private Vector3 posjugador;
    public Vector3 jugrotation;
    public List<int> posicionesG = new List<int>();
    public manager_al1 manager;
    public Text rondaText;
    public Animator rondaAnim;
    public int contadorene;
    public GameObject explosion;
    public bool actinironda;
    public float temp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        ronda = 0;
        posjugador = jugador.transform.position;
        jugrotation = jugador.transform.eulerAngles;
        rondaC();
        
        
    }
    // Update is called once per frame
    void Update()
    {
        if(contadorene <= 0)
        {
            if(ronda < maxronda)
            {
                ronda++;
                rondaC();
            }

        }


        if(actinironda == true)
        {
            if(temp < 3)
            {
                temp += Time.deltaTime;
            }
            else if(temp >= 3)
            {
                jugador.controlact = true;
                if(maxenemigo1rondas[ronda] > 0)
                {

                    for(int i = 0; i < maxenemigo1rondas[ronda]; i++)
                    {
                        int pos = Random.Range(0, maxposiciones);
                        for(int T = 0; T < posicionesG.Count; T++)
                        {
                            if(pos == posicionesG[T])
                            {
                                pos = Random.Range(0, maxposiciones);
                                T = 0;
                            }
                            else
                            {
                                T = posicionesG.Count;
                            }
                        }
                        GameObject enemigos1 = Instantiate(enemigos[0], posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        GameObject explosion1 = Instantiate(explosion, posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        Destroy(explosion1, 0.5f);
                        posicionesG.Add(pos);
                        
                    }
                }
                if(maxenemigo2rondas[ronda] > 0)
                {
                    for(int i = 0; i < maxenemigo2rondas[ronda]; i++)
                    {
                        int pos = Random.Range(0, maxposiciones);
                        for(int T = 0; T < posicionesG.Count; T++)
                        {
                            if(pos == posicionesG[T])
                            {
                                pos = Random.Range(0, maxposiciones);
                                T = 0;
                            }
                            else
                            {
                                T = posicionesG.Count;
                            }
                        }
                        GameObject enemigos1 = Instantiate(enemigos[1], posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        GameObject explosion2 = Instantiate(explosion, posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        Destroy(explosion2, 0.5f);
                        posicionesG.Add(pos);
                    }
                }
                if(maxenemigo3rondas[ronda] > 0)
                {
                    for(int i = 0; i < maxenemigo3rondas[ronda]; i++)
                    {
                        int pos = Random.Range(0, maxposiciones);
                        for(int T = 0; T < posicionesG.Count; T++)
                        {
                            if(pos == posicionesG[T])
                            {
                                pos = Random.Range(0, maxposiciones);
                                T = 0;
                            }
                            else
                            {
                                T = posicionesG.Count;
                            }
                        }
                        GameObject enemigos1 = Instantiate(enemigos[2], posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        GameObject explosion3 = Instantiate(explosion, posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        Destroy(explosion3, 0.5f);
                        posicionesG.Add(pos);
                    }
                }
                if(maxenemigo4rondas[ronda] > 0)
                {
                    for(int i = 0; i < maxenemigo4rondas[ronda]; i++)
                    {
                        int pos = Random.Range(0, maxposiciones);
                        for(int T = 0; T < posicionesG.Count; T++)
                        {
                            if(pos == posicionesG[T])
                            {
                                pos = Random.Range(0, maxposiciones);
                                T = 0;
                            }
                            else
                            {
                                T = posicionesG.Count;
                            }
                        }
                        GameObject enemigos1 = Instantiate(enemigos[3], posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        GameObject explosion4 = Instantiate(explosion, posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        Destroy(explosion4, 0.5f);
                        posicionesG.Add(pos);
                    }
                }
                if(maxenemigo5rondas[ronda] > 0)
                {
                    for(int i = 0; i < maxenemigo5rondas[ronda]; i++)
                    {
                        int pos = Random.Range(0, maxposiciones);
                        for(int T = 0; T < posicionesG.Count; T++)
                        {
                            if(pos == posicionesG[T])
                            {
                                pos = Random.Range(0, maxposiciones);
                                T = 0;
                            }
                            else
                            {
                                T = posicionesG.Count;
                            }
                        }
                        GameObject enemigos1 = Instantiate(enemigos[4], posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        GameObject explosion5 = Instantiate(explosion, posiciones[pos].transform.position, posiciones[pos].transform.rotation);
                        Destroy(explosion5, 0.5f);
                        posicionesG.Add(pos);
                    }
                }
                else if(ronda == maxronda)
                {manager.datosconfig.carga = "piso1_al1";
            manager.guardarconfig();
            manager.guardar();
				SceneManager.LoadScene("carga");}
                temp = 0;
                actinironda = false;
            }
        }
        
    }
    


    public void rondaC()
    {
        if(ronda  == maxronda)
        {
            rondaText.text = "consegido";
            rondaAnim.Play("ordasanim1");
            contadorene = 1;
            //si ganaste dara el torneo como superado
        }
        else
        {
            posicionesG = new List<int>();
            rondaText.text = "Ronda " + (ronda+1).ToString();
            rondaAnim.Play("ordasanim1");
            contadorene = maxenemigosrondas[ronda];
        }
        jugador.transform.position = posjugador;
        jugador.transform.eulerAngles = jugrotation;
        jugador.camara.transform.localEulerAngles = new Vector3(0, 0, 0);
        jugador.controlact = false;
        actinironda = true;
        temp = 0;
        
        
    }

    
}
