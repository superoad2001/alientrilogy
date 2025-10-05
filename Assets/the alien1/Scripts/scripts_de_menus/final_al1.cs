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
	public Text boton;

	// Token: 0x0600000C RID: 12 RVA: 0x00002397 File Offset: 0x00000597
	private void Start()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		manager.datosserial.demoFIN = true;

		manager.datosserial.asc = 0;
        manager.guardar();

		if(manager.datosconfig.idioma == "es")
        {
			tit.text = "volver al menu";
			tit.text = "fin";
			score.text = string.Concat("enemigos vencidos: ",manager.datosserial.asesinatos,"\n",
			"Muertes sufridas: ",manager.datosserial.muertes,"\n",
			"Nivel Alien : ",manager.datosserial.niveljug,"\n",
			"Misiones Completadas : ",manager.MisionesCumplidas,"/12","\n",
			"Tiempo de Juego : ",manager.datosserial.horas,":",manager.datosserial.minutos.ToString("D2"),":",manager.datosserial.segundos.ToString("00"));
        }
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002399 File Offset: 0x00000599
	private void Update()
	{

		if(manager.datosconfig.idioma == "es")
        {
			tit.text = "volver al menu";
			tit.text = "fin";
			score.text = string.Concat("enemigos vencidos: ",manager.datosserial.asesinatos,"\n",
			"Muertes sufridas: ",manager.datosserial.muertes,"\n",
			"Nivel Alien : ",manager.datosserial.niveljug,"\n",
			"Misiones Completadas : ",manager.MisionesCumplidas,"/12","\n",
			"Tiempo de Juego : ",manager.datosserial.horas,":",manager.datosserial.minutos.ToString("D2"),":",manager.datosserial.segundos.ToString("00"));
        }
		if (botonm == true)
		{
			manager.datosconfig.carga = "menu_de_carga_al1";
            manager.guardarconfig();
            manager.guardar();
			SceneManager.LoadScene("carga");
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
