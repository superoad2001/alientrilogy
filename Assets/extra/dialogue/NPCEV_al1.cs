using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeetAndTalk.GlobalValue;

namespace MeetAndTalk.Event
{
    [CreateAssetMenu(menuName = "Dialogue/Event/npcev_al1")]
    public class NPCEV_al1 : DialogueEventSO
    {
        #region Variables
        [HideInInspector] GlobalValueManager manager;
        public manager_al1 manager1;
        #endregion

        /// <summary>.
        /// The RunEvent function is called by the Event Node
        /// It can also be called manually
        /// </summary>.
        public override void RunEvent()
        {
            manager1 = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
            // Load Global Value Manager
            manager1.mision_aceptar(manager1.misionS);
            
        }
    }
}
