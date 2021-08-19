using UnityEngine;

namespace ShitStain
{
    public class Loader
    {
        public static GameObject gameObject;
        public static void Load()
        {
            gameObject = new GameObject();
            gameObject.AddComponent<Main>();
            Object.DontDestroyOnLoad(gameObject);
        }

        public static void Unload()
        {
            Object.Destroy(gameObject);
        }
    }
}
