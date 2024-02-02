using UnityEngine;

public class platx1_al3: MonoBehaviour
{
	public int lado;


	public float aux;

	public float tiempo = 5;

	public float vel;
	private void Start()
	{
	}

	private void Update()
	{
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
	}


}
