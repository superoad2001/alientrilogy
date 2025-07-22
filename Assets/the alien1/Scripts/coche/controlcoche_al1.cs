using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class controlcoche_al1 : MonoBehaviour
{
    public GameObject[] checkpointsprin;
    public GameObject[] checkpointsSec;
    public int[] IDsigSec = new int[4];
    public int checkpointsSecMax;

    public GameObject[] jugG = new GameObject[4];

    public int[] checkprinCompletos = new int[4];
    public int[] IDsigprin = new int[4];
    public int checkprinmax;


    public int[] vueltasJ = new int[4];
    public int[] posicionJ = new int[4];
    public int vueltasmax;
    public int asign = 2;
    public GameObject[] jug = new GameObject[4];


    public float[] jugpos = new float[4];

    public bool[] muerte;

    
    
    
    


    public int maxjug;
    public Text vueltasT;
    public Text posicionT;
    
    public string[] name = new string[4];
    public int[] listaposini = new int[4];

    private int decpos;
    private int[] decpos4 = new int[4];
    private int maxdecpos4 = 4;
    public controlmeta_al1 controlmeta;
    public IAenecoche_al1[] enemigos;


    

    void Start()
    {
        name[0] = "Player";
        name[1] = "carreraene1";
        name[2] = "carreraene2";
        name[3] = "carreraene3";

        listaposini[0] = 9;
        listaposini[1] = 9;
        listaposini[2] = 9;
        listaposini[3] = 9;
        

        for(int i = 0; i < maxjug;  i++ )
        {
            decpos = Random.Range(0,4);
            Debug.Log("1 : "+i+" : "+decpos);
            if(i == 0)
            {
                listaposini[0] = decpos;
            }
            for(int z = 0; z < 2;  z++ )
            {
                z = 1;
                if(listaposini[0] == decpos)
                {
                    decpos = Random.Range(0,4);   
                    z = 0;
                }
                if(listaposini[1] == decpos)
                {
                    decpos = Random.Range(0,4);   
                    z = 0;
                }
                if(listaposini[2] == decpos)
                {
                    decpos = Random.Range(0,4);   
                    z = 0;
                }
                
                
            }
            Debug.Log("4 : "+i+" : "+decpos);
            listaposini[i] = decpos;
        }

        for(int i = 0; i < maxjug;  i++ )
        {

            jug[i].transform.position = checkpointsprin[checkprinmax].GetComponent<controlmeta_al1>().pos1.pos[listaposini[i]].transform.position;
            jug[i].transform.rotation = checkpointsprin[checkprinmax].GetComponent<controlmeta_al1>().pos1.pos[listaposini[i]].transform.rotation;              

        }
        for(int i = 1; i < maxjug;  i++ )
        {   
            enemigos[i-1].posactual = 0;
            if(controlmeta.SecSig.Length == 0)
            {
                int decposruta2 = Random.Range(0,4);
                enemigos[i-1].ruta = new GameObject[1];
                enemigos[i-1].ruta[0] = controlmeta.prinfinal.pos1.pos[decposruta2];
            }
            else
            {
                enemigos[i-1].ruta = new GameObject[controlmeta.SecSig.Length+1];
                for(int t = 0; t == controlmeta.SecSig.Length;  t++ )
                {
                    int decposruta1 = Random.Range(0,4);
                    enemigos[i-1].ruta[t] = controlmeta.SecSig[t].pos1.pos[decposruta1];   
                }
                int decposruta2 = Random.Range(0,4);
                enemigos[i-1].ruta[controlmeta.SecSig.Length] = controlmeta.prinfinal.pos1.pos[decposruta2];  

            }
               

        }
        
    }
    void Update()
    {   

        for(int i = 0; i < maxjug;  i++ )
        {
            if(muerte[i] == true)
            {
                
                if(IDsigprin[i] == 0)
                {
                    decpos = Random.Range(0,4);
                    jug[i].transform.position = checkpointsprin[checkprinmax].GetComponent<controlmeta_al1>().pos1.pos[decpos].transform.position;
                    jug[i].transform.rotation = checkpointsprin[checkprinmax].GetComponent<controlmeta_al1>().pos1.pos[decpos].transform.rotation;
                }
                else
                {
                    decpos = Random.Range(0,4);
                    jug[i].transform.position = checkpointsprin[IDsigprin[i]-1].GetComponent<controlcheck_al1>().pos1.pos[decpos].transform.position;
                    jug[i].transform.rotation = checkpointsprin[IDsigprin[i]-1].GetComponent<controlcheck_al1>().pos1.pos[decpos].transform.rotation;
                }
                
                muerte[i] = false;
            }
        }
        vueltasT.text = vueltasJ[0]+"/"+vueltasmax;
        
        posicionJ[0] = 0;
        posicionJ[1] = 0;
        posicionJ[2] = 0;
        posicionJ[3] = 0;
        
        for(int i = 0; i < maxjug;  i++ )
        { 
            if(i == 0)
            {

                posicionJ[i] = 1;
                asign = 1;
                
                
            }
            else
            {
                


                for(int g = 0; g < i;  g++ )
                {

                    if(vueltasJ[i] > vueltasJ[g])
                    {
                        posicionJ[i] = posicionJ[g];
                        posicionJ[g] += 1;
                        
                    }
                    else if(vueltasJ[i] == vueltasJ[g])
                    {
                        
                        if(IDsigSec[i] > IDsigSec[g])
                        {
                            posicionJ[i] = posicionJ[g];
                            posicionJ[g] += 1;
                            
                        }
                        else if(IDsigSec[i] == IDsigSec[g])
                        {
                            recpos(IDsigSec[i],i,g);
                            if(jugpos[i] < jugpos[g])
                            {
                                posicionJ[i] = posicionJ[g];
                                posicionJ[g] += 1;
                                
                                
                                
                            }
                        } 
                        
                    }
                    
                    
                    
                }
                
                
                    
                
                
            }
            if(posicionJ[i] == 0)
            {posicionJ[i] = asign;}
            asign++;
        }
        posicionT.text = posicionJ[0].ToString();
            
            
        
    }

    public void recpos(int numub,int pos1,int pos2)
    {
        jugpos[pos1] = Vector3.Distance(jug[pos1].transform.position, checkpointsSec[numub].transform.position);
        jugpos[pos2] = Vector3.Distance(jug[pos2].transform.position, checkpointsSec[numub].transform.position);
    }
    


}
