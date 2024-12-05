using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MeetAndTalk.Demo
{
    public class DemoInteraction : MonoBehaviour
    {
        public string InteractionText;
        public UnityEvent OnInteraction;

        public void Interaction()
        {
            OnInteraction.Invoke();
        }
    }
}
