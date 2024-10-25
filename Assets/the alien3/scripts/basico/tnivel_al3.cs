using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tnivel_al3: MonoBehaviour
{
    public int nivel = 1;
    public int jefe = 0;
    public bool tpr;
    public bool tp;
    public bool tp15;
    public Vector3 destino;
    public GameObject platpers;
    public bool platpersact;
    private Controles controles;
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
    public float temp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
    public void OnTriggerStay(Collider col) 
    {
        jugador1_al3 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al3>();
        if (col.gameObject.tag == "Player" && controles.al3.y.ReadValue<float>() > 0)
		{
            if(nivel == 1 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel1_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 2 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel2_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 3 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel3_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 4 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel4_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 5 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel5_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 6 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel6_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 7 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel7_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 8 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel8_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 9 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel9_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 10 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel10_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 11 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel11_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 12 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel12_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 13 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel13_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 14 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel14_al3");
                jugador.tempboton = 0;
            }
            if(nivel == 15 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("nivel15_al3");
                jugador.tempboton = 0;
            }
            if(jefe == 1 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("escena2_al3");
                jugador.tempboton = 0;
            }
            if(jefe == 2 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("escena4_al3");
                jugador.tempboton = 0;
            }
            if(jefe == 3 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("escena6_al3");
                jugador.tempboton = 0;
            }
            if(jefe == 4 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("escena8_al3");
            }
            if(jefe == 5 && tp == false && tpr == false)
            {
                SceneManager.LoadScene("escena10_al3");
            }
            if(tpr == true)
            {
                SceneManager.LoadScene("carga_al3");
            }
            if(tp == true && jugador.tempboton > 0.5f)
            {
                col.gameObject.transform.localPosition = destino;
                jugador.tempboton = 0;
                temp = 0;
            }
            if(platpersact == true)
            {
                platpers.SetActive(true);
            }
            if(tp15 == true)
            {
                SceneManager.LoadScene("mundo15");
            }

            
		}
    }
}
