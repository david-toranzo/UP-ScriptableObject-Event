using System;
using UnityEngine;

namespace ScriptableObjects.Event
{
    [CreateAssetMenu(fileName = "EventSO", menuName = "ScriptableObjects/Events/Empty", order = 0)]
    public class EmptyEventScriptableObject : ScriptableObject, IEmptyEvent
    {
        public Action OnEvent { get; set; }

        public void InvokeEvent()
        {
            OnEvent?.Invoke();
        }
    }
}