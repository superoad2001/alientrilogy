using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeetAndTalk.GlobalValue;

namespace MeetAndTalk.Event
{
    [CreateAssetMenu(menuName = "Dialogue/Event/npcev2_al3")]
    public class NPCEV2_al3 : DialogueEventSO
    {
        #region Variables
        [HideInInspector] GlobalValueManager manager;
        //public jugador_al3 jugador;
        #endregion

        /// <summary>.
        /// The RunEvent function is called by the Event Node
        /// It can also be called manually
        /// </summary>.
        public override void RunEvent()
        {
            //jugador = (jugador_al3)FindFirstObjectByType(typeof(jugador_al3));
            //jugador.mision_fin();
            
        }
    }
}
