using System;
using System.Collections.Generic;
using UnityEngine;

namespace GarbageSorting
{
    [Serializable]
    public class LevelCollectionModel : Model
    {
        [SerializeField] private List<GameObject> _levelPrefabs;

        public List<GameObject> LevelPrefabs => _levelPrefabs;
    }
}

