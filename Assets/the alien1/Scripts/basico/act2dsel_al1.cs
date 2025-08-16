using UnityEngine;

public class act2dsel_al1 : MonoBehaviour
{
   public GameObject a2d;
   public GameObject a3d;
   public jugador_al1 jugador;
   public void Start()
   {
        jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
        if(jugador.modo == "2D")
        {
        a2d.SetActive(true);
        a3d.SetActive(false);
        }
   }
}
