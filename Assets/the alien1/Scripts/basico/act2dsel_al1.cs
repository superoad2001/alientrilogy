using UnityEngine;

public class act2dsel_al1 : MonoBehaviour
{
   public GameObject a2d;
   public GameObject a3d;
   public manager_al1 manager;
   public void Start()
   {
        manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
        if(manager.juego == 3)
        {
        a2d.SetActive(true);
        a3d.SetActive(false);
        }
   }
}
