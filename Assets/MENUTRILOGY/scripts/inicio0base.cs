﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
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
	public void Start()
	{
		manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));

		audiomixer.SetFloat ("MusicVolume",manager.datosconfig.musica);
		audiomixer.SetFloat ("EnvironmentVolume",manager.datosconfig.voz);
		audiomixer.SetFloat ("SFXVolume",manager.datosconfig.sfx);
		audiomixer.SetFloat ("UIVolume",manager.datosconfig.ui);
		Debug.Log(Screen.width+" "+manager.datosconfig.largo);
		if(Screen.width >= manager.datosconfig.largo && Screen.height >= manager.datosconfig.altura)
		{
			Screen.SetResolution(manager.datosconfig.largo,manager.datosconfig.altura,manager.datosconfig.full);
			if(manager.datosconfig.primera == false)
			{
				SceneManager.LoadScene("opcionesbase");
			}
			else
			{
				SceneManager.LoadScene("menutrilogy");
			}
		}
		else
		{
			SceneManager.LoadScene("opcionesbase");
		}
	

		

		idioma = manager.datosconfig.idioma;
		plat = manager.datosconfig.plat;
	}
	public void Update()
	{

	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728



}
