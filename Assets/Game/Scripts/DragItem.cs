using UnityEngine;
using UnityEngine.EventSystems;

namespace GarbageSorting
{
    public class DragItem : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        //[SerializeField] private float upForce = 50f;
        private Rigidbody _rigidbody;
        public bool isDraggable { get; private set; }
        [SerializeField] private TrashType _type;
        public TrashType Type { get => _type; }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (!isDraggable) return;
            if (!eventData.pointerCurrentRaycast.isValid)
            {
                _rigidbody.isKinematic = false;
                isDraggable = false;
                return;
            }
            var pos = eventData.pointerCurrentRaycast.worldPosition;
            var delta = pos - transform.position;
            delta.y = 0;
            //Debug.Log(pos);
            transform.position += delta;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _rigidbody.isKinematic = true;
            isDraggable = true;
            transform.position += Vector3.up * 1.5f;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (!isDraggable) return;
            _rigidbody.isKinematic = false;
            //_rigidbody.transform.position += Vector3.up * 5;
            //_rigidbody.AddForce(Vector3.up * upForce);
            isDraggable = false;
        }
    }
}
