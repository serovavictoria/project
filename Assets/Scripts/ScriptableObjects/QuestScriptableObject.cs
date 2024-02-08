using System;
using System.Linq;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "NewQuest", menuName = "ScriptableObjects/Quest", order = 1)]
    public class QuestScriptableObject : ScriptableObject
    {
        [SerializeField]
        private String questDesc;
        public String QuestDesc { get { return questDesc; } }

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

        [SerializeField]
        private QuestScriptableObject[] requiredCompletedQuests;

        public bool CanCompleteQuest
        {
            get
            {
                if (requiredCompletedQuests == null || requiredCompletedQuests.Length == 0) return true;

                return requiredCompletedQuests.All(quest => quest.IsComplete);
            }
        }

        private void OnEnable()
        {
            IsComplete = false;
        }
    }
}
