using UnityEngine;

public class checkpoitnsec_al1 : MonoBehaviour
{
    public int IDCheck;
    public controlcoche_al1 control;

    void Start()
    {
        control = (controlcoche_al1)FindFirstObjectByType(typeof(controlcoche_al1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        for(int i = 0; i < control.maxjug;  i++ )
        {  
            if (col.gameObject.tag == control.name[i])
            {
            }
        }
        
    }
}
