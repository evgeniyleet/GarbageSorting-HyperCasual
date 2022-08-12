using UnityEngine;
using UnityEngine.SceneManagement;

namespace GarbageSorting
{
    public class SceneChanger : MonoBehaviour
    {
        private void Start()
        {
            var level = PlayerPrefs.GetInt("Level", 0);
            var ind = SceneManager.GetActiveScene().buildIndex;

            if (level != ind)
            {
                Debug.Log("LOADING SCENE " + level);
                LoadLevel(level);
            }
        }

        public void LoadLevel(int levelInd)
        {
            var ind = SceneManager.GetActiveScene().buildIndex;
            var sceneCount = SceneManager.sceneCountInBuildSettings;
            var nextLevel = (levelInd) % sceneCount;
            SceneManager.LoadScene(nextLevel);
        }
        public void LoadNextLevel()
        {
            var ind = SceneManager.GetActiveScene().buildIndex;
            var sceneCount = SceneManager.sceneCountInBuildSettings;
            var nextLevel = (ind + 1) % sceneCount;
            PlayerPrefs.SetInt("Level", nextLevel);
            SceneManager.LoadScene(nextLevel);

        }
        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }
}
