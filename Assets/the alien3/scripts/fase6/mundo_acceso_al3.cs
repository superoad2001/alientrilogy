using UnityEngine;
using UnityEngine.SceneManagement;

public class mundo_acceso_al3: MonoBehaviour
{

	private void Start()
	{

	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.transform.localRotation = Quaternion.Lerp(col.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
		}
	}
}
