using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jefe1_al3: MonoBehaviour
{
	public long vida;
	public long vidamax;
	public Image vidab;

	public int jefe = 1;

	public Text cuentavidae;

	public float tiempodisp = 0;

	public int dispa;
	public int dispa2;

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
	public float balafrec = 0.5f;

	public GameObject balaprefab;
	public GameObject balaprefab2;

	public float balavel;

	public AudioSource disp;
	public manager_al3 manager;
	public GameObject respawnm;
	public GameObject juego;

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "bala")
        {
			jugador1_al3 jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));
         	vida -= (5987 * jugador.fuerzanave )- 987;
			UnityEngine.Object.Destroy(col.gameObject);
			
        }
		if (col.gameObject.tag == "portal")
        {
			respawnm.SetActive(true);
            juego.SetActive(false);

			
        }
	}

	private void Start()
	{
		this.rb = base.GetComponent<Rigidbody>();
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
	}

	private void Update()
	{
		
		base.transform.Translate(Vector3.forward * Time.deltaTime * 1 * this.velocidad);
		if (tiempodisp > balafrec)
		{
			disparo();
			tiempodisp = 0;
		}
		if (tiempodisp < 15)
		{tiempodisp += 1 * Time.deltaTime; }
		vidab.fillAmount = (float)vida/(float)vidamax;
		cuentavidae.text = "vida: "+vida;
		if (vida <= 0)
		{
			if (jefe == 1)
			{
				if(manager.datosserial.espacio2act == 1)
				{manager.datosserial.espacio2act = 2;
				manager.guardar();}
				SceneManager.LoadScene("espacio2_al3");
			}
			if (jefe == 2)
			{
				if(manager.datosserial.espacio3act == 1)
				{manager.datosserial.espacio3act = 2;}
				manager.guardar();
				SceneManager.LoadScene("espacio3_al3");
			}
			if (jefe == 3)
			{
				if(manager.datosserial.espacio4act == 1)
				{manager.datosserial.espacio4act = 2;}
				manager.guardar();
				SceneManager.LoadScene("espacio4_al3");
			}
			if (jefe == 4)
			{
				if(manager.datosserial.espacio5act == 1)
				{manager.datosserial.espacio5act =  2;}
				manager.guardar();
				SceneManager.LoadScene("espacio5_al3");
			}
			if (jefe == 5)
			{
				manager.datosserial.final1 = 1;
				manager.guardar();
				SceneManager.LoadScene("escena12_al3");
			}
			if (jefe == 6)
			{
				if(manager.datosserial.espacio0act == 0)
				{manager.datosserial.espacio0act =  1;}
				manager.guardar();
				SceneManager.LoadScene("espacio0_al3");
			}
		}
	}
	public void disparo()
	{
		dispa = Random.Range(1,12);
		dispa2 = Random.Range(1,6);
		GameObject BalaTemporal = null;
		if (dispa == 1)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja1.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja1.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 2)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja2.transform.position,caja2.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja2.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 3)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja3.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja3.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 4)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja4.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja4.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 5)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja5.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja5.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 6)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja6.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja6.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 7)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja7.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja7.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 8)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja8.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja8.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 9)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja9.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja9.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 10)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja10.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja10.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 11)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja11.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja11.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
		if (dispa == 12)
		{
			if(dispa2 >= 1 && dispa2 <= 4)
			{
				BalaTemporal = Instantiate(balaprefab, caja12.transform.position,caja1.transform.rotation) as GameObject;
			}
			if(dispa2 == 5)
			{
				BalaTemporal = Instantiate(balaprefab2, caja12.transform.position,caja1.transform.rotation) as GameObject;
			}

			Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

			rb.AddForce(transform.forward * vel2 * -balavel);

			Destroy(BalaTemporal, 9.0f);

			disp.Play();
		}
	}
}
