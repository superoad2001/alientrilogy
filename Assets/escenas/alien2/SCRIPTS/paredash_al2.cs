using UnityEngine;

public class paredash_al2 : MonoBehaviour
{
    public BoxCollider pared;
    public jugador_al2 player;
    public float temp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
    }

    // Update is called once per frame
    void Update()
    {
        if(temp < 15)
        {
            temp += Time.deltaTime;
        }
        if(temp > 2f)
        {
            pared.isTrigger = false;
        }
        if(player.dashefect2 == true)
        {
            pared.isTrigger = true;
            temp = 0;
        }
    }

}
