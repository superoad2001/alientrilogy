using System;
using UnityEngine;
using UnityEngine.SceneManagement;


// Token: 0x02000005 RID: 5
public class final2_al3: MonoBehaviour
{
	public GameObject tactil;
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
	// Token: 0x0600000C RID: 12 RVA: 0x00002397 File Offset: 0x00000597
	private void Start()
	{
		
		manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
	}
	public float temp;
	public int Ac = 0;
	public void A()
	{
		Ac = 1;
	}
	// Token: 0x0600000D RID: 13 RVA: 0x00002399 File Offset: 0x00000599
	private void Update()
	{
		manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (controles.al3.a.ReadValue<float>() > 0f && temp >= 1 || Ac == 1 && temp >= 1)
		{
			manager.datosserial.com = 0;
			manager.guardar();
			SceneManager.LoadScene("escena15_al3");
		}
	}

}
