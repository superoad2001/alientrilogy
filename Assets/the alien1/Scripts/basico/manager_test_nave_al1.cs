using UnityEngine;

public class manager_test_nave_al1 : MonoBehaviour
{

    public enemigo1nave_al1 testene1;
    public enemigo2nave_al1 testene2;
    public enemigo3nave_al1 testene3;
    public jugador_al1 jugador;
    public manager_al1 manager;
    public int nivelG;
    public int nivelarma;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(testene1 != null)
        {
            testene1.nivelactual = nivelG;
        }
        if(testene2 != null)
        {
            testene2.nivelactual = nivelG;
        }
        if(testene3 != null)
        {
            testene3.nivelactual = nivelG;
        }
        manager.datosserial.niveljugnave = nivelG;
        manager.datosserial.nivelarmanave1 = nivelarma;
        manager.datosserial.nivelarmanave2 = nivelarma;
        manager.datosserial.nivelarmanave3 = nivelarma;
        manager.datosserial.nivelarmanave4 = nivelarma;
        manager.guardar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
