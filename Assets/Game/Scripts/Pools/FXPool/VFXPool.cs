using System.Collections.Generic;
using UnityEngine;

namespace GarbageSorting
{
    [CreateAssetMenu(fileName = "VFXPool", menuName = "Game/VFXPool", order = 1)]
    public class VFXPool : ScriptableObject
    {
        [SerializeField] private int _size = 5;
        [SerializeField] private GameObject _vfxPrefab;

        private List<VFXPoolItem> _items;
        private Queue<VFXPoolItem> _queue;

        private bool _poolIsInitialized = false;

        public void InitializePool()
        {
            if (_poolIsInitialized)
            {
                return;
            }


            _items = new List<VFXPoolItem>(_size);
            _queue = new Queue<VFXPoolItem>();

            for (int i = 0; i < _size; i++)
            {
                CreateItem();
            }

            _poolIsInitialized = true;
        }
        public void ResetPool()
        {

            _poolIsInitialized = false;

            _items.ForEach(item =>
            {
                if (item != null && item.gameObject != null)
                {
                    Destroy(item);
                }
            });

            _items?.Clear();
            _queue?.Clear();


        }
        public VFXPoolItem GetFromPool()
        {
            if (_queue.Count == 0)
            {
                ExpandPool();
            }

            VFXPoolItem vfxPoolItem = _queue.Dequeue();

            vfxPoolItem.OnGetFromPool();

            return vfxPoolItem;
        }

        public void ReturnToPool(VFXPoolItem item)
        {
            _queue.Enqueue(item);
        }

        protected void ExpandPool()
        {
            for (int i = 0; i < _size; i++)
            {
                CreateItem();
            }
        }

        protected VFXPoolItem CreateItem()
        {
            GameObject ItemInstance = Instantiate(_vfxPrefab);
            ItemInstance.SetActive(false);

            VFXPoolItem vfxPoolItem = ItemInstance.GetComponent<VFXPoolItem>();
            vfxPoolItem.Pool = this;
            _items.Add(vfxPoolItem);
            _queue.Enqueue(vfxPoolItem);

            return vfxPoolItem;
        }

    }
}
