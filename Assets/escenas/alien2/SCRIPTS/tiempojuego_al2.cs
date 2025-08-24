using System;
using UnityEngine;

public class tiempojuego_al2 : MonoBehaviour
{
    public manager_al2 manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));
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
