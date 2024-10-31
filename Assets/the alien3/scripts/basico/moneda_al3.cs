using UnityEngine;

public class moneda_al3: MonoBehaviour
{
	public manager_al3 manager;
	public AudioSource audio1;
	public int valor;
	public float valor2;
	public int valor3;

	private void Start()
	{
		if(valor2 >= 5)
		{
			valor3 = 3;
		}
		if(valor2 >= 20)
		{
			valor3 = 5;
		}
		if(valor2 >= 30)
		{
			valor3 = 7;
		}
		if(valor2 >= 40)
		{
			valor3 = 9;
		}
		if(valor2 >= 50)
		{
			valor3 = 11;
		}
		if(valor2 >= 60)
		{
			valor3 = 16;
		}
		if(valor2 >= 70)
		{
			valor3 = 21;
		}
		if(valor2 >= 80)
		{
			valor3 = 26;
		}
		if(valor2 >= 90)
		{
			valor3 = 31;
		}
		if(valor2 >= 100)
		{
			valor3 = 36;
		}
		valor = Random.Range(1,valor3);
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
			manager.datosserial.monedas += valor;
			manager.guardar();
			audio1.Play();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
