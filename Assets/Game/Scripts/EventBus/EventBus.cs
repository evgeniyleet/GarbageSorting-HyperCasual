using UnityEngine;
using UnityEngine.Events;

namespace GarbageSorting
{
    [CreateAssetMenu(fileName = "EventBus", menuName = "Create EventBus")]
    public class EventBus : ScriptableObject
    {
        public UnityEvent OnInvoke;
    }
}
