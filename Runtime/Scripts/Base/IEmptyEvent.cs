using System;

namespace ScriptableObjects.Event
{
    public interface IEmptyEvent
    {
        Action OnEvent { get; set; }
    }
}