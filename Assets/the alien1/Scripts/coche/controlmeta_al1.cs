using UnityEngine;

public class controlmeta_al1 : MonoBehaviour
{
    public int IDCheck;
    public controlcoche_al1 control;
    public int[] checkverificado = new int[4];
    public int IDCheckP;
    public posicioncoche_al1 pos1;
    public controlchecksec_al1[] SecSig;
    public controlcheck_al1 prinfinal;
    public bool rectaynocurva;
    public float temp;

    void Start()
    {
        control = (controlcoche_al1)FindFirstObjectByType(typeof(controlcoche_al1));

    }
    public void fincheckene(int i)
    {

      
                control.enemigos[i-1].posactual = 0;

                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
                control.vueltasJ[i]++;
                
            
                

                if(SecSig.Length == 0)
                {
                    int decposruta2 = Random.Range(0,4);
                    control.enemigos[i-1].ruta = new GameObject[1];
                    control.enemigos[i-1].ruta[0] = prinfinal.pos1.pos[decposruta2];
                }
                else
                {
                    control.enemigos[i-1].ruta = new GameObject[SecSig.Length+1];
                    for(int t = 0; t < SecSig.Length;  t++ )
                    {
                        int decposruta1 = Random.Range(0,4);
                        control.enemigos[i-1].ruta[t] = SecSig[t].pos1.pos[decposruta1];   
                    }
                    int decposruta2 = Random.Range(0,4);
                    control.enemigos[i-1].ruta[SecSig.Length] = prinfinal.pos1.pos[decposruta2]; 
                }
                

                

            
        
    }
    public void fincheck(int i)
    {
        if(control.IDsigprin[i] == IDCheck )
        {

            if(checkverificado[i] == 4 && control.checkprinCompletos[i] == control.checkprinmax)
            {
                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
                control.vueltasJ[i]++;
            }
            
           
            else if(checkverificado[i] == 4 && control.vueltasJ[i] < 0 && i == 0)
            {
                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
                control.vueltasJ[i] = 0;
            }
            else if(checkverificado[i] == 4 && control.checkprinCompletos[i] != control.checkprinmax && i == 0)
            {
                control.IDsigSec[i] = 0;
                control.checkprinCompletos[i] = 0;
                checkverificado[i] = 0;
                control.IDsigprin[i] = 0;
            }
            



        }
        
        if(control.IDsigprin[i] == 0 && i == 0)
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
