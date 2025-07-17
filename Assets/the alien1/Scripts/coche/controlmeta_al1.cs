using UnityEngine;

public class controlmeta_al1 : MonoBehaviour
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
        if(control.IDsigprin[i] == IDCheck)
        {

            if(checkverificado[i] == 4 && control.checkprinCompletos[i] == control.checkprinmax)
            {
                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
                control.vueltasJ[i]++;
            }
           
            else if(checkverificado[i] == 4 && control.vueltasJ[i] < 0)
            {
                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
                control.vueltasJ[i] = 0;
            }
            else if(checkverificado[i] == 4 && control.checkprinCompletos[i] != control.checkprinmax)
            {
                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
            }
            



        }
        
        if(control.IDsigprin[i] == 0)
        {

            if(checkverificado[i] == -4 && control.checkprinCompletos[i] == 0 && control.vueltasJ[i] <= 0)
            {
                control.IDsigSec[i] = IDCheckP;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = IDCheck;
                control.vueltasJ[i] = 0;
            }
            else if(checkverificado[i] == -4 )
            {
                control.IDsigSec[i] = IDCheckP;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = IDCheck;
                control.vueltasJ[i]--;
            }
        }
    }
}
