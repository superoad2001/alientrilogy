using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigo2_al2: MonoBehaviour
{
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
    public float temp;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(objetivo == null)
        {
            objetivo = objetivob;
            objetivo1 = objetivo1b;
        }

        if(detectar == true && desactivar == false)
        {
            if(temp > 3f)
            {
                anim.SetBool("atk",true);
                temp = 0;
            }
            else
            {
                anim.SetBool("atk",false);
            }
            transform.position = Vector3.MoveTowards(transform.position,objetivo.transform.position + new Vector3(0,0,-3),vel * Time.deltaTime);
            Vector3 direction = objetivo1.position - transform.position;
            rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(transform.rotation.eulerAngles.x,rotation.eulerAngles.y,transform.rotation.eulerAngles.z),2f * Time.deltaTime);
            temp += 1 * Time.deltaTime;
        }
        
        
    }
    private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.tag == "bala")
		{
            Destroy(gameObject);
			
		}
	}
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "respawn")
		{
			Destroy(gameObject);
		}
        
    }
}
