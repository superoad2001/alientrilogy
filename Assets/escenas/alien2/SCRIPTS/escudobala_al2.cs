using UnityEngine;

public class escudobala_al2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "danoene")
        {
            //por cada arma enemiga get component ye l dano es transferido al jugador en forma de vida el dano hay un limite a trasferir basado en el nivel del arma
        }
    }
}
