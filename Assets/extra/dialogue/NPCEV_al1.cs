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
        public jugador_al1 jugador;
        #endregion

        /// <summary>.
        /// The RunEvent function is called by the Event Node
        /// It can also be called manually
        /// </summary>.
        public override void RunEvent()
        {
            jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
            jugador.mision_aceptar();
            
        }
    }
}
