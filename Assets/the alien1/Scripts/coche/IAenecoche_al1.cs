using UnityEngine;

public class IAenecoche_al1 : MonoBehaviour
{
    public int IDene;
    public GameObject[] ruta;
    public float velocidad;
    public int posactual;
    public bool derrape;
    public bool turbo;
    public float temp;
    public int turbocont;
    public GameObject derrapeOBJ;
    public GameObject largoOBJ;
    public GameObject cortoOBJ;

    public AudioSource cortoson;
    public AudioSource derrapeson;
	public AudioSource turboson;
    public bool controlact;


    void Start()
    {
        velocidad = 30;
    }

    void Update()
    {
        cortoson.Pause();
        turboson.Pause();
        derrapeson.Pause();
        if(controlact)
        {

            

            if(turbo && turbocont > 0)
            {
                velocidad = 60;
                derrapeOBJ.SetActive(false);
                cortoOBJ.SetActive(false);
                largoOBJ.SetActive(true);
                if(velocidad > 75)
                {
                    velocidad = 75;
                }
                temp = 0;
                cortoson.Pause();
                turboson.UnPause();
                derrapeson.Pause();
            }
            else if(derrape)
            {
                turbo = false;
                velocidad = 55;
                if(velocidad > 55)
                {
                    velocidad = 55;
                }
                if(temp > 5)
                {
                    if(turbocont < 2)
                    {
                        turbocont++;
                        temp = 0;
                    }
                    
                }
                derrapeOBJ.SetActive(true);
                cortoOBJ.SetActive(false);
                largoOBJ.SetActive(false);
                cortoson.Pause();
                turboson.Pause();
                derrapeson.UnPause();
            }
            else
            {
                if(velocidad > 50)
                {
                    velocidad = 50;
                }
                derrapeOBJ.SetActive(false);
                cortoOBJ.SetActive(true);
                largoOBJ.SetActive(false);
                turbo = false;
                temp = 0;
                float velmech = velocidad -20;
                cortoOBJ.transform.localScale = new Vector3(cortoOBJ.transform.localScale.x,0.8f + ((velmech/200)*29f),cortoOBJ.transform.localScale.z);
                cortoson.UnPause();
                turboson.Pause();
                derrapeson.Pause();
            }
            
            

            
            if(temp< 15 && derrape == true)
            {temp += 1 * Time.deltaTime;}

            if(posactual > ruta.Length)
            {
                posactual = ruta.Length;
            }

            velocidad += 2 * Time.deltaTime;
            
            if(velocidad < 30)
            {
                velocidad = 30;
            }
            if(ruta.Length >= 0)
            {
                transform.position = Vector3.MoveTowards(transform.position,ruta[posactual].transform.position, velocidad * Time.deltaTime);
                transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(transform.forward,ruta[posactual].transform.forward, 1 * Time.deltaTime,0));
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if(ruta.Length > 0)
        {
            if(col.gameObject  ==  ruta[posactual])
            {
                posactual++;
            }
        }
        
    }

}
