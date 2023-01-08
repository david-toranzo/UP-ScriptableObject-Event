using UnityEngine;

namespace ScriptableObjects.Event
{
    [CreateAssetMenu(fileName = "GameObjectEventSO", menuName = "ScriptableObjects/Events/GameObject", order = 0)]
    public class GameObjectEventScriptableObject : TypeEventScriptableObject<GameObject>
    {

    }
}