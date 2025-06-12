using UnityEngine;

public class modeventolista_al1 : MonoBehaviour
{
    public int evento;
    public manager_al1 manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(evento == 0)
        {
            manager.datosserial.eventos[1] = false;
            manager.datosserial.eventos[2] = true;
            manager.guardar();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
