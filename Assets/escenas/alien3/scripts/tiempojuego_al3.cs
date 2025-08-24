using System;
using UnityEngine;

public class tiempojuego_al3 : MonoBehaviour
{
    public manager_al3 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
    }

    // Update is called once per frame
    void Update()
    {
        manager.datosserial.segundos += 1 * Time.unscaledDeltaTime;
        if (manager.datosserial.segundos > 60)
        {
            manager.datosserial.segundos = 0;
            manager.datosserial.minutos++;
        }
        if (manager.datosserial.minutos > 60)
        {
            manager.datosserial.minutos = 0;
            manager.datosserial.horas++;
        }
        if (manager.datosserial.horas > 999)
        { manager.datosserial.horas = 999; }
    }
}
