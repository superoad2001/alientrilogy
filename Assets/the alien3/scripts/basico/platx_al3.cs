using UnityEngine;

public class platx_al3: MonoBehaviour
{
	public int lado;


	public float aux;

	public float tiempo = 5;

	public float vel;
	public bool tp;
	public Vector3 cord;
	public Transform juego;
	private void Start()
	{
	}

	private void Update()
	{
		if(tp == true)
		{
			transform.localPosition = cord;
			tp = false;
			tiempo = 0;
		}
		if(tiempo > 2)
		{
			base.transform.position -= lado * vel * Time.deltaTime * Vector3.left;
		}
		if(tiempo < 15)
        {tiempo += 1 * Time.deltaTime;}
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "back")
		{
			tiempo = 0;
			lado = -1;
		}
		if (col.gameObject.tag == "forward")
		{
			tiempo = 0;
			lado = 1;
		}
		
		
	}

	private void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.transform.parent = this.transform;
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.transform.parent = this.transform;
		}
	}

	private void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.transform.parent = juego;
		}
	}
}
