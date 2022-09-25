using System;
using UnityEngine;
using UnityEngine.Events;

namespace GarbageSorting
{
    public class EventBusProvider : MonoBehaviour
    {
        [SerializeField] protected EventBus _eventBus;
        public UnityEvent OnInvoke;

        public EventBus EventBus => _eventBus;

        private void OnEnable()
        {
            EventBus.OnInvoke.AddListener(OnInvokeListener);
        }

        private void OnDisable()
        {
            EventBus.OnInvoke.RemoveListener(OnInvokeListener);
        }

        protected void OnInvokeListener()
        {
            OnInvoke.Invoke();
        }

        public void CallEventBusInvoke()
        {
            EventBus.OnInvoke.Invoke();
        }
    }
}
