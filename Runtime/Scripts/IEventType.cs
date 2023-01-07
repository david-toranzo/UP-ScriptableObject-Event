using System;

namespace ScriptableObjects.Event
{
    public interface IEventType<Type>
    {
        Action<Type> OnTypeEvent { get; set; }
    }
}