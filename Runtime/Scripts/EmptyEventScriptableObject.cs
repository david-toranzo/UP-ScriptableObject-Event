using System;
using UnityEngine;

namespace ScriptableObjects.Event
{
    [CreateAssetMenu(fileName = "EventSO", menuName = "ScriptableObjects/Events/Empy", order = 0)]
    public class EmptyEventScriptableObject : ScriptableObject, IEmptyEvent
    {
        public Action OnEvent { get; set; }
    }
}