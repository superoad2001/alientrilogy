using UnityEngine;
using TMPro;

public class cambia_nombre : MonoBehaviour
{
    public TextMeshProUGUI nombre;
    public manager_al1 manager1;
    public manager_al2 manager2;
    public manager_al3 manager3;
    private string nombreoriginal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if((manager_al1)FindFirstObjectByType(typeof(manager_al1)) != null)
        {
            manager1 = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        }
        if((manager_al2)FindFirstObjectByType(typeof(manager_al2)) != null)
        {
            manager2 = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
        }
        if((manager_al3)FindFirstObjectByType(typeof(manager_al3)) != null)
        {
            manager3 = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        }
    }

    public void cambio()
    {
        if(manager1 != null)
        {
            nombre.text = nombre.text.Replace("<nombre1>", manager1.datosserial.nameCH[0]);
            nombre.text = nombre.text.Replace("<nombre2>", manager1.datosserial.nameCH[1]);
            nombre.text = nombre.text.Replace("<nombre3>", manager1.datosserial.nameCH[2]);
            nombre.text = nombre.text.Replace("<nombre4>", manager1.datosserial.nameCH[3]);
        }
        if(manager2 != null)
        {
            nombre.text = nombre.text.Replace("<nombre1>", manager2.datosserial.nameCH[0]);
            nombre.text = nombre.text.Replace("<nombre2>", manager2.datosserial.nameCH[1]);
            nombre.text = nombre.text.Replace("<nombre3>", manager2.datosserial.nameCH[2]);
            nombre.text = nombre.text.Replace("<nombre4>", manager2.datosserial.nameCH[3]);
        }
        if(manager3 != null)
        {   

        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(nombre.text != nombreoriginal)
        {cambio();}
        

    }
}
