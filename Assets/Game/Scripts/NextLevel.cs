using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarbageSorting
{
    public class NextLevel : MonoBehaviour
    {
        private LevelChanger levelChanger;

        /*private void Start() {
            levelChanger = 
        }*/
        public void NextLevelLaunch()
        {
            levelChanger.startNextLevel();
        }

    }
}
