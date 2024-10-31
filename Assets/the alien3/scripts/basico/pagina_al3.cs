using UnityEngine;

public class pagina_al3: MonoBehaviour
{
	public manager_al3 manager;
	public AudioSource audio1;
	public int diariop;


	public int tdiario1;
	public int tdiario2;
	public int tdiario3;
	public int tdiario4;
	public int tdiario5;
	public int tdiario6;
	public int tdiario7;
	public int tdiario8;
	public int tdiario9;
	public int tdiario10;
	public int tdiario11;
	public int tdiario12;
	public int tdiario13;
	public int tdiario14;
	public int tdiario15;
	private void Start()
	{
		if(diariop == 1 && tdiario1 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 2 && tdiario2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 3 && tdiario3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 4 && tdiario4 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 5 && tdiario5 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 6 && tdiario6 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 7 && tdiario7 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 8 && tdiario8 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 9 && tdiario9 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 10 && tdiario10 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 11 && tdiario11 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 12 && tdiario12 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 13 && tdiario13 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 14 && tdiario14 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 15 && tdiario15 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
			jugador1_al3 jugador = (jugador1_al3)FindFirstObjectByType(typeof(jugador1_al3));


		if(diariop == 1 && tdiario1 == 0)
		{
			manager.datosserial.tdiario1 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 2 && tdiario2 == 0)
		{
			manager.datosserial.tdiario2 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 3 && tdiario3 == 0)
		{
			manager.datosserial.tdiario3 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 4 && tdiario4 == 0)
		{
			manager.datosserial.tdiario4 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 5 && tdiario5 == 0)
		{
			manager.datosserial.tdiario5 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 6 && tdiario6 == 0)
		{
			manager.datosserial.tdiario6 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 7 && tdiario7 == 0)
		{
			manager.datosserial.tdiario7 = 1;
			manager.datosserial.diariostotal++;
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 8 && tdiario8 == 0)
		{
			manager.datosserial.tdiario8 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 9 && tdiario9 == 0)
		{
			manager.datosserial.tdiario9 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 10 && tdiario10 == 0)
		{
			manager.datosserial.tdiario10 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 11 && tdiario11 == 0)
		{
			manager.datosserial.tdiario11 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 12 && tdiario12 == 0)
		{
			manager.datosserial.tdiario12 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 13 && tdiario13 == 0)
		{
			manager.datosserial.tdiario13 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 14 && tdiario14 == 0)
		{
			manager.datosserial.tdiario14 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if(diariop == 15 && tdiario15 == 0)
		{
			manager.datosserial.tdiario15 = 1;
			manager.datosserial.diariostotal++;
			manager.guardar();
			UnityEngine.Object.Destroy(base.gameObject);
		}
		audio1.Play();
		}
	}
}
