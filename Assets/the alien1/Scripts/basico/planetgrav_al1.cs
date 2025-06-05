using UnityEngine;

public class _al1 : MonoBehaviour
{

    [HideInInspector] public float fuerzaGravedad;
    public float radioActivacion;
    [HideInInspector] public float velocidadRotacion;
    
    private GameObject jugador;
    private Rigidbody jugadorRb;
    private jugador_al1 scriptJugador;
    private manager_al1 manager;
    public float jugpos;
    public bool jugadorEntrando = true;
    public float anguloY;
    public bool planeta;
    
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        if (jugador != null)
        {
            jugadorRb = jugador.GetComponent<Rigidbody>();
            scriptJugador = jugador.GetComponent<jugador_al1>();
            manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        }
        
        float escalaPromedio = (transform.localScale.x);
        
        // Escalar los valores según el tamaño del planeta
        this.fuerzaGravedad = 20f;
        this.radioActivacion = 8f + (escalaPromedio /2);
        this.velocidadRotacion = 10f / Mathf.Sqrt(escalaPromedio * 3); // La velocidad de rotación disminuye con planetas más grandes
        
        Debug.Log("Planeta escala: " + escalaPromedio + ", vel " + velocidadRotacion + ", Radio: " + radioActivacion);

        
    }
    
    void FixedUpdate()
    {
        
            
        
       
            if (this.jugador == null || this.jugadorRb == null || this.scriptJugador == null)
                return;
                
            // Calcular la distancia al jugador
            Vector3 direccionAlJugador = jugador.transform.position - transform.position;
            float distancia = direccionAlJugador.magnitude;
            if(distancia < this.radioActivacion && scriptJugador.objplaneta == null) 
            {
                scriptJugador.objplaneta = this.gameObject;
            } 
            else if(distancia < this.radioActivacion && scriptJugador.objplaneta != null && scriptJugador.objplaneta != this.gameObject) 
            {
                if(distancia < scriptJugador.disjugsave)
                {
                    scriptJugador.objplaneta = this.gameObject;
                }
                
            } 
            // Verificar si el jugador está dentro del radio de activación
            else if (distancia < this.radioActivacion && scriptJugador.objplaneta == this.gameObject)
            {
                scriptJugador.disjugsave = distancia;
                this.scriptJugador.planetCenter = transform.position;
                // Activar el modo planeta en el script del jugador
                
                // Normalizar la dirección para obtener el vector hacia el centro
                Vector3 direccionNormalizada = direccionAlJugador.normalized;
                
                // Aplicar fuerza de gravedad hacia el centro del planeta
                this.jugadorRb.AddForce(-direccionNormalizada * fuerzaGravedad, ForceMode.Acceleration);
                if(manager.juego == 3)
                {

                
                

                
                // Guardar el ángulo Y actual para preservar la dirección a la que mira el jugador
                    this.anguloY = jugador.transform.rotation.eulerAngles.y;
                    
                    // Rotar al jugador para que sus pies apunten hacia el planeta, pero manteniendo su orientación Y
                    Quaternion rotacionDeseada = Quaternion.FromToRotation(jugador.transform.up, direccionNormalizada) * jugador.transform.rotation;
                    
                    // Extraer los ángulos de la rotación deseada
                    Vector3 angulos = rotacionDeseada.eulerAngles;
                    // Reemplazar el ángulo Y con el original para mantener la dirección de mirada
                    rotacionDeseada = Quaternion.Euler(angulos.x, anguloY, angulos.z);
                    
                    jugador.transform.rotation = Quaternion.Slerp(jugador.transform.rotation, rotacionDeseada, Time.fixedDeltaTime * velocidadRotacion);
                }
                if(manager.juego == 4)
                {

                    
                    // Rotar al jugador para que sus pies apunten hacia el planeta
                    Quaternion rotacionDeseada = Quaternion.FromToRotation(jugador.transform.up, direccionNormalizada) * jugador.transform.rotation;
                    jugador.transform.rotation = Quaternion.Slerp(jugador.transform.rotation, rotacionDeseada, Time.fixedDeltaTime * velocidadRotacion);
                    
                }
            }
            else if(scriptJugador.objplaneta == this.gameObject)
            {
                scriptJugador.objplaneta = null;
            }

        
       
            
    }

}