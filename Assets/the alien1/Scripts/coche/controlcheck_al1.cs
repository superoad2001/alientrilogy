using UnityEngine;

public class controlcheck_al1 : MonoBehaviour
{
    public int IDCheck;
    public controlcoche_al1 control;
    public int[] checkverificado = new int[4];
    public int IDCheckP;

    void Start()
    {
        control = (controlcoche_al1)FindFirstObjectByType(typeof(controlcoche_al1));
        

    }

    public void fincheck(int i)
    {
        if(control.IDsigprin[i] == IDCheck && (int)control.checkprinCompletos[i] == (int)IDCheck)
        {
            if(checkverificado[i] == 4)
            {
                control.IDsigSec[i] = IDCheckP + 1;
                control.checkprinCompletos[i]++;
                checkverificado[i] = 0;
                control.IDsigprin[i] = IDCheck+1;
            }
        }
        if(control.IDsigprin[i] == (IDCheck+1) && control.checkprinCompletos[i] == (IDCheck+1))
        {
            if(checkverificado[i] == -4)
            {
                control.IDsigSec[i] = IDCheckP;
                control.checkprinCompletos[i]--;
                checkverificado[i] = 0;
                control.IDsigprin[i] = IDCheck;
            }
        }
    }
}
