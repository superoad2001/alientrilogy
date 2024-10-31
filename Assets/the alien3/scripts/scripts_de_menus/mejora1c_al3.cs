using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mejora1c_al3: MonoBehaviour
{
	public manager_al3 manager;
    public AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void act()
    {
        SceneManager.LoadScene("mundo_abierto_al3");
    }
    // Update is called once per frame
    void Update()
    {
        if(!audio1.isPlaying)
		{
			SceneManager.LoadScene("mundo_abierto_al3");
		}
    }
}
