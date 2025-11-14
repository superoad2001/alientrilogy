using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class final_al2 : MonoBehaviour
{
	public manager_al2 manager;
	public GameObject tactil;
	private Controles controles;
	public Text final;
	public string ss;
	public string fb;
	public string fm;
	public string fa;
	
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
		manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
		if(manager.datosconfig.idioma == "es")
        {
			if(manager.datosserial.sala_secreta == true)
			{
				ss = "si";
			}
			else
			{
				ss = "no";
			}
			if(manager.datosserial.finalbueno == 1)
			{
				fb = "si";
			}
			else
			{
				fb = "no";
			}
			if(manager.datosserial.finalmalo == 1)
			{
				fm = "si";
			}
			else
			{
				fm = "no";
			}
			if(manager.datosserial.final_alt == true)
			{
				fa = "si";
			}
			else
			{
				fa = "no";
			}
			final.text = "enemgios asesinados : "+manager.datosserial.aliensderrotados+"                              muertes sufridas : "+manager.datosserial.muertes+"                        final malo : "+fm+"                                   final bueno : "+fb+"                     final alternativo : "+fa+"                     vida maxima : "+manager.datosserial.vidamaxima+"/6";
		}
		if(manager.datosconfig.idioma == "en")
        {
			if(manager.datosserial.sala_secreta == true)
			{
				ss = "yes";
			}
			else
			{
				ss = "no";
			}
			if(manager.datosserial.finalbueno == 1)
			{
				fb = "yes";
			}
			else
			{
				fb = "no";
			}
			if(manager.datosserial.finalmalo == 1)
			{
				fm = "yes";
			}
			else
			{
				fm = "no";
			}
			if(manager.datosserial.final_alt == true)
			{
				fa = "yes";
			}
			else
			{
				fa = "no";
			}
			final.text = "enemies defeated : "+manager.datosserial.aliensderrotados+"                              deaths suffered : "+manager.datosserial.muertes+"                        bad ending : "+fm+"                                   good ending : "+fb+"                     alternate end : "+fa+"                     max life : "+manager.datosserial.vidamaxima+"/6";
		}
		if(manager.datosconfig.idioma == "cat")
        {
			if(manager.datosserial.sala_secreta == true)
			{
				ss = "si";
			}
			else
			{
				ss = "no";
			}
			if(manager.datosserial.finalbueno == 1)
			{
				fb = "si";
			}
			else
			{
				fb = "no";
			}
			if(manager.datosserial.finalmalo == 1)
			{
				fm = "si";
			}
			else
			{
				fm = "no";
			}
			if(manager.datosserial.final_alt == true)
			{
				fa = "si";
			}
			else
			{
				fa = "no";
			}
			final.text = "enemics morts : "+manager.datosserial.aliensderrotados+"                                                         morts : "+manager.datosserial.muertes+"                                              final dolent : "+fm+"                                                       final bo : "+fb+"                                         final alternatiu : "+fa+"                     vida maxima : "+manager.datosserial.vidamaxima+"/6";
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
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (controles.al2.a.ReadValue<float>() > 0f && temp >= 1 || Ac == 1 && temp >= 1)
		{
			SceneManager.LoadScene("menu_de_carga_al2");
		}
	}

}
