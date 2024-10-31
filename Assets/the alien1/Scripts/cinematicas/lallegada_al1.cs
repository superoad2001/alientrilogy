using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000010 RID: 16
public class lallegada_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool botonm = false;
	private Controles controles;
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
	// Token: 0x06000038 RID: 56 RVA: 0x00003A94 File Offset: 0x00001C94
	private void Start()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A96 File Offset: 0x00001C96
	private void Update()
	{
		
	}
	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player" || controles.menu.saltar.ReadValue<float>() > 0f)
		{
			SceneManager.LoadScene("cinematicainicial_al1");
		}
	}

}
