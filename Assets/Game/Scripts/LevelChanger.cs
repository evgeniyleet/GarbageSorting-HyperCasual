using UnityEngine;

namespace GarbageSorting
{
    public class LevelChanger : MonoBehaviour
    {

        [SerializeField] private GameObject nextLevel;
        [SerializeField] private GameObject currentLevel;

        public void initLevel()
        {
            Debug.Log("start level");
            currentLevel = Instantiate(nextLevel);
        }
        public void startNextLevel()
        {
            Destroy(currentLevel);
            Debug.Log("next level");
            currentLevel = Instantiate(nextLevel);
        }


    }
}
