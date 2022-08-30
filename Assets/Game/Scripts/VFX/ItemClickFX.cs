using UnityEngine;
using UnityEngine.EventSystems;

namespace GarbageSorting
{
    public class ItemClickFX : MonoBehaviour, IPointerDownHandler
    {
        //[SerializeField] private GameObject _circleClickFxPrefab;
        [SerializeField] private VFXPoolProvider _vfxPoolProvider;


        public void OnPointerDown(PointerEventData eventData)
        {
            //Instantiate(_circleClickFxPrefab, transform.position, Quaternion.identity, null);
            VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();
        }
    }
}
