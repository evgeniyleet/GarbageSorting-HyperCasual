using UnityEngine;
using UnityEngine.EventSystems;

namespace GarbageSorting
{
    public class ItemTrail : MonoBehaviour, IBeginDragHandler, IEndDragHandler
    {
        [SerializeField] private TrailRenderer _trailRenderer;

        private void Awake()
        {
            _trailRenderer.emitting = false;
        }
        public void OnBeginDrag(PointerEventData eventData)
        {
            _trailRenderer.emitting = true;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _trailRenderer.emitting = false;
        }
    }
}
