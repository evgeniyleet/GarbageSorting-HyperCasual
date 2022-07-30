using UnityEngine;

namespace GarbageSorting
{
    public class FirstLevel : MonoBehaviour
    {
        [SerializeField] private GameObject Level;
        GameObject currentLevel;

        private void Start()
        {

            Debug.Log("start level");
            currentLevel = Instantiate(Level);

        }

        public void deleteObj()
        {
            Destroy(currentLevel);
        }
    }
}
