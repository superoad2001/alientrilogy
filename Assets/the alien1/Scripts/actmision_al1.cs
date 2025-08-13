using UnityEngine;

public class actmision_al1 : MonoBehaviour
{
    public bool activador;
    public bool fin;
    public manager_al1 manager;
    public int ID;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(activador == true)
        {
            manager.datosserial.misiones[ID] = 1;
        }

        if(fin == true)
        {
            manager.datosserial.misiones[ID] = 2;
        }
        manager.guardar();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
