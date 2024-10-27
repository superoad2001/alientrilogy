using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

// Token: 0x02000009 RID: 9
public class inicio0base : MonoBehaviour
{
	public string idioma;
	public int plat;
	public float temp;
	public AudioMixer audiomixer;
	public managerBASE manager;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
		audiomixer.SetFloat ("MusicVolume",manager.datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",manager.datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",manager.datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",manager.datosconfig.ui);
		idioma = manager.datosconfig.idioma;
		plat = manager.datosconfig.plat;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if(temp > 1)
		{
		if(manager.datosconfig.idioma != "es" && manager.datosconfig.idioma != "en" && manager.datosconfig.idioma != "cat")
		{
			SceneManager.LoadScene("idiomabase");
		}
		else if(manager.datosconfig.plat != 1 && manager.datosconfig.plat != 2)
		{
			SceneManager.LoadScene("controlesbase");
		}
		else if(manager.datosconfig.distancia != 200 && manager.datosconfig.distancia != 500 && manager.datosconfig.distancia != 1000 && manager.datosconfig.distancia != 2000 && manager.datosconfig.distancia != 3000)
		{
			SceneManager.LoadScene("distanciabase");
		}
		else if(manager.datosconfig.postpro != 1 && manager.datosconfig.postpro != 2)
		{
			SceneManager.LoadScene("mejorabase");
		}
		else
		{
			SceneManager.LoadScene("presentacionbase");
		}
		}
		temp += 1 * Time.deltaTime;
	}
	public void reset()
	{
		manager.borrar_data();
		SceneManager.LoadScene("idiomabase");
	}
}
