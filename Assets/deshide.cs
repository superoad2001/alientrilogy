using UnityEngine;

public class deshide : StateMachineBehaviour
{
    public void start()
    {
        hidemenu_al1 hide = (hidemenu_al1)FindFirstObjectByType(typeof(hidemenu_al1));
        hide.anim.SetBool("show2",false);
    }
}
