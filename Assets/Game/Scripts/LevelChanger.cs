using UnityEngine;

namespace GarbageSorting
{
    public class LevelChanger : MonoBehaviour
    {

        //[SerializeField] private GameObject nextLevel;
        //[SerializeField] private GameObject currentLevel;
        [SerializeField] private LevelCollectionScriptableModel _levelCollectionScriptableModel;
        [SerializeField] private CurrentLevelScriptableModel _currentLevelScriptableModel;
        public void initLevel()
        {
            Debug.Log("start level");
            _currentLevelScriptableModel.Model.currentLevel = Instantiate(_levelCollectionScriptableModel.Model.LevelPrefabs[_currentLevelScriptableModel.Model.Number]);
        }
        public void startNextLevel()
        {

            Destroy(_currentLevelScriptableModel.Model.currentLevel);
            Debug.Log("next level");

            _currentLevelScriptableModel.Model.Number++;
            if (_currentLevelScriptableModel.Model.Number >= _levelCollectionScriptableModel.Model.LevelPrefabs.Count)
            {
                _currentLevelScriptableModel.Model.Number = 0;
            }
            _currentLevelScriptableModel.Model.currentLevel = Instantiate(_levelCollectionScriptableModel.Model.LevelPrefabs[_currentLevelScriptableModel.Model.Number]);
            //currentLevel = Instantiate(nextLevel);
        }


    }
}
