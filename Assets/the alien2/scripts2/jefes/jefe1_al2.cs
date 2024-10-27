using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jefe1_al2 : MonoBehaviour
{
	public float vida;
	public float vidamax;
	public Image vidab;


	public Text cuentavidae;
	
	public float tiempodisp = 0;

	public int dispa;

	public GameObject jugador;

	public float velocidad;
	public float vel2 = 50;

	private Rigidbody rb;

	public GameObject caja1;
	public GameObject caja2;
	public GameObject caja3;
	public GameObject caja4;
	public GameObject caja5;
	public GameObject caja6;
	public GameObject caja7;
	public GameObject caja8;
	public GameObject caja9;
	public GameObject caja10;
	public GameObject caja11;
	public GameObject caja12;

	public GameObject balaprefab;

	public float balavel;

	public AudioSource disp;

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "bala")
        {
         	vida--;
			UnityEngine.Object.Destroy(col.gameObject);
			
        }
		if (col.gameObject.tag == "portal")
        {
			jugador1_al2 jugador = (jugador1_al2)FindFirstObjectByType(typeof(jugador1_al2));
         	jugador.muerte = true;
			
        }
	}
	public manager_al2 manager;
	private void Start()
	{
		this.rb = base.GetComponent<Rigidbody>();
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
			
	}

	private void Update()
	{


		vidab.fillAmount = vida/vidamax;

		
		

		if(manager.datosconfig.idioma == "es")
		{
		cuentavidae.text = "GRUMETE BILL: "+vida;
		}
		if(manager.datosconfig.idioma == "en")
		{
		cuentavidae.text = "CABIN BOY BILL: "+vida;
		}
		if(manager.datosconfig.idioma == "cat")
		{
		cuentavidae.text = "GRUMET BILL: "+vida;
		}
		
		base.transform.Translate(Vector3.forward * Time.deltaTime * 1 * this.velocidad);
		if (tiempodisp > 1)
		{
			disparo();
			tiempodisp = 0;
		}
		if (tiempodisp < 15)
		{tiempodisp += 1 * Time.deltaTime; }
		
		if (vida <= 0 && manager.datosserial.tengosaltod == 1)
		{
			SceneManager.LoadScene("mundo_abierto_al2");
		}
		if (vida <= 0 && manager.datosserial.tengosaltod == 0)
		{
			SceneManager.LoadScene("mejora1_al2");
		}
	}
	public void disparo()
	{
		dispa = Random.Range(1,12);
		if (dispa == 1)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja1.transform.position,caja1.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 2)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja2.transform.position,caja2.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 3)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja3.transform.position,caja3.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 4)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja4.transform.position,caja4.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 5)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja5.transform.position,caja5.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 6)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja6.transform.position,caja6.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 7)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja7.transform.position,caja7.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 8)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja8.transform.position,caja8.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 9)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja9.transform.position,caja9.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 10)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja10.transform.position,caja10.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 11)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja11.transform.position,caja11.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 12)
		{
			GameObject BalaTemporal = Instantiate(balaprefab, caja12.transform.position,caja12.transform.rotation) as GameObject;

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
	}
}
