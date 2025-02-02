using UnityEngine;

public class baladef_exp_al1 : MonoBehaviour
{
    public GameObject explosiont;

    public float explosion = 13;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Destroy(explosiont, explosion);
    }
}
