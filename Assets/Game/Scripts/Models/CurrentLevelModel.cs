using System;
using UnityEngine;

namespace GarbageSorting
{
    [Serializable]
    public class CurrentLevelModel : Model
    {
        [SerializeField] protected int _number;
        [NonSerialized] public GameObject currentLevel;

        public int Number
        {
            get => _number;
            set => _number = value;
        }
    }
}
