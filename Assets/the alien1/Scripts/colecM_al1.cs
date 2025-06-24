using UnityEngine;

public class colecM_al1 : MonoBehaviour
{
    public int npcid;
    public int misionID;
    public manager_al1 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if (manager.datosserial.misiones[misionID] != 1)
        {
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager.datosserial.misiones[misionID] = 2;
            manager.datosserial.npcF[npcid]++;
            manager.guardar();
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }
}
