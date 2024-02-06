using Scripts;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class QuestWindow : AbstractWindowUI
    {
        [SerializeField]
        private Button sendingAnswerButton;

        private QuestScriptableObject quest;

        public bool HasQuest { get { return quest != null; } }

        public bool IsQuestComplete { get { return quest.IsComplete; } }

        public event Action OnSendAnswer;

        private void Start()
        {
            sendingAnswerButton.onClick.AddListener(OnSendAnswer.Invoke);
        }

        public void LoadQuest(QuestScriptableObject obj)
        {
            quest = obj;
        }
    }
}