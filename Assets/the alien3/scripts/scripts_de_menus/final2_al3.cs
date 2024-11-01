using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class final2_al3: MonoBehaviour
{
	public manager_al3 manager;
	public GameObject tactil;
	private Controles controles;
	public Text final;
	public string f1;
	public string f2;
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
		
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		manager.datosserial.tfinal1 = true;
		manager.guardar();

		if(manager.datosconfig.idioma == "es")
        {
			if(manager.datosserial.tfinal1 == true)
			{
				f1 = "si";
			}
			else
			{
				f1 = "no";
			}
			if(manager.datosserial.tfinal2 == true)
			{
				f2 = "si";
			}
			else
			{
				f2 = "no";
			}
			final.text = "enemigos derrotados : "+manager.datosserial.enemigos_muertos+ "                          muertes sufridas : "+manager.datosserial.muertes+ "                                             final 1 : "+f1+"                                                 final 2 : "+f2+"                                  armas : "+manager.datosserial.armastotal+"/15                          armaduras "+manager.datosserial.armadurastotal+"/10                                    gemas : "+manager.datosserial.gemas+"/100                             paginas : "+manager.datosserial.diariostotal+"/15                                                              vida maxima "+manager.datosserial.vidamaxima+"/100";
		}
		if(manager.datosconfig.idioma == "en")
        {
			if(manager.datosserial.tfinal1 == true)
			{
				f1 = "yes";
			}
			else
			{
				f1 = "no";
			}
			if(manager.datosserial.tfinal2 == true)
			{
				f2 = "yes";
			}
			else
			{
				f2 = "no";
			}
			final.text = "enemies defeated: "+manager.datosserial.enemigos_muertos+ "                          deaths suffered : "+manager.datosserial.muertes+ "                                             end 1 : "+f1+"                                                 end 2 : "+f2+"                                  weapons : "+manager.datosserial.armastotal+"/15                          armors "+manager.datosserial.armadurastotal+"/10                                    gems : "+manager.datosserial.gemas+"/100                             pages : "+manager.datosserial.diariostotal+"/15                                                              max life "+manager.datosserial.vidamaxima+"/100";
		}
		if(manager.datosconfig.idioma == "cat")
        {
			if(manager.datosserial.tfinal1 == true)
			{
				f1 = "si";
			}
			else
			{
				f1 = "no";
			}
			if(manager.datosserial.tfinal2 == true)
			{
				f2 = "si";
			}
			else
			{
				f2 = "no";
			} 
			final.text = "enemics morts : "+manager.datosserial.enemigos_muertos+ "                                                                  morts : "+manager.datosserial.muertes+ "                                             final 1 : "+f1+"                                                 final 2 : "+f2+"                                           armas : "+manager.datosserial.armastotal+"/15                          armadures "+manager.datosserial.armadurastotal+"/10                                    gemas : "+manager.datosserial.gemas+"/100                             paginas : "+manager.datosserial.diariostotal+"/15                                                              vida maxima "+manager.datosserial.vidamaxima+"/100";
		}
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
		manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
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
