using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class controlmusicabase : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Slider slidermusica;
    public Slider slidervoz;
    public Slider slidersfx;
    public Slider sliderui;

    public AudioSource sfxa;
    public AudioSource voza;
    public AudioSource uia;
    public float test;

    public bool opciones;
    public managerBASE manager;

    public Text disp;
    public int dispt = 2;
    public void Start ()
    {
        
        
        manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
        slidermusica.value =  (manager.datosconfig.musicaslider);
        slidervoz.value =  (manager.datosconfig.vozslider);
        slidersfx.value =  (manager.datosconfig.sfxslider);
        sliderui.value =  (manager.datosconfig.uislider);
        uia.Stop();
        sfxa.Stop();
        voza.Stop();

    }
    public void controlmusica (float slideraudio)
    {
        audiomixer.SetFloat ("MusicVolume", Mathf.Log10 (slideraudio) * 20);
        
    }
    public void controlvoz (float slideraudio)
    {
        audiomixer.SetFloat ("EnvironmentVolume", Mathf.Log10 (slideraudio) * 20);
        voza.Play();
        sfxa.Stop();
        uia.Stop();
        
    }
    public void controlsfx (float slideraudio)
    {
        audiomixer.SetFloat ("SFXVolume", Mathf.Log10 (slideraudio) * 20);
        sfxa.Play();
        voza.Stop();
        uia.Stop();
        
    }
    public void controlui (float slideraudio)
    {
        audiomixer.SetFloat ("UIVolume", Mathf.Log10 (slideraudio) * 20);
        uia.Play();
        sfxa.Stop();
        voza.Stop();
        
    }

}
