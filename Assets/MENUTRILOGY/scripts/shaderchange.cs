using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaderchange : MonoBehaviour
{
    public Renderer rend;
    public Shader shad1;
    public Shader shad2;
    public GameObject[] allObjects;
    // Start is called before the first frame update
    void Start()
    {

        shad1 = Shader.Find("Standard");
        shad2 = Shader.Find("Shader Graphs/prueba");
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject obj in allObjects)
        {
        if (obj.activeInHierarchy)
        {
            if(obj.gameObject.GetComponent<Renderer>() != null)
            {
                rend = obj.gameObject.GetComponent<Renderer>();
                if(rend.material.shader == shad1)
                {rend.material.shader = shad2;}
            }
        }
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
