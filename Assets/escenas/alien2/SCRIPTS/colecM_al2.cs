using UnityEngine;

public class colecM_al2 : MonoBehaviour
{
    public int npcid;
    public int misionID;
    public manager_al2 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
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
            manager.datosserial.npcF[npcid]++;
            manager.guardar();
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }
}
