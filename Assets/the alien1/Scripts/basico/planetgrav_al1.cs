using UnityEngine;

public class planetgrav_al1 : MonoBehaviour
{

    [HideInInspector] public float fuerzaGravedad;
    [HideInInspector] public float radioActivacion;
    [HideInInspector] public float velocidadRotacion;
    
    private GameObject jugador;
    private Rigidbody jugadorRb;
    private jugador_al1 scriptJugador;
    private manager_al1 manager;
    public float jugpos;
    private bool jugadorEntrando = true;
    
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        if (jugador != null)
        {
            jugadorRb = jugador.GetComponent<Rigidbody>();
            scriptJugador = jugador.GetComponent<jugador_al1>();
            manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        }
        
        // Calcular la escala del planeta (promedio de los 3 ejes)
        float escalaPromedio = (transform.localScale.x + transform.localScale.y + transform.localScale.z) /30f;
        
        // Escalar los valores según el tamaño del planeta
        fuerzaGravedad = 20f;
        radioActivacion = 7f * escalaPromedio;
        velocidadRotacion = 5f / Mathf.Sqrt(escalaPromedio); // La velocidad de rotación disminuye con planetas más grandes
        
        Debug.Log("Planeta escala: " + escalaPromedio + ", vel " + velocidadRotacion + ", Radio: " + radioActivacion);
    }
    
    void FixedUpdate()
    {
        
        if(manager.juego == 4)
        {
            if (jugador == null || jugadorRb == null || scriptJugador == null)
                return;
                
            // Calcular la distancia al jugador
            Vector3 direccionAlJugador = jugador.transform.position - transform.position;
            float distancia = direccionAlJugador.magnitude;
            
            // Verificar si el jugador está dentro del radio de activación
            if (distancia < radioActivacion)
            {
                scriptJugador.planetCenter = transform.position;
                // Activar el modo planeta en el script del jugador
                scriptJugador.planeta = true;
                
                // Normalizar la dirección para obtener el vector hacia el centro
                Vector3 direccionNormalizada = direccionAlJugador.normalized;
                
                // Aplicar fuerza de gravedad hacia el centro del planeta
                jugadorRb.AddForce(-direccionNormalizada * fuerzaGravedad, ForceMode.Acceleration);

                
                
                // Rotar al jugador para que sus pies apunten hacia el planeta
                Quaternion rotacionDeseada = Quaternion.FromToRotation(jugador.transform.up, direccionNormalizada) * jugador.transform.rotation;
                jugador.transform.rotation = Quaternion.Slerp(jugador.transform.rotation, rotacionDeseada, Time.fixedDeltaTime * velocidadRotacion);
            }
            else
            {
                // Desactivar el modo planeta cuando el jugador está fuera del radio
                scriptJugador.planeta = false;
            }
        }
        else if (manager.juego == 3)
        {
                if (jugadorEntrando)
                {
                    if(scriptJugador.dimensiion == true)
                    {
                        jugpos = jugador.transform.position.x;
                        //jugador.transform.localPosition = nuevaPos;
                    }
                    else if(scriptJugador.dimensiion == false)
                    {
                        jugpos = jugador.transform.position.z;
                    }
                     // Guardar la posición Z (horizontal)
                    jugadorEntrando = false;
                }
            // Desactivar el modo planeta cuando el jugador está fuera del radio
                if (jugador == null || jugadorRb == null || scriptJugador == null)
                return;
            
                // Calcular la distancia al jugador
                Vector3 direccionAlJugador = jugador.transform.position - transform.position;
                float distancia = direccionAlJugador.magnitude;
                
                // Verificar si el jugador está dentro del radio de activación
                if (distancia < radioActivacion)
                {
                    // Activar el modo planeta en el script del jugador
                    scriptJugador.planeta = true;
                    
                    // Normalizar la dirección para obtener el vector hacia el centro
                    Vector3 direccionNormalizada = direccionAlJugador.normalized;
                    
                    // Aplicar fuerza de gravedad hacia el centro del planeta
                    jugadorRb.AddForce(-direccionNormalizada * fuerzaGravedad, ForceMode.Acceleration);

                    if(scriptJugador.dimensiion == true)
                    {
                        Vector3 nuevaPos = jugador.transform.position;
                        nuevaPos.x = jugpos;
                        jugador.transform.position = nuevaPos;
                    }
                    else if(scriptJugador.dimensiion == false)
                    {
                        Vector3 nuevaPos = jugador.transform.position;
                        nuevaPos.z = jugpos;
                        jugador.transform.position = nuevaPos;
                    }
                    
                    
                    // Guardar el ángulo Y actual para preservar la dirección a la que mira el jugador
                    float anguloY = jugador.transform.rotation.eulerAngles.y;
                    
                    // Rotar al jugador para que sus pies apunten hacia el planeta, pero manteniendo su orientación Y
                    Quaternion rotacionDeseada = Quaternion.FromToRotation(jugador.transform.up, direccionNormalizada) * jugador.transform.rotation;
                    
                    // Extraer los ángulos de la rotación deseada
                    Vector3 angulos = rotacionDeseada.eulerAngles;
                    // Reemplazar el ángulo Y con el original para mantener la dirección de mirada
                    rotacionDeseada = Quaternion.Euler(angulos.x, anguloY, angulos.z);
                    
                    jugador.transform.rotation = Quaternion.Slerp(jugador.transform.rotation, rotacionDeseada, Time.fixedDeltaTime * velocidadRotacion);

                }
                else
                {
                    // Desactivar el modo planeta cuando el jugador está fuera del radio
                    scriptJugador.planeta = false;
                }
        }
            
    }
}