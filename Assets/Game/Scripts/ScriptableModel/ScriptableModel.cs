using UnityEngine;
using System.IO;

namespace GarbageSorting
{
    public class ScriptableModel<TModel> : ScriptableObject where TModel : Model, new()
    {
        [SerializeField] protected TModel _model;

        public TModel Model
        {
            get => _model;
            set
            {
                _model = value;
            }
        }
        public bool Load()
        {
            if (File.Exists(GetStoragePath(name)) == false)
            {
                return false;
            }

            TModel model = new TModel();
            string text = File.ReadAllText(GetStoragePath(name));
            JsonUtility.FromJsonOverwrite(text, model);

            Model = model;

            return true;
        }
        public bool Save()
        {
            return true;
        }
        protected static string GetStoragePath(string name)
        {
            return Application.persistentDataPath + Path.DirectorySeparatorChar + name + ".json";
        }
    }
}
