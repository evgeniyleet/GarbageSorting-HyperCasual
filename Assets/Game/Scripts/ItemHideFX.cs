using UnityEngine;

namespace GarbageSorting
{
    public class ItemHideFX : MonoBehaviour
    {
        [SerializeField] private GameObject _hideFxPrefab;
        public void Hide()
        {
            Instantiate(_hideFxPrefab, transform.position, Quaternion.identity, null);
            Destroy(this.gameObject);
        }
    }
}
