using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GarbageSorting
{
    public class LevelChanger : MonoBehaviour
    {

        [SerializeField] private GameObject nextLevel;
        [SerializeField] private GameObject currentLevel;
        [SerializeField] private Camera uiCamera;
        public void initLevel()
        {
            Debug.Log("start level");
            currentLevel = Instantiate(nextLevel);
            uiCamera.gameObject.SetActive(false);
        }
        public void startNextLevel()
        {
            Destroy(currentLevel);
            Debug.Log("next level");
            currentLevel = Instantiate(nextLevel);
        }


    }
}
