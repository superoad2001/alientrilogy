using UnityEngine;

public class tutorialbase_al1 : MonoBehaviour
{
    public int id;
    public jugador_al1 player;
    public manager_al1 manager;
    public manualtut_al1 manual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        player = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        manual = (manualtut_al1)FindFirstObjectByType(typeof(manualtut_al1));
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
            manager.controlene = false;
            if(controles.al1_3d.marcar.ReadValue<float>() > 0)
            {
                player.marcarc = 1;
                manual.terminar_evento();
                Destroy(this.gameObject);
            }
        }

        
    }
    public void evento()
    {
        if(id == 1)
        {
            manual.terminar_evento();
            Destroy(this.gameObject);
        }
    }
    public void eventoene()
    {
        if(id == 2)
        {
            manual.terminar_evento();
            Destroy(this.gameObject);
        }
    }
}
