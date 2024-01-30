using System;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "NewQuest", menuName = "ScriptableObjects/Quest", order = 1)]
    internal class QuestScriptableObject : ScriptableObject
    {
        [SerializeField]
        private new String name;

        [SerializeField]
        private String description;

        [SerializeField]
        private Sprite imageDescription;

        [SerializeField]
        private String questGiver;

        [SerializeField]
        private String rightAnswer;
    }
}
