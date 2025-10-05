using UnityEngine;

public class boss1cerebrocin_al1 : MonoBehaviour
{
    public manager_al1 manager;
    public GameObject cerebro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.Find("manager").GetComponent<manager_al1>();
        if(manager.datosserial.newgameplus1 == false)
        {
        cerebro.SetActive(true);
        }
        else
        {
        cerebro.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
