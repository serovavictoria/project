using System;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "NewQuest", menuName = "ScriptableObjects/Quest", order = 1)]
    public class QuestScriptableObject : ScriptableObject
    {
        [SerializeField]
        private Sprite imageDescription;
        public Sprite ImageDescription { get { return imageDescription; } }

        [SerializeField]
        private Sprite clue;
        public Sprite Clue { get {  return clue; } }

        [SerializeField]
        private String rightAnswer;
        public String RightAnswer { get { return rightAnswer; } }

        public bool IsComplete { get; set; }

        private void OnEnable()
        {
            IsComplete = false;
        }
    }
}
