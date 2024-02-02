using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalsecreto_al1 : MonoBehaviour
{
    public bool activar;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manager2_al1 manager = UnityEngine.Object.FindObjectOfType<manager2_al1>();

        if(manager.datosserial.recordnv1 <= 0 && manager.datosserial.recordnv2 <= 0 && manager.datosserial.recordnv3 <= 0 && manager.datosserial.recordnv4 <= 0 && manager.datosserial.recordnv5 <= 0 && manager.datosserial.recordnv6 <= 0 && manager.datosserial.recordnv7 <= 0 && manager.datosserial.recordnv8 <= 0 && manager.datosserial.recordnv9 <= 0 
        && manager.datosserial.recordnv10 <= 0 && manager.datosserial.recordnv11 <= 0 && manager.datosserial.recordnv12 <= 0 && manager.datosserial.recordnv13 <= 0 && manager.datosserial.recordnv14 <= 0 && manager.datosserial.recordnv15 <= 0)
        {
            activar = true;
            portal.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Player" && activar == true)
		{
			SceneManager.LoadScene("sala_secreta_al1");
		}
    }
}
