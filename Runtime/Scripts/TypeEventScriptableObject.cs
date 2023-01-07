using System;
using UnityEngine;

namespace ScriptableObjects.Event
{
    public class TypeEventScriptableObject<Type> : ScriptableObject, IEventType<Type>
    {
        public Action<Type> OnTypeEvent { get; set; }
    }
}