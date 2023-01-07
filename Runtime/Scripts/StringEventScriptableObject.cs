using UnityEngine;

namespace ScriptableObjects.Event
{
    [CreateAssetMenu(fileName = "StringEventSO", menuName = "ScriptableObjects/Events/String", order = 0)]
    public class StringEventScriptableObject : TypeEventScriptableObject<string>
    {

    }
}