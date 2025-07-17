using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class controlcoche_al1 : MonoBehaviour
{
    
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
    public int primero;

    
    
    
    


    public int maxjug;
    public Text vueltasT;
    public Text posicionT;
    
    public string[] name = new string[4];
    

    void Start()
    {
        name[0] = "Player";
        name[1] = "Palayer";
        name[2] = "Palayer";
        name[3] = "Palayer";
    }
    void Update()
    {

        
        vueltasT.text = vueltasJ[0]+"/"+vueltasmax;

        for(int i = 0; i < maxjug;  i++ )
        { 
            if(i == 0)
            {

                posicionJ[i] = 1;
                primero = i;
                
            }
            else
            {
                if(vueltasJ[i] > vueltasJ[primero])
                {
                    posicionJ[i] = 1;
                    primero = i;
                    for(int z = 0; z < i;  z++ )
                    {
                        posicionJ[z] += 1;
                    }
                    asign++;
                }
                else if(vueltasJ[i] == vueltasJ[primero])
                {
                        if(IDsigSec[i] > IDsigSec[primero])
                        {
                            posicionJ[i] = 1;
                            primero = i;
                            for(int z = 0; z < i;  z++ )
                            {
                                posicionJ[z] += 1;
                            }
                            asign++;
                        }
                        else if(IDsigSec[i] == IDsigSec[primero])
                        {
                            recpos(IDsigSec[i],i,primero);
                            if(jugpos[i] > jugpos[primero])
                            {
                                posicionJ[i] = 1;
                                primero = i;
                                for(int z = 0; z < i;  z++ )
                                {
                                    posicionJ[z] += 1;
                                }
                                asign++;
                            }
                            else
                            {
                                posicionJ[i] = asign;
                                asign++;
                            }
                        }
                        else
                        {
                            posicionJ[i] = asign;
                            asign++;
                        }
                }
                else
                {
                    posicionJ[i] = asign;
                    asign++;
                }
            }
        }
        posicionT.text = posicionJ[0].ToString();
            
            
        
    }

    public void recpos(int numub,int pos1,int pos2)
    {
        jugpos[pos1] = Vector3.Distance(jug[pos1].transform.position, checkpointsSec[numub].transform.position);
        jugpos[pos2] = Vector3.Distance(jug[pos2].transform.position, checkpointsSec[numub].transform.position);
    }
    


}
