using UnityEngine;

public class eventostienda_al1 : MonoBehaviour
{
    public GameObject[] eventos = new GameObject[10];
    public GameObject paret;
    public GameObject puerta;
    public manager_al1 manager;
    public teleportautom_al1 teleport;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        paret.SetActive(true);
        puerta.SetActive(true);
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        teleport = (teleportautom_al1)FindFirstObjectByType(typeof(teleportautom_al1));
        if(manager.datosserial.eventos[0] == true)
        {
            eventos[0].SetActive(true);
            paret.SetActive(false);
            puerta.SetActive(false);
            teleport.ubi = "tutorial3_al1";

        }
        if(manager.datosserial.eventos[1] == true)
        {
            eventos[1].SetActive(true);
            paret.SetActive(false);
            puerta.SetActive(false);
            teleport.ubi = "tutorial4_al1";

        }
        if(manager.datosserial.eventos[2] == true)
        {
            eventos[2].SetActive(true);
            paret.SetActive(true);
            puerta.SetActive(true);
            manager.datosserial.eventos[2] = false;
            manager.guardar();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
