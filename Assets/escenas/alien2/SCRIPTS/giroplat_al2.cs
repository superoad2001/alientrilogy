using UnityEngine;

public class giroplat_al2 : MonoBehaviour
{

    public GameObject part;
    public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			part.SetActive(true);
		}

	}
	public void OnTriggerExit(Collider col)
	{

		if (col.gameObject.tag == "Player")
		{
			part.SetActive(false);
		}
	}
}
