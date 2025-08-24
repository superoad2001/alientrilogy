using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo1_al2: MonoBehaviour
{
	public manager_al2 manager;
    public bool detectar;
    public GameObject objetivo;
    public GameObject objetivob;
    public Quaternion rotation;
    public Transform objetivo1;
    public Transform objetivo1b;
    public Rigidbody rb_;
    public float vel = 2;
    public bool desactivar;
    public enemigodet_al2 enemigodet;
    public GameObject dano;
    public GameObject det;
    public GameObject explosion;
    public jugador_al2 jugador1;
    public AudioSource muertes;
    public GameObject muertesaudio;
    // Start is called before the first frame update
    void Start()
    {
        jugador1 = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        jugador1.explosion = explosion;
        if(GameObject.Find("muerteaudio") == true)
		{muertes = GameObject.Find("muerteaudio").GetComponent<AudioSource>();}
    }

    // Update is called once per frame
    void Update()
    {
        det.transform.position = this.transform.position;
        dano.transform.position = this.transform.position;
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }
        
        if(detectar == true && desactivar == false)
        {
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position,vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
        }
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "bala")
		{
            GameObject explosiont = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
            Destroy(transform.parent.gameObject);
            Destroy(explosiont, 1f);
            manager.datosserial.enemigos_muertos++;
            manager.guardar();
            muertes.Play();
			
		}

	}
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "respawn")
		{
			Destroy(transform.parent.gameObject);
            muertes.Play();
		}
        
    }
}
