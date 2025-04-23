using UnityEngine;

public class tutorialbase_al1 : MonoBehaviour
{
    public int id;
    public jugador_al1 player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public Controles controles;
    public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if(id == 0)
        {
            if(controles.al1.r3.ReadValue<float>() > 0)
            {
                player.r3 = 1;
            }
        }
        
    }
}
