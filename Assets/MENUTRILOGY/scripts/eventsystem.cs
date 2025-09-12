using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class EventSystemAccess : MonoBehaviour
{
    public static EventSystemAccess Instance { get; private set; }

    [SerializeField] private List<GameObject> objetosSeleccionables = new List<GameObject>();
    
    private EventSystem eventSystemActual;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (eventSystemActual == null || !eventSystemActual.isActiveAndEnabled)
        {
            eventSystemActual = EventSystem.current;
            ActualizarLista();
        }

        if (eventSystemActual != null && EventSystem.current.currentSelectedGameObject == null && objetosSeleccionables.Count > 0)
        {
            
            Seleccionar(objetosSeleccionables[0]);
        }
        
    }
    private void ActualizarLista()
    {
        objetosSeleccionables.Clear();
        Selectable[] todos = GameObject.FindObjectsOfType<Selectable>();
        foreach (var s in todos)
        {
            if (s.IsActive() && s.interactable)
            {
                objetosSeleccionables.Add(s.gameObject);
            }
        }
    }
    public void Seleccionar(GameObject objeto)
    {
        if (eventSystemActual == null || !eventSystemActual.isActiveAndEnabled)
        {
            eventSystemActual = EventSystem.current;
        }
        if (eventSystemActual != null && objeto != null)
        {
            EventSystem.current.SetSelectedGameObject(objeto);
            Debug.Log("Seleccionado: " + objeto.name);
        }
        else
        {
            // Si pasas null, se deselecciona todo
            EventSystem.current.SetSelectedGameObject(null);
            Debug.Log("Nada seleccionado");
        }
    }
}