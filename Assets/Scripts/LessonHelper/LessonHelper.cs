using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code
{
    public sealed class LessonHelper : MonoBehaviour
    {
        [SerializeField]
        private CharacterData[] characterDatas;
        [SerializeField] private CharacterSelector characterSelector;



        [ContextMenu("Show")]
        public void Show()
        {
            characterSelector.Initialize(characterDatas.Select(c=> new CharacterModel(c)).ToList());
        }
    }
}
