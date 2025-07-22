using UnityEngine;

public class controlchecksec_al1 : MonoBehaviour
{
    public int IDCheckP;
    public controlcoche_al1 control;
    public int[] checkverificado = new int[4];
    public posicioncoche_al1 pos1;

    void Start()
    {
        control = (controlcoche_al1)FindFirstObjectByType(typeof(controlcoche_al1));
        

    }

    public void fincheck(int i)
    {

            if(checkverificado[i] == 4)
            {
                control.IDsigSec[i] = IDCheckP + 1;
                checkverificado[i] = 0;

            }
        

            if(checkverificado[i] == -4)
            {
                control.IDsigSec[i] = IDCheckP; 
                checkverificado[i] = 0;
            }
        
    }
    public void fincheckene(int i)
    {
        control.IDsigSec[i] = IDCheckP + 1;
        checkverificado[i] = 0;     
    }
}
