using UnityEngine;
using UnityEngine.UI;

namespace B2B.Data
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Picture")]
    public class Picture : ScriptableObject
    {
        public Sprite Artwork;
        public string Author;
        public string Date;
        [TextArea(10, 20)]
        public string Description;
    }
}
