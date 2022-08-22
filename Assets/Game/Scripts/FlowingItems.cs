using UnityEngine;
using UnityEngine.EventSystems;

namespace GarbageSorting
{
    public class FlowingItems : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private float speed;
        public bool isDraggable { get; private set; }
        [SerializeField] private Transform _endPoint;
        private void FixedUpdate()
        {
            if (!isDraggable)
            {
                Vector3 target = _endPoint.position;
                Vector3 _item = transform.position;
                transform.position = Vector3.MoveTowards(_item, target, speed);
            }

        }

        public void OnPointerDown(PointerEventData eventData)
        {
            isDraggable = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (!isDraggable) return;
            isDraggable = false;
        }
    }

}
