using Scripts;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class QuestWindow : AbstractWindowUI
    {
        [SerializeField]
        private Image questImage;

        [SerializeField]
        private ClueWindow clueWindow;

        [SerializeField]
        private Button sendingAnswerButton;

        [SerializeField]
        private TMP_InputField inputField;


        private QuestScriptableObject quest;

        public bool HasQuest { get { return quest != null; } }

        public bool IsQuestComplete { get { return quest.IsComplete; } }

        public event Action OnSendAnswer;

        private void Start()
        {
            sendingAnswerButton.onClick.AddListener(OnSendAnswer.Invoke);
        }

        public override void OpenWindow()
        {
            base.OpenWindow();
            questImage.sprite = quest.ImageDescription;
            clueWindow.LoadClueImage(quest.Clue);
        }

        public void CheckAnswer()
        {
            if (inputField.text == quest.RightAnswer)
            {
                quest.IsComplete = true;
                inputField.text = "";
                //TODO: добавить увеличение оценки
                CloseWindow();
            }
        }

        public void LoadQuest(QuestScriptableObject obj)
        {
            quest = obj;
        }
    }
}