using UnityEngine;

public class controlcheck_al1 : MonoBehaviour
{
    public int IDCheck;
    public controlcoche_al1 control;
    public int[] checkverificado = new int[4];
    public int IDCheckP;
    public posicioncoche_al1 pos1;
    public controlchecksec_al1[] SecSig;
    public controlcheck_al1 prinfinal;
    public controlmeta_al1 prinfinalmeta;
    public bool rectaynocurva;
    public bool metaynoprincipal;
    void Start()
    {
        control = (controlcoche_al1)FindFirstObjectByType(typeof(controlcoche_al1));
        

    }
    public void fincheckene(int i)
    {
   
                
                control.enemigos[i-1].posactual = 0;

                control.IDsigSec[i] = IDCheckP + 1;
                control.checkprinCompletos[i]++;
                checkverificado[i] = 0;
                control.IDsigprin[i] = IDCheck+1;
                int azar = Random.Range(0,2);
                control.enemigos[i-1].turbo = false;
                control.enemigos[i-1].derrape = false;
                if(rectaynocurva)
                {
                    if(azar == 1)
                    {
                        control.enemigos[i-1].turbo = true;
                    }
                }
                else
                {
                    if(azar == 1)
                    {
                        control.enemigos[i-1].derrape = true;
                    }
                }
                
                
                if(SecSig.Length == 0)
                {
                    if(metaynoprincipal == true)
                    {
                        int decposruta2 = Random.Range(0,4);
                        control.enemigos[i-1].ruta = new GameObject[1];
                        control.enemigos[i-1].ruta[0] = prinfinalmeta.pos1.pos[decposruta2];  
                    }
                    else
                    {
                        int decposruta2 = Random.Range(0,4);
                        control.enemigos[i-1].ruta = new GameObject[1];
                        control.enemigos[i-1].ruta[0] = prinfinal.pos1.pos[decposruta2];  
                    }
                }
                else
                {
                    
                    control.enemigos[i-1].ruta = new GameObject[SecSig.Length+1];
                    for(int t = 0; t < SecSig.Length;  t++ )
                    {
                        int decposruta1 = Random.Range(0,4);
                        control.enemigos[i-1].ruta[t] = SecSig[t].pos1.pos[decposruta1];   
                    }

                    if(metaynoprincipal == true)
                    {
                        int decposruta2 = Random.Range(0,4);
                        control.enemigos[i-1].ruta[SecSig.Length] = prinfinalmeta.pos1.pos[decposruta2];  
                    }
                    else
                    {
                        int decposruta2 = Random.Range(0,4);
                        control.enemigos[i-1].ruta[SecSig.Length] = prinfinal.pos1.pos[decposruta2];  
                    }
                    

                }
                

                

            
        
    }
    public void fincheck(int i)
    {
        if(control.IDsigprin[i] == IDCheck && (int)control.checkprinCompletos[i] == (int)IDCheck )
        {
            if(checkverificado[i] == 4)
            {
                control.IDsigSec[i] = IDCheckP + 1;
                control.checkprinCompletos[i]++;
                checkverificado[i] = 0;
                control.IDsigprin[i] = IDCheck+1;
            }
        }
        if(control.IDsigprin[i] == (IDCheck+1) && control.checkprinCompletos[i] == (IDCheck+1) && i == 0)
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
