using UnityEngine;

namespace GarbageSorting
{
    [CreateAssetMenu(fileName = "PlayerScriptableModel", menuName = "Create PlayerScriptableModel", order = 1)]
    public class PlayerScriptableModel : ScriptableModel<PlayerModel>
    {
        public bool NextLevel()
        {
            if (Model.CurrentLevel + 1 > 4)
            {
                return false;
            }

            Model.CurrentLevel++;

            return true;
        }
    }
}
