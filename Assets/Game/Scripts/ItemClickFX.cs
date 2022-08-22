using UnityEngine;
using UnityEngine.EventSystems;

namespace GarbageSorting
{
    public class ItemClickFX : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _circleClickFxPrefab;

        public void OnPointerDown(PointerEventData eventData)
        {
            Instantiate(_circleClickFxPrefab, transform.position, Quaternion.identity, null);
        }
    }
}
