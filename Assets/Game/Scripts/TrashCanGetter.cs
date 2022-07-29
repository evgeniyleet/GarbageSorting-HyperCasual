using UnityEngine;
using UnityEngine.Events;

namespace GarbageSorting
{
    public class TrashCanGetter : MonoBehaviour
    {
        [SerializeField] private TrashType _type;
        private DragItem _item;
        private int targetCount = 1;
        private int count = 0;
        private bool active = true;

        public UnityEvent<TrashCanGetter> onCountChanged;
        public void SetCount(int value)
        {
            targetCount = value;
            if (count >= targetCount)
            {
                active = false;
            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (!active) return;
            var item = other.attachedRigidbody.GetComponent<DragItem>();
            if (item.isDraggable && item != null) //item != null : когда айтем может быть налом, если айтем это всегда объект, который вошел в триггер???? 
            {
                _item = item;
                return;
            }

            if (!item.isDraggable && _item == item)
            {
                TryGetItem();
                _item = null;
                return;
            }

        }

        private void TryGetItem()
        {
            if (_item.Type == _type)
            {
                Destroy(_item.gameObject);
                count++;

                onCountChanged.Invoke(this);
            }
            if (count >= targetCount)
            {
                active = false;
            }
        }
    }
}
