using UnityEngine;

namespace GarbageSorting
{
    public class PlayerScriptableModelProvider : MonoBehaviour
    {
        [SerializeField] protected PlayerScriptableModel _playerScriptableModel;

        public PlayerScriptableModel PlayerScriptableModel => _playerScriptableModel;

        public void StepToNextLevel()
        {
            _playerScriptableModel.NextLevel();
        }
    }
}
