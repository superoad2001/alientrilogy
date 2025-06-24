using UnityEngine;

public class DestruibleMision_al1 : MonoBehaviour
{
    public manager_al1 manager;
    public int mision;
    public GameObject explosion;
    public AudioSource expson;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(manager.datosserial.misiones[mision] > 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.datosserial.misiones[mision] > 0)
        {
            GameObject roto = Instantiate(explosion, transform.position,transform.rotation) as GameObject;
            roto.transform.localScale = transform.localScale;
            expson.Play();
            Destroy(roto, 1f);
            Destroy(gameObject);
        }
    }
}
