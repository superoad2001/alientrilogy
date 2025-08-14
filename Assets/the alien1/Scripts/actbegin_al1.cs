using UnityEngine;

public class actbegin_al1 : MonoBehaviour
{

    public manager_al1 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        manager.datosserial.begin = true;
        manager.guardar();


    }

}
