using UnityEngine;
using UnityEngine.Events;

namespace GarbageSorting
{
    public class ScoreHandler : MonoBehaviour
    {
        [SerializeField] private GetterParameters[] _getters;

        public UnityEvent onFull;
        private void Start()
        {
            if (_getters == null)
            {
                Debug.LogError("Getters is null");
                return;
            }

            foreach (var getter in _getters)
            {
                getter.trashCanGetter.SetCount(getter.targetCount);
                getter.trashCanGetter.onCountChanged.AddListener(OnCountChanged);
            }
        }

        private void OnDestroy()
        {
            foreach (var getter in _getters)
            {
                getter.trashCanGetter.onCountChanged.RemoveListener(OnCountChanged);
            }
        }
        private void OnCountChanged(TrashCanGetter trashCanGetter)
        {
            for (int i = 0; i < _getters.Length; i++)
            {
                ref var item = ref _getters[i];

                if (item.trashCanGetter != trashCanGetter)
                {
                    continue;
                }

                item.count++;
            }

            bool full = true;

            foreach (GetterParameters item in _getters)
            {
                if (item.count < item.targetCount)
                {
                    full = false;

                    break;
                }
            }

            if (full)
            {
                Debug.Log("win");
                onFull.Invoke();
            }
        }
    }

    [System.Serializable]
    public struct GetterParameters
    {
        public TrashCanGetter trashCanGetter;
        public int targetCount;
        [HideInInspector] public int count;
    }
}
