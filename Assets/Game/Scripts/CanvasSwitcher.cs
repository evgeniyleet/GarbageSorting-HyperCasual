using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarbageSorting
{
    public class CanvasSwitcher : MonoBehaviour
    {
        [SerializeField] private GameObject _menuCanvas;
        [SerializeField] private GameObject _playCanvas;
        [SerializeField] private GameObject _winCanvas;
        [SerializeField] private GameObject _loseCanvas;

        public void togglePlay()
        {
            _menuCanvas.SetActive(false);
            _playCanvas.SetActive(true);
        }
        public void toggleWin()
        {
            _playCanvas.SetActive(false);
            _winCanvas.SetActive(true);
        }
        public void toggleLose()
        {
            _playCanvas.SetActive(false);
            _loseCanvas.SetActive(true);
        }
    }
}
