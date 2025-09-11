using UnityEngine;

public class barragrindeo_al2 : MonoBehaviour
{


    /*deberia permitir que al mantener x el jugador vaya en la direccion de destino de la barra 
    donde marque la camara siempre que la camra pase un margen 180 en una o otra direccion*/
    public jugador_al2 player;
    public GameObject dest1;
    public GameObject dest2;
    public GameObject dest;
    private bool act;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dest = dest2;
        player = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));
    }
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            player.saltop = true;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            act = false;
            player.grind = false;
            player.anim.SetBool("salto",true);
        }
    }
    public void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            if(player.controles.al2_3d.lateral.ReadValue<float>() > 0 && player.skate == true)
            {
                player.anim.SetBool("salto",false);
                if(act == false)
                {
                    if(player.mod.transform.eulerAngles.y - dest1.transform.eulerAngles.y >= 1 && player.mod.transform.eulerAngles.y - dest1.transform.eulerAngles.y <= 90 || player.mod.transform.eulerAngles.y - dest1.transform.eulerAngles.y >= 271 && player.mod.transform.eulerAngles.y - dest1.transform.eulerAngles.y <= 360)
                    {
                        dest = dest1;
                    }
                    else
                    {
                        dest = dest2;
                    }
                    act = true;
                }
                
                player.mod.transform.localRotation = Quaternion.Lerp(player.mod.transform.localRotation, 
                Quaternion.Euler(player.mod.transform.localEulerAngles.x, 0, player.mod.transform.localEulerAngles.z),
                10f * Time.deltaTime);

                player.transform.rotation = Quaternion.Slerp(player.transform.rotation, 
                Quaternion.Euler(0, dest.transform.eulerAngles.y, 0),
                10 * Time.deltaTime);

                if(player._rb.linearVelocity.y < 0)
                {
                    player._rb.linearVelocity = Vector3.zero;
                }
                else
                {
                    player._rb.linearVelocity = new Vector3(0, player._rb.linearVelocity.y, 0);
                }
                
                player.transform.position = Vector3.MoveTowards(player.transform.position,new Vector3(dest.transform.position.x,transform.position.y+4f,dest.transform.position.z),28 * Time.deltaTime);
                

                
                
			    
                player.grind = true;
                player.movskate = false;
            }
            else
            {
                player.grind = false;
                act = false;
                player.anim.SetBool("salto",true);
            }
               
        }
        
    }
}
