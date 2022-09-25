using UnityEngine;

namespace GarbageSorting
{
    [System.Serializable]
    public class PlayerModel : Model
    {
        [SerializeField] protected string _playerName;
        [SerializeField] protected int _currentLevel;

        public string PlayerName
        {
            get => _playerName;
            set
            {
                _playerName = value;
            }
        }

        public int CurrentLevel
        {
            get => _currentLevel;
            set
            {
                if (value > 4)
                {
                    value = 1;
                }
                _currentLevel = value;
            }
        }

    }
}
