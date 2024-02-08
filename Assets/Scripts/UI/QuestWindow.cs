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
        private TMP_Text questDesc;

        [Space]

        [SerializeField]
        private ClueWindow clueWindow;

        [SerializeField]
        private СonfirmationWindow confirmationWindow;

        [SerializeField] 
        private ErrorWindow errorWindow;

        [Space]

        [SerializeField]
        private Button sendingAnswerButton;

        [SerializeField]
        private Button clueButton;

        [Space]

        [SerializeField]
        private TMP_InputField inputField;

        [Space]

        [SerializeField]
        private AssessmentController assessmentController;


        private QuestScriptableObject quest;

        private float assessment = 1;


        public bool HasQuest { get { return quest != null; } }

        public bool IsQuestComplete { get { return quest.IsComplete; } }

        public event Action OnSendAnswer;

        private void Start()
        {
            sendingAnswerButton.onClick.AddListener(OnSendAnswer.Invoke);

            clueButton.onClick.AddListener(() =>
            {
                if (clueWindow.isOpenedClue)
                {
                    clueWindow.OpenWindow();
                }
                else
                {
                    confirmationWindow.OpenWindow();
                }
            });
        }

        public override void OpenWindow()
        {
            base.OpenWindow();
            questImage.sprite = quest.ImageDescription;
            clueWindow.LoadClueImage(quest.Clue);
            questDesc.text = quest.QuestDesc;
        }

        public void OpenClueWindow()
        {
            clueWindow.isOpenedClue = true;
            assessment = 0.5f;
        }

        public void CheckAnswer()
        {
            if (inputField.text == quest.RightAnswer)
            {
                quest.IsComplete = true;
                inputField.text = "";

                PlayerPrefs.SetFloat("assessment", PlayerPrefs.GetFloat("assessment") + assessment);
                assessmentController.UpdateAssessment();

                clueWindow.isOpenedClue = false;
                assessment = 1;


                CloseWindow();
            }
            else
            {
                errorWindow.OpenWindow();
            }
        }

        public void LoadQuest(QuestScriptableObject obj)
        {
            quest = obj;
        }
    }
}