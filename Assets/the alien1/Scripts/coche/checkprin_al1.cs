using UnityEngine;

public class checkprin_al1 : MonoBehaviour
{
    public bool check1;
    public bool check2;
    public int IDCheck;
    public controlcoche_al1 control;
    private Renderer Rend;

    public controlcheck_al1 controlcheck;

    void Start()
    {
        GetComponent<Renderer>().enabled = false;
        control = (controlcoche_al1)FindFirstObjectByType(typeof(controlcoche_al1));
        IDCheck = controlcheck.IDCheck;
    }

    private void OnTriggerEnter(Collider col)
    {
        for(int i = 0; i < control.maxjug;  i++ )
        {   
            if(check1)
            {
                if (col.gameObject.tag == control.name[i])
                {

                    if(controlcheck.checkverificado[i] == 0)
                    {
                        controlcheck.checkverificado[i] = 1;
                    }
                    else if(controlcheck.checkverificado[i] == 3)
                    {
                        controlcheck.checkverificado[i] = 2;
                    }
                    else if(controlcheck.checkverificado[i] == -1)
                    {
                        controlcheck.checkverificado[i] = -2;
                    }
                    
                }
            }
            if(check2)
            {
                if (col.gameObject.tag == control.name[i])
                {   
                    if(controlcheck.checkverificado[i] == 1)
                    {
                        controlcheck.checkverificado[i] = 2;
                    }
                    else if(controlcheck.checkverificado[i] == 0)
                    {
                        controlcheck.checkverificado[i] = -1;
                    }
                    else if(controlcheck.checkverificado[i] == -3)
                    {
                        controlcheck.checkverificado[i] = -2;
                    }
                    
                }
            }
        }
        
    } 

    

    private void OnTriggerExit(Collider col)
    {

        for(int i = 0; i < control.maxjug;  i++ )
        {  
            if(check1)
            {
                if (col.gameObject.tag == control.name[i])
                {
                    if(controlcheck.checkverificado[i] == 1)
                    {
                        controlcheck.checkverificado[i] = 0;
                    
                    }
                    else if(controlcheck.checkverificado[i] == 2)
                    {
                        controlcheck.checkverificado[i] = 3;
                    
                    }

                    else if(controlcheck.checkverificado[i] == -3)
                    {
                        controlcheck.checkverificado[i] = -4;
                        controlcheck.fincheck(i);
                    
                    }
                    else if(controlcheck.checkverificado[i] == -2)
                    {
                        controlcheck.checkverificado[i] = -1;
                    
                    }
                    else 
                    {
                        controlcheck.checkverificado[i] = 0;
                    }

                }
            }
            if(check2)
            {
                if (col.gameObject.tag == control.name[i])
                {
                    if(controlcheck.checkverificado[i] == 3)
                    {
                        controlcheck.checkverificado[i] = 4;
                        controlcheck.fincheck(i);
                    
                    }
                    else if(controlcheck.checkverificado[i] == 2)
                    {
                        controlcheck.checkverificado[i] = 1;
                    
                    }

                    else if(controlcheck.checkverificado[i] == -1)
                    {
                        controlcheck.checkverificado[i] = 0;
                    
                    }
                    else if(controlcheck.checkverificado[i] == -2)
                    {
                        controlcheck.checkverificado[i] = -3;
                    
                    }
                    else 
                    {
                        controlcheck.checkverificado[i] = 0;
                    }

                }
            }
        }
    } 
}
