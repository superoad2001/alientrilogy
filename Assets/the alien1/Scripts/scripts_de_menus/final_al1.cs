using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Token: 0x02000005 RID: 5
public class final_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public bool botonm = false;
	public Text score;
	public Text tit;

	// Token: 0x0600000C RID: 12 RVA: 0x00002397 File Offset: 0x00000597
	private void Start()
	{
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		manager.datosserial.demoFIN = true;
		manager.guardar();

		if(manager.datosconfig.idioma == "es")
        {
			
			tit.text = "fin";
			score.text = "enemigos vencidos: "+manager.datosserial.asesinatos+"\n"+
			"Muertes sufridas: "+manager.datosserial.muertes+"\n"+
			"Nivel Alien : "+manager.datosserial.niveljug+"\n"+
			"Misiones Completadas : "+manager.MisionesCumplidas;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002399 File Offset: 0x00000599
	private void Update()
	{
		if (botonm == true)
		{
			SceneManager.LoadScene("menu_de_carga_al1");
		}
	}
		public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
}
