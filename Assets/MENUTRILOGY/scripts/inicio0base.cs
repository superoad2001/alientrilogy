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
			if(manager.datosconfig.primera == false)
			{
				SceneManager.LoadScene("opcionesbase");
			}
			else
			{
				SceneManager.LoadScene("menutrilogy");
			}
		}
		temp += 1 * Time.deltaTime;
	}
	public void reset()
	{
		manager.borrar_data();
		SceneManager.LoadScene("opcionesbase");
	}
}
